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
    public partial class Dashboard_Profile_Section : Form
    {
        public Dashboard_Profile_Section()
        {
            InitializeComponent();
        }

        private void imgProfileIcon_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            this.Dispose();
        }

        private void Dashboard_Setup_Profile_Load(object sender, EventArgs e)
        {

        }

        private void imgFeedbackIcon_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.Show();
            this.Dispose();
        }

        private void lblActivity_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.Show();
            this.Dispose();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            this.Dispose();
        }

        private void imgFinancialResourceIcon_Click(object sender, EventArgs e)
        {
            Financial_Library financial_Library = new Financial_Library();
            financial_Library.Show();
            this.Dispose();
        }

        private void lblFinancialResources_Click(object sender, EventArgs e)
        {
            Financial_Library financial_Library = new Financial_Library();
            financial_Library.Show();
            this.Dispose();
        }

        private void btnFinancialResources_Click(object sender, EventArgs e)
        {
            Financial_Library financial_Library = new Financial_Library();
            financial_Library.Show();
            this.Dispose();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Financial_Library financial_Library = new Financial_Library();
            financial_Library.Show();
            this.Dispose();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Dispose();
        }

        private void pnlEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            this.Dispose();
        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.Show();
            this.Dispose();
        }
    }
}
