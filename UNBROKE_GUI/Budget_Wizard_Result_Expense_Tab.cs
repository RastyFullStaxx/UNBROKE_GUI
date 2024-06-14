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
    public partial class Budget_Wizard_Result_Expense_Tab : Form
    {
        private string currentuser;

        public Budget_Wizard_Result_Expense_Tab(string currentuser)
        {
            InitializeComponent();
            this.currentuser = currentuser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Budget_Wizard_Result_Load(object sender, EventArgs e)
        {

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
    }
}
