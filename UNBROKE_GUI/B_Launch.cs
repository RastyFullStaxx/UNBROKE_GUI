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
    public partial class B_Launch : Form
    {
        public B_Launch()
        {
            InitializeComponent();
        }

        private void B_Launch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Dispose();
        }
    }
}
