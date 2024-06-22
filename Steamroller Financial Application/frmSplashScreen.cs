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
    public partial class frmSplashScreen : Form
    {
        private SQL_Database data;//Refrence to Database Instance from Main Form
        private GlobalDataAndFunctions globals;
        bool flag = false;

        public frmSplashScreen(SQL_Database db, GlobalDataAndFunctions globalData)
        {
            InitializeComponent();
            data = db;
            globals = globalData;

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
//#if DEBUG
//            this.Close();
//#endif
string userName = txtUserName.Text;
            string password = txtPassword.Text;






        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            //toDo Setup new User
        }
    }
}
