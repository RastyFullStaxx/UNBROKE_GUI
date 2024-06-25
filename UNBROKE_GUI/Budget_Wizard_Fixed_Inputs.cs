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

namespace UNBROKE_GUI
{
    public partial class Budget_Wizard_Fixed_Inputs : Form
    {
        DatabaseHelper db = DatabaseHelper.GetInstance();
        private string currentuser;
        private int userId;
        private int budgetId;

        public Budget_Wizard_Fixed_Inputs(string currentuser)
        {
            InitializeComponent();
            this.currentuser = currentuser;
            Placeholder.SetFixedInput(txtFoodExpenseAmount, "5000");
            Placeholder.SetFixedInput(txtRentExpenseAmount, "5000");


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
                    MessageBox.Show("Food expense inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to insert food expense.");
                }
            }
            else
            {
                MessageBox.Show("Invalid food expense amount.");
            }

            // Parse the rent expense amount from the textbox
            if (decimal.TryParse(txtRentExpenseAmount.Text, out decimal rentExpense))
            {
                // Insert the rent expense into the database
                bool success = db.InsertExpense(budgetId, ExpenseCategory.Fix, ExpenseSubCategory.Rent, rentExpense);
                if (success)
                {
                    MessageBox.Show("Rent expense inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to insert rent expense.");
                }
            }
            else
            {
                MessageBox.Show("Invalid rent expense amount.");
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
