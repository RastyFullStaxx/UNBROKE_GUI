using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;


namespace UNBROKE_GUI
{
    public partial class Signup : Form
    {

        //Strings for userinfo
        private string usernamePlaceholder = "Enter valid username";
        private string passwordPlaceholder = "Enter valid password";
        private String username, password, passwordHash;
        private DatabaseHelper db = DatabaseHelper.GetInstance();

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
            username = txtUsername.Text;
            password = txtPassword.Text;

            passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            bool success = db.InsertUser(username, passwordHash);
            if (success)
            {
                Console.WriteLine("New user inserted");
            }
            else
            {
                Console.WriteLine("Failed to insert new user");
            }


            Signup2 signup = new Signup2(username);
            signup.Show();
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
