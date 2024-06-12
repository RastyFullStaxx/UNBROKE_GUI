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
    public partial class ProfileSetup : Form
    {
        private string usernamePlaceholder = "Enter valid password";
        private string passwordPlaceholder = "Enter valid password";


        public ProfileSetup()
        {
            InitializeComponent();
        }

        private void ProfileSetup_Load(object sender, EventArgs e)
        {
            //Placeholder classes
            Placeholder.SetPlaceholderUsername(txtUsername, usernamePlaceholder);
            Placeholder.SetPlaceholderPassword(txtPassword, passwordPlaceholder, btnShowpass);
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
            Greetings greetings = new Greetings();
            greetings.Show();
            this.Dispose();
        }
    }
}
