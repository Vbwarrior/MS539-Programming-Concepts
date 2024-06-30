using Microsoft.VisualBasic.Logging;
using SQLiteClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Steamroller_Financial_Application
{
    public partial class frmBill : Form
    {
        // private SQLiteCRUD data;//Refrence to Database Instance from Main Form
        private SQLiteCRUD data;
        private GlobalDataAndFunctions globals;
        private Point selectedPaymentHilighterLocation;
        private bool enableEvents = true;
        private string lockedControlTag = string.Empty;
        private string billType;
        private string preferedPaymentMethod = string.Empty;
        private string DueDay = "1";
        private Point CreditCardLogo = new Point();
        private string Logo;

        private Dictionary<string, string> Bills = new Dictionary<string, string>();
        private Dictionary<string, string> HouseHold = new Dictionary<string, string>();
        private Dictionary<string, string> CreditCard = new Dictionary<string, string>();
        private Dictionary<string, string> Loans = new Dictionary<string, string>();
        private Dictionary<string, string> Category = new Dictionary<string, string>();
        private Dictionary<string, string> CategoryItems = new Dictionary<string, string>();
        private Dictionary<string, string> conditions = new Dictionary<string, string>();


        public frmBill(SQLiteCRUD db, GlobalDataAndFunctions globalData, string HeaderText)
        {
            InitializeComponent();

            picLogo.KeyDown += new KeyEventHandler(picLogo_KeyDown);
            picLogo.PreviewKeyDown += new PreviewKeyDownEventHandler(picLogo_PreviewKeyDown);

            data = db;
            globals = globalData;
            lblHeader.Text = HeaderText;
        }
        private void frmBill_Load(object sender, EventArgs e)
        {

            SetupDictionaries();
            List<Dictionary<string, string>> TableData = new List<Dictionary<string, string>>();
            List<string> ColumnNames = new List<string>();

            pnlHouseHold.AllowDrop = true;
            picLogo.AllowDrop = true;
            TableData.Clear();
            TableData = data.SelectTable("Categories");

            foreach (Dictionary<string, string> row in TableData)
            {
                Category.Add(row["CategoryName"], row["CategoryID"]);
            }

            foreach (KeyValuePair<string, string> row in Category)
            {
                cmbBudgetCategory.Items.Add(row.Key);

            }


            TableData.Clear();
            ColumnNames.Add("CategoryID");
            ColumnNames.Add("SubCategoryName");

            TableData = data.SelectTable("CategorySubGroups", ColumnNames);

            foreach (Dictionary<string, string> row in TableData)
            {
                string key = row["SubCategoryName"];
                string value = row["CategoryID"];

                // Append ":" and the value to the key for all items due to posible duplicate Sub Category names
                key = key + ":" + value;

                CategoryItems.Add(key, value);
            }




            // CategoryItems

        }

        private void SetupDictionaries()
        {

            Loans.Add("BillID", null);
            Loans.Add("APR", null);
            Loans.Add("Balance", null);
            Loans.Add("TermMonths", null);
            Loans.Add("StartDate", null);
            Loans.Add("EndDate", null);
            Loans.Add("LogoFilePath", null);
            Loans.Add("IsActive", "1");


            
            CreditCard.Add("BillID", null);
            CreditCard.Add("APR", null);
            CreditCard.Add("Balance", null);
            CreditCard.Add("LogoFilePath", null);
            CreditCard.Add("IsActive", "1");

          
            HouseHold.Add("BillID", null);
            HouseHold.Add("LogoFilePath", null);
            HouseHold.Add("IsActive", "1");


            Bills.Add("CategoryID", null);
            Bills.Add("SubGroupID", null);
            Bills.Add("CompanyName", null);
            Bills.Add("DisplayName", null);
            Bills.Add("PaymentMethodID", null);
            Bills.Add("DueDay", null);
            Bills.Add("AccountNumber", null);
            Bills.Add("Address", null);
            Bills.Add("State", null);
            Bills.Add("ZipCode", null);
            Bills.Add("PhoneNumber", null);
            Bills.Add("Website", null);
            Bills.Add("Recurring", null);
            Bills.Add("IsPrimaryVendor", null);
            Bills.Add("AutoPay", null);


        }


        #region "Completed"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calDatePicker_DateSelected(object sender, DateRangeEventArgs e)
        {
            btnSelectedDay.Text = calDatePicker.SelectionRange.Start.Day.ToString();
            btnSelectedDay.Visible = true;
            btnSelectedDay.BringToFront();
            calDatePicker.Visible = false;
            lblPnlNewPayee_SelectedDay.Text = "Selected Due Day";
            DueDay = btnSelectedDay.Text;

        }

        private void btnSelectedDay_Click(object sender, EventArgs e)
        {
            btnSelectedDay.Visible = false;
            btnSelectedDay.SendToBack();
            calDatePicker.Visible = true;
            calDatePicker.BringToFront();
            lblPnlNewPayee_SelectedDay.Text = "Select Due By Date";
        }

        private void AccountTypeDecisionButtons_Click(object sender, EventArgs e)
        {
            if (!(sender is Button)) { return; }

            Button selection = (Button)sender;




            if (selection.Name == "btnHouseHold" || selection.Name == "btnLoan" || selection.Name == "btnCreditCard")
            {
                billType = selection.Text;//sets Global for BillType to be used when uploading Data
                btnHouseHold.BackColor = Color.FromKnownColor(KnownColor.Control);
                btnHouseHold.ForeColor = Color.Black;
                btnLoan.BackColor = Color.FromKnownColor(KnownColor.Control);
                btnLoan.ForeColor = Color.Black;
                btnCreditCard.BackColor = Color.FromKnownColor(KnownColor.Control);
                btnCreditCard.ForeColor = Color.Black;
                lblAccountInformation.Enabled = true;

                enableEvents = true;//Release highlighter if Type changes

                selection.BackColor = Color.RoyalBlue;
                selection.ForeColor = Color.White;

            }
            pnlHouseHold.Visible = false;
            pnlLoan.Visible = false;
            pnlCreditCard.Visible = false;
            pnlAccountInformation.Visible = true;
            pnlAccountInformation.Size = new Size(0, 25);
            pnlAccountInformation.Location = new Point(0, 753);



            if (selection.Name == "btnHouseHold")
            {
                pnlHouseHold.Visible = true;
                pnlHouseHold.Location = new Point(0, 360);
                pnlHouseHold.Height = 400;
                pnlHouseHold.BringToFront();
               
            }
            else if (selection.Name == "btnLoan")
            {
                pnlLoan.Visible = true;
                pnlLoan.Location = new Point(0, 360);
                pnlLoan.Height = 400;
                pnlLoan.BringToFront();
                Bills["CategoryID"] = "16";
            }
            else if (selection.Name == "btnCreditCard")
            {
                Bills.Add("CategoryID", "17");
                Bills.Add("SubGroupID", "97");
                pnlCreditCard.Visible = true;
                pnlCreditCard.Location = new Point(0, 360);
                pnlCreditCard.Height = 400;
                pnlCreditCard.BringToFront();
            }

        }

        private void PreferedPaymentMethod_Click(object sender, EventArgs e)
        {

            PictureBox pic = new PictureBox();
            pic = sender as PictureBox;
            string[] xTagParts = pic.Tag.ToString().Split(':');
            string xTag = xTagParts[0];

            preferedPaymentMethod = xTagParts[1];

            Point xControl = pic.Location;

            switch (xTag)
            {
                case "House Hold":
                    lblPaymentMethodHighligter.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter.Visible = true;

                    lblPaymentMethodHighligter.BackColor = Color.DodgerBlue;
                    selectedPaymentHilighterLocation = new Point(0, 0);

                    break;
                case "Credit Card":
                    lblPaymentMethodHighligter2.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter2.Visible = true;


                    lblPaymentMethodHighligter2.BackColor = Color.DodgerBlue;
                    selectedPaymentHilighterLocation = new Point(0, 0);

                    break;
                case "Loan":
                    lblPaymentMethodHighligter3.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter3.Visible = true;
                    lblPaymentMethodHighligter3.BackColor = Color.Fuchsia;

                    lblPaymentMethodHighligter3.BackColor = Color.DodgerBlue;
                    selectedPaymentHilighterLocation = new Point(0, 0);



                    break;
            }




        }
        private void CreditCardImageSelection(int displayNumber)
        {

            // Define the row and column values for each logo Grid = 4rows & 13Col
            int Row = displayNumber / 13;
            int Col = displayNumber % 13;



            Size sectionSize = new Size(501, 348); //Size of each logo on Vector Image
            System.Drawing.Image image = Properties.Resources.CreditCardLogos;//Logos Purchased from Vector Stock
            const int RowSpacing = 484;//Spacing Between Images 136 plus Image Height 348
            const int ColSpacing = 718;//Spacing Between Images 217 plus Width of Image 501

            Point sectionStartPoint = new Point(0, 0);

            sectionStartPoint = new Point(ColSpacing * Col, RowSpacing * Row); // Replace with the actual values

            Bitmap section = new Bitmap(sectionSize.Width, sectionSize.Height);//Creates a place holder with correct size for image

            using (Graphics g = Graphics.FromImage(section))
            {
                g.DrawImage(image, new Rectangle(Point.Empty, sectionSize), new Rectangle(sectionStartPoint, sectionSize), GraphicsUnit.Pixel);

            }

            if (Row == 4) { picImageSelectorSelectedImage.Image = Properties.Resources.CreditCardLogos; btnUseSelectedImage.Tag = "-1"; }//Reset Control
            else { picImageSelectorSelectedImage.Image = section; CreditCardLogo = sectionStartPoint; }

        }//Retrive Section of Image

        private void ImageSelectorControls_Click(object sender, EventArgs e)//Controls for Image Selector Pnl
        {
            int displayNumber = 0;
            Button xButton = new Button();

            xButton = sender as Button;

            if (xButton.Name == "btnImageSelectorScrollLeft")
            {
                int.TryParse(btnUseSelectedImage.Tag.ToString(), out displayNumber);
                displayNumber--;
                if (displayNumber == -1)
                {
                    picImageSelectorSelectedImage.Image = Properties.Resources.CreditCardLogos;
                }
                else if (displayNumber < -1)
                {
                    displayNumber = 51;
                    CreditCardImageSelection(displayNumber);
                }
                else
                {
                    CreditCardImageSelection(displayNumber);
                }
            }
            else if (xButton.Name == "btnImageSelectorScrollRight")
            {
                int.TryParse(btnUseSelectedImage.Tag.ToString(), out displayNumber);
                displayNumber++;
                if (displayNumber > 51)
                {
                    displayNumber = -1;
                    picImageSelectorSelectedImage.Image = Properties.Resources.CreditCardLogos;
                }
                else
                {
                    CreditCardImageSelection(displayNumber);
                }

            }
            else
            {
                picCardSelectedImage.Image = picImageSelectorSelectedImage.Image;
                //"btnUseSelectedImage"
                //ToDo Send value to Database create Utility Table or Settings

                pnlImageSelector.Visible = false;
            }

            btnUseSelectedImage.Tag = displayNumber;


        }


        private void picCardSelectedImage_Click(object sender, EventArgs e)
        {
            pnlImageSelector.Visible = true;
            pnlImageSelector.BringToFront();
        }

        private void btnUseSelectedImage_Click(object sender, EventArgs e)
        {
            picCardSelectedImage.Image = picImageSelectorSelectedImage.Image;
            pnlImageSelector.Visible = false;

        }



        private void LoanTypeSelector_Click(object sender, EventArgs e)
        {

            Button xButton = new Button();
            xButton = sender as Button;
            int direction = int.Parse(xButton.Tag.ToString());
            int xTag = int.Parse(picLoanType.Tag.ToString());

            xTag += direction;
            if (xTag > 3) { xTag = 1; }
            else if (xTag < 1) { xTag = 3; }
            xButton.Tag = xTag;

            switch (xTag)
            {
                case (1):
                    picLoanType.Image = Properties.Resources.Personal_Loan;
                    Bills.Add("SubGroupID", "95");
                    break;
                case (2):
                    picLoanType.Image = Properties.Resources.Car_Loan;
                    Bills.Add("SubGroupID", "96");
                    break;
                case (3):
                    picLoanType.Image = Properties.Resources.Home_Loan;
                    Bills.Add("SubGroupID", "98");
                    break;

            }

        }



        private void Logo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) ||
                (e.Data.GetDataPresent(DataFormats.Text) &&
                ((string)e.Data.GetData(DataFormats.Text)).StartsWith("http")))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private async void Logo_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        picLogo.Image = Image.FromFile(file);
                        if (!string.IsNullOrEmpty(txtCompanyName.Text))
                        {
                            string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                            string targetPath = Path.Combine(exePath, "AppData", "Resources", "Images", "Bills");

                            Directory.CreateDirectory(targetPath);

                            string desiredFileName = $"{txtCompanyName.Text}_{fileName}";

                            string targetFile = Path.Combine(targetPath, desiredFileName);

                            if (File.Exists(targetFile))// Check for duplicate add attempt, overwrite existing as it may be better quality.
                            {
                                File.Delete(targetFile);
                            }

                            // Copy the file
                            File.Copy(file, targetFile, true);
                        }
                    }
                }
                else if (e.Data.GetDataPresent(DataFormats.Text) &&
                         ((string)e.Data.GetData(DataFormats.Text)).StartsWith("http"))
                {
                    string url = (string)e.Data.GetData(DataFormats.Text);

                    using (var client = new WebClient())
                    {
                        var data = await client.DownloadDataTaskAsync(url);
                        using (var stream = new MemoryStream(data))
                        {
                            picLogo.Image = new Bitmap(stream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picLogo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.V)//Check for Cntrl+V for pasting
            {
                if (Clipboard.ContainsImage())
                {
                    picLogo.Image = Clipboard.GetImage();
                }
            }
        }

        private void picLogo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                case Keys.C:
                case Keys.V:
                case Keys.X:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void TextBoxValidationOn_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = new TextBox();
            txtBox = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;  // Ignore
            }
            else if (e.KeyChar == '.' && txtBox.Text.Contains('.'))
            {
                e.Handled = true;  // Ignore
            }
        }


        private void cmbBudgetCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoryItems.Items.Clear();

            string valueToFind = cmbBudgetCategory.SelectedItem.ToString();
            string value = Category[valueToFind];

            Bills["CategoryID"] = value;

            foreach (KeyValuePair<string, string> kvp in CategoryItems)
            {
                if (kvp.Value == value)
                {
                    string[] parts = kvp.Key.Split(':');
                    cmbCategoryItems.Items.Add(parts[0]);//Lod list box with Items from this category
                }
            }
        }

        private void cmbCategoryItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoryItems.SelectedIndex != 0)
            {
                conditions.Clear();
                conditions.Add("SubCategoryName", cmbCategoryItems.SelectedItem.ToString());
                conditions.Add("CategoryID", Bills["CategoryID"]);

                Bills["SubGroupID"] = data.SelectString("SubGroupID", "CategorySubGroups", conditions);
            }

        }
        #endregion
        private void lblAccountInformation_Click(object sender, EventArgs e)
        {
            pnlHouseHold.Visible = false;
            pnlLoan.Visible = false;
            pnlCreditCard.Visible = false;

            cmbStateAbreviations.Items.AddRange(data.SelectList("StateAbbreviation", "States").ToArray());

            pnlAccountInformation.Location = new Point(0, 360);
            pnlAccountInformation.Height = 425;
            pnlAccountInformation.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            double balance = 0;
            int paymentType = 0;
            double APR = 0;           
            string Bill_ID;
            int months;

            if (billType == "Credit Card" && txtCreditCard_StartingBalance.Text != null) { double.TryParse(txtCreditCard_StartingBalance.Text, out balance); }
            else if (billType == "Loan" && txtLoan_StartingBalance.Text != null) { { double.TryParse(txtLoan_StartingBalance.Text, out balance); } }
            else { balance = 0; }

            if (billType == "Credit Card" && txtCreditCardAPR.Text != null) { double.TryParse(txtCreditCardAPR.Text, out APR); }
            else if (billType == "Loan" && txtLoan_APR.Text != null) { { double.TryParse(txtLoan_APR.Text, out APR); } }
            else { APR = 0; }


            switch (preferedPaymentMethod)
            {
                case "Check":
                    paymentType = 1;
                    break;
                case "Credit Card":
                    paymentType = 3;
                    break;
                case "Debit Card":
                    paymentType = 4;
                    break;
                case "Cash":
                    paymentType = 12;
                    break;
                case "Online Banking":
                    paymentType = 19;
                    break;

            }

            //Add to Bills First Since forigen Key is based off Bill ID

            Bills["CompanyName"] = txtCompanyName.Text != null ? txtCompanyName.Text : "NULL";
            Bills["DisplayName"] = txtDisplayName.Text != null ? txtDisplayName.Text : "NULL";
            Bills["DueDay"] = DueDay != null ? DueDay : "1";
            Bills["PaymentMethodID"] = paymentType.ToString() != null ? paymentType.ToString() : "1";
            Bills["AccountNumber"] = txtAccount_Number.Text != null ? txtAccount_Number.Text : "NULL";
            Bills["Address"] = txtAccount_Address.Text != null ? txtAccount_Address.Text : "NULL";
            Bills["State"] = cmbStateAbreviations.SelectedValue != null ? cmbStateAbreviations.SelectedValue.ToString() : "NULL";
            Bills["ZipCode"] = mtbAccount_ZipCode.Text != null ? mtbAccount_ZipCode.Text : "NULL";
            Bills["PhoneNumber"] = mtbAccountPhoneNumber.Text != null ? mtbAccountPhoneNumber.Text : "NULL";
            Bills["Website"] = txtAccount_Website.Text != null ? txtAccount_Website.Text : "NULL";
            Bills["Recurring"] = ckbRecurring.Checked == true ? "1" : "0";
            Bills["IsPrimaryVendor"] = ckbPrimaryVendor.Checked == true ? "1" : "0";
            Bills["AutoPay"] = ckbAutoPay.Checked == true ? "1" : "0";

            conditions.Clear();
            conditions["CompanyName"] = txtCompanyName.Text != null ? txtCompanyName.Text : "NULL";


            bool IsNewRecord = !(data.Contains("Bills", "CompanyName", Bills["CompanyName"]));

            //ToDo: Add code to invoke inputbox as warning and inform user they may be adding a duplicate record.
            //Display Current record and New record in Datagridview where they can keep either or both.

            data.Insert_Into("Bills", Bills);
            Bill_ID = data.GetLastInsertID().ToString();

            switch (billType)
            {
                case "Loans":

                    if (dtStartDate.Value < dtEndDate.Value)
                    {
                        months = ((dtEndDate.Value.Year - dtStartDate.Value.Year) * 12) + dtEndDate.Value.Month - dtStartDate.Value.Month;
                    }
                    else
                    {
                        months = 0;
                        dtStartDate.Value = dtStartDate.MinDate;
                        dtEndDate.Value = dtEndDate.MinDate;
                    }


                    Loans["BillID"] = Bill_ID;
                    Loans["APR"] =APR.ToString();
                    Loans["Balance"] = balance.ToString();
                    Loans["TermMonths"] = months.ToString();
                    Loans["StartDate"] = dtStartDate.Value.ToString("MM,dd,yyyy");
                    Loans["EndDate"] = dtEndDate.Value.ToString("MM,dd,yyyy");
                    Loans["LogoFilePath"] = Logo != null ? Logo : "NULL";
                    Loans["IsActive"] = "1";
                    break;

                case "Credit Card":
                    CreditCard["BillID"] = Bill_ID;
                    CreditCard["APR"] = APR.ToString();
                    CreditCard["Balance"] = balance.ToString();
                    CreditCard["LogoFilePath"] = Logo != null ? Logo : "NULL";
                    CreditCard["IsActive"] = "1";
                    break;

                case "House Hold":
                    HouseHold["BillID"] = Bill_ID;
                    HouseHold["LogoFilePath"] = Logo != null ? Logo : "NULL";
                    HouseHold["IsActive"] = "1";
                    break;
            }





        }

    }

}

