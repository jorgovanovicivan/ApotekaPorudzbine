using KorisnickiInterfejs.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                try
                {
                    LoginForma frmLogin = new LoginForma();
                    frmLogin.ShowDialog();
                    DialogResult result = frmLogin.DialogResult;
                    frmLogin.Dispose();

                    if (result == DialogResult.OK)
                    {
                        Application.Run(new MainForma());
                    }
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Greska pri radu sa serverom!");
                }
            }

        }
    }
}
