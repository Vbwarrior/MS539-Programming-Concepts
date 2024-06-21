using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Steamroller_Financial_Application
{
    public partial class frmReports : Form
    {
        private SQL_Database data;//Refrence to Database Instance from Main Form
        private string sqlQuery = string.Empty;
        private List<string> categories = new List<string>();
        private List<string> paymentMethod = new List<string>();
        private List<string> paidTo = new List<string>();
        private DateTime startDate;
        private DateTime endDate;
        private bool hasBeenModified = false;
        private string rgbValue = string.Empty;

        public frmReports(SQL_Database db)
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            data = db;
            pnlFilter.Visible = false;

            this.Location = new Point(200, 200);

            CreateInstructions();


        }
        private void btnSearchDatabase_Click(object sender, EventArgs e)
        {

            using (SQLiteDataReader reader = data.FetchData(sqlQuery))
            {

                dgDataDisplay.Rows.Clear();
                dgDataDisplay.Columns.Clear();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dgDataDisplay.Columns.Add(reader.GetName(i), reader.GetName(i));
                }

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = reader.GetValue(i) });
                    }
                    dgDataDisplay.Rows.Add(row);
                }
            }

        }

        private void BuildSelectStatment()
        { //loop through tags and any value that is a 2 add to where list

            StringBuilder sql = new StringBuilder();
            List<string> Conditions = new List<string>();//SQL Where Conditions
            Dictionary<int, string> validationErrors = new Dictionary<int, string>();
            int errorCount = 0;

            sql.Append("SELECT * FROM TRANSACTIONS");

            if (picSlider_1.Tag.ToString().Contains('1'))
            {

                sql.Append(";");
                sqlQuery = sql.ToString();

                return; //Get all transactions
            }
            else//Build Conditions List
            {

                if (txtLastRangeValue.Text != string.Empty || txtLastRangeValue.Text.Length != 0)
                {
                    bool isValid = int.TryParse(txtLastRangeValue.Text, out int value);
                    DateTime lastDate;
                    DateTime today = DateTime.Today;
                    if (isValid)
                    {
                        if (lblDayMonthYearValue.Text == "Days")
                        {
                            lastDate = today.AddDays(-value);
                        }
                        else if (lblDayMonthYearValue.Text == "Months")
                        {
                            lastDate = today.AddMonths(-value);
                        }
                        else
                        {
                            lastDate = today.AddYears(-value);
                        }

                        Conditions.Add($"Date >= '{lastDate}' AND Date <= '{today.ToString("yyyy-MM-dd")}'");

                    }
                    else
                    {
                        validationErrors.Add(errorCount, "The value entered into the \"Last\" input box does not contain an integer value.");
                    }
                }

                if (picSlider_2.Tag.ToString().Contains('2'))
                {
                    if (categories.Count < 1)
                    {
                        errorCount++; validationErrors.Add(errorCount, "Categories is selected but no values were entered, Either unselect Category or select values.");
                    }
                    else
                    {

                        StringBuilder selectedCategories = new StringBuilder();

                        for (int i = 0; i < categories.Count; i++)
                        {
                            selectedCategories.Append($"'{categories[i]}'");

                            // If it's not the last item, add a comma and a space
                            if (i < categories.Count - 1)
                            {
                                selectedCategories.Append(", ");
                            }
                        }

                        Conditions.Add($"Category IN ({selectedCategories.ToString()})");
                    }
                }

                if (picSlider_3.Tag.ToString().Contains('2'))
                {
                    if (dateStartDate.Value > dateEndDate.Value)
                    {
                        // Swap the dates
                        DateTime temp = dateStartDate.Value;
                        dateStartDate.Value = dateEndDate.Value;
                        dateEndDate.Value = temp;
                    }

                    Conditions.Add($"Date>= \'{dateStartDate.Value.ToString("yyyy-MM-dd")}\'  AND Date <= \'{dateEndDate.Value.ToString("yyyy-MM-dd")}\'");
                }

                if (picSlider_4.Tag.ToString().Contains('2'))
                {
                    if (paymentMethod.Count < 1)
                    {
                        errorCount++; validationErrors.Add(errorCount, "Payment Methods is selected but no values were entered, Either unselect Payment Methods or select values.");
                    }
                    else
                    {

                        StringBuilder selectedPaymnetMethods = new StringBuilder();

                        for (int i = 0; i < paymentMethod.Count; i++)
                        {
                            selectedPaymnetMethods.Append($"'{paymentMethod[i]}'");

                            // If it's not the last item, add a comma and a space
                            if (i < paymentMethod.Count - 1)
                            {
                                selectedPaymnetMethods.Append(", ");
                            }
                        }

                        Conditions.Add($"PaymentMethd IN ({selectedPaymnetMethods.ToString()})");
                    }
                }

                if (picSlider_5.Tag.ToString().Contains('2'))
                {
                    if (paidTo.Count < 1)
                    {
                        errorCount++; validationErrors.Add(errorCount, "Paid To is selected but no values were entered, Either unselect Paid To or select values.");
                    }
                    else
                    {

                        StringBuilder selectedPayTo = new StringBuilder();

                        for (int i = 0; i < paidTo.Count; i++)
                        {
                            selectedPayTo.Append($"'{paidTo[i]}'");

                            // If it's not the last item, add a comma and a space
                            if (i < paidTo.Count - 1)
                            {
                                selectedPayTo.Append(", ");
                            }
                        }

                        Conditions.Add($"VendorName IN ({paidTo.ToString()})");
                    }
                }

                if (picSlider_6.Tag.ToString().Contains('2'))
                {
                    if (txtAmount.Text.Length < 1 || txtAmount.Text == string.Empty)
                    {
                        errorCount++; validationErrors.Add(errorCount, "Amount is selected but no value was entered, Either unselect Amount or set a value.");
                    }
                    else
                    {
                        bool isValid = decimal.TryParse(txtAmount.Text, out decimal value);
                        if (isValid)
                        {
                            decimal integralPart = Math.Truncate(value);
                            decimal fractionalPart = value - integralPart;
                            int decimalPlaces = BitConverter.GetBytes(decimal.GetBits(fractionalPart)[3])[2];

                            if (decimalPlaces > 2)
                            {

                                validationErrors.Add(errorCount, "The value entered into the \"Amount\" input box has more than 2 decimal places.");
                            }
                        }
                        else
                        {
                            validationErrors.Add(errorCount, "The value entered into the \"Amount\" input box does not contain an dollar value.");
                        }

                        Conditions.Add($"Amount = \'{value}\'");

                    }

                }
            }

            //Check if any errors found
            if (errorCount > 0)
            {
                StringBuilder errors = new StringBuilder();

                for (int i = 0; i < validationErrors.Count; i++)
                {
                    errors.Append((i + 1).ToString() + " " + validationErrors[i].ToString() + "\n");
                }
                MessageBox.Show(errors.ToString(), "Filter Errors");

            }
            else//Build SQL Query
            {
                sql.Append(" WHERE ");

                for (int i = 0; i < Conditions.Count; i++)
                {
                    sql.Append(Conditions[i].ToString());

                    if (i < Conditions.Count - 1) { sql.Append("AND "); }

                }
                sql.Append(";");
                sqlQuery = sql.ToString();
                hasBeenModified = true;
                btnSave.Enabled = true;
            }
        }

        #region "Completed Code"


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PredefinedReports_Click(object sender, EventArgs e)
        {
            Button report = new Button();
            report = sender as Button;

            string[] reportTag = report.Tag.ToString().Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

            string reportName = reportTag[1];
            int reportKey = int.Parse(reportTag[0]);

            ClearControls();//Reset Controls

            switch (reportName)//Set the tags to the "On" Position before envoking Event to get correct action
            {
                case "Transactions":
                    picSlider_1.Tag = "2:Display";
                    lblReportName.Text = "All Transactions";
                    Sliders_Click(picSlider_1, EventArgs.Empty);
                    break;
                case "Income":
                    picSlider_1.Tag = "2:Display";
                    lblReportName.Text = "All Income";
                    Sliders_Click(picSlider_1, EventArgs.Empty);
                    break;
                case "Budget":
                    picSlider_1.Tag = "2:Display";
                    lblReportName.Text = "All Budget Allocations";
                    Sliders_Click(picSlider_1, EventArgs.Empty);
                    break;
                case "Bill":
                    picSlider_1.Tag = "2:Display";
                    lblReportName.Text = "All Bills";
                    Sliders_Click(picSlider_1, EventArgs.Empty);
                    break;

            }
            pnlFilter.Size = MaximumSize;
            pnlFilter.Visible = true;
            pnlFilter.BringToFront();
        }

        private void Sliders_Click(object sender, EventArgs e)
        {
            PictureBox slider = new PictureBox();
            slider = sender as PictureBox;
            Image sliderImage;
            string[] sliderTag = slider.Tag.ToString().Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

            string sliderName = sliderTag[1];
            int sliderPosition = int.Parse(sliderTag[0]);

            sliderPosition = sliderPosition == 1 ? 2 : 1;//Flipflop Position

            slider.Tag = $"{sliderPosition}:{sliderName}";

            switch (sliderName)
            {
                case "Display"://Disable all filters if Range is set to All
                    sliderImage = sliderPosition == 1 ? Properties.Resources.Slider_Off3 : Properties.Resources.SliderGreen;
                    slider.Image = sliderImage;
                    lblRangeType.Text = sliderPosition == 1 ? "All" : "Range";//Flipflop Range Type
                    if (sliderPosition == 1) { ClearControls(1); txtLastRangeValue.Text = string.Empty; }
                    txtLastRangeValue.Enabled = sliderPosition == 1 ? false : true;
                    picDayMonthYearSlider.Enabled = sliderPosition == 1 ? false : true;
                    picSlider_2.Enabled = sliderPosition == 1 ? false : true;
                    picSlider_3.Enabled = sliderPosition == 1 ? false : true;
                    picSlider_4.Enabled = sliderPosition == 1 ? false : true;
                    picSlider_5.Enabled = sliderPosition == 1 ? false : true;
                    picSlider_6.Enabled = sliderPosition == 1 ? false : true;
                    cmbCategories.Enabled = sliderPosition == 1 ? false : true;
                    dateStartDate.Enabled = sliderPosition == 1 ? false : true;
                    dateEndDate.Enabled = sliderPosition == 1 ? false : true;
                    cmbPaymentMethod.Enabled = sliderPosition == 1 ? false : true;
                    cmbPaidTo.Enabled = sliderPosition == 1 ? false : true;
                    btnAddCategories.Enabled = sliderPosition != 1 ? false : true;
                    btnAddPaymentMethod.Enabled = sliderPosition != 1 ? false : true;
                    btnAddPaidTo.Enabled = sliderPosition != 1 ? false : true;
                    txtAmount.Enabled = sliderPosition != 1 ? false : true;
                    btnSave.Enabled = sliderPosition != 1 ? false : true;//Disable Save button for predefined report
                    break;
                case "Category":
                    sliderImage = sliderPosition == 1 ? Properties.Resources.Slider_Off3 : Properties.Resources.SliderBlue;
                    slider.Image = sliderImage;
                    cmbCategories.Enabled = sliderPosition == 1 ? false : true;
                    btnAddCategories.Enabled = sliderPosition == 1 ? false : true;
                    if (sliderPosition == 1) { cmbCategories.Text = string.Empty; }
                    break;
                case "Date":
                    sliderImage = sliderPosition == 1 ? Properties.Resources.Slider_Off3 : Properties.Resources.SliderYellow2;
                    slider.Image = sliderImage;
                    dateStartDate.Enabled = sliderPosition == 1 ? false : true;
                    dateEndDate.Enabled = sliderPosition == 1 ? false : true;
                    if (sliderPosition == 1) { dateStartDate.ResetText(); dateEndDate.ResetText(); }
                    break;
                case "Payment":
                    sliderImage = sliderPosition == 1 ? Properties.Resources.Slider_Off3 : Properties.Resources.SliderRed2;
                    slider.Image = sliderImage;
                    cmbPaymentMethod.Enabled = sliderPosition == 1 ? false : true;
                    btnAddPaymentMethod.Enabled = sliderPosition != 1 ? false : true;
                    if (sliderPosition == 1) { cmbPaymentMethod.Text = string.Empty; }

                    break;
                case "Pay":
                    sliderImage = sliderPosition == 1 ? Properties.Resources.Slider_Off3 : Properties.Resources.SliderPurple;
                    slider.Image = sliderImage;
                    cmbPaidTo.Enabled = sliderPosition == 1 ? false : true;
                    btnAddPaidTo.Enabled = sliderPosition != 1 ? false : true;
                    if (sliderPosition == 1) { cmbPaidTo.Text = string.Empty; }
                    break;
                case "Amount":
                    sliderImage = sliderPosition == 1 ? Properties.Resources.Slider_Off3 : Properties.Resources.SliderOrange;
                    slider.Image = sliderImage;
                    txtAmount.Enabled = sliderPosition == 1 ? false : true;
                    if (sliderPosition == 1) { txtAmount.Text = string.Empty; }
                    break;



            }





        }

        private void picDayMonthYearSlider_Click(object sender, EventArgs e)
        {

            int.TryParse(picDayMonthYearSlider.Tag.ToString(), out int slidePostion);

            ++slidePostion;

            if (slidePostion > 3)
            {
                slidePostion = 1;
            }
            picDayMonthYearSlider.Tag = slidePostion.ToString();
            if (slidePostion == 1) { picDayMonthYearSlider.Image = Properties.Resources.SliderEmptyLeft; lblDayMonthYearValue.Text = "Days"; }
            else if (slidePostion == 2) { picDayMonthYearSlider.Image = Properties.Resources.SliderMiddleLeft; lblDayMonthYearValue.Text = "Months"; }
            else if (slidePostion == 3) { picDayMonthYearSlider.Image = Properties.Resources.SliderFullRight; lblDayMonthYearValue.Text = "Years"; }

        }

        private void btnDisplayHelp_Click(object sender, EventArgs e)
        {
            rtbDirections.Visible = rtbDirections.Visible == true ? false : true;
            rtbDirections.Size = rtbDirections.MaximumSize;
        }

        private void ClearControls(int mode = 0)
        {
            if (mode == 0)
            {
                picSlider_1.Tag = "2:Display";
                Sliders_Click(picSlider_1, EventArgs.Empty);
            }

            picSlider_2.Tag = "2:Category";
            Sliders_Click(picSlider_2, EventArgs.Empty);
            picSlider_3.Tag = "2:Date";
            Sliders_Click(picSlider_3, EventArgs.Empty);
            picSlider_4.Tag = "2:Payment";
            Sliders_Click(picSlider_4, EventArgs.Empty);
            picSlider_5.Tag = "2:Pay";
            Sliders_Click(picSlider_5, EventArgs.Empty);
            picSlider_6.Tag = "2:Amount";
            Sliders_Click(picSlider_6, EventArgs.Empty);
            picDayMonthYearSlider.Tag = 3;//Reset Control
            picDayMonthYearSlider_Click(picDayMonthYearSlider, EventArgs.Empty);

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Center_Object(pnlSaveInfo, EventArgs.Empty);
            pnlSaveInfo.Visible = true;

        }

        public void Center_Object(object sender, EventArgs e, int xOffset = 0, int yOffset = 0)//Uneversal Centering Method for Panels and additional forms
        {

            if (!(sender is Panel || sender is Form)) { return; }

            Control myControl = sender as Control;


            Form frm = Application.OpenForms["frmReports"];

            if (frm != null && myControl != null)
            {
                int x = (frm.Width - myControl.Width) / 2 + xOffset;
                int y = (frm.Height - myControl.Height) / 2 + yOffset;

                myControl.Location = new Point(x, y);

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlFilter.Size = MinimumSize;

        }

        private void lblFilterHeader_Click(object sender, EventArgs e)
        {
            pnlFilter.Size = pnlFilter.Size == pnlFilter.MaximumSize ? pnlFilter.MinimumSize : pnlFilter.MaximumSize;


        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedItem != null)
            {
                categories.Add(cmbCategories.SelectedItem.ToString());
            }

        }


        private void CreateInstructions()
        {
            StringBuilder instructions = new StringBuilder();

            instructions.AppendLine("Reports Instructions");
            instructions.AppendLine("");
            instructions.AppendLine("Select one of the predefined reports. This will dispaly the default filter criteria. If no changes are required then click the \"Search Database\" button.");
            instructions.AppendLine("If change are required then change \"Display\" to Range. This will unlock the ohter filter controls. Use these controls to target specific data you would like to see.");
            instructions.AppendLine("Run the search by clicking the Search Database button. If the desired results are displayed you can save the search criteria for future use, by clicking the save button on at the top of the filter panel.");
            instructions.AppendLine("In the dialoge box that appears enter the name for your search and select a color value. This will be used to generate a new button for your search.");
            instructions.AppendLine("If at any time the search is no longer needed it can be deleted by selecting it and then clicking the delete button from the filter panel.");
            instructions.AppendLine("If modifications are needed to your saved search. Simple select it, make your modifications and then save the results.");
            instructions.AppendLine("Predefined searches cannot be modified.");

            rtbDirections.Clear();
            rtbDirections.Text = instructions.ToString();

        }
        #endregion


        private void btnSaveQueryName_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtName.Text.Length < 22)
            {
                if(rgbValue.Length > 0 && sqlQuery.Length > 0) 
                {
                    string fileName = rgbValue + ":" + txtName.Text + ":" + sqlQuery;//Color,Name,Query

                    data.ExecuteCommand(data.sqlCommands(sqlCode: "NewSearch", Value1: fileName));

                }
            }
            else
            {
                if (txtName.Text.Length < 1) { MessageBox.Show("Name cannont be empty.")}
                if (txtName.Text.Length > 22) { MessageBox.Show("Name cannont be longer than 22 characters.")}


            }
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            if (cdSelectColor.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = cdSelectColor.Color;
                Color color = cdSelectColor.Color;
                rgbValue = $"RGB({color.R}, {color.G}, {color.B})";
            }
        }
    }
}
