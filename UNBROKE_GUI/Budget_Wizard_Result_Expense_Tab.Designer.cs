﻿namespace UNBROKE_GUI
{
    partial class Budget_Wizard_Result_Expense_Tab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget_Wizard_Result_Expense_Tab));
            this.lblNeeds = new System.Windows.Forms.Label();
            this.lblWants = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.pnlExpenses = new System.Windows.Forms.Panel();
            this.lblClothingAmountDisplay = new System.Windows.Forms.Label();
            this.lblEntertainmentAmountDisplay = new System.Windows.Forms.Label();
            this.btnEditWantsExpense = new System.Windows.Forms.Button();
            this.lblTotalWantsAmountDisplay = new System.Windows.Forms.Label();
            this.LblWant = new System.Windows.Forms.Label();
            this.imgWantsIcon = new System.Windows.Forms.PictureBox();
            this.lblEntertainment = new System.Windows.Forms.Label();
            this.lblClothing = new System.Windows.Forms.Label();
            this.lblOthersAmountDisplay = new System.Windows.Forms.Label();
            this.lblSuppliesAmountDisplay = new System.Windows.Forms.Label();
            this.lblSupplies = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.lblTransportationAmountDisplay = new System.Windows.Forms.Label();
            this.lblBillsAmountDisplay = new System.Windows.Forms.Label();
            this.btnEditNeedsExpense = new System.Windows.Forms.Button();
            this.lblDisplayTotalNeedsExpenseDisplay = new System.Windows.Forms.Label();
            this.lblNeed = new System.Windows.Forms.Label();
            this.imgNeedIcon = new System.Windows.Forms.PictureBox();
            this.lblBills = new System.Windows.Forms.Label();
            this.lblTransportation = new System.Windows.Forms.Label();
            this.lblRentAmountDisplay = new System.Windows.Forms.Label();
            this.lblFoodAmountDisplay = new System.Windows.Forms.Label();
            this.btnEditFixedExpense = new System.Windows.Forms.Button();
            this.lblDisplayTotalFixedExpenseAmountDisplay = new System.Windows.Forms.Label();
            this.lblFixedExpense = new System.Windows.Forms.Label();
            this.imgFixedIcon = new System.Windows.Forms.PictureBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblTotalBudget = new System.Windows.Forms.Label();
            this.lblTotalBudgetAmountDisplay = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStartDateDisplay = new System.Windows.Forms.Label();
            this.lblEndDateDisplay = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.pnlTotalBudgetAndDate = new System.Windows.Forms.Panel();
            this.btnSavingsTab = new System.Windows.Forms.Button();
            this.btnExpenseTab = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBudgetWizard2 = new System.Windows.Forms.Button();
            this.imgBudgetWizardTitle = new System.Windows.Forms.PictureBox();
            this.needsProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.needsLabel = new System.Windows.Forms.Label();
            this.wantsProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.wantsLabel = new System.Windows.Forms.Label();
            this.savingsProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWantsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNeedIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFixedIcon)).BeginInit();
            this.pnlTotalBudgetAndDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBudgetWizardTitle)).BeginInit();
            this.needsProgressBar.SuspendLayout();
            this.wantsProgressBar.SuspendLayout();
            this.savingsProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNeeds
            // 
            this.lblNeeds.AutoSize = true;
            this.lblNeeds.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNeeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNeeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeeds.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNeeds.Location = new System.Drawing.Point(36, 229);
            this.lblNeeds.Name = "lblNeeds";
            this.lblNeeds.Size = new System.Drawing.Size(59, 16);
            this.lblNeeds.TabIndex = 44;
            this.lblNeeds.Text = "NEEDS";
            // 
            // lblWants
            // 
            this.lblWants.AutoSize = true;
            this.lblWants.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWants.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWants.Location = new System.Drawing.Point(159, 229);
            this.lblWants.Name = "lblWants";
            this.lblWants.Size = new System.Drawing.Size(62, 16);
            this.lblWants.TabIndex = 45;
            this.lblWants.Text = "WANTS";
            this.lblWants.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavings.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSavings.Location = new System.Drawing.Point(277, 229);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(73, 16);
            this.lblSavings.TabIndex = 46;
            this.lblSavings.Text = "SAVINGS";
            // 
            // pnlExpenses
            // 
            this.pnlExpenses.AutoScroll = true;
            this.pnlExpenses.Controls.Add(this.lblClothingAmountDisplay);
            this.pnlExpenses.Controls.Add(this.lblEntertainmentAmountDisplay);
            this.pnlExpenses.Controls.Add(this.btnEditWantsExpense);
            this.pnlExpenses.Controls.Add(this.lblTotalWantsAmountDisplay);
            this.pnlExpenses.Controls.Add(this.LblWant);
            this.pnlExpenses.Controls.Add(this.imgWantsIcon);
            this.pnlExpenses.Controls.Add(this.lblEntertainment);
            this.pnlExpenses.Controls.Add(this.lblClothing);
            this.pnlExpenses.Controls.Add(this.lblOthersAmountDisplay);
            this.pnlExpenses.Controls.Add(this.lblSuppliesAmountDisplay);
            this.pnlExpenses.Controls.Add(this.lblSupplies);
            this.pnlExpenses.Controls.Add(this.lblOthers);
            this.pnlExpenses.Controls.Add(this.lblTransportationAmountDisplay);
            this.pnlExpenses.Controls.Add(this.lblBillsAmountDisplay);
            this.pnlExpenses.Controls.Add(this.btnEditNeedsExpense);
            this.pnlExpenses.Controls.Add(this.lblDisplayTotalNeedsExpenseDisplay);
            this.pnlExpenses.Controls.Add(this.lblNeed);
            this.pnlExpenses.Controls.Add(this.imgNeedIcon);
            this.pnlExpenses.Controls.Add(this.lblBills);
            this.pnlExpenses.Controls.Add(this.lblTransportation);
            this.pnlExpenses.Controls.Add(this.lblRentAmountDisplay);
            this.pnlExpenses.Controls.Add(this.lblFoodAmountDisplay);
            this.pnlExpenses.Controls.Add(this.btnEditFixedExpense);
            this.pnlExpenses.Controls.Add(this.lblDisplayTotalFixedExpenseAmountDisplay);
            this.pnlExpenses.Controls.Add(this.lblFixedExpense);
            this.pnlExpenses.Controls.Add(this.imgFixedIcon);
            this.pnlExpenses.Controls.Add(this.lblFood);
            this.pnlExpenses.Controls.Add(this.lblRent);
            this.pnlExpenses.Location = new System.Drawing.Point(26, 367);
            this.pnlExpenses.Name = "pnlExpenses";
            this.pnlExpenses.Size = new System.Drawing.Size(328, 347);
            this.pnlExpenses.TabIndex = 51;
            // 
            // lblClothingAmountDisplay
            // 
            this.lblClothingAmountDisplay.AutoSize = true;
            this.lblClothingAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblClothingAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClothingAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClothingAmountDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClothingAmountDisplay.Location = new System.Drawing.Point(231, 498);
            this.lblClothingAmountDisplay.Name = "lblClothingAmountDisplay";
            this.lblClothingAmountDisplay.Size = new System.Drawing.Size(61, 16);
            this.lblClothingAmountDisplay.TabIndex = 87;
            this.lblClothingAmountDisplay.Text = "₱500.00";
            this.lblClothingAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEntertainmentAmountDisplay
            // 
            this.lblEntertainmentAmountDisplay.AutoSize = true;
            this.lblEntertainmentAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEntertainmentAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEntertainmentAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntertainmentAmountDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEntertainmentAmountDisplay.Location = new System.Drawing.Point(226, 456);
            this.lblEntertainmentAmountDisplay.Name = "lblEntertainmentAmountDisplay";
            this.lblEntertainmentAmountDisplay.Size = new System.Drawing.Size(69, 16);
            this.lblEntertainmentAmountDisplay.TabIndex = 86;
            this.lblEntertainmentAmountDisplay.Text = "₱1500.00";
            this.lblEntertainmentAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditWantsExpense
            // 
            this.btnEditWantsExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditWantsExpense.FlatAppearance.BorderSize = 0;
            this.btnEditWantsExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditWantsExpense.Image = ((System.Drawing.Image)(resources.GetObject("btnEditWantsExpense.Image")));
            this.btnEditWantsExpense.Location = new System.Drawing.Point(284, 416);
            this.btnEditWantsExpense.Name = "btnEditWantsExpense";
            this.btnEditWantsExpense.Size = new System.Drawing.Size(16, 16);
            this.btnEditWantsExpense.TabIndex = 80;
            this.btnEditWantsExpense.UseVisualStyleBackColor = true;
            // 
            // lblTotalWantsAmountDisplay
            // 
            this.lblTotalWantsAmountDisplay.AutoSize = true;
            this.lblTotalWantsAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalWantsAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalWantsAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWantsAmountDisplay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTotalWantsAmountDisplay.Location = new System.Drawing.Point(193, 416);
            this.lblTotalWantsAmountDisplay.Name = "lblTotalWantsAmountDisplay";
            this.lblTotalWantsAmountDisplay.Size = new System.Drawing.Size(69, 16);
            this.lblTotalWantsAmountDisplay.TabIndex = 85;
            this.lblTotalWantsAmountDisplay.Text = "₱4000.00";
            this.lblTotalWantsAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblWant
            // 
            this.LblWant.AutoSize = true;
            this.LblWant.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblWant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWant.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LblWant.Location = new System.Drawing.Point(70, 416);
            this.LblWant.Name = "LblWant";
            this.LblWant.Size = new System.Drawing.Size(50, 16);
            this.LblWant.TabIndex = 81;
            this.LblWant.Text = "Wants";
            this.LblWant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgWantsIcon
            // 
            this.imgWantsIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgWantsIcon.Image")));
            this.imgWantsIcon.Location = new System.Drawing.Point(19, 404);
            this.imgWantsIcon.Name = "imgWantsIcon";
            this.imgWantsIcon.Size = new System.Drawing.Size(45, 45);
            this.imgWantsIcon.TabIndex = 84;
            this.imgWantsIcon.TabStop = false;
            // 
            // lblEntertainment
            // 
            this.lblEntertainment.AutoSize = true;
            this.lblEntertainment.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEntertainment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEntertainment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntertainment.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEntertainment.Location = new System.Drawing.Point(24, 456);
            this.lblEntertainment.Name = "lblEntertainment";
            this.lblEntertainment.Size = new System.Drawing.Size(101, 16);
            this.lblEntertainment.TabIndex = 82;
            this.lblEntertainment.Text = "Entertainment";
            // 
            // lblClothing
            // 
            this.lblClothing.AutoSize = true;
            this.lblClothing.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblClothing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClothing.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblClothing.Location = new System.Drawing.Point(24, 498);
            this.lblClothing.Name = "lblClothing";
            this.lblClothing.Size = new System.Drawing.Size(63, 16);
            this.lblClothing.TabIndex = 83;
            this.lblClothing.Text = "Clothing";
            // 
            // lblOthersAmountDisplay
            // 
            this.lblOthersAmountDisplay.AutoSize = true;
            this.lblOthersAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOthersAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOthersAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthersAmountDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOthersAmountDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOthersAmountDisplay.Location = new System.Drawing.Point(247, 342);
            this.lblOthersAmountDisplay.Name = "lblOthersAmountDisplay";
            this.lblOthersAmountDisplay.Size = new System.Drawing.Size(45, 16);
            this.lblOthersAmountDisplay.TabIndex = 79;
            this.lblOthersAmountDisplay.Text = "₱0.00";
            this.lblOthersAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuppliesAmountDisplay
            // 
            this.lblSuppliesAmountDisplay.AutoSize = true;
            this.lblSuppliesAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSuppliesAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSuppliesAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliesAmountDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSuppliesAmountDisplay.Location = new System.Drawing.Point(226, 302);
            this.lblSuppliesAmountDisplay.Name = "lblSuppliesAmountDisplay";
            this.lblSuppliesAmountDisplay.Size = new System.Drawing.Size(69, 16);
            this.lblSuppliesAmountDisplay.TabIndex = 78;
            this.lblSuppliesAmountDisplay.Text = "₱1500.00";
            this.lblSuppliesAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSupplies
            // 
            this.lblSupplies.AutoSize = true;
            this.lblSupplies.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSupplies.Location = new System.Drawing.Point(24, 302);
            this.lblSupplies.Name = "lblSupplies";
            this.lblSupplies.Size = new System.Drawing.Size(68, 16);
            this.lblSupplies.TabIndex = 76;
            this.lblSupplies.Text = "Supplies";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblOthers.Location = new System.Drawing.Point(24, 342);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(52, 16);
            this.lblOthers.TabIndex = 77;
            this.lblOthers.Text = "Others";
            // 
            // lblTransportationAmountDisplay
            // 
            this.lblTransportationAmountDisplay.AutoSize = true;
            this.lblTransportationAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTransportationAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTransportationAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportationAmountDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTransportationAmountDisplay.Location = new System.Drawing.Point(231, 260);
            this.lblTransportationAmountDisplay.Name = "lblTransportationAmountDisplay";
            this.lblTransportationAmountDisplay.Size = new System.Drawing.Size(61, 16);
            this.lblTransportationAmountDisplay.TabIndex = 75;
            this.lblTransportationAmountDisplay.Text = "₱600.00";
            this.lblTransportationAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBillsAmountDisplay
            // 
            this.lblBillsAmountDisplay.AutoSize = true;
            this.lblBillsAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBillsAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBillsAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillsAmountDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBillsAmountDisplay.Location = new System.Drawing.Point(231, 218);
            this.lblBillsAmountDisplay.Name = "lblBillsAmountDisplay";
            this.lblBillsAmountDisplay.Size = new System.Drawing.Size(61, 16);
            this.lblBillsAmountDisplay.TabIndex = 74;
            this.lblBillsAmountDisplay.Text = "₱900.00";
            this.lblBillsAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditNeedsExpense
            // 
            this.btnEditNeedsExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditNeedsExpense.FlatAppearance.BorderSize = 0;
            this.btnEditNeedsExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNeedsExpense.Image = ((System.Drawing.Image)(resources.GetObject("btnEditNeedsExpense.Image")));
            this.btnEditNeedsExpense.Location = new System.Drawing.Point(284, 178);
            this.btnEditNeedsExpense.Name = "btnEditNeedsExpense";
            this.btnEditNeedsExpense.Size = new System.Drawing.Size(16, 16);
            this.btnEditNeedsExpense.TabIndex = 68;
            this.btnEditNeedsExpense.UseVisualStyleBackColor = true;
            // 
            // lblDisplayTotalNeedsExpenseDisplay
            // 
            this.lblDisplayTotalNeedsExpenseDisplay.AutoSize = true;
            this.lblDisplayTotalNeedsExpenseDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDisplayTotalNeedsExpenseDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDisplayTotalNeedsExpenseDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotalNeedsExpenseDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDisplayTotalNeedsExpenseDisplay.Location = new System.Drawing.Point(193, 178);
            this.lblDisplayTotalNeedsExpenseDisplay.Name = "lblDisplayTotalNeedsExpenseDisplay";
            this.lblDisplayTotalNeedsExpenseDisplay.Size = new System.Drawing.Size(69, 16);
            this.lblDisplayTotalNeedsExpenseDisplay.TabIndex = 73;
            this.lblDisplayTotalNeedsExpenseDisplay.Text = "₱3000.00";
            this.lblDisplayTotalNeedsExpenseDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNeed
            // 
            this.lblNeed.AutoSize = true;
            this.lblNeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNeed.Location = new System.Drawing.Point(70, 178);
            this.lblNeed.Name = "lblNeed";
            this.lblNeed.Size = new System.Drawing.Size(53, 16);
            this.lblNeed.TabIndex = 69;
            this.lblNeed.Text = "Needs";
            this.lblNeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgNeedIcon
            // 
            this.imgNeedIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgNeedIcon.Image")));
            this.imgNeedIcon.Location = new System.Drawing.Point(19, 166);
            this.imgNeedIcon.Name = "imgNeedIcon";
            this.imgNeedIcon.Size = new System.Drawing.Size(45, 45);
            this.imgNeedIcon.TabIndex = 72;
            this.imgNeedIcon.TabStop = false;
            // 
            // lblBills
            // 
            this.lblBills.AutoSize = true;
            this.lblBills.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBills.Location = new System.Drawing.Point(24, 218);
            this.lblBills.Name = "lblBills";
            this.lblBills.Size = new System.Drawing.Size(37, 16);
            this.lblBills.TabIndex = 70;
            this.lblBills.Text = "Bills";
            // 
            // lblTransportation
            // 
            this.lblTransportation.AutoSize = true;
            this.lblTransportation.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTransportation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTransportation.Location = new System.Drawing.Point(24, 260);
            this.lblTransportation.Name = "lblTransportation";
            this.lblTransportation.Size = new System.Drawing.Size(108, 16);
            this.lblTransportation.TabIndex = 71;
            this.lblTransportation.Text = "Transportation";
            // 
            // lblRentAmountDisplay
            // 
            this.lblRentAmountDisplay.AutoSize = true;
            this.lblRentAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRentAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRentAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentAmountDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRentAmountDisplay.Location = new System.Drawing.Point(224, 101);
            this.lblRentAmountDisplay.Name = "lblRentAmountDisplay";
            this.lblRentAmountDisplay.Size = new System.Drawing.Size(69, 16);
            this.lblRentAmountDisplay.TabIndex = 67;
            this.lblRentAmountDisplay.Text = "₱2500.00";
            this.lblRentAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFoodAmountDisplay
            // 
            this.lblFoodAmountDisplay.AutoSize = true;
            this.lblFoodAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFoodAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFoodAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodAmountDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFoodAmountDisplay.Location = new System.Drawing.Point(226, 59);
            this.lblFoodAmountDisplay.Name = "lblFoodAmountDisplay";
            this.lblFoodAmountDisplay.Size = new System.Drawing.Size(69, 16);
            this.lblFoodAmountDisplay.TabIndex = 66;
            this.lblFoodAmountDisplay.Text = "₱1500.00";
            this.lblFoodAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditFixedExpense
            // 
            this.btnEditFixedExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditFixedExpense.FlatAppearance.BorderSize = 0;
            this.btnEditFixedExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFixedExpense.Image = ((System.Drawing.Image)(resources.GetObject("btnEditFixedExpense.Image")));
            this.btnEditFixedExpense.Location = new System.Drawing.Point(284, 19);
            this.btnEditFixedExpense.Name = "btnEditFixedExpense";
            this.btnEditFixedExpense.Size = new System.Drawing.Size(16, 16);
            this.btnEditFixedExpense.TabIndex = 54;
            this.btnEditFixedExpense.UseVisualStyleBackColor = true;
            // 
            // lblDisplayTotalFixedExpenseAmountDisplay
            // 
            this.lblDisplayTotalFixedExpenseAmountDisplay.AutoSize = true;
            this.lblDisplayTotalFixedExpenseAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDisplayTotalFixedExpenseAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDisplayTotalFixedExpenseAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotalFixedExpenseAmountDisplay.ForeColor = System.Drawing.Color.Indigo;
            this.lblDisplayTotalFixedExpenseAmountDisplay.Location = new System.Drawing.Point(192, 19);
            this.lblDisplayTotalFixedExpenseAmountDisplay.Name = "lblDisplayTotalFixedExpenseAmountDisplay";
            this.lblDisplayTotalFixedExpenseAmountDisplay.Size = new System.Drawing.Size(69, 16);
            this.lblDisplayTotalFixedExpenseAmountDisplay.TabIndex = 65;
            this.lblDisplayTotalFixedExpenseAmountDisplay.Text = "₱4000.00";
            this.lblDisplayTotalFixedExpenseAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFixedExpense
            // 
            this.lblFixedExpense.AutoSize = true;
            this.lblFixedExpense.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFixedExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFixedExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixedExpense.ForeColor = System.Drawing.Color.Indigo;
            this.lblFixedExpense.Location = new System.Drawing.Point(70, 19);
            this.lblFixedExpense.Name = "lblFixedExpense";
            this.lblFixedExpense.Size = new System.Drawing.Size(117, 16);
            this.lblFixedExpense.TabIndex = 61;
            this.lblFixedExpense.Text = "Fixed Expenses";
            this.lblFixedExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgFixedIcon
            // 
            this.imgFixedIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgFixedIcon.Image")));
            this.imgFixedIcon.Location = new System.Drawing.Point(19, 7);
            this.imgFixedIcon.Name = "imgFixedIcon";
            this.imgFixedIcon.Size = new System.Drawing.Size(45, 45);
            this.imgFixedIcon.TabIndex = 64;
            this.imgFixedIcon.TabStop = false;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.Indigo;
            this.lblFood.Location = new System.Drawing.Point(24, 59);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(43, 16);
            this.lblFood.TabIndex = 62;
            this.lblFood.Text = "Food";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.ForeColor = System.Drawing.Color.Indigo;
            this.lblRent.Location = new System.Drawing.Point(24, 101);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(39, 16);
            this.lblRent.TabIndex = 63;
            this.lblRent.Text = "Rent";
            // 
            // lblTotalBudget
            // 
            this.lblTotalBudget.AutoSize = true;
            this.lblTotalBudget.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBudget.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalBudget.Location = new System.Drawing.Point(46, 23);
            this.lblTotalBudget.Name = "lblTotalBudget";
            this.lblTotalBudget.Size = new System.Drawing.Size(96, 16);
            this.lblTotalBudget.TabIndex = 52;
            this.lblTotalBudget.Text = "Total Budget";
            // 
            // lblTotalBudgetAmountDisplay
            // 
            this.lblTotalBudgetAmountDisplay.AutoSize = true;
            this.lblTotalBudgetAmountDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalBudgetAmountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBudgetAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBudgetAmountDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalBudgetAmountDisplay.Location = new System.Drawing.Point(36, 38);
            this.lblTotalBudgetAmountDisplay.Name = "lblTotalBudgetAmountDisplay";
            this.lblTotalBudgetAmountDisplay.Size = new System.Drawing.Size(102, 24);
            this.lblTotalBudgetAmountDisplay.TabIndex = 54;
            this.lblTotalBudgetAmountDisplay.Text = "₱5,700.00";
            this.lblTotalBudgetAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStartDate.Location = new System.Drawing.Point(193, 10);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 16);
            this.lblStartDate.TabIndex = 55;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblStartDateDisplay
            // 
            this.lblStartDateDisplay.AutoSize = true;
            this.lblStartDateDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartDateDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartDateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDateDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStartDateDisplay.Location = new System.Drawing.Point(193, 26);
            this.lblStartDateDisplay.Name = "lblStartDateDisplay";
            this.lblStartDateDisplay.Size = new System.Drawing.Size(81, 16);
            this.lblStartDateDisplay.TabIndex = 56;
            this.lblStartDateDisplay.Text = "2024-06-14";
            // 
            // lblEndDateDisplay
            // 
            this.lblEndDateDisplay.AutoSize = true;
            this.lblEndDateDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndDateDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndDateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDateDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEndDateDisplay.Location = new System.Drawing.Point(193, 63);
            this.lblEndDateDisplay.Name = "lblEndDateDisplay";
            this.lblEndDateDisplay.Size = new System.Drawing.Size(81, 16);
            this.lblEndDateDisplay.TabIndex = 58;
            this.lblEndDateDisplay.Text = "2024-07-14";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEndDate.Location = new System.Drawing.Point(193, 47);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 16);
            this.lblEndDate.TabIndex = 57;
            this.lblEndDate.Text = "End Date";
            // 
            // pnlTotalBudgetAndDate
            // 
            this.pnlTotalBudgetAndDate.Controls.Add(this.lblEndDateDisplay);
            this.pnlTotalBudgetAndDate.Controls.Add(this.lblTotalBudgetAmountDisplay);
            this.pnlTotalBudgetAndDate.Controls.Add(this.lblEndDate);
            this.pnlTotalBudgetAndDate.Controls.Add(this.lblTotalBudget);
            this.pnlTotalBudgetAndDate.Controls.Add(this.lblStartDateDisplay);
            this.pnlTotalBudgetAndDate.Controls.Add(this.lblStartDate);
            this.pnlTotalBudgetAndDate.Location = new System.Drawing.Point(26, 263);
            this.pnlTotalBudgetAndDate.Name = "pnlTotalBudgetAndDate";
            this.pnlTotalBudgetAndDate.Size = new System.Drawing.Size(328, 95);
            this.pnlTotalBudgetAndDate.TabIndex = 52;
            // 
            // btnSavingsTab
            // 
            this.btnSavingsTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavingsTab.FlatAppearance.BorderSize = 0;
            this.btnSavingsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavingsTab.Image = ((System.Drawing.Image)(resources.GetObject("btnSavingsTab.Image")));
            this.btnSavingsTab.Location = new System.Drawing.Point(236, 80);
            this.btnSavingsTab.Name = "btnSavingsTab";
            this.btnSavingsTab.Size = new System.Drawing.Size(101, 42);
            this.btnSavingsTab.TabIndex = 53;
            this.btnSavingsTab.UseVisualStyleBackColor = true;
            this.btnSavingsTab.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExpenseTab
            // 
            this.btnExpenseTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenseTab.FlatAppearance.BorderSize = 0;
            this.btnExpenseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseTab.Image = ((System.Drawing.Image)(resources.GetObject("btnExpenseTab.Image")));
            this.btnExpenseTab.Location = new System.Drawing.Point(37, 80);
            this.btnExpenseTab.Name = "btnExpenseTab";
            this.btnExpenseTab.Size = new System.Drawing.Size(101, 42);
            this.btnExpenseTab.TabIndex = 52;
            this.btnExpenseTab.UseVisualStyleBackColor = true;
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
            this.btnProfile.TabIndex = 50;
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
            this.btnDashboard.TabIndex = 49;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
            this.btnBudgetWizard2.TabIndex = 48;
            this.btnBudgetWizard2.UseVisualStyleBackColor = true;
            // 
            // imgBudgetWizardTitle
            // 
            this.imgBudgetWizardTitle.Image = ((System.Drawing.Image)(resources.GetObject("imgBudgetWizardTitle.Image")));
            this.imgBudgetWizardTitle.Location = new System.Drawing.Point(98, 41);
            this.imgBudgetWizardTitle.Name = "imgBudgetWizardTitle";
            this.imgBudgetWizardTitle.Size = new System.Drawing.Size(179, 28);
            this.imgBudgetWizardTitle.TabIndex = 74;
            this.imgBudgetWizardTitle.TabStop = false;
            // 
            // needsProgressBar
            // 
            this.needsProgressBar.Controls.Add(this.needsLabel);
            this.needsProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.needsProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.needsProgressBar.ForeColor = System.Drawing.Color.White;
            this.needsProgressBar.Location = new System.Drawing.Point(19, 124);
            this.needsProgressBar.Maximum = 50;
            this.needsProgressBar.Minimum = 0;
            this.needsProgressBar.Name = "needsProgressBar";
            this.needsProgressBar.ProgressColor = System.Drawing.Color.DarkSlateBlue;
            this.needsProgressBar.ProgressColor2 = System.Drawing.Color.DarkSlateBlue;
            this.needsProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.needsProgressBar.Size = new System.Drawing.Size(102, 102);
            this.needsProgressBar.TabIndex = 75;
            this.needsProgressBar.Text = "guna2CircleProgressBar1";
            // 
            // needsLabel
            // 
            this.needsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.needsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.needsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.needsLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.needsLabel.Location = new System.Drawing.Point(28, 40);
            this.needsLabel.Name = "needsLabel";
            this.needsLabel.Size = new System.Drawing.Size(46, 24);
            this.needsLabel.TabIndex = 59;
            this.needsLabel.Text = "50%";
            this.needsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wantsProgressBar
            // 
            this.wantsProgressBar.Controls.Add(this.wantsLabel);
            this.wantsProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.wantsProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.wantsProgressBar.ForeColor = System.Drawing.Color.White;
            this.wantsProgressBar.Location = new System.Drawing.Point(141, 124);
            this.wantsProgressBar.Maximum = 30;
            this.wantsProgressBar.Minimum = 0;
            this.wantsProgressBar.Name = "wantsProgressBar";
            this.wantsProgressBar.ProgressColor = System.Drawing.Color.OrangeRed;
            this.wantsProgressBar.ProgressColor2 = System.Drawing.Color.OrangeRed;
            this.wantsProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.wantsProgressBar.Size = new System.Drawing.Size(102, 102);
            this.wantsProgressBar.TabIndex = 76;
            this.wantsProgressBar.Text = "guna2CircleProgressBar1";
            // 
            // wantsLabel
            // 
            this.wantsLabel.AutoSize = true;
            this.wantsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.wantsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wantsLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.wantsLabel.Location = new System.Drawing.Point(28, 40);
            this.wantsLabel.Name = "wantsLabel";
            this.wantsLabel.Size = new System.Drawing.Size(45, 20);
            this.wantsLabel.TabIndex = 60;
            this.wantsLabel.Text = "30%";
            this.wantsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // savingsProgressBar
            // 
            this.savingsProgressBar.Controls.Add(this.savingsLabel);
            this.savingsProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.savingsProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.savingsProgressBar.ForeColor = System.Drawing.Color.White;
            this.savingsProgressBar.Location = new System.Drawing.Point(260, 124);
            this.savingsProgressBar.Maximum = 20;
            this.savingsProgressBar.Minimum = 0;
            this.savingsProgressBar.Name = "savingsProgressBar";
            this.savingsProgressBar.ProgressColor = System.Drawing.Color.Aqua;
            this.savingsProgressBar.ProgressColor2 = System.Drawing.Color.Aqua;
            this.savingsProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.savingsProgressBar.Size = new System.Drawing.Size(102, 102);
            this.savingsProgressBar.TabIndex = 77;
            this.savingsProgressBar.Text = "guna2CircleProgressBar1";
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.savingsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsLabel.ForeColor = System.Drawing.Color.Aqua;
            this.savingsLabel.Location = new System.Drawing.Point(29, 40);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(45, 20);
            this.savingsLabel.TabIndex = 61;
            this.savingsLabel.Text = "20%";
            this.savingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Budget_Wizard_Result_Expense_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 812);
            this.Controls.Add(this.savingsProgressBar);
            this.Controls.Add(this.wantsProgressBar);
            this.Controls.Add(this.needsProgressBar);
            this.Controls.Add(this.imgBudgetWizardTitle);
            this.Controls.Add(this.btnSavingsTab);
            this.Controls.Add(this.btnExpenseTab);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnBudgetWizard2);
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.lblWants);
            this.Controls.Add(this.lblNeeds);
            this.Controls.Add(this.pnlExpenses);
            this.Controls.Add(this.pnlTotalBudgetAndDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Budget_Wizard_Result_Expense_Tab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget_Wizard_Result";
            this.Load += new System.EventHandler(this.Budget_Wizard_Result_Load);
            this.pnlExpenses.ResumeLayout(false);
            this.pnlExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWantsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNeedIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFixedIcon)).EndInit();
            this.pnlTotalBudgetAndDate.ResumeLayout(false);
            this.pnlTotalBudgetAndDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBudgetWizardTitle)).EndInit();
            this.needsProgressBar.ResumeLayout(false);
            this.wantsProgressBar.ResumeLayout(false);
            this.wantsProgressBar.PerformLayout();
            this.savingsProgressBar.ResumeLayout(false);
            this.savingsProgressBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNeeds;
        private System.Windows.Forms.Label lblWants;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBudgetWizard2;
        private System.Windows.Forms.Panel pnlExpenses;
        private System.Windows.Forms.Label lblTotalBudget;
        private System.Windows.Forms.Button btnExpenseTab;
        private System.Windows.Forms.Button btnSavingsTab;
        private System.Windows.Forms.Label lblTotalBudgetAmountDisplay;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblStartDateDisplay;
        private System.Windows.Forms.Label lblEndDateDisplay;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Panel pnlTotalBudgetAndDate;
        private System.Windows.Forms.Button btnEditFixedExpense;
        private System.Windows.Forms.Label lblDisplayTotalFixedExpenseAmountDisplay;
        private System.Windows.Forms.Label lblFixedExpense;
        private System.Windows.Forms.PictureBox imgFixedIcon;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblTransportationAmountDisplay;
        private System.Windows.Forms.Label lblBillsAmountDisplay;
        private System.Windows.Forms.Button btnEditNeedsExpense;
        private System.Windows.Forms.Label lblDisplayTotalNeedsExpenseDisplay;
        private System.Windows.Forms.Label lblNeed;
        private System.Windows.Forms.PictureBox imgNeedIcon;
        private System.Windows.Forms.Label lblBills;
        private System.Windows.Forms.Label lblTransportation;
        private System.Windows.Forms.Label lblRentAmountDisplay;
        private System.Windows.Forms.Label lblFoodAmountDisplay;
        private System.Windows.Forms.Label lblClothingAmountDisplay;
        private System.Windows.Forms.Label lblEntertainmentAmountDisplay;
        private System.Windows.Forms.Button btnEditWantsExpense;
        private System.Windows.Forms.Label lblTotalWantsAmountDisplay;
        private System.Windows.Forms.Label LblWant;
        private System.Windows.Forms.PictureBox imgWantsIcon;
        private System.Windows.Forms.Label lblEntertainment;
        private System.Windows.Forms.Label lblClothing;
        private System.Windows.Forms.Label lblOthersAmountDisplay;
        private System.Windows.Forms.Label lblSuppliesAmountDisplay;
        private System.Windows.Forms.Label lblSupplies;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.PictureBox imgBudgetWizardTitle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar needsProgressBar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar wantsProgressBar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar savingsProgressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label needsLabel;
        private System.Windows.Forms.Label wantsLabel;
        private System.Windows.Forms.Label savingsLabel;
    }
}