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
        private String usernamePlaceholder = "Enter valid username";
        private String passwordPlaceholder = "Enter valid password";

        private bool isPasswordVisible = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SetPlaceholderUsername(txtUsername, usernamePlaceholder);
            SetPlaceholderPassword(txtPassword, passwordPlaceholder);
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


        //Placeholder for username
        private void SetPlaceholderUsername(TextBox textBox, string text)
        {
            textBox.Text = text;
            textBox.Font = new Font("Poppins", 8.25F);

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == text)
                {
                    textBox.Text = "";
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = text;
                }
            };
        }

        //Placeholder for password

        private void SetPlaceholderPassword(TextBox textBox, string text)
        {
            textBox.Text = text;
            textBox.Font = new Font("Poppins", 8.25F);
            textBox.UseSystemPasswordChar = false;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == text)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    textBox.UseSystemPasswordChar = !isPasswordVisible;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = text;
                    textBox.ForeColor = Color.Gray;
                    textBox.UseSystemPasswordChar = false;
                }
            };
        }
        private void BtnShowpass_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != passwordPlaceholder)
            {
                isPasswordVisible = !isPasswordVisible;
                txtPassword.UseSystemPasswordChar = !isPasswordVisible;
                btnShowpass.Image = isPasswordVisible ? Properties.Resources.HidePassword : Properties.Resources.ShowPassword;
            }
        }
    } 

}
