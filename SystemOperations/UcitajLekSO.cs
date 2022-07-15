using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajLekSO : SystemOperationBase
    {
        Lek lek;
        public UcitajLekSO(Lek lek)
        {
            this.lek = lek;
        }
      public  Lek Result { get; set; }
        protected override void Execute()

        {
         //   Result = repository.GetAll(new Lek()).Cast<Lek>().ToList()[0];
           //  Result = repository.GetSpecific(lek).Cast<Lek>().ToList()[0];
            Result = repository.GetSpecific(lek).Cast<Lek>().ToList()[0];
        }
    }
}
