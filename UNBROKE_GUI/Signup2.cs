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
    public partial class Signup2 : Form
    {
        private string user;
        public Signup2(string user)
        {
            InitializeComponent();
            this.user = user;   
        }

        private void btnSetupProfile_Click(object sender, EventArgs e)
        {
            ProfileSetup profileSetup = new ProfileSetup(user);
            profileSetup.Show();
            this.Dispose();
        }

        private void Signup2_Load(object sender, EventArgs e)
        {

        }
    }
}
