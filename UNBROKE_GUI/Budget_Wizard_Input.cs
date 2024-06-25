using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNBROKE_GUI
{
    public partial class Budget_Wizard_Input : Form
    {
        private DatabaseHelper db = DatabaseHelper.GetInstance();
        private string currentuser;
        private DateTime enddate; // Store the budget_id passed from Budget_Wizard_Date
        private int userID;

        public Budget_Wizard_Input(string currentuser,DateTime endDate)
        {
            InitializeComponent();
            this.currentuser = currentuser;
            this.enddate = endDate;

            userID = db.GetUserIdByUsername(currentuser);

        }

        private void Budget_Wizard_Input_Load(object sender, EventArgs e)
        {

        }

        private void lblTotalBudget_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPHP_Click(object sender, EventArgs e)
        {

        }


        private void TxtTotalBudget_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the TextBox gains focus
            if (txtTotalBudget.Text == "5000")
            {
                txtTotalBudget.Text = "";
            }
        }

        private void TxtTotalBudget_Leave(object sender, EventArgs e)
        {
            // Restore the placeholder text if the TextBox is empty
            if (string.IsNullOrWhiteSpace(txtTotalBudget.Text))
            {
                txtTotalBudget.Text = "5000";

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalBudget.Text, out decimal totalBudget))
            {
                int userId = db.GetUserIdByUsername(currentuser);

                if (userId != -1)
                {
                    // Insert budget with the highest budget ID + 1
                    bool success = db.InsertBudget(userId, totalBudget, DateTime.Now, enddate);

                    if (success)
                    {
                        Budget_Wizard_Fixed_Inputs budget_Wizard_Date = new Budget_Wizard_Fixed_Inputs(currentuser);
                        budget_Wizard_Date.Show();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save budget data. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("User not found. Please log in again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid total budget amount.");
            }
        }

    }
}
