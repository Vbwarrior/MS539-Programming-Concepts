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
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            pnlLogin = new Panel();
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
            txtPassword.Location = new Point(147, 75);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(317, 39);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 4;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(23, 82);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Black;
            txtUserName.ForeColor = Color.Gray;
            txtUserName.Location = new Point(147, 17);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(317, 39);
            txtUserName.TabIndex = 5;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnNewAccount);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtUserName);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Location = new Point(603, 374);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(518, 210);
            pnlLogin.TabIndex = 7;
            pnlLogin.Visible = false;
            // 
            // btnNewAccount
            // 
            btnNewAccount.FlatStyle = FlatStyle.Flat;
            btnNewAccount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewAccount.ForeColor = Color.Gray;
            btnNewAccount.Location = new Point(5, 158);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(86, 44);
            btnNewAccount.TabIndex = 8;
            btnNewAccount.Text = "Create\r\nAccount";
            btnNewAccount.UseVisualStyleBackColor = true;
            btnNewAccount.Click += btnNewAccount_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(268, 142);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(74, 44);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Ok";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmSplashScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.vectorstock_31211011;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1724, 954);
            Controls.Add(pnlLogin);
            Controls.Add(picDollarSign);
            Controls.Add(picEyeball);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "frmSplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplashScreen";
            Click += frmSplashScreen_Click;
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
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private Panel pnlLogin;
        private Button btnLogin;
        private Button btnNewAccount;
    }
}