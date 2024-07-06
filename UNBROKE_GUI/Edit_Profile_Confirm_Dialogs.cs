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
    public partial class Edit_Profile_Confirm_Dialogs : Form
    {
        public Edit_Profile_Confirm_Dialogs()
        {
            InitializeComponent();
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; // Set DialogResult to OK when confirming changes

            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Dispose();
        }

        private void btnDeclineChanges_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Set DialogResult to Cancel when declining changes
            this.Dispose();
            Form2 loginForm = new Form2();
            loginForm.Show();
        }

        private void Edit_Profile_Confirm_Dialogs_Load(object sender, EventArgs e)
        {

        }
    }
}
