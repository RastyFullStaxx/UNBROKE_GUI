namespace UNBROKE_GUI
{
    partial class Budget_Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget_Loading));
            this.lblLoadingDialogs = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoadingDialogs
            // 
            this.lblLoadingDialogs.AutoSize = true;
            this.lblLoadingDialogs.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLoadingDialogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoadingDialogs.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingDialogs.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLoadingDialogs.Location = new System.Drawing.Point(65, 201);
            this.lblLoadingDialogs.Name = "lblLoadingDialogs";
            this.lblLoadingDialogs.Size = new System.Drawing.Size(171, 42);
            this.lblLoadingDialogs.TabIndex = 42;
            this.lblLoadingDialogs.Text = "Budgetting...";
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.BackgroundImage")));
            this.imgLogo.Location = new System.Drawing.Point(72, 67);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(147, 94);
            this.imgLogo.TabIndex = 43;
            this.imgLogo.TabStop = false;
            // 
            // Budget_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblLoadingDialogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Budget_Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget_Loading";
            this.Load += new System.EventHandler(this.Budget_Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoadingDialogs;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}