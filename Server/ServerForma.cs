using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForma : Form
    {
        private Server s;
        public ServerForma()
        {
            InitializeComponent();
            btnZaustavi.Enabled = false;
            btnPokreni.Enabled = true;
            this.FormClosed += ServerForma_FormClosed;
        }
        private void ServerForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnPokreni_Click(object sender, EventArgs e)
        {
                s = new Server();
                if (s.Start())
                {
                btnZaustavi.Enabled = true;
                btnPokreni.Enabled = false;
                Thread nit = new Thread(s.Listen);
                MessageBox.Show("Pokrenut server!");
                nit.IsBackground = true;
                 nit.Start();
                 }
                 else
                 {
                 MessageBox.Show("Server nije pokrenut");
                }
        }
        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            s?.Stop();
            s = null;
            btnZaustavi.Enabled = false;
            btnPokreni.Enabled = true;
            MessageBox.Show("Server je zaustavljen");
        }
        private void ServerForma_Load(object sender, EventArgs e)
        { 
           
        }

       
    }
}
