using SQLiteClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Steamroller_Financial_Application
{
    public partial class frmAccount : Form
    {
        private SQLiteCRUD data;//Refrence to Database Instance from Main Form
        private GlobalDataAndFunctions globals;
        Dictionary<string, string> columnNames = new Dictionary<string, string>();
        private int acctType;
        private string Logo;

        public frmAccount(SQLiteCRUD db, GlobalDataAndFunctions globalData)
        {
            InitializeComponent();
            data = db;
            globals = globalData;
            picLogo.AllowDrop = true;

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Logo_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    Logo = fileName;
                    picLogo.Image = Image.FromFile(file);
                    if (!string.IsNullOrEmpty(txtNickName.Text))
                    {
                        string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        string targetPath = Path.Combine(exePath, "Steamroller Financial Assistant", "User Defined Resources", "Images", "Accounts");

                        string accountType = acctType == 1 ? "Checking_" : "Saving_";

                        Directory.CreateDirectory(targetPath);

                        string desiredFileName = $"{accountType}{txtNickName.Text}_{fileName}";

                        string targetFile = Path.Combine(targetPath, desiredFileName);

                        if (File.Exists(targetFile))// Check for duplicate add atempt, overwrite existing as it my be better quality.
                        {
                            File.Delete(targetFile);
                        }

                        // Copy the file
                        File.Copy(file, targetFile, true);

                        columnNames["Image"] = targetFile;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Logo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        private void picSavings_Click(object sender, EventArgs e)
        {
            lblHilighter.Visible = true;
            lblHilighter.Location = new Point(picAccountType_Savings.Location.X - 5, picAccountType_Savings.Location.Y - 5);
            acctType = 2;
        }


        private void picChecking_Click(object sender, EventArgs e)
        {
            lblHilighter.Visible = true;
            lblHilighter.Location = new Point(picAccountType_Checking.Location.X - 5, picAccountType_Checking.Location.Y - 5);
            acctType = 1;
        }


        private void trackBarLogoResize_Scroll(object sender, EventArgs e)
        {
            if (trackBarLogoResize.Value > 0) { picLogo.SizeMode = PictureBoxSizeMode.StretchImage; }
            else { picLogo.SizeMode = PictureBoxSizeMode.Zoom; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            columnNames.Add("AccountsTypesID", acctType.ToString());
            columnNames.Add("NIckName", txtNickName.Text);
            columnNames.Add("Balance", txtStartingBalance.Text);
            columnNames.Add("BankName", txtBankName.Text);
            columnNames.Add("AcctNumber", txtLast6AccountNumber.Text);
            columnNames.Add("Image", Logo);
            columnNames.Add("BudgetID", globals.BudgetID);

            data.Insert_Into("Accounts", columnNames);

        }
    }
}
