namespace UNBROKE_GUI
{
    partial class ProfileSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSetup));
            this.imgDefaultPhoto = new System.Windows.Forms.PictureBox();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnShowPass = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProfileSetup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDefaultPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDefaultPhoto
            // 
            this.imgDefaultPhoto.Image = ((System.Drawing.Image)(resources.GetObject("imgDefaultPhoto.Image")));
            this.imgDefaultPhoto.Location = new System.Drawing.Point(123, 148);
            this.imgDefaultPhoto.Name = "imgDefaultPhoto";
            this.imgDefaultPhoto.Size = new System.Drawing.Size(128, 128);
            this.imgDefaultPhoto.TabIndex = 2;
            this.imgDefaultPhoto.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadPhoto.Image")));
            this.btnUploadPhoto.Location = new System.Drawing.Point(212, 252);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(24, 24);
            this.btnUploadPhoto.TabIndex = 3;
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Image = ((System.Drawing.Image)(resources.GetObject("btnContinue.Image")));
            this.btnContinue.Location = new System.Drawing.Point(16, 709);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(343, 55);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowPass.BackgroundImage")));
            this.btnShowPass.Location = new System.Drawing.Point(316, 405);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(24, 24);
            this.btnShowPass.TabIndex = 11;
            this.btnShowPass.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPassword.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPassword.Location = new System.Drawing.Point(48, 397);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 23);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUsername.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUsername.Location = new System.Drawing.Point(47, 329);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 23);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(47, 421);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(245, 17);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(46, 353);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(245, 17);
            this.txtUsername.TabIndex = 22;
            this.txtUsername.Text = "Enter valid username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(20, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 56);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(21, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 56);
            this.panel2.TabIndex = 27;
            // 
            // lblProfileSetup
            // 
            this.lblProfileSetup.AutoSize = true;
            this.lblProfileSetup.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblProfileSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProfileSetup.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.lblProfileSetup.Location = new System.Drawing.Point(80, 68);
            this.lblProfileSetup.Name = "lblProfileSetup";
            this.lblProfileSetup.Size = new System.Drawing.Size(216, 51);
            this.lblProfileSetup.TabIndex = 35;
            this.lblProfileSetup.Text = "Profile Set Up";
            // 
            // ProfileSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.lblProfileSetup);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.imgDefaultPhoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.ProfileSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDefaultPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgDefaultPhoto;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox btnShowPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProfileSetup;
    }
}