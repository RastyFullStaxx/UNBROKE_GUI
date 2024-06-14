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
            Budget_Wizard_Input budget_Wizard_Input = new Budget_Wizard_Input(currentuser);
            budget_Wizard_Input.Show();
            this.Dispose();
        }

        private void Budget_Wizard_Date_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
