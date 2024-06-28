using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Steamroller_Financial_Application
{
    public partial class InputBox : Form
    {

        public enum Style
        {
            Small = 0,
            Medium = 1,
            Large = 2
        }

        public string ReturnValue { get; set; }


        public InputBox(string message, Style style = Style.Small)
        {
            InitializeComponent();

            lblMessage.Text = message;
            SizeByStyle(ref style);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.ReturnValue = txtUserInput.Text;
            if (string.IsNullOrEmpty(ReturnValue)) { this.ReturnValue = "Budget_1"; }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void SizeByStyle( ref Style style)
        {
            if (style == Style.Small)
            {
                pnlHeader.Height = 50;
                lblMessage.Font = new Font("Ink Free", 18f, FontStyle.Bold);

                txtUserInput.Width = 228;
                txtUserInput.Location = new Point(48, 71);
                txtUserInput.Font = new Font("Segoe UI", 20f, FontStyle.Regular);

                btnAccept.Location = new Point(136, 119);
                btnAccept.Size = new System.Drawing.Size(40, 40);

                this.Size = new System.Drawing.Size(325, 201);

            }
            else if (style == Style.Medium)
            {
                pnlHeader.Height = 100;
                lblMessage.Font = new Font("Ink Free", 26f, FontStyle.Bold);

                txtUserInput.Width = 328;
                txtUserInput.Location = new Point(113, 161);                
                txtUserInput.Font = new Font("Segoe UI", 20f, FontStyle.Regular);      
                
                btnAccept.Location = new Point(251, 237);
                btnAccept.Size = new System.Drawing.Size(52, 52);

                this.Size = new System.Drawing.Size(554, 324);
            }
            else if (style == Style.Large)
            {
                pnlHeader.Height = 100;
                lblMessage.Font = new Font("Ink Free", 26f, FontStyle.Bold);
                
                txtUserInput.Width = 428;
                txtUserInput.Location = new Point(159, 191);
                txtUserInput.Font = new Font("Segoe UI", 20f, FontStyle.Regular);

                btnAccept.Location = new Point(315, 295);
                btnAccept.Size = new System.Drawing.Size(116, 116);
              
                this.Size = new System.Drawing.Size(747, 464);
            }


            // Center txtUserInput
            txtUserInput.Left = this.ClientSize.Width / 2 - txtUserInput.Size.Width / 2;

            btnAccept.Left = this.ClientSize.Width / 2 - btnAccept.Size.Width / 2;

        }

       
    }
}
