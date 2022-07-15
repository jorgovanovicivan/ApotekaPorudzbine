using Common;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.Session;
using KorisnickiInterfejs.UserControls.Porudzbina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.GUIController
{
    public class ObrisiPorudzbinuController
    {
        private UCObrisiPorudzbinu uCObrisiPorudzbinu;
        BindingList<StavkaPorudzbine> listaStavki = new BindingList<StavkaPorudzbine>();
        StavkaPorudzbine stv = new StavkaPorudzbine();
        Porudzbina p = new Porudzbina();
        BindingList<Porudzbina> listaPorudzbina = new BindingList<Porudzbina>();
        public int Btn_UcitajPorudzbinu_Click { get; private set; }

        public ObrisiPorudzbinuController(UCObrisiPorudzbinu uCObrisiPorudzbinu)
        {
            this.uCObrisiPorudzbinu = uCObrisiPorudzbinu;
        }

        internal void Init()
        {
            uCObrisiPorudzbinu.DgvPorudzbine.DataSource = Communication.Instance.SendRequestGetResult<List<Porudzbina>>(Common.Operations.VratiSvePorudzbine);
            uCObrisiPorudzbinu.BtnPretraga.Click += Btn_Pretraga_Click;
            uCObrisiPorudzbinu.BtnUcitajPorudzbinu.Click += Btn_UcitajPorudzbinu;
            uCObrisiPorudzbinu.BtnObrisi.Click += Btn_ObrisiPorudzbinu_CLick;
            listaPorudzbina = new BindingList<Porudzbina>(Communication.Instance.SendRequestGetResult<List<Porudzbina>>(Common.Operations.VratiSvePorudzbine));
        }

        private void Btn_UcitajPorudzbinu(object sender, EventArgs e)
        {
            if (uCObrisiPorudzbinu.DgvPorudzbine.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da ucita porudzbinu.");
                return;
            }
            try
            {
                p = (Porudzbina)uCObrisiPorudzbinu.DgvPorudzbine.CurrentRow.DataBoundItem;
                p.Condition = $"PorudzbinaID={p.IdPorudzbina}";
                p = Communication.Instance.SendRequestGetResult<Porudzbina>(Operations.UcitajPorudzbinu, p);
                uCObrisiPorudzbinu.TxtPorudzbinaID.Text = p.IdPorudzbina.ToString();
                uCObrisiPorudzbinu.TxtDatum.Text = p.Datum.ToString("dd.MM.yyyy");
                uCObrisiPorudzbinu.TxtCenaUkupno.Text = p.CenaUkupno.ToString();
                if (p.Status)
                {
                    uCObrisiPorudzbinu.TxtStatus.Text = "HITNO";

                }
                if (!p.Status)
                {
                    uCObrisiPorudzbinu.TxtStatus.Text = "Nije hitno";
                }

                uCObrisiPorudzbinu.TxtApotekar.Text = p.Apotekar.ToString();
                uCObrisiPorudzbinu.TxtDobavljac.Text = p.Dobavljac.ToString();
                uCObrisiPorudzbinu.DgvStavke.DataSource = p.ListaStavki;
                listaStavki = p.ListaStavki;
                System.Windows.Forms.MessageBox.Show("Sistem je ucitao porudzbinu.");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Sistem ne moze da ucita porudzbinu. ");
            }
        }

        private void Btn_ObrisiPorudzbinu_CLick(object sender, EventArgs e)
        {
            try
            {

                p.IdPorudzbina = Convert.ToInt32(uCObrisiPorudzbinu.TxtPorudzbinaID.Text);
                p.Condition = $" PorudzbinaID ={p.IdPorudzbina}";
                Communication.Instance.SendRequestNoResult(Operations.ObrisiPorudzbinu, p);
                System.Windows.Forms.MessageBox.Show("Sistem je obrisao porudzbinu. ");
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Sistem ne moze da obrise porudzbinu. ");
            }

          
        }


        private void Btn_Pretraga_Click(object sender, EventArgs e)
        {
            Porudzbina porudzbinaPretraga = new Porudzbina();

            if (!Validations.UserControllValidation.EmptyFieldValidation(uCObrisiPorudzbinu.TxtPretraga))
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da pronadje porudzbine po zadatim vrednostima. ");
                return;
            }
            String nazivDobavljaca = uCObrisiPorudzbinu.TxtPretraga.Text;
            porudzbinaPretraga.Condition = $" d.NazivDobavljaca LIKE '{nazivDobavljaca}%'";
            List<Porudzbina> listaPorudzbina = new List<Porudzbina>();
            listaPorudzbina = Communication.Instance.SendRequestGetResult<List<Porudzbina>>(Operations.NadjiPorudzbine, porudzbinaPretraga);
            uCObrisiPorudzbinu.DgvPorudzbine.DataSource = listaPorudzbina;

            if (listaPorudzbina.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da pronadje porudzbinu po zadatoj vrednosti. ");
            }
            else
            {
            System.Windows.Forms.MessageBox.Show("Sistem je pronasao porudzbinu po zadatoj vrednosti. ");

            }
        }
    
           
        }
    }

