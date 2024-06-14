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
    public partial class Budget_Loading : Form
    {
        private string currentuser;

        public Budget_Loading(String currentUser)
        {
            InitializeComponent();
            this.currentuser = currentUser;
        }

        private void Budget_Loading_Load(object sender, EventArgs e)
        {
            // Create a Timer with a 3-second interval
            Timer loadingTimer = new Timer();
            loadingTimer.Interval = 3000; // 3000 milliseconds = 3 seconds

            // Handle the Timer's Tick event
            loadingTimer.Tick += (s, args) =>
            {
                loadingTimer.Stop(); // Stop the timer

                // Load the next form
                Budget_Loaded budgetLoadedForm = new Budget_Loaded(currentuser);
                budgetLoadedForm.Show();

                // Close the current loading form
                this.Close();
            };

            // Start the timer
            loadingTimer.Start();
        }
    }
}
