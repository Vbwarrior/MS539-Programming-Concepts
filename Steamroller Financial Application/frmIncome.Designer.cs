namespace Steamroller_Financial_Application
{
    partial class frmIncome
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
            picSavings = new PictureBox();
            picChecking = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            txtAmount = new TextBox();
            txtPaidTo = new TextBox();
            txtNameOfEmployer = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnlHeader = new Panel();
            btnCancel = new Button();
            lblHeader = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picSavings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChecking).BeginInit();
            panel1.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // picSavings
            // 
            picSavings.BackColor = Color.Transparent;
            picSavings.Image = Properties.Resources.Bank_and_Pig;
            picSavings.Location = new Point(169, 383);
            picSavings.Name = "picSavings";
            picSavings.Size = new Size(129, 123);
            picSavings.SizeMode = PictureBoxSizeMode.Zoom;
            picSavings.TabIndex = 0;
            picSavings.TabStop = false;
            toolTip1.SetToolTip(picSavings, "Primary Savings");
            picSavings.Click += picSavings_Click;
            // 
            // picChecking
            // 
            picChecking.BackColor = Color.Transparent;
            picChecking.Image = Properties.Resources.BlankCheckGreen;
            picChecking.Location = new Point(439, 398);
            picChecking.Name = "picChecking";
            picChecking.Size = new Size(204, 93);
            picChecking.SizeMode = PictureBoxSizeMode.StretchImage;
            picChecking.TabIndex = 1;
            picChecking.TabStop = false;
            toolTip1.SetToolTip(picChecking, "Primary Checking");
            picChecking.Click += picChecking_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.DepositBlue;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(txtPaidTo);
            panel1.Controls.Add(txtNameOfEmployer);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(26, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 303);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Britannic Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(461, 17);
            label3.Name = "label3";
            label3.Size = new Size(274, 71);
            label3.TabIndex = 5;
            label3.Text = "DEPOSIT";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.FromArgb(226, 244, 253);
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(577, 163);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "0.00";
            txtAmount.Size = new Size(116, 39);
            txtAmount.TabIndex = 4;
            txtAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPaidTo
            // 
            txtPaidTo.BackColor = Color.FromArgb(226, 244, 253);
            txtPaidTo.BorderStyle = BorderStyle.None;
            txtPaidTo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaidTo.Location = new Point(47, 177);
            txtPaidTo.Name = "txtPaidTo";
            txtPaidTo.PlaceholderText = "Your Name";
            txtPaidTo.Size = new Size(450, 43);
            txtPaidTo.TabIndex = 3;
            // 
            // txtNameOfEmployer
            // 
            txtNameOfEmployer.BackColor = Color.FromArgb(226, 244, 253);
            txtNameOfEmployer.BorderStyle = BorderStyle.None;
            txtNameOfEmployer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameOfEmployer.Location = new Point(47, 94);
            txtNameOfEmployer.Name = "txtNameOfEmployer";
            txtNameOfEmployer.PlaceholderText = "Employers Name";
            txtNameOfEmployer.Size = new Size(250, 32);
            txtNameOfEmployer.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(41, 144);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 1;
            label2.Text = "To:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(42, 73);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(btnCancel);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(812, 55);
            pnlHeader.TabIndex = 3;
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
            btnCancel.TabIndex = 4;
            toolTip1.SetToolTip(btnCancel, "Close");
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Record Income";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmIncome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Black_Metal;
            ClientSize = new Size(812, 526);
            Controls.Add(pnlHeader);
            Controls.Add(panel1);
            Controls.Add(picChecking);
            Controls.Add(picSavings);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIncome";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Income";
            ((System.ComponentModel.ISupportInitialize)picSavings).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChecking).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picSavings;
        private PictureBox picChecking;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtNameOfEmployer;
        private TextBox txtAmount;
        private TextBox txtPaidTo;
        private Label label3;
        private Panel pnlHeader;
        private Label lblHeader;
        private Button btnCancel;
        private ToolTip toolTip1;
    }
}