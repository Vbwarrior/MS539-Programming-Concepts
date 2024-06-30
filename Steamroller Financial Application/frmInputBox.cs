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
    public partial class frmInputBox : Form
    {

        public enum Style
        {
            Small = 0,
            Medium = 1,
            Large = 2
        }

        public enum Mode
        {
            TextBox = 0,
            ComboBox = 1,
            OkButtonOnly = 2,
            OkCancel = 3,
            YesNo = 4

        }

        private GlobalDataAndFunctions globals;
        Control UserInput = null;
        Button btnOk = null;
        Button btnCancel1 = null;

        public string ReturnValue { get; set; }


        public frmInputBox(GlobalDataAndFunctions globalData, string message, Style style = Style.Small, Mode mode = 0)
        {
            InitializeComponent();

            globals = globalData;
            lblMessage.Text = message;
            SetControlsByMode(mode);
            SizeByStyle(ref style);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Assuming userInput is a Control object that can be TextBox, ComboBox, or Button
            if (UserInput is TextBox)
            {
                this.ReturnValue = ((TextBox)UserInput).Text;
            }
            else if (UserInput is ComboBox)
            {
                this.ReturnValue = ((ComboBox)UserInput).SelectedItem.ToString();
            }
            else if (UserInput is Button)
            {
                this.ReturnValue = ((Button)UserInput).Text;
            }

            if (string.IsNullOrEmpty(ReturnValue))
            {
                this.ReturnValue = "Not Set";
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }


        private void SizeByStyle(ref Style style)
        {
            if (style == Style.Small)
            {
                pnlHeader.Height = 50;
                lblMessage.Font = new Font("Ink Free", 18f, FontStyle.Bold);

                UserInput.Width = 228;
                UserInput.Location = new Point(48, 71);
                UserInput.Font = new Font("Segoe UI", 20f, FontStyle.Regular);

                btnOk.Location = new Point(142, 136);
                btnOk.Size = new System.Drawing.Size(40, 40);

                this.Size = new System.Drawing.Size(325, 201);

            }
            else if (style == Style.Medium)
            {
                pnlHeader.Height = 100;
                lblMessage.Font = new Font("Ink Free", 26f, FontStyle.Bold);

                UserInput.Width = 328;
                UserInput.Location = new Point(113, 161);
                UserInput.Font = new Font("Segoe UI", 20f, FontStyle.Regular);

                btnOk.Location = new Point(251, 237);
                btnOk.Size = new System.Drawing.Size(52, 52);

                this.Size = new System.Drawing.Size(554, 324);
            }
            else if (style == Style.Large)
            {
                pnlHeader.Height = 100;
                lblMessage.Font = new Font("Ink Free", 26f, FontStyle.Bold);

                UserInput.Width = 428;
                UserInput.Location = new Point(159, 189);
                UserInput.Font = new Font("Segoe UI", 20f, FontStyle.Regular);

                btnOk.Location = new Point(315, 295);
                btnOk.Size = new System.Drawing.Size(116, 116);

                this.Size = new System.Drawing.Size(747, 464);
            }


            // Center txtUserInput
            UserInput.Left = this.ClientSize.Width / 2 - txtUserInput.Size.Width / 2;
            btnAccept.Left = this.ClientSize.Width / 2 - btnAccept.Size.Width / 2;

        }

        private void SetControlsByMode(Mode mode)
        {

            switch (mode)
            {
                case Mode.TextBox:
                    txtUserInput.Visible = true;
                    cmbDataSelection.Visible = false;
                    UserInput = txtUserInput;
                    btnOk = btnAccept;
                    // Set properties for TextBox
                    break;
                case Mode.ComboBox:
                    txtUserInput.Visible = false;
                    cmbDataSelection.Visible = true;
                    cmbDataSelection.Items.AddRange(globals.DataList.ToArray());
                    UserInput = cmbDataSelection;
                    btnOk = btnAccept;

                    break;
                case Mode.OkButtonOnly:
                    btnOk = btnAccept;
                    // Set properties for Ok Button


                    break;
                case Mode.OkCancel:
                    btnOk = new Button();
                    btnCancel1 = new Button();
                    // Set properties for Ok and Cancel Buttons
                    break;
                case Mode.YesNo:
                    btnOk = new Button();
                    btnCancel = new Button();
                    // Set properties for Yes and No Buttons
                    break;
                default:
                    throw new Exception("Invalid mode");
            }

            // Add the control to the form or container
            if (UserInput != null)
                this.Controls.Add(UserInput);
            if (btnOk != null)
                this.Controls.Add(btnOk);
            if (btnCancel1 != null)
                this.Controls.Add(btnCancel);

        }

        private void frmInputBox_Load(object sender, EventArgs e)
        {

        }
    }
}
