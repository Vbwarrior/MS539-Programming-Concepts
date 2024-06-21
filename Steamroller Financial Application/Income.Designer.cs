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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnlHeader = new Panel();
            button1 = new Button();
            label4 = new Label();
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
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.DepositBlue;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
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
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(226, 244, 253);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(577, 163);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "0.00";
            textBox3.Size = new Size(116, 39);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(226, 244, 253);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(47, 177);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Your Name";
            textBox2.Size = new Size(450, 43);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(226, 244, 253);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(47, 94);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Employers Name";
            textBox1.Size = new Size(250, 32);
            textBox1.TabIndex = 2;
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
            label1.Click += label1_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(button1);
            pnlHeader.Controls.Add(label4);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(812, 55);
            pnlHeader.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Cancel1;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(784, 3);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 4;
            toolTip1.SetToolTip(button1, "Close");
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Ink Free", 26.2499962F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(812, 55);
            label4.TabIndex = 0;
            label4.Text = "Record Income";
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIncome";
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
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Panel pnlHeader;
        private Label label4;
        private Button button1;
        private ToolTip toolTip1;
    }
}