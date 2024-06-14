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
    public partial class Feedback : Form
    {
        private string currentuser;

        public Feedback(String currentUser)
        {
            InitializeComponent();
            this.currentuser = currentUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Profile_Section dashboard_Profile_Section = new Dashboard_Profile_Section(currentuser);
            dashboard_Profile_Section.Show();
            this.Dispose();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }
    }
}
