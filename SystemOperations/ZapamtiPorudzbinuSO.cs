using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ZapamtiPorudzbinuSO : SystemOperationBase
    {
        protected readonly Porudzbina porudzbina;
        public ZapamtiPorudzbinuSO(Porudzbina porudzbina)
        {
            this.porudzbina = porudzbina;
        }
        protected override void Execute()
        {
                int id= repository.GetNewId(porudzbina);
            porudzbina.IdPorudzbina = id;
            repository.Save(porudzbina);

            foreach(StavkaPorudzbine s in porudzbina.ListaStavki)
            {
                s.Porudzbina = new Porudzbina
                {
                    IdPorudzbina = id
                };

                repository.Save(s);

            }
        }
    }
}
