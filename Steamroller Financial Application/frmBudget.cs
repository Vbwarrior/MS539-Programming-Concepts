/*
 
1. Check if user already has a budget
        Yes- 1. See if there is any alloctions already for this budget
                2. Load NetSpending amount into Allocated Amount label
                3. Load Dictionary with All allocations for this budget into BudgetData
                4. Run a Linq query to calculate total amount already allocated in budget
                5. When user selects category then alredy defined amount should be displayed.

        No- 1. Open Input Box and Ask for Total funds available for budget
                2. Assign this value to NetSpending on Budgets Table
 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SQLiteClassLib;


namespace Steamroller_Financial_Application
{
    public partial class frmBudget : Form
    {
        //frmMain mainForm = new frmMain();
        private SQLiteCRUD data;//Refrence to Database Instance from Main Form
        private GlobalDataAndFunctions globals;
        private List<Button> createdButtons = new List<Button>();
        private Dictionary<string, string> columnData = new Dictionary<string, string>();
        Dictionary<string, string> conditions = new Dictionary<string, string>();
        Dictionary<string, string> allocations = new Dictionary<string, string>();
        string BudgetID = string.Empty;

        private bool mouseIsDown = false;
        private bool eventsEnabled = false;
        private int increment = 0;
        private int AdditionalHeight;
        private Point lastLocation;

        private int netSpending;
        private int AssignAmount;


        public frmBudget(SQLiteCRUD db, GlobalDataAndFunctions globalData)
        {
            InitializeComponent();
            txtAmount.MouseWheel += TxtAmount_MouseWheel;
            this.Size = new Size(785, 430);
            data = db;
            globals = globalData;
            BudgetID = data.SelectString("BudgetID", "Budgets", globals.UserID.ToString());

        }

        private void frmBudget_Load(object sender, EventArgs e)
        {
            if (BudgetID == "No Data Found")//Get Budget ID if Budget is present.
            {
                BudgetID = string.Empty;
                lblAllocatedAmount.Text = "0";
                lblAssignedAmount.Text = "0";
                GetBudgetNetSpending();
            }
            else//Load users data
            {
                UpdateAllocationsAndAssigned();

            }
        }

        private void GetBudgetNetSpending()
        {
            frmInputBox inputBox = new frmInputBox(globals, "Set amount of available money for your new budget.", frmInputBox.Style.Medium, frmInputBox.Mode.TextBox);
            var result = inputBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                int.TryParse(inputBox.ReturnValue, out netSpending);

                if (netSpending > 0)
                {
                    lblAllocatedAmount.Text = netSpending.ToString();
                    conditions.Clear();
                    conditions.Add("BudgetId", BudgetID);
                    columnData.Clear();
                    columnData.Add("NetSpending", netSpending.ToString());
                    data.Update("Budgets", columnData, conditions);//Update amount of Net Spending in table
                }
            }
        }

        private void UpdateAllocationsAndAssigned()
        {
            var keyValuePair = new KeyValuePair<string, string>("BudgetID", BudgetID);
            netSpending = int.Parse(data.SelectString("NetSpending", "Budgets", keyValuePair));
            lblAllocatedAmount.Text = netSpending.ToString();
            List<string> xList = data.SelectList("Amount", "Allocations", "BudgetID", BudgetID);
            int x = 0;
            for (int i = 0; i < xList.Count; i++)
            {
                x += int.Parse(xList[i]);
            }
            lblAssignedAmount.Text = x.ToString();

        }

        private void Category_Click(object sender, EventArgs e)
        {
            Button selection = sender as Button;
            int xPos = 0;
            int yPos = 0;
            string category = selection.Tag.ToString();
            string categoryID;

            lblCategoryName.Text = selection.Tag.ToString();

            if (lblAllocatedAmount.Text != "0")//Get Allocated amount to set increment value
            {
                int.TryParse(lblAllocatedAmount.Text, out int setAmount);
                increment = setAmount / 600;
                lblRedBar.Width = int.Parse(lblAssignedAmount.Text) / increment;

            }
            else
            {
                lblRedBar.Width = 0;
            }

            xPos = lblOrangeBar.Right - lblRedBar.Width;
            yPos = lblOrangeBar.Top;


            lblRedBar.Location = new Point(xPos, yPos);
            conditions.Clear();
            conditions.Add("CategoryName", category);
            categoryID = data.SelectString("CategoryID", "Categories", conditions);

            if (data.Contains("Allocations", "CategoryID", categoryID))
            {
                columnData.Clear();
                columnData.Add("BudgetID", BudgetID);
                columnData.Add("CategoryID", categoryID);

                allocations = data.SelectRow("Allocations", columnData);
                txtAmount.Text = allocations["Amount"];
                lblSelectedColor.BackColor = globals.StringToColor(allocations["KeyColor"]);

                //Set Green Bar Position
                lblGreenBar.Width = int.Parse(allocations["Amount"]) / increment;
                picControlKnob.Location = new Point(lblGreenBar.Right, 123);
            }
            else
            {
                txtAmount.Text = "0";
                lblGreenBar.Width = 0;
                picControlKnob.Location = new Point(91, 123);
            }

            getCategoryItems(categoryID);

            pnlBudgetCategory_Alocator.Visible = true;
            pnlBudgetCategory_Alocator.BringToFront();
            pnlBudgetCategory_Alocator.Dock = DockStyle.Fill;

        }

        private void getCategoryItems(string categoryID)
        {
            List<string> columns = new List<string>();
            List<string> categoryItems = new List<string>();
            Dictionary<string, string> orderBy = new Dictionary<string, string>();


            //Get List of SubGroup Items with Category Name 
            conditions.Clear();
            conditions.Add("CategoryID", categoryID);
            conditions.Add("IsActive", "1");
            orderBy.Add("SubCategoryName", "ASC");
            categoryItems.AddRange(data.SelectList("SubCategoryName", "CategorySubGroups", conditions, orderBy));//Get List of Items from Database

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
            int formWidth = this.Width;
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



                this.pnlBudgetCategory_Alocator.Controls.Add(xButton);

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

        private void lblSelectedColor_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Set the label's background color to the selected color
                lblSelectedColor.BackColor = colorDialog.Color;

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {


            conditions.Clear();
            conditions.Add("CategoryName", lblCategoryName.Text);
            string CategoryID = data.SelectString("CategoryID", "Categories", conditions);

            conditions.Clear();
            conditions.Add("CategoryID", CategoryID);
            conditions.Add("BudgetID", BudgetID);
            //Check for existing Data
            if (data.Contains("Allocations", conditions))//Update
            {
                conditions.Clear();
                conditions.Add("BudgetID", BudgetID);
                conditions.Add("CategoryID", CategoryID);

                columnData.Clear();
                columnData.Add("Amount", txtAmount.Text);
                columnData.Add("KeyColor", globals.ColorToString(lblSelectedColor.BackColor));//  return $"{color.R},{color.G},{color.B}";

                data.Update("Allocations", columnData, conditions);
            }
            else//Add New
            {
                conditions.Clear();
                conditions.Add("CategoryName", lblCategoryName.Text);
                columnData.Clear();
                columnData.Add("BudgetID", BudgetID);
                columnData.Add("CategoryID", CategoryID);
                columnData.Add("Amount", txtAmount.Text);
                columnData.Add("KeyColor", globals.ColorToString(lblSelectedColor.BackColor));//  return $"{color.R},{color.G},{color.B}";
                data.Insert_Into("Allocations", columnData);
            }

            lblAssignedAmount.Text = (int.Parse(lblAssignedAmount.Text) + int.Parse(txtAmount.Text)).ToString();

            pnlBudgetCategory_Alocator.Visible = false;
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



        #region "UI Controls"
        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlBudgetCategory_Alocator.Visible = false;
        }
        private void btnCloseAlocatorPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picControlKnob_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            lastLocation = e.Location;
        }

        private void picControlKnob_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int newLeft = picControlKnob.Left + e.X - lastLocation.X;

                if (newLeft >= 90 && newLeft <= 691)
                {
                    picControlKnob.Left = newLeft;

                    int newWidth = (picControlKnob.Left - 91) * increment;

                    lblGreenBar.Width = picControlKnob.Location.X - 91;

                    txtAmount.Text = newWidth.ToString();
                }
            }
        }

        private void picControlKnob_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void TxtAmount_MouseWheel(object sender, MouseEventArgs e)
        {
            // Check if the current value is a valid number
            if (int.TryParse(txtAmount.Text, out int currentValue))
            {
                // If the mouse wheel is scrolled upwards, increment the value
                if (e.Delta > 0)
                {
                    currentValue++;
                }
                // If the mouse wheel is scrolled downwards, decrement the value
                else if (e.Delta < 0)
                {
                    currentValue--;
                }

                // Set the new value to the TextBox
                txtAmount.Text = currentValue.ToString();
            }
            else
            {
                // If the current value is not a valid number, set it to 0
                txtAmount.Text = "0";
            }
        }

        #endregion
    }
}
