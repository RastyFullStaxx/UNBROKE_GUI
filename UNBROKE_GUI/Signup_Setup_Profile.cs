using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNBROKE_GUI
{
    public partial class ProfileSetup : Form
    {
        private string firstnamePlaceholder = "Enter your first name";
        private string lastnamePlaceholder = "Enter your last name";
        private DatabaseHelper db = DatabaseHelper.GetInstance();
        private string firstname, lastname;
        private byte[] profileImageBytes;
        private string user;
        private int userID;
        public ProfileSetup(string user)
        {
            InitializeComponent();
            this.user = user;
            userID = db.GetUserIdByUsername(user);

        }

        private void ProfileSetup_Load(object sender, EventArgs e)
        {
            //Placeholder classes
            Placeholder.SetPlaceholderUsername(txtFName, firstnamePlaceholder);
            Placeholder.SetPlaceholderUsername(txtLName, lastnamePlaceholder);

        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected image file path
                string imagePath = openFileDialog.FileName;

                // Load the selected image into the imgDefaultPhoto control
                imgDefaultPhoto.Image = Image.FromFile(imagePath);
            }
        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            firstname = txtFName.Text;
            lastname = txtLName.Text;
            profileImageBytes = ImageToByteArray(imgDefaultPhoto.Image);
            bool isProfileDone = true;

            bool profile = db.SetupProfile(userID, firstname, lastname, profileImageBytes, isProfileDone);

            if (profile)
            {
                Console.WriteLine("Set up successfully");
            }
            else
            {
                Console.WriteLine("Failed to set up");
            }

            Greetings greetings = new Greetings(firstname);
            greetings.Show();
            this.Dispose();
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png); // Adjust ImageFormat based on your requirements
                return ms.ToArray();
            }
        }
    }
}
