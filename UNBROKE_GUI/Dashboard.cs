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

namespace UNBROKE_GUI
{
    public partial class Dashboard : Form
    {
        private string currentuser;

        public Dashboard(string currentuser)
        {
            InitializeComponent();
            this.currentuser = currentuser;

            // Update lblDate with current month and year
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("MMMM yyyy");
            lblDate.Text = formattedDate;

        }

     

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {

        }

        private void dbTotalBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTransactionTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Dashboard_Profile_Section dashboard_Profile_Section = new Dashboard_Profile_Section(currentuser);
            dashboard_Profile_Section.Show();
            this.Dispose();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
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


        private void DashboardDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            Budget_Wizard_Date budget_Wizard_Date = new Budget_Wizard_Date(currentuser);
            budget_Wizard_Date.Show();
            this.Dispose();
        }

        private void link_lblBudgetWizard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Budget_Wizard_Date budget_Wizard_Date = new Budget_Wizard_Date(currentuser);
            budget_Wizard_Date.Show();
            this.Dispose();
        }

        private void btnBudgetWizard2_Click(object sender, EventArgs e)
        {
            Budget_Wizard_Result_Expense_Tab budget_Wizard_Result_Expense_Tab = new Budget_Wizard_Result_Expense_Tab(currentuser);
            budget_Wizard_Result_Expense_Tab.Show();
            this.Dispose();
        }
    }
}
