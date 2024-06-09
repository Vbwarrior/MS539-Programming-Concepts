using System.Windows.Forms;

namespace Steamroller_Financial_Application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(ApplicationExceptionHandler);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }

        static void ApplicationExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            frmMain frm = new frmMain();
            Exception e = (Exception)args.ExceptionObject;
            if (frm.InvokeRequired)
            {
                frm.Invoke(new Action(() =>
                {
                    frm.pnlerrorPanel.Visible = true;
                    frm.pnlerrorPanel.Size = new Size(803, 572);
                    frm.pnlerrorPanel.BringToFront();
                    frm.errorPanelLabel.Text = e.Message;
                }));
            }
            else
            {
                frm.pnlerrorPanel.Visible = true;
                frm.pnlerrorPanel.Size = new Size(803, 572);
                frm.pnlerrorPanel.BringToFront();
                frm.errorPanelLabel.Text = e.Message;
            }

            frm.Center_Object(frm.pnlerrorPanel,EventArgs.Empty);

        }

    }
}