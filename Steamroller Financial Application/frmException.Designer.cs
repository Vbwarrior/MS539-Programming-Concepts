namespace Steamroller_Financial_Application
{
    partial class frmException
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
            lblMessage = new Label();
            picHeaderImage = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHeaderImage).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(btnCancel);
            pnlHeader.Controls.Add(picHeaderImage);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 305);
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
            btnCancel.Location = new Point(771, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(25, 25);
            btnCancel.TabIndex = 4;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Black;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = SystemColors.ActiveCaption;
            lblMessage.Location = new Point(0, 305);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(800, 145);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "404 - Can't go no more. \r\nYou have reached the end, \r\nclose this message and go back again.";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picHeaderImage
            // 
            picHeaderImage.BackColor = Color.Transparent;
            picHeaderImage.Dock = DockStyle.Fill;
            picHeaderImage.Image = Properties.Resources.Under_Construction;
            picHeaderImage.Location = new Point(0, 0);
            picHeaderImage.Name = "picHeaderImage";
            picHeaderImage.Size = new Size(800, 305);
            picHeaderImage.SizeMode = PictureBoxSizeMode.Zoom;
            picHeaderImage.TabIndex = 5;
            picHeaderImage.TabStop = false;
            // 
            // frmException
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(pnlHeader);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmException";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmException";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHeaderImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblMessage;
        private Button btnCancel;
        private PictureBox picHeaderImage;
    }
}