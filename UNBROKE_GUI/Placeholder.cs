using System;
using System.Drawing;
using System.Windows.Forms;

namespace UNBROKE_GUI
{
    internal static class Placeholder
    {
        private static bool isPasswordVisible = false;

        public static void SetPlaceholderUsername(TextBox textBox, string text)
        {
            textBox.Text = text;
            textBox.Font = new Font("Poppins", 8.25F);

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == text)
                {
                    textBox.Text = "";
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = text;
                }
            };
        }
        public static void SetFixedInput(TextBox textBox, string text)
        {
            textBox.Text = text;
            textBox.Font = new Font("Poppins", 8.25F);

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == text)
                {
                    textBox.Text = "";
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = text;
                }
            };
        }
        public static void SetBudget(TextBox textBox, string text)
        {
            textBox.Text = text;
            textBox.Font = new Font("Poppins", 8.25F);

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == text)
                {
                    textBox.Text = "";
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = text;
                }
            };
        }

        public static void SetPlaceholderPassword(TextBox textBox, string text, Button btnShowpass)
        {
            textBox.Text = text;
            textBox.Font = new Font("Poppins", 8.25F);
            textBox.UseSystemPasswordChar = false;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == text)
                {
                    textBox.Text = "";
                    textBox.UseSystemPasswordChar = !isPasswordVisible;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = text;
                    textBox.UseSystemPasswordChar = false;
                }
            };

            btnShowpass.Click += (sender, e) =>
            {
                if (textBox.Text != text)
                {
                    isPasswordVisible = !isPasswordVisible;
                    textBox.UseSystemPasswordChar = !isPasswordVisible;
                    btnShowpass.Image = isPasswordVisible ? Properties.Resources.HidePassword : Properties.Resources.ShowPassword;
                }
            };
        }
    }
}
