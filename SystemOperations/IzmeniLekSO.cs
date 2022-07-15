using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class IzmeniLekSO : SystemOperationBase
    {
        protected readonly Lek lek;
        public IzmeniLekSO(Lek lek)
        {
            this.lek = lek;
        }
        protected override void Execute()
        {
            repository.Update(lek);
        }
    }
}
