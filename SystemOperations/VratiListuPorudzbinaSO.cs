using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class VratiListuPorudzbinaSO : SystemOperationBase
    {
        Porudzbina po;
      
   public   List<Porudzbina> Result { get; set; }
        protected override void Execute()
        {
            Result = repository.getAllJoin(new Porudzbina()).OfType<Porudzbina>().ToList();
            //foreach(Porudzbina p in Result)
            //{

           
            ////s.Porudzbina.IdPorudzbina = p.IdPorudzbina;
            ////p.ListaStavki =new System.ComponentModel.BindingList<StavkaPorudzbine>( repository.GetSpecific(s).OfType<StavkaPorudzbine>().ToList());

            //}
            
        }
    }
}
