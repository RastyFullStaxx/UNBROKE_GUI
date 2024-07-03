using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using UNBROKE_GUI.Enums;
using static UNBROKE_GUI.DatabaseHelper;
using UNBROKE_GUI.Managers;
using System.Drawing; // Add this directive for Point

namespace UNBROKE_GUI
{
    public partial class Budget_Wizard_Result_Expense_Tab : Form
    {
        private string currentuser;
        DatabaseHelper db = DatabaseHelper.GetInstance();

        private Timer timer;
        private ProgressManager progressBarManager;

        public Budget_Wizard_Result_Expense_Tab(string currentuser)
        {
            InitializeComponent();
            this.currentuser = currentuser;

            InitializeProgressBars();

            needsProgressBar.Maximum = 100;
            wantsProgressBar.Maximum = 100; // Assuming you have a wants progress bar
            savingsProgressBar.Maximum = 100;

            timer = new Timer();
            timer.Interval = 10; // Interval in milliseconds
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void InitializeProgressBars()
        {
            progressBarManager = new ProgressManager(needsProgressBar, wantsProgressBar, savingsProgressBar);
            progressBarManager.InitializeTargets(50, 30, 20); // Set initial targets
            progressBarManager.SetMaximumValues(); // Set maximum values for progress bars
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void Budget_Wizard_Result_Load(object sender, EventArgs e)
        {
            FetchBudgetDetails();
            FetchAndDisplayExpenses();
            SetLabelPositionsAndMargins();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentuser);
            dashboard.Show();
            this.Dispose();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Dashboard_Profile_Section profile = new Dashboard_Profile_Section(currentuser);
            profile.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Budget_Wizard_Result_Savings_Tab budget_Wizard_Result_Savings_Tab = new Budget_Wizard_Result_Savings_Tab(currentuser);
            budget_Wizard_Result_Savings_Tab.Show();
            this.Dispose();
        }

        private void DisplayBudgetDetails(decimal totalBudget, DateTime startDate, DateTime endDate)
        {
            // Format totalBudget as ₱5,700.00
            string formattedBudget = $"₱{totalBudget:N2}";

            // Set values to UI components
            lblTotalBudgetAmountDisplay.Text = formattedBudget;
            lblStartDateDisplay.Text = startDate.ToString("yyyy-MM-dd");
            lblEndDateDisplay.Text = endDate.ToString("yyyy-MM-dd");
        }

        private void FetchBudgetDetails()
        {
            // Fetch total_budget, start_date, end_date from database
            int userId = db.GetUserIdByUsername(currentuser);
            if (userId != -1)
            {
                decimal totalBudget = db.GetTotalBudgetByID(userId);
                DateTime startDate = db.GetStartDateByUserID(userId);
                DateTime endDate = db.GetEndDateByUserID(userId);

                // Display fetched data
                DisplayBudgetDetails(totalBudget, startDate, endDate);
            }
            else
            {
                MessageBox.Show("User not found in database.");
            }
        }

        private void FetchAndDisplayExpenses()
        {
            int userId = db.GetUserIdByUsername(currentuser);
            if (userId != -1)
            {
                int highestBudgetId = db.GetHighestBudgetIdByUserId(userId);
                if (highestBudgetId != -1)
                {
                    List<Expense> expenses = db.GetExpensesByBudgetId(highestBudgetId);
                    SetExpenseLabels(expenses);
                }
                else
                {
                    MessageBox.Show("No budget found for user.");
                }
            }
            else
            {
                MessageBox.Show("User not found in database.");
            }
        }

        private void SetExpenseLabels(List<Expense> expenses)
        {
            // Initialize sums
            decimal totalFixed = 0m;
            decimal totalNeeds = 0m;
            decimal totalWants = 0m;

            decimal foodAmount = 0m;
            decimal rentAmount = 0m;

            decimal billsAmount = 0m;
            decimal transportationAmount = 0m;
            decimal suppliesAmount = 0m;
            decimal othersAmount = 0m;

            decimal entertainmentAmount = 0m;
            decimal clothingAmount = 0m;

            // Aggregate expenses
            foreach (var expense in expenses)
            {
                switch (expense.Category)
                {
                    case ExpenseCategory.Fix:
                        if (expense.Subcategory == ExpenseSubCategory.Food)
                        {
                            foodAmount += expense.Amount;
                        }
                        else if (expense.Subcategory == ExpenseSubCategory.Rent)
                        {
                            rentAmount += expense.Amount;
                        }
                        totalFixed += expense.Amount;
                        break;

                    case ExpenseCategory.Needs:
                        if (expense.Subcategory == ExpenseSubCategory.Bills)
                        {
                            billsAmount += expense.Amount;
                        }
                        else if (expense.Subcategory == ExpenseSubCategory.Transportation)
                        {
                            transportationAmount += expense.Amount;
                        }
                        else if (expense.Subcategory == ExpenseSubCategory.Supplies)
                        {
                            suppliesAmount += expense.Amount;
                        }
                        else if (expense.Subcategory == ExpenseSubCategory.Others)
                        {
                            othersAmount += expense.Amount;
                        }
                        totalNeeds += expense.Amount;
                        break;

                    case ExpenseCategory.Wants:
                        if (expense.Subcategory == ExpenseSubCategory.Entertainment)
                        {
                            entertainmentAmount += expense.Amount;
                        }
                        else if (expense.Subcategory == ExpenseSubCategory.Clothing)
                        {
                            clothingAmount += expense.Amount;
                        }
                        totalWants += expense.Amount;
                        break;
                }
            }

            // Set label values
            lblDisplayTotalFixedExpenseAmountDisplay.Text = FormatCurrency(totalFixed);
            lblFoodAmountDisplay.Text = FormatCurrency(foodAmount);
            lblRentAmountDisplay.Text = FormatCurrency(rentAmount);

            lblDisplayTotalNeedsExpenseDisplay.Text = FormatCurrency(totalNeeds);
            lblBillsAmountDisplay.Text = FormatCurrency(billsAmount);
            lblTransportationAmountDisplay.Text = FormatCurrency(transportationAmount);
            lblSuppliesAmountDisplay.Text = FormatCurrency(suppliesAmount);
            lblOthersAmountDisplay.Text = FormatCurrency(othersAmount);

            lblTotalWantsAmountDisplay.Text = FormatCurrency(totalWants);
            lblEntertainmentAmountDisplay.Text = FormatCurrency(entertainmentAmount);
            lblClothingAmountDisplay.Text = FormatCurrency(clothingAmount);
        }

        private string FormatCurrency(decimal amount)
        {
            return string.Format(CultureInfo.GetCultureInfo("en-PH"), "₱{0:N2}", amount);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update progress bars through the ProgressBarManager
            progressBarManager.UpdateProgress();

            // Check if all progress bars have reached their targets to stop the timer
            if (progressBarManager.AllProgressReachedTargets())
            {
                timer.Stop();
            }
        }

        private void SetLabelPositionsAndMargins()
        {
            // Set the locations of the labels
            lblDisplayTotalFixedExpenseAmountDisplay.Location = new Point(192, 19);
            lblFoodAmountDisplay.Location = new Point(247, 59);
            lblRentAmountDisplay.Location = new Point(247, 101);

            lblDisplayTotalNeedsExpenseDisplay.Location = new Point(193, 178);
            lblBillsAmountDisplay.Location = new Point(247, 218);
            lblTransportationAmountDisplay.Location = new Point(247, 260);
            lblSuppliesAmountDisplay.Location = new Point(247, 302);
            lblOthersAmountDisplay.Location = new Point(247, 342);

            lblTotalWantsAmountDisplay.Location = new Point(193, 416);
            lblEntertainmentAmountDisplay.Location = new Point(247, 456);
            lblClothingAmountDisplay.Location = new Point(247, 498);

            // Set the margins of the labels
            Padding labelMargin = new Padding(3, 0, 3, 0);
            lblDisplayTotalFixedExpenseAmountDisplay.Margin = labelMargin;
            lblFoodAmountDisplay.Margin = labelMargin;
            lblRentAmountDisplay.Margin = labelMargin;

            lblDisplayTotalNeedsExpenseDisplay.Margin = labelMargin;
            lblBillsAmountDisplay.Margin = labelMargin;
            lblTransportationAmountDisplay.Margin = labelMargin;
            lblSuppliesAmountDisplay.Margin = labelMargin;
            lblOthersAmountDisplay.Margin = labelMargin;

            lblTotalWantsAmountDisplay.Margin = labelMargin;
            lblEntertainmentAmountDisplay.Margin = labelMargin;
            lblClothingAmountDisplay.Margin = labelMargin;
        }
    }
}
