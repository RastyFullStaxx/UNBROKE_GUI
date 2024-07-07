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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblTotalBalanceText = new System.Windows.Forms.Label();
            this.lblTotalBalanceAmount = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.imgTotalBalanceTitle = new System.Windows.Forms.PictureBox();
            this.txtTransactionTitle = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBudgetWizard2 = new System.Windows.Forms.Button();
            this.pnlBalanceAmount = new System.Windows.Forms.Panel();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.priorityPanel = new System.Windows.Forms.Panel();
            this.lblEndDateDisplay = new System.Windows.Forms.Label();
            this.lblTotalBudget1 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblHistoryTotalBudget = new System.Windows.Forms.Label();
            this.lblStartDateDisplay = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnBudgetWizard1 = new System.Windows.Forms.Button();
            this.imgNotificationIcon = new System.Windows.Forms.PictureBox();
            this.youdonthaveLabel = new System.Windows.Forms.Label();
            this.link_lblBudgetWizard = new System.Windows.Forms.LinkLabel();
            this.panel3Transition = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel4Transition = new System.Windows.Forms.Timer(this.components);
            this.panel5Transition = new System.Windows.Forms.Timer(this.components);
            this.panel6Transition = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBalanceTitle)).BeginInit();
            this.pnlBalanceAmount.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.priorityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotificationIcon)).BeginInit();
            this.panel6.SuspendLayout();
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
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBudget.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(24, 221);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(129, 26);
            this.lblBudget.TabIndex = 33;
            this.lblBudget.Text = "Budget Activity";
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
            // imgTotalBalanceTitle
            // 
            this.imgTotalBalanceTitle.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.imgTotalBalanceTitle.Image = ((System.Drawing.Image)(resources.GetObject("imgTotalBalanceTitle.Image")));
            this.imgTotalBalanceTitle.Location = new System.Drawing.Point(24, 14);
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
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.Location = new System.Drawing.Point(283, 754);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(43, 44);
            this.btnProfile.TabIndex = 12;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(42, 750);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(79, 48);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnBudgetWizard2
            // 
            this.btnBudgetWizard2.BackColor = System.Drawing.Color.Transparent;
            this.btnBudgetWizard2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBudgetWizard2.FlatAppearance.BorderSize = 0;
            this.btnBudgetWizard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgetWizard2.Image = ((System.Drawing.Image)(resources.GetObject("btnBudgetWizard2.Image")));
            this.btnBudgetWizard2.Location = new System.Drawing.Point(158, 714);
            this.btnBudgetWizard2.Name = "btnBudgetWizard2";
            this.btnBudgetWizard2.Size = new System.Drawing.Size(61, 65);
            this.btnBudgetWizard2.TabIndex = 10;
            this.btnBudgetWizard2.UseVisualStyleBackColor = false;
            this.btnBudgetWizard2.Click += new System.EventHandler(this.btnBudgetWizard2_Click);
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
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.panel6);
            this.mainPanel.Controls.Add(this.panel5);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Location = new System.Drawing.Point(29, 390);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(342, 306);
            this.mainPanel.TabIndex = 58;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(1, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 94);
            this.panel5.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(166, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "2024-07-14";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Total Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(166, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(37, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "₱0.00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(166, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "2024-06-14";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(166, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Start Date";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 94);
            this.panel3.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(166, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "2024-07-14";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Total Balance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(166, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "End Date";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(37, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 29);
            this.label10.TabIndex = 32;
            this.label10.Text = "₱0.00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(166, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 60;
            this.label11.Text = "2024-06-14";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(166, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Start Date";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(1, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 94);
            this.panel4.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(166, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 62;
            this.label13.Text = "2024-07-14";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Poppins Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Total Balance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(166, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 61;
            this.label15.Text = "End Date";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(37, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 29);
            this.label16.TabIndex = 32;
            this.label16.Text = "₱0.00";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(166, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 16);
            this.label17.TabIndex = 60;
            this.label17.Text = "2024-06-14";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(166, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 59;
            this.label18.Text = "Start Date";
            // 
            // priorityPanel
            // 
            this.priorityPanel.BackColor = System.Drawing.Color.Maroon;
            this.priorityPanel.Controls.Add(this.lblEndDateDisplay);
            this.priorityPanel.Controls.Add(this.lblTotalBudget1);
            this.priorityPanel.Controls.Add(this.lblEndDate);
            this.priorityPanel.Controls.Add(this.lblHistoryTotalBudget);
            this.priorityPanel.Controls.Add(this.lblStartDateDisplay);
            this.priorityPanel.Controls.Add(this.lblStartDate);
            this.priorityPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priorityPanel.Location = new System.Drawing.Point(29, 268);
            this.priorityPanel.Name = "priorityPanel";
            this.priorityPanel.Size = new System.Drawing.Size(324, 94);
            this.priorityPanel.TabIndex = 68;
            // 
            // lblEndDateDisplay
            // 
            this.lblEndDateDisplay.AutoSize = true;
            this.lblEndDateDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEndDateDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndDateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDateDisplay.ForeColor = System.Drawing.Color.Silver;
            this.lblEndDateDisplay.Location = new System.Drawing.Point(166, 65);
            this.lblEndDateDisplay.Name = "lblEndDateDisplay";
            this.lblEndDateDisplay.Size = new System.Drawing.Size(81, 16);
            this.lblEndDateDisplay.TabIndex = 62;
            this.lblEndDateDisplay.Text = "2024-07-14";
            // 
            // lblTotalBudget1
            // 
            this.lblTotalBudget1.AutoSize = true;
            this.lblTotalBudget1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotalBudget1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBudget1.Font = new System.Drawing.Font("Poppins Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBudget1.ForeColor = System.Drawing.Color.White;
            this.lblTotalBudget1.Location = new System.Drawing.Point(38, 25);
            this.lblTotalBudget1.Name = "lblTotalBudget1";
            this.lblTotalBudget1.Size = new System.Drawing.Size(91, 17);
            this.lblTotalBudget1.TabIndex = 59;
            this.lblTotalBudget1.Text = "Total Balance";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(166, 49);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 16);
            this.lblEndDate.TabIndex = 61;
            this.lblEndDate.Text = "End Date";
            // 
            // lblHistoryTotalBudget
            // 
            this.lblHistoryTotalBudget.BackColor = System.Drawing.Color.Transparent;
            this.lblHistoryTotalBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHistoryTotalBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHistoryTotalBudget.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryTotalBudget.ForeColor = System.Drawing.Color.Silver;
            this.lblHistoryTotalBudget.Location = new System.Drawing.Point(13, 43);
            this.lblHistoryTotalBudget.Name = "lblHistoryTotalBudget";
            this.lblHistoryTotalBudget.Size = new System.Drawing.Size(134, 29);
            this.lblHistoryTotalBudget.TabIndex = 32;
            this.lblHistoryTotalBudget.Text = "₱0.00";
            this.lblHistoryTotalBudget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartDateDisplay
            // 
            this.lblStartDateDisplay.AutoSize = true;
            this.lblStartDateDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStartDateDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartDateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDateDisplay.ForeColor = System.Drawing.Color.Silver;
            this.lblStartDateDisplay.Location = new System.Drawing.Point(166, 28);
            this.lblStartDateDisplay.Name = "lblStartDateDisplay";
            this.lblStartDateDisplay.Size = new System.Drawing.Size(81, 16);
            this.lblStartDateDisplay.TabIndex = 60;
            this.lblStartDateDisplay.Text = "2024-06-14";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(166, 12);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 16);
            this.lblStartDate.TabIndex = 59;
            this.lblStartDate.Text = "Start Date";
            // 
            // btnBudgetWizard1
            // 
            this.btnBudgetWizard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBudgetWizard1.FlatAppearance.BorderSize = 0;
            this.btnBudgetWizard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgetWizard1.Image = ((System.Drawing.Image)(resources.GetObject("btnBudgetWizard1.Image")));
            this.btnBudgetWizard1.Location = new System.Drawing.Point(139, 250);
            this.btnBudgetWizard1.Name = "btnBudgetWizard1";
            this.btnBudgetWizard1.Size = new System.Drawing.Size(83, 82);
            this.btnBudgetWizard1.TabIndex = 64;
            this.btnBudgetWizard1.UseVisualStyleBackColor = true;
            // 
            // imgNotificationIcon
            // 
            this.imgNotificationIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgNotificationIcon.BackgroundImage")));
            this.imgNotificationIcon.Location = new System.Drawing.Point(82, 368);
            this.imgNotificationIcon.Name = "imgNotificationIcon";
            this.imgNotificationIcon.Size = new System.Drawing.Size(16, 16);
            this.imgNotificationIcon.TabIndex = 67;
            this.imgNotificationIcon.TabStop = false;
            // 
            // youdonthaveLabel
            // 
            this.youdonthaveLabel.AutoSize = true;
            this.youdonthaveLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.youdonthaveLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.youdonthaveLabel.Font = new System.Drawing.Font("Poppins ExtraBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youdonthaveLabel.Location = new System.Drawing.Point(61, 335);
            this.youdonthaveLabel.Name = "youdonthaveLabel";
            this.youdonthaveLabel.Size = new System.Drawing.Size(255, 19);
            this.youdonthaveLabel.TabIndex = 65;
            this.youdonthaveLabel.Text = "You don’t have any budget at the moment.";
            // 
            // link_lblBudgetWizard
            // 
            this.link_lblBudgetWizard.ActiveLinkColor = System.Drawing.Color.Red;
            this.link_lblBudgetWizard.AutoSize = true;
            this.link_lblBudgetWizard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_lblBudgetWizard.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lblBudgetWizard.ForeColor = System.Drawing.Color.DarkRed;
            this.link_lblBudgetWizard.LinkColor = System.Drawing.Color.DarkRed;
            this.link_lblBudgetWizard.Location = new System.Drawing.Point(104, 365);
            this.link_lblBudgetWizard.Name = "link_lblBudgetWizard";
            this.link_lblBudgetWizard.Size = new System.Drawing.Size(176, 19);
            this.link_lblBudgetWizard.TabIndex = 66;
            this.link_lblBudgetWizard.TabStop = true;
            this.link_lblBudgetWizard.Text = "Click here to create a new one.";
            this.link_lblBudgetWizard.Click += new System.EventHandler(this.link_lblBudgetWizard_LinkClicked);
            // 
            // panel3Transition
            // 
            this.panel3Transition.Tick += new System.EventHandler(this.panel1Transition_Tick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Location = new System.Drawing.Point(1, 295);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(333, 94);
            this.panel6.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(166, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 16);
            this.label19.TabIndex = 62;
            this.label19.Text = "2024-07-14";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Poppins Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(38, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 17);
            this.label20.TabIndex = 59;
            this.label20.Text = "Total Balance";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(166, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 16);
            this.label21.TabIndex = 61;
            this.label21.Text = "End Date";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkRed;
            this.label22.Location = new System.Drawing.Point(37, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 29);
            this.label22.TabIndex = 32;
            this.label22.Text = "₱0.00";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Cursor = System.Windows.Forms.Cursors.Default;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkRed;
            this.label23.Location = new System.Drawing.Point(166, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 16);
            this.label23.TabIndex = 60;
            this.label23.Text = "2024-06-14";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(166, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 16);
            this.label24.TabIndex = 59;
            this.label24.Text = "Start Date";
            // 
            // panel4Transition
            // 
            this.panel4Transition.Tick += new System.EventHandler(this.panel4TransitionClick_Tick);
            // 
            // panel5Transition
            // 
            this.panel5Transition.Tick += new System.EventHandler(this.panel5Transition_Tick);
            // 
            // panel6Transition
            // 
            this.panel6Transition.Tick += new System.EventHandler(this.panel6Transition_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.btnBudgetWizard2);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.priorityPanel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.imgNotificationIcon);
            this.Controls.Add(this.btnBudgetWizard1);
            this.Controls.Add(this.link_lblBudgetWizard);
            this.Controls.Add(this.youdonthaveLabel);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblTotalBalanceText);
            this.Controls.Add(this.imgTotalBalanceTitle);
            this.Controls.Add(this.txtTransactionTitle);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.pnlBalanceAmount);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBalanceTitle)).EndInit();
            this.pnlBalanceAmount.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.priorityPanel.ResumeLayout(false);
            this.priorityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotificationIcon)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBudgetWizard2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button txtTransactionTitle;
        private System.Windows.Forms.PictureBox imgTotalBalanceTitle;
        private System.Windows.Forms.Label lblTotalBalanceText;
        private System.Windows.Forms.Label lblTotalBalanceAmount;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlBalanceAmount;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel priorityPanel;
        private System.Windows.Forms.Label lblEndDateDisplay;
        private System.Windows.Forms.Label lblTotalBudget1;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblHistoryTotalBudget;
        private System.Windows.Forms.Label lblStartDateDisplay;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnBudgetWizard1;
        private System.Windows.Forms.PictureBox imgNotificationIcon;
        private System.Windows.Forms.Label youdonthaveLabel;
        private System.Windows.Forms.LinkLabel link_lblBudgetWizard;
        private System.Windows.Forms.Timer panel3Transition;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Timer panel4Transition;
        private System.Windows.Forms.Timer panel5Transition;
        private System.Windows.Forms.Timer panel6Transition;
    }
}