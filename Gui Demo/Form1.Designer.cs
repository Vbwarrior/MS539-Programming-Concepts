namespace Gui_Demo
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
            panel_Chart = new Panel();
            colorPicker = new ColorDialog();
            label4 = new Label();
            errorProvider = new ErrorProvider(components);
            pnlKey = new Panel();
            btnSwitchChartStyle = new Button();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel_Chart
            // 
            panel_Chart.BorderStyle = BorderStyle.Fixed3D;
            panel_Chart.Location = new Point(122, 67);
            panel_Chart.Margin = new Padding(4);
            panel_Chart.Name = "panel_Chart";
            panel_Chart.Size = new Size(886, 300);
            panel_Chart.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(541, 42);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 8;
            label4.Text = "Chart";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // pnlKey
            // 
            pnlKey.Location = new Point(1072, 67);
            pnlKey.Name = "pnlKey";
            pnlKey.Size = new Size(143, 215);
            pnlKey.TabIndex = 9;
            // 
            // btnSwitchChartStyle
            // 
            btnSwitchChartStyle.Location = new Point(516, 416);
            btnSwitchChartStyle.Name = "btnSwitchChartStyle";
            btnSwitchChartStyle.Size = new Size(99, 29);
            btnSwitchChartStyle.TabIndex = 10;
            btnSwitchChartStyle.Text = "Switch";
            btnSwitchChartStyle.UseVisualStyleBackColor = true;
            btnSwitchChartStyle.Click += btnSwitchChartStyle_Click;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ShowAlways = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1126, 43);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 22;
            label1.Text = "Key";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1292, 502);
            Controls.Add(label1);
            Controls.Add(btnSwitchChartStyle);
            Controls.Add(pnlKey);
            Controls.Add(label4);
            Controls.Add(panel_Chart);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Chart;
        private ColorDialog colorPicker;
        private Label label4;
        private ErrorProvider errorProvider;
        private Button btnSwitchChartStyle;
        private Panel pnlKey;
        private ToolTip toolTip1;
        private Label label1;
    }
}
