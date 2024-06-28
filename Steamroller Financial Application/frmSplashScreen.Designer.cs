namespace Steamroller_Financial_Application
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            picEyeball = new PictureBox();
            picDollarSign = new PictureBox();
            SplashTimer = new System.Windows.Forms.Timer(components);
            LoginTimer = new System.Windows.Forms.Timer(components);
            CloseTimer = new System.Windows.Forms.Timer(components);
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            pnlLogin = new Panel();
            btnCancel = new Button();
            lblViolation = new Label();
            btnNewAccount = new Button();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)picEyeball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDollarSign).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // picEyeball
            // 
            picEyeball.BackColor = Color.DimGray;
            picEyeball.Image = Properties.Resources.vectorstock_46727522;
            picEyeball.Location = new Point(787, 427);
            picEyeball.Name = "picEyeball";
            picEyeball.Size = new Size(150, 100);
            picEyeball.SizeMode = PictureBoxSizeMode.StretchImage;
            picEyeball.TabIndex = 1;
            picEyeball.TabStop = false;
            picEyeball.Visible = false;
            // 
            // picDollarSign
            // 
            picDollarSign.BackColor = Color.Transparent;
            picDollarSign.Image = (Image)resources.GetObject("picDollarSign.Image");
            picDollarSign.Location = new Point(862, 477);
            picDollarSign.Name = "picDollarSign";
            picDollarSign.Size = new Size(1, 1);
            picDollarSign.SizeMode = PictureBoxSizeMode.Zoom;
            picDollarSign.TabIndex = 2;
            picDollarSign.TabStop = false;
            // 
            // SplashTimer
            // 
            SplashTimer.Enabled = true;
            SplashTimer.Interval = 50;
            SplashTimer.Tick += SplashTimer_Tick;
            // 
            // LoginTimer
            // 
            LoginTimer.Interval = 30;
            LoginTimer.Tick += LoginTimer_Tick;
            // 
            // CloseTimer
            // 
            CloseTimer.Tick += CloseTimer_Tick;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(31, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(317, 39);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Black;
            txtUserName.ForeColor = Color.Gray;
            txtUserName.Location = new Point(31, 31);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(317, 39);
            txtUserName.TabIndex = 0;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnCancel);
            pnlLogin.Controls.Add(lblViolation);
            pnlLogin.Controls.Add(btnNewAccount);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtUserName);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Location = new Point(680, 363);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(364, 221);
            pnlLogin.TabIndex = 7;
            pnlLogin.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(345, 2);
            btnCancel.MaximumSize = new Size(15, 20);
            btnCancel.MinimumSize = new Size(15, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.Yes;
            btnCancel.Size = new Size(15, 20);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "X";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += btnCancel_MouseEnter;
            btnCancel.MouseLeave += btnCancel_MouseLeave;
            // 
            // lblViolation
            // 
            lblViolation.Dock = DockStyle.Top;
            lblViolation.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblViolation.ForeColor = Color.FromArgb(192, 0, 0);
            lblViolation.Location = new Point(0, 0);
            lblViolation.Name = "lblViolation";
            lblViolation.Size = new Size(364, 17);
            lblViolation.TabIndex = 9;
            lblViolation.Text = "Invalid Username or Password (3) attempts remaining!";
            lblViolation.TextAlign = ContentAlignment.MiddleCenter;
            lblViolation.Visible = false;
            // 
            // btnNewAccount
            // 
            btnNewAccount.FlatStyle = FlatStyle.Flat;
            btnNewAccount.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewAccount.ForeColor = Color.Gray;
            btnNewAccount.Location = new Point(298, 170);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(63, 43);
            btnNewAccount.TabIndex = 3;
            btnNewAccount.Text = "Create\r\nAccount";
            btnNewAccount.UseVisualStyleBackColor = true;
            btnNewAccount.Click += btnNewAccount_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(145, 131);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(74, 44);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Ok";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmSplashScreen
            // 
            AcceptButton = btnLogin;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.vectorstock_31211011;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnCancel;
            ClientSize = new Size(1724, 954);
            Controls.Add(pnlLogin);
            Controls.Add(picDollarSign);
            Controls.Add(picEyeball);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "frmSplashScreen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSplashScreen";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)picEyeball).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDollarSign).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picEyeball;
        private PictureBox picDollarSign;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Timer LoginTimer;
        private System.Windows.Forms.Timer CloseTimer;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Panel pnlLogin;
        private Button btnLogin;
        private Button btnNewAccount;
        private Label lblViolation;
        private Button btnCancel;
    }
}