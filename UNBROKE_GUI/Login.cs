using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNBROKE_GUI;


namespace UNBROKE_GUI
{

    public partial class Form2 : Form
    {
        private String usernamePlaceholder = "Enter valid username";
        private String passwordPlaceholder = "Enter valid password";
        private DatabaseHelper db = DatabaseHelper.GetInstance();
        private Authentication auth = new Authentication();

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Authentication.LoginStatus loginStatus = auth.Login(username, password);

            switch (loginStatus)
            {
                case Authentication.LoginStatus.Success:
                    // Check if profile setup is needed or not
                    bool profileSetupNeeded = !db.IsProfileSetup(username);

                    if (profileSetupNeeded)
                    {
                        ProfileSetup profile = new ProfileSetup(username);
                        profile.Show();
                        this.Hide();
                    }
                    else
                    {
                        Dashboard dashboardForm = new Dashboard(username);
                        dashboardForm.Show();
                        this.Hide();
                    }
                    break;

                case Authentication.LoginStatus.ProfileSetupNeeded:
                    ProfileSetup profileSetupForm = new ProfileSetup(username);
                    profileSetupForm.Show();
                    this.Hide();
                    break;

                case Authentication.LoginStatus.InvalidCredentials:
                    MessageBox.Show("Invalid username or password.");
                    break;

                case Authentication.LoginStatus.Error:
                    MessageBox.Show("An error occurred during login.");
                    break;

                default:
                    MessageBox.Show("An unexpected error occurred.");
                    break;
            }

        }
    }
}
