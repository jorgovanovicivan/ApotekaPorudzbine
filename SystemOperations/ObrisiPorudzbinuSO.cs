using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ObrisiPorudzbinuSO : SystemOperationBase
    {
        Porudzbina p;
        public ObrisiPorudzbinuSO(Porudzbina p)
        {
            this.p = p;
        }
        protected override void Execute()
        {
            repository.Delete(p);
        }
    }
}
