namespace UNBROKE_GUI
{
    partial class Budget_Wizard_Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget_Wizard_Input));
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblTotalBudget = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalBudget = new System.Windows.Forms.TextBox();
            this.lblPHP = new System.Windows.Forms.Label();
            this.lblPrompt1 = new System.Windows.Forms.Label();
            this.lblPrompt2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.imgGiantLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGiantLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBudget.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBudget.Location = new System.Drawing.Point(92, 23);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(197, 42);
            this.lblBudget.TabIndex = 34;
            this.lblBudget.Text = "Budget Wizard";
            // 
            // lblTotalBudget
            // 
            this.lblTotalBudget.AutoSize = true;
            this.lblTotalBudget.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBudget.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBudget.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalBudget.Location = new System.Drawing.Point(34, 227);
            this.lblTotalBudget.Name = "lblTotalBudget";
            this.lblTotalBudget.Size = new System.Drawing.Size(119, 23);
            this.lblTotalBudget.TabIndex = 35;
            this.lblTotalBudget.Text = "Set Total Budget";
            this.lblTotalBudget.Click += new System.EventHandler(this.lblTotalBudget_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotalBudget);
            this.panel1.Controls.Add(this.lblPHP);
            this.panel1.Location = new System.Drawing.Point(31, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 73);
            this.panel1.TabIndex = 36;
            // 
            // txtTotalBudget
            // 
            this.txtTotalBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalBudget.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalBudget.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBudget.Location = new System.Drawing.Point(53, 28);
            this.txtTotalBudget.Name = "txtTotalBudget";
            this.txtTotalBudget.Size = new System.Drawing.Size(245, 17);
            this.txtTotalBudget.TabIndex = 40;
            this.txtTotalBudget.Text = "5000";
            // 
            // lblPHP
            // 
            this.lblPHP.AutoSize = true;
            this.lblPHP.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPHP.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPHP.ForeColor = System.Drawing.Color.Black;
            this.lblPHP.Location = new System.Drawing.Point(12, 25);
            this.lblPHP.Name = "lblPHP";
            this.lblPHP.Size = new System.Drawing.Size(35, 23);
            this.lblPHP.TabIndex = 40;
            this.lblPHP.Text = "PHP";
            this.lblPHP.Click += new System.EventHandler(this.lblPHP_Click);
            // 
            // lblPrompt1
            // 
            this.lblPrompt1.AutoSize = true;
            this.lblPrompt1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrompt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrompt1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt1.ForeColor = System.Drawing.Color.Black;
            this.lblPrompt1.Location = new System.Drawing.Point(25, 110);
            this.lblPrompt1.Name = "lblPrompt1";
            this.lblPrompt1.Size = new System.Drawing.Size(334, 42);
            this.lblPrompt1.TabIndex = 37;
            this.lblPrompt1.Text = "What\'s your total budget?";
            // 
            // lblPrompt2
            // 
            this.lblPrompt2.AutoSize = true;
            this.lblPrompt2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrompt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrompt2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPrompt2.Location = new System.Drawing.Point(24, 146);
            this.lblPrompt2.Name = "lblPrompt2";
            this.lblPrompt2.Size = new System.Drawing.Size(276, 42);
            this.lblPrompt2.TabIndex = 38;
            this.lblPrompt2.Text = "We\'ll handle the rest!";
            this.lblPrompt2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(25, 708);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(319, 55);
            this.btnNext.TabIndex = 6;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += btnNext_Click;
            // 
            // imgGiantLogo
            // 
            this.imgGiantLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgGiantLogo.BackgroundImage")));
            this.imgGiantLogo.Location = new System.Drawing.Point(145, 332);
            this.imgGiantLogo.Name = "imgGiantLogo";
            this.imgGiantLogo.Size = new System.Drawing.Size(229, 474);
            this.imgGiantLogo.TabIndex = 39;
            this.imgGiantLogo.TabStop = false;
            // 
            // Budget_Wizard_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.lblPrompt2);
            this.Controls.Add(this.lblPrompt1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalBudget);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.imgGiantLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Budget_Wizard_Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget_Wizard_Input";
            this.Load += new System.EventHandler(this.Budget_Wizard_Input_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGiantLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TxtTotalBudget_Enter1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblTotalBudget;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrompt1;
        private System.Windows.Forms.Label lblPrompt2;
        private System.Windows.Forms.PictureBox imgGiantLogo;
        private System.Windows.Forms.TextBox txtTotalBudget;
        private System.Windows.Forms.Label lblPHP;
    }
}