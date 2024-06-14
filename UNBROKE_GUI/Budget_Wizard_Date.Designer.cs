namespace UNBROKE_GUI
{
    partial class Budget_Wizard_Date
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget_Wizard_Date));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblSetDate = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblPrompt2 = new System.Windows.Forms.Label();
            this.lblPrompt1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.imgGiantLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGiantLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(32, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 73);
            this.panel1.TabIndex = 43;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.IndianRed;
            this.dateTimePicker.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(63, 21);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker.TabIndex = 41;
            // 
            // lblSetDate
            // 
            this.lblSetDate.AutoSize = true;
            this.lblSetDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSetDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSetDate.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetDate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSetDate.Location = new System.Drawing.Point(35, 228);
            this.lblSetDate.Name = "lblSetDate";
            this.lblSetDate.Size = new System.Drawing.Size(93, 23);
            this.lblSetDate.TabIndex = 42;
            this.lblSetDate.Text = "Set End Date";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBudget.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBudget.Location = new System.Drawing.Point(93, 24);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(197, 42);
            this.lblBudget.TabIndex = 41;
            this.lblBudget.Text = "Budget Wizard";
            // 
            // lblPrompt2
            // 
            this.lblPrompt2.AutoSize = true;
            this.lblPrompt2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrompt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrompt2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPrompt2.Location = new System.Drawing.Point(25, 147);
            this.lblPrompt2.Name = "lblPrompt2";
            this.lblPrompt2.Size = new System.Drawing.Size(203, 42);
            this.lblPrompt2.TabIndex = 45;
            this.lblPrompt2.Text = "budget will be?";
            // 
            // lblPrompt1
            // 
            this.lblPrompt1.AutoSize = true;
            this.lblPrompt1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrompt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrompt1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt1.ForeColor = System.Drawing.Color.Black;
            this.lblPrompt1.Location = new System.Drawing.Point(26, 111);
            this.lblPrompt1.Name = "lblPrompt1";
            this.lblPrompt1.Size = new System.Drawing.Size(263, 42);
            this.lblPrompt1.TabIndex = 44;
            this.lblPrompt1.Text = "First, until when this";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(26, 709);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(319, 55);
            this.btnNext.TabIndex = 40;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // imgGiantLogo
            // 
            this.imgGiantLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgGiantLogo.BackgroundImage")));
            this.imgGiantLogo.Location = new System.Drawing.Point(-176, 333);
            this.imgGiantLogo.Name = "imgGiantLogo";
            this.imgGiantLogo.Size = new System.Drawing.Size(424, 486);
            this.imgGiantLogo.TabIndex = 46;
            this.imgGiantLogo.TabStop = false;
            // 
            // Budget_Wizard_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSetDate);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPrompt2);
            this.Controls.Add(this.lblPrompt1);
            this.Controls.Add(this.imgGiantLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Budget_Wizard_Date";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget_Wizard_Date";
            this.Load += new System.EventHandler(this.Budget_Wizard_Date_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgGiantLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSetDate;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPrompt2;
        private System.Windows.Forms.Label lblPrompt1;
        private System.Windows.Forms.PictureBox imgGiantLogo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}