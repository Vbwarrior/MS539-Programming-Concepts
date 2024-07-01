using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteClassLib;

namespace Steamroller_Financial_Application
{
    public partial class frmNewTransaction : Form
    {
        private SQLiteCRUD data;//Refrence to Database Instance from Main Form
        private GlobalDataAndFunctions globals;
        public Dictionary<string, string> columnData = new Dictionary<string, string>();
        public Dictionary<string, string> conditions = new Dictionary<string, string>();
        public List<Button> createdButtons = new List<Button>();
        public int AdditionalHeight;
        private int maxitemHaloSizeWidth = 621;
        private bool eventsEnabled = false;
        private string BudgetID;
        public frmNewTransaction(SQLiteCRUD db, GlobalDataAndFunctions globalData)
        {
            InitializeComponent();

            data = db;
            globals = globalData;

            BudgetID = data.SelectString("BudgetID", "Budgets", globals.UserID.ToString());
        }

        private void NewTransaction_Load(object sender, EventArgs e)
        {
            columnData.Add("TransactionDate", DateTime.Now.ToString("MM/dd/yy"));
            columnData.Add("CategoryID", "");
            columnData.Add("BudgetID", BudgetID);
            columnData.Add("Amount", "");
            columnData.Add("VendorName", "");
            columnData.Add("SubGroupID", "");
            columnData.Add("PaymentMethodID", "");


            btnHousing.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void category_Click(object sender, EventArgs e)
        {
            Button xButton = sender as Button;
            string xTag = xButton.Tag.ToString();
            string category;
            eventsEnabled = false;
            txtAmount.Text = string.Empty;
            txtPayTo.Text = string.Empty;
            //Update Highlighters
            lblCategoryHalo.Location = new Point(xButton.Location.X - 5, xButton.Location.Y - 5);
            lblCategoryHalo.Visible = true;
            lblCategoryHalo.Size = lblCategoryHalo.MinimumSize;
            category = xTag;
            lblItemsHalo.Visible = false;

            getCategoryItems(category);
        }
        private void paymentMethod_Click(object sender, EventArgs e)
        {
            Button xButton = sender as Button;
            string xTag = xButton.Tag.ToString();

            btnCash.BackColor = Color.Transparent;
            btnCheck.BackColor = Color.Transparent;
            btnCreditCard.BackColor = Color.Transparent;
            btnDebitCard.BackColor = Color.Transparent;
            btnOnlineBanking.BackColor = Color.Transparent;
            //Update Highlighters
            lblPaymentMethodHalo.Location = new Point(xButton.Location.X - 5, xButton.Location.Y - 5);
            lblPaymentMethodHalo.Visible = true;
            lblPaymentMethodHalo.Size = lblPaymentMethodHalo.MinimumSize;
            columnData["PaymentMethodID"] = xTag;
            xButton.BackColor = lblPaymentMethodHalo.BackColor;
        }

        private void getCategoryItems(string category)
        {
            //Get CategoryID from Categories
            List<string> columns = new List<string>();
            Dictionary<string, string> conditions = new Dictionary<string, string>();
            Dictionary<string, string> orderBy = new Dictionary<string, string>();

            List<string> categoryItems = new List<string>();

            //Get List of SubGroup Items with Category Name from BudgetItems
            conditions.Clear();
            conditions.Add("CategoryName", category);
            string categoryID = data.SelectString("CategoryID", "Categories", conditions);

            columnData["CategoryID"] = categoryID;

            conditions.Clear();
            conditions.Add("CategoryID", categoryID);
            conditions.Add("IsActive", "1");
            orderBy.Add("SubCategoryName", "ASC");
            categoryItems.AddRange(data.SelectList("SubCategoryName", "CategorySubGroups", conditions, orderBy));//Get List of Items 
            //Create Buttons for Each Item with click_event  item_Click
            createButtons(categoryItems);


        }

        private void createButtons(List<string> categoryItems)
        {
            //Copy Example from designer for scafolding and change values
            Button xButton = new Button();
            Dictionary<Button, Point> xLocations = new Dictionary<Button, Point>();
            //Determine Number of Buttons to Create 
            int step = 6;//261  Bar 245  Drop from bar 14 - Start @ 88 - 730
            int CurrentSpaceRequired = 0; //646 Available per row
            int RowsRequired = 0;
            Tuple<int, int> xTuple;//Holds number of buttonss in Row and width required
            List<Tuple<int, int>> btnCountPerRow = new List<Tuple<int, int>>();
            int btnCount = 0;
            int xCount = 0;
            int X = 0;
            int xAmt;
            int xHeight;
            int formWidth; // Replace this with the actual width of your form or panel
            int startingX;
            int startingY;


            if (createdButtons.Count > 0) { DestroyButtons(); this.Height -= AdditionalHeight; }//Destroy any previously created buttons and Zero list, re-adjust height to original

            for (int i = 0; i < categoryItems.Count; i++)
            {
                xButton = new Button();
                xButton.AutoSize = true;
                xButton.BackColor = Color.Transparent;
                xButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                xButton.BackgroundImage = Properties.Resources.Grid;
                // xButton.BackgroundImage = Properties.Resources.Black_Metal;
                xButton.BackgroundImageLayout = ImageLayout.Stretch;
                xButton.FlatAppearance.BorderSize = 0;
                xButton.FlatStyle = FlatStyle.Flat;
                xButton.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                xButton.ForeColor = globals.RandomColors();
                xButton.Name = "xButton_" + i;
                xButton.Tag = categoryItems[i];
                xButton.Text = categoryItems[i];
                xButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                xButton.UseVisualStyleBackColor = false;
                xButton.Visible = false;
                xLocations.Add(xButton, Point.Empty);

                xButton.Click += XButton_Click;

                this.Controls.Add(xButton);

                createdButtons.Add(xButton);

                if (CurrentSpaceRequired + xButton.Width > 640) //Get Row Requirments for Each New Set of Buttons
                {
                    RowsRequired++;
                    xTuple = new Tuple<int, int>(btnCount, CurrentSpaceRequired);
                    btnCountPerRow.Add(xTuple);
                    btnCount = 0;
                    CurrentSpaceRequired = xButton.Width;
                }
                else
                {
                    CurrentSpaceRequired += xButton.Width + step;
                    btnCount++;
                }
            }
            xTuple = new Tuple<int, int>(btnCount, CurrentSpaceRequired);
            btnCountPerRow.Add(xTuple);//capture elements in last row
            AdditionalHeight = (xButton.Height * RowsRequired) + (RowsRequired * 6);//Adjust Height to accomodate extra rows
            this.Height += AdditionalHeight;

            // Get Starting Point for first control
            btnCount = 0;
            xCount = 0;
            X = 0;
            xAmt = btnCountPerRow[0].Item1;
            xHeight = xButton.Height + 6;
            formWidth = 812; // Replace this with the actual width of your form or panel
            startingX = (formWidth - btnCountPerRow[xCount].Item2) / 2;
            startingY = 261;

            foreach (var cntrl in xLocations)
            {
                xLocations[cntrl.Key] = new Point(startingX, startingY);
                startingX += step + cntrl.Key.Width;

                X++;
                if (X >= xAmt)
                {
                    X = 0;
                    ++xCount;
                    if (xCount < btnCountPerRow.Count) // Check if there are more rows
                    {
                        xAmt = btnCountPerRow[xCount].Item1; // Update the number of buttons in the current row
                        startingY += xHeight;
                        startingX = (formWidth - btnCountPerRow[xCount].Item2) / 2; // Update the starting X position for the new row
                    }
                }
            }
            foreach (var cntrl in xLocations)
            {
                cntrl.Key.Location = new Point(cntrl.Value.X, cntrl.Value.Y);
                cntrl.Key.Visible = true;
            }

        }

        private void XButton_Click(object? sender, EventArgs e)
        {
            eventsEnabled = true;
            Button xButton = sender as Button;
            string xTag = xButton.Tag.ToString();

            //Update Highlighters
            lblItemsHalo.Location = new Point(xButton.Location.X - 5, xButton.Location.Y - 5);

            lblItemsHalo.Width = xButton.Width + 10;
            lblItemsHalo.Height = xButton.Height + 10;

            lblItemsHalo.Visible = true;

            conditions.Clear();
            conditions.Add("CategoryID", columnData["CategoryID"]);
            conditions.Add("IsActive", "1");

            string subGroupID = data.SelectString("SubGroupID", "CategorySubGroups", conditions);
            columnData["SubGroupID"] = subGroupID;




            txtAmount.Focus();

            xButton.BringToFront();
        }

        private void DestroyButtons()
        {
            foreach (Button button in createdButtons)
            {
                this.Controls.Remove(button);
                button.Dispose();

            }
            createdButtons.Clear();
            this.Height -= AdditionalHeight;
            AdditionalHeight = 0;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            columnData["Amount"] = txtAmount.Text;
            columnData["VendorName"] = txtPayTo.Text;

            if (!(ValidateData())) { return; }

            data.Insert_Into("Transactions", columnData);

            txtAmount.Text = string.Empty;
            txtPayTo.Text = string.Empty;

            lblCategoryHalo.Visible = false;
            lblItemsHalo.Visible = false;
            lblPaymentMethodHalo.Visible = false;

            DestroyButtons();
           
            //Reset Data Input
            columnData.Clear();
            columnData.Add("TransactionDate", DateTime.Now.ToString("MM/dd/yy"));
            columnData.Add("CategoryID", "");
            columnData.Add("BudgetID", BudgetID);
            columnData.Add("Amount", "");
            columnData.Add("VendorName", "");
            columnData.Add("SubGroupID", "");
            columnData.Add("PaymentMethodID", "");

        }

        private bool ValidateData()
        {
            bool isValid = true;
            List<string> errMsg = new List<string>();
            StringBuilder displayedErrorMsg = new StringBuilder();

            if (string.IsNullOrEmpty(columnData["CategoryID"]))
            {
                errMsg.Add("Select Category");
                lblCategoryHalo.Size = lblCategoryHalo.MaximumSize;
                lblCategoryHalo.Visible = true;
                isValid = false;
            }


            if (string.IsNullOrEmpty(columnData["SubGroupID"]))
            {
                errMsg.Add("Select the category item.");
                lblItemsHalo.Size = new Size(lblTopBar.Width, lblBottomBar.Location.Y - lblTopBar.Location.Y);
                lblItemsHalo.Location = new Point(lblTopBar.Location.X, lblTopBar.Bottom);
                lblItemsHalo.SendToBack();
                lblItemsHalo.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrEmpty(columnData["Amount"]))
            {
                errMsg.Add("Missing Amount");
                isValid = false;
            }
            else if (decimal.TryParse(columnData["Amount"], out decimal result))
            {
                string[] parts = result.ToString().Split('.');

                if (parts.Length > 1 && parts[1].Length > 2)// Check if it has more than two decimal places
                {
                    errMsg.Add("Amount has more than two decimal places");
                    isValid = false;
                }
                else if (result <= 0)
                {
                    errMsg.Add("Amount cannot be zero");
                    isValid = false;
                }
            }
            else
            {
                errMsg.Add("Amount is not a dollar value");
                isValid = false;
            }



            if (string.IsNullOrEmpty(columnData["VendorName"]))
            {
                errMsg.Add("The paid to field is required.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(columnData["PaymentMethodID"]))
            {
                errMsg.Add("Select payment type.");
                lblPaymentMethodHalo.Size = lblPaymentMethodHalo.MaximumSize;
                lblPaymentMethodHalo.Visible = true;
                isValid = false;
            }



            for (int i = 0; i < errMsg.Count; i++)
            {
                displayedErrorMsg.AppendLine($"({i + 1}).   {errMsg[i]}.");

            }



            if (isValid == false) { MessageBox.Show(displayedErrorMsg.ToString()); }

            return isValid;
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            bool isValid = true;
            if (eventsEnabled == false) { return; }

            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                toolTip1.SetToolTip(picError_Amount, "Missing Amount");
                isValid = false;
            }
            else if (decimal.TryParse(txtAmount.Text, out decimal result))
            {
                result = Math.Round(result, 2); // Round to the nearest cent

                // Format the decimal value to always have two decimal places
                txtAmount.Text = result.ToString("F2");

                string[] parts = result.ToString().Split('.');

                if (parts.Length > 1 && parts[1].Length > 2)// Check if it has more than two decimal places
                {
                    toolTip1.SetToolTip(picError_Amount, "Amount has more than two decimal places");
                    isValid = false;
                }
                else if (result <= 0)
                {
                    toolTip1.SetToolTip(picError_Amount, "Amount cannot be zero");
                    isValid = false;
                }
            }
            else
            {
                toolTip1.SetToolTip(picError_Amount, "Amount is not a dollar value");
                isValid = false;
            }

            if (isValid == false)
            {
                picError_Amount.Visible = true;
            }
            else
            {
                picError_Amount.Visible = false;
                txtPayTo.Focus();
            }
        }


        private void txtPayTo_Leave(object sender, EventArgs e)
        {
            if (eventsEnabled == false) { return; }

            if (string.IsNullOrEmpty(txtPayTo.Text))
            {
                toolTip1.SetToolTip(picError_PayTo, "The paid to field is required.");
                picError_PayTo.Visible = true;
            }
            else
            {
                // Convert the text to Proper Case while preserving acronyms
                CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;

                txtPayTo.Text = string.Join(" ", txtPayTo.Text
                    .Split(' ')
                    .Select(word => word.All(char.IsUpper) ? word : textInfo.ToTitleCase(word.ToLower())));

                picError_PayTo.Visible = false;
            }
        }
    }
}
