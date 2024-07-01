namespace Steamroller_Financial_Application
{
    partial class frmNewTransaction
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTransaction));
            txtAmount = new TextBox();
            toolTip1 = new ToolTip(components);
            btnAccept = new Button();
            btnHousing = new Button();
            btnTransportation = new Button();
            btnTravel = new Button();
            btnEntertainment = new Button();
            btnPersonalCare = new Button();
            btnSavings = new Button();
            btnEducation = new Button();
            btnInsurance = new Button();
            btnHealthCare = new Button();
            btnUtilities = new Button();
            btnClothing = new Button();
            btnGroceries = new Button();
            btnPets = new Button();
            btnGifts = new Button();
            btnCash = new Button();
            btnPayBills = new Button();
            btnOnlineBanking = new Button();
            btnCheck = new Button();
            btnCreditCard = new Button();
            btnDebitCard = new Button();
            btnTaxes = new Button();
            label1 = new Label();
            btnCancel = new Button();
            pnlHeader = new Panel();
            lblHeader = new Label();
            lblPaymentMethodHalo = new Label();
            txtPayTo = new TextBox();
            label4 = new Label();
            lblCategoryHalo = new Label();
            lblTopBar = new Label();
            lblBottomBar = new Label();
            lblItemsHalo = new Label();
            picError_Amount = new PictureBox();
            picError_PayTo = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picError_Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picError_PayTo).BeginInit();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Bottom;
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(341, 345);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "0.00";
            txtAmount.Size = new Size(154, 32);
            txtAmount.TabIndex = 16;
            txtAmount.TextAlign = HorizontalAlignment.Center;
            txtAmount.Leave += txtAmount_Leave;
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Bottom;
            btnAccept.BackColor = Color.Transparent;
            btnAccept.BackgroundImage = Properties.Resources.Thumbs_Up_Left;
            btnAccept.BackgroundImageLayout = ImageLayout.Stretch;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Location = new Point(364, 533);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(85, 77);
            btnAccept.TabIndex = 23;
            toolTip1.SetToolTip(btnAccept, "Accept");
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnHousing
            // 
            btnHousing.BackgroundImage = Properties.Resources.House;
            btnHousing.BackgroundImageLayout = ImageLayout.Zoom;
            btnHousing.FlatAppearance.BorderSize = 0;
            btnHousing.Location = new Point(88, 75);
            btnHousing.Name = "btnHousing";
            btnHousing.Size = new Size(75, 75);
            btnHousing.TabIndex = 0;
            btnHousing.Tag = "Housing";
            toolTip1.SetToolTip(btnHousing, "Housing &  Maintenance");
            btnHousing.UseVisualStyleBackColor = true;
            btnHousing.Click += category_Click;
            // 
            // btnTransportation
            // 
            btnTransportation.BackgroundImage = Properties.Resources.Vehicle;
            btnTransportation.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransportation.FlatAppearance.BorderSize = 0;
            btnTransportation.Location = new Point(169, 75);
            btnTransportation.Name = "btnTransportation";
            btnTransportation.Size = new Size(75, 75);
            btnTransportation.TabIndex = 1;
            btnTransportation.Tag = "Transportation";
            toolTip1.SetToolTip(btnTransportation, "Transportation &  Maintenance");
            btnTransportation.UseVisualStyleBackColor = true;
            btnTransportation.Click += category_Click;
            // 
            // btnTravel
            // 
            btnTravel.BackgroundImage = Properties.Resources.Travel;
            btnTravel.BackgroundImageLayout = ImageLayout.Zoom;
            btnTravel.FlatAppearance.BorderSize = 0;
            btnTravel.Location = new Point(412, 156);
            btnTravel.Name = "btnTravel";
            btnTravel.Size = new Size(75, 75);
            btnTravel.TabIndex = 12;
            btnTravel.Tag = "Travel & Leisure";
            toolTip1.SetToolTip(btnTravel, "Travel & Leisure");
            btnTravel.UseVisualStyleBackColor = true;
            btnTravel.Click += category_Click;
            // 
            // btnEntertainment
            // 
            btnEntertainment.BackgroundImage = Properties.Resources.Entertainment;
            btnEntertainment.BackgroundImageLayout = ImageLayout.Zoom;
            btnEntertainment.FlatAppearance.BorderSize = 0;
            btnEntertainment.Location = new Point(331, 156);
            btnEntertainment.Name = "btnEntertainment";
            btnEntertainment.Size = new Size(75, 75);
            btnEntertainment.TabIndex = 11;
            btnEntertainment.Tag = "Entertainment";
            toolTip1.SetToolTip(btnEntertainment, "Entertainment");
            btnEntertainment.UseVisualStyleBackColor = true;
            btnEntertainment.Click += category_Click;
            // 
            // btnPersonalCare
            // 
            btnPersonalCare.BackgroundImage = Properties.Resources.Personal_Care;
            btnPersonalCare.BackgroundImageLayout = ImageLayout.Zoom;
            btnPersonalCare.FlatAppearance.BorderSize = 0;
            btnPersonalCare.Location = new Point(250, 156);
            btnPersonalCare.Name = "btnPersonalCare";
            btnPersonalCare.Size = new Size(75, 75);
            btnPersonalCare.TabIndex = 10;
            btnPersonalCare.Tag = "Personal Care";
            toolTip1.SetToolTip(btnPersonalCare, "Personal Care & Grooming");
            btnPersonalCare.UseVisualStyleBackColor = true;
            btnPersonalCare.Click += category_Click;
            // 
            // btnSavings
            // 
            btnSavings.BackgroundImage = Properties.Resources.PiggyBank;
            btnSavings.BackgroundImageLayout = ImageLayout.Stretch;
            btnSavings.FlatAppearance.BorderSize = 0;
            btnSavings.Location = new Point(169, 156);
            btnSavings.Name = "btnSavings";
            btnSavings.Size = new Size(75, 75);
            btnSavings.TabIndex = 9;
            btnSavings.Tag = "Savings & Investments";
            toolTip1.SetToolTip(btnSavings, "Savings & Investments");
            btnSavings.UseVisualStyleBackColor = true;
            btnSavings.Click += category_Click;
            // 
            // btnEducation
            // 
            btnEducation.BackgroundImage = Properties.Resources.Education;
            btnEducation.BackgroundImageLayout = ImageLayout.Zoom;
            btnEducation.FlatAppearance.BorderSize = 0;
            btnEducation.Location = new Point(88, 156);
            btnEducation.Name = "btnEducation";
            btnEducation.Size = new Size(75, 75);
            btnEducation.TabIndex = 8;
            btnEducation.Tag = "Education & Child Care";
            toolTip1.SetToolTip(btnEducation, "Education & After School Care");
            btnEducation.UseVisualStyleBackColor = true;
            btnEducation.Click += category_Click;
            // 
            // btnInsurance
            // 
            btnInsurance.BackgroundImage = Properties.Resources.Insurance;
            btnInsurance.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsurance.FlatAppearance.BorderSize = 0;
            btnInsurance.Location = new Point(574, 75);
            btnInsurance.Name = "btnInsurance";
            btnInsurance.Size = new Size(75, 75);
            btnInsurance.TabIndex = 6;
            btnInsurance.Tag = "Insurance";
            toolTip1.SetToolTip(btnInsurance, "Insurance");
            btnInsurance.UseVisualStyleBackColor = true;
            btnInsurance.Click += category_Click;
            // 
            // btnHealthCare
            // 
            btnHealthCare.BackgroundImage = Properties.Resources.HealthCare;
            btnHealthCare.BackgroundImageLayout = ImageLayout.Zoom;
            btnHealthCare.FlatAppearance.BorderSize = 0;
            btnHealthCare.Location = new Point(493, 75);
            btnHealthCare.Name = "btnHealthCare";
            btnHealthCare.Size = new Size(75, 75);
            btnHealthCare.TabIndex = 5;
            btnHealthCare.Tag = "Medical Care";
            toolTip1.SetToolTip(btnHealthCare, "Health Care");
            btnHealthCare.UseVisualStyleBackColor = true;
            btnHealthCare.Click += category_Click;
            // 
            // btnUtilities
            // 
            btnUtilities.BackgroundImage = Properties.Resources.Utilites;
            btnUtilities.BackgroundImageLayout = ImageLayout.Zoom;
            btnUtilities.Location = new Point(412, 75);
            btnUtilities.Name = "btnUtilities";
            btnUtilities.Size = new Size(75, 75);
            btnUtilities.TabIndex = 4;
            btnUtilities.Tag = "Utilities";
            toolTip1.SetToolTip(btnUtilities, "Houehold Utilities");
            btnUtilities.UseVisualStyleBackColor = true;
            btnUtilities.Click += category_Click;
            // 
            // btnClothing
            // 
            btnClothing.BackgroundImage = Properties.Resources.Clothes;
            btnClothing.BackgroundImageLayout = ImageLayout.Zoom;
            btnClothing.FlatAppearance.BorderSize = 0;
            btnClothing.Location = new Point(331, 75);
            btnClothing.Name = "btnClothing";
            btnClothing.Size = new Size(75, 75);
            btnClothing.TabIndex = 3;
            btnClothing.Tag = "Clothing";
            toolTip1.SetToolTip(btnClothing, "Clothing & Accessories");
            btnClothing.UseVisualStyleBackColor = true;
            btnClothing.Click += category_Click;
            // 
            // btnGroceries
            // 
            btnGroceries.BackgroundImage = Properties.Resources.Food;
            btnGroceries.BackgroundImageLayout = ImageLayout.Zoom;
            btnGroceries.FlatAppearance.BorderSize = 0;
            btnGroceries.Location = new Point(250, 75);
            btnGroceries.Name = "btnGroceries";
            btnGroceries.Size = new Size(75, 75);
            btnGroceries.TabIndex = 2;
            btnGroceries.Tag = "Food";
            toolTip1.SetToolTip(btnGroceries, "Groceries & Household Supplies");
            btnGroceries.UseVisualStyleBackColor = true;
            btnGroceries.Click += category_Click;
            // 
            // btnPets
            // 
            btnPets.BackgroundImage = Properties.Resources.Pets;
            btnPets.BackgroundImageLayout = ImageLayout.Zoom;
            btnPets.FlatAppearance.BorderSize = 0;
            btnPets.Location = new Point(493, 156);
            btnPets.Name = "btnPets";
            btnPets.Size = new Size(75, 75);
            btnPets.TabIndex = 13;
            btnPets.Tag = "Pets";
            toolTip1.SetToolTip(btnPets, "Pet Care & Accessories");
            btnPets.UseVisualStyleBackColor = true;
            btnPets.Click += category_Click;
            // 
            // btnGifts
            // 
            btnGifts.BackgroundImage = Properties.Resources.Gifts;
            btnGifts.BackgroundImageLayout = ImageLayout.Zoom;
            btnGifts.FlatAppearance.BorderSize = 0;
            btnGifts.Location = new Point(574, 156);
            btnGifts.Name = "btnGifts";
            btnGifts.Size = new Size(75, 75);
            btnGifts.TabIndex = 14;
            btnGifts.Tag = "Gifts & Contributions";
            toolTip1.SetToolTip(btnGifts, "Gifts & Contributions");
            btnGifts.UseVisualStyleBackColor = true;
            btnGifts.Click += category_Click;
            // 
            // btnCash
            // 
            btnCash.Anchor = AnchorStyles.Bottom;
            btnCash.BackColor = Color.Transparent;
            btnCash.BackgroundImage = Properties.Resources.vectorstock_51448106;
            btnCash.BackgroundImageLayout = ImageLayout.Zoom;
            btnCash.FlatAppearance.BorderSize = 0;
            btnCash.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCash.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCash.FlatStyle = FlatStyle.Flat;
            btnCash.Location = new Point(212, 457);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(76, 51);
            btnCash.TabIndex = 18;
            btnCash.Tag = "1";
            toolTip1.SetToolTip(btnCash, "Cash");
            btnCash.UseVisualStyleBackColor = false;
            btnCash.Click += paymentMethod_Click;
            // 
            // btnPayBills
            // 
            btnPayBills.BackgroundImage = (Image)resources.GetObject("btnPayBills.BackgroundImage");
            btnPayBills.BackgroundImageLayout = ImageLayout.Stretch;
            btnPayBills.FlatAppearance.BorderSize = 0;
            btnPayBills.Location = new Point(655, 156);
            btnPayBills.Margin = new Padding(1);
            btnPayBills.Name = "btnPayBills";
            btnPayBills.Size = new Size(75, 75);
            btnPayBills.TabIndex = 15;
            btnPayBills.Tag = "Bills";
            toolTip1.SetToolTip(btnPayBills, "Pay Bills");
            btnPayBills.UseVisualStyleBackColor = true;
            btnPayBills.Click += category_Click;
            // 
            // btnOnlineBanking
            // 
            btnOnlineBanking.Anchor = AnchorStyles.Bottom;
            btnOnlineBanking.BackColor = Color.Transparent;
            btnOnlineBanking.BackgroundImage = Properties.Resources.vectorstock_1143062_transparent;
            btnOnlineBanking.BackgroundImageLayout = ImageLayout.Zoom;
            btnOnlineBanking.FlatAppearance.BorderSize = 0;
            btnOnlineBanking.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOnlineBanking.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOnlineBanking.FlatStyle = FlatStyle.Flat;
            btnOnlineBanking.Location = new Point(548, 457);
            btnOnlineBanking.Name = "btnOnlineBanking";
            btnOnlineBanking.Size = new Size(76, 51);
            btnOnlineBanking.TabIndex = 22;
            btnOnlineBanking.Tag = "5";
            toolTip1.SetToolTip(btnOnlineBanking, "Online Banking");
            btnOnlineBanking.UseVisualStyleBackColor = false;
            btnOnlineBanking.Click += paymentMethod_Click;
            // 
            // btnCheck
            // 
            btnCheck.Anchor = AnchorStyles.Bottom;
            btnCheck.BackColor = Color.Transparent;
            btnCheck.BackgroundImage = Properties.Resources.BlankCheckGreen;
            btnCheck.BackgroundImageLayout = ImageLayout.Zoom;
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCheck.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Location = new Point(296, 457);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(76, 51);
            btnCheck.TabIndex = 19;
            btnCheck.Tag = "2";
            toolTip1.SetToolTip(btnCheck, "Cash");
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += paymentMethod_Click;
            // 
            // btnCreditCard
            // 
            btnCreditCard.Anchor = AnchorStyles.Bottom;
            btnCreditCard.BackColor = Color.Transparent;
            btnCreditCard.BackgroundImage = Properties.Resources.CreditCard;
            btnCreditCard.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreditCard.FlatAppearance.BorderSize = 0;
            btnCreditCard.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCreditCard.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCreditCard.FlatStyle = FlatStyle.Flat;
            btnCreditCard.Location = new Point(380, 457);
            btnCreditCard.Name = "btnCreditCard";
            btnCreditCard.Size = new Size(76, 51);
            btnCreditCard.TabIndex = 20;
            btnCreditCard.Tag = "3";
            toolTip1.SetToolTip(btnCreditCard, "Cash");
            btnCreditCard.UseVisualStyleBackColor = false;
            btnCreditCard.Click += paymentMethod_Click;
            // 
            // btnDebitCard
            // 
            btnDebitCard.Anchor = AnchorStyles.Bottom;
            btnDebitCard.BackColor = Color.Transparent;
            btnDebitCard.BackgroundImage = Properties.Resources.Debit_Card;
            btnDebitCard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDebitCard.FlatAppearance.BorderSize = 0;
            btnDebitCard.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDebitCard.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDebitCard.FlatStyle = FlatStyle.Flat;
            btnDebitCard.Location = new Point(464, 457);
            btnDebitCard.Name = "btnDebitCard";
            btnDebitCard.Size = new Size(76, 51);
            btnDebitCard.TabIndex = 21;
            btnDebitCard.Tag = "6";
            toolTip1.SetToolTip(btnDebitCard, "Cash");
            btnDebitCard.UseVisualStyleBackColor = false;
            btnDebitCard.Click += paymentMethod_Click;
            // 
            // btnTaxes
            // 
            btnTaxes.BackgroundImage = Properties.Resources.Taxes1;
            btnTaxes.BackgroundImageLayout = ImageLayout.Zoom;
            btnTaxes.FlatAppearance.BorderSize = 0;
            btnTaxes.Location = new Point(655, 75);
            btnTaxes.Name = "btnTaxes";
            btnTaxes.Size = new Size(75, 75);
            btnTaxes.TabIndex = 7;
            btnTaxes.Tag = "Taxes & Fees";
            toolTip1.SetToolTip(btnTaxes, "Taxes & Fees");
            btnTaxes.UseVisualStyleBackColor = true;
            btnTaxes.Click += category_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 237, 204);
            label1.Location = new Point(377, 319);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 42;
            label1.Text = "Amount";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImage = Properties.Resources.Cancel1;
            btnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(784, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(25, 25);
            btnCancel.TabIndex = 0;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid1;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(btnCancel);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(812, 55);
            pnlHeader.TabIndex = 47;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Ink Free", 26.2499962F, FontStyle.Bold);
            lblHeader.ForeColor = SystemColors.ActiveCaption;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(812, 55);
            lblHeader.TabIndex = 45;
            lblHeader.Text = "New Transaction";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPaymentMethodHalo
            // 
            lblPaymentMethodHalo.Anchor = AnchorStyles.Bottom;
            lblPaymentMethodHalo.BackColor = Color.LightGreen;
            lblPaymentMethodHalo.Location = new Point(207, 452);
            lblPaymentMethodHalo.MaximumSize = new Size(422, 61);
            lblPaymentMethodHalo.MinimumSize = new Size(86, 61);
            lblPaymentMethodHalo.Name = "lblPaymentMethodHalo";
            lblPaymentMethodHalo.Size = new Size(86, 61);
            lblPaymentMethodHalo.TabIndex = 57;
            lblPaymentMethodHalo.Visible = false;
            // 
            // txtPayTo
            // 
            txtPayTo.Anchor = AnchorStyles.Bottom;
            txtPayTo.BorderStyle = BorderStyle.None;
            txtPayTo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPayTo.Location = new Point(276, 396);
            txtPayTo.Name = "txtPayTo";
            txtPayTo.PlaceholderText = "Who are you paying?";
            txtPayTo.Size = new Size(284, 32);
            txtPayTo.TabIndex = 17;
            txtPayTo.TextAlign = HorizontalAlignment.Center;
            txtPayTo.Leave += txtPayTo_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(244, 237, 204);
            label4.Location = new Point(188, 402);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 59;
            label4.Text = "Paid To:";
            // 
            // lblCategoryHalo
            // 
            lblCategoryHalo.BackColor = Color.LightGreen;
            lblCategoryHalo.Location = new Point(83, 70);
            lblCategoryHalo.MaximumSize = new Size(653, 166);
            lblCategoryHalo.MinimumSize = new Size(85, 85);
            lblCategoryHalo.Name = "lblCategoryHalo";
            lblCategoryHalo.Size = new Size(653, 166);
            lblCategoryHalo.TabIndex = 60;
            lblCategoryHalo.Visible = false;
            // 
            // lblTopBar
            // 
            lblTopBar.BackColor = Color.SlateGray;
            lblTopBar.Location = new Point(96, 245);
            lblTopBar.Name = "lblTopBar";
            lblTopBar.Size = new Size(621, 2);
            lblTopBar.TabIndex = 65;
            // 
            // lblBottomBar
            // 
            lblBottomBar.Anchor = AnchorStyles.Bottom;
            lblBottomBar.BackColor = Color.SlateGray;
            lblBottomBar.Location = new Point(96, 307);
            lblBottomBar.Name = "lblBottomBar";
            lblBottomBar.Size = new Size(621, 2);
            lblBottomBar.TabIndex = 66;
            // 
            // lblItemsHalo
            // 
            lblItemsHalo.BackColor = Color.LightGreen;
            lblItemsHalo.Location = new Point(96, 247);
            lblItemsHalo.Name = "lblItemsHalo";
            lblItemsHalo.Size = new Size(44, 38);
            lblItemsHalo.TabIndex = 67;
            lblItemsHalo.Visible = false;
            // 
            // picError_Amount
            // 
            picError_Amount.Anchor = AnchorStyles.Bottom;
            picError_Amount.BackColor = Color.Transparent;
            picError_Amount.BackgroundImage = Properties.Resources.Warning;
            picError_Amount.BackgroundImageLayout = ImageLayout.Zoom;
            picError_Amount.Location = new Point(500, 330);
            picError_Amount.Name = "picError_Amount";
            picError_Amount.Size = new Size(34, 32);
            picError_Amount.TabIndex = 68;
            picError_Amount.TabStop = false;
            picError_Amount.Visible = false;
            // 
            // picError_PayTo
            // 
            picError_PayTo.Anchor = AnchorStyles.Bottom;
            picError_PayTo.BackColor = Color.Transparent;
            picError_PayTo.BackgroundImage = Properties.Resources.Warning;
            picError_PayTo.BackgroundImageLayout = ImageLayout.Zoom;
            picError_PayTo.Location = new Point(566, 382);
            picError_PayTo.Name = "picError_PayTo";
            picError_PayTo.Size = new Size(34, 32);
            picError_PayTo.TabIndex = 69;
            picError_PayTo.TabStop = false;
            picError_PayTo.Visible = false;
            // 
            // frmNewTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Black_Metal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 630);
            Controls.Add(picError_PayTo);
            Controls.Add(picError_Amount);
            Controls.Add(lblBottomBar);
            Controls.Add(lblTopBar);
            Controls.Add(btnDebitCard);
            Controls.Add(btnCreditCard);
            Controls.Add(btnCheck);
            Controls.Add(label4);
            Controls.Add(txtPayTo);
            Controls.Add(btnOnlineBanking);
            Controls.Add(btnHousing);
            Controls.Add(btnTransportation);
            Controls.Add(btnPayBills);
            Controls.Add(btnTravel);
            Controls.Add(btnCash);
            Controls.Add(btnEntertainment);
            Controls.Add(pnlHeader);
            Controls.Add(btnPersonalCare);
            Controls.Add(btnAccept);
            Controls.Add(btnEducation);
            Controls.Add(btnSavings);
            Controls.Add(btnTaxes);
            Controls.Add(label1);
            Controls.Add(btnInsurance);
            Controls.Add(txtAmount);
            Controls.Add(btnHealthCare);
            Controls.Add(btnUtilities);
            Controls.Add(btnGifts);
            Controls.Add(btnClothing);
            Controls.Add(btnPets);
            Controls.Add(btnGroceries);
            Controls.Add(lblPaymentMethodHalo);
            Controls.Add(lblCategoryHalo);
            Controls.Add(lblItemsHalo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(812, 526);
            Name = "frmNewTransaction";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewTransaction";
            Load += NewTransaction_Load;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picError_Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)picError_PayTo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAmount;
        private ToolTip toolTip1;
        private Label label1;
        private Button btnAccept;
        private Button btnCancel;
        private Panel pnlHeader;
        private Label lblHeader;
        private Button btnHousing;
        private Button btnTransportation;
        private Button btnTravel;
        private Button btnEntertainment;
        private Button btnPersonalCare;
        private Button btnSavings;
        private Button btnEducation;
        private Button btnTaxes;
        private Button btnInsurance;
        private Button btnHealthCare;
        private Button btnUtilities;
        private Button btnClothing;
        private Button btnGroceries;
        private Button btnPets;
        private Button btnGifts;
        private Button btnCash;
        private Button btnPayBills;
        private Button btnOnlineBanking;
        private Button btnDebitCard;
        private Button btnCreditCard;
        private Button btnCheck;
        private Label lblPaymentMethodHalo;
        private TextBox txtPayTo;
        private Label label4;
        private Label lblCategoryHalo;
        private Label lblTopBar;
        private Label lblBottomBar;
        private Label lblItemsHalo;
        private PictureBox picError_Amount;
        private PictureBox picError_PayTo;
    }
}