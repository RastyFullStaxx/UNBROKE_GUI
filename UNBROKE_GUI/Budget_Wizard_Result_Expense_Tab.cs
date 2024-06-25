using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNBROKE_GUI.Managers;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Budget_Wizard_Result_Load(object sender, EventArgs e)
        {
            FetchBudgetDetails();
            /* PopulateProgressBar();*/
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

    }
}
