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
    public partial class Budget_Wizard_Fixed_Inputs : Form
    {
        public Budget_Wizard_Fixed_Inputs()
        {
            InitializeComponent();
        }

        private void lblPrompt1_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalBudget_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPHP_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Budget_Loading budget_Loading = new Budget_Loading();
            budget_Loading.Show();
            this.Dispose();
        }

        private void Budget_Wizard_Fixed_Inputs_Load(object sender, EventArgs e)
        {

        }
    }
}
