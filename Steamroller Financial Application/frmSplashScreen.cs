using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using SQLiteClassLib;

namespace Steamroller_Financial_Application
{
    public partial class frmSplashScreen : Form
    {
        // private SQLiteCRUD data;//Refrence to Database Instance from Main Form
        private SQLiteCRUD data;
        private GlobalDataAndFunctions globals;
        bool flag = false;
        int FailedLoginAttempts = 0;
        string inputBoxReturnValue;
        public List<string> columns = new List<string>();
        public Dictionary<string, string> conditions = new Dictionary<string, string>();
     


        public frmSplashScreen(SQLiteCRUD db, GlobalDataAndFunctions globalData)
        {
            InitializeComponent();
            data = db;
            globals = globalData;

#if DEBUG
            this.TopMost = false;
#endif

        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            if (flag == false && (picEyeball.Left < 100 || picEyeball.Top < 100))
            {
                flag = true;
                Thread.Sleep(1000); // 2-second pause
                LoginTimer.Interval = 20;
                pnlLogin.Height = 1;
                pnlLogin.Visible = true;
                pnlLogin.BringToFront();
            }
            else if (flag)
            {
                pnlLogin.Height += 10;
                if (pnlLogin.Height >= 210) { LoginTimer.Enabled = false; }
            }
            else
            {
                picDollarSign.Visible = false;
                picEyeball.Visible = true;
                picEyeball.Size = new Size(picEyeball.Width + 100, picEyeball.Height + 100);
                picEyeball.Location = new Point(picEyeball.Left - 50, picEyeball.Top - 50);
            }
        }

        private void frmSplashScreen_Click(object sender, EventArgs e)
        {
#if DEBUG

            this.Close();
#endif
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            float centerX1;
            float centerY1;
            float centerX2;
            float centerY2;
            string text1 = "Steam Roller";
            string text2 = "Financial Application";


            if (picDollarSign.Top < 10)
            {
                SplashTimer.Enabled = false;

                if (picDollarSign.Image != null)
                {
                    // Create a Graphics object from the image
                    using (Graphics g = Graphics.FromImage(picDollarSign.Image))
                    {
                        // Draw the centered text
                        using (Font font = new Font("Stencil", 250, FontStyle.Bold | FontStyle.Italic)) // Changed font size to 144
                        {

                            centerX1 = (picDollarSign.Image.Width - g.MeasureString(text1, font).Width) / 2;//center the first line
                            centerY1 = (picDollarSign.Image.Height - g.MeasureString(text1, font).Height) / 2;

                            g.DrawString(text1, font, Brushes.Fuchsia, new PointF(centerX1, centerY1));
                        }
                        using (Font font = new Font("Stencil", 150, FontStyle.Bold | FontStyle.Italic))
                        {
                            centerX2 = (picDollarSign.Image.Width - g.MeasureString(text2, font).Width) / 2;// center for the second line
                            centerY2 = centerY1 + g.MeasureString(text1, font).Height;

                            g.DrawString(text2, font, Brushes.Yellow, new PointF(centerX2, centerY2));
                        }
                    }
                    picDollarSign.Refresh();

                }

                Thread.Sleep(1000); // 2-second pause
                LoginTimer.Enabled = true;
            }
            else
            {
                picDollarSign.Size = new Size(picDollarSign.Width + 50, picDollarSign.Height + 50);
                picDollarSign.Location = new Point(picDollarSign.Left - 25, picDollarSign.Top - 25);
                picDollarSign.SendToBack();
            }
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            pnlLogin.Height -= 10;
            if (pnlLogin.Height <= 0)
            {
                CloseTimer.Enabled = false;
                Thread.Sleep(2000); // 2-second pause
                this.Close();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text)) { return; }
            //#if DEBUG
            //            this.Close();
            //#endif
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            List<string> Budgets = new List<string>();
            long BudgetID = 0;
            bool hasName = false;
            string BudgetName = string.Empty;
            int xCount = 0;
            Dictionary<string, string> columnsAndValues = new Dictionary<string, string>();

            conditions.Clear();
            columns.Clear();

            lblViolation.Visible = false;//Clear any previous error attempts

            hasName = data.FieldContains("Users", "UserName", userName);// Check if Users Exists Already

            
            if (hasName)
            {

                columns.Add("BudgetID");
                conditions.Add("UserName",userName);

                
                using (SQLiteDataReader getUsersBudgets = data.SelectReader(columns, "User_Access", conditions)) 
                {
                    if (getUsersBudgets.HasRows)
                    {
                        BudgetID = getUsersBudgets.GetInt32(0);

                    }
                    else//Create New Budget
                    {
                        using (var inputBox = new InputBox("Enter Budget Name"))
                        {
                            var result = inputBox.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                BudgetName = inputBox.ReturnValue;

                            }
                        }


                        //Add New Budget into Budgets
                        columnsAndValues.Add("isActive", "1");
                        columnsAndValues.Add("BudgetName", BudgetName);
                        data.Insert_Into("Budgets", columnsAndValues);

                      
                        columns.Clear();
                        columns.Add("ID");
                        conditions.Clear();
                        conditions.Add("BudgetName",BudgetName);


                       
                      
                        using (SQLiteDataReader LastID = data.SelectReader(columns, data.Tables(SQLiteCRUD.TableNames.Budgets), conditions))
                        {
                            if (LastID.Read()) // Check if there are any results
                            {
                                long lastRowId = LastID.GetInt64(0); // Convert BudgetID into Long
                                BudgetID = lastRowId;
                            }
                        }
                     
                        //Add User Data and Budget ID into User Access
                        columnsAndValues.Clear();
                        columnsAndValues.Add("UserName", userName);
                        columnsAndValues.Add("BudgetID", BudgetID.ToString());
                        data.Insert_Into("User_Access", columnsAndValues);

                    }


                }

            }

            else
            {
                lblViolation.Visible = true;
                ++FailedLoginAttempts;
                //Invalid Username or Password (3) attempts remaining!
                lblViolation.Text = $"Invalid Username or Password ({3 - FailedLoginAttempts}) attempts remaining!";


                if (FailedLoginAttempts > 2) { Application.Exit(); }

                return;
            }
            //   }

            globals.BudgetID = BudgetID.ToString();
            globals.UserName = userName;

            this.Close();

        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            frmNewUser frmNewUsercs = new frmNewUser(data, globals);

            frmNewUsercs.ShowDialog();

        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Cyan;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();//User Canceled Operation
        }






    }
}
