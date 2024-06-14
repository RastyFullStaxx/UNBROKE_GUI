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
    public partial class Budget_Wizard_Date : Form
    {
        private string currentuser;

        public Budget_Wizard_Date(string currentuser)
        {
            InitializeComponent();
            this.currentuser = currentuser;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Get current date as start date
            DateTime startDate = DateTime.Today;

            // Get the selected end date from the DateTimePicker
            DateTime endDate = dateTimePicker.Value;

            // Insert budget data into the database
            DatabaseHelper db = DatabaseHelper.GetInstance();
            int userId = db.GetUserIdByUsername(currentuser);

            if (userId != -1)
            {
                bool success = db.InsertBudgetDate(userId, startDate, endDate);

                if (success)
                {
                    // Show the Budget_Wizard_Input form and pass necessary data
                    Budget_Wizard_Input budget_Wizard_Input = new Budget_Wizard_Input(currentuser);
                    budget_Wizard_Input.Show();
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

        private void Budget_Wizard_Date_Load(object sender, EventArgs e)
        {
            // Initialize DateTimePicker with current date or default value
            dateTimePicker.Value = DateTime.Today.AddDays(1); // Default to tomorrow's date
        }
    }
}
