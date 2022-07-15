using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class VratiListuDobavljacaSO : SystemOperationBase
    {
          public List<Dobavljac> Result{ get; set; }
        protected override void Execute()
        {
            Result = repository.GetAll(new Dobavljac()).OfType<Dobavljac>().ToList();
        }
    }
}
