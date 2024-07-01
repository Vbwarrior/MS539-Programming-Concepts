using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using SQLiteClassLib;

namespace Steamroller_Financial_Application
{

    public partial class frmIncome : Form
    {
        private SQLiteCRUD data;//Refrence to Database Instance from Main Form
        private GlobalDataAndFunctions globals;
        // private Dictionary<string, string> conditions = new Dictionary<string, string>();
        private Dictionary<string, string> columnsAndValues = new Dictionary<string, string>();
        private string BudgetID;
        public frmIncome(SQLiteCRUD db, GlobalDataAndFunctions globalData)
        {
            InitializeComponent();
            data = db;
            globals = globalData;

            BudgetID = data.SelectString("BudgetID", "Budgets", globals.UserID.ToString());

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSavings_Click(object sender, EventArgs e)
        {
            UploadData();

        }

        private void picChecking_Click(object sender, EventArgs e)
        {
            UploadData();
        }

        private void UploadData()
        {
            columnsAndValues.Add("BudgetID", BudgetID);
            columnsAndValues.Add("TransactionTypeID", "1");
            columnsAndValues.Add("CategoryID", "0");
            columnsAndValues.Add("SubGroupID", "99");
            columnsAndValues.Add("Amount", txtAmount.Text);
            columnsAndValues.Add("VendorName", txtNameOfEmployer.Text);
            columnsAndValues.Add("TransactionDate", DateTime.Now.ToString("MM/dd/yyyy"));

            data.Insert_Into("Transactions", columnsAndValues);
            MessageBox.Show("Income Recorded");
            this.Close();
        }

    }
}
