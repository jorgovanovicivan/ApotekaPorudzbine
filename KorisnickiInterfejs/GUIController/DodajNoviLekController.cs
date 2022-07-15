using AplicationLogic;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.Session;
using KorisnickiInterfejs.UserControls.Lek;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KorisnickiInterfejs.GUIController
{
  public  class DodajNoviLekController
    {
        UCNoviLek unosNovogLeka;
      
        public DodajNoviLekController(UCNoviLek unosNovogLeka)
        {
            this.unosNovogLeka = unosNovogLeka;
        }

        internal void Init()
        {
            unosNovogLeka.CbTipLeka.DataSource = Communication.Instance.SendRequestGetResult<List<TipLeka>>(Common.Operations.VratiTipoveLeka);
            unosNovogLeka.CbProizvodjac.DataSource = Enum.GetValues(typeof(Proizvodjac));
            unosNovogLeka.BtnDOdajLek.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {

         if(  ! Validations.UserControllValidation.EmptyFieldValidation(unosNovogLeka.TxtCena)|
                !Validations.UserControllValidation.EmptyFieldValidation(unosNovogLeka.TxtImeLeka) |
                !Validations.UserControllValidation.EmptyFieldValidation(unosNovogLeka.TxtJKL) |
                !Validations.UserControllValidation.EmptyFieldValidation(unosNovogLeka.TxtFOLeka)|
                 !Validations.UserControllValidation.EmptyFieldValidation(unosNovogLeka.TxtINN))
            {
                MessageBox.Show("Sistem ne moze da zapamti lek.");
                return;
            }

            if (!Validations.UserControllValidation.DoubleValidation(unosNovogLeka.TxtCena))
            {
                return;
            }

            if(!Validations.UserControllValidation.ComboBoxValidation(unosNovogLeka.CbProizvodjac)| !Validations.UserControllValidation.ComboBoxValidation(unosNovogLeka.CbTipLeka))
            {
                return;
            }
            try
            {
                Lek lek = new Lek();
                lek.ImeLeka = unosNovogLeka.TxtImeLeka.Text;
                try
                {
                    lek.JKL = Convert.ToInt32(unosNovogLeka.TxtJKL.Text);
                }
                catch (Exception)
                {

                    return;
                }
                if (!Validations.UserControllValidation.jklValidation(unosNovogLeka.TxtJKL))
                {
                    return;
                }
                lek.INN = unosNovogLeka.TxtINN.Text;
                lek.FOLeka = unosNovogLeka.TxtFOLeka.Text;
                lek.Proizvodjac = unosNovogLeka.CbProizvodjac.SelectedItem.ToString();
                try
                {
                    lek.Cena = Double.Parse(unosNovogLeka.TxtCena.Text);
                }
                catch (Exception)
                {

                    return;
                }
                if (lek.Cena <= 0)
                {
                    unosNovogLeka.TxtCena.Text = "Moratte uneti broj veci od nule";
                    unosNovogLeka.TxtCena.BackColor = Color.LightCoral;
                    return ;
                }
                lek.Apotekar = SessionData.Instance.Apotekar;
                lek.TipLeka = (TipLeka)unosNovogLeka.CbTipLeka.SelectedItem;


              
                Communication.Instance.SendRequestNoResult(Common.Operations.DodajLek, lek);
                MessageBox.Show("Sistem je zapamtio lek.");
            }
            catch (Exception ed)
            {
                MessageBox.Show("Sistem ne moze da zapamti lek."+ed.Message);
            }
        }
    }
}
