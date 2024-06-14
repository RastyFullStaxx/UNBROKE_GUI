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
    public partial class Budget_Wizard_Result_Savings_Tab : Form
    {
        private string currentuser;

        public Budget_Wizard_Result_Savings_Tab( string currentUser
)
        {
            InitializeComponent();
            this.currentuser = currentUser;
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
    }
}
