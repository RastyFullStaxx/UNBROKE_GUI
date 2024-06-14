using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNBROKE_GUI
{
    public partial class Dashboard_Profile_Section : Form
    {
        private string currentuser;

        public Dashboard_Profile_Section(String currentUser)
        {
            InitializeComponent();
            this.currentuser = currentUser;
        }

        private void imgProfileIcon_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(currentuser);
            editProfile.Show();
            this.Dispose();
        }

        private void Dashboard_Setup_Profile_Load(object sender, EventArgs e)
        {
            // Fetch user information from the database
            DatabaseHelper db = DatabaseHelper.GetInstance();
            try
            {
                // Get user ID using current username
                int userId = db.GetUserIdByUsername(currentuser);

                if (userId != -1)
                {
                    // Get first name
                    string firstName = db.GetFirstNameByUserID(userId);
                    // Get last name (if needed)
                    string lastName = db.GetLastNameByUserID(userId);

                    // Display full name with space
                    string fullName = firstName;
                    if (!string.IsNullOrEmpty(lastName))
                    {
                        fullName += " " + lastName;
                    }
                    lblFullNameDisplay.Text = fullName.Trim(); // Trim to remove any extra spaces


                    // Get profile image
                    byte[] profileImage = db.GetProfileImageByUsername(currentuser);
                    if (profileImage != null && profileImage.Length > 0)
                    {
                        // Display profile image
                        using (MemoryStream ms = new MemoryStream(profileImage))
                        {
                            imgDefaultPhoto.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Set default profile image if no image found
                        //imgDefaultPhoto.Image = Properties.Resources.default_profile_image;
                    }
                }
                else
                {
                    MessageBox.Show("User not found. Please log in again.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching user profile: {ex.Message}");
                // Handle exception as needed
            }
        }

        private void imgFeedbackIcon_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(currentuser);
            feedback.Show();
            this.Dispose();
        }

        private void lblActivity_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(currentuser);
            editProfile.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(currentuser);
            feedback.Show();
            this.Dispose();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(currentuser);
            editProfile.Show();
            this.Dispose();
        }

        private void imgFinancialResourceIcon_Click(object sender, EventArgs e)
        {
            Financial_Library financial_Library = new Financial_Library(currentuser);
            financial_Library.Show();
            this.Dispose();
        }

        private void lblFinancialResources_Click(object sender, EventArgs e)
        {
            Financial_Library financial_Library = new Financial_Library(currentuser);
            financial_Library.Show();
            this.Dispose();
        }

        private void btnFinancialResources_Click(object sender, EventArgs e)
        {
            Financial_Library financial_Library = new Financial_Library(currentuser);
            financial_Library.Show();
            this.Dispose();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Financial_Library financial_Library = new Financial_Library(currentuser);
            financial_Library.Show();
            this.Dispose();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentuser);
            dashboard.Show();
            this.Dispose();
        }

        private void pnlEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(currentuser);
            editProfile.Show();
            this.Dispose();
        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(currentuser);
            feedback.Show();
            this.Dispose();
        }
    }
}
