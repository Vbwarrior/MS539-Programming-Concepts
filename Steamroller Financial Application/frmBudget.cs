/*
 
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
        private SQLiteCRUD data;//Refrence to Database Instance from Main Form
        private GlobalDataAndFunctions globals;
        bool mouseIsDown = false;
        frmMain mainForm = new frmMain();
        int increment = 0;
        private Point lastLocation;
        private Dictionary<string, int> dictBudget = new Dictionary<string, int>();
        Dictionary<string, string> columnData = new Dictionary<string, string>();


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



            //ToDo: Load Budget Values from DB and store them in dictBudget

            dictBudget.Clear();
          //  dictBudget =data.



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
            mainForm.pnlMainMenu.Visible = true;
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

            data.Insert_Into(data.Tables(SQLiteCRUD.TableNames.BudgetData), columnData);

        }

        private void LoadData()
        {


        }
   
    }
}
