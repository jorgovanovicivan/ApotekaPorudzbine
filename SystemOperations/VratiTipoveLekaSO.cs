using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class VratiTipoveLekaSO : SystemOperationBase
    {
    public  List<TipLeka> Result { get; set; }
        protected override void Execute()
        {

            Result = repository.GetAll(new TipLeka()).OfType<TipLeka>().ToList();
        }
    }
}
