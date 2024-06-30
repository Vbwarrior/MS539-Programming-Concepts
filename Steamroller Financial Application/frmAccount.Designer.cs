namespace Steamroller_Financial_Application
{
    partial class frmAccount
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
            pnlHeader = new Panel();
            btnCancel = new Button();
            btnReturn = new Button();
            lblHeader = new Label();
            label56 = new Label();
            label52 = new Label();
            trackBarLogoResize = new TrackBar();
            btnSave = new Button();
            txtLast6AccountNumber = new MaskedTextBox();
            label55 = new Label();
            txtPhoneNumber = new MaskedTextBox();
            label54 = new Label();
            label53 = new Label();
            label47 = new Label();
            picLogo = new PictureBox();
            txtStartingBalance = new TextBox();
            txtNickName = new TextBox();
            label36 = new Label();
            txtBankName = new TextBox();
            label31 = new Label();
            picAccountType_Savings = new PictureBox();
            picAccountType_Checking = new PictureBox();
            lblHilighter = new Label();
            label1 = new Label();
            ckbIsPrimary = new CheckBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarLogoResize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAccountType_Savings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAccountType_Checking).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid1;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(btnCancel);
            pnlHeader.Controls.Add(btnReturn);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 55);
            pnlHeader.TabIndex = 49;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImage = Properties.Resources.Cancel1;
            btnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(771, 4);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(25, 25);
            btnCancel.TabIndex = 47;
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
            btnReturn.Location = new Point(2147, 4);
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
            lblHeader.Size = new Size(800, 55);
            lblHeader.TabIndex = 45;
            lblHeader.Text = "New Account";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.BackColor = Color.Transparent;
            label56.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label56.ForeColor = Color.FromArgb(244, 237, 204);
            label56.Location = new Point(709, 352);
            label56.Name = "label56";
            label56.Size = new Size(36, 13);
            label56.TabIndex = 66;
            label56.Text = "Zoom";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.BackColor = Color.Transparent;
            label52.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label52.ForeColor = Color.FromArgb(244, 237, 204);
            label52.Location = new Point(709, 287);
            label52.Name = "label52";
            label52.Size = new Size(43, 13);
            label52.TabIndex = 65;
            label52.Text = "Stretch";
            // 
            // trackBarLogoResize
            // 
            trackBarLogoResize.BackColor = Color.FromArgb(64, 64, 64);
            trackBarLogoResize.LargeChange = 1;
            trackBarLogoResize.Location = new Point(707, 303);
            trackBarLogoResize.Maximum = 1;
            trackBarLogoResize.Name = "trackBarLogoResize";
            trackBarLogoResize.Orientation = Orientation.Vertical;
            trackBarLogoResize.RightToLeft = RightToLeft.No;
            trackBarLogoResize.Size = new Size(45, 50);
            trackBarLogoResize.TabIndex = 64;
            trackBarLogoResize.TickFrequency = 0;
            trackBarLogoResize.TickStyle = TickStyle.None;
            trackBarLogoResize.Scroll += trackBarLogoResize_Scroll;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(95, 93, 156);
            btnSave.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(244, 237, 204);
            btnSave.Location = new Point(133, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(210, 70);
            btnSave.TabIndex = 63;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtLast6AccountNumber
            // 
            txtLast6AccountNumber.BackColor = Color.FromArgb(64, 64, 64);
            txtLast6AccountNumber.BorderStyle = BorderStyle.None;
            txtLast6AccountNumber.Font = new Font("Segoe UI", 12F);
            txtLast6AccountNumber.ForeColor = Color.FromArgb(244, 237, 204);
            txtLast6AccountNumber.Location = new Point(264, 237);
            txtLast6AccountNumber.Mask = "######";
            txtLast6AccountNumber.Name = "txtLast6AccountNumber";
            txtLast6AccountNumber.Size = new Size(139, 22);
            txtLast6AccountNumber.TabIndex = 62;
            txtLast6AccountNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.BackColor = Color.Transparent;
            label55.Font = new Font("Segoe UI", 12F);
            label55.ForeColor = Color.FromArgb(244, 237, 204);
            label55.Location = new Point(261, 213);
            label55.Name = "label55";
            label55.Size = new Size(142, 21);
            label55.TabIndex = 61;
            label55.Text = "Last 6 # of Account";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(64, 64, 64);
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI", 12F);
            txtPhoneNumber.ForeColor = Color.FromArgb(244, 237, 204);
            txtPhoneNumber.Location = new Point(133, 237);
            txtPhoneNumber.Mask = "(999) 000-0000";
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(116, 22);
            txtPhoneNumber.TabIndex = 60;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.BackColor = Color.Transparent;
            label54.Font = new Font("Segoe UI", 12F);
            label54.ForeColor = Color.FromArgb(244, 237, 204);
            label54.Location = new Point(133, 213);
            label54.Name = "label54";
            label54.Size = new Size(116, 21);
            label54.TabIndex = 59;
            label54.Text = "Phone Number";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.BackColor = Color.Transparent;
            label53.Font = new Font("Segoe UI", 12F);
            label53.ForeColor = Color.FromArgb(244, 237, 204);
            label53.Location = new Point(83, 113);
            label53.Name = "label53";
            label53.Size = new Size(87, 21);
            label53.TabIndex = 58;
            label53.Text = "Nick Name";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.BackColor = Color.Transparent;
            label47.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label47.ForeColor = Color.FromArgb(244, 237, 204);
            label47.Location = new Point(521, 404);
            label47.Name = "label47";
            label47.Size = new Size(120, 13);
            label47.TabIndex = 54;
            label47.Text = "Insert Logo (Optional)";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(64, 64, 64);
            picLogo.Location = new Point(457, 252);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(249, 140);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 57;
            picLogo.TabStop = false;
            picLogo.DragDrop += Logo_DragDrop;
            picLogo.DragEnter += Logo_DragEnter;
            // 
            // txtStartingBalance
            // 
            txtStartingBalance.BackColor = Color.FromArgb(64, 64, 64);
            txtStartingBalance.BorderStyle = BorderStyle.None;
            txtStartingBalance.Font = new Font("Segoe UI", 12F);
            txtStartingBalance.ForeColor = Color.FromArgb(244, 237, 204);
            txtStartingBalance.Location = new Point(176, 155);
            txtStartingBalance.Name = "txtStartingBalance";
            txtStartingBalance.PlaceholderText = "Balance";
            txtStartingBalance.Size = new Size(99, 22);
            txtStartingBalance.TabIndex = 55;
            txtStartingBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNickName
            // 
            txtNickName.BackColor = Color.FromArgb(64, 64, 64);
            txtNickName.BorderStyle = BorderStyle.None;
            txtNickName.Font = new Font("Segoe UI", 12F);
            txtNickName.ForeColor = Color.FromArgb(244, 237, 204);
            txtNickName.Location = new Point(176, 113);
            txtNickName.Name = "txtNickName";
            txtNickName.PlaceholderText = "Primary Checking/ Savings";
            txtNickName.Size = new Size(236, 22);
            txtNickName.TabIndex = 53;
            txtNickName.TextAlign = HorizontalAlignment.Center;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = Color.Transparent;
            label36.Font = new Font("Segoe UI", 12F);
            label36.ForeColor = Color.FromArgb(244, 237, 204);
            label36.Location = new Point(49, 155);
            label36.Name = "label36";
            label36.Size = new Size(121, 21);
            label36.TabIndex = 52;
            label36.Text = "Starting Balance";
            // 
            // txtBankName
            // 
            txtBankName.BackColor = Color.FromArgb(64, 64, 64);
            txtBankName.BorderStyle = BorderStyle.None;
            txtBankName.Font = new Font("Segoe UI", 12F);
            txtBankName.ForeColor = Color.FromArgb(244, 237, 204);
            txtBankName.Location = new Point(176, 71);
            txtBankName.Name = "txtBankName";
            txtBankName.PlaceholderText = "Enter Name of Bank";
            txtBankName.Size = new Size(236, 22);
            txtBankName.TabIndex = 51;
            txtBankName.TextAlign = HorizontalAlignment.Center;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Transparent;
            label31.Font = new Font("Segoe UI", 12F);
            label31.ForeColor = Color.FromArgb(244, 237, 204);
            label31.Location = new Point(80, 71);
            label31.Name = "label31";
            label31.Size = new Size(90, 21);
            label31.TabIndex = 50;
            label31.Text = "Bank Name";
            // 
            // picAccountType_Savings
            // 
            picAccountType_Savings.BackColor = Color.Transparent;
            picAccountType_Savings.Image = Properties.Resources.PiggyBank;
            picAccountType_Savings.Location = new Point(474, 85);
            picAccountType_Savings.Name = "picAccountType_Savings";
            picAccountType_Savings.Size = new Size(133, 115);
            picAccountType_Savings.SizeMode = PictureBoxSizeMode.Zoom;
            picAccountType_Savings.TabIndex = 67;
            picAccountType_Savings.TabStop = false;
            picAccountType_Savings.Click += picSavings_Click;
            // 
            // picAccountType_Checking
            // 
            picAccountType_Checking.BackColor = Color.Transparent;
            picAccountType_Checking.Image = Properties.Resources.BlankCheckGreen;
            picAccountType_Checking.Location = new Point(619, 82);
            picAccountType_Checking.Name = "picAccountType_Checking";
            picAccountType_Checking.Size = new Size(133, 115);
            picAccountType_Checking.SizeMode = PictureBoxSizeMode.Zoom;
            picAccountType_Checking.TabIndex = 68;
            picAccountType_Checking.TabStop = false;
            picAccountType_Checking.Click += picChecking_Click;
            // 
            // lblHilighter
            // 
            lblHilighter.BackColor = Color.FromArgb(137, 115, 208);
            lblHilighter.Location = new Point(469, 80);
            lblHilighter.Name = "lblHilighter";
            lblHilighter.Size = new Size(143, 125);
            lblHilighter.TabIndex = 69;
            lblHilighter.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(244, 237, 204);
            label1.Location = new Point(558, 59);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 70;
            label1.Text = "Select Account Type";
            // 
            // ckbIsPrimary
            // 
            ckbIsPrimary.AutoSize = true;
            ckbIsPrimary.BackColor = Color.Transparent;
            ckbIsPrimary.Font = new Font("Segoe UI", 12F);
            ckbIsPrimary.ForeColor = Color.FromArgb(244, 237, 204);
            ckbIsPrimary.Location = new Point(571, 217);
            ckbIsPrimary.Name = "ckbIsPrimary";
            ckbIsPrimary.Size = new Size(126, 25);
            ckbIsPrimary.TabIndex = 71;
            ckbIsPrimary.Text = "Make Primary";
            ckbIsPrimary.UseVisualStyleBackColor = false;
            // 
            // frmAccount
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Black_Metal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ckbIsPrimary);
            Controls.Add(label1);
            Controls.Add(picAccountType_Savings);
            Controls.Add(picAccountType_Checking);
            Controls.Add(lblHilighter);
            Controls.Add(label56);
            Controls.Add(label52);
            Controls.Add(trackBarLogoResize);
            Controls.Add(btnSave);
            Controls.Add(txtLast6AccountNumber);
            Controls.Add(label55);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label54);
            Controls.Add(label53);
            Controls.Add(label47);
            Controls.Add(picLogo);
            Controls.Add(txtStartingBalance);
            Controls.Add(txtNickName);
            Controls.Add(label36);
            Controls.Add(txtBankName);
            Controls.Add(label31);
            Controls.Add(pnlHeader);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAccount";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAccount";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBarLogoResize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAccountType_Savings).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAccountType_Checking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Button btnCancel;
        private Button btnReturn;
        private Label lblHeader;
        private Label label56;
        private Label label52;
        private TrackBar trackBarLogoResize;
        private Button btnSave;
        private MaskedTextBox txtLast6AccountNumber;
        private Label label55;
        private MaskedTextBox txtPhoneNumber;
        private Label label54;
        private Label label53;
        private Label label47;
        private PictureBox picLogo;
        private TextBox txtStartingBalance;
        private TextBox txtNickName;
        private Label label36;
        private TextBox txtBankName;
        private Label label31;
        private PictureBox picAccountType_Savings;
        private PictureBox picAccountType_Checking;
        private Label lblHilighter;
        private Label label1;
        private CheckBox ckbIsPrimary;
    }
}