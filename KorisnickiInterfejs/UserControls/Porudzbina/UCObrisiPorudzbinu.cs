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

namespace KorisnickiInterfejs.UserControls.Porudzbina
{
    public partial class UCObrisiPorudzbinu : UserControl

    {
        ObrisiPorudzbinuController controller;
        public UCObrisiPorudzbinu()
        {
            InitializeComponent();
            controller = new ObrisiPorudzbinuController(this);
            controller.Init();
        }

        public object DgvStavkaPorudzbine { get; internal set; }
    }
}
