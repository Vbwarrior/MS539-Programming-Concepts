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
    public partial class InputBox : Form
    {
        public string ReturnValue { get; set; }

       
        public InputBox( string message)
        {
            InitializeComponent();
          
            lblMessage.Text = message;
        }
          
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.ReturnValue = txtUserInput.Text;
            if (string.IsNullOrEmpty(ReturnValue)) { this.ReturnValue = "Budget_1"; }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
