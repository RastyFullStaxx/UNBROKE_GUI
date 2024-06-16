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
    public partial class Budget_Loaded : Form
    {
        private string currentuser;

        public Budget_Loaded(string currentuser)
        {
            InitializeComponent();
            this.currentuser = currentuser;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentuser);
            dashboard.Show();
            this.Dispose();
        }

        private void Budget_Loaded_Load(object sender, EventArgs e)
        {

        }

        private void btnGoToBudgetWizardResults_Click(object sender, EventArgs e)
        {
            Budget_Wizard_Result_Expense_Tab budget_Wizard_Result_Expense_Tab = new Budget_Wizard_Result_Expense_Tab(currentuser);
            budget_Wizard_Result_Expense_Tab.Show();
            this.Dispose();

        }
    }
}
