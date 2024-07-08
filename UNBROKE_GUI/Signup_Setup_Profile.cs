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
                string imagePath = openFileDialog.FileName;
                imgDefaultPhoto.SizeMode = PictureBoxSizeMode.Zoom; // Set size mode to normal for manual resizing

                // Load the selected image into the imgDefaultPhoto control
                Image originalImage = Image.FromFile(imagePath);
                imgDefaultPhoto.Image = ResizeAndCropImage(originalImage, imgDefaultPhoto.Width, imgDefaultPhoto.Height);
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
        private Image ResizeAndCropImage(Image image, int targetWidth, int targetHeight)
        {
            float aspectRatio = (float)image.Width / image.Height;
            float targetRatio = (float)targetWidth / targetHeight;

            int newWidth, newHeight;
            int cropX = 0, cropY = 0;

            if (aspectRatio > targetRatio)
            {
                newHeight = targetHeight;
                newWidth = (int)(newHeight * aspectRatio);
                cropX = (newWidth - targetWidth) / 2;
            }
            else
            {
                newWidth = targetWidth;
                newHeight = (int)(newWidth / aspectRatio);
                cropY = (newHeight - targetHeight) / 2;
            }

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            Bitmap croppedImage = new Bitmap(targetWidth, targetHeight);
            using (Graphics graphics = Graphics.FromImage(croppedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(resizedImage, -cropX, -cropY, newWidth, newHeight);
            }

            return croppedImage;
        }
    }
}
