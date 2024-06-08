namespace Exception_Handling_Demo
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtTextOnly = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnTest = new Button();
            label1 = new Label();
            label2 = new Label();
            txtIntegersOnly = new TextBox();
            label3 = new Label();
            txtBooleaneOnly = new TextBox();
            numOddNumbersOnly = new NumericUpDown();
            label4 = new Label();
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOddNumbersOnly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // txtTextOnly
            // 
            txtTextOnly.Location = new Point(257, 35);
            txtTextOnly.Name = "txtTextOnly";
            txtTextOnly.Size = new Size(100, 23);
            txtTextOnly.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(257, 180);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(100, 44);
            btnTest.TabIndex = 1;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 43);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter Sample Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 69);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter Sample Integer";
            // 
            // txtIntegersOnly
            // 
            txtIntegersOnly.Location = new Point(257, 61);
            txtIntegersOnly.Name = "txtIntegersOnly";
            txtIntegersOnly.Size = new Size(100, 23);
            txtIntegersOnly.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 98);
            label3.Name = "label3";
            label3.Size = new Size(230, 15);
            label3.TabIndex = 6;
            label3.Text = "Enter Sample Booleane as text (true | false)";
            // 
            // txtBooleaneOnly
            // 
            txtBooleaneOnly.Location = new Point(257, 90);
            txtBooleaneOnly.Name = "txtBooleaneOnly";
            txtBooleaneOnly.Size = new Size(100, 23);
            txtBooleaneOnly.TabIndex = 5;
            // 
            // numOddNumbersOnly
            // 
            numOddNumbersOnly.Location = new Point(257, 131);
            numOddNumbersOnly.Name = "numOddNumbersOnly";
            numOddNumbersOnly.Size = new Size(100, 23);
            numOddNumbersOnly.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 139);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 8;
            label4.Text = "Select an Odd number Only";
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 253);
            Controls.Add(label4);
            Controls.Add(numOddNumbersOnly);
            Controls.Add(label3);
            Controls.Add(txtBooleaneOnly);
            Controls.Add(label2);
            Controls.Add(txtIntegersOnly);
            Controls.Add(label1);
            Controls.Add(btnTest);
            Controls.Add(txtTextOnly);
            Name = "frmMain";
            Text = "Error Handling Demo";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOddNumbersOnly).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTextOnly;
        private ErrorProvider errorProvider1;
        private Label label3;
        private TextBox txtBooleaneOnly;
        private Label label2;
        private TextBox txtIntegersOnly;
        private Label label1;
        private Button btnTest;
        private Label label4;
        private NumericUpDown numOddNumbersOnly;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
    }
}
