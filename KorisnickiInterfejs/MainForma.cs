using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls.Lek;
using KorisnickiInterfejs.UserControls.Porudzbina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class MainForma : Form
    {
        public MainForma()
        {
            InitializeComponent();
        }

        private void unosNovogLekaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCNoviLek());
        }


        private void ChangePanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }

        private void MainForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Communication.Instance.CloseConnection();
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>>> FormClosed event >>>>>" + ex.Message);
            }
        }

        private void unosNovePorudzbineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCPorudzbina());
        }

        private void brisanjePorudzbineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCObrisiPorudzbinu());
        }

        private void izmenaLekaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCIzmeniLek());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void izmenaPorudzbineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCIzmeniPorudzbinu());
        }

        private void brisanjeLekaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCObrisiLek());
        }

        private void MainForma_Load(object sender, EventArgs e)
        {

        }
    }
}
