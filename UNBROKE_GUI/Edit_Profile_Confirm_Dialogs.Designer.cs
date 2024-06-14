namespace UNBROKE_GUI
{
    partial class Edit_Profile_Confirm_Dialogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Profile_Confirm_Dialogs));
            this.lblConfirmChanges = new System.Windows.Forms.Label();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.btnDeclineChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmChanges
            // 
            this.lblConfirmChanges.AutoSize = true;
            this.lblConfirmChanges.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblConfirmChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfirmChanges.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmChanges.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfirmChanges.Location = new System.Drawing.Point(71, 33);
            this.lblConfirmChanges.Name = "lblConfirmChanges";
            this.lblConfirmChanges.Size = new System.Drawing.Size(166, 28);
            this.lblConfirmChanges.TabIndex = 55;
            this.lblConfirmChanges.Text = "Confirm Changes?";
            this.lblConfirmChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmChanges.FlatAppearance.BorderSize = 0;
            this.btnConfirmChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmChanges.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmChanges.Image")));
            this.btnConfirmChanges.Location = new System.Drawing.Point(51, 70);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(90, 30);
            this.btnConfirmChanges.TabIndex = 56;
            this.btnConfirmChanges.UseVisualStyleBackColor = true;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // btnDeclineChanges
            // 
            this.btnDeclineChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeclineChanges.FlatAppearance.BorderSize = 0;
            this.btnDeclineChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeclineChanges.Image = ((System.Drawing.Image)(resources.GetObject("btnDeclineChanges.Image")));
            this.btnDeclineChanges.Location = new System.Drawing.Point(163, 70);
            this.btnDeclineChanges.Name = "btnDeclineChanges";
            this.btnDeclineChanges.Size = new System.Drawing.Size(90, 30);
            this.btnDeclineChanges.TabIndex = 57;
            this.btnDeclineChanges.UseVisualStyleBackColor = true;
            this.btnDeclineChanges.Click += new System.EventHandler(this.btnDeclineChanges_Click);
            // 
            // Edit_Profile_Confirm_Dialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 125);
            this.Controls.Add(this.btnDeclineChanges);
            this.Controls.Add(this.btnConfirmChanges);
            this.Controls.Add(this.lblConfirmChanges);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Profile_Confirm_Dialogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Profile_Confirm_Dialogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmChanges;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.Button btnDeclineChanges;
    }
}