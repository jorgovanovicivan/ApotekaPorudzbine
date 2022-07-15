using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class NadjiLekoveSO : SystemOperationBase
    {
        Lek lek;
        public NadjiLekoveSO(Lek lek)
        {
            this.lek = lek;
        }
        public List<Lek> Result { get; set; }
        protected override void Execute()
        {
            Result = repository.GetSpecific(lek).Cast<Lek>().ToList();
        }

       
    }
}
