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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtPassword.Text = "Enter password";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            B_Launch b_Launch = new B_Launch();
            b_Launch.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Dispose();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
