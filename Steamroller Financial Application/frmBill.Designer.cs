namespace Steamroller_Financial_Application
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            pnlHeader = new Panel();
            btn_Save = new Button();
            btnCancel = new Button();
            btnReturn = new Button();
            lblHeader = new Label();
            lblPnlNewPayee_SelectedDay = new Label();
            label30 = new Label();
            label26 = new Label();
            txtDisplayName = new TextBox();
            label20 = new Label();
            txtCompanyName = new TextBox();
            ckbRecurring = new CheckBox();
            calDatePicker = new MonthCalendar();
            pnlImageSelector = new Panel();
            btnCloseImageSelectorPanel = new Button();
            btnImageSelectorScrollRight = new Button();
            btnImageSelectorScrollLeft = new Button();
            btnUseSelectedImage = new Button();
            lblImageSelectorHeader = new Label();
            picImageSelectorSelectedImage = new PictureBox();
            btnSelectedDay = new Button();
            pnlHouseHold = new Panel();
            label8 = new Label();
            cmbCategoryItems = new ComboBox();
            label7 = new Label();
            label32 = new Label();
            picLogo = new PictureBox();
            ckbPrimaryVendor = new CheckBox();
            label33 = new Label();
            cmbBudgetCategory = new ComboBox();
            groupBox1 = new GroupBox();
            picHouseHold_Cash = new PictureBox();
            label34 = new Label();
            picHouseHold_Check = new PictureBox();
            picHouseHold_Charge = new PictureBox();
            picHouseHold_OnlineBanking = new PictureBox();
            lblPaymentMethodHighligter = new Label();
            pnlCreditCard = new Panel();
            label6 = new Label();
            txtCreditCardAPR = new TextBox();
            txtCreditCard_StartingBalance = new TextBox();
            label48 = new Label();
            label46 = new Label();
            groupBox2 = new GroupBox();
            label35 = new Label();
            picCreditCard_Check = new PictureBox();
            picCreditCard_DebitCard = new PictureBox();
            picCreditCard_OnlineBanking = new PictureBox();
            lblPaymentMethodHighligter2 = new Label();
            picCardSelectedImage = new PictureBox();
            label29 = new Label();
            pnlLoan = new Panel();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtEndDate = new DateTimePicker();
            dtStartDate = new DateTimePicker();
            btnLoanTypeScroll_Left = new Button();
            btnLoanTypeScroll_Right = new Button();
            txtLoan_APR = new TextBox();
            label57 = new Label();
            picLoanType = new PictureBox();
            txtLoan_StartingBalance = new TextBox();
            label49 = new Label();
            label50 = new Label();
            groupBox3 = new GroupBox();
            picLoan_CreditCard = new PictureBox();
            picLoan_Cash = new PictureBox();
            label51 = new Label();
            picLoan_Check = new PictureBox();
            picLoan_DebitCard = new PictureBox();
            picLoan_OnlineBanking = new PictureBox();
            lblPaymentMethodHighligter3 = new Label();
            label4 = new Label();
            pnlAccountInformation = new Panel();
            label45 = new Label();
            label28 = new Label();
            mtbAccount_ZipCode = new MaskedTextBox();
            mtbAccountPhoneNumber = new MaskedTextBox();
            label27 = new Label();
            cmbStateAbreviations = new ComboBox();
            lblAccountInformation = new Label();
            txtAccount_Address2 = new TextBox();
            label25 = new Label();
            txtAccount_City = new TextBox();
            txtAccount_Number = new TextBox();
            label21 = new Label();
            label24 = new Label();
            txtAccount_Website = new TextBox();
            txtAccount_Address = new TextBox();
            label22 = new Label();
            label23 = new Label();
            ckbAutoPay = new CheckBox();
            btnHouseHold = new Button();
            btnLoan = new Button();
            btnCreditCard = new Button();
            pnlHeader.SuspendLayout();
            pnlImageSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImageSelectorSelectedImage).BeginInit();
            pnlHouseHold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHouseHold_Cash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHouseHold_Check).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHouseHold_Charge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHouseHold_OnlineBanking).BeginInit();
            pnlCreditCard.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCreditCard_Check).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCreditCard_DebitCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCreditCard_OnlineBanking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCardSelectedImage).BeginInit();
            pnlLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoanType).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoan_CreditCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLoan_Cash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLoan_Check).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLoan_DebitCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLoan_OnlineBanking).BeginInit();
            pnlAccountInformation.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid1;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(btn_Save);
            pnlHeader.Controls.Add(btnCancel);
            pnlHeader.Controls.Add(btnReturn);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(796, 55);
            pnlHeader.TabIndex = 48;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.Transparent;
            btn_Save.BackgroundImage = Properties.Resources.Save;
            btn_Save.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Save.ForeColor = Color.Cyan;
            btn_Save.Location = new Point(3, 7);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(51, 45);
            btn_Save.TabIndex = 38;
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImage = Properties.Resources.Cancel1;
            btnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(765, 4);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(25, 25);
            btnCancel.TabIndex = 46;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReturn
            // 
            btnReturn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReturn.BackColor = Color.Transparent;
            btnReturn.BackgroundImage = Properties.Resources.Cancel1;
            btnReturn.BackgroundImageLayout = ImageLayout.Zoom;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Location = new Point(1547, 4);
            btnReturn.Margin = new Padding(4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(32, 35);
            btnReturn.TabIndex = 44;
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Ink Free", 26.2499962F, FontStyle.Bold);
            lblHeader.ForeColor = SystemColors.ActiveCaption;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(796, 55);
            lblHeader.TabIndex = 45;
            lblHeader.Text = "New Bill";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPnlNewPayee_SelectedDay
            // 
            lblPnlNewPayee_SelectedDay.AutoSize = true;
            lblPnlNewPayee_SelectedDay.BackColor = Color.Transparent;
            lblPnlNewPayee_SelectedDay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPnlNewPayee_SelectedDay.ForeColor = Color.FromArgb(244, 237, 204);
            lblPnlNewPayee_SelectedDay.Location = new Point(346, 241);
            lblPnlNewPayee_SelectedDay.Margin = new Padding(4, 0, 4, 0);
            lblPnlNewPayee_SelectedDay.Name = "lblPnlNewPayee_SelectedDay";
            lblPnlNewPayee_SelectedDay.Size = new Size(105, 15);
            lblPnlNewPayee_SelectedDay.TabIndex = 60;
            lblPnlNewPayee_SelectedDay.Text = "Select Due By Date";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Segoe UI", 14.25F);
            label30.ForeColor = Color.FromArgb(244, 237, 204);
            label30.Location = new Point(371, 156);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(51, 25);
            label30.TabIndex = 54;
            label30.Text = "Type";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Segoe UI", 14.25F);
            label26.ForeColor = Color.FromArgb(244, 237, 204);
            label26.Location = new Point(403, 79);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(136, 25);
            label26.TabIndex = 52;
            label26.Text = "*Display Name";
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(403, 108);
            txtDisplayName.Margin = new Padding(4);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(262, 29);
            txtDisplayName.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 14.25F);
            label20.ForeColor = Color.FromArgb(244, 237, 204);
            label20.Location = new Point(132, 79);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(147, 25);
            label20.TabIndex = 50;
            label20.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(132, 108);
            txtCompanyName.Margin = new Padding(4);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(262, 29);
            txtCompanyName.TabIndex = 0;
            // 
            // ckbRecurring
            // 
            ckbRecurring.AutoSize = true;
            ckbRecurring.BackColor = Color.Transparent;
            ckbRecurring.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbRecurring.ForeColor = Color.FromArgb(244, 237, 204);
            ckbRecurring.Location = new Point(425, 425);
            ckbRecurring.Margin = new Padding(4);
            ckbRecurring.Name = "ckbRecurring";
            ckbRecurring.Size = new Size(83, 21);
            ckbRecurring.TabIndex = 7;
            ckbRecurring.Text = "Recurring";
            ckbRecurring.UseVisualStyleBackColor = false;
            // 
            // calDatePicker
            // 
            calDatePicker.Location = new Point(285, 262);
            calDatePicker.Margin = new Padding(12, 13, 12, 13);
            calDatePicker.Name = "calDatePicker";
            calDatePicker.TabIndex = 5;
            calDatePicker.DateSelected += calDatePicker_DateSelected;
            // 
            // pnlImageSelector
            // 
            pnlImageSelector.Controls.Add(btnCloseImageSelectorPanel);
            pnlImageSelector.Controls.Add(btnImageSelectorScrollRight);
            pnlImageSelector.Controls.Add(btnImageSelectorScrollLeft);
            pnlImageSelector.Controls.Add(btnUseSelectedImage);
            pnlImageSelector.Controls.Add(lblImageSelectorHeader);
            pnlImageSelector.Controls.Add(picImageSelectorSelectedImage);
            pnlImageSelector.Location = new Point(233, 228);
            pnlImageSelector.Margin = new Padding(4);
            pnlImageSelector.Name = "pnlImageSelector";
            pnlImageSelector.Size = new Size(330, 218);
            pnlImageSelector.TabIndex = 58;
            pnlImageSelector.Tag = "Permanant";
            pnlImageSelector.Visible = false;
            // 
            // btnCloseImageSelectorPanel
            // 
            btnCloseImageSelectorPanel.BackColor = Color.FromArgb(95, 93, 156);
            btnCloseImageSelectorPanel.BackgroundImage = Properties.Resources.Cancel1;
            btnCloseImageSelectorPanel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseImageSelectorPanel.FlatAppearance.BorderSize = 0;
            btnCloseImageSelectorPanel.FlatStyle = FlatStyle.Flat;
            btnCloseImageSelectorPanel.Location = new Point(395, 4);
            btnCloseImageSelectorPanel.Margin = new Padding(4);
            btnCloseImageSelectorPanel.Name = "btnCloseImageSelectorPanel";
            btnCloseImageSelectorPanel.Size = new Size(26, 28);
            btnCloseImageSelectorPanel.TabIndex = 26;
            btnCloseImageSelectorPanel.UseVisualStyleBackColor = false;
            // 
            // btnImageSelectorScrollRight
            // 
            btnImageSelectorScrollRight.BackgroundImage = Properties.Resources.Right_Pointer_Black1;
            btnImageSelectorScrollRight.BackgroundImageLayout = ImageLayout.Zoom;
            btnImageSelectorScrollRight.Dock = DockStyle.Right;
            btnImageSelectorScrollRight.Location = new Point(263, 53);
            btnImageSelectorScrollRight.Margin = new Padding(4);
            btnImageSelectorScrollRight.Name = "btnImageSelectorScrollRight";
            btnImageSelectorScrollRight.Size = new Size(67, 106);
            btnImageSelectorScrollRight.TabIndex = 4;
            btnImageSelectorScrollRight.Tag = "";
            btnImageSelectorScrollRight.UseVisualStyleBackColor = true;
            btnImageSelectorScrollRight.Click += ImageSelectorControls_Click;
            // 
            // btnImageSelectorScrollLeft
            // 
            btnImageSelectorScrollLeft.BackgroundImage = Properties.Resources.Left_Pointer_Black1;
            btnImageSelectorScrollLeft.BackgroundImageLayout = ImageLayout.Zoom;
            btnImageSelectorScrollLeft.Dock = DockStyle.Left;
            btnImageSelectorScrollLeft.Location = new Point(0, 53);
            btnImageSelectorScrollLeft.Margin = new Padding(4);
            btnImageSelectorScrollLeft.Name = "btnImageSelectorScrollLeft";
            btnImageSelectorScrollLeft.Size = new Size(75, 106);
            btnImageSelectorScrollLeft.TabIndex = 3;
            btnImageSelectorScrollLeft.Tag = "";
            btnImageSelectorScrollLeft.UseVisualStyleBackColor = true;
            btnImageSelectorScrollLeft.Click += ImageSelectorControls_Click;
            // 
            // btnUseSelectedImage
            // 
            btnUseSelectedImage.Dock = DockStyle.Bottom;
            btnUseSelectedImage.Location = new Point(0, 159);
            btnUseSelectedImage.Margin = new Padding(4);
            btnUseSelectedImage.Name = "btnUseSelectedImage";
            btnUseSelectedImage.Size = new Size(330, 59);
            btnUseSelectedImage.TabIndex = 2;
            btnUseSelectedImage.Tag = "-1";
            btnUseSelectedImage.Text = "Accept";
            btnUseSelectedImage.UseVisualStyleBackColor = true;
            btnUseSelectedImage.Click += btnUseSelectedImage_Click;
            // 
            // lblImageSelectorHeader
            // 
            lblImageSelectorHeader.BackColor = Color.FromArgb(95, 93, 156);
            lblImageSelectorHeader.Dock = DockStyle.Top;
            lblImageSelectorHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImageSelectorHeader.ForeColor = Color.FromArgb(0, 192, 192);
            lblImageSelectorHeader.Location = new Point(0, 0);
            lblImageSelectorHeader.Margin = new Padding(4, 0, 4, 0);
            lblImageSelectorHeader.Name = "lblImageSelectorHeader";
            lblImageSelectorHeader.Size = new Size(330, 53);
            lblImageSelectorHeader.TabIndex = 1;
            lblImageSelectorHeader.Text = "Card Selector";
            lblImageSelectorHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picImageSelectorSelectedImage
            // 
            picImageSelectorSelectedImage.BorderStyle = BorderStyle.FixedSingle;
            picImageSelectorSelectedImage.Location = new Point(82, 57);
            picImageSelectorSelectedImage.Margin = new Padding(4);
            picImageSelectorSelectedImage.Name = "picImageSelectorSelectedImage";
            picImageSelectorSelectedImage.Size = new Size(173, 94);
            picImageSelectorSelectedImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImageSelectorSelectedImage.TabIndex = 0;
            picImageSelectorSelectedImage.TabStop = false;
            // 
            // btnSelectedDay
            // 
            btnSelectedDay.BackgroundImage = Properties.Resources.CalendarPic;
            btnSelectedDay.BackgroundImageLayout = ImageLayout.Stretch;
            btnSelectedDay.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectedDay.Location = new Point(286, 262);
            btnSelectedDay.Margin = new Padding(4);
            btnSelectedDay.Name = "btnSelectedDay";
            btnSelectedDay.Size = new Size(227, 162);
            btnSelectedDay.TabIndex = 53;
            btnSelectedDay.Text = "17";
            btnSelectedDay.TextAlign = ContentAlignment.BottomCenter;
            btnSelectedDay.UseVisualStyleBackColor = true;
            btnSelectedDay.Visible = false;
            btnSelectedDay.Click += btnSelectedDay_Click;
            // 
            // pnlHouseHold
            // 
            pnlHouseHold.BorderStyle = BorderStyle.FixedSingle;
            pnlHouseHold.Controls.Add(label8);
            pnlHouseHold.Controls.Add(cmbCategoryItems);
            pnlHouseHold.Controls.Add(label7);
            pnlHouseHold.Controls.Add(label32);
            pnlHouseHold.Controls.Add(picLogo);
            pnlHouseHold.Controls.Add(ckbPrimaryVendor);
            pnlHouseHold.Controls.Add(label33);
            pnlHouseHold.Controls.Add(cmbBudgetCategory);
            pnlHouseHold.Controls.Add(groupBox1);
            pnlHouseHold.Dock = DockStyle.Bottom;
            pnlHouseHold.Location = new Point(0, 784);
            pnlHouseHold.MaximumSize = new Size(796, 371);
            pnlHouseHold.Name = "pnlHouseHold";
            pnlHouseHold.Size = new Size(796, 30);
            pnlHouseHold.TabIndex = 65;
            pnlHouseHold.Tag = "Permanant";
            pnlHouseHold.Visible = false;
            pnlHouseHold.DragDrop += Logo_DragDrop;
            pnlHouseHold.DragEnter += Logo_DragEnter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(438, 34);
            label8.Name = "label8";
            label8.Size = new Size(108, 21);
            label8.TabIndex = 46;
            label8.Text = "Category Item";
            // 
            // cmbCategoryItems
            // 
            cmbCategoryItems.FormattingEnabled = true;
            cmbCategoryItems.Location = new Point(406, 58);
            cmbCategoryItems.Name = "cmbCategoryItems";
            cmbCategoryItems.Size = new Size(172, 29);
            cmbCategoryItems.TabIndex = 1;
            cmbCategoryItems.SelectedIndexChanged += cmbCategoryItems_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(378, 179);
            label7.Name = "label7";
            label7.Size = new Size(38, 13);
            label7.TabIndex = 44;
            label7.Text = "*Logo";
            // 
            // label32
            // 
            label32.BackColor = Color.FromArgb(192, 255, 255);
            label32.BorderStyle = BorderStyle.FixedSingle;
            label32.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.Location = new Point(0, 0);
            label32.Name = "label32";
            label32.Size = new Size(93, 25);
            label32.TabIndex = 0;
            label32.Text = "House Hold";
            label32.Visible = false;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(340, 102);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(114, 74);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 43;
            picLogo.TabStop = false;
            picLogo.DragDrop += Logo_DragDrop;
            picLogo.DragEnter += Logo_DragEnter;
            // 
            // ckbPrimaryVendor
            // 
            ckbPrimaryVendor.AutoSize = true;
            ckbPrimaryVendor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbPrimaryVendor.Location = new Point(584, 68);
            ckbPrimaryVendor.Name = "ckbPrimaryVendor";
            ckbPrimaryVendor.Size = new Size(118, 19);
            ckbPrimaryVendor.TabIndex = 2;
            ckbPrimaryVendor.Text = "Is Primary Vendor";
            ckbPrimaryVendor.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(240, 34);
            label33.Name = "label33";
            label33.Size = new Size(126, 21);
            label33.TabIndex = 2;
            label33.Text = "Budget Category";
            // 
            // cmbBudgetCategory
            // 
            cmbBudgetCategory.FormattingEnabled = true;
            cmbBudgetCategory.Location = new Point(217, 58);
            cmbBudgetCategory.Name = "cmbBudgetCategory";
            cmbBudgetCategory.Size = new Size(172, 29);
            cmbBudgetCategory.TabIndex = 0;
            cmbBudgetCategory.SelectedIndexChanged += cmbBudgetCategory_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picHouseHold_Cash);
            groupBox1.Controls.Add(label34);
            groupBox1.Controls.Add(picHouseHold_Check);
            groupBox1.Controls.Add(picHouseHold_Charge);
            groupBox1.Controls.Add(picHouseHold_OnlineBanking);
            groupBox1.Controls.Add(lblPaymentMethodHighligter);
            groupBox1.Location = new Point(131, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 147);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // picHouseHold_Cash
            // 
            picHouseHold_Cash.Image = Properties.Resources.vectorstock_51448106;
            picHouseHold_Cash.Location = new Point(16, 55);
            picHouseHold_Cash.Name = "picHouseHold_Cash";
            picHouseHold_Cash.Size = new Size(125, 68);
            picHouseHold_Cash.SizeMode = PictureBoxSizeMode.Zoom;
            picHouseHold_Cash.TabIndex = 31;
            picHouseHold_Cash.TabStop = false;
            picHouseHold_Cash.Tag = "House Hold:Cash";
            picHouseHold_Cash.Click += PreferedPaymentMethod_Click;
            // 
            // label34
            // 
            label34.Dock = DockStyle.Top;
            label34.Location = new Point(3, 25);
            label34.Name = "label34";
            label34.Size = new Size(551, 25);
            label34.TabIndex = 0;
            label34.Text = "Prefered Payment Method";
            label34.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picHouseHold_Check
            // 
            picHouseHold_Check.Image = Properties.Resources.BlankCheckGreen;
            picHouseHold_Check.Location = new Point(149, 55);
            picHouseHold_Check.Name = "picHouseHold_Check";
            picHouseHold_Check.Size = new Size(125, 68);
            picHouseHold_Check.SizeMode = PictureBoxSizeMode.StretchImage;
            picHouseHold_Check.TabIndex = 30;
            picHouseHold_Check.TabStop = false;
            picHouseHold_Check.Tag = "House Hold:Check";
            picHouseHold_Check.Click += PreferedPaymentMethod_Click;
            // 
            // picHouseHold_Charge
            // 
            picHouseHold_Charge.Image = Properties.Resources.CreditCard;
            picHouseHold_Charge.Location = new Point(282, 55);
            picHouseHold_Charge.Name = "picHouseHold_Charge";
            picHouseHold_Charge.Size = new Size(125, 68);
            picHouseHold_Charge.SizeMode = PictureBoxSizeMode.Zoom;
            picHouseHold_Charge.TabIndex = 32;
            picHouseHold_Charge.TabStop = false;
            picHouseHold_Charge.Tag = "House Hold:Credit Card";
            picHouseHold_Charge.Click += PreferedPaymentMethod_Click;
            // 
            // picHouseHold_OnlineBanking
            // 
            picHouseHold_OnlineBanking.Image = Properties.Resources.vectorstock_1143062_transparent;
            picHouseHold_OnlineBanking.Location = new Point(415, 55);
            picHouseHold_OnlineBanking.Name = "picHouseHold_OnlineBanking";
            picHouseHold_OnlineBanking.Size = new Size(125, 68);
            picHouseHold_OnlineBanking.SizeMode = PictureBoxSizeMode.Zoom;
            picHouseHold_OnlineBanking.TabIndex = 33;
            picHouseHold_OnlineBanking.TabStop = false;
            picHouseHold_OnlineBanking.Tag = "House Hold:Online Banking";
            picHouseHold_OnlineBanking.Click += PreferedPaymentMethod_Click;
            // 
            // lblPaymentMethodHighligter
            // 
            lblPaymentMethodHighligter.BackColor = Color.DodgerBlue;
            lblPaymentMethodHighligter.Location = new Point(10, 55);
            lblPaymentMethodHighligter.Name = "lblPaymentMethodHighligter";
            lblPaymentMethodHighligter.Size = new Size(135, 78);
            lblPaymentMethodHighligter.TabIndex = 1;
            lblPaymentMethodHighligter.Visible = false;
            // 
            // pnlCreditCard
            // 
            pnlCreditCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCreditCard.Controls.Add(label6);
            pnlCreditCard.Controls.Add(txtCreditCardAPR);
            pnlCreditCard.Controls.Add(txtCreditCard_StartingBalance);
            pnlCreditCard.Controls.Add(label48);
            pnlCreditCard.Controls.Add(label46);
            pnlCreditCard.Controls.Add(groupBox2);
            pnlCreditCard.Controls.Add(picCardSelectedImage);
            pnlCreditCard.Controls.Add(label29);
            pnlCreditCard.Dock = DockStyle.Bottom;
            pnlCreditCard.Location = new Point(0, 814);
            pnlCreditCard.MaximumSize = new Size(796, 371);
            pnlCreditCard.Name = "pnlCreditCard";
            pnlCreditCard.Size = new Size(796, 26);
            pnlCreditCard.TabIndex = 64;
            pnlCreditCard.Tag = "Permanant";
            pnlCreditCard.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(379, 102);
            label6.Name = "label6";
            label6.Size = new Size(37, 13);
            label6.TabIndex = 48;
            label6.Text = "Select";
            // 
            // txtCreditCardAPR
            // 
            txtCreditCardAPR.Location = new Point(430, 133);
            txtCreditCardAPR.Name = "txtCreditCardAPR";
            txtCreditCardAPR.PlaceholderText = "0.00%";
            txtCreditCardAPR.Size = new Size(77, 29);
            txtCreditCardAPR.TabIndex = 2;
            txtCreditCardAPR.TextAlign = HorizontalAlignment.Center;
            txtCreditCardAPR.KeyPress += TextBoxValidationOn_KeyPress;
            // 
            // txtCreditCard_StartingBalance
            // 
            txtCreditCard_StartingBalance.Location = new Point(288, 133);
            txtCreditCard_StartingBalance.Name = "txtCreditCard_StartingBalance";
            txtCreditCard_StartingBalance.PlaceholderText = "0.00";
            txtCreditCard_StartingBalance.Size = new Size(77, 29);
            txtCreditCard_StartingBalance.TabIndex = 1;
            txtCreditCard_StartingBalance.TextAlign = HorizontalAlignment.Center;
            txtCreditCard_StartingBalance.KeyPress += TextBoxValidationOn_KeyPress;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(165, 137);
            label48.Name = "label48";
            label48.Size = new Size(121, 21);
            label48.TabIndex = 45;
            label48.Text = "Starting Balance";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(379, 137);
            label46.Name = "label46";
            label46.Size = new Size(52, 21);
            label46.TabIndex = 41;
            label46.Text = "APR%";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label35);
            groupBox2.Controls.Add(picCreditCard_Check);
            groupBox2.Controls.Add(picCreditCard_DebitCard);
            groupBox2.Controls.Add(picCreditCard_OnlineBanking);
            groupBox2.Controls.Add(lblPaymentMethodHighligter2);
            groupBox2.Location = new Point(179, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(436, 144);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            // 
            // label35
            // 
            label35.Dock = DockStyle.Top;
            label35.Location = new Point(3, 25);
            label35.Name = "label35";
            label35.Size = new Size(430, 25);
            label35.TabIndex = 36;
            label35.Text = "Prefered Payment Method";
            label35.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picCreditCard_Check
            // 
            picCreditCard_Check.Image = Properties.Resources.BlankCheckGreen;
            picCreditCard_Check.Location = new Point(18, 60);
            picCreditCard_Check.Name = "picCreditCard_Check";
            picCreditCard_Check.Size = new Size(125, 68);
            picCreditCard_Check.SizeMode = PictureBoxSizeMode.StretchImage;
            picCreditCard_Check.TabIndex = 30;
            picCreditCard_Check.TabStop = false;
            picCreditCard_Check.Tag = "Credit Card:Check";
            picCreditCard_Check.Click += PreferedPaymentMethod_Click;
            // 
            // picCreditCard_DebitCard
            // 
            picCreditCard_DebitCard.Image = (Image)resources.GetObject("picCreditCard_DebitCard.Image");
            picCreditCard_DebitCard.Location = new Point(156, 60);
            picCreditCard_DebitCard.Name = "picCreditCard_DebitCard";
            picCreditCard_DebitCard.Size = new Size(125, 68);
            picCreditCard_DebitCard.SizeMode = PictureBoxSizeMode.Zoom;
            picCreditCard_DebitCard.TabIndex = 32;
            picCreditCard_DebitCard.TabStop = false;
            picCreditCard_DebitCard.Tag = "Credit Card:Debit";
            picCreditCard_DebitCard.Click += PreferedPaymentMethod_Click;
            // 
            // picCreditCard_OnlineBanking
            // 
            picCreditCard_OnlineBanking.Image = Properties.Resources.vectorstock_1143062_transparent;
            picCreditCard_OnlineBanking.Location = new Point(294, 60);
            picCreditCard_OnlineBanking.Name = "picCreditCard_OnlineBanking";
            picCreditCard_OnlineBanking.Size = new Size(125, 68);
            picCreditCard_OnlineBanking.SizeMode = PictureBoxSizeMode.Zoom;
            picCreditCard_OnlineBanking.TabIndex = 33;
            picCreditCard_OnlineBanking.TabStop = false;
            picCreditCard_OnlineBanking.Tag = "Credit Card:Online Banking";
            picCreditCard_OnlineBanking.Click += PreferedPaymentMethod_Click;
            // 
            // lblPaymentMethodHighligter2
            // 
            lblPaymentMethodHighligter2.BackColor = SystemColors.MenuHighlight;
            lblPaymentMethodHighligter2.Location = new Point(15, 60);
            lblPaymentMethodHighligter2.MaximumSize = new Size(135, 78);
            lblPaymentMethodHighligter2.Name = "lblPaymentMethodHighligter2";
            lblPaymentMethodHighligter2.Size = new Size(135, 78);
            lblPaymentMethodHighligter2.TabIndex = 37;
            lblPaymentMethodHighligter2.Visible = false;
            // 
            // picCardSelectedImage
            // 
            picCardSelectedImage.BorderStyle = BorderStyle.FixedSingle;
            picCardSelectedImage.Image = Properties.Resources.CreditCardLogos;
            picCardSelectedImage.Location = new Point(348, 32);
            picCardSelectedImage.Name = "picCardSelectedImage";
            picCardSelectedImage.Size = new Size(98, 67);
            picCardSelectedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picCardSelectedImage.TabIndex = 1;
            picCardSelectedImage.TabStop = false;
            picCardSelectedImage.Click += picCardSelectedImage_Click;
            // 
            // label29
            // 
            label29.BackColor = Color.FromArgb(192, 255, 255);
            label29.BorderStyle = BorderStyle.FixedSingle;
            label29.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(0, 0);
            label29.Name = "label29";
            label29.Size = new Size(127, 25);
            label29.TabIndex = 0;
            label29.Text = "Credit Card Data";
            label29.Visible = false;
            // 
            // pnlLoan
            // 
            pnlLoan.BorderStyle = BorderStyle.FixedSingle;
            pnlLoan.Controls.Add(label5);
            pnlLoan.Controls.Add(label3);
            pnlLoan.Controls.Add(label2);
            pnlLoan.Controls.Add(label1);
            pnlLoan.Controls.Add(dtEndDate);
            pnlLoan.Controls.Add(dtStartDate);
            pnlLoan.Controls.Add(btnLoanTypeScroll_Left);
            pnlLoan.Controls.Add(btnLoanTypeScroll_Right);
            pnlLoan.Controls.Add(txtLoan_APR);
            pnlLoan.Controls.Add(label57);
            pnlLoan.Controls.Add(picLoanType);
            pnlLoan.Controls.Add(txtLoan_StartingBalance);
            pnlLoan.Controls.Add(label49);
            pnlLoan.Controls.Add(label50);
            pnlLoan.Controls.Add(groupBox3);
            pnlLoan.Controls.Add(label4);
            pnlLoan.Dock = DockStyle.Bottom;
            pnlLoan.Location = new Point(0, 840);
            pnlLoan.MaximumSize = new Size(796, 371);
            pnlLoan.Name = "pnlLoan";
            pnlLoan.Size = new Size(796, 37);
            pnlLoan.TabIndex = 8;
            pnlLoan.Tag = "Permanant";
            pnlLoan.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(303, 47);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 62;
            label5.Text = "Terms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F);
            label3.Location = new Point(616, 122);
            label3.Name = "label3";
            label3.Size = new Size(51, 13);
            label3.TabIndex = 61;
            label3.Text = "Personal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F);
            label2.Location = new Point(346, 99);
            label2.Name = "label2";
            label2.Size = new Size(54, 13);
            label2.TabIndex = 60;
            label2.Text = "End Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F);
            label1.Location = new Point(247, 99);
            label1.Name = "label1";
            label1.Size = new Size(58, 13);
            label1.TabIndex = 59;
            label1.Text = "Start Date";
            // 
            // dtEndDate
            // 
            dtEndDate.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtEndDate.CustomFormat = "MM/dd/yyyy";
            dtEndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtEndDate.Format = DateTimePickerFormat.Custom;
            dtEndDate.Location = new Point(328, 71);
            dtEndDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(91, 25);
            dtEndDate.TabIndex = 2;
            // 
            // dtStartDate
            // 
            dtStartDate.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtStartDate.CustomFormat = "MM/dd/yyyy";
            dtStartDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtStartDate.Format = DateTimePickerFormat.Custom;
            dtStartDate.Location = new Point(231, 71);
            dtStartDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(91, 25);
            dtStartDate.TabIndex = 1;
            // 
            // btnLoanTypeScroll_Left
            // 
            btnLoanTypeScroll_Left.BackColor = Color.Transparent;
            btnLoanTypeScroll_Left.BackgroundImage = Properties.Resources.Left_Pointer_Black;
            btnLoanTypeScroll_Left.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoanTypeScroll_Left.FlatAppearance.BorderSize = 0;
            btnLoanTypeScroll_Left.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnLoanTypeScroll_Left.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnLoanTypeScroll_Left.FlatStyle = FlatStyle.Flat;
            btnLoanTypeScroll_Left.Location = new Point(557, 68);
            btnLoanTypeScroll_Left.Name = "btnLoanTypeScroll_Left";
            btnLoanTypeScroll_Left.Size = new Size(30, 30);
            btnLoanTypeScroll_Left.TabIndex = 56;
            btnLoanTypeScroll_Left.Tag = "-1";
            btnLoanTypeScroll_Left.UseVisualStyleBackColor = false;
            btnLoanTypeScroll_Left.Click += LoanTypeSelector_Click;
            // 
            // btnLoanTypeScroll_Right
            // 
            btnLoanTypeScroll_Right.BackColor = Color.Transparent;
            btnLoanTypeScroll_Right.BackgroundImage = Properties.Resources.Right_Pointer_Black;
            btnLoanTypeScroll_Right.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoanTypeScroll_Right.FlatAppearance.BorderSize = 0;
            btnLoanTypeScroll_Right.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnLoanTypeScroll_Right.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnLoanTypeScroll_Right.FlatStyle = FlatStyle.Flat;
            btnLoanTypeScroll_Right.Location = new Point(696, 68);
            btnLoanTypeScroll_Right.Name = "btnLoanTypeScroll_Right";
            btnLoanTypeScroll_Right.Size = new Size(30, 30);
            btnLoanTypeScroll_Right.TabIndex = 55;
            btnLoanTypeScroll_Right.Tag = "1";
            btnLoanTypeScroll_Right.UseVisualStyleBackColor = false;
            btnLoanTypeScroll_Right.Click += LoanTypeSelector_Click;
            // 
            // txtLoan_APR
            // 
            txtLoan_APR.Location = new Point(485, 69);
            txtLoan_APR.Name = "txtLoan_APR";
            txtLoan_APR.PlaceholderText = "0.00%";
            txtLoan_APR.Size = new Size(59, 29);
            txtLoan_APR.TabIndex = 3;
            txtLoan_APR.TextAlign = HorizontalAlignment.Center;
            txtLoan_APR.KeyPress += TextBoxValidationOn_KeyPress;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label57.Location = new Point(626, 33);
            label57.Name = "label57";
            label57.Size = new Size(30, 13);
            label57.TabIndex = 53;
            label57.Text = "Type";
            // 
            // picLoanType
            // 
            picLoanType.BorderStyle = BorderStyle.FixedSingle;
            picLoanType.Image = Properties.Resources.Personal_Loan;
            picLoanType.Location = new Point(589, 48);
            picLoanType.Name = "picLoanType";
            picLoanType.Size = new Size(105, 71);
            picLoanType.SizeMode = PictureBoxSizeMode.StretchImage;
            picLoanType.TabIndex = 52;
            picLoanType.TabStop = false;
            picLoanType.Tag = "1";
            // 
            // txtLoan_StartingBalance
            // 
            txtLoan_StartingBalance.Location = new Point(148, 69);
            txtLoan_StartingBalance.Name = "txtLoan_StartingBalance";
            txtLoan_StartingBalance.PlaceholderText = "0.00";
            txtLoan_StartingBalance.Size = new Size(77, 29);
            txtLoan_StartingBalance.TabIndex = 0;
            txtLoan_StartingBalance.TextAlign = HorizontalAlignment.Center;
            txtLoan_StartingBalance.KeyPress += TextBoxValidationOn_KeyPress;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(26, 73);
            label49.Name = "label49";
            label49.Size = new Size(121, 21);
            label49.TabIndex = 50;
            label49.Text = "Starting Balance";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(428, 73);
            label50.Name = "label50";
            label50.Size = new Size(52, 21);
            label50.TabIndex = 49;
            label50.Text = "APR%";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picLoan_CreditCard);
            groupBox3.Controls.Add(picLoan_Cash);
            groupBox3.Controls.Add(label51);
            groupBox3.Controls.Add(picLoan_Check);
            groupBox3.Controls.Add(picLoan_DebitCard);
            groupBox3.Controls.Add(picLoan_OnlineBanking);
            groupBox3.Controls.Add(lblPaymentMethodHighligter3);
            groupBox3.Location = new Point(63, 150);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(668, 146);
            groupBox3.TabIndex = 47;
            groupBox3.TabStop = false;
            // 
            // picLoan_CreditCard
            // 
            picLoan_CreditCard.Image = Properties.Resources.CreditCard;
            picLoan_CreditCard.Location = new Point(533, 62);
            picLoan_CreditCard.Name = "picLoan_CreditCard";
            picLoan_CreditCard.Size = new Size(125, 68);
            picLoan_CreditCard.SizeMode = PictureBoxSizeMode.Zoom;
            picLoan_CreditCard.TabIndex = 38;
            picLoan_CreditCard.TabStop = false;
            picLoan_CreditCard.Tag = "Loan:Credit Card";
            picLoan_CreditCard.Click += PreferedPaymentMethod_Click;
            // 
            // picLoan_Cash
            // 
            picLoan_Cash.Image = Properties.Resources.vectorstock_51448106;
            picLoan_Cash.Location = new Point(10, 62);
            picLoan_Cash.Name = "picLoan_Cash";
            picLoan_Cash.Size = new Size(125, 68);
            picLoan_Cash.SizeMode = PictureBoxSizeMode.Zoom;
            picLoan_Cash.TabIndex = 37;
            picLoan_Cash.TabStop = false;
            picLoan_Cash.Tag = "Loan:Cash";
            picLoan_Cash.Click += PreferedPaymentMethod_Click;
            // 
            // label51
            // 
            label51.Dock = DockStyle.Top;
            label51.Location = new Point(3, 25);
            label51.Name = "label51";
            label51.Size = new Size(662, 25);
            label51.TabIndex = 36;
            label51.Text = "Prefered Payment Method";
            label51.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLoan_Check
            // 
            picLoan_Check.Image = Properties.Resources.BlankCheckGreen;
            picLoan_Check.Location = new Point(140, 62);
            picLoan_Check.Name = "picLoan_Check";
            picLoan_Check.Size = new Size(125, 68);
            picLoan_Check.SizeMode = PictureBoxSizeMode.StretchImage;
            picLoan_Check.TabIndex = 30;
            picLoan_Check.TabStop = false;
            picLoan_Check.Tag = "Loan:Check";
            picLoan_Check.Click += PreferedPaymentMethod_Click;
            // 
            // picLoan_DebitCard
            // 
            picLoan_DebitCard.Image = (Image)resources.GetObject("picLoan_DebitCard.Image");
            picLoan_DebitCard.Location = new Point(402, 62);
            picLoan_DebitCard.Name = "picLoan_DebitCard";
            picLoan_DebitCard.Size = new Size(125, 68);
            picLoan_DebitCard.SizeMode = PictureBoxSizeMode.Zoom;
            picLoan_DebitCard.TabIndex = 32;
            picLoan_DebitCard.TabStop = false;
            picLoan_DebitCard.Tag = "Loan:Debit Card";
            picLoan_DebitCard.Click += PreferedPaymentMethod_Click;
            // 
            // picLoan_OnlineBanking
            // 
            picLoan_OnlineBanking.Image = Properties.Resources.vectorstock_1143062_transparent;
            picLoan_OnlineBanking.Location = new Point(270, 62);
            picLoan_OnlineBanking.Name = "picLoan_OnlineBanking";
            picLoan_OnlineBanking.Size = new Size(125, 68);
            picLoan_OnlineBanking.SizeMode = PictureBoxSizeMode.Zoom;
            picLoan_OnlineBanking.TabIndex = 33;
            picLoan_OnlineBanking.TabStop = false;
            picLoan_OnlineBanking.Tag = "Loan:Online Banking";
            picLoan_OnlineBanking.Click += PreferedPaymentMethod_Click;
            // 
            // lblPaymentMethodHighligter3
            // 
            lblPaymentMethodHighligter3.BackColor = SystemColors.MenuHighlight;
            lblPaymentMethodHighligter3.Location = new Point(10, 52);
            lblPaymentMethodHighligter3.Name = "lblPaymentMethodHighligter3";
            lblPaymentMethodHighligter3.Size = new Size(135, 78);
            lblPaymentMethodHighligter3.TabIndex = 52;
            lblPaymentMethodHighligter3.Visible = false;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(192, 255, 255);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 0;
            label4.Text = "Loan Data";
            label4.Visible = false;
            // 
            // pnlAccountInformation
            // 
            pnlAccountInformation.BorderStyle = BorderStyle.FixedSingle;
            pnlAccountInformation.Controls.Add(label45);
            pnlAccountInformation.Controls.Add(label28);
            pnlAccountInformation.Controls.Add(mtbAccount_ZipCode);
            pnlAccountInformation.Controls.Add(mtbAccountPhoneNumber);
            pnlAccountInformation.Controls.Add(label27);
            pnlAccountInformation.Controls.Add(cmbStateAbreviations);
            pnlAccountInformation.Controls.Add(lblAccountInformation);
            pnlAccountInformation.Controls.Add(txtAccount_Address2);
            pnlAccountInformation.Controls.Add(label25);
            pnlAccountInformation.Controls.Add(txtAccount_City);
            pnlAccountInformation.Controls.Add(txtAccount_Number);
            pnlAccountInformation.Controls.Add(label21);
            pnlAccountInformation.Controls.Add(label24);
            pnlAccountInformation.Controls.Add(txtAccount_Website);
            pnlAccountInformation.Controls.Add(txtAccount_Address);
            pnlAccountInformation.Controls.Add(label22);
            pnlAccountInformation.Controls.Add(label23);
            pnlAccountInformation.Dock = DockStyle.Bottom;
            pnlAccountInformation.Location = new Point(0, 877);
            pnlAccountInformation.MaximumSize = new Size(796, 371);
            pnlAccountInformation.MinimumSize = new Size(796, 27);
            pnlAccountInformation.Name = "pnlAccountInformation";
            pnlAccountInformation.Size = new Size(796, 32);
            pnlAccountInformation.TabIndex = 62;
            pnlAccountInformation.Tag = "Permanant";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(135, 171);
            label45.Name = "label45";
            label45.Size = new Size(112, 21);
            label45.TabIndex = 20;
            label45.Text = "Address Line 2";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(339, 233);
            label28.Name = "label28";
            label28.Size = new Size(72, 21);
            label28.TabIndex = 19;
            label28.Text = "Zip Code";
            // 
            // mtbAccount_ZipCode
            // 
            mtbAccount_ZipCode.Location = new Point(339, 257);
            mtbAccount_ZipCode.Mask = "00000";
            mtbAccount_ZipCode.Name = "mtbAccount_ZipCode";
            mtbAccount_ZipCode.Size = new Size(72, 29);
            mtbAccount_ZipCode.TabIndex = 3;
            mtbAccount_ZipCode.TextAlign = HorizontalAlignment.Center;
            mtbAccount_ZipCode.ValidatingType = typeof(int);
            // 
            // mtbAccountPhoneNumber
            // 
            mtbAccountPhoneNumber.Location = new Point(455, 129);
            mtbAccountPhoneNumber.Mask = "(999) 000-0000";
            mtbAccountPhoneNumber.Name = "mtbAccountPhoneNumber";
            mtbAccountPhoneNumber.Size = new Size(122, 29);
            mtbAccountPhoneNumber.TabIndex = 17;
            mtbAccountPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(261, 233);
            label27.Name = "label27";
            label27.Size = new Size(44, 21);
            label27.TabIndex = 16;
            label27.Text = "State";
            // 
            // cmbStateAbreviations
            // 
            cmbStateAbreviations.FormattingEnabled = true;
            cmbStateAbreviations.Location = new Point(261, 257);
            cmbStateAbreviations.Name = "cmbStateAbreviations";
            cmbStateAbreviations.Size = new Size(72, 29);
            cmbStateAbreviations.TabIndex = 2;
            // 
            // lblAccountInformation
            // 
            lblAccountInformation.BackColor = Color.FromArgb(255, 192, 192);
            lblAccountInformation.BorderStyle = BorderStyle.FixedSingle;
            lblAccountInformation.Enabled = false;
            lblAccountInformation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccountInformation.Location = new Point(0, 0);
            lblAccountInformation.Name = "lblAccountInformation";
            lblAccountInformation.Size = new Size(161, 25);
            lblAccountInformation.TabIndex = 0;
            lblAccountInformation.Text = "*Account Information";
            lblAccountInformation.Click += lblAccountInformation_Click;
            // 
            // txtAccount_Address2
            // 
            txtAccount_Address2.Location = new Point(135, 191);
            txtAccount_Address2.Name = "txtAccount_Address2";
            txtAccount_Address2.Size = new Size(276, 29);
            txtAccount_Address2.TabIndex = 9;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(135, 105);
            label25.Name = "label25";
            label25.Size = new Size(66, 21);
            label25.TabIndex = 14;
            label25.Text = "Address";
            // 
            // txtAccount_City
            // 
            txtAccount_City.Location = new Point(135, 257);
            txtAccount_City.Name = "txtAccount_City";
            txtAccount_City.Size = new Size(120, 29);
            txtAccount_City.TabIndex = 1;
            // 
            // txtAccount_Number
            // 
            txtAccount_Number.Location = new Point(135, 60);
            txtAccount_Number.Name = "txtAccount_Number";
            txtAccount_Number.Size = new Size(205, 29);
            txtAccount_Number.TabIndex = 0;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(135, 233);
            label21.Name = "label21";
            label21.Size = new Size(37, 21);
            label21.TabIndex = 6;
            label21.Text = "City";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(135, 36);
            label24.Name = "label24";
            label24.Size = new Size(128, 21);
            label24.TabIndex = 12;
            label24.Text = "Account Number";
            // 
            // txtAccount_Website
            // 
            txtAccount_Website.Location = new Point(455, 191);
            txtAccount_Website.Name = "txtAccount_Website";
            txtAccount_Website.Size = new Size(205, 29);
            txtAccount_Website.TabIndex = 7;
            // 
            // txtAccount_Address
            // 
            txtAccount_Address.Location = new Point(135, 129);
            txtAccount_Address.Name = "txtAccount_Address";
            txtAccount_Address.Size = new Size(276, 29);
            txtAccount_Address.TabIndex = 11;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(455, 171);
            label22.Name = "label22";
            label22.Size = new Size(65, 21);
            label22.TabIndex = 8;
            label22.Text = "Website";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(455, 105);
            label23.Name = "label23";
            label23.Size = new Size(116, 21);
            label23.TabIndex = 10;
            label23.Text = "Phone Number";
            // 
            // ckbAutoPay
            // 
            ckbAutoPay.AutoSize = true;
            ckbAutoPay.BackColor = Color.Transparent;
            ckbAutoPay.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbAutoPay.ForeColor = Color.FromArgb(244, 237, 204);
            ckbAutoPay.Location = new Point(289, 425);
            ckbAutoPay.Margin = new Padding(4);
            ckbAutoPay.Name = "ckbAutoPay";
            ckbAutoPay.Size = new Size(78, 21);
            ckbAutoPay.TabIndex = 6;
            ckbAutoPay.Text = "Auto Pay";
            ckbAutoPay.UseVisualStyleBackColor = false;
            // 
            // btnHouseHold
            // 
            btnHouseHold.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnHouseHold.FlatAppearance.BorderSize = 0;
            btnHouseHold.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnHouseHold.FlatStyle = FlatStyle.Flat;
            btnHouseHold.Location = new Point(131, 187);
            btnHouseHold.Name = "btnHouseHold";
            btnHouseHold.Size = new Size(170, 37);
            btnHouseHold.TabIndex = 2;
            btnHouseHold.Text = "House Hold";
            btnHouseHold.UseVisualStyleBackColor = true;
            btnHouseHold.Click += AccountTypeDecisionButtons_Click;
            // 
            // btnLoan
            // 
            btnLoan.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnLoan.FlatAppearance.BorderSize = 0;
            btnLoan.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnLoan.FlatStyle = FlatStyle.Flat;
            btnLoan.Location = new Point(313, 187);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(170, 37);
            btnLoan.TabIndex = 3;
            btnLoan.Text = "Loan";
            btnLoan.UseVisualStyleBackColor = true;
            btnLoan.Click += AccountTypeDecisionButtons_Click;
            // 
            // btnCreditCard
            // 
            btnCreditCard.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnCreditCard.FlatAppearance.BorderSize = 0;
            btnCreditCard.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnCreditCard.FlatStyle = FlatStyle.Flat;
            btnCreditCard.Location = new Point(495, 186);
            btnCreditCard.Name = "btnCreditCard";
            btnCreditCard.Size = new Size(170, 37);
            btnCreditCard.TabIndex = 4;
            btnCreditCard.Text = "Credit Card";
            btnCreditCard.UseVisualStyleBackColor = true;
            btnCreditCard.Click += AccountTypeDecisionButtons_Click;
            // 
            // frmBill
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Black_Metal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(796, 909);
            Controls.Add(btnCreditCard);
            Controls.Add(btnLoan);
            Controls.Add(btnHouseHold);
            Controls.Add(ckbAutoPay);
            Controls.Add(pnlHouseHold);
            Controls.Add(pnlCreditCard);
            Controls.Add(pnlLoan);
            Controls.Add(pnlAccountInformation);
            Controls.Add(lblPnlNewPayee_SelectedDay);
            Controls.Add(label30);
            Controls.Add(label26);
            Controls.Add(txtDisplayName);
            Controls.Add(label20);
            Controls.Add(txtCompanyName);
            Controls.Add(ckbRecurring);
            Controls.Add(pnlHeader);
            Controls.Add(calDatePicker);
            Controls.Add(btnSelectedDay);
            Controls.Add(pnlImageSelector);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmBill";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Account";
            Load += frmBill_Load;
            pnlHeader.ResumeLayout(false);
            pnlImageSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImageSelectorSelectedImage).EndInit();
            pnlHouseHold.ResumeLayout(false);
            pnlHouseHold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHouseHold_Cash).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHouseHold_Check).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHouseHold_Charge).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHouseHold_OnlineBanking).EndInit();
            pnlCreditCard.ResumeLayout(false);
            pnlCreditCard.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCreditCard_Check).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCreditCard_DebitCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCreditCard_OnlineBanking).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCardSelectedImage).EndInit();
            pnlLoan.ResumeLayout(false);
            pnlLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLoanType).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLoan_CreditCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLoan_Cash).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLoan_Check).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLoan_DebitCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLoan_OnlineBanking).EndInit();
            pnlAccountInformation.ResumeLayout(false);
            pnlAccountInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Button btnReturn;
        private Label lblHeader;
        private Label lblPnlNewPayee_SelectedDay;
        private Label label30;
        private Label label26;
        private TextBox txtDisplayName;
        private Label label20;
        private TextBox txtCompanyName;
        private CheckBox ckbRecurring;
        private MonthCalendar calDatePicker;
        private Panel pnlImageSelector;
        private Button btnCloseImageSelectorPanel;
        private Button btnImageSelectorScrollRight;
        private Button btnImageSelectorScrollLeft;
        private Button btnUseSelectedImage;
        private Label lblImageSelectorHeader;
        private PictureBox picImageSelectorSelectedImage;
        private Button btnSelectedDay;
        private Panel pnlHouseHold;
        private Button btn_Save;
        private Label label32;
        private Label label33;
        private ComboBox cmbBudgetCategory;
        private GroupBox groupBox1;
        private PictureBox picHouseHold_Cash;
        private Label label34;
        private PictureBox picHouseHold_Check;
        private PictureBox picHouseHold_Charge;
        private PictureBox picHouseHold_OnlineBanking;
        private Label lblPaymentMethodHighligter;
        private Panel pnlCreditCard;
        private TextBox txtCreditCard_StartingBalance;
        private Label label48;
        private Label label46;
        private GroupBox groupBox2;
        private Label label35;
        private PictureBox picCreditCard_Check;
        private PictureBox picCreditCard_DebitCard;
        private PictureBox picCreditCard_OnlineBanking;
        private Label lblPaymentMethodHighligter2;
        private PictureBox picCardSelectedImage;
        private Label label29;
        private Panel pnlLoan;
        private Label label57;
        private PictureBox picLoanType;
        private TextBox txtLoan_StartingBalance;
        private Label label49;
        private Label label50;
        private GroupBox groupBox3;
        private PictureBox picLoan_CreditCard;
        private PictureBox picLoan_Cash;
        private Label label51;
        private PictureBox picLoan_Check;
        private PictureBox picLoan_DebitCard;
        private PictureBox picLoan_OnlineBanking;
        private Label lblPaymentMethodHighligter3;
        private Label label4;
        private Panel pnlAccountInformation;
        private Label label45;
        private Label label28;
        private MaskedTextBox mtbAccount_ZipCode;
        private MaskedTextBox mtbAccountPhoneNumber;
        private Label label27;
        private ComboBox cmbStateAbreviations;
        private Label lblAccountInformation;
        private TextBox txtAccount_Address2;
        private Label label25;
        private TextBox txtAccount_City;
        private TextBox txtAccount_Number;
        private Label label21;
        private Label label24;
        private TextBox txtAccount_Website;
        private TextBox txtAccount_Address;
        private Label label22;
        private Label label23;
        private TextBox txtLoan_APR;
        private Button btnCancel;
        private Button btnLoanTypeScroll_Right;
        private Button btnLoanTypeScroll_Left;
        private DateTimePicker dtStartDate;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtEndDate;
        private Label label6;
        private TextBox txtCreditCardAPR;
        private Label label5;
        private CheckBox ckbAutoPay;
        private Label label7;
        private PictureBox picLogo;
        private CheckBox ckbPrimaryVendor;
        private Label label8;
        private ComboBox cmbCategoryItems;
        private Button btnHouseHold;
        private Button btnLoan;
        private Button btnCreditCard;
    }
}