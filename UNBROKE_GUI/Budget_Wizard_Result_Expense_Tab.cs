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

        private decimal totalBudget, currentFixedExpense, newFixedExpense, currentNeedsExpense, newNeedsExpense,
            currentWantsExpense, newWantsExpense;

        private decimal Fixed_Food, Fixed_Rent;
        private decimal Needs_Bills, Needs_Transportation, Needs_Supplies, Needs_Others;
        private decimal Wants_Entertainment, Wants_Clothing;





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




            FetchAmounts();

        }


        //EDIT BUTTONS
        private void btnEditFixedExpense_Click(object sender, EventArgs e)
        {
            // Display confirmation MessageBox to update fixed expenses
            DialogResult result = MessageBox.Show("Are you sure you want to update the fixed expense?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Proceed with updating fixed expenses
                UpdateFixedExpenses();

                // Attempt to parse and format lblFoodAmountDisplay and lblRentAmountDisplay
                decimal foodAmount, rentAmount;

                // Remove currency symbol and trim whitespace
                string foodText = lblFoodAmountDisplay.Text.Replace("₱", "").Trim();
                string rentText = lblRentAmountDisplay.Text.Replace("₱", "").Trim();

                if (decimal.TryParse(foodText, out foodAmount) && decimal.TryParse(rentText, out rentAmount))
                {
                    lblFoodAmountDisplay.Text = FormatCurrency(foodAmount);
                    lblRentAmountDisplay.Text = FormatCurrency(rentAmount);

                    // Get the highest budget ID for the current user
                    int userId = db.GetUserIdByUsername(currentuser);
                    int budgetId = db.GetHighestBudgetIdByUserId(userId);

                    if (budgetId != -1)
                    {
                        // Update the database with new values
                        bool updatedFood = db.UpdateExpense(budgetId, ExpenseCategory.Fix, ExpenseSubCategory.Food, foodAmount);
                        bool updatedRent = db.UpdateExpense(budgetId, ExpenseCategory.Fix, ExpenseSubCategory.Rent, rentAmount);

                        // Calculate the new total budget
                        totalBudget = RemoveCurrencySymbol(lblTotalBudgetAmountDisplay.Text);

                        if (updatedFood && updatedRent)
                        {
                            // Update the total budget and savings in the database
                            bool updatedTotalBudgetAndSavings = db.UpdateTotalBudgetAndSavings(budgetId, totalBudget);

                            if (updatedTotalBudgetAndSavings)
                            {
                                Console.WriteLine("Fixed expenses, total budget, and savings updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update the total budget and savings.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update some or all fixed expenses.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No budget found for the current user.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid amount format in either Food or Rent expenses.");
                }
            }
            else
            {
                // Handle cancel or no action
            }
        }

        private void btnEditNeedsExpense_Click(object sender, EventArgs e)
        {
            // Display confirmation MessageBox to update needs expenses
            DialogResult result = MessageBox.Show("Are you sure you want to update the needs expense?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Proceed with updating needs expenses
                UpdateNeedsExpenses();

                // Attempt to parse and format lblBillsAmountDisplay, lblTransportationAmountDisplay, lblSuppliesAmountDisplay, lblOthersAmountDisplay
                decimal bills, transportation, supplies, others;

                // Remove currency symbol and trim whitespace
                string billsText = lblBillsAmountDisplay.Text.Replace("₱", "").Trim();
                string transportationText = lblTransportationAmountDisplay.Text.Replace("₱", "").Trim();
                string suppliesText = lblSuppliesAmountDisplay.Text.Replace("₱", "").Trim();
                string othersText = lblOthersAmountDisplay.Text.Replace("₱", "").Trim();

                if (decimal.TryParse(billsText, out bills) && decimal.TryParse(transportationText, out transportation) && decimal.TryParse(suppliesText, out supplies) && decimal.TryParse(othersText, out others))
                {
                    lblBillsAmountDisplay.Text = FormatCurrency(bills);
                    lblTransportationAmountDisplay.Text = FormatCurrency(transportation);
                    lblSuppliesAmountDisplay.Text = FormatCurrency(supplies);
                    lblOthersAmountDisplay.Text = FormatCurrency(others);

                    // Get the highest budget ID for the current user
                    int userId = db.GetUserIdByUsername(currentuser);
                    int budgetId = db.GetHighestBudgetIdByUserId(userId);

                    if (budgetId != -1)
                    {
                        // Update the database with new values
                        bool updatedBills = db.UpdateExpense(budgetId, ExpenseCategory.Needs, ExpenseSubCategory.Bills, bills);
                        bool updatedTransportation = db.UpdateExpense(budgetId, ExpenseCategory.Needs, ExpenseSubCategory.Transportation, transportation);
                        bool updatedSupplies = db.UpdateExpense(budgetId, ExpenseCategory.Needs, ExpenseSubCategory.Supplies, supplies);
                        bool updatedOthers = db.UpdateExpense(budgetId, ExpenseCategory.Needs, ExpenseSubCategory.Others, others);

                        // Calculate the new total budget
                        totalBudget = RemoveCurrencySymbol(lblTotalBudgetAmountDisplay.Text);

                        if (updatedBills && updatedTransportation && updatedSupplies && updatedOthers)
                        {
                            // Update the total budget and savings in the database
                            bool updatedTotalBudgetAndSavings = db.UpdateTotalBudgetAndSavings(budgetId, totalBudget);

                            if (updatedTotalBudgetAndSavings)
                            {
                                Console.WriteLine("Needs expenses, total budget, and savings updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update the total budget and savings.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update some or all needs expenses.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No budget found for the current user.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid amount format in either Bills, Transportation, Supplies, or Others expenses.");
                }
            }
            else
            {
                // Handle cancel or no action
            }
        }

        private void btnEditWantsExpense_Click(object sender, EventArgs e)
        {
            // Display confirmation MessageBox to update wants expenses
            DialogResult result = MessageBox.Show("Are you sure you want to update the wants expense?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Proceed with updating wants expenses
                UpdateWantsExpenses();

                // Attempt to parse and format lblEntertainmentAmountDisplay and lblClothingAmountDisplay
                decimal entertainment, clothing;

                // Remove currency symbol and trim whitespace
                string entertainmentText = lblEntertainmentAmountDisplay.Text.Replace("₱", "").Trim();
                string clothingText = lblClothingAmountDisplay.Text.Replace("₱", "").Trim();

                if (decimal.TryParse(entertainmentText, out entertainment) && decimal.TryParse(clothingText, out clothing))
                {
                    lblEntertainmentAmountDisplay.Text = FormatCurrency(entertainment);
                    lblClothingAmountDisplay.Text = FormatCurrency(clothing);

                    // Get the highest budget ID for the current user
                    int userId = db.GetUserIdByUsername(currentuser);
                    int budgetId = db.GetHighestBudgetIdByUserId(userId);

                    if (budgetId != -1)
                    {
                        // Update the database with new values
                        bool updatedEntertainment = db.UpdateExpense(budgetId, ExpenseCategory.Wants, ExpenseSubCategory.Entertainment, entertainment);
                        bool updatedClothing = db.UpdateExpense(budgetId, ExpenseCategory.Wants, ExpenseSubCategory.Clothing, clothing);

                        // Calculate the new total budget
                        totalBudget = RemoveCurrencySymbol(lblTotalBudgetAmountDisplay.Text);

                        if (updatedEntertainment && updatedClothing)
                        {
                            // Update the total budget and savings in the database
                            bool updatedTotalBudgetAndSavings = db.UpdateTotalBudgetAndSavings(budgetId, totalBudget);

                            if (updatedTotalBudgetAndSavings)
                            {
                                Console.WriteLine("Wants expenses, total budget, and savings updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update the total budget and savings.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update some or all wants expenses.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No budget found for the current user.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid amount format in either Entertainment or Clothing expenses.");
                }
            }
            else
            {
                // Handle cancel or no action
            }
        }




        private void UpdateFixedExpenses()
        {
            FetchAmounts(); // Assuming this method fetches Fixed_Food, Fixed_Rent, and currentFixedExpense
            decimal newFixedExpense = Fixed_Food + Fixed_Rent;
            decimal difference = 0.0m;

            if (newFixedExpense > currentFixedExpense)
            {
                difference = newFixedExpense - currentFixedExpense;
                totalBudget += difference;
                Console.WriteLine($"Increased fixed expenses by: {difference.ToString("C")}");
                lblDisplayTotalFixedExpenseAmountDisplay.Text = FormatCurrency(newFixedExpense);
                lblTotalBudgetAmountDisplay.Text = FormatCurrency(totalBudget);

            }
            else if (newFixedExpense < currentFixedExpense)
            {
                difference = currentFixedExpense - newFixedExpense;
                totalBudget -= difference;
                Console.WriteLine($"Decreased fixed expenses by: {difference.ToString("C")}");
                lblDisplayTotalFixedExpenseAmountDisplay.Text = FormatCurrency(newFixedExpense);
                lblTotalBudgetAmountDisplay.Text = FormatCurrency(totalBudget);

            }
        }
        private void UpdateNeedsExpenses()
        {
            FetchAmounts(); // Assuming this method fetches Fixed_Food, Fixed_Rent, and currentFixedExpense


            decimal newNeedsExpense = Needs_Transportation + Needs_Bills + Needs_Supplies + Needs_Others;
            decimal difference = 0.0m;

            if(newNeedsExpense > currentNeedsExpense)
            {
                difference = newNeedsExpense - currentNeedsExpense;
                totalBudget += difference;
                lblDisplayTotalNeedsExpenseDisplay.Text = FormatCurrency(newNeedsExpense);
                lblTotalBudgetAmountDisplay.Text = FormatCurrency(totalBudget);


            }else if(newNeedsExpense < currentNeedsExpense)
            {
                difference = currentNeedsExpense - newNeedsExpense;
                totalBudget -= difference;
                lblDisplayTotalNeedsExpenseDisplay.Text = FormatCurrency(newNeedsExpense);
                lblTotalBudgetAmountDisplay.Text = FormatCurrency(totalBudget);
            }


        }

        private void UpdateWantsExpenses()
        {
            FetchAmounts(); // Assuming this method fetches Fixed_Food, Fixed_Rent, and currentFixedExpense


            decimal newWantsExpense = Wants_Entertainment + Wants_Clothing;
            decimal difference = 0.0m;

            if (newWantsExpense > currentWantsExpense)
            {
                difference = newWantsExpense - currentWantsExpense;
                totalBudget += difference;
                lblTotalWantsAmountDisplay.Text = FormatCurrency(newWantsExpense);
                lblTotalBudgetAmountDisplay.Text = FormatCurrency(totalBudget);

            }
            else if (newWantsExpense < currentWantsExpense)
            {
                difference = currentWantsExpense - newWantsExpense;
                totalBudget -= difference;
                lblTotalWantsAmountDisplay.Text = FormatCurrency(newWantsExpense);
                lblTotalBudgetAmountDisplay.Text = FormatCurrency(totalBudget);
            }


        }



        private void FetchAmounts()
        {
            try
            {
                totalBudget = RemoveCurrencySymbol(lblTotalBudgetAmountDisplay.Text);
                currentFixedExpense = RemoveCurrencySymbol(lblDisplayTotalFixedExpenseAmountDisplay.Text);
                Fixed_Food = RemoveCurrencySymbol(lblFoodAmountDisplay.Text);
                Fixed_Rent = RemoveCurrencySymbol(lblRentAmountDisplay.Text);

                currentNeedsExpense = RemoveCurrencySymbol(lblDisplayTotalNeedsExpenseDisplay.Text);
                Needs_Bills = RemoveCurrencySymbol(lblDisplayTotalNeedsExpenseDisplay.Text) ;
                Needs_Transportation = RemoveCurrencySymbol(lblTransportationAmountDisplay.Text);
                Needs_Supplies = RemoveCurrencySymbol(lblSuppliesAmountDisplay.Text);
                Needs_Others = RemoveCurrencySymbol(lblOthersAmountDisplay.Text);

                currentWantsExpense = RemoveCurrencySymbol(lblTotalWantsAmountDisplay.Text);
                Wants_Entertainment = RemoveCurrencySymbol(lblEntertainmentAmountDisplay.Text);
                Wants_Clothing = RemoveCurrencySymbol(lblClothingAmountDisplay.Text); 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching amounts: {ex.Message}");
            }
        }

        private decimal RemoveCurrencySymbol(string amountText)
        {
            try
            {
                // Remove currency symbol (₱) and commas from the text
                string cleanText = amountText.Replace("₱", "").Replace(",", "");

                // Attempt to parse the cleaned text to a decimal without specifying a specific culture
                if (decimal.TryParse(cleanText, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal amount))
                {
                    return amount;
                }
                else
                {
                    // Handle parsing error if the text is not a valid decimal format
                    throw new FormatException($"Invalid amount format in label: {amountText}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0; // or return any default value based on your application logic
            }
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
            lblFoodAmountDisplay.Location = new Point(210, 48);
            lblRentAmountDisplay.Location = new Point(202, 90);

            lblDisplayTotalNeedsExpenseDisplay.Location = new Point(193, 178);
            lblBillsAmountDisplay.Location = new Point(205, 207);
            lblTransportationAmountDisplay.Location = new Point(205, 249);
            lblSuppliesAmountDisplay.Location = new Point(205, 291);
            lblOthersAmountDisplay.Location = new Point(205, 331);

            lblTotalWantsAmountDisplay.Location = new Point(193, 416);
            lblEntertainmentAmountDisplay.Location = new Point(205, 445);
            lblClothingAmountDisplay.Location = new Point(205, 487);

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
