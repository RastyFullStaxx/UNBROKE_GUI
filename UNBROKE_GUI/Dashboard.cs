using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNBROKE_GUI.Enums;
using UNBROKE_GUI.Managers;

namespace UNBROKE_GUI
{
    public partial class Dashboard : Form
    {
        DatabaseHelper db = DatabaseHelper.GetInstance();

        private string currentuser;
        private decimal numberofBudget;
        private int userID;

        private bool panel3Expand = false;
        private bool panel4Expand = false;
        private bool panel5Expand = false;
        private bool panel6Expand = false;

        private const int targetExpandedHeight = 246;
        private const int targetCollapsedHeight = 94;
        private const int step = 100; // Adjust the step value for smoother transition



        public Dashboard(string currentuser)
        {
            InitializeComponent();
            this.currentuser = currentuser;

            // Update lblDate with current month and year
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("MMMM yyyy");
            lblDate.Text = formattedDate;


            userID = db.GetUserIdByUsername(currentuser);
            numberofBudget = db.CountTotalBudgetsByUserID(userID);


            LoadPanelData();


        }



        private void priorityPanel_Click(object sender, EventArgs e)
        {
            Budget_Wizard_Result_Expense_Tab budgetExpense = new Budget_Wizard_Result_Expense_Tab(currentuser);
            budgetExpense.Show();
            this.Dispose();
        }

        //This method uses timer component to slide down the options in the dashboard; borrow, return, reserve, penalty form, borrower list


        private void btnProfile_Click(object sender, EventArgs e)
        {
            Dashboard_Profile_Section dashboard_Profile_Section = new Dashboard_Profile_Section(currentuser);
            dashboard_Profile_Section.Show();
            this.Dispose();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Register click event for panel3
            panel3.Click += panel3_Click;
            panel4.Click += panel4_Click;
            panel5.Click += panel5_Click;
            panel6.Click += panel6_Click;


            // Initialize panel transition timer
            InitializePanelPositions();

            DefaultLayout(userID);

            priorityPanel.Click += new EventHandler(priorityPanel_Click);

            LoadUserData();
        }
        private void LoadUserData()
        {
            DatabaseHelper db = DatabaseHelper.GetInstance();

            try
            {
                // Debug statement to check currentuser before fetching userId
                Console.WriteLine($"Current user in LoadUserData: {currentuser}");

                // Get user ID using current username
                int userId = db.GetUserIdByUsername(currentuser);

                if (userId != -1)
                {
                    // Get total budget
                    decimal totalBudget = db.GetTotalBudgetByID(userId);

                    // Display total budget in the format ₱0.00
                    lblTotalBalanceAmount.Text = $"₱{totalBudget.ToString("0.00")}"; // Formatting totalBudget to 2 decimal places
                    lblHistoryTotalBudget.Text = $"₱{totalBudget.ToString("0.00")}";
                }
                else
                {
                    MessageBox.Show("User not found. Please log in again.");
                    // Example: Redirect to login form or handle this case accordingly

                    Form2 loginForm = new Form2();
                    loginForm.Show();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching user profile: {ex.Message}");
                // Handle exception as needed
            }
        }

        private void btnBudgetWizard2_Click(object sender, EventArgs e)
        {
                Budget_Wizard_Date budget_Wizard_Date = new Budget_Wizard_Date(currentuser);
                budget_Wizard_Date.Show();
                this.Dispose();

        }

        private void txtTransactionTitle_Click(object sender, EventArgs e)
        {

        }

        private void DefaultLayout(int userId)
        {
            DateTime startDate = db.GetStartDateByUserID(userId);
            DateTime endDate = db.GetEndDateByUserID(userId);

            lblStartDateDisplay.Text = startDate.ToString("yyyy-MM-dd");
            lblEndDateDisplay.Text = endDate.ToString("yyyy-MM-dd");
            if (numberofBudget == 1)
            {
                link_lblBudgetWizard.Visible = false;
                imgNotificationIcon.Visible = false;    
                btnBudgetWizard1.Visible = false;
                youdonthaveLabel.Visible = false;
                priorityPanel.Visible = true;
                mainPanel.Visible = false;

            }else if( numberofBudget ==2)
            {
                link_lblBudgetWizard.Visible = false;
                imgNotificationIcon.Visible = false;
                btnBudgetWizard1.Visible = false;
                youdonthaveLabel.Visible = false;
                priorityPanel.Visible = true;
                mainPanel.Visible = true;
                panel3.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;

            }
            else if (numberofBudget == 3)
            {
                link_lblBudgetWizard.Visible = false;
                imgNotificationIcon.Visible = false;
                btnBudgetWizard1.Visible = false;
                youdonthaveLabel.Visible = false;
                priorityPanel.Visible = true;
                mainPanel.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = false;
                panel6.Visible = false;

            }
            else if (numberofBudget == 4)
            {
                link_lblBudgetWizard.Visible = false;
                imgNotificationIcon.Visible = false;
                btnBudgetWizard1.Visible = false;
                youdonthaveLabel.Visible = false;
                priorityPanel.Visible = true;
                mainPanel.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = false;

            }
            else if (numberofBudget == 5)
            {
                link_lblBudgetWizard.Visible = false;
                imgNotificationIcon.Visible = false;
                btnBudgetWizard1.Visible = false;
                youdonthaveLabel.Visible = false;
                priorityPanel.Visible = true;
                mainPanel.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;

            }

            else 
            {
                link_lblBudgetWizard.Visible = true;
                imgNotificationIcon.Visible = true;
                btnBudgetWizard1.Visible = true;
                youdonthaveLabel.Visible = true;
                priorityPanel.Visible = false;
                priorityPanel.Visible = false;
                mainPanel.Visible = false;


            }
        }





        //FUNCTIONS FOR TRANSITION

        private void InitializePanelPositions()
        {
            // Initial positions of panels inside mainPanel
            panel4.Location = new Point(0, panel3.Bottom);
            panel5.Location = new Point(0, panel4.Bottom);
            panel6.Location = new Point(0, panel5.Bottom);

            // Add more panels if necessary
        }


        private void panel3_Click(object sender, EventArgs e)
        {
            // Toggle panel3 expansion
            panel3Expand = !panel3Expand;

            panel3Transition.Start();
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            // Toggle panel3 expansion
            panel4Expand = !panel4Expand;

            panel4Transition.Start();
        }
        private void panel5_Click(object sender, EventArgs e)
        {
            // Toggle panel3 expansion
            panel5Expand = !panel5Expand;

            panel5Transition.Start();
        }
        private void panel6_Click(object sender, EventArgs e)
        {
            // Toggle panel3 expansion
            panel6Expand = !panel6Expand;

            panel6Transition.Start();
        }


        private void panel1Transition_Tick(object sender, EventArgs e)
        {
            AdjustPanelHeight(panel3, panel3Expand);
        }

        private void AdjustPanelPositions()
        {
            // Adjust panel positions based on panel heights
            panel4.Location = new Point(panel4.Left, panel3.Bottom);
            panel5.Location = new Point(panel5.Left, panel4.Bottom);
            panel6.Location = new Point(panel6.Left, panel5.Bottom);
        }


        private void ActivateAutoScrollIfNeeded()
        {
            // Calculate total height of panels inside mainPanel
            int totalPanelHeight = panel6.Bottom; // Adjust based on the last panel position

            // Activate auto-scroll if total height exceeds mainPanel height
            mainPanel.AutoScroll = totalPanelHeight > mainPanel.Height;
        }

        private void link_lblBudgetWizard_LinkClicked(object sender, EventArgs e)
        {
            Budget_Wizard_Date budget_Wizard_Date = new Budget_Wizard_Date(currentuser);
            budget_Wizard_Date.Show();
            this.Dispose();
        }

        private void panel4TransitionClick_Tick(object sender, EventArgs e)
        {
            AdjustPanelHeight(panel4, panel4Expand);
        }

        private void panel5Transition_Tick(object sender, EventArgs e)
        {
            AdjustPanelHeight(panel5, panel5Expand);

        }

        private void panel6Transition_Tick(object sender, EventArgs e)
        {
            AdjustPanelHeight(panel6, panel6Expand);

        }
        private void AdjustPanelHeight(Panel panel, bool expand)
        {
            int currentHeight = panel.Height;

            if (!expand)
            {
                // Expanding panel
                panel.Height += step;
                if (panel.Height >= targetExpandedHeight)
                {
                    panel.Height = targetExpandedHeight;
                    StopPanelTransition(panel);
                }
            }
            else
            {
                // Collapsing panel
                panel.Height -= step;
                if (panel.Height <= targetCollapsedHeight)
                {
                    panel.Height = targetCollapsedHeight;
                    StopPanelTransition(panel);
                }
            }

            // Adjust positions of panels inside mainPanel
            AdjustPanelPositions();

            // Activate auto-scroll if necessary
            ActivateAutoScrollIfNeeded();
        }

        private void StopPanelTransition(Panel panel)
        {
            // Stop the corresponding transition timer
            if (panel == panel3)
                panel3Transition.Stop();
            else if (panel == panel4)
                panel4Transition.Stop();
            else if (panel == panel5)
                panel5Transition.Stop();
            else if (panel == panel6)
                panel6Transition.Stop();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void LoadPanelData()
        {
            try
            {
                // Get top budget IDs starting from the second highest (skip=1, take=4)
                List<int> budgetIds = db.GetTopBudgetIdsByUserId(userID, 1, 4);

                // Display data on the respective panels
                if (budgetIds.Count > 0)
                {
                    // Panel 3
                    DisplayBudgetDetails(panel3, budgetIds[0]);
                    SetBudgetDetails(panel3, budgetIds[0], "lblTotalBudgetPanel3", "lblStartDatePanel3", "lblEndDatePanel3");
                    SetExpenses(panel3, budgetIds[0], "lblFoodAmountPanel3", "lblRentAmountPanel3", "lblBillsAmountPanel3", "lblTransportationAmountPanel3", "lblSuppliesAmountPanel3", "lblOthersAmountPanel3", "lblEntertainmentAmountPanel3", "lblClothingAmountPanel3", "lblSavingsPanel3");

                    // Calculate and set total expenses labels for panel 3
                    Label lblTotalFixedExpensesPanel3 = panel3.Controls.Find("lblTotalFixedExpensesPanel3", true).FirstOrDefault() as Label;
                    Label lblTotalNeedsExpensesPanel3 = panel3.Controls.Find("lblTotalNeedsExpensesPanel3", true).FirstOrDefault() as Label;
                    Label lblTotalWantsExpensesPanel3 = panel3.Controls.Find("lblTotalWantsExpensesPanel3", true).FirstOrDefault() as Label;

                    FormatCurrencyLabel(lblTotalFixedExpensesPanel3, CalculateTotalFixedExpenses(panel3.Controls.Find("lblFoodAmountPanel3", true).FirstOrDefault() as Label, panel3.Controls.Find("lblRentAmountPanel3", true).FirstOrDefault() as Label));
                    FormatCurrencyLabel(lblTotalNeedsExpensesPanel3, CalculateTotalNeedsExpenses(panel3.Controls.Find("lblBillsAmountPanel3", true).FirstOrDefault() as Label, panel3.Controls.Find("lblTransportationAmountPanel3", true).FirstOrDefault() as Label, panel3.Controls.Find("lblSuppliesAmountPanel3", true).FirstOrDefault() as Label, panel3.Controls.Find("lblOthersAmountPanel3", true).FirstOrDefault() as Label));
                    FormatCurrencyLabel(lblTotalWantsExpensesPanel3, CalculateTotalWantsExpenses(panel3.Controls.Find("lblEntertainmentAmountPanel3", true).FirstOrDefault() as Label, panel3.Controls.Find("lblClothingAmountPanel3", true).FirstOrDefault() as Label));

                    // Panel 4
                    if (budgetIds.Count > 1)
                    {
                        DisplayBudgetDetails(panel4, budgetIds[1]);
                        SetBudgetDetails(panel4, budgetIds[1], "lblTotalBudgetPanel4", "lblStartDatePanel4", "lblEndDatePanel4");
                        SetExpenses(panel4, budgetIds[1], "lblFoodAmountPanel4", "lblRentAmountPanel4", "lblBillsAmountPanel4", "lblTransportationAmountPanel4", "lblSuppliesAmountPanel4", "lblOthersAmountPanel4", "lblEntertainmentAmountPanel4", "lblClothingAmountPanel4", "lblSavingsPanel4");

                        // Calculate and set total expenses labels for panel 4
                        Label lblTotalFixedExpensesPanel4 = panel4.Controls.Find("lblTotalFixedExpensesPanel4", true).FirstOrDefault() as Label;
                        Label lblTotalNeedsExpensesPanel4 = panel4.Controls.Find("lblTotalNeedsExpensesPanel4", true).FirstOrDefault() as Label;
                        Label lblTotalWantsExpensesPanel4 = panel4.Controls.Find("lblTotalWantsExpensesPanel4", true).FirstOrDefault() as Label;

                        FormatCurrencyLabel(lblTotalFixedExpensesPanel4, CalculateTotalFixedExpenses(panel4.Controls.Find("lblFoodAmountPanel4", true).FirstOrDefault() as Label, panel4.Controls.Find("lblRentAmountPanel4", true).FirstOrDefault() as Label));
                        FormatCurrencyLabel(lblTotalNeedsExpensesPanel4, CalculateTotalNeedsExpenses(panel4.Controls.Find("lblBillsAmountPanel4", true).FirstOrDefault() as Label, panel4.Controls.Find("lblTransportationAmountPanel4", true).FirstOrDefault() as Label, panel4.Controls.Find("lblSuppliesAmountPanel4", true).FirstOrDefault() as Label, panel4.Controls.Find("lblOthersAmountPanel4", true).FirstOrDefault() as Label));
                        FormatCurrencyLabel(lblTotalWantsExpensesPanel4, CalculateTotalWantsExpenses(panel4.Controls.Find("lblEntertainmentAmountPanel4", true).FirstOrDefault() as Label, panel4.Controls.Find("lblClothingAmountPanel4", true).FirstOrDefault() as Label));
                    }

                    // Panel 5
                    if (budgetIds.Count > 2)
                    {
                        DisplayBudgetDetails(panel5, budgetIds[2]);
                        SetBudgetDetails(panel5, budgetIds[2], "lblTotalBudgetPanel5", "lblStartDatePanel5", "lblEndDatePanel5");
                        SetExpenses(panel5, budgetIds[2], "lblFoodAmountPanel5", "lblRentAmountPanel5", "lblBillsAmountPanel5", "lblTransportationAmountPanel5", "lblSuppliesAmountPanel5", "lblOthersAmountPanel5", "lblEntertainmentAmountPanel5", "lblClothingAmountPanel5", "lblSavingsPanel5");

                        // Calculate and set total expenses labels for panel 5
                        Label lblTotalFixedExpensesPanel5 = panel5.Controls.Find("lblTotalFixedExpensesPanel5", true).FirstOrDefault() as Label;
                        Label lblTotalNeedsExpensesPanel5 = panel5.Controls.Find("lblTotalNeedsExpensesPanel5", true).FirstOrDefault() as Label;
                        Label lblTotalWantsExpensesPanel5 = panel5.Controls.Find("lblTotalWantsExpensesPanel5", true).FirstOrDefault() as Label;

                        FormatCurrencyLabel(lblTotalFixedExpensesPanel5, CalculateTotalFixedExpenses(panel5.Controls.Find("lblFoodAmountPanel5", true).FirstOrDefault() as Label, panel5.Controls.Find("lblRentAmountPanel5", true).FirstOrDefault() as Label));
                        FormatCurrencyLabel(lblTotalNeedsExpensesPanel5, CalculateTotalNeedsExpenses(panel5.Controls.Find("lblBillsAmountPanel5", true).FirstOrDefault() as Label, panel5.Controls.Find("lblTransportationAmountPanel5", true).FirstOrDefault() as Label, panel5.Controls.Find("lblSuppliesAmountPanel5", true).FirstOrDefault() as Label, panel5.Controls.Find("lblOthersAmountPanel5", true).FirstOrDefault() as Label));
                        FormatCurrencyLabel(lblTotalWantsExpensesPanel5, CalculateTotalWantsExpenses(panel5.Controls.Find("lblEntertainmentAmountPanel5", true).FirstOrDefault() as Label, panel5.Controls.Find("lblClothingAmountPanel5", true).FirstOrDefault() as Label));
                    }

                    // Panel 6
                    if (budgetIds.Count > 3)
                    {
                        DisplayBudgetDetails(panel6, budgetIds[3]);
                        SetBudgetDetails(panel6, budgetIds[3], "lblTotalBudgetPanel6", "lblStartDatePanel6", "lblEndDatePanel6");
                        SetExpenses(panel6, budgetIds[3], "lblFoodAmountPanel6", "lblRentAmountPanel6", "lblBillsAmountPanel6", "lblTransportationAmountPanel6", "lblSuppliesAmountPanel6", "lblOthersAmountPanel6", "lblEntertainmentAmountPanel6", "lblClothingAmountPanel6", "lblSavingsPanel6");

                        // Calculate and set total expenses labels for panel 6
                        Label lblTotalFixedExpensesPanel6 = panel6.Controls.Find("lblTotalFixedExpensesPanel6", true).FirstOrDefault() as Label;
                        Label lblTotalNeedsExpensesPanel6 = panel6.Controls.Find("lblTotalNeedsExpensesPanel6", true).FirstOrDefault() as Label;
                        Label lblTotalWantsExpensesPanel6 = panel6.Controls.Find("lblTotalWantsExpensesPanel6", true).FirstOrDefault() as Label;

                        FormatCurrencyLabel(lblTotalFixedExpensesPanel6, CalculateTotalFixedExpenses(panel6.Controls.Find("lblFoodAmountPanel6", true).FirstOrDefault() as Label, panel6.Controls.Find("lblRentAmountPanel6", true).FirstOrDefault() as Label));
                        FormatCurrencyLabel(lblTotalNeedsExpensesPanel6, CalculateTotalNeedsExpenses(panel6.Controls.Find("lblBillsAmountPanel6", true).FirstOrDefault() as Label, panel6.Controls.Find("lblTransportationAmountPanel6", true).FirstOrDefault() as Label, panel6.Controls.Find("lblSuppliesAmountPanel6", true).FirstOrDefault() as Label, panel6.Controls.Find("lblOthersAmountPanel6", true).FirstOrDefault() as Label));
                        FormatCurrencyLabel(lblTotalWantsExpensesPanel6, CalculateTotalWantsExpenses(panel6.Controls.Find("lblEntertainmentAmountPanel6", true).FirstOrDefault() as Label, panel6.Controls.Find("lblClothingAmountPanel6", true).FirstOrDefault() as Label));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading panel data: {ex.Message}");
                MessageBox.Show("Error loading panel data. Please try again.");
                // Handle exception as needed
            }
        }


        private void DisplayBudgetDetails(Panel panel, int budgetId)
        {
            try
            {
                // Get budget details and expenses
                var budgetDetails = db.GetBudgetDetails(budgetId);
                var expenses = db.GetExpensesByBudgetId(budgetId);
                decimal totalExpenses = expenses.Sum(e => e.Amount);

                // Assuming you have labels for each panel to display these details
                Label lblTotalBudget = panel.Controls.Find("lblTotalBudget", true).FirstOrDefault() as Label;
                Label lblStartDate = panel.Controls.Find("lblStartDate", true).FirstOrDefault() as Label;
                Label lblEndDate = panel.Controls.Find("lblEndDate", true).FirstOrDefault() as Label;
                Label lblTotalExpenses = panel.Controls.Find("lblTotalExpenses", true).FirstOrDefault() as Label;

                if (lblTotalBudget != null)
                {
                    lblTotalBudget.Text = $"₱{budgetDetails.TotalBudget.ToString("0.00")}";
                }

                if (lblStartDate != null)
                {
                    lblStartDate.Text = budgetDetails.StartDate.ToString("yyyy-MM-dd");
                }

                if (lblEndDate != null)
                {
                    lblEndDate.Text = budgetDetails.EndDate.ToString("yyyy-MM-dd");
                }

                if (lblTotalExpenses != null)
                {
                    lblTotalExpenses.Text = $"₱{totalExpenses.ToString("0.00")}";
                }

                // Display expense details
                Label lblExpenseDetails = panel.Controls.Find("lblExpenseDetails", true).FirstOrDefault() as Label;

                if (lblExpenseDetails != null)
                {
                    lblExpenseDetails.Text = ""; // Clear previous content
                    foreach (var expense in expenses)
                    {
                        lblExpenseDetails.Text += $"{expense.Category}: {expense.Subcategory} - ₱{expense.Amount.ToString("0.00")}\n";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error displaying budget details: {ex.Message}");
                MessageBox.Show($"Error displaying budget details for Budget ID {budgetId}. Please try again.");
                // Handle exception as needed
            }
        }

        public void SetBudgetDetails(Panel panel, int budgetId, string totalBudgetLabelName, string startDateLabelName, string endDateLabelName)
        {
            var budgetDetails = db.GetBudgetDetails(budgetId);

            Label lblTotalBudget = panel.Controls.Find(totalBudgetLabelName, true).FirstOrDefault() as Label;
            Label lblStartDate = panel.Controls.Find(startDateLabelName, true).FirstOrDefault() as Label;
            Label lblEndDate = panel.Controls.Find(endDateLabelName, true).FirstOrDefault() as Label;

            if (lblTotalBudget != null)
            {
                lblTotalBudget.Text = $"₱{budgetDetails.TotalBudget.ToString("0.00")}";
            }

            if (lblStartDate != null)
            {
                lblStartDate.Text = budgetDetails.StartDate.ToString("yyyy-MM-dd");
            }

            if (lblEndDate != null)
            {
                lblEndDate.Text = budgetDetails.EndDate.ToString("yyyy-MM-dd");
            }
        }
        public void SetExpenses(Panel panel, int budgetId, string foodLabelName, string rentLabelName, string billsLabelName, string transportationLabelName, string suppliesLabelName, string othersLabelName, string entertainmentLabelName, string clothingLabelName, string savingsLabelName)
        {
            var expenses = db.GetExpensesByBudgetId(budgetId);
            var budgetDetails =  db.GetBudgetDetails(budgetId);

            Label lblFoodAmount = panel.Controls.Find(foodLabelName, true).FirstOrDefault() as Label;
            Label lblRentAmount = panel.Controls.Find(rentLabelName, true).FirstOrDefault() as Label;
            Label lblBillsAmount = panel.Controls.Find(billsLabelName, true).FirstOrDefault() as Label;
            Label lblTransportationAmount = panel.Controls.Find(transportationLabelName, true).FirstOrDefault() as Label;
            Label lblSuppliesAmount = panel.Controls.Find(suppliesLabelName, true).FirstOrDefault() as Label;
            Label lblOthersAmount = panel.Controls.Find(othersLabelName, true).FirstOrDefault() as Label;
            Label lblEntertainmentAmount = panel.Controls.Find(entertainmentLabelName, true).FirstOrDefault() as Label;
            Label lblClothingAmount = panel.Controls.Find(clothingLabelName, true).FirstOrDefault() as Label;
            Label lblSavings = panel.Controls.Find(savingsLabelName, true).FirstOrDefault() as Label;

            decimal totalFood = 0;
            decimal totalRent = 0;
            decimal totalBills = 0;
            decimal totalTransportation = 0;
            decimal totalSupplies = 0;
            decimal totalOthers = 0;
            decimal totalEntertainment = 0;
            decimal totalClothing = 0;
            decimal totalSavings = budgetDetails.Savings;

            foreach (var expense in expenses)
            {
                switch (expense.Subcategory)
                {
                    case ExpenseSubCategory.Food:
                        totalFood += expense.Amount;
                        break;
                    case ExpenseSubCategory.Rent:
                        totalRent += expense.Amount;
                        break;
                    case ExpenseSubCategory.Bills:
                        totalBills += expense.Amount;
                        break;
                    case ExpenseSubCategory.Transportation:
                        totalTransportation += expense.Amount;
                        break;
                    case ExpenseSubCategory.Supplies:
                        totalSupplies += expense.Amount;
                        break;
                    case ExpenseSubCategory.Others:
                        totalOthers += expense.Amount;
                        break;
                    case ExpenseSubCategory.Entertainment:
                        totalEntertainment += expense.Amount;
                        break;
                    case ExpenseSubCategory.Clothing:
                        totalClothing += expense.Amount;
                        break;
                    default:
                        // Handle unexpected subcategory
                        break;
                }
            }

            if (lblFoodAmount != null)
            {
                lblFoodAmount.Text = $"₱{totalFood.ToString("0.00")}";
            }

            if (lblRentAmount != null)
            {
                lblRentAmount.Text = $"₱{totalRent.ToString("0.00")}";
            }

            if (lblBillsAmount != null)
            {
                lblBillsAmount.Text = $"₱{totalBills.ToString("0.00")}";
            }

            if (lblTransportationAmount != null)
            {
                lblTransportationAmount.Text = $"₱{totalTransportation.ToString("0.00")}";
            }

            if (lblSuppliesAmount != null)
            {
                lblSuppliesAmount.Text = $"₱{totalSupplies.ToString("0.00")}";
            }

            if (lblOthersAmount != null)
            {
                lblOthersAmount.Text = $"₱{totalOthers.ToString("0.00")}";
            }

            if (lblEntertainmentAmount != null)
            {
                lblEntertainmentAmount.Text = $"₱{totalEntertainment.ToString("0.00")}";
            }

            if (lblClothingAmount != null)
            {
                lblClothingAmount.Text = $"₱{totalClothing.ToString("0.00")}";
            }

            if (lblSavings != null)
            {
                lblSavings.Text = $"₱{totalSavings.ToString("0.00")}";
            }
        }


        private void FormatCurrencyLabel(Label label, decimal amount)
        {
            label.Text = $"₱{amount.ToString("0.00")}";
        }


        private decimal CalculateTotalFixedExpenses(Label lblFood, Label lblRent)
        {
            decimal totalFixedExpenses = 0;
            if (lblFood != null && !string.IsNullOrEmpty(lblFood.Text))
            {
                totalFixedExpenses += decimal.Parse(lblFood.Text.Trim('₱'));
            }
            if (lblRent != null && !string.IsNullOrEmpty(lblRent.Text))
            {
                totalFixedExpenses += decimal.Parse(lblRent.Text.Trim('₱'));
            }
            return totalFixedExpenses;
        }

        private decimal CalculateTotalNeedsExpenses(Label lblBills, Label lblTransportation, Label lblSupplies, Label lblOthers)
        {
            decimal totalNeedsExpenses = 0;
            if (lblBills != null && !string.IsNullOrEmpty(lblBills.Text))
            {
                totalNeedsExpenses += decimal.Parse(lblBills.Text.Trim('₱'));
            }
            if (lblTransportation != null && !string.IsNullOrEmpty(lblTransportation.Text))
            {
                totalNeedsExpenses += decimal.Parse(lblTransportation.Text.Trim('₱'));
            }
            if (lblSupplies != null && !string.IsNullOrEmpty(lblSupplies.Text))
            {
                totalNeedsExpenses += decimal.Parse(lblSupplies.Text.Trim('₱'));
            }
            if (lblOthers != null && !string.IsNullOrEmpty(lblOthers.Text))
            {
                totalNeedsExpenses += decimal.Parse(lblOthers.Text.Trim('₱'));
            }
            return totalNeedsExpenses;
        }

        private decimal CalculateTotalWantsExpenses(Label lblEntertainment, Label lblClothing)
        {
            decimal totalWantsExpenses = 0;
            if (lblEntertainment != null && !string.IsNullOrEmpty(lblEntertainment.Text))
            {
                totalWantsExpenses += decimal.Parse(lblEntertainment.Text.Trim('₱'));
            }
            if (lblClothing != null && !string.IsNullOrEmpty(lblClothing.Text))
            {
                totalWantsExpenses += decimal.Parse(lblClothing.Text.Trim('₱'));
            }
            return totalWantsExpenses;
        }


    }
}
