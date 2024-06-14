using System.Drawing;

namespace UNBROKE_GUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblTotalBalanceText = new System.Windows.Forms.Label();
            this.lblTotalBalanceAmount = new System.Windows.Forms.Label();
            this.lblPesoSign = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblNoBudgetActivity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.link_lblBudgetWizard = new System.Windows.Forms.LinkLabel();
            this.lblDate = new System.Windows.Forms.Label();
            this.imgNotificationIcon = new System.Windows.Forms.PictureBox();
            this.imgTotalBalanceTitle = new System.Windows.Forms.PictureBox();
            this.txtTransactionTitle = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBudgetWizard2 = new System.Windows.Forms.Button();
            this.btnBudgetWizard1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotificationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBalanceTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalBalanceText
            // 
            this.lblTotalBalanceText.AutoSize = true;
            this.lblTotalBalanceText.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalBalanceText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBalanceText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalanceText.Location = new System.Drawing.Point(135, 112);
            this.lblTotalBalanceText.Name = "lblTotalBalanceText";
            this.lblTotalBalanceText.Size = new System.Drawing.Size(105, 22);
            this.lblTotalBalanceText.TabIndex = 30;
            this.lblTotalBalanceText.Text = "Total Balance";
            // 
            // lblTotalBalanceAmount
            // 
            this.lblTotalBalanceAmount.AutoSize = true;
            this.lblTotalBalanceAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBalanceAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalBalanceAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBalanceAmount.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalanceAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalBalanceAmount.Location = new System.Drawing.Point(90, 125);
            this.lblTotalBalanceAmount.Name = "lblTotalBalanceAmount";
            this.lblTotalBalanceAmount.Size = new System.Drawing.Size(141, 65);
            this.lblTotalBalanceAmount.TabIndex = 31;
            this.lblTotalBalanceAmount.Text = "₱0.00";
            this.lblTotalBalanceAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPesoSign
            // 
            this.lblPesoSign.AutoSize = true;
            this.lblPesoSign.BackColor = System.Drawing.Color.Transparent;
            this.lblPesoSign.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblPesoSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPesoSign.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoSign.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPesoSign.Location = new System.Drawing.Point(106, 92);
            this.lblPesoSign.Name = "lblPesoSign";
            this.lblPesoSign.Size = new System.Drawing.Size(0, 65);
            this.lblPesoSign.TabIndex = 32;
            this.lblPesoSign.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBudget.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(24, 221);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(67, 26);
            this.lblBudget.TabIndex = 33;
            this.lblBudget.Text = "Budget";
            this.lblBudget.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblActivity.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(24, 445);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(70, 26);
            this.lblActivity.TabIndex = 34;
            this.lblActivity.Text = "Activity";
            // 
            // lblNoBudgetActivity
            // 
            this.lblNoBudgetActivity.AutoSize = true;
            this.lblNoBudgetActivity.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNoBudgetActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoBudgetActivity.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBudgetActivity.Location = new System.Drawing.Point(68, 506);
            this.lblNoBudgetActivity.Name = "lblNoBudgetActivity";
            this.lblNoBudgetActivity.Size = new System.Drawing.Size(258, 38);
            this.lblNoBudgetActivity.TabIndex = 35;
            this.lblNoBudgetActivity.Text = "Looks like you haven’t added any expenses yet.\r\n              Set up your budget " +
    "to get started.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "You don’t have any budget at the moment.";
            // 
            // link_lblBudgetWizard
            // 
            this.link_lblBudgetWizard.ActiveLinkColor = System.Drawing.Color.Red;
            this.link_lblBudgetWizard.AutoSize = true;
            this.link_lblBudgetWizard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_lblBudgetWizard.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lblBudgetWizard.ForeColor = System.Drawing.Color.DarkRed;
            this.link_lblBudgetWizard.LinkColor = System.Drawing.Color.DarkRed;
            this.link_lblBudgetWizard.Location = new System.Drawing.Point(113, 384);
            this.link_lblBudgetWizard.Name = "link_lblBudgetWizard";
            this.link_lblBudgetWizard.Size = new System.Drawing.Size(176, 19);
            this.link_lblBudgetWizard.TabIndex = 37;
            this.link_lblBudgetWizard.TabStop = true;
            this.link_lblBudgetWizard.Text = "Click here to create a new one.";
            this.link_lblBudgetWizard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lblBudgetWizard_LinkClicked);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(276, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 22);
            this.lblDate.TabIndex = 39;
            // 
            // imgNotificationIcon
            // 
            this.imgNotificationIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgNotificationIcon.BackgroundImage")));
            this.imgNotificationIcon.Location = new System.Drawing.Point(99, 384);
            this.imgNotificationIcon.Name = "imgNotificationIcon";
            this.imgNotificationIcon.Size = new System.Drawing.Size(16, 16);
            this.imgNotificationIcon.TabIndex = 38;
            this.imgNotificationIcon.TabStop = false;
            // 
            // imgTotalBalanceTitle
            // 
            this.imgTotalBalanceTitle.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.imgTotalBalanceTitle.Image = ((System.Drawing.Image)(resources.GetObject("imgTotalBalanceTitle.Image")));
            this.imgTotalBalanceTitle.Location = new System.Drawing.Point(24, 12);
            this.imgTotalBalanceTitle.Name = "imgTotalBalanceTitle";
            this.imgTotalBalanceTitle.Size = new System.Drawing.Size(102, 28);
            this.imgTotalBalanceTitle.TabIndex = 29;
            this.imgTotalBalanceTitle.TabStop = false;
            // 
            // txtTransactionTitle
            // 
            this.txtTransactionTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTransactionTitle.Image = ((System.Drawing.Image)(resources.GetObject("txtTransactionTitle.Image")));
            this.txtTransactionTitle.Location = new System.Drawing.Point(35, 384);
            this.txtTransactionTitle.Name = "txtTransactionTitle";
            this.txtTransactionTitle.Size = new System.Drawing.Size(0, 0);
            this.txtTransactionTitle.TabIndex = 18;
            this.txtTransactionTitle.UseVisualStyleBackColor = true;
            this.txtTransactionTitle.Click += new System.EventHandler(this.txtTransactionTitle_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.Location = new System.Drawing.Point(283, 754);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(43, 44);
            this.btnProfile.TabIndex = 12;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(42, 750);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(79, 48);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnBudgetWizard2
            // 
            this.btnBudgetWizard2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBudgetWizard2.FlatAppearance.BorderSize = 0;
            this.btnBudgetWizard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgetWizard2.Image = ((System.Drawing.Image)(resources.GetObject("btnBudgetWizard2.Image")));
            this.btnBudgetWizard2.Location = new System.Drawing.Point(161, 685);
            this.btnBudgetWizard2.Name = "btnBudgetWizard2";
            this.btnBudgetWizard2.Size = new System.Drawing.Size(61, 65);
            this.btnBudgetWizard2.TabIndex = 10;
            this.btnBudgetWizard2.UseVisualStyleBackColor = true;
            this.btnBudgetWizard2.Click += new System.EventHandler(this.btnBudgetWizard2_Click);
            // 
            // btnBudgetWizard1
            // 
            this.btnBudgetWizard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBudgetWizard1.FlatAppearance.BorderSize = 0;
            this.btnBudgetWizard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgetWizard1.Image = ((System.Drawing.Image)(resources.GetObject("btnBudgetWizard1.Image")));
            this.btnBudgetWizard1.Location = new System.Drawing.Point(148, 274);
            this.btnBudgetWizard1.Name = "btnBudgetWizard1";
            this.btnBudgetWizard1.Size = new System.Drawing.Size(83, 82);
            this.btnBudgetWizard1.TabIndex = 7;
            this.btnBudgetWizard1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.imgNotificationIcon);
            this.Controls.Add(this.link_lblBudgetWizard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoBudgetActivity);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblPesoSign);
            this.Controls.Add(this.lblTotalBalanceText);
            this.Controls.Add(this.imgTotalBalanceTitle);
            this.Controls.Add(this.txtTransactionTitle);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnBudgetWizard2);
            this.Controls.Add(this.btnBudgetWizard1);
            this.Controls.Add(this.lblTotalBalanceAmount);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgNotificationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBalanceTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBudgetWizard1;
        private System.Windows.Forms.Button btnBudgetWizard2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button txtTransactionTitle;
        private System.Windows.Forms.PictureBox imgTotalBalanceTitle;
        private System.Windows.Forms.Label lblTotalBalanceText;
        private System.Windows.Forms.Label lblTotalBalanceAmount;
        private System.Windows.Forms.Label lblPesoSign;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblNoBudgetActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_lblBudgetWizard;
        private System.Windows.Forms.PictureBox imgNotificationIcon;
        private System.Windows.Forms.Label lblDate;
    }
}