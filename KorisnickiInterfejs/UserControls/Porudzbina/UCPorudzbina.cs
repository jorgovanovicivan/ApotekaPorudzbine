using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public partial class UCPorudzbina : UserControl
    {
        DodajPorudzbinuController controller;
        public UCPorudzbina()
        {
            InitializeComponent();
            controller = new DodajPorudzbinuController(this);
            controller.init();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UCPorudzbina_Load(object sender, EventArgs e)
        {



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
