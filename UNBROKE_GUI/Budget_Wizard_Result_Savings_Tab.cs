using MySql.Data.MySqlClient;
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
    public partial class Budget_Wizard_Result_Savings_Tab : Form
    {
        private string currentuser;
        private Timer timer;
        private ProgressManager progressBarManager;

        public Budget_Wizard_Result_Savings_Tab( string currentUser
)
        {
            InitializeComponent();
            this.currentuser = currentUser;
            InitializeProgressBars();

            savingsProgressBar.Maximum = 100;

            timer = new Timer();
            timer.Interval = 10; // Interval in milliseconds
            timer.Tick += timer1_Tick;
            timer.Start();

            // Update lblDate with current month and year
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("MMMM yyyy");
            lblSavingsDate.Text = formattedDate;
            // Fetch and display total expenses for the highest budget ID
            decimal totalExpenses = FetchTotalExpensesForHighestBudgetID();
            lblExpenseAmount.Text = FormatCurrency(totalExpenses);

            // Fetch and display savings for the highest budget ID
            decimal savings = FetchSavingsForHighestBudgetID();
            lblExpectedSavingsAmount.Text = FormatCurrency(savings);
        }

        private string FormatCurrency(decimal amount)
        {
            return string.Format("₱{0:N2}", amount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Budget_Wizard_Result_Expense_Tab budget_Wizard_Result_Expense_Tab = new Budget_Wizard_Result_Expense_Tab(currentuser);
            budget_Wizard_Result_Expense_Tab.Show();
            this.Dispose();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentuser);
            dashboard.Show();
            this.Dispose();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Dashboard_Profile_Section dashboard_Profile = new Dashboard_Profile_Section(currentuser);
            dashboard_Profile.Show();
            this.Dispose();
        }

        private void Budget_Wizard_Result_Savings_Tab_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
     
                // Update progress bars through the ProgressBarManager
                progressBarManager.UpdateProgress1();

                // Check if all progress bars have reached their targets to stop the timer
                if (progressBarManager.AllProgressReachedTargets1())
                {
                    timer.Stop();
                }
            

        }
        private void InitializeProgressBars()
        {
            progressBarManager = new ProgressManager(savingsProgressBar);
            progressBarManager.InitializeTargets(20); // Set initial targets
            progressBarManager.SetMaximumValues1(); // Set maximum values for progress bars
        }

        private MySqlConnection GetConnection()
        {
            string connectionString = "server=localhost;port=3307;database=unbroke;uid=root;pwd='';";

            return new MySqlConnection(connectionString);
        }



        public decimal FetchTotalExpensesForHighestBudgetID()
        {
            decimal totalExpenses = 0;

            string query = @"
        SELECT SUM(e.amount) 
        FROM expense e
        INNER JOIN budget b ON e.budget_ID = b.budget_id
        WHERE b.budget_id = (SELECT MAX(budget_id) FROM budget WHERE user_id = (SELECT user_id FROM user WHERE username = @currentUser))";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@currentUser", currentuser);

                        var result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalExpenses = Convert.ToDecimal(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return totalExpenses;
        }

        public decimal FetchSavingsForHighestBudgetID()
        {
            decimal savings = 0;

            string query = @"
        SELECT b.savings 
        FROM budget b
        WHERE b.budget_id = (SELECT MAX(budget_id) FROM budget WHERE user_id = (SELECT user_id FROM user WHERE username = @currentUser))";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@currentUser", currentuser);

                        var result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            savings = Convert.ToDecimal(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return savings;
        }


    }
}
