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
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            B_Launch b_Launch = new B_Launch();
            b_Launch.Show();
            this.Dispose();
        }

        private void lblCreateAcc2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Greetings greetings = new Greetings();
            greetings.Show();
            this.Dispose();
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the TextBox gains focus
            if (txtUsername.Text == "Enter valid username")
            {
                txtUsername.Text = "";
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            // Restore the placeholder text if the TextBox is empty
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Enter valid username";
            }
        }
        private void BtnShowpass_Click(object sender, EventArgs e)
        {
            // Toggle the UseSystemPasswordChar property
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            // Change the button icon based on the current state
            btnShowpass.Image = txtPassword.UseSystemPasswordChar ? Properties.Resources.ShowPassword : Properties.Resources.HidePassword;
        }

        private void GotoLogin_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 Login = new Form2();
            Login.Show();
            this.Dispose();
        }
    }
}
