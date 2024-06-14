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
    public partial class EditProfile : Form
    {
        private string currentuser;

        public EditProfile(String currentUser)
        {
            InitializeComponent();
            this.currentuser = currentUser;
        }

        private void imgDefaultPhoto_Click(object sender, EventArgs e)
        {

        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }

        private void lblUserpass_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Profile_Section dashboard_Profile_Section = new Dashboard_Profile_Section(currentuser);
            dashboard_Profile_Section.Show();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Edit_Profile_Confirm_Dialogs edit_Profile_Confirm_Dialogs = new Edit_Profile_Confirm_Dialogs();
            edit_Profile_Confirm_Dialogs.Show();
        }
    }
}
