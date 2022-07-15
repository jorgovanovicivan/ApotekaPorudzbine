using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class VratiListuLekovaSO : SystemOperationBase
    {
      public  List<Lek> Result { get; set; }
        protected override void Execute()
        {
        // Result = repository.GetAll(new Lek()).OfType<Lek>().ToList();
            Result = repository.getAllJoin(new Lek()).OfType<Lek>().ToList();
        }
    }
}
