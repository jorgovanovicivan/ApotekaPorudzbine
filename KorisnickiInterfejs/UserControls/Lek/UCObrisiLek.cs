using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicationLogic;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.UserControls.Lek
{
    public partial class UCObrisiLek : UserControl
    {
        ObrisiLekController controller;
        public UCObrisiLek()
        {
            InitializeComponent();
            controller = new ObrisiLekController(this);
            controller.Init();

        }
    }
}
