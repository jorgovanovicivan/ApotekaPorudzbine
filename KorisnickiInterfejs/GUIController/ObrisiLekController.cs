using Domain;
using KorisnickiInterfejs.ServerCommunication;
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
    public class ObrisiLekController
    {
        private UCObrisiLek uCObrisiLek;
        Lek l = new Lek();
        public ObrisiLekController(UCObrisiLek uCObrisiLek)
        {
            this.uCObrisiLek = uCObrisiLek;

        }

        internal void Init()
        {

            uCObrisiLek.DgvLekovi.DataSource = Communication.Instance.SendRequestGetResult<List<Lek>>(Common.Operations.VratiLekove);
            uCObrisiLek.CbTipLeka.DataSource = Communication.Instance.SendRequestGetResult<List<TipLeka>>(Common.Operations.VratiTipoveLeka);
            uCObrisiLek.CbProizvodjac.DataSource = Enum.GetValues(typeof(Proizvodjac));
            uCObrisiLek.BtnPretraga.Click += BtnPretraga_Click;
            uCObrisiLek.BtnUcitajLek.Click += BtnUcitajLek_Click;
            uCObrisiLek.BtnObrisi.Click += BtnObrisiLek_Click;
        }

        private void BtnObrisiLek_Click(object sender, EventArgs e)
        {
            try
            {
                l.SifraLeka = Convert.ToInt32(uCObrisiLek.TxtSifraLeka.Text);
                l.Condition = $"SifraLeka={l.SifraLeka}";
                Communication.Instance.SendRequestNoResult(Common.Operations.ObrisiLek, l);
                MessageBox.Show("Sistem je obrisao lek. ");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da obrise lek.");
            }
        }

        private void BtnUcitajLek_Click(object sender, EventArgs e)
        {

            if (uCObrisiLek.DgvLekovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita lek.");
                return;
            }
            l= (Lek)uCObrisiLek.DgvLekovi.CurrentRow.DataBoundItem;
 
            Lek lek = new Lek();
           
            lek.Condition = $" l.SifraLeka={l.SifraLeka}";
            lek = Communication.Instance.SendRequestGetResult<Lek>(Common.Operations.UcitajLek, lek);
            if (lek == null)
            {
                MessageBox.Show("Sistem ne moze da ucita lek");
                return;
            }
            uCObrisiLek.TxtSifraLeka.Text = lek.SifraLeka.ToString();
            uCObrisiLek.TxtJKL.Text = lek.JKL.ToString();
            uCObrisiLek.TxtImeLeka.Text = lek.ImeLeka.ToString();
            uCObrisiLek.TxtINN.Text = lek.INN.ToString();
            uCObrisiLek.TxtFOLeka.Text = lek.FOLeka.ToString();
            uCObrisiLek.CbProizvodjac.SelectedItem = lek.Proizvodjac;
            uCObrisiLek.TxtCena.Text = lek.Cena.ToString();
            uCObrisiLek.CbTipLeka.SelectedItem = lek.TipLeka;
            MessageBox.Show("Sistem je ucitao lek. ");
        }

        private void BtnPretraga_Click(object sender, EventArgs e)
        {
            if (!Validations.UserControllValidation.EmptyFieldValidation(uCObrisiLek.TxtPretraga))
            {
                MessageBox.Show("Sistem ne moze da nadje lekove po zadatim vrednostima.");
                return;
            }

            
                BindingList<Lek> listaLekovaPretraga = new BindingList<Lek>();
                Lek lek = new Lek();
                lek.Condition = $"ImeLeka LIKE '{uCObrisiLek.TxtPretraga.Text}%'";

                listaLekovaPretraga = new BindingList<Lek>(Communication.Instance.SendRequestGetResult<List<Lek>>(Common.Operations.NadjiLekove, lek));
                if (listaLekovaPretraga.Count == 0)
                {
                    MessageBox.Show("Sistem ne moze da nadje lekove po zadatim vrednostima.");
                    return;
                }
                else
                {

                MessageBox.Show("Sistem je nasao lekove po zadatoj vrednosti. ");
                }
                uCObrisiLek.DgvLekovi.DataSource = listaLekovaPretraga;
            }
           

        }
    }
