using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.Session;
using KorisnickiInterfejs.UserControls.Lek;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class IzmeniLekController
    {
        private UCIzmeniLek uCIzmeniLek;
        Lek l = new Lek();
        BindingList<Lek> listaLekova = new BindingList<Lek>();
        public IzmeniLekController(UCIzmeniLek uCIzmeniLek)
        {
            this.uCIzmeniLek = uCIzmeniLek;
        }
        internal void Init()
        {
            uCIzmeniLek.CbTipLeka.DataSource = Communication.Instance.SendRequestGetResult<List<TipLeka>>(Common.Operations.VratiTipoveLeka);
            uCIzmeniLek.CbProizvodjac.DataSource = Enum.GetValues(typeof(Proizvodjac));
            uCIzmeniLek.DataGridView1.DataSource = Communication.Instance.SendRequestGetResult<List<Lek>>(Common.Operations.VratiLekove);
            uCIzmeniLek.BtnPretraga.Click += btnPretraga_Click;
            uCIzmeniLek.BtnSacuvajIzmene.Click += btnSacuvaj_Click;
            uCIzmeniLek.BtnUcitajLek.Click += btnUcitajLek_Click;
        }

        private void btnUcitajLek_Click(object sender, EventArgs e)
        {
            izaberiLek();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            pretragaLeka();
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Validations.UserControllValidation.EmptyFieldValidation(uCIzmeniLek.TxtImeLeka) |
                !Validations.UserControllValidation.EmptyFieldValidation(uCIzmeniLek.TxtINN) |
                !Validations.UserControllValidation.EmptyFieldValidation(uCIzmeniLek.TxtFOLeka)|
                !Validations.UserControllValidation.EmptyFieldValidation(uCIzmeniLek.TxtCena) | 
                !Validations.UserControllValidation.IntValidation(uCIzmeniLek.TxtJKL) )
            {
                MessageBox.Show("Sistem ne moze da izmeni lek. ");
                return;
            }
            if(!Validations.UserControllValidation.ComboBoxValidation(uCIzmeniLek.CbProizvodjac)|
                !Validations.UserControllValidation.ComboBoxValidation(uCIzmeniLek.CbTipLeka))
            {
                MessageBox.Show("Sistem ne moze da izmeni lek. ");
                return;
            }

            try
            {
                Lek lek = new Lek();
                lek.SifraLeka = Convert.ToInt32(uCIzmeniLek.TxtSifraLeka.Text);
                lek.JKL = Convert.ToInt32(uCIzmeniLek.TxtJKL.Text);
                lek.ImeLeka = uCIzmeniLek.TxtImeLeka.Text;
                lek.INN = uCIzmeniLek.TxtINN.Text;
                lek.FOLeka = uCIzmeniLek.TxtFOLeka.Text;
                lek.Proizvodjac = uCIzmeniLek.CbProizvodjac.SelectedItem.ToString();
                lek.Cena = Convert.ToDouble(uCIzmeniLek.TxtCena.Text);
              
                lek.Apotekar = SessionData.Instance.Apotekar;
                lek.TipLeka = (TipLeka)uCIzmeniLek.CbTipLeka.SelectedItem;
                Communication.Instance.SendRequestNoResult(Common.Operations.IzmeniLek, lek);
                MessageBox.Show("Sistem je izmenio lek.");
            }
            catch (Exception s)
            {
                MessageBox.Show("Sistem ne moze da izmeni lek. "+s.Message);
            }
        }

        void pretragaLeka()
        {

            if (!Validations.UserControllValidation.EmptyFieldValidation(uCIzmeniLek.TxtPretraga))
            {
                MessageBox.Show("Sistem ne moze da nadje lekove po zadatim vrednostima.");
                return;
            }
          
            try
            {
                Lek lek = new Lek();
                lek.Condition = $"ImeLeka LIKE '{uCIzmeniLek.TxtPretraga.Text}%'";
                BindingList<Lek> listaLekovaPretraga = new BindingList<Lek>();
                listaLekovaPretraga = new BindingList<Lek>(Communication.Instance.SendRequestGetResult<List<Lek>>(Common.Operations.NadjiLekove, lek));
                if (listaLekovaPretraga.Count==0)
                {
                    MessageBox.Show("Sistem ne moze da nadje lekove po zadatim vrednostima. ");
                    return;
                }
                else
                {
                MessageBox.Show("Sistem je nasao lekove po zadatoj vrednosti. ");

                }
                uCIzmeniLek.DataGridView1.DataSource = listaLekovaPretraga;
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da nadje lekove po zadatim vrednostima. ");
            }
        }

        public void izaberiLek()
        {
            if (uCIzmeniLek.DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita lek");
                return;
            }
                l = (Lek)uCIzmeniLek.DataGridView1.CurrentRow.DataBoundItem;
          
           
            int sifra = l.SifraLeka;
            Lek lek = new Lek();
          
            lek.Condition = $"SifraLeka={sifra}";
            lek = Communication.Instance.SendRequestGetResult<Lek>(Common.Operations.UcitajLek, lek);
            uCIzmeniLek.TxtSifraLeka.Text = lek.SifraLeka.ToString();
            uCIzmeniLek.TxtJKL.Text = lek.JKL.ToString();
            uCIzmeniLek.TxtImeLeka.Text = lek.ImeLeka.ToString();
            uCIzmeniLek.TxtINN.Text = lek.INN.ToString();
            uCIzmeniLek.TxtFOLeka.Text = lek.FOLeka.ToString();
            uCIzmeniLek.CbProizvodjac.SelectedItem = lek.Proizvodjac;
            uCIzmeniLek.TxtCena.Text = lek.Cena.ToString();
            uCIzmeniLek.CbTipLeka.SelectedItem = lek.TipLeka;
            MessageBox.Show("Sistem je ucitao lek. ");
        }
    }
}
