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
    public partial class Signup : Form
    {
        private string usernamePlaceholder = "Enter valid password";
        private string passwordPlaceholder = "Enter valid password";
        public Signup()
        {
            InitializeComponent();
        }
        private void Signup_Load(object sender, EventArgs e)
        {
            //Placeholder classes
            Placeholder.SetPlaceholderUsername(txtUsername, usernamePlaceholder);
            Placeholder.SetPlaceholderPassword(txtPassword, passwordPlaceholder, btnShowpass);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B_Launch b_Launch = new B_Launch();
            b_Launch.Show();
            this.Dispose();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup2 greetings = new Signup2();
            greetings.Show();
            this.Dispose();
        }

        private void GotoLogin_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 Login = new Form2();
            Login.Show();
            this.Dispose();
        }
    }
}
