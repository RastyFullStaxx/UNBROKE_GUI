namespace UNBROKE_GUI
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.lblEditProfile = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.usernameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditUsername = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.userpasswordText = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditUserPassword = new System.Windows.Forms.Button();
            this.pnlLastName = new System.Windows.Forms.Panel();
            this.userlastnameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditLastName = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlFirstName = new System.Windows.Forms.Panel();
            this.userfirstnameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditFirstName = new System.Windows.Forms.Button();
            this.lblFullNameDisplay = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.imgDefaultPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlFullNameDisplay = new System.Windows.Forms.Panel();
            this.pnlUsername.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlLastName.SuspendLayout();
            this.pnlFirstName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDefaultPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.AutoSize = true;
            this.lblEditProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEditProfile.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProfile.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEditProfile.Location = new System.Drawing.Point(99, 68);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(179, 51);
            this.lblEditProfile.TabIndex = 36;
            this.lblEditProfile.Text = "Edit Profile";
            this.lblEditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPassword.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPassword.Location = new System.Drawing.Point(48, 431);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 23);
            this.lblPassword.TabIndex = 43;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUsername.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUsername.Location = new System.Drawing.Point(48, 362);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 23);
            this.lblUsername.TabIndex = 42;
            this.lblUsername.Text = "Username";
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlUsername.Controls.Add(this.usernameText);
            this.pnlUsername.Controls.Add(this.btnEditUsername);
            this.pnlUsername.Location = new System.Drawing.Point(22, 358);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(331, 56);
            this.pnlUsername.TabIndex = 44;
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.SystemColors.Window;
            this.usernameText.BorderColor = System.Drawing.Color.DarkGray;
            this.usernameText.BorderThickness = 0;
            this.usernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameText.DefaultText = "";
            this.usernameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.ForeColor = System.Drawing.Color.Black;
            this.usernameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameText.Location = new System.Drawing.Point(17, 30);
            this.usernameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameText.Name = "usernameText";
            this.usernameText.PasswordChar = '\0';
            this.usernameText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.usernameText.PlaceholderText = "username";
            this.usernameText.SelectedText = "";
            this.usernameText.Size = new System.Drawing.Size(200, 19);
            this.usernameText.TabIndex = 49;
            // 
            // btnEditUsername
            // 
            this.btnEditUsername.FlatAppearance.BorderSize = 0;
            this.btnEditUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUsername.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUsername.Image")));
            this.btnEditUsername.Location = new System.Drawing.Point(290, 15);
            this.btnEditUsername.Name = "btnEditUsername";
            this.btnEditUsername.Size = new System.Drawing.Size(24, 24);
            this.btnEditUsername.TabIndex = 48;
            this.btnEditUsername.UseVisualStyleBackColor = true;
            this.btnEditUsername.Click += new System.EventHandler(this.btnEditUsername_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlPassword.Controls.Add(this.userpasswordText);
            this.pnlPassword.Controls.Add(this.btnEditUserPassword);
            this.pnlPassword.Location = new System.Drawing.Point(22, 428);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(331, 56);
            this.pnlPassword.TabIndex = 45;
            // 
            // userpasswordText
            // 
            this.userpasswordText.BackColor = System.Drawing.SystemColors.Window;
            this.userpasswordText.BorderColor = System.Drawing.Color.DarkGray;
            this.userpasswordText.BorderThickness = 0;
            this.userpasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userpasswordText.DefaultText = "";
            this.userpasswordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userpasswordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userpasswordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userpasswordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userpasswordText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userpasswordText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userpasswordText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userpasswordText.ForeColor = System.Drawing.Color.Black;
            this.userpasswordText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userpasswordText.Location = new System.Drawing.Point(17, 29);
            this.userpasswordText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userpasswordText.Name = "userpasswordText";
            this.userpasswordText.PasswordChar = '\0';
            this.userpasswordText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.userpasswordText.PlaceholderText = "password";
            this.userpasswordText.SelectedText = "";
            this.userpasswordText.Size = new System.Drawing.Size(200, 19);
            this.userpasswordText.TabIndex = 50;
            // 
            // btnEditUserPassword
            // 
            this.btnEditUserPassword.FlatAppearance.BorderSize = 0;
            this.btnEditUserPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUserPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUserPassword.Image")));
            this.btnEditUserPassword.Location = new System.Drawing.Point(290, 14);
            this.btnEditUserPassword.Name = "btnEditUserPassword";
            this.btnEditUserPassword.Size = new System.Drawing.Size(24, 24);
            this.btnEditUserPassword.TabIndex = 49;
            this.btnEditUserPassword.UseVisualStyleBackColor = true;
            this.btnEditUserPassword.Click += new System.EventHandler(this.btnEditUserPassword_Click);
            // 
            // pnlLastName
            // 
            this.pnlLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlLastName.Controls.Add(this.userlastnameText);
            this.pnlLastName.Controls.Add(this.btnEditLastName);
            this.pnlLastName.Location = new System.Drawing.Point(22, 569);
            this.pnlLastName.Name = "pnlLastName";
            this.pnlLastName.Size = new System.Drawing.Size(331, 56);
            this.pnlLastName.TabIndex = 53;
            // 
            // userlastnameText
            // 
            this.userlastnameText.BackColor = System.Drawing.SystemColors.Window;
            this.userlastnameText.BorderColor = System.Drawing.Color.DarkGray;
            this.userlastnameText.BorderThickness = 0;
            this.userlastnameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userlastnameText.DefaultText = "";
            this.userlastnameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userlastnameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userlastnameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userlastnameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userlastnameText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userlastnameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userlastnameText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlastnameText.ForeColor = System.Drawing.Color.Black;
            this.userlastnameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userlastnameText.Location = new System.Drawing.Point(17, 29);
            this.userlastnameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userlastnameText.Name = "userlastnameText";
            this.userlastnameText.PasswordChar = '\0';
            this.userlastnameText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.userlastnameText.PlaceholderText = "last name";
            this.userlastnameText.SelectedText = "";
            this.userlastnameText.Size = new System.Drawing.Size(200, 19);
            this.userlastnameText.TabIndex = 52;
            // 
            // btnEditLastName
            // 
            this.btnEditLastName.FlatAppearance.BorderSize = 0;
            this.btnEditLastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLastName.Image = ((System.Drawing.Image)(resources.GetObject("btnEditLastName.Image")));
            this.btnEditLastName.Location = new System.Drawing.Point(290, 14);
            this.btnEditLastName.Name = "btnEditLastName";
            this.btnEditLastName.Size = new System.Drawing.Size(24, 24);
            this.btnEditLastName.TabIndex = 49;
            this.btnEditLastName.UseVisualStyleBackColor = true;
            this.btnEditLastName.Click += new System.EventHandler(this.btnEditLastName_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLastName.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLastName.Location = new System.Drawing.Point(48, 572);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(81, 23);
            this.lblLastName.TabIndex = 51;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFirstName.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFirstName.Location = new System.Drawing.Point(48, 503);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(82, 23);
            this.lblFirstName.TabIndex = 50;
            this.lblFirstName.Text = "First Name";
            // 
            // pnlFirstName
            // 
            this.pnlFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlFirstName.Controls.Add(this.userfirstnameText);
            this.pnlFirstName.Controls.Add(this.btnEditFirstName);
            this.pnlFirstName.Location = new System.Drawing.Point(22, 499);
            this.pnlFirstName.Name = "pnlFirstName";
            this.pnlFirstName.Size = new System.Drawing.Size(331, 56);
            this.pnlFirstName.TabIndex = 52;
            // 
            // userfirstnameText
            // 
            this.userfirstnameText.BackColor = System.Drawing.SystemColors.Window;
            this.userfirstnameText.BorderColor = System.Drawing.Color.DarkGray;
            this.userfirstnameText.BorderThickness = 0;
            this.userfirstnameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userfirstnameText.DefaultText = "";
            this.userfirstnameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userfirstnameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userfirstnameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userfirstnameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userfirstnameText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userfirstnameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userfirstnameText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userfirstnameText.ForeColor = System.Drawing.Color.Black;
            this.userfirstnameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userfirstnameText.Location = new System.Drawing.Point(17, 30);
            this.userfirstnameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userfirstnameText.Name = "userfirstnameText";
            this.userfirstnameText.PasswordChar = '\0';
            this.userfirstnameText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.userfirstnameText.PlaceholderText = "first name";
            this.userfirstnameText.SelectedText = "";
            this.userfirstnameText.Size = new System.Drawing.Size(200, 19);
            this.userfirstnameText.TabIndex = 51;
            // 
            // btnEditFirstName
            // 
            this.btnEditFirstName.FlatAppearance.BorderSize = 0;
            this.btnEditFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFirstName.Image = ((System.Drawing.Image)(resources.GetObject("btnEditFirstName.Image")));
            this.btnEditFirstName.Location = new System.Drawing.Point(290, 15);
            this.btnEditFirstName.Name = "btnEditFirstName";
            this.btnEditFirstName.Size = new System.Drawing.Size(24, 24);
            this.btnEditFirstName.TabIndex = 48;
            this.btnEditFirstName.UseVisualStyleBackColor = true;
            this.btnEditFirstName.Click += new System.EventHandler(this.btnEditFirstName_Click);
            // 
            // lblFullNameDisplay
            // 
            this.lblFullNameDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFullNameDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFullNameDisplay.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFullNameDisplay.Location = new System.Drawing.Point(25, 306);
            this.lblFullNameDisplay.Name = "lblFullNameDisplay";
            this.lblFullNameDisplay.Size = new System.Drawing.Size(325, 28);
            this.lblFullNameDisplay.TabIndex = 54;
            this.lblFullNameDisplay.Text = "FirstName LastName";
            this.lblFullNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(16, 709);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(343, 55);
            this.btnSave.TabIndex = 47;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadPhoto.Image")));
            this.btnUploadPhoto.Location = new System.Drawing.Point(248, 258);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(24, 24);
            this.btnUploadPhoto.TabIndex = 46;
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // imgDefaultPhoto
            // 
            this.imgDefaultPhoto.ImageRotate = 0F;
            this.imgDefaultPhoto.Location = new System.Drawing.Point(101, 128);
            this.imgDefaultPhoto.Name = "imgDefaultPhoto";
            this.imgDefaultPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgDefaultPhoto.Size = new System.Drawing.Size(170, 154);
            this.imgDefaultPhoto.TabIndex = 39;
            this.imgDefaultPhoto.TabStop = false;
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
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlFullNameDisplay
            // 
            this.pnlFullNameDisplay.AutoSize = true;
            this.pnlFullNameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlFullNameDisplay.Location = new System.Drawing.Point(22, 299);
            this.pnlFullNameDisplay.Name = "pnlFullNameDisplay";
            this.pnlFullNameDisplay.Size = new System.Drawing.Size(331, 41);
            this.pnlFullNameDisplay.TabIndex = 57;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.lblFullNameDisplay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.pnlFirstName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.imgDefaultPhoto);
            this.Controls.Add(this.lblEditProfile);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlLastName);
            this.Controls.Add(this.pnlFullNameDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.pnlUsername.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlLastName.ResumeLayout(false);
            this.pnlFirstName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgDefaultPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEditProfile;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgDefaultPhoto;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditUsername;
        private System.Windows.Forms.Button btnEditUserPassword;
        private System.Windows.Forms.Button btnEditLastName;
        private System.Windows.Forms.Button btnEditFirstName;
        private System.Windows.Forms.Panel pnlLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnlFirstName;
        private System.Windows.Forms.Label lblFullNameDisplay;
        private System.Windows.Forms.Panel pnlFullNameDisplay;
        private Guna.UI2.WinForms.Guna2TextBox usernameText;
        private Guna.UI2.WinForms.Guna2TextBox userpasswordText;
        private Guna.UI2.WinForms.Guna2TextBox userlastnameText;
        private Guna.UI2.WinForms.Guna2TextBox userfirstnameText;
    }
}