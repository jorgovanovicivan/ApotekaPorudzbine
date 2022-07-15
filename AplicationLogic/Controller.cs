using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;

namespace AplicationLogic
{
    public class Controller
    {
        private static Controller instanca;
        private Broker broker = new Broker();
        Controller()
        {

        }
        public static Controller Instance
        {
            get
            {
                if (instanca == null)
                {
                    instanca = new Controller();
                }
                return instanca;
            }
        }
        public Apotekar Login(Apotekar apotekar)
        {
            SystemOperationBase so = new PrijavaZaposlenogSO(apotekar);
            so.ExecuteTemplate();
            return ((PrijavaZaposlenogSO)so).Result;
        }


        public List<TipLeka> vratiTipoveLeka()
        {
            SystemOperationBase so = new VratiTipoveLekaSO();
            so.ExecuteTemplate();
            return ((VratiTipoveLekaSO)so).Result;
        }

      

        public void ZapamtiLek(Lek lek)
        {
            SystemOperationBase so = new ZapamtiLekSO(lek);
            so.ExecuteTemplate();
        }

        public List<Dobavljac> vratiListuDobavljaca()
        {
            SystemOperationBase so = new VratiListuDobavljacaSO();
            so.ExecuteTemplate();
            return ((VratiListuDobavljacaSO)so).Result;
        }

        public List<Lek> VratiListuLekova()
        {
            SystemOperationBase so = new VratiListuLekovaSO();
            so.ExecuteTemplate();
            return ((VratiListuLekovaSO)so).Result;
        }
        public Lek UcitajLek(Lek lek)
        {
            SystemOperationBase so = new UcitajLekSO(lek);
            so.ExecuteTemplate();
            return ((UcitajLekSO)so).Result;
        }

        public void SacuvajPorudzbinu(Porudzbina porudzbina)
        {
            SystemOperationBase so = new ZapamtiPorudzbinuSO(porudzbina);
            so.ExecuteTemplate();
        }

        public void IzmeniLek(Lek lek)
        {
            SystemOperationBase so = new IzmeniLekSO(lek);
            so.ExecuteTemplate();
        }
        public void ObrisiLek(Lek lek)
        {
            SystemOperationBase so = new ObrisiLekSO(lek);
            so.ExecuteTemplate();
        }

        public List<Lek> NadjiLekove(Lek lek)
        {
            SystemOperationBase so = new NadjiLekoveSO(lek);
            so.ExecuteTemplate();
            return ((NadjiLekoveSO)so).Result;
            
            
        }
        public List<Porudzbina> vratiListuPorudzbina()
        {
            SystemOperationBase so = new VratiListuPorudzbinaSO();
            so.ExecuteTemplate();
            return ((VratiListuPorudzbinaSO)so).Result;
        }
          public List<StavkaPorudzbine> vratiListuStavkiPorudzbina(StavkaPorudzbine stavka)
        {
            SystemOperationBase so = new VratiListuStavkiPorudzbineSO(stavka);
            so.ExecuteTemplate();
            return ((VratiListuStavkiPorudzbineSO)so).Result;
        }

        public void IzmeniPorudzbini(Porudzbina p)
        {
            SystemOperationBase so = new IzmeniPorudzbinuSO(p);
            so.ExecuteTemplate();
        }

        public Porudzbina UcitajPorudzbinu(Porudzbina po)
        {
            SystemOperationBase so = new UcitajPorudzbinuSO(po);
            so.ExecuteTemplate();
            return ((UcitajPorudzbinuSO)so).Result;

        }
        public List<Porudzbina> NadjiPorudzbine(Porudzbina p)
        {
            SystemOperationBase so = new NadjiPorudzbineSO(p);
            so.ExecuteTemplate();
            return ((NadjiPorudzbineSO)so).Result;


        }
        public void ObrisiPorudzbinu(Porudzbina p)
        {
            SystemOperationBase so = new ObrisiPorudzbinuSO(p);
            so.ExecuteTemplate();
        }
    }
}
