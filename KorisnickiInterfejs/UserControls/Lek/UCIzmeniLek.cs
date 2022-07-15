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
    public partial class UCIzmeniLek : UserControl
    {
        IzmeniLekController controller;
        public UCIzmeniLek()
        {
            InitializeComponent();
            controller = new IzmeniLekController(this);
            controller.Init();
        }
        private void UCIzmeniLek_Load(object sender, EventArgs e)
        {

        }
    }
}
