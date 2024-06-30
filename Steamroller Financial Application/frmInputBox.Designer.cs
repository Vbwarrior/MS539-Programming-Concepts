namespace Steamroller_Financial_Application
{
    partial class frmInputBox
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
            cmbDataSelection = new ComboBox();
            btnCancel = new Button();
            btnCancel_ = new Button();
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
            pnlHeader.Size = new Size(325, 50);
            pnlHeader.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Ink Free", 18F, FontStyle.Bold);
            lblMessage.ForeColor = SystemColors.ActiveCaption;
            lblMessage.Location = new Point(0, 0);
            lblMessage.Margin = new Padding(5, 0, 5, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(325, 50);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "input box";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserInput
            // 
            txtUserInput.BackColor = Color.FromArgb(64, 64, 64);
            txtUserInput.BorderStyle = BorderStyle.None;
            txtUserInput.Font = new Font("Segoe UI", 12F);
            txtUserInput.ForeColor = SystemColors.InactiveCaption;
            txtUserInput.Location = new Point(48, 71);
            txtUserInput.Margin = new Padding(5, 6, 5, 6);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.PlaceholderText = "Budget_1";
            txtUserInput.Size = new Size(228, 22);
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
            btnAccept.Location = new Point(142, 136);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(40, 40);
            btnAccept.TabIndex = 2;
            btnAccept.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // cmbDataSelection
            // 
            cmbDataSelection.Font = new Font("Segoe UI", 12F);
            cmbDataSelection.FormattingEnabled = true;
            cmbDataSelection.Location = new Point(48, 71);
            cmbDataSelection.Name = "cmbDataSelection";
            cmbDataSelection.Size = new Size(228, 29);
            cmbDataSelection.TabIndex = 3;
            cmbDataSelection.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            // 
            // btnCancel_
            // 
            btnCancel_.BackColor = Color.Transparent;
            btnCancel_.BackgroundImage = Properties.Resources.Thumbs_Down_Left;
            btnCancel_.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancel_.FlatAppearance.BorderSize = 0;
            btnCancel_.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancel_.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCancel_.FlatStyle = FlatStyle.Flat;
            btnCancel_.Location = new Point(142, 136);
            btnCancel_.Name = "btnCancel_";
            btnCancel_.Size = new Size(40, 40);
            btnCancel_.TabIndex = 4;
            btnCancel_.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancel_.UseVisualStyleBackColor = false;
            btnCancel_.Visible = false;
            // 
            // frmInputBox
            // 
            AcceptButton = btnAccept;
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.BlueGrid;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(325, 201);
            ControlBox = false;
            Controls.Add(btnCancel_);
            Controls.Add(cmbDataSelection);
            Controls.Add(btnAccept);
            Controls.Add(txtUserInput);
            Controls.Add(pnlHeader);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmInputBox";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmInputBox_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblMessage;
        private TextBox txtUserInput;
        private Button btnAccept;
        private ComboBox cmbDataSelection;
        private Button btnCancel;
        private Button btnCancel_;
    }
}