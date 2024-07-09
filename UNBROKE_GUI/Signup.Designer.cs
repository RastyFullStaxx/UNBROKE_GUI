using System.Drawing;

namespace UNBROKE_GUI
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblAskingAccount = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShowpass = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreateAcc1 = new System.Windows.Forms.Label();
            this.lblCreateAcc2 = new System.Windows.Forms.Label();
            this.lnblLogin = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSignup
            // 
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Image = ((System.Drawing.Image)(resources.GetObject("btnSignup.Image")));
            this.btnSignup.Location = new System.Drawing.Point(16, 709);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(343, 55);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblAskingAccount
            // 
            this.lblAskingAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAskingAccount.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskingAccount.ForeColor = System.Drawing.Color.Black;
            this.lblAskingAccount.Location = new System.Drawing.Point(85, 681);
            this.lblAskingAccount.Multiline = true;
            this.lblAskingAccount.Name = "lblAskingAccount";
            this.lblAskingAccount.ReadOnly = true;
            this.lblAskingAccount.Size = new System.Drawing.Size(177, 27);
            this.lblAskingAccount.TabIndex = 6;
            this.lblAskingAccount.Text = "Already have an account?";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(24, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(16, 16);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowpass
            // 
            this.btnShowpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowpass.FlatAppearance.BorderSize = 0;
            this.btnShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowpass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowpass.Image")));
            this.btnShowpass.Location = new System.Drawing.Point(315, 330);
            this.btnShowpass.Name = "btnShowpass";
            this.btnShowpass.Size = new System.Drawing.Size(24, 24);
            this.btnShowpass.TabIndex = 12;
            this.btnShowpass.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPassword.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPassword.Location = new System.Drawing.Point(49, 324);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 23);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUsername.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUsername.Location = new System.Drawing.Point(49, 255);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 23);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(48, 279);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(245, 17);
            this.txtUsername.TabIndex = 16;
            this.txtUsername.Text = "Enter valid username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(22, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 56);
            this.panel1.TabIndex = 20;
            // 
            // lblCreateAcc1
            // 
            this.lblCreateAcc1.AutoSize = true;
            this.lblCreateAcc1.Font = new System.Drawing.Font("Poppins", 39.75F, System.Drawing.FontStyle.Bold);
            this.lblCreateAcc1.Location = new System.Drawing.Point(20, 36);
            this.lblCreateAcc1.Name = "lblCreateAcc1";
            this.lblCreateAcc1.Size = new System.Drawing.Size(310, 93);
            this.lblCreateAcc1.TabIndex = 22;
            this.lblCreateAcc1.Text = "Create an";
            // 
            // lblCreateAcc2
            // 
            this.lblCreateAcc2.AutoSize = true;
            this.lblCreateAcc2.Font = new System.Drawing.Font("Poppins", 39.75F, System.Drawing.FontStyle.Bold);
            this.lblCreateAcc2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCreateAcc2.Location = new System.Drawing.Point(22, 97);
            this.lblCreateAcc2.Name = "lblCreateAcc2";
            this.lblCreateAcc2.Size = new System.Drawing.Size(268, 93);
            this.lblCreateAcc2.TabIndex = 23;
            this.lblCreateAcc2.Text = "account";
            // 
            // lnblLogin
            // 
            this.lnblLogin.AutoSize = true;
            this.lnblLogin.Font = new System.Drawing.Font("Poppins", 9F);
            this.lnblLogin.LinkColor = System.Drawing.Color.DarkRed;
            this.lnblLogin.Location = new System.Drawing.Point(246, 681);
            this.lnblLogin.Name = "lnblLogin";
            this.lnblLogin.Size = new System.Drawing.Size(45, 22);
            this.lnblLogin.TabIndex = 24;
            this.lnblLogin.TabStop = true;
            this.lnblLogin.Text = "Log in";
            this.lnblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GotoLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(48, 348);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(245, 17);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(22, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 56);
            this.panel2.TabIndex = 21;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.lnblLogin);
            this.Controls.Add(this.lblCreateAcc2);
            this.Controls.Add(this.lblCreateAcc1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnShowpass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAskingAccount);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox lblAskingAccount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShowpass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateAcc1;
        private System.Windows.Forms.Label lblCreateAcc2;
        private System.Windows.Forms.LinkLabel lnblLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel2;
    }
}