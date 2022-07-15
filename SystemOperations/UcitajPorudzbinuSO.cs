using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajPorudzbinuSO : SystemOperationBase
    {
        Porudzbina po;
        public UcitajPorudzbinuSO(Porudzbina po)
        {
            this.po = po;

        }
     public   Porudzbina Result { get; set; }
        protected override void Execute()
        {
            Result = repository.GetSpecific(po).OfType<Porudzbina>().ToList()[0];
            //   clan.GrupaZaTreniranje = Repository.GetSpecific(new GrupaZaTreniranje { GCondition = $"GrupaID={clan.GrupaZaTreniranje.GrupaId}" }).Cast<GrupaZaTreniranje>().ToList()[0];
            Result.ListaStavki =new System.ComponentModel.BindingList<StavkaPorudzbine>( repository.GetSpecific(new StavkaPorudzbine { Condition = $"PorudzbinaID={Result.IdPorudzbina}" }).Cast<StavkaPorudzbine>().ToList());
            //s.Condition = $"PorudzbinaID={po.IdPorudzbina}";
            //po.ListaStavki = new System.ComponentModel.BindingList<StavkaPorudzbine>();
            //po.ListaStavki =new System.ComponentModel.BindingList<StavkaPorudzbine>(repository.GetSpecific(s).OfType<StavkaPorudzbine>().ToList());

        }
    }
}
