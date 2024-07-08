using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace UNBROKE_GUI
{
    public partial class EditProfile : Form
    {
        private string currentuser;
        private DatabaseHelper db = DatabaseHelper.GetInstance();
        private int userID;
        private byte[] profileImageBytes;

        public EditProfile(string currentUser)
        {
            InitializeComponent();
            this.currentuser = currentUser;
            usernameText.Enabled = false;
            userpasswordText.Enabled = false;
            userfirstnameText.Enabled = false;
            userlastnameText.Enabled = false;

            userID = db.GetUserIdByUsername(currentUser);
            FetchUserInformation(userID);
        }

        private void FetchUserInformation(int userID)
        {
            try
            {
                string username = db.GetUsernamebyUserID(userID);
                string firstname = db.GetFirstNameByUserID(userID);
                string lastname = db.GetLastNameByUserID(userID);

                usernameText.Text = username;
                userfirstnameText.Text = firstname;
                userlastnameText.Text = lastname;

                // Display full name in label
                lblFullNameDisplay.Text = $"{firstname} {lastname}".Trim();

                // Get profile image and display
                byte[] profileImage = db.GetProfileImageByUsername(currentuser);
                if (profileImage != null && profileImage.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(profileImage))
                    {
                        Image originalImage = Image.FromStream(ms);
                        imgDefaultPhoto.Image = ResizeAndCropImage(originalImage, imgDefaultPhoto.Width, imgDefaultPhoto.Height);
                    }
                }
                else
                {
                    // Set default profile image if no image found
                    // imgDefaultPhoto.Image = Properties.Resources.default_profile_image;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching user profile: {ex.Message}");
                // Handle exception as needed
            }
        }

        private void UpdateUserProfile(int userID)
        {
            try
            {
                string username = usernameText.Text;
                string password = userpasswordText.Text;
                string firstname = userfirstnameText.Text;
                string lastname = userlastnameText.Text;

                // Hash password
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                // Convert profile image to byte array
                profileImageBytes = ImageToByteArray(imgDefaultPhoto.Image);

                // Update profile using DatabaseHelper method
                bool profileUpdated = db.UpdateProfile(userID, username, passwordHash, firstname, lastname, profileImageBytes);

                if (profileUpdated)
                {
                    FetchUserInformation(userID); // Refresh displayed information after update
                }
                else
                {
                    MessageBox.Show("Failed to update profile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}");
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png); // Save image to memory stream as PNG (adjust ImageFormat as needed)
                return ms.ToArray();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Profile_Section dashboardProfileSection = new Dashboard_Profile_Section(currentuser);
            dashboardProfileSection.Show();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Edit_Profile_Confirm_Dialogs editProfileConfirmDialog = new Edit_Profile_Confirm_Dialogs();
            if (editProfileConfirmDialog.ShowDialog() == DialogResult.OK)
            {
                UpdateUserProfile(userID); // Call method to update user profile
                Form2 loginForm = new Form2();
                loginForm.Show();
                this.Dispose();
            }
        }

        private void btnEditUsername_Click(object sender, EventArgs e)
        {
            usernameText.Enabled = true;
        }

        private void btnEditUserPassword_Click(object sender, EventArgs e)
        {
            userpasswordText.Enabled = true;
        }

        private void btnEditFirstName_Click(object sender, EventArgs e)
        {
            userfirstnameText.Enabled = true;
        }

        private void btnEditLastName_Click(object sender, EventArgs e)
        {
            userlastnameText.Enabled = true;
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



        private void EditProfile_Load(object sender, EventArgs e)
        {

        }

    }
}
