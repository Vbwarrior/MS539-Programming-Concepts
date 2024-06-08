
/*
 *  Creating a Line Chart:
 *  create a lable of size 1,1  or 3,3 (Size may need to reflect the line width ) with a color
 *  then draw a line from the controls center to the next to create the graph lines
 */



namespace Gui_Demo
{
    public partial class frmMain : Form
    {

        public struct PiePiece
        {
            public float StartAngle;
            public float SweepAngle;

            public PiePiece(float startAngle, float sweepAngle)
            {
                StartAngle = startAngle;
                SweepAngle = sweepAngle;
            }
        }


        public struct ChartControls
        {
            public string Name;
            public int Value;
            public Color CntrlColor = Color.Empty;

            public ChartControls(string name, int value, Color cColor)
            {
                Name = name;
                Value = value;
                CntrlColor = cColor;
            }
        };

        public enum ChartType
        {
            None = 0,
            BarChart = 1,
            SideBarChart = 2,
            LineChart = 3,
            PlotChart = 4,
            PieChart = 5
        }



        Color SelectedColor;
        List<ChartControls> ChartElements = new System.Collections.Generic.List<ChartControls>();
        Dictionary<ChartControls, PiePiece> pieBounds = new Dictionary<ChartControls, PiePiece>();
        public int SwitchState = 0;
        public ChartType ChartStyle;


        public frmMain()
        {
            InitializeComponent();

            LoadList();
        }

        private void LoadList()
        {
            ChartElements.Add(new ChartControls("Entertainment", 50, Color.Blue));
            ChartElements.Add(new ChartControls("Housing", 500, Color.Red));
            ChartElements.Add(new ChartControls("Grocieries", 600, Color.Orange));
            ChartElements.Add(new ChartControls("Utilities", 350, Color.Green));
            ChartElements.Add(new ChartControls("Fuel", 500, Color.Teal));
            ChartElements.Add(new ChartControls("Auto Maintenance", 150, Color.Aqua));
            ChartElements.Add(new ChartControls("Shopping", 250, Color.LightBlue));
            ChartElements.Add(new ChartControls("Streaming Services", 50, Color.DarkGray));
            ChartElements.Add(new ChartControls("Pets", 75, Color.DarkCyan));
            ChartElements.Add(new ChartControls("Eating Out", 450, Color.DarkMagenta));

        }

        private void ClearControls()
        {
            List<Control> myControls = new List<Control>();


            foreach (Control control in this.Controls)
            {
                if (control is Label && control.Name.StartsWith("lblChart"))
                {
                    myControls.Add(control);
                }
            }

            for (int i = 0; i < myControls.Count; i++)
            {
                Control control = myControls[i];
                if (control.Name.StartsWith("lblChartData_X_Axis_") && ChartStyle == ChartType.BarChart)
                {
                    control.Dispose();
                }
                else if (control.Name.StartsWith("lblChartData_Y_Axis_") && ChartStyle == ChartType.SideBarChart)
                {
                    control.Dispose();
                }
                else if ((control.Name.StartsWith("lblChartData_Y_Axis_") || control.Name.StartsWith("lblChartData_X_Axis_")) && ChartStyle == ChartType.PieChart)
                {
                    control.Dispose();
                }
            }













        }

        private void btnSwitchChartStyle_Click(object sender, EventArgs e)
        {
            SwitchState += 1;

            if (SwitchState == 1)
            {
                panel_Chart.Controls.Clear();
                ChartStyle = ChartType.PieChart;
                CreatePieChart(panel_Chart, 0);
            }
            else if (SwitchState == 2)
            {
                panel_Chart.Controls.Clear();

                ChartStyle = ChartType.BarChart;
                CreateBarChart();
                DisplayChartLines();
            }
            else if (SwitchState == 3)
            {
                panel_Chart.Controls.Clear();
                ChartStyle = ChartType.SideBarChart;
                CreateSideBarChart();
                DisplayChartLines();
            }
            else
            {
                SwitchState = 0;
                panel_Chart.Controls.Clear();
                ChartStyle = ChartType.None;
            }

        }




        #region "Pie Chart"

        public void CreatePieChart(Panel parent, int rotationOffset = 0)
        {

            //foreach (Control control in panel_Chart.Controls)
            //{
            //    control.Dispose();
            //}

            ClearControls();

            Panel pnlPieChart = new Panel();
            pnlPieChart.BorderStyle = BorderStyle.None;
            pnlPieChart.Width = parent.Height - 20;
            pnlPieChart.Height = parent.Height - 20;
            pnlPieChart.Left = (parent.Width - pnlPieChart.Width) / 2;
            pnlPieChart.Top = (parent.Height - pnlPieChart.Height) / 2;

            parent.Controls.Add(pnlPieChart);

            pnlPieChart.Paint += pnlPieChart_Paint;// event handler

            pnlKey.Controls.Clear();
            pnlKey.Height = ChartElements.Count * 30 + 2;

            for (int i = ChartElements.Count - 1; i >= 0; i--)
            {
                Label xLabel = new Label();

                xLabel.Text = ChartElements[i].Name;
                xLabel.TextAlign = ContentAlignment.MiddleCenter;
                xLabel.Height = 30;
                xLabel.BackColor = ChartElements[i].CntrlColor;
                xLabel.Dock = DockStyle.Top;

                pnlKey.Controls.Add(xLabel);

                xLabel.MouseEnter += XLabel_MouseEnter;
                xLabel.MouseLeave += XLabel_MouseLeave;

            }

        }

        private void pnlPieChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, ((Panel)sender).Width, ((Panel)sender).Height);

            int total = 0;
            foreach (ChartControls data in ChartElements)
            {
                total += data.Value;
            }

            float startAngle = 0;
            foreach (ChartControls data in ChartElements)
            {
                float percentage = (float)data.Value / total;
                float sweepAngle = percentage * 360;

                g.FillPie(new SolidBrush(data.CntrlColor), rect, startAngle, sweepAngle);
                g.DrawPie(Pens.Black, rect, startAngle, sweepAngle);

                pieBounds[data] = new PiePiece(startAngle, sweepAngle);

                startAngle += sweepAngle;
            }
        }

        public bool AddChartData(string name, int value, Color cColor)
        {
            foreach (ChartControls data in ChartElements)
            {
                if (data.CntrlColor == cColor)
                {
                    return false;
                }
            }

            ChartElements.Add(new ChartControls(name, value, cColor));

            return true;
        }

        #endregion

        #region "Bar Charts"

        #region "Bar Chart"
        private void CreateBarChart()
        {
            ChartStyle = ChartType.BarChart;
            Label xLabel;
            int maxValue = ChartElements.Max(element => element.Value);
            int Width = panel_Chart.Width;
            int Height = panel_Chart.Height;
            int Spacing = Width / (ChartElements.Count * 2);
            int maxLabelHeight = Height - 10;
            int totalWidth = ChartElements.Count * Spacing;
            int chartMaxValue = GetChartMaxValue(ChartElements);


            ClearControls();
            //foreach (Control control in panel_Chart.Controls)
            //{
            //    if (control is Label && control.Name.StartsWith("lblChartLine_")) { continue; }
            //    else { control.Dispose(); }
            //}

            pnlKey.Controls.Clear();
            pnlKey.Height = ChartElements.Count * 30 + 2;

            for (int i = 0; i < ChartElements.Count; i++)
            {
                xLabel = new Label();
                xLabel.Width = Spacing;
                xLabel.Name = ChartElements[i].Name;
                xLabel.Height = (int)((double)ChartElements[i].Value / chartMaxValue * maxLabelHeight);
                //xLabel.Height = (int)((double)ChartElements[i].Value / maxValue * Height);
                xLabel.Text = "";
                xLabel.BackColor = ChartElements[i].CntrlColor;

                xLabel.Location = new Point(Spacing * i * 2, Height - xLabel.Height);
                string ttLabel = $"{ChartElements[i].Name} = ${ChartElements[i].Value}";
                toolTip1.SetToolTip(xLabel, ttLabel);
                panel_Chart.Controls.Add(xLabel);
                xLabel.BringToFront();
            }
            for (int i = ChartElements.Count - 1; i >= 0; i--)
            {
                xLabel = new Label();

                xLabel.Text = ChartElements[i].Name;
                xLabel.TextAlign = ContentAlignment.MiddleCenter;
                xLabel.Height = 30;
                xLabel.BackColor = ChartElements[i].CntrlColor;
                xLabel.Dock = DockStyle.Top;

                pnlKey.Controls.Add(xLabel);

                xLabel.MouseEnter += XLabel_MouseEnter;
                xLabel.MouseLeave += XLabel_MouseLeave;

            }



        }

        #endregion

        #region "Side Bar Chart"
        private void CreateSideBarChart()
        {
            ChartStyle = ChartType.SideBarChart;
            Label xLabel;
            int maxValue = ChartElements.Max(element => element.Value);
            int Width = panel_Chart.Width;
            int Height = panel_Chart.Height;
            int Spacing = Height / (ChartElements.Count * 2);
            int maxLabelWidth = Width - 10;
            int totalHeight = ChartElements.Count * Spacing;
            int chartMaxValue = GetChartMaxValue(ChartElements);

            ClearControls();

            pnlKey.Controls.Clear();
            pnlKey.Height = ChartElements.Count * 30 + 2;

            for (int i = 0; i < ChartElements.Count; i++)
            {
                xLabel = new Label();
                xLabel.Height = Spacing;
                xLabel.Name = ChartElements[i].Name;
                xLabel.Width = (int)((double)ChartElements[i].Value / chartMaxValue * maxLabelWidth);
                xLabel.Text = "";
                xLabel.BackColor = ChartElements[i].CntrlColor;

                xLabel.Location = new Point(0, Spacing * i * 2);
                string ttLabel = $"{ChartElements[i].Name} = ${ChartElements[i].Value}";
                toolTip1.SetToolTip(xLabel, ttLabel);
                panel_Chart.Controls.Add(xLabel);
                xLabel.BringToFront();
            }
            for (int i = ChartElements.Count - 1; i >= 0; i--)
            {
                xLabel = new Label();

                xLabel.Text = ChartElements[i].Name;
                xLabel.TextAlign = ContentAlignment.MiddleCenter;
                xLabel.Height = 30;
                xLabel.BackColor = ChartElements[i].CntrlColor;
                xLabel.Dock = DockStyle.Top;

                pnlKey.Controls.Add(xLabel);

                xLabel.MouseEnter += XLabel_MouseEnter;
                xLabel.MouseLeave += XLabel_MouseLeave;

            }
        }

        #endregion


        private void XLabel_MouseLeave(object? sender, EventArgs e)
        {
            Label chartLabel = new Label();
            Control[] matches = panel_Chart.Controls.Find("HighlightLabel", true);
            if (matches.Length > 0)
            {
                chartLabel = matches[0] as Label;
                toolTip1.Hide(chartLabel);
                chartLabel.Dispose();
            }
        }
        private void XLabel_MouseEnter(object? sender, EventArgs e)
        {
            if (sender == null) { return; }
            Label? xLabel = sender as Label;
            Label chartLabel = new Label();
            Control[] matches = panel_Chart.Controls.Find(xLabel.Text, true);
            if (matches.Length > 0)
            {
                chartLabel = matches[0] as Label;
            }


            Label HighLightLabel = new Label();
            HighLightLabel.Width = chartLabel.Width + 10;
            HighLightLabel.Name = "HighlightLabel";
            HighLightLabel.Height = chartLabel.Height + 10;
            HighLightLabel.Text = string.Empty;
            HighLightLabel.BackColor = Color.Yellow;
            HighLightLabel.Location = new Point(chartLabel.Left - 5, chartLabel.Top - 10);

            if (ChartStyle == ChartType.BarChart)
            {
                HighLightLabel.Location = new Point(chartLabel.Left - 5, chartLabel.Top - 10);
            }
            else if (ChartStyle == ChartType.SideBarChart)
            {

                HighLightLabel.Location = new Point(chartLabel.Left, chartLabel.Top - 5);

            }
            panel_Chart.Controls.Add(HighLightLabel);
            HighLightLabel.SendToBack();



            toolTip1.Show(toolTip1.GetToolTip(chartLabel), chartLabel);

        }
        private int GetChartMaxValue(List<ChartControls> chartElements)
        {
            int maxValue = chartElements.Max(element => element.Value);
            int roundedMaxValue = (int)Math.Ceiling((double)maxValue / 1000) * 1000;
            return roundedMaxValue;
        }
        private void DisplayChartLines()
        {
            int chartMaxValue = GetChartMaxValue(ChartElements);
            int chartIncrementValue = (int)Math.Round((double)chartMaxValue / 10);
            int Step;// used to place Labels for Data points in Side Bar Graph
            Point BasePoint = new Point(panel_Chart.Left, panel_Chart.Bottom + 11);
            Label xLabel = new Label();

            if (ChartStyle == ChartType.BarChart)
            {
                //Add Lables for Data Point Lines
                for (int i = 0; i <= 10; i++)
                {
                    Step = panel_Chart.Height / 10;
                    xLabel = new Label();
                    xLabel.Text = (chartIncrementValue * i).ToString();//Add Value to Increment 
                    xLabel.TextAlign = ContentAlignment.MiddleRight;
                    xLabel.Visible = true;
                    xLabel.Size = new Size(103, 21);
                    xLabel.ForeColor = Color.Black;
                    xLabel.Location = new Point(panel_Chart.Left - 114, (BasePoint.Y - 21) - (i * Step));
                    xLabel.Name = "lblChartData_Y_Axis_" + i;
                    xLabel.Font = new Font("Segoe UI", 8.25f);

                    this.Controls.Add(xLabel);
                    xLabel.BringToFront();
                }


                for (int i = 1; i <= panel_Chart.Height - 30; i++)
                {
                    xLabel = new Label();
                    xLabel.Text = string.Empty;
                    xLabel.Visible = true;
                    xLabel.Size = new Size(panel_Chart.Width, 1);
                    xLabel.BackColor = Color.Black;
                    xLabel.Location = new Point(0, i * 30);

                    panel_Chart.Controls.Add(xLabel);
                }

            }


            else if (ChartStyle == ChartType.SideBarChart)
            {
                Step = panel_Chart.Width / 10;

                //Add Lables for Data Point Lines
                for (int i = 0; i <= 10; i++)
                {
                    xLabel = new Label();
                    xLabel.Text = (chartIncrementValue * i).ToString();//Add Value to Increment 
                    xLabel.Visible = true;
                    xLabel.Size = new Size(103, 21);
                    xLabel.ForeColor = Color.Black;
                    xLabel.Location = new Point(BasePoint.X + i * Step, BasePoint.Y);
                    xLabel.Name = "lblChartData_X_Axis_" + i;
                    xLabel.Font = new Font("Segoe UI", 8.25f);

                    this.Controls.Add(xLabel);
                    xLabel.BringToFront();
                }

                //Add Data Lines
                for (int i = 1; i <= 9; i++)
                {
                    xLabel = new Label();
                    xLabel.Text = string.Empty;
                    xLabel.Visible = true;
                    xLabel.Size = new Size(1, panel_Chart.Height);
                    xLabel.BackColor = Color.Black;
                    xLabel.Location = new Point(i * Step, 0);

                    panel_Chart.Controls.Add(xLabel);
                }

            }


        }//End Display Chart Lines


        #endregion




    }
}

