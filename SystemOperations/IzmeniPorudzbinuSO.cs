using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class IzmeniPorudzbinuSO : SystemOperationBase
    {
        Porudzbina porudzbina;


        public IzmeniPorudzbinuSO(Porudzbina porudzbina)
        {
            this.porudzbina = porudzbina;
        }
        protected override void Execute()
        {
            repository.Update(porudzbina);
            foreach(StavkaPorudzbine s in porudzbina.ListaStavki)
            {
                repository.Update(s);
            }
        }
    }
}
