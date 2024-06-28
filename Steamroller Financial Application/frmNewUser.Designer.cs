




namespace Steamroller_Financial_Application
{
    partial class frmNewUser
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
            txtUserName = new TextBox();
            txtPassword1 = new TextBox();
            txtPassword2 = new TextBox();
            btnCreateAccount = new Button();
            btnCancel = new Button();
            pnlHeader = new Panel();
            lblHeaderText = new Label();
            picWarning = new PictureBox();
            toolTip1 = new ToolTip(components);
            picWarning2 = new PictureBox();
            pnlMessage = new Panel();
            lblWelcomeMessage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWarning2).BeginInit();
            pnlMessage.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(40, 37, 37);
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 18F);
            txtUserName.ForeColor = Color.FromArgb(244, 237, 204);
            txtUserName.Location = new Point(53, 75);
            txtUserName.Margin = new Padding(4);
            txtUserName.MaxLength = 200;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(289, 32);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPassword1
            // 
            txtPassword1.BackColor = Color.FromArgb(40, 37, 37);
            txtPassword1.BorderStyle = BorderStyle.None;
            txtPassword1.Font = new Font("Segoe UI", 18F);
            txtPassword1.ForeColor = Color.FromArgb(244, 237, 204);
            txtPassword1.Location = new Point(53, 120);
            txtPassword1.Margin = new Padding(4);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.PasswordChar = '*';
            txtPassword1.PlaceholderText = "Password";
            txtPassword1.Size = new Size(289, 32);
            txtPassword1.TabIndex = 2;
            txtPassword1.TextChanged += txtPassword1_TextChanged;
            // 
            // txtPassword2
            // 
            txtPassword2.BackColor = Color.FromArgb(40, 37, 37);
            txtPassword2.BorderStyle = BorderStyle.None;
            txtPassword2.Font = new Font("Segoe UI", 18F);
            txtPassword2.ForeColor = Color.FromArgb(244, 237, 204);
            txtPassword2.Location = new Point(53, 166);
            txtPassword2.Margin = new Padding(4);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.PlaceholderText = "Re-Enter Password";
            txtPassword2.Size = new Size(289, 32);
            txtPassword2.TabIndex = 3;
            txtPassword2.TextChanged += txtPassword2_TextChanged;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.Transparent;
            btnCreateAccount.BackgroundImage = Properties.Resources.Thumbs_Down_Left;
            btnCreateAccount.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreateAccount.Enabled = false;
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnCreateAccount.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCreateAccount.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Location = new Point(149, 205);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(96, 65);
            btnCreateAccount.TabIndex = 0;
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImage = Properties.Resources.Cancel1;
            btnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(373, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(21, 19);
            btnCancel.TabIndex = 4;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(btnCancel);
            pnlHeader.Controls.Add(lblHeaderText);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(394, 55);
            pnlHeader.TabIndex = 5;
            // 
            // lblHeaderText
            // 
            lblHeaderText.BackColor = Color.Transparent;
            lblHeaderText.Dock = DockStyle.Fill;
            lblHeaderText.Font = new Font("Ink Free", 26.2499962F, FontStyle.Bold);
            lblHeaderText.ForeColor = SystemColors.ActiveCaption;
            lblHeaderText.Location = new Point(0, 0);
            lblHeaderText.Name = "lblHeaderText";
            lblHeaderText.Size = new Size(394, 55);
            lblHeaderText.TabIndex = 0;
            lblHeaderText.Text = "New User";
            lblHeaderText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picWarning
            // 
            picWarning.BackColor = Color.Transparent;
            picWarning.Image = Properties.Resources.Warning;
            picWarning.Location = new Point(21, 147);
            picWarning.Name = "picWarning";
            picWarning.Size = new Size(25, 24);
            picWarning.SizeMode = PictureBoxSizeMode.Zoom;
            picWarning.TabIndex = 6;
            picWarning.TabStop = false;
            toolTip1.SetToolTip(picWarning, "Passwords do not match.");
            picWarning.Visible = false;
            // 
            // picWarning2
            // 
            picWarning2.BackColor = Color.Transparent;
            picWarning2.Image = Properties.Resources.Warning;
            picWarning2.Location = new Point(21, 75);
            picWarning2.Name = "picWarning2";
            picWarning2.Size = new Size(25, 24);
            picWarning2.SizeMode = PictureBoxSizeMode.Zoom;
            picWarning2.TabIndex = 7;
            picWarning2.TabStop = false;
            toolTip1.SetToolTip(picWarning2, "User Name must be greater than 4 charecters");
            picWarning2.Visible = false;
            // 
            // pnlMessage
            // 
            pnlMessage.BackgroundImage = Properties.Resources.Black_Metal;
            pnlMessage.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMessage.Controls.Add(lblWelcomeMessage);
            pnlMessage.Dock = DockStyle.Fill;
            pnlMessage.Location = new Point(0, 55);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Size = new Size(394, 232);
            pnlMessage.TabIndex = 8;
            pnlMessage.Visible = false;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.BackColor = Color.Transparent;
            lblWelcomeMessage.Dock = DockStyle.Fill;
            lblWelcomeMessage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeMessage.ForeColor = Color.FromArgb(244, 237, 204);
            lblWelcomeMessage.Location = new Point(0, 0);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(394, 232);
            lblWelcomeMessage.TabIndex = 0;
            lblWelcomeMessage.Text = "Your new account was created sucessfully.\r\nPlease login with your cedentials";
            lblWelcomeMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Interval = 6000;
            timer1.Tick += timer1_Tick;
            // 
            // frmNewUser
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Black_Metal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(394, 287);
            Controls.Add(pnlMessage);
            Controls.Add(picWarning2);
            Controls.Add(picWarning);
            Controls.Add(pnlHeader);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword1);
            Controls.Add(txtUserName);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmNewUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New User";
            TopMost = true;
            Load += frmNewUser_Load;
            Shown += frmNewUser_Shown;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWarning2).EndInit();
            pnlMessage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword1;
        private TextBox txtPassword2;
        private Button btnCreateAccount;
        private Button btnCancel;
        private Panel pnlHeader;
        private Label lblHeaderText;
        private PictureBox picWarning;
        private ToolTip toolTip1;
        private PictureBox picWarning2;
        private Panel pnlMessage;
        private Label lblWelcomeMessage;
        private System.Windows.Forms.Timer timer1;
    }
}