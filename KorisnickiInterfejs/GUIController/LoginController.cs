using Domain;
using KorisnickiInterfejs.Exeptions;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.Session;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class LoginController
    {
        Apotekar Apotekar { get; set; }
        internal void Login(LoginForma loginForma)
        {
            String korisnickoIme = loginForma.TxtKorisnickoIme.Text;
            String lozinka = loginForma.TxtLozinka.Text;
            if (string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(lozinka))
            {
                loginForma.TxtKorisnickoIme.BackColor = Color.Salmon;
                loginForma.TxtLozinka.BackColor = Color.Salmon;
                return;
            }
            try
            {
                Apotekar apotekar = new Apotekar()
                {
                KorisnickoIme = korisnickoIme,
                Lozinka = lozinka
                };

                Communication.Instance.Connect();

               SessionData.Instance.Apotekar= Communication.Instance.SendRequestGetResult<Apotekar>(Common.Operations.Login, apotekar);
                if (SessionData.Instance.Apotekar != null)
                {
                    MessageBox.Show("Sistem je uspesno prijavio zaposslenog.");
                   loginForma.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da prijavi zaposlenog.");
                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greska pri radu sa serverom!");
            }

        }
    }
}
