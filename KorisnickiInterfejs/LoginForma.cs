using Domain;
using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class LoginForma : Form
    {
        LoginController loginController;
        public LoginForma()
        {
            InitializeComponent();
            loginController = new LoginController();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void LoginForma_Load(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            loginController.Login(this);
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
