using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace UNBROKE_GUI
{
    public partial class Financial_Library : Form
    {
        private string currentuser;

        public Financial_Library(String currentUser)
        {
            InitializeComponent();
            this.currentuser = currentUser;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://youtu.be/HQzoZfc3GwQ?si=mfMdMpvxwc3HTrfU";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string url = "https://www.efrennolasco.com/how-can-a-filipino-student-save-money-effectively/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Profile_Section dashboard_Profile_Section = new Dashboard_Profile_Section(currentuser);
            dashboard_Profile_Section.Show();
            this.Dispose();
        }

        private void imgResource1_Click(object sender, EventArgs e)
        {
            string url = "https://www.investopedia.com/ask/answers/022916/what-502030-budget-rule.asp";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource3_Click(object sender, EventArgs e)
        {
            string url = "https://www.rocketmoney.com/learn/personal-finance/the-definitive-guide-to-creating-a-budget-that-works";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource4_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=28FMPE2tH80&pp=ygUmaG93IHRvIGJ1ZGdldCBwaGlsaXBwaW5lcyBhcyBhIHN0dWRlbnQ%3D";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource5_Click(object sender, EventArgs e)
        {
            string url = "https://www.ucas.com/money-and-student-life/money/budgeting/student-budgeting-tips";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource6_Click(object sender, EventArgs e)
        {
            string url = "https://cnu.edu.ph/students-learn-to-manage-expenses/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource7_Click(object sender, EventArgs e)
        {
            string url = "https://www.workbc.ca/find-loans-and-grants/students-and-adult-learners/student-budgeting";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource9_Click(object sender, EventArgs e)
        {
            string url = "https://www.bestcolleges.com/blog/budgeting-tips-first-year-students/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource10_Click(object sender, EventArgs e)
        {
            string url = "https://moulshree.medium.com/7-budgeting-tips-to-manage-your-finances-like-a-pro-c5925c59029c";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource11_Click(object sender, EventArgs e)
        {
            string url = "https://roselynromero.com/2020/05/27/how-i-budget-in-college/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource12_Click(object sender, EventArgs e)
        {
            string url = "https://medium.com/@baheard16/how-to-budget-save-money-in-college-b92ed18abe96";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource13_Click(object sender, EventArgs e)
        {
            string url = "https://digido.ph/articles/student-loans/how-to-save-money-as-a-student-philippines";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource14_Click(object sender, EventArgs e)
        {
            string url = "https://singlife.com.ph/about/blog/basic-budgeting-tips-for-young-adults/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource15_Click(object sender, EventArgs e)
        {
            string url = "https://www.rappler.com/business/personal-finance/39443-creating-a-monthly-budget/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource16_Click(object sender, EventArgs e)
        {
            string url = "https://blog.youragora.com/school-budgets-made-simple-a-crash-course";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource17_Click(object sender, EventArgs e)
        {
            string url = "https://www.manulife.com.ph/about-us/blog/how-to-save-money-as-a-student.html";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource18_Click(object sender, EventArgs e)
        {
            string url = "https://bukas.ph/blog/tipid-tips-for-filipino-students/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource19_Click(object sender, EventArgs e)
        {
            string url = "https://www.simplyfinanceph.com/blog/simply-finance-101-the-4-core-money-beliefs";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource20_Click(object sender, EventArgs e)
        {
            string url = "https://www.voicesofyouth.org/blog/importance-budgeting-during-college";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void imgResource21_Click(object sender, EventArgs e)
        {
            string url = "https://www.vistaresidences.com.ph/blog/clever-tips-on-budgeting-your-allowance-as-a-college-student";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
