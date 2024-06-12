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
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Dispose();
        }

    } 

}
