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
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProfileSetup = new System.Windows.Forms.Label();
            this.imgDefaultPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDefaultPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadPhoto.Image")));
            this.btnUploadPhoto.Location = new System.Drawing.Point(250, 252);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(24, 24);
            this.btnUploadPhoto.TabIndex = 3;
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
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
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click_1);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLName.Location = new System.Drawing.Point(48, 397);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(81, 16);
            this.lblLName.TabIndex = 25;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFName.Location = new System.Drawing.Point(47, 329);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(82, 16);
            this.lblFName.TabIndex = 24;
            this.lblFName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(46, 353);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(245, 13);
            this.txtFName.TabIndex = 22;
            this.txtFName.Text = "Enter first name";
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
            this.lblProfileSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileSetup.ForeColor = System.Drawing.Color.DarkRed;
            this.lblProfileSetup.Location = new System.Drawing.Point(80, 68);
            this.lblProfileSetup.Name = "lblProfileSetup";
            this.lblProfileSetup.Size = new System.Drawing.Size(208, 33);
            this.lblProfileSetup.TabIndex = 35;
            this.lblProfileSetup.Text = "Profile Set Up";
            // 
            // imgDefaultPhoto
            // 
            this.imgDefaultPhoto.ImageRotate = 0F;
            this.imgDefaultPhoto.Location = new System.Drawing.Point(105, 122);
            this.imgDefaultPhoto.Name = "imgDefaultPhoto";
            this.imgDefaultPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgDefaultPhoto.Size = new System.Drawing.Size(170, 165);
            this.imgDefaultPhoto.TabIndex = 36;
            this.imgDefaultPhoto.TabStop = false;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(46, 425);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(245, 13);
            this.txtLName.TabIndex = 37;
            this.txtLName.Text = "Enter last name";
            // 
            // ProfileSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.imgDefaultPhoto);
            this.Controls.Add(this.lblProfileSetup);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.btnContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.ProfileSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDefaultPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.Button btnContinue;

        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProfileSetup;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgDefaultPhoto;
        private System.Windows.Forms.TextBox txtLName;
    }
}