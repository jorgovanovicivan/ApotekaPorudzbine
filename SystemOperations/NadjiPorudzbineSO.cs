using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class NadjiPorudzbineSO : SystemOperationBase
    {
        Porudzbina p;
        public NadjiPorudzbineSO(Porudzbina p)
        {
            this.p = p;
        }
        public List<Porudzbina> Result { get; set; }

        protected override void Execute()
        {
            Result = repository.GetSpecific(p).Cast<Porudzbina>().ToList();
        }
    }
}
