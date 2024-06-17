using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steamroller_Financial_Application
{
    public partial class frmBudget : Form
    {
        bool mouseIsDown = false;
        frmMain mainForm = new frmMain();
        int increment = 0;
        private Point lastLocation;
        private Dictionary<string,int> dictBudget = new Dictionary<string,int>();

        public frmBudget()
        {
            InitializeComponent();
            txtAmount.MouseWheel += TxtAmount_MouseWheel;
            this.DoubleBuffered = true; // Enable double buffering
        }
        private void frmBudget_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(783, 418);
            this.Location = new Point(200, 120);
            LoadBudgetValues();

        }

        private void LoadBudgetValues()
        {
            //ToDo: Load Budget Values from DB and store them in dictBudget
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //ToDo: Update Database
            pnlBudgetCategory_Alocator.Visible = false;
        }
    }
}
