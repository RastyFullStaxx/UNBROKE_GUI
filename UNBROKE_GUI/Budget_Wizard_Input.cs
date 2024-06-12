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
    public partial class Budget_Wizard_Input : Form
    {
        public Budget_Wizard_Input()
        {
            InitializeComponent();
        }

        private void lblTotalBudget_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPHP_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalBudget_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotalBudget_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the TextBox gains focus
            if (txtTotalBudget.Text == "5000")
            {
                txtTotalBudget.Text = "";
            }
        }

        private void TxtTotalBudget_Leave(object sender, EventArgs e)
        {
            // Restore the placeholder text if the TextBox is empty
            if (string.IsNullOrWhiteSpace(txtTotalBudget.Text))
            {
                txtTotalBudget.Text = "5000";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Budget_Wizard_Fixed_Inputs budget_Wizard_Fixed_Inputs = new Budget_Wizard_Fixed_Inputs();
            budget_Wizard_Fixed_Inputs.Show();
            this.Dispose();
        }

        private void Budget_Wizard_Input_Load(object sender, EventArgs e)
        {

        }
    }
}
