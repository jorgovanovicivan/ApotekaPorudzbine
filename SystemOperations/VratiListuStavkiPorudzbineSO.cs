using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class VratiListuStavkiPorudzbineSO : SystemOperationBase
    {
        private StavkaPorudzbine stavka;

        public VratiListuStavkiPorudzbineSO(StavkaPorudzbine stavka)
        {
            this.stavka = stavka;
        }

        public    List<StavkaPorudzbine> Result { get; set; }
        protected override void Execute()
        {
           // Result = repository.GetSpecific(stavka).OfType<StavkaPorudzbine>().ToList();
        }
    }
}
