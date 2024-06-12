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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

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
            Budget_Wizard_Date budget_Wizard_Date = new Budget_Wizard_Date();
            budget_Wizard_Date.Show();
            this.Dispose();
        }
    }
}
