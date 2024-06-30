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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SQLiteClassLib;


namespace Steamroller_Financial_Application
{
    public partial class frmNewUser : Form
    {
        private SQLiteCRUD data;//Refrence to Database Instance from Main Form
        private GlobalDataAndFunctions globals;
        private bool eventsEnabled = true;
        int Mode = 0;
        public frmNewUser(SQLiteCRUD db, GlobalDataAndFunctions globalData)
        {
            InitializeComponent();
            data = db;
            globals = globalData;
        }
        private void frmNewUser_Load(object sender, EventArgs e)
        {
#if DEBUG
            this.TopMost = false;
#endif
        }
        private void frmNewUser_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if (eventsEnabled == false) { return; }//prevent event from executing while reseting control
            ValidateValues();
        }
        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            if (eventsEnabled == false) { return; }//prevent event from executing while reseting control
            if (txtPassword2.Text.Length < 1) { return; }
            ValidateValues();
        }


        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (eventsEnabled == false) { return; }//prevent event from executing while reseting control
            ValidateValues();
        }

        private bool ValidateValues()
        {


            if (txtUserName.Text.Length < 5)
            {
                picWarning2.Visible = true;
                toolTip1.SetToolTip(picWarning2, "User Name must be greater than 4 charecters");
                btnCreateAccount.BackgroundImage = Properties.Resources.Thumbs_Down_Left;
                btnCreateAccount.Enabled = false;
                return false;
            }
            else
            {
                picWarning2.Visible = false;
            }

            if (txtPassword2.Text.Length == 0) { return false; }//No value in txtPassword 2 to evaluate

            if (txtPassword1.Text != txtPassword2.Text)
            {
                btnCreateAccount.Enabled = false;
                toolTip1.SetToolTip(picWarning, "Passwords do not match.");
                picWarning.Visible = true;
                btnCreateAccount.BackgroundImage = Properties.Resources.Thumbs_Down_Left;
                return false;
            }
            else
            {
                picWarning.Visible = false;
            }

            if (txtPassword1.Text.Length >= 5 && txtPassword2.Text.Length >= 5)
            {
                picWarning.Visible = false;
                btnCreateAccount.BackgroundImage = Properties.Resources.Thumbs_Up_Left;
                btnCreateAccount.Enabled = true;
                return true;
            }
            else
            {
                btnCreateAccount.Enabled = false;
                picWarning.Visible = true;
                toolTip1.SetToolTip(picWarning, "Minimum length for Passwords is 5 charecters");
                btnCreateAccount.BackgroundImage = Properties.Resources.Thumbs_Down_Left;
                return false;
            }

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                btnCreateAccount.Enabled = false;
                if (ValidateValues() == false)
                {
                    btnCreateAccount.Enabled = false;
                    btnCreateAccount.BackgroundImage = Properties.Resources.Thumbs_Down_Left;
                    return;
                }

                UploadData();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show($"Failed to create Account due to the following reasons:\n{ex.Message}");
#endif
            }

        }



        private void UploadData()//Check if an Account exists
        {

            List<string> columns = new List<string>();
            Dictionary<string, string> conditions = new Dictionary<string, string>();
            Dictionary<string, string> columnsAndValues = new Dictionary<string, string>();

            string userName = txtUserName.Text;
            string password = globals.CreateSha256Hash(txtPassword1.Text);//Create Password Hash
            conditions.Add("UserName", userName);
            int count = data.Count("Users", conditions);

            if (count > 0)//Duplicate Found
            {
                eventsEnabled = false;//prevent event from executing while reseting control
                btnCreateAccount.Enabled = false;
                picWarning2.Visible = true;
                toolTip1.SetToolTip(picWarning2, "Duplicate Add attempt");
                btnCreateAccount.BackgroundImage = Properties.Resources.Thumbs_Down_Left;

                pnlMessage.Visible = true;
                pnlMessage.Dock = DockStyle.Fill;
                pnlMessage.BringToFront();
                lblWelcomeMessage.Text = $"Sorry the username {txtUserName.Text} already exists.\n Please create a new username or login.";

                txtUserName.Text = "";
                timer1.Enabled = true;//start 3 second clock
                Mode = 1;
                eventsEnabled = true; // allow event firing again
            }
            else//Add new user
            {
                columnsAndValues.Clear();
                columnsAndValues.Add("UserName", userName);
                columnsAndValues.Add("PasswordHash", password);
                columnsAndValues.Add("isActive", "1");

                data.Insert_Into("Users", columnsAndValues);
                globals.UserID = data.GetLastInsertID();//Store in Global variable required everywhere              
                pnlMessage.Visible = true;
                pnlMessage.Dock = DockStyle.Fill;
                pnlMessage.BringToFront();
                lblHeaderText.Text = $"Welcome {txtUserName.Text} ";
                lblWelcomeMessage.Text = "Your new account was created sucessfully.\nPlease login with your cedentials";
                timer1.Enabled = true;//start 3 second clock
                Mode = 0;
            }

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Mode == 1)//Display Error Message only
            {
                pnlMessage.Visible = false;
                timer1.Enabled = false;
                return;
            }
            timer1.Enabled = false;
            this.Close();
        }




    }
}
