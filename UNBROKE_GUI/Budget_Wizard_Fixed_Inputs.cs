using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNBROKE_GUI.Enums;
using UNBROKE_GUI.BaseCalculation;

namespace UNBROKE_GUI
{
    public partial class Budget_Wizard_Fixed_Inputs : Form
    {
        DatabaseHelper db = DatabaseHelper.GetInstance();
        BaseClass budget;

        private string currentuser;
        private int userId;
        private int budgetId;
        private decimal totalB;

        // DATABASE CONNECTION: PASSED TO THE CURRENT USER [JAE]
        public Budget_Wizard_Fixed_Inputs(string currentuser, decimal totalBudget)
        {
            InitializeComponent();
            this.currentuser = currentuser;
            Placeholder.SetFixedInput(txtFoodExpenseAmount, "5000");
            Placeholder.SetFixedInput(txtRentExpenseAmount, "5000");
            this.totalB = totalBudget;

            userId = db.GetUserIdByUsername(currentuser);
            budgetId = db.GetHighestBudgetIdByUserId(userId);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Parse the food expense amount from the textbox
            if (decimal.TryParse(txtFoodExpenseAmount.Text, out decimal foodExpense))
            {
                // Insert the food expense into the database
                bool success = db.InsertExpense(budgetId, ExpenseCategory.Fix, ExpenseSubCategory.Food, foodExpense);
                if (success)
                {
                    Console.WriteLine("Food expense inserted successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to insert food expense.");
                }
            }
            else
            {
                Console.WriteLine("Invalid food expense amount.");
            }

            // Parse the rent expense amount from the textbox
            if (decimal.TryParse(txtRentExpenseAmount.Text, out decimal rentExpense))
            {
                // Insert the rent expense into the database
                bool success = db.InsertExpense(budgetId, ExpenseCategory.Fix, ExpenseSubCategory.Rent, rentExpense);
                if (success)
                {
                    Console.WriteLine("Rent expense inserted successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to insert rent expense.");
                }
            }
            else
            {
                Console.WriteLine("Invalid rent expense amount.");
            }

            // Parse input values from text boxes
            if (decimal.TryParse(txtRentExpenseAmount.Text, out decimal rent) &&
                decimal.TryParse(txtFoodExpenseAmount.Text, out decimal food))
            {
                // Initialize BaseClass with TotalBudget, Rent, and Food
                budget = new BaseClass(totalB, rent, food);


        /*      
         *      // KNAPSACK ALGO PERFORMED BY BASECLASS FORMS [RASTY]
                Console.WriteLine("Total Budget: " + totalB.ToString("N2"));
                Console.WriteLine("Fixed Expenses: " + budget.FixedExpenses.ToString("N2"));
                Console.WriteLine("Rent: " + budget.Rent.ToString("N2"));
                Console.WriteLine("Food: " + budget.Food.ToString("N2"));
                Console.WriteLine("Non-Fixed Expenses: " + budget.NonFixedExpenses.ToString("N2"));
                Console.WriteLine("Needs: " + budget.Needs.ToString("N2"));
                Console.WriteLine("Bills: " + budget.Bills.ToString("N2"));
                Console.WriteLine("Transportation: " + budget.Transportation.ToString("N2"));
                Console.WriteLine("Supplies: " + budget.Supplies.ToString("N2"));
                Console.WriteLine("Others: " + budget.Others.ToString("N2"));
                Console.WriteLine("Wants: " + budget.Wants.ToString("N2"));
                Console.WriteLine("Entertainment: " + budget.Entertainment.ToString("N2"));
                Console.WriteLine("Clothing: " + budget.Clothing.ToString("N2"));
                Console.WriteLine("Savings: " + budget.Savings.ToString("N2"));
        
         */


                // DATABASE CONNECTION FOR EXPENSES USED IN KNAPSACK [JAE]
                bool Bills = db.InsertExpense(budgetId, ExpenseCategory.Needs, ExpenseSubCategory.Bills, budget.Bills);
                bool Transportation = db.InsertExpense(budgetId, ExpenseCategory.Needs, ExpenseSubCategory.Transportation, budget.Transportation);
                bool Supplies = db.InsertExpense(budgetId, ExpenseCategory.Needs, ExpenseSubCategory.Supplies, budget.Supplies);
                bool Others = db.InsertExpense(budgetId, ExpenseCategory.Needs, ExpenseSubCategory.Others, budget.Others);

                bool Entertainment = db.InsertExpense(budgetId, ExpenseCategory.Wants, ExpenseSubCategory.Entertainment, budget.Entertainment);
                bool Clothing = db.InsertExpense(budgetId, ExpenseCategory.Wants, ExpenseSubCategory.Clothing, budget.Clothing);

                bool Savings = db.InsertSavings(userId, budgetId, budget.Savings);
            }
            else
            {
                Console.WriteLine("ERROR");

            }

            // Proceed to the next form
            Budget_Loading budget_Loading = new Budget_Loading(currentuser);
            budget_Loading.Show();
            this.Dispose();
        }

        private void Budget_Wizard_Fixed_Inputs_Load(object sender, EventArgs e)
        {
            UpdateTotalFixedExpense();

        }

        private void txtFoodExpenseAmount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalFixedExpense();
        }

        private void txtRentExpenseAmount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalFixedExpense();

        }

        private void UpdateTotalFixedExpense()
        {
            // Parse values from textboxes
            if (decimal.TryParse(txtRentExpenseAmount.Text, out decimal rentExpense) &&
                decimal.TryParse(txtFoodExpenseAmount.Text, out decimal foodExpense))
            {
                // Calculate the total
                decimal totalFixedExpense = rentExpense + foodExpense;

                // Update the label text
                lblDisplayTotalFixedExpenseAmount.Text = $"₱{totalFixedExpense.ToString("0.00")}";
            }
            else
            {
                // Handle invalid input gracefully if needed
                lblDisplayTotalFixedExpenseAmount.Text = "₱0.00";
            }
        }
    }
}
