namespace UNBROKE_GUI
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblGreet2 = new System.Windows.Forms.Label();
            this.lblGreet1 = new System.Windows.Forms.Label();
            this.pnlRating = new System.Windows.Forms.Panel();
            this.btnFiveStar = new System.Windows.Forms.Button();
            this.btnFourStar = new System.Windows.Forms.Button();
            this.btnThreeStar = new System.Windows.Forms.Button();
            this.btnTwoStar = new System.Windows.Forms.Button();
            this.btnOneStar = new System.Windows.Forms.Button();
            this.lblRatingPrompt = new System.Windows.Forms.Label();
            this.pnlComments = new System.Windows.Forms.Panel();
            this.txtComments = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCommentPrompt = new System.Windows.Forms.Label();
            this.pnlRating.SuspendLayout();
            this.pnlComments.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.Location = new System.Drawing.Point(16, 709);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(343, 55);
            this.btnSubmit.TabIndex = 48;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFeedback.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFeedback.Location = new System.Drawing.Point(105, 34);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(170, 51);
            this.lblFeedback.TabIndex = 49;
            this.lblFeedback.Text = "Feedback";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreet2
            // 
            this.lblGreet2.AutoSize = true;
            this.lblGreet2.Font = new System.Drawing.Font("Poppins", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGreet2.Location = new System.Drawing.Point(30, 148);
            this.lblGreet2.Name = "lblGreet2";
            this.lblGreet2.Size = new System.Drawing.Size(187, 62);
            this.lblGreet2.TabIndex = 51;
            this.lblGreet2.Text = "matters!";
            // 
            // lblGreet1
            // 
            this.lblGreet1.AutoSize = true;
            this.lblGreet1.Font = new System.Drawing.Font("Poppins", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet1.Location = new System.Drawing.Point(30, 102);
            this.lblGreet1.Name = "lblGreet1";
            this.lblGreet1.Size = new System.Drawing.Size(254, 62);
            this.lblGreet1.TabIndex = 50;
            this.lblGreet1.Text = "Your opinion";
            // 
            // pnlRating
            // 
            this.pnlRating.Controls.Add(this.btnFiveStar);
            this.pnlRating.Controls.Add(this.btnFourStar);
            this.pnlRating.Controls.Add(this.btnThreeStar);
            this.pnlRating.Controls.Add(this.btnTwoStar);
            this.pnlRating.Controls.Add(this.btnOneStar);
            this.pnlRating.Controls.Add(this.lblRatingPrompt);
            this.pnlRating.Location = new System.Drawing.Point(41, 231);
            this.pnlRating.Name = "pnlRating";
            this.pnlRating.Size = new System.Drawing.Size(292, 83);
            this.pnlRating.TabIndex = 52;
            // 
            // btnFiveStar
            // 
            this.btnFiveStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiveStar.FlatAppearance.BorderSize = 0;
            this.btnFiveStar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiveStar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiveStar.Image")));
            this.btnFiveStar.Location = new System.Drawing.Point(150, 34);
            this.btnFiveStar.Name = "btnFiveStar";
            this.btnFiveStar.Size = new System.Drawing.Size(30, 30);
            this.btnFiveStar.TabIndex = 57;
            this.btnFiveStar.UseVisualStyleBackColor = true;
            this.btnFiveStar.Click += new System.EventHandler(this.btnFiveStar_Click);
            // 
            // btnFourStar
            // 
            this.btnFourStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFourStar.FlatAppearance.BorderSize = 0;
            this.btnFourStar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFourStar.Image = ((System.Drawing.Image)(resources.GetObject("btnFourStar.Image")));
            this.btnFourStar.Location = new System.Drawing.Point(114, 34);
            this.btnFourStar.Name = "btnFourStar";
            this.btnFourStar.Size = new System.Drawing.Size(30, 30);
            this.btnFourStar.TabIndex = 56;
            this.btnFourStar.UseVisualStyleBackColor = true;
            this.btnFourStar.Click += new System.EventHandler(this.btnFourStar_Click);
            // 
            // btnThreeStar
            // 
            this.btnThreeStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThreeStar.FlatAppearance.BorderSize = 0;
            this.btnThreeStar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThreeStar.Image = ((System.Drawing.Image)(resources.GetObject("btnThreeStar.Image")));
            this.btnThreeStar.Location = new System.Drawing.Point(79, 34);
            this.btnThreeStar.Name = "btnThreeStar";
            this.btnThreeStar.Size = new System.Drawing.Size(30, 30);
            this.btnThreeStar.TabIndex = 56;
            this.btnThreeStar.UseVisualStyleBackColor = true;
            this.btnThreeStar.Click += new System.EventHandler(this.btnThreeStar_Click);
            // 
            // btnTwoStar
            // 
            this.btnTwoStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwoStar.FlatAppearance.BorderSize = 0;
            this.btnTwoStar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwoStar.Image = ((System.Drawing.Image)(resources.GetObject("btnTwoStar.Image")));
            this.btnTwoStar.Location = new System.Drawing.Point(43, 34);
            this.btnTwoStar.Name = "btnTwoStar";
            this.btnTwoStar.Size = new System.Drawing.Size(30, 30);
            this.btnTwoStar.TabIndex = 55;
            this.btnTwoStar.UseVisualStyleBackColor = true;
            this.btnTwoStar.Click += new System.EventHandler(this.btnTwoStar_Click);
            // 
            // btnOneStar
            // 
            this.btnOneStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOneStar.FlatAppearance.BorderSize = 0;
            this.btnOneStar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneStar.Image = ((System.Drawing.Image)(resources.GetObject("btnOneStar.Image")));
            this.btnOneStar.Location = new System.Drawing.Point(7, 34);
            this.btnOneStar.Name = "btnOneStar";
            this.btnOneStar.Size = new System.Drawing.Size(30, 30);
            this.btnOneStar.TabIndex = 54;
            this.btnOneStar.UseVisualStyleBackColor = true;
            this.btnOneStar.Click += new System.EventHandler(this.btnOneStar_Click);
            // 
            // lblRatingPrompt
            // 
            this.lblRatingPrompt.AutoSize = true;
            this.lblRatingPrompt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRatingPrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRatingPrompt.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingPrompt.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRatingPrompt.Location = new System.Drawing.Point(3, 2);
            this.lblRatingPrompt.Name = "lblRatingPrompt";
            this.lblRatingPrompt.Size = new System.Drawing.Size(166, 23);
            this.lblRatingPrompt.TabIndex = 54;
            this.lblRatingPrompt.Text = "How would you rate us?";
            // 
            // pnlComments
            // 
            this.pnlComments.Controls.Add(this.txtComments);
            this.pnlComments.Controls.Add(this.lblCommentPrompt);
            this.pnlComments.Location = new System.Drawing.Point(41, 348);
            this.pnlComments.Name = "pnlComments";
            this.pnlComments.Size = new System.Drawing.Size(292, 314);
            this.pnlComments.TabIndex = 53;
            // 
            // txtComments
            // 
            this.txtComments.BorderColor = System.Drawing.Color.Transparent;
            this.txtComments.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComments.DefaultText = "";
            this.txtComments.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComments.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComments.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComments.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.txtComments.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComments.Location = new System.Drawing.Point(21, 38);
            this.txtComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.PasswordChar = '\0';
            this.txtComments.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComments.PlaceholderText = "Add your comments here...";
            this.txtComments.SelectedText = "";
            this.txtComments.Size = new System.Drawing.Size(245, 247);
            this.txtComments.TabIndex = 56;
            this.txtComments.TextChanged += new System.EventHandler(this.txtComments_TextChanged);
            // 
            // lblCommentPrompt
            // 
            this.lblCommentPrompt.AutoSize = true;
            this.lblCommentPrompt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCommentPrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCommentPrompt.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentPrompt.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCommentPrompt.Location = new System.Drawing.Point(3, 2);
            this.lblCommentPrompt.Name = "lblCommentPrompt";
            this.lblCommentPrompt.Size = new System.Drawing.Size(155, 23);
            this.lblCommentPrompt.TabIndex = 55;
            this.lblCommentPrompt.Text = "Tell us your thoughts!";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.pnlComments);
            this.Controls.Add(this.pnlRating);
            this.Controls.Add(this.lblGreet2);
            this.Controls.Add(this.lblGreet1);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.pnlRating.ResumeLayout(false);
            this.pnlRating.PerformLayout();
            this.pnlComments.ResumeLayout(false);
            this.pnlComments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblGreet2;
        private System.Windows.Forms.Label lblGreet1;
        private System.Windows.Forms.Panel pnlRating;
        private System.Windows.Forms.Panel pnlComments;
        private System.Windows.Forms.Label lblRatingPrompt;
        private System.Windows.Forms.Label lblCommentPrompt;
        private System.Windows.Forms.Button btnOneStar;
        private System.Windows.Forms.Button btnFiveStar;
        private System.Windows.Forms.Button btnFourStar;
        private System.Windows.Forms.Button btnThreeStar;
        private System.Windows.Forms.Button btnTwoStar;
        private Guna.UI2.WinForms.Guna2TextBox txtComments;
    }
}