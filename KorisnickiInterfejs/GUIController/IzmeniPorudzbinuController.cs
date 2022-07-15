using Common;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.Session;
using KorisnickiInterfejs.UserControls.Porudzbina;
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
    public class IzmeniPorudzbinuController
    {
        private UCIzmeniPorudzbinu uCIzmeniPorudzbinu;
        BindingList<StavkaPorudzbine> listaStavki = new BindingList<StavkaPorudzbine>();
        StavkaPorudzbine stv = new StavkaPorudzbine();
        Porudzbina porudzbina = new Porudzbina();
        public IzmeniPorudzbinuController(UCIzmeniPorudzbinu uCIzmeniPorudzbinu)
        {
            this.uCIzmeniPorudzbinu = uCIzmeniPorudzbinu;
        }
        internal void Init()
        {
            uCIzmeniPorudzbinu.DgvPorudzbine.DataSource = Communication.Instance.SendRequestGetResult<List<Porudzbina>>(Common.Operations.VratiSvePorudzbine);
            uCIzmeniPorudzbinu.CbLekovi.DataSource = Communication.Instance.SendRequestGetResult<List<Lek>>(Operations.VratiLekove);
            uCIzmeniPorudzbinu.CbDobavljac.DataSource = Communication.Instance.SendRequestGetResult<List<Dobavljac>>(Common.Operations.VratiDobavljace);
            uCIzmeniPorudzbinu.BtnPretraga.Click += Btn_Pretraga_Click;
            uCIzmeniPorudzbinu.BtnSacuvajIzmene.Click += Btn_Sacuvaj_CLick;
            uCIzmeniPorudzbinu.BtnUcitajStavku.Click += Btn_Stavke_Click;
            uCIzmeniPorudzbinu.BtnIzmeniStavku.Click += Btn_IzmeniStavku_Click;
            uCIzmeniPorudzbinu.BtnUcitajPorudbinu.Click += Btn_UcitajPorudzbinu_Click;
            uCIzmeniPorudzbinu.BtnIzmeniStavku.Enabled = false;
            uCIzmeniPorudzbinu.CbLekovi.SelectedIndexChanged += azurirajCenu;
            uCIzmeniPorudzbinu.TxtKolicina.TextChanged += azurirajCenu;
          
        }

        private void Btn_UcitajPorudzbinu_Click(object sender, EventArgs e)
        {
            
                popuni();
           
        }

        void ucitajStavke()
        {

        }
        private void Btn_IzmeniStavku_Click(object sender, EventArgs e)
        {
            stv = (StavkaPorudzbine)uCIzmeniPorudzbinu.DgvStavkaPorudzbine.CurrentRow.DataBoundItem;
            StavkaPorudzbine stavka = new StavkaPorudzbine();
            stavka.Porudzbina = new Porudzbina();
            try
            {
                stavka.Porudzbina.IdPorudzbina = Convert.ToInt32(uCIzmeniPorudzbinu.TxtPorudzbinaID.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Nije ucitana porudzbina");
                return;
            }
            if (!Validations.UserControllValidation.EmptyFieldValidation(uCIzmeniPorudzbinu.TxtKolicina))
            {
                return;
            }
            stavka.Rb = Convert.ToInt32(uCIzmeniPorudzbinu.TxtRb.Text);
            try
            {
                stavka.Kolicina = Convert.ToInt32(uCIzmeniPorudzbinu.TxtKolicina.Text);
            }
            catch (Exception)
            {

                return;
            }

            if (stavka.Kolicina <= 0)
            {
                uCIzmeniPorudzbinu.TxtKolicina.Text = "Moras uneti broj veci od nule!";
                uCIzmeniPorudzbinu.TxtKolicina.BackColor = Color.Red;
                return;
            }

            stavka.Lek = (Lek)uCIzmeniPorudzbinu.CbLekovi.SelectedItem;
            stavka.Cena = Double.Parse(uCIzmeniPorudzbinu.TxtCena.Text);
           listaStavki.Add(stavka);

            porudzbina.ListaStavki.Add(stavka);
            porudzbina.ListaStavki.Remove(stv);
            

        }

        private void Btn_Stavke_Click(object sender, EventArgs e)
        {
            porudzbina = (Porudzbina)uCIzmeniPorudzbinu.DgvPorudzbine.CurrentRow.DataBoundItem;
            uCIzmeniPorudzbinu.DgvStavkaPorudzbine.DataSource = porudzbina.ListaStavki;
            if (uCIzmeniPorudzbinu.DgvStavkaPorudzbine.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nisu ucitate stavke");
                return;
            }
            else
            {
            stv =(StavkaPorudzbine) uCIzmeniPorudzbinu.DgvStavkaPorudzbine.CurrentRow.DataBoundItem;
           /// uCIzmeniPorudzbinu.CbLekovi.DataSource = Communication.Instance.SendRequestGetResult <List<Lek>>(Operations.VratiLekove);
            uCIzmeniPorudzbinu.CbLekovi.SelectedItem = stv.Lek;
            uCIzmeniPorudzbinu.TxtPorudzbinaNaziv.Text = stv.Porudzbina.IdPorudzbina.ToString();
            uCIzmeniPorudzbinu.TxtRb.Text = stv.Rb.ToString();
            uCIzmeniPorudzbinu.TxtKolicina.Text = stv.Kolicina.ToString();
            uCIzmeniPorudzbinu.TxtCena.Text = stv.Cena.ToString();
            uCIzmeniPorudzbinu.CbLekovi.SelectedIndexChanged += azurirajCenu;
            uCIzmeniPorudzbinu.BtnIzmeniStavku.Enabled = true;
            }
           
        }

        private void azurirajCenu(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(uCIzmeniPorudzbinu.TxtKolicina.Text) && uCIzmeniPorudzbinu.CbLekovi.SelectedItem != null)
                {
                    Lek l = (Lek)uCIzmeniPorudzbinu.CbLekovi.SelectedItem;
                    int kolicina = int.Parse(uCIzmeniPorudzbinu.TxtKolicina.Text);
                    uCIzmeniPorudzbinu.TxtCena.Text = (kolicina * l.Cena).ToString();
                }
                else
                {
                    uCIzmeniPorudzbinu.TxtCena.Text = "0";
                }
            }
            catch (FormatException ex)
            {
                uCIzmeniPorudzbinu.TxtCena.Text = "0";
                MessageBox.Show("Greska! " + ex.Message);
                Debug.WriteLine(">>>" + ex.Message);
            }
        }
        private void azurirajCenuKolicinom(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(uCIzmeniPorudzbinu.TxtKolicina.Text))
                {
                    Lek l = (Lek)uCIzmeniPorudzbinu.CbLekovi.SelectedItem;
                    int kolicina = int.Parse(uCIzmeniPorudzbinu.TxtKolicina.Text);
                    uCIzmeniPorudzbinu.TxtCena.Text = (kolicina * l.Cena).ToString();
                }
                else
                {
                    uCIzmeniPorudzbinu.TxtCena.Text = "0";
                }
            }
            catch (FormatException ex)
            {
                uCIzmeniPorudzbinu.TxtCena.Text = "0";
                MessageBox.Show("Greska! " + ex.Message);
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        void pretrazi()
        {
            Porudzbina porudzbinaPretraga = new Porudzbina();
           
            
           if(!Validations.UserControllValidation.EmptyFieldValidation(uCIzmeniPorudzbinu.TxtPretraga))
            {
                MessageBox.Show("Sistem ne moze da pronadje porudzbine po zadatim vrednostima. ");
                return;
            }
            if (!Validations.UserControllValidation.DateValidation(uCIzmeniPorudzbinu.TxtPretraga))
            {
                
                return;
            }
                porudzbinaPretraga.Datum = DateTime.ParseExact(uCIzmeniPorudzbinu.TxtPretraga.Text, "dd.MM.yyyy", null);
              porudzbinaPretraga.Condition = $" p.Datum = '{porudzbinaPretraga.Datum}'";
           
            BindingList<Porudzbina> listaPorudzbina = new BindingList<Porudzbina>();

            listaPorudzbina=new BindingList<Porudzbina>( Communication.Instance.SendRequestGetResult<List<Porudzbina>>(Operations.NadjiPorudzbine, porudzbinaPretraga));
            if (listaPorudzbina.Count == 0)
            {
                 MessageBox.Show("Sistem ne moze da pronadje porudzbine po zadatim vrednostima. ");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je nasao porudzbine po zadatim vrednostima. ");

            }
           
                uCIzmeniPorudzbinu.DgvPorudzbine.DataSource = listaPorudzbina;
            
             


        }
        public void popuni()
        {
            try
            {
                porudzbina = (Porudzbina)uCIzmeniPorudzbinu.DgvPorudzbine.CurrentRow.DataBoundItem;

               
                Porudzbina p = new Porudzbina();
                p.IdPorudzbina = Convert.ToInt32(porudzbina.IdPorudzbina);
                p.Condition = $"PorudzbinaID={p.IdPorudzbina}";

                List<Porudzbina> listaPorudzbina = new List<Porudzbina>();

                p = Communication.Instance.SendRequestGetResult<Porudzbina>(Operations.UcitajPorudzbinu, p);
                if (uCIzmeniPorudzbinu.DgvPorudzbine.SelectedRows.Count == 0)
                {
                  
                    MessageBox.Show("Sistem ne moze da ucita porudzbinu. ");
                    return;
                }
                listaPorudzbina.Add(p);

                uCIzmeniPorudzbinu.DgvPorudzbine.DataSource = listaPorudzbina;
                uCIzmeniPorudzbinu.DgvStavkaPorudzbine.DataSource = p.ListaStavki;
                uCIzmeniPorudzbinu.TxtPorudzbinaID.Text = porudzbina.IdPorudzbina.ToString();
                uCIzmeniPorudzbinu.TxtDatum.Text = porudzbina.Datum.ToString("dd.MM.yyyy");
                uCIzmeniPorudzbinu.TxtCenaUkupno.Text = porudzbina.CenaUkupno.ToString();
                if (porudzbina.Status)
                {
                    uCIzmeniPorudzbinu.RbDa.Checked = true;
                }
                if (!porudzbina.Status)
                {
                    uCIzmeniPorudzbinu.RbNe.Checked = true;
                }
                uCIzmeniPorudzbinu.TxtApotekar.Text = $"{SessionData.Instance.Apotekar.ImeApotekara} {SessionData.Instance.Apotekar.ImeApotekara}";
                uCIzmeniPorudzbinu.CbDobavljac.SelectedItem = porudzbina.Dobavljac;
                listaStavki = porudzbina.ListaStavki;
              //  uCIzmeniPorudzbinu.DgvStavkaPorudzbine.DataSource = listaStavki;
                porudzbina = p;
                porudzbina.ListaStavki = p.ListaStavki;
                uCIzmeniPorudzbinu.DgvStavkaPorudzbine.DataSource = p.ListaStavki;
                MessageBox.Show("Sistem je ucitao porudzbinu. ");
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da ucita porudzbinu. ");
            }
        }
        void stavka()
        {
            int id = Convert.ToInt32(uCIzmeniPorudzbinu.TxtPorudzbinaID.Text);
            StavkaPorudzbine stavka = new StavkaPorudzbine();
            stavka.Condition = $"PorudzbinaID={id}";
            listaStavki = new BindingList<StavkaPorudzbine>(Communication.Instance.SendRequestGetResult<List<StavkaPorudzbine>>(Operations.VratiStavke, stavka));
            uCIzmeniPorudzbinu.DgvStavkaPorudzbine.DataSource = listaStavki;
        }

        private void Btn_Sacuvaj_CLick(object sender, EventArgs e)
        {
            if (!Validations.UserControllValidation.DateValidation(uCIzmeniPorudzbinu.TxtDatum))
            {
                return;
            }
            try
            {
                Porudzbina p = new Porudzbina();
                p.IdPorudzbina = Convert.ToInt32(uCIzmeniPorudzbinu.TxtPorudzbinaID.Text);
                p.Datum = DateTime.ParseExact(uCIzmeniPorudzbinu.TxtDatum.Text, "dd.MM.yyyy", null);
                p.CenaUkupno = Convert.ToDouble(uCIzmeniPorudzbinu.TxtCenaUkupno.Text);
                if (uCIzmeniPorudzbinu.RbDa.Checked)
                {
                    p.Status = true;
                }
                else if (uCIzmeniPorudzbinu.RbNe.Checked)
                {
                    p.Status = false;
                }
                p.CenaUkupno = listaStavki.Sum(x => x.Cena);
                p.Apotekar = SessionData.Instance.Apotekar;
                p.Dobavljac = (Dobavljac)uCIzmeniPorudzbinu.CbDobavljac.SelectedItem;
                p.ListaStavki = listaStavki;
                Communication.Instance.SendRequestNoResult(Common.Operations.IzmeniPorudzbinu, p);
                System.Windows.Forms.MessageBox.Show("Sistem je izmenio porudzbinu ");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Sistem ne moze da izmeni porudzbinu. ");
            }
        }

        private void Btn_Pretraga_Click(object sender, EventArgs e)
        {
            pretrazi();
          
        }
    }
}
