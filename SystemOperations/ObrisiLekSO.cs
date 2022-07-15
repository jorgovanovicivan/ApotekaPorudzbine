using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ObrisiLekSO : SystemOperationBase
    {
        Lek lek;
        public ObrisiLekSO(Lek lek)
        {
            this.lek = lek;
        }

        protected override void Execute()
        {
            repository.Delete(lek);
        }
    }
}
