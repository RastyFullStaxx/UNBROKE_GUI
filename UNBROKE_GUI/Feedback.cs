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
    public partial class Feedback : Form
    {
        private string currentuser;
        private string userFeedback;

        public Feedback(String currentUser)
        {
            InitializeComponent();
            this.currentuser = currentUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Profile_Section dashboard_Profile_Section = new Dashboard_Profile_Section(currentuser);
            dashboard_Profile_Section.Show();
            this.Dispose();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feedback received, thank you!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

            Dashboard dashboardForm = new Dashboard(currentuser);
            dashboardForm.Show();


            userFeedback = txtComments.Text;

            Console.WriteLine(userFeedback);
        }

        private void btnOneStar_Click(object sender, EventArgs e)
        {
            // Update Button Images
            btnOneStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png"); 
            btnTwoStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnGreyStar.png"); 
            btnThreeStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnGreyStar.png"); 
            btnFourStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnGreyStar.png"); 
            btnFiveStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnGreyStar.png"); 

            // Store Rating 
            int rating = 1;             
        }

        private void btnTwoStar_Click(object sender, EventArgs e)
        {
            // Update Button Images
            btnOneStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnTwoStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnThreeStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnGreyStar.png");
            btnFourStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnGreyStar.png");
            btnFiveStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnGreyStar.png");

            // Store Rating 
            int rating = 2;
        }

        private void btnThreeStar_Click(object sender, EventArgs e)
        {
            // Update Button Images
            btnOneStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnTwoStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnThreeStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnFourStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnGreyStar.png");
            btnFiveStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnGreyStar.png");

            // Store Rating 
            int rating = 3;
        }

        private void btnFourStar_Click(object sender, EventArgs e)
        {
            // Update Button Images
            btnOneStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnTwoStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnThreeStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnFourStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnFiveStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnGreyStar.png");

            // Store Rating 
            int rating = 4;
        }

        private void btnFiveStar_Click(object sender, EventArgs e)
        {
            // Update Button Images
            btnOneStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnTwoStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnThreeStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnFourStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");
            btnFiveStar.Image = Image.FromFile("C:\\Users\\MSI\\OneDrive\\Attachments\\Documents\\UNBROKE\\UNBROKE\\assets\\btnYellowStar.png");

            // Store Rating 
            int rating = 5;
        }

        private void txtComments_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
