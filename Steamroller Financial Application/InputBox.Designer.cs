namespace Steamroller_Financial_Application
{
    partial class InputBox
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
            lblMessage = new Label();
            txtUserInput = new TextBox();
            btnAccept = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(lblMessage);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(5, 6, 5, 6);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(554, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Ink Free", 26.2499962F, FontStyle.Bold);
            lblMessage.ForeColor = SystemColors.ActiveCaption;
            lblMessage.Location = new Point(0, 0);
            lblMessage.Margin = new Padding(5, 0, 5, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(554, 100);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "input box";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserInput
            // 
            txtUserInput.BackColor = Color.FromArgb(64, 64, 64);
            txtUserInput.BorderStyle = BorderStyle.None;
            txtUserInput.ForeColor = SystemColors.InactiveCaption;
            txtUserInput.Location = new Point(78, 160);
            txtUserInput.Margin = new Padding(5, 6, 5, 6);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.PlaceholderText = "Budget_1";
            txtUserInput.Size = new Size(398, 28);
            txtUserInput.TabIndex = 1;
            txtUserInput.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Transparent;
            btnAccept.BackgroundImage = Properties.Resources.Thumbs_Up_Left;
            btnAccept.BackgroundImageLayout = ImageLayout.Zoom;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAccept.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Location = new Point(214, 220);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(127, 52);
            btnAccept.TabIndex = 2;
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // InputBox
            // 
            AcceptButton = btnAccept;
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.BlueGrid;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(554, 324);
            ControlBox = false;
            Controls.Add(btnAccept);
            Controls.Add(txtUserInput);
            Controls.Add(pnlHeader);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "InputBox";
            StartPosition = FormStartPosition.CenterParent;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblMessage;
        private TextBox txtUserInput;
        private Button btnAccept;
    }
}