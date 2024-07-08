namespace UNBROKE_GUI
{
    partial class Budget_Loaded
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget_Loaded));
            this.btnNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGoToBudgetWizardResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(19, 704);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(335, 55);
            this.btnNext.TabIndex = 41;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGoToBudgetWizardResults
            // 
            this.btnGoToBudgetWizardResults.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToBudgetWizardResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToBudgetWizardResults.FlatAppearance.BorderSize = 0;
            this.btnGoToBudgetWizardResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToBudgetWizardResults.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToBudgetWizardResults.Image")));
            this.btnGoToBudgetWizardResults.Location = new System.Drawing.Point(19, 653);
            this.btnGoToBudgetWizardResults.Name = "btnGoToBudgetWizardResults";
            this.btnGoToBudgetWizardResults.Size = new System.Drawing.Size(335, 55);
            this.btnGoToBudgetWizardResults.TabIndex = 42;
            this.btnGoToBudgetWizardResults.UseVisualStyleBackColor = true;
            this.btnGoToBudgetWizardResults.Click += new System.EventHandler(this.btnGoToBudgetWizardResults_Click);
            // 
            // Budget_Loaded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.btnGoToBudgetWizardResults);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Budget_Loaded";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget_Loaded";
            this.Load += new System.EventHandler(this.Budget_Loaded_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGoToBudgetWizardResults;
    }
}