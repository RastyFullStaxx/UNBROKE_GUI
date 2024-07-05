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
            this.pnlBalanceAmount = new System.Windows.Forms.Panel();
            this.pnlExpenseBreakdowns = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHistoryTotalBudget = new System.Windows.Forms.Label();
            this.lblTotalBudget1 = new System.Windows.Forms.Label();
            this.lblEndDateDisplay = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDateDisplay = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotificationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBalanceTitle)).BeginInit();
            this.pnlBalanceAmount.SuspendLayout();
            this.pnlExpenseBreakdowns.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.lblTotalBalanceAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBalanceAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalBalanceAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBalanceAmount.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalanceAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalBalanceAmount.Location = new System.Drawing.Point(5, 42);
            this.lblTotalBalanceAmount.Name = "lblTotalBalanceAmount";
            this.lblTotalBalanceAmount.Size = new System.Drawing.Size(307, 65);
            this.lblTotalBalanceAmount.TabIndex = 31;
            this.lblTotalBalanceAmount.Text = "₱0.00";
            this.lblTotalBalanceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblActivity.Size = new System.Drawing.Size(0, 26);
            this.lblActivity.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 117);
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
            this.link_lblBudgetWizard.Location = new System.Drawing.Point(89, 136);
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
            this.imgNotificationIcon.Location = new System.Drawing.Point(75, 136);
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
            this.btnBudgetWizard1.Location = new System.Drawing.Point(124, 26);
            this.btnBudgetWizard1.Name = "btnBudgetWizard1";
            this.btnBudgetWizard1.Size = new System.Drawing.Size(83, 82);
            this.btnBudgetWizard1.TabIndex = 7;
            this.btnBudgetWizard1.UseVisualStyleBackColor = true;
            // 
            // pnlBalanceAmount
            // 
            this.pnlBalanceAmount.AutoSize = true;
            this.pnlBalanceAmount.BackColor = System.Drawing.Color.Transparent;
            this.pnlBalanceAmount.Controls.Add(this.lblTotalBalanceAmount);
            this.pnlBalanceAmount.Location = new System.Drawing.Point(24, 92);
            this.pnlBalanceAmount.Name = "pnlBalanceAmount";
            this.pnlBalanceAmount.Size = new System.Drawing.Size(334, 108);
            this.pnlBalanceAmount.TabIndex = 57;
            // 
            // pnlExpenseBreakdowns
            // 
            this.pnlExpenseBreakdowns.AutoSize = true;
            this.pnlExpenseBreakdowns.BackColor = System.Drawing.Color.Transparent;
            this.pnlExpenseBreakdowns.Controls.Add(this.panel1);
            this.pnlExpenseBreakdowns.Controls.Add(this.btnBudgetWizard1);
            this.pnlExpenseBreakdowns.Controls.Add(this.imgNotificationIcon);
            this.pnlExpenseBreakdowns.Controls.Add(this.label1);
            this.pnlExpenseBreakdowns.Controls.Add(this.link_lblBudgetWizard);
            this.pnlExpenseBreakdowns.Location = new System.Drawing.Point(24, 250);
            this.pnlExpenseBreakdowns.Name = "pnlExpenseBreakdowns";
            this.pnlExpenseBreakdowns.Size = new System.Drawing.Size(334, 466);
            this.pnlExpenseBreakdowns.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEndDateDisplay);
            this.panel1.Controls.Add(this.lblTotalBudget1);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.lblHistoryTotalBudget);
            this.panel1.Controls.Add(this.lblStartDateDisplay);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Location = new System.Drawing.Point(18, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 94);
            this.panel1.TabIndex = 39;
            // 
            // lblHistoryTotalBudget
            // 
            this.lblHistoryTotalBudget.BackColor = System.Drawing.Color.Transparent;
            this.lblHistoryTotalBudget.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHistoryTotalBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHistoryTotalBudget.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryTotalBudget.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHistoryTotalBudget.Location = new System.Drawing.Point(37, 38);
            this.lblHistoryTotalBudget.Name = "lblHistoryTotalBudget";
            this.lblHistoryTotalBudget.Size = new System.Drawing.Size(90, 29);
            this.lblHistoryTotalBudget.TabIndex = 32;
            this.lblHistoryTotalBudget.Text = "₱0.00";
            this.lblHistoryTotalBudget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalBudget1
            // 
            this.lblTotalBudget1.AutoSize = true;
            this.lblTotalBudget1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalBudget1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBudget1.Font = new System.Drawing.Font("Poppins Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBudget1.Location = new System.Drawing.Point(36, 20);
            this.lblTotalBudget1.Name = "lblTotalBudget1";
            this.lblTotalBudget1.Size = new System.Drawing.Size(91, 17);
            this.lblTotalBudget1.TabIndex = 59;
            this.lblTotalBudget1.Text = "Total Balance";
            // 
            // lblEndDateDisplay
            // 
            this.lblEndDateDisplay.AutoSize = true;
            this.lblEndDateDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndDateDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndDateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDateDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEndDateDisplay.Location = new System.Drawing.Point(166, 60);
            this.lblEndDateDisplay.Name = "lblEndDateDisplay";
            this.lblEndDateDisplay.Size = new System.Drawing.Size(81, 16);
            this.lblEndDateDisplay.TabIndex = 62;
            this.lblEndDateDisplay.Text = "2024-07-14";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEndDate.Location = new System.Drawing.Point(166, 44);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 16);
            this.lblEndDate.TabIndex = 61;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDateDisplay
            // 
            this.lblStartDateDisplay.AutoSize = true;
            this.lblStartDateDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartDateDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartDateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDateDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStartDateDisplay.Location = new System.Drawing.Point(166, 23);
            this.lblStartDateDisplay.Name = "lblStartDateDisplay";
            this.lblStartDateDisplay.Size = new System.Drawing.Size(81, 16);
            this.lblStartDateDisplay.TabIndex = 60;
            this.lblStartDateDisplay.Text = "2024-06-14";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStartDate.Location = new System.Drawing.Point(166, 7);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 16);
            this.lblStartDate.TabIndex = 59;
            this.lblStartDate.Text = "Start Date";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblPesoSign);
            this.Controls.Add(this.lblTotalBalanceText);
            this.Controls.Add(this.imgTotalBalanceTitle);
            this.Controls.Add(this.txtTransactionTitle);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnBudgetWizard2);
            this.Controls.Add(this.pnlBalanceAmount);
            this.Controls.Add(this.pnlExpenseBreakdowns);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgNotificationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBalanceTitle)).EndInit();
            this.pnlBalanceAmount.ResumeLayout(false);
            this.pnlExpenseBreakdowns.ResumeLayout(false);
            this.pnlExpenseBreakdowns.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_lblBudgetWizard;
        private System.Windows.Forms.PictureBox imgNotificationIcon;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlBalanceAmount;
        private System.Windows.Forms.Panel pnlExpenseBreakdowns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalBudget1;
        private System.Windows.Forms.Label lblHistoryTotalBudget;
        private System.Windows.Forms.Label lblEndDateDisplay;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDateDisplay;
        private System.Windows.Forms.Label lblStartDate;
    }
}