namespace UNBROKE_GUI
{
    partial class Greetings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Greetings));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProfileSetup = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 102);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnProfileSetup
            // 
            this.btnProfileSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileSetup.FlatAppearance.BorderSize = 0;
            this.btnProfileSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnProfileSetup.Image")));
            this.btnProfileSetup.Location = new System.Drawing.Point(16, 709);
            this.btnProfileSetup.Name = "btnProfileSetup";
            this.btnProfileSetup.Size = new System.Drawing.Size(343, 55);
            this.btnProfileSetup.TabIndex = 8;
            this.btnProfileSetup.UseVisualStyleBackColor = true;
            this.btnProfileSetup.Click += new System.EventHandler(this.btnProfileSetup_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.BackgroundImage")));
            this.imgLogo.Location = new System.Drawing.Point(214, 629);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(121, 90);
            this.imgLogo.TabIndex = 10;
            this.imgLogo.TabStop = false;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Poppins", 39.75F, System.Drawing.FontStyle.Bold);
            this.lblHello.Location = new System.Drawing.Point(40, 81);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(193, 93);
            this.lblHello.TabIndex = 11;
            this.lblHello.Text = "Hello,";
            this.lblHello.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Poppins", 39.75F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUser.Location = new System.Drawing.Point(40, 147);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(107, 93);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "%!";
            // 
            // Greetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnProfileSetup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Greetings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Greetings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProfileSetup;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblUser;
    }
}