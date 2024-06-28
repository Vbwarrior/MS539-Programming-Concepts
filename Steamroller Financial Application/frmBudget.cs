﻿/*
 
Add subgroups to category if not already present 
get amounts and add to dictionary
 
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

        private List<Dictionary<string, string>> budgetData = new List<Dictionary<string, string>>();
        private List<Button> createdButtons = new List<Button>();
        private Dictionary<string, string> columnData = new Dictionary<string, string>();

        private bool mouseIsDown = false;
        private bool eventsEnabled = false;
        private int increment = 0;
        private int AdditionalHeight;
        private Point lastLocation;


        public frmBudget(SQLiteCRUD db, GlobalDataAndFunctions globalData)
        {
            InitializeComponent();
            txtAmount.MouseWheel += TxtAmount_MouseWheel;

            data = db;
            globals = globalData;

        }
        private void frmBudget_Load(object sender, EventArgs e)
        {

            LoadBudgetValues();
        }

        private void LoadBudgetValues()
        {
            columnData.Add("Category", "");
            columnData.Add("AllocatedAmount", "");
            columnData.Add("Color", "");
            columnData.Add("SubGroup", "");
            columnData.Add("Category", "");

            if (data.Contains("BudgetData", "BudgetID", globals.BudgetID.ToString()))
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("BudgetID", globals.BudgetID.ToString());
                budgetData.Clear();
                budgetData = data.SelectTable("BudgetData", conditions);
            }
            else
            {

            }
        }

        private void Category_Click(object sender, EventArgs e)
        {
            Button selection = sender as Button;

            lblCategoryName.Text = selection.Tag.ToString();

            increment = int.Parse(lblAllocatedAmount.Text) / 600;
            lblRedBar.Width = int.Parse(lblAssignedAmount.Text) / increment;
            int xPos = lblOrangeBar.Right - lblRedBar.Width;
            int yPos = lblOrangeBar.Top;

            lblRedBar.Location = new Point(xPos, yPos);











            //toDo : Pull current amount from Database and assign to textbox, get all items in current Category and add Buttons with each

            /*
             * int CurrentAllocation = Database Get Current Amount by Category Name
             * 
             if(CurrentAllocation != 0)
            {
            
            txtAmount.Text = CurrentAllocation;
            }
            else
            {
             txtAmount.Text = 0;
            }
             */


            pnlBudgetCategory_Alocator.Visible = true;
            pnlBudgetCategory_Alocator.BringToFront();
            pnlBudgetCategory_Alocator.Dock = DockStyle.Fill;



        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlBudgetCategory_Alocator.Visible = true;
        }
        private void btnCloseAlocatorPanel_Click(object sender, EventArgs e)
        {
            //mainForm.pnlMainMenu.Visible = true;
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

            pnlBudgetCategory_Alocator.Visible = false;


            Dictionary<string, string> columnData = new Dictionary<string, string>();

            columnData.Add("Category", lblCategoryName.Text);
            columnData.Add("AllocatedAmount", txtAmount.Text);
            columnData.Add("Color", lblSelectedColor.BackColor.ToString());//[A=255, R=value, G=value, B=value]

            data.Insert_Into("BudgetData", columnData);

        }

        private void getCategoryItems()
        {
            //Get CategoryID from Categories
            List<string> columns = new List<string>();
            Dictionary<string, string> conditions = new Dictionary<string, string>();
            Dictionary<string, string> orderBy = new Dictionary<string, string>();

            List<string> categoryItems = new List<string>();

            //Get List of SubGroup Items with Category Name from BudgetItems
            conditions.Add("Category", columnData["Category"]);
            orderBy.Add("SubGroup", "ASC");
            categoryItems.AddRange(data.SelectList("SubGroup", "BudgetItems", conditions, orderBy));//Get List of Items from Database

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



        //private string ShowInputBox()
        //{
        //    using (var inputBox = new InputBox("Enter Budget Name", InputBox.Style.Medium))
        //    {
        //        var result = inputBox.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            BudgetName = inputBox.ReturnValue;

        //        }
        //    }
        //}





        private void LoadData()
        {


        }

    }
}
