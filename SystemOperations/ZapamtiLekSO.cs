using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ZapamtiLekSO : SystemOperationBase
    {
        protected readonly Lek lek;
        public ZapamtiLekSO(Lek lek)
        {
            this.lek = lek;
        }
        protected override void Execute()
        {
            lek.SifraLeka = repository.GetNewId(lek);
            repository.Save(lek);
        }
    }
}
