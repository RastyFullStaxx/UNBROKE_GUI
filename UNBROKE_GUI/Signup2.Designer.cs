using System.Drawing;

namespace UNBROKE_GUI
{
    partial class Signup2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup2));
            this.imgAlmostThere = new System.Windows.Forms.PictureBox();
            this.btnSetupProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlmostThere)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAlmostThere
            // 
            this.imgAlmostThere.Image = ((System.Drawing.Image)(resources.GetObject("imgAlmostThere.Image")));
            this.imgAlmostThere.Location = new System.Drawing.Point(66, 168);
            this.imgAlmostThere.Name = "imgAlmostThere";
            this.imgAlmostThere.Size = new System.Drawing.Size(243, 246);
            this.imgAlmostThere.TabIndex = 0;
            this.imgAlmostThere.TabStop = false;
            this.imgAlmostThere.BackColor = Color.Transparent;
            // 
            // btnSetupProfile
            // 
            this.btnSetupProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetupProfile.FlatAppearance.BorderSize = 0;
            this.btnSetupProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetupProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnSetupProfile.Image")));
            this.btnSetupProfile.Location = new System.Drawing.Point(16, 709);
            this.btnSetupProfile.Name = "btnSetupProfile";
            this.btnSetupProfile.Size = new System.Drawing.Size(343, 55);
            this.btnSetupProfile.TabIndex = 6;
            this.btnSetupProfile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSetupProfile.UseVisualStyleBackColor = true;
            this.btnSetupProfile.Click += new System.EventHandler(this.btnSetupProfile_Click);
            // 
            // Signup2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.btnSetupProfile);
            this.Controls.Add(this.imgAlmostThere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Signup2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAlmostThere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAlmostThere;
        private System.Windows.Forms.Button btnSetupProfile;
    }
}