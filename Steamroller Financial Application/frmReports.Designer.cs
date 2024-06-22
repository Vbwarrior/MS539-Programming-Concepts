
namespace Steamroller_Financial_Application
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            pnlHeader = new Panel();
            btnCancel = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            dgDataDisplay = new DataGridView();
            picDayMonthYearSlider = new PictureBox();
            txtLastRangeValue = new TextBox();
            picSlider_2 = new PictureBox();
            picSlider_3 = new PictureBox();
            picSlider_4 = new PictureBox();
            picSlider_5 = new PictureBox();
            cmbCategories = new ComboBox();
            btnAddCategories = new Button();
            dateStartDate = new DateTimePicker();
            dateEndDate = new DateTimePicker();
            btnAddPaymentMethod = new Button();
            cmbPaymentMethod = new ComboBox();
            btnAddPaidTo = new Button();
            cmbPaidTo = new ComboBox();
            picSlider_1 = new PictureBox();
            btnDisplayHelp = new Button();
            btnSave = new Button();
            btnSearchDatabase = new Button();
            btnDeleteReport = new Button();
            button6 = new Button();
            btnSaveQueryName = new Button();
            btnReturn = new Button();
            btnTranactions = new Button();
            btnIncome = new Button();
            btnBills = new Button();
            btnBudget = new Button();
            txtName = new TextBox();
            pnlFilter = new Panel();
            rtbDirections = new RichTextBox();
            lblReportName = new Label();
            label3 = new Label();
            txtAmount = new TextBox();
            label6 = new Label();
            lblDayMonthYearValue = new Label();
            lblRangeType = new Label();
            label14 = new Label();
            picSlider_6 = new PictureBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            lblFilterHeader = new Label();
            pnlData = new Panel();
            pnlSaveInfo = new Panel();
            label7 = new Label();
            lblColor = new Label();
            label4 = new Label();
            cdSelectColor = new ColorDialog();
            flpnlCustomReports = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDataDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDayMonthYearSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSlider_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSlider_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSlider_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSlider_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSlider_1).BeginInit();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSlider_6).BeginInit();
            pnlData.SuspendLayout();
            pnlSaveInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(btnCancel);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(843, 55);
            pnlHeader.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImage = Properties.Resources.Cancel1;
            btnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(815, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(25, 25);
            btnCancel.TabIndex = 1;
            toolTip1.SetToolTip(btnCancel, "Cancel and Close");
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Ink Free", 26.2499962F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(843, 55);
            label1.TabIndex = 0;
            label1.Text = "Reports";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgDataDisplay
            // 
            dgDataDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDataDisplay.Dock = DockStyle.Bottom;
            dgDataDisplay.Location = new Point(0, 53);
            dgDataDisplay.Name = "dgDataDisplay";
            dgDataDisplay.Size = new Size(144, 43);
            dgDataDisplay.TabIndex = 2;
            toolTip1.SetToolTip(dgDataDisplay, "Report Data");
            // 
            // picDayMonthYearSlider
            // 
            picDayMonthYearSlider.Cursor = Cursors.Hand;
            picDayMonthYearSlider.Enabled = false;
            picDayMonthYearSlider.Image = Properties.Resources.Slider3PosOff;
            picDayMonthYearSlider.Location = new Point(399, 98);
            picDayMonthYearSlider.Name = "picDayMonthYearSlider";
            picDayMonthYearSlider.Size = new Size(117, 33);
            picDayMonthYearSlider.SizeMode = PictureBoxSizeMode.Zoom;
            picDayMonthYearSlider.TabIndex = 6;
            picDayMonthYearSlider.TabStop = false;
            picDayMonthYearSlider.Tag = "1";
            toolTip1.SetToolTip(picDayMonthYearSlider, "Select Days, Months, or Years");
            picDayMonthYearSlider.Click += picDayMonthYearSlider_Click;
            // 
            // txtLastRangeValue
            // 
            txtLastRangeValue.BackColor = SystemColors.GradientInactiveCaption;
            txtLastRangeValue.BorderStyle = BorderStyle.None;
            txtLastRangeValue.Cursor = Cursors.Hand;
            txtLastRangeValue.Enabled = false;
            txtLastRangeValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastRangeValue.Location = new Point(350, 100);
            txtLastRangeValue.Name = "txtLastRangeValue";
            txtLastRangeValue.Size = new Size(38, 28);
            txtLastRangeValue.TabIndex = 4;
            toolTip1.SetToolTip(txtLastRangeValue, "Past amount of Days, Months, or Years to apply to filter.");
            // 
            // picSlider_2
            // 
            picSlider_2.Cursor = Cursors.Hand;
            picSlider_2.Image = Properties.Resources.Slider_Off3;
            picSlider_2.Location = new Point(155, 137);
            picSlider_2.Name = "picSlider_2";
            picSlider_2.Size = new Size(87, 33);
            picSlider_2.SizeMode = PictureBoxSizeMode.Zoom;
            picSlider_2.TabIndex = 14;
            picSlider_2.TabStop = false;
            picSlider_2.Tag = "1:Category";
            toolTip1.SetToolTip(picSlider_2, "Category Filter");
            picSlider_2.Click += Sliders_Click;
            // 
            // picSlider_3
            // 
            picSlider_3.Cursor = Cursors.Hand;
            picSlider_3.Image = Properties.Resources.Slider_Off3;
            picSlider_3.Location = new Point(155, 176);
            picSlider_3.Name = "picSlider_3";
            picSlider_3.Size = new Size(87, 33);
            picSlider_3.SizeMode = PictureBoxSizeMode.Zoom;
            picSlider_3.TabIndex = 15;
            picSlider_3.TabStop = false;
            picSlider_3.Tag = "1:Date";
            toolTip1.SetToolTip(picSlider_3, "Date Filter");
            picSlider_3.Click += Sliders_Click;
            // 
            // picSlider_4
            // 
            picSlider_4.Cursor = Cursors.Hand;
            picSlider_4.Image = Properties.Resources.Slider_Off3;
            picSlider_4.Location = new Point(155, 215);
            picSlider_4.Name = "picSlider_4";
            picSlider_4.Size = new Size(87, 33);
            picSlider_4.SizeMode = PictureBoxSizeMode.Zoom;
            picSlider_4.TabIndex = 16;
            picSlider_4.TabStop = false;
            picSlider_4.Tag = "1:Payment";
            toolTip1.SetToolTip(picSlider_4, "Payment Method Filter");
            picSlider_4.Click += Sliders_Click;
            // 
            // picSlider_5
            // 
            picSlider_5.Cursor = Cursors.Hand;
            picSlider_5.Image = Properties.Resources.Slider_Off3;
            picSlider_5.Location = new Point(155, 254);
            picSlider_5.Name = "picSlider_5";
            picSlider_5.Size = new Size(87, 33);
            picSlider_5.SizeMode = PictureBoxSizeMode.Zoom;
            picSlider_5.TabIndex = 17;
            picSlider_5.TabStop = false;
            picSlider_5.Tag = "1:Pay";
            toolTip1.SetToolTip(picSlider_5, "Paid To Filter");
            picSlider_5.Click += Sliders_Click;
            // 
            // cmbCategories
            // 
            cmbCategories.Cursor = Cursors.Hand;
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.Enabled = false;
            cmbCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(248, 139);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(131, 29);
            cmbCategories.TabIndex = 26;
            toolTip1.SetToolTip(cmbCategories, "Select Category");
            // 
            // btnAddCategories
            // 
            btnAddCategories.BackgroundImage = Properties.Resources.Add2;
            btnAddCategories.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddCategories.Cursor = Cursors.Hand;
            btnAddCategories.Enabled = false;
            btnAddCategories.FlatAppearance.BorderSize = 0;
            btnAddCategories.FlatStyle = FlatStyle.Flat;
            btnAddCategories.Location = new Point(385, 141);
            btnAddCategories.Name = "btnAddCategories";
            btnAddCategories.Size = new Size(25, 25);
            btnAddCategories.TabIndex = 27;
            toolTip1.SetToolTip(btnAddCategories, "Add Aditional Categories");
            btnAddCategories.UseVisualStyleBackColor = true;
            btnAddCategories.Click += btnAddCategories_Click;
            // 
            // dateStartDate
            // 
            dateStartDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateStartDate.Cursor = Cursors.Hand;
            dateStartDate.Enabled = false;
            dateStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateStartDate.Location = new Point(248, 178);
            dateStartDate.Name = "dateStartDate";
            dateStartDate.Size = new Size(267, 29);
            dateStartDate.TabIndex = 28;
            toolTip1.SetToolTip(dateStartDate, "Start Date");
            // 
            // dateEndDate
            // 
            dateEndDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateEndDate.Cursor = Cursors.Hand;
            dateEndDate.Enabled = false;
            dateEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateEndDate.Location = new Point(542, 178);
            dateEndDate.Name = "dateEndDate";
            dateEndDate.Size = new Size(267, 29);
            dateEndDate.TabIndex = 29;
            toolTip1.SetToolTip(dateEndDate, "End Date");
            // 
            // btnAddPaymentMethod
            // 
            btnAddPaymentMethod.BackgroundImage = Properties.Resources.Add2;
            btnAddPaymentMethod.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddPaymentMethod.Cursor = Cursors.Hand;
            btnAddPaymentMethod.Enabled = false;
            btnAddPaymentMethod.FlatAppearance.BorderSize = 0;
            btnAddPaymentMethod.FlatStyle = FlatStyle.Flat;
            btnAddPaymentMethod.Location = new Point(385, 221);
            btnAddPaymentMethod.Name = "btnAddPaymentMethod";
            btnAddPaymentMethod.Size = new Size(25, 25);
            btnAddPaymentMethod.TabIndex = 34;
            toolTip1.SetToolTip(btnAddPaymentMethod, "Add Aditional Categories");
            btnAddPaymentMethod.UseVisualStyleBackColor = true;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Cursor = Cursors.Hand;
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Enabled = false;
            cmbPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(248, 219);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(131, 29);
            cmbPaymentMethod.TabIndex = 33;
            toolTip1.SetToolTip(cmbPaymentMethod, "Select Category");
            // 
            // btnAddPaidTo
            // 
            btnAddPaidTo.BackgroundImage = Properties.Resources.Add2;
            btnAddPaidTo.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddPaidTo.Cursor = Cursors.Hand;
            btnAddPaidTo.Enabled = false;
            btnAddPaidTo.FlatAppearance.BorderSize = 0;
            btnAddPaidTo.FlatStyle = FlatStyle.Flat;
            btnAddPaidTo.Location = new Point(385, 258);
            btnAddPaidTo.Name = "btnAddPaidTo";
            btnAddPaidTo.Size = new Size(25, 25);
            btnAddPaidTo.TabIndex = 36;
            toolTip1.SetToolTip(btnAddPaidTo, "Add Aditional Categories");
            btnAddPaidTo.UseVisualStyleBackColor = true;
            // 
            // cmbPaidTo
            // 
            cmbPaidTo.Cursor = Cursors.Hand;
            cmbPaidTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaidTo.Enabled = false;
            cmbPaidTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaidTo.FormattingEnabled = true;
            cmbPaidTo.Location = new Point(248, 256);
            cmbPaidTo.Name = "cmbPaidTo";
            cmbPaidTo.Size = new Size(131, 29);
            cmbPaidTo.TabIndex = 35;
            toolTip1.SetToolTip(cmbPaidTo, "Select Category");
            // 
            // picSlider_1
            // 
            picSlider_1.Cursor = Cursors.Hand;
            picSlider_1.Image = Properties.Resources.Slider_Off3;
            picSlider_1.Location = new Point(155, 98);
            picSlider_1.Name = "picSlider_1";
            picSlider_1.Size = new Size(87, 33);
            picSlider_1.SizeMode = PictureBoxSizeMode.Zoom;
            picSlider_1.TabIndex = 38;
            picSlider_1.TabStop = false;
            picSlider_1.Tag = "1:Display";
            toolTip1.SetToolTip(picSlider_1, "Display Filter");
            picSlider_1.Click += Sliders_Click;
            // 
            // btnDisplayHelp
            // 
            btnDisplayHelp.BackColor = Color.FromArgb(64, 64, 64);
            btnDisplayHelp.BackgroundImage = Properties.Resources.HelpBlue;
            btnDisplayHelp.BackgroundImageLayout = ImageLayout.Zoom;
            btnDisplayHelp.Cursor = Cursors.Hand;
            btnDisplayHelp.FlatAppearance.BorderSize = 0;
            btnDisplayHelp.FlatStyle = FlatStyle.Flat;
            btnDisplayHelp.Location = new Point(805, 2);
            btnDisplayHelp.Name = "btnDisplayHelp";
            btnDisplayHelp.Size = new Size(35, 35);
            btnDisplayHelp.TabIndex = 40;
            toolTip1.SetToolTip(btnDisplayHelp, "Display Help");
            btnDisplayHelp.UseVisualStyleBackColor = false;
            btnDisplayHelp.Click += btnDisplayHelp_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.BackgroundImage = Properties.Resources.Save;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(51, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(48, 33);
            btnSave.TabIndex = 43;
            toolTip1.SetToolTip(btnSave, "Save Custom Search");
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearchDatabase
            // 
            btnSearchDatabase.BackgroundImage = Properties.Resources.SearchDatabase1;
            btnSearchDatabase.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchDatabase.Cursor = Cursors.Hand;
            btnSearchDatabase.FlatAppearance.BorderSize = 0;
            btnSearchDatabase.FlatStyle = FlatStyle.Flat;
            btnSearchDatabase.Location = new Point(446, 227);
            btnSearchDatabase.Name = "btnSearchDatabase";
            btnSearchDatabase.Size = new Size(108, 97);
            btnSearchDatabase.TabIndex = 44;
            toolTip1.SetToolTip(btnSearchDatabase, "Execute Search");
            btnSearchDatabase.UseVisualStyleBackColor = true;
            btnSearchDatabase.Click += btnSearchDatabase_Click;
            // 
            // btnDeleteReport
            // 
            btnDeleteReport.BackColor = Color.FromArgb(64, 64, 64);
            btnDeleteReport.BackgroundImage = Properties.Resources.Delete;
            btnDeleteReport.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleteReport.Cursor = Cursors.Hand;
            btnDeleteReport.FlatAppearance.BorderSize = 0;
            btnDeleteReport.FlatStyle = FlatStyle.Flat;
            btnDeleteReport.Location = new Point(107, 5);
            btnDeleteReport.Name = "btnDeleteReport";
            btnDeleteReport.Size = new Size(35, 33);
            btnDeleteReport.TabIndex = 46;
            toolTip1.SetToolTip(btnDeleteReport, "Delete Custom Search");
            btnDeleteReport.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.Black;
            button6.BackgroundImage = Properties.Resources.Cancel1;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(371, 3);
            button6.Name = "button6";
            button6.Size = new Size(25, 25);
            button6.TabIndex = 2;
            toolTip1.SetToolTip(button6, "Cancel");
            button6.UseVisualStyleBackColor = false;
            // 
            // btnSaveQueryName
            // 
            btnSaveQueryName.BackColor = Color.Transparent;
            btnSaveQueryName.BackgroundImage = Properties.Resources.Thumbs_Up_Left;
            btnSaveQueryName.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaveQueryName.FlatAppearance.BorderSize = 0;
            btnSaveQueryName.FlatStyle = FlatStyle.Flat;
            btnSaveQueryName.Location = new Point(323, 55);
            btnSaveQueryName.Name = "btnSaveQueryName";
            btnSaveQueryName.Size = new Size(44, 49);
            btnSaveQueryName.TabIndex = 6;
            toolTip1.SetToolTip(btnSaveQueryName, "Accept and Save");
            btnSaveQueryName.UseVisualStyleBackColor = false;
            btnSaveQueryName.Click += btnSaveQueryName_Click;
            // 
            // btnReturn
            // 
            btnReturn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReturn.BackColor = Color.FromArgb(64, 64, 64);
            btnReturn.BackgroundImage = Properties.Resources.Return_Logo1;
            btnReturn.BackgroundImageLayout = ImageLayout.Zoom;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Location = new Point(3, 7);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(42, 25);
            btnReturn.TabIndex = 47;
            toolTip1.SetToolTip(btnReturn, "Return to Report Selection");
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnTranactions
            // 
            btnTranactions.BackgroundImage = Properties.Resources.Transactions;
            btnTranactions.BackgroundImageLayout = ImageLayout.Zoom;
            btnTranactions.Cursor = Cursors.Hand;
            btnTranactions.FlatStyle = FlatStyle.Flat;
            btnTranactions.Location = new Point(246, 80);
            btnTranactions.Name = "btnTranactions";
            btnTranactions.Size = new Size(84, 84);
            btnTranactions.TabIndex = 11;
            btnTranactions.Tag = "1:Transactions";
            btnTranactions.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnTranactions, "Transactions");
            btnTranactions.UseVisualStyleBackColor = true;
            btnTranactions.Click += PredefinedReports_Click;
            // 
            // btnIncome
            // 
            btnIncome.BackColor = Color.White;
            btnIncome.BackgroundImage = Properties.Resources.Record_Income;
            btnIncome.BackgroundImageLayout = ImageLayout.Zoom;
            btnIncome.Cursor = Cursors.Hand;
            btnIncome.FlatStyle = FlatStyle.Flat;
            btnIncome.Location = new Point(335, 80);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(84, 84);
            btnIncome.TabIndex = 12;
            btnIncome.Tag = "1:Income";
            btnIncome.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnIncome, "Income");
            btnIncome.UseVisualStyleBackColor = false;
            btnIncome.Click += PredefinedReports_Click;
            // 
            // btnBills
            // 
            btnBills.BackgroundImage = Properties.Resources.Bills;
            btnBills.BackgroundImageLayout = ImageLayout.Zoom;
            btnBills.Cursor = Cursors.Hand;
            btnBills.FlatStyle = FlatStyle.Flat;
            btnBills.Location = new Point(424, 80);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(84, 84);
            btnBills.TabIndex = 13;
            btnBills.Tag = "1:Bill";
            btnBills.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnBills, "Bills");
            btnBills.UseVisualStyleBackColor = true;
            btnBills.Click += PredefinedReports_Click;
            // 
            // btnBudget
            // 
            btnBudget.BackColor = Color.FromArgb(137, 115, 208);
            btnBudget.BackgroundImage = Properties.Resources.Budget;
            btnBudget.BackgroundImageLayout = ImageLayout.Zoom;
            btnBudget.Cursor = Cursors.Hand;
            btnBudget.FlatStyle = FlatStyle.Flat;
            btnBudget.Location = new Point(513, 80);
            btnBudget.Name = "btnBudget";
            btnBudget.Size = new Size(84, 84);
            btnBudget.TabIndex = 14;
            btnBudget.Tag = "1:Budget";
            btnBudget.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnBudget, "Budget");
            btnBudget.UseVisualStyleBackColor = false;
            btnBudget.Click += PredefinedReports_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(76, 60);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Report Name";
            txtName.ReadOnly = true;
            txtName.Size = new Size(241, 39);
            txtName.TabIndex = 4;
            txtName.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(txtName, "Display Name for Custom Report");
            txtName.TextChanged += txtName_TextChanged;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = SystemColors.ActiveCaption;
            pnlFilter.Controls.Add(btnReturn);
            pnlFilter.Controls.Add(btnDeleteReport);
            pnlFilter.Controls.Add(btnSave);
            pnlFilter.Controls.Add(rtbDirections);
            pnlFilter.Controls.Add(btnDisplayHelp);
            pnlFilter.Controls.Add(lblReportName);
            pnlFilter.Controls.Add(btnSearchDatabase);
            pnlFilter.Controls.Add(label3);
            pnlFilter.Controls.Add(picSlider_1);
            pnlFilter.Controls.Add(txtAmount);
            pnlFilter.Controls.Add(btnAddPaidTo);
            pnlFilter.Controls.Add(cmbPaidTo);
            pnlFilter.Controls.Add(btnAddPaymentMethod);
            pnlFilter.Controls.Add(cmbPaymentMethod);
            pnlFilter.Controls.Add(label6);
            pnlFilter.Controls.Add(dateEndDate);
            pnlFilter.Controls.Add(lblDayMonthYearValue);
            pnlFilter.Controls.Add(txtLastRangeValue);
            pnlFilter.Controls.Add(dateStartDate);
            pnlFilter.Controls.Add(picDayMonthYearSlider);
            pnlFilter.Controls.Add(btnAddCategories);
            pnlFilter.Controls.Add(cmbCategories);
            pnlFilter.Controls.Add(lblRangeType);
            pnlFilter.Controls.Add(label14);
            pnlFilter.Controls.Add(picSlider_6);
            pnlFilter.Controls.Add(label13);
            pnlFilter.Controls.Add(label12);
            pnlFilter.Controls.Add(label11);
            pnlFilter.Controls.Add(label10);
            pnlFilter.Controls.Add(label9);
            pnlFilter.Controls.Add(picSlider_5);
            pnlFilter.Controls.Add(picSlider_4);
            pnlFilter.Controls.Add(picSlider_3);
            pnlFilter.Controls.Add(picSlider_2);
            pnlFilter.Controls.Add(label2);
            pnlFilter.Controls.Add(lblFilterHeader);
            pnlFilter.Dock = DockStyle.Bottom;
            pnlFilter.Location = new Point(0, 225);
            pnlFilter.MaximumSize = new Size(843, 350);
            pnlFilter.MinimumSize = new Size(843, 40);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(843, 350);
            pnlFilter.TabIndex = 4;
            pnlFilter.Visible = false;
            // 
            // rtbDirections
            // 
            rtbDirections.BackColor = Color.FromArgb(64, 64, 64);
            rtbDirections.Dock = DockStyle.Right;
            rtbDirections.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDirections.ForeColor = Color.White;
            rtbDirections.Location = new Point(833, 40);
            rtbDirections.MaximumSize = new Size(397, 310);
            rtbDirections.Name = "rtbDirections";
            rtbDirections.Size = new Size(10, 310);
            rtbDirections.TabIndex = 32;
            rtbDirections.Text = resources.GetString("rtbDirections.Text");
            rtbDirections.Visible = false;
            // 
            // lblReportName
            // 
            lblReportName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportName.Location = new Point(245, 40);
            lblReportName.Name = "lblReportName";
            lblReportName.Size = new Size(352, 30);
            lblReportName.TabIndex = 45;
            lblReportName.Text = "Report Name";
            lblReportName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 309);
            label3.Name = "label3";
            label3.Size = new Size(61, 13);
            label3.TabIndex = 39;
            label3.Text = "0.00 = Any";
            // 
            // txtAmount
            // 
            txtAmount.Cursor = Cursors.Hand;
            txtAmount.Enabled = false;
            txtAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(248, 295);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "0.00";
            txtAmount.Size = new Size(80, 29);
            txtAmount.TabIndex = 37;
            txtAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(408, 82);
            label6.Name = "label6";
            label6.Size = new Size(99, 13);
            label6.TabIndex = 30;
            label6.Text = "Day | Month | Year";
            // 
            // lblDayMonthYearValue
            // 
            lblDayMonthYearValue.AutoSize = true;
            lblDayMonthYearValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDayMonthYearValue.Location = new Point(522, 104);
            lblDayMonthYearValue.Name = "lblDayMonthYearValue";
            lblDayMonthYearValue.Size = new Size(41, 20);
            lblDayMonthYearValue.TabIndex = 7;
            lblDayMonthYearValue.Text = "Days";
            lblDayMonthYearValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRangeType
            // 
            lblRangeType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRangeType.Location = new Point(248, 104);
            lblRangeType.Name = "lblRangeType";
            lblRangeType.Size = new Size(58, 21);
            lblRangeType.TabIndex = 25;
            lblRangeType.Text = "All";
            lblRangeType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(88, 104);
            label14.Name = "label14";
            label14.Size = new Size(61, 21);
            label14.TabIndex = 24;
            label14.Text = "Display";
            // 
            // picSlider_6
            // 
            picSlider_6.Cursor = Cursors.Hand;
            picSlider_6.Image = Properties.Resources.Slider_Off3;
            picSlider_6.Location = new Point(155, 293);
            picSlider_6.Name = "picSlider_6";
            picSlider_6.Size = new Size(87, 33);
            picSlider_6.SizeMode = PictureBoxSizeMode.Zoom;
            picSlider_6.TabIndex = 23;
            picSlider_6.TabStop = false;
            picSlider_6.Tag = "1:Amount";
            picSlider_6.Click += Sliders_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(83, 299);
            label13.Name = "label13";
            label13.Size = new Size(66, 21);
            label13.TabIndex = 22;
            label13.Text = "Amount";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(91, 260);
            label12.Name = "label12";
            label12.Size = new Size(58, 21);
            label12.TabIndex = 21;
            label12.Text = "Paid To";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(21, 227);
            label11.Name = "label11";
            label11.Size = new Size(128, 21);
            label11.TabIndex = 20;
            label11.Text = "Payment Method";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(107, 182);
            label10.Name = "label10";
            label10.Size = new Size(42, 21);
            label10.TabIndex = 19;
            label10.Text = "Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(76, 143);
            label9.Name = "label9";
            label9.Size = new Size(73, 21);
            label9.TabIndex = 18;
            label9.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(309, 104);
            label2.Name = "label2";
            label2.Size = new Size(41, 21);
            label2.TabIndex = 5;
            label2.Text = "Last:";
            // 
            // lblFilterHeader
            // 
            lblFilterHeader.BackColor = Color.FromArgb(64, 64, 64);
            lblFilterHeader.Cursor = Cursors.SizeNS;
            lblFilterHeader.Dock = DockStyle.Top;
            lblFilterHeader.Font = new Font("Ink Free", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterHeader.ForeColor = SystemColors.InactiveCaption;
            lblFilterHeader.Location = new Point(0, 0);
            lblFilterHeader.Name = "lblFilterHeader";
            lblFilterHeader.Size = new Size(843, 40);
            lblFilterHeader.TabIndex = 13;
            lblFilterHeader.Text = "Filter";
            lblFilterHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblFilterHeader.Click += lblFilterHeader_Click;
            // 
            // pnlData
            // 
            pnlData.BackColor = SystemColors.ButtonFace;
            pnlData.Controls.Add(dgDataDisplay);
            pnlData.Location = new Point(12, 58);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(144, 96);
            pnlData.TabIndex = 8;
            pnlData.Visible = false;
            // 
            // pnlSaveInfo
            // 
            pnlSaveInfo.BackgroundImage = Properties.Resources.Grid;
            pnlSaveInfo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlSaveInfo.Controls.Add(btnSaveQueryName);
            pnlSaveInfo.Controls.Add(label7);
            pnlSaveInfo.Controls.Add(txtName);
            pnlSaveInfo.Controls.Add(lblColor);
            pnlSaveInfo.Controls.Add(button6);
            pnlSaveInfo.Controls.Add(label4);
            pnlSaveInfo.Location = new Point(222, 293);
            pnlSaveInfo.MaximumSize = new Size(399, 118);
            pnlSaveInfo.Name = "pnlSaveInfo";
            pnlSaveInfo.Size = new Size(399, 118);
            pnlSaveInfo.TabIndex = 15;
            pnlSaveInfo.Tag = "Used to Store Current Custom Report Control Name";
            pnlSaveInfo.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(244, 237, 204);
            label7.Location = new Point(170, 37);
            label7.Name = "label7";
            label7.Size = new Size(53, 21);
            label7.TabIndex = 5;
            label7.Text = "Name";
            // 
            // lblColor
            // 
            lblColor.Location = new Point(30, 59);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(40, 40);
            lblColor.TabIndex = 3;
            lblColor.Text = "Set\r\nColor";
            lblColor.TextAlign = ContentAlignment.MiddleCenter;
            lblColor.Click += lblColor_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Ink Free", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(399, 36);
            label4.TabIndex = 0;
            label4.Text = "Save Search";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpnlCustomReports
            // 
            flpnlCustomReports.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpnlCustomReports.BackColor = Color.Transparent;
            flpnlCustomReports.Location = new Point(12, 170);
            flpnlCustomReports.Name = "flpnlCustomReports";
            flpnlCustomReports.Size = new Size(819, 117);
            flpnlCustomReports.TabIndex = 24;
            flpnlCustomReports.Visible = false;
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Black_Metal;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnCancel;
            ClientSize = new Size(843, 575);
            Controls.Add(pnlFilter);
            Controls.Add(flpnlCustomReports);
            Controls.Add(pnlData);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSaveInfo);
            Controls.Add(btnBudget);
            Controls.Add(btnBills);
            Controls.Add(btnIncome);
            Controls.Add(btnTranactions);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(843, 575);
            Name = "frmReports";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDataDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDayMonthYearSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSlider_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSlider_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSlider_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSlider_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSlider_1).EndInit();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSlider_6).EndInit();
            pnlData.ResumeLayout(false);
            pnlSaveInfo.ResumeLayout(false);
            pnlSaveInfo.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Button btnCancel;
        private ToolTip toolTip1;
        private DataGridView dgDataDisplay;
        private Panel pnlFilter;
        private TextBox txtLastRangeValue;
        private Label label2;
        private PictureBox picDayMonthYearSlider;
        private Label lblDayMonthYearValue;
        private Label lblFilterHeader;
        private Panel pnlData;
        private Label label9;
        private PictureBox picSlider_5;
        private PictureBox picSlider_4;
        private PictureBox picSlider_3;
        private PictureBox picSlider_2;
        private Label label11;
        private Label label10;
        private Label label14;
        private PictureBox picSlider_6;
        private Label label13;
        private Label label12;
        private ComboBox cmbCategories;
        private Label lblRangeType;
        private Button btnAddCategories;
        private DateTimePicker dateStartDate;
        private DateTimePicker dateEndDate;
        private Label label6;
        private RichTextBox rtbDirections;
        private TextBox txtAmount;
        private Button btnAddPaidTo;
        private ComboBox cmbPaidTo;
        private Button btnAddPaymentMethod;
        private ComboBox cmbPaymentMethod;
        private PictureBox picSlider_1;
        private Label label3;
        private Button btnDisplayHelp;
        private PictureBox pictureBox1;
        private Button btnTranactions;
        private Button btnIncome;
        private Button btnBills;
        private Button btnBudget;
        private Panel pnlSaveInfo;
        private Button button6;
        private Label label4;
        private Label label7;
        private Label lblColor;
        private Button btnSearchDatabase;
        private Button btnSave;
        private Label lblReportName;
        private Button btnDeleteReport;
        private Button btnSaveQueryName;
        private Button btnReturn;
        private ColorDialog cdSelectColor;
        private FlowLayoutPanel flpnlCustomReports;
        protected internal TextBox txtName;
    }
}