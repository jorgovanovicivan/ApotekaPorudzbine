using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.UserControls.Lek
{
    public partial class UCNoviLek : UserControl
    {
        DodajNoviLekController controller;
        public UCNoviLek()
        {
            InitializeComponent();
            controller = new DodajNoviLekController(this);
            controller.Init();
            
        }

        private void UCNoviLek_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbTipLeka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProizvodjac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFOLeka_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtINN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtJKL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImeLeka_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
