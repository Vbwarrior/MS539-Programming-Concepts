using SQLiteClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
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

        public frmBill(SQLiteCRUD db, GlobalDataAndFunctions globalData, string HeaderText)
        {
            InitializeComponent();
            data = db;
            globals = globalData;
            lblHeader.Text = HeaderText;
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

        private void AccountTypeDecisionLables_Click(object sender, EventArgs e)
        {
            if (!(sender is Label)) { return; }

            Label selection = (Label)sender;




            if (selection.Name == "lblHouseHold" || selection.Name == "lblLoan" || selection.Name == "lblCreditCard")
            {
                billType = selection.Text;//sets Global for BillType to be used when uploading Data
                lblHouseHold.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblHouseHold.ForeColor = Color.Black;
                lblLoan.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblLoan.ForeColor = Color.Black;
                lblCreditCard.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblCreditCard.ForeColor = Color.Black;
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



            if (selection.Name == "lblHouseHold")
            {
                pnlHouseHold.Visible = true;
                pnlHouseHold.Location = new Point(0, 360);
                pnlHouseHold.Height = 400;
                pnlHouseHold.BringToFront();
            }
            else if (selection.Name == "lblLoan")
            {
                pnlLoan.Visible = true;
                pnlLoan.Location = new Point(0, 360);
                pnlLoan.Height = 400;
                pnlLoan.BringToFront();
            }
            else if (selection.Name == "lblCreditCard")
            {
                pnlCreditCard.Visible = true;
                pnlCreditCard.Location = new Point(0, 360);
                pnlCreditCard.Height = 400;
                pnlCreditCard.BringToFront();
            }
            else if (selection.Name == "lblAccountInformation")
            {
                pnlAccountInformation.Visible = true;
                pnlAccountInformation.Location = new Point(0, 360);
                pnlAccountInformation.Height = 425;
                pnlAccountInformation.BringToFront();
            }


        }




        private void PreferedPaymentMethod_MouseEnter(object sender, EventArgs e)//Moves the TextHiglight Box to current control
        {
            if (enableEvents == false) { return; }

            PictureBox pic = new PictureBox();
            pic = sender as PictureBox;

            string[] xTagParts = pic.Tag.ToString().Split(':');
            string xTag = xTagParts[0];
            preferedPaymentMethod = xTagParts[1];


            Point xControl = pic.Location;

            xTag = pic.Tag.ToString();

            lblPaymentMethodHighligter.Visible = false;
            lblPaymentMethodHighligter2.Visible = false;
            lblPaymentMethodHighligter3.Visible = false;

            switch (xTag)
            {
                case "House Hold":
                    lblPaymentMethodHighligter.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter.Visible = true;
                    break;
                case "Credit Card":
                    lblPaymentMethodHighligter2.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter2.Visible = true;

                    break;
                case "Loan":
                    lblPaymentMethodHighligter3.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter3.Visible = true;
                    break;
            }
        }



        private void PreferedPaymentMethod_Click(object sender, EventArgs e)
        {

            PictureBox pic = new PictureBox();
            string xTag = string.Empty;
            pic = sender as PictureBox;

            Point xControl = pic.Location;

            xTag = pic.Tag.ToString();

            if (lockedControlTag != xTag && enableEvents == false) { return; }//Higligter locked

            switch (xTag)
            {
                case "House Hold":
                    lblPaymentMethodHighligter.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter.Visible = true;

                    if (enableEvents == false)
                    {
                        enableEvents = true;
                        lblPaymentMethodHighligter.BackColor = Color.DodgerBlue;
                        selectedPaymentHilighterLocation = new Point(0, 0);
                    }
                    else
                    {
                        lockedControlTag = xTag;
                        enableEvents = false;
                        lblPaymentMethodHighligter.BackColor = Color.Fuchsia;
                        selectedPaymentHilighterLocation = new Point(xControl.X - 5, xControl.Y - 5);
                    }
                    break;
                case "Credit Card":
                    lblPaymentMethodHighligter2.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter2.Visible = true;


                    if (enableEvents == false)
                    {
                        enableEvents = true;
                        lblPaymentMethodHighligter2.BackColor = Color.DodgerBlue;
                        selectedPaymentHilighterLocation = new Point(0, 0);
                    }
                    else
                    {
                        enableEvents = false;
                        lblPaymentMethodHighligter2.BackColor = Color.Fuchsia;
                        selectedPaymentHilighterLocation = new Point(xControl.X - 5, xControl.Y - 5);
                        lockedControlTag = xTag;
                    }

                    break;
                case "Loan":
                    lblPaymentMethodHighligter3.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter3.Visible = true;
                    lblPaymentMethodHighligter3.BackColor = Color.Fuchsia;

                    if (enableEvents == false)
                    {
                        enableEvents = true;
                        lblPaymentMethodHighligter3.BackColor = Color.DodgerBlue;
                        selectedPaymentHilighterLocation = new Point(0, 0);
                    }
                    else
                    {
                        enableEvents = false;
                        lblPaymentMethodHighligter3.BackColor = Color.Fuchsia;
                        selectedPaymentHilighterLocation = new Point(xControl.X - 5, xControl.Y - 5);
                        lockedControlTag = xTag;
                    }


                    break;
            }




        }


        #endregion

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

        private void btnSave_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> columnData = new Dictionary<string, string>();
            double balance = 0;
            double APR = 0;
            int paymentType = 0;

            if (billType == "Credit Card" && txtCreditCard_StartingBalance.Text != null) { double.TryParse(txtCreditCard_StartingBalance.Text, out balance); }
            else if (billType == "Loan" && txtLoan_StartingBalance.Text != null) { { double.TryParse(txtLoan_StartingBalance.Text, out balance); } }
            else { balance = 0; }

            if (billType == "Credit Card" && txtCreditCard_APR.Text != null) { double.TryParse(txtCreditCard_APR.Text, out APR); }
            else if (billType == "Loan" && txtLoan_APR.Text != null) { { double.TryParse(txtLoan_APR.Text, out APR); } }
            else { APR = 0; }


            switch (preferedPaymentMethod)
            {
                case "Checking":
                    paymentType = 1;
                    break;
                case "CreditCard":
                    paymentType = 3;
                    break;
                case "DebitCard":
                    paymentType = 4;
                    break;
                case "Cash":
                    paymentType = 12;
                    break;
                case "Online Banking":
                    paymentType = 19;
                    break;

            }


           columnData.Add("isActive ", "1");
           columnData.Add("BudgetID ",globals.BudgetID);
           columnData.Add("CompanyName ", txtCompanyName.Text != null ? txtCompanyName.Text : "NULL");
           columnData.Add("DisplayName ", txtDisplayName.Text != null ? txtDisplayName.Text : "NULL");
           columnData.Add("Address ", txtAccount_Address.Text != null ? txtAccount_Address.Text : "NULL");
           columnData.Add("City ", txtAccount_City.Text != null ? txtAccount_City.Text : "NULL");
           columnData.Add("State ", cmbStateAbreviations.SelectedValue != null ? cmbStateAbreviations.SelectedValue.ToString() : "NULL");
           columnData.Add("ZipCode ", mtbAccount_ZipCode.Text != null ? mtbAccount_ZipCode.Text : "NULL");
           columnData.Add("PhoneNumber ", mtbAccountPhoneNumber.Text != null ? mtbAccountPhoneNumber.Text : "NULL");
           columnData.Add("PrimaryPaymentMethod ", preferedPaymentMethod);
           columnData.Add("AccountType ", "Not Set");
           columnData.Add("Balance ", balance.ToString());
           columnData.Add("APR ", APR.ToString());
           columnData.Add("Website ", txtAccount_Website.Text != null ? txtAccount_Website.Text : "NULL");
           columnData.Add("BillType ", billType);
           columnData.Add("DueDay ", DueDay);
           columnData.Add("Recurring ", ckbRecurring.Checked == true ? "1" : "0");
           columnData.Add("PreferedPaymentMethod ", paymentType.ToString());
           columnData.Add("AccountNumber ", txtAccount_Number.Text != null ? txtAccount_Number.Text : "NULL");
           columnData.Add("CreditCardImage ", CreditCardLogo.ToString());
           columnData.Add("LoanType ", "Not Set");
           columnData.Add("BudgetCategory ", cmbBudgetCategory.SelectedValue != null ? cmbBudgetCategory.SelectedValue.ToString() : "NULL");
           columnData.Add("CompanyLogo ", "Not Set");

            data.Insert_Into(data.Tables(SQLiteCRUD.TableNames.Bills), columnData);



        }


    }
}
