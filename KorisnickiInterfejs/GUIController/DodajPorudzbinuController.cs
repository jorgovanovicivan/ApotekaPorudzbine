using Common;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class DodajPorudzbinuController
    {
        private Porudzbina p = new Porudzbina();
        private BindingList<StavkaPorudzbine> listaStavki = new BindingList<StavkaPorudzbine>();
        UCPorudzbina porudzbina;
        public DodajPorudzbinuController(UCPorudzbina porudzbina)
        {
            this.porudzbina = porudzbina;
        }

        internal void init()
        {
            porudzbina.CbDovavljac.DataSource = Communication.Instance.SendRequestGetResult<List<Dobavljac>>(Operations.VratiDobavljace);
            porudzbina.CbListaLekova.DataSource = Communication.Instance.SendRequestGetResult<List<Lek>>(Operations.VratiLekove);
            porudzbina.BtnDodaj.Click += btnDodaj_Click;
            porudzbina.BtnObrisiRed.Click += btnObrisi_Click;
            porudzbina.BtnSacuvajPorudzbinu.Click += btnSacuvajPorudzbinu_Click;
            porudzbina.DgvListaStavki.DataSource = listaStavki;
            porudzbina.CbListaLekova.SelectedIndexChanged += azurirajCenu;
            porudzbina.TxtKolicina.TextChanged += azurirajCenu;
        }

        private void azurirajCenu(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(porudzbina.TxtKolicina.Text) && porudzbina.CbListaLekova.SelectedItem != null)
                {
                    Lek l = (Lek)porudzbina.CbListaLekova.SelectedItem;
                    int kolicina = int.Parse(porudzbina.TxtKolicina.Text);
                    porudzbina.TxtCena.Text = (kolicina * l.Cena).ToString();
                }
                else
                {
                    porudzbina.TxtCena.Text = "0";
                }
            }
            catch (FormatException ex)
            {
                porudzbina.TxtCena.Text = "0";
                MessageBox.Show("Greska! " + ex.Message);
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        private void btnSacuvajPorudzbinu_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!Validations.UserControllValidation.DateValidation(porudzbina.TxtDatum))
                {
                    MessageBox.Show("Sistem je ne moze da zapamti porudzbinu.");
                    return;
                }
                if (!Validations.UserControllValidation.ComboBoxValidation(porudzbina.CbDovavljac))
                {
                    MessageBox.Show("Sistem je ne moze da zapamti porudzbinu.");
                    return;
                }

                p.Datum = DateTime.ParseExact(porudzbina.TxtDatum.Text, "dd.MM.yyyy", null);
                if (p.Datum < DateTime.Now)
                {
                    MessageBox.Show("Ne sme u proslosti datum");
                    return;
                }
                if (listaStavki == null)
                {
                    MessageBox.Show("Sistem je ne moze da zapamti porudzbinu.");
                    return;
                }
                p.ListaStavki = listaStavki;
                if (p.ListaStavki.Count == 0)
                {
                    MessageBox.Show("Mora bar jedna stavka biti u porudzbini");
                    return;
                }
                //if (!Validations.UserControllValidation.DoubleValidation(porudzbina.TxtCenaUkupno))
                //{
                //    MessageBox.Show("Sistem je ne moze da zapamti porudzbinu.");
                //    return;
                //}
                p.CenaUkupno = Convert.ToDouble(porudzbina.TxtCenaUkupno.Text);
                if (porudzbina.RbDa.Checked)
                {
                    p.Status = true;

                }
                else if (porudzbina.RbNe.Checked)
                {
                    p.Status = false;
                }
                if (!porudzbina.RbDa.Checked && !porudzbina.RbNe.Checked)
                {
                    MessageBox.Show("Morate cekirti status");
                    return;

                }
                p.Apotekar = SessionData.Instance.Apotekar;
                p.Dobavljac = (Dobavljac)porudzbina.CbDovavljac.SelectedItem;
                Communication.Instance.SendRequestNoResult(Operations.SacuvajPorudzbini, p);
                MessageBox.Show("Sistem je zapamtio porudzbinu.");
               
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem je ne moze da zapamti porudzbinu.");
            }
        }
       
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            StavkaPorudzbine s = new StavkaPorudzbine();
            s.Porudzbina = p;
            if (!Validations.UserControllValidation.IntValidation(porudzbina.TxtKolicina) && !Validations.UserControllValidation.EmptyFieldValidation(porudzbina.TxtKolicina))
            {
                return;
            }
            if (!Validations.UserControllValidation.ComboBoxValidation(porudzbina.CbListaLekova))
            {
                return;
            }
           
            if (p == null)
            {
                return;
            }
            s.Rb = listaStavki.Count + 1;


            try
            {
                s.Kolicina = int.Parse(porudzbina.TxtKolicina.Text);
            }
            catch (Exception)
            {

                return;
            }
            if (s.Kolicina <= 0)
            {
                porudzbina.TxtKolicina.Text = "Moras uneti broj veci od nule jer ne moze biti kolicina negativna";
                porudzbina.TxtKolicina.BackColor = Color.Red;
                return;
            }
          
            s.Lek = (Lek)porudzbina.CbListaLekova.SelectedItem;
            s.Cena = Double.Parse(porudzbina.TxtCena.Text);
            listaStavki.Add(s);
            porudzbina.TxtCenaUkupno.Text = listaStavki.Sum(x => x.Cena).ToString();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (porudzbina.DgvListaStavki.SelectedRows.Count == 0)
            {
                return;
            }
            StavkaPorudzbine stavka = (StavkaPorudzbine)porudzbina.DgvListaStavki.CurrentRow.DataBoundItem;
            
            listaStavki.Remove(stavka);
            int rb = 1;
            foreach(StavkaPorudzbine s in listaStavki)
            {
                s.Rb = rb;
                rb++;
            }

        }

    }
}
