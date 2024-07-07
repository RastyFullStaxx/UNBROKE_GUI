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
            if (numberofBudget >= 1)
            {
                link_lblBudgetWizard.Visible = false;
                imgNotificationIcon.Visible = false;    
                btnBudgetWizard1.Visible = false;
                youdonthaveLabel.Visible = false;
                priorityPanel.Visible = true;

            }
            else
            {
                link_lblBudgetWizard.Visible = true;
                imgNotificationIcon.Visible = true;
                btnBudgetWizard1.Visible = true;
                youdonthaveLabel.Visible = true;
                priorityPanel.Visible = false;


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
    }
}
