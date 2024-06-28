using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteClassLib;
namespace Steamroller_Financial_Application
{
    public partial class frmTransfer : Form
    {
        private SQLiteCRUD data;//Refrence to Database Instance from Main Form
        private GlobalDataAndFunctions globals;
        public frmTransfer(SQLiteCRUD db, GlobalDataAndFunctions globalData)
        {
            InitializeComponent();
            data = db;
            globals = globalData;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
