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
    public partial class Greetings : Form
    {
        private string nameofUser;
        public Greetings(string nameofUser)
        {
            InitializeComponent();
            this.nameofUser = nameofUser;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Greetings_Load(object sender, EventArgs e)
        {
            lblUser.Text = nameofUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProfileSetup_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(nameofUser);
            dashboard.Show();
            this.Dispose();
        }
    }
}
