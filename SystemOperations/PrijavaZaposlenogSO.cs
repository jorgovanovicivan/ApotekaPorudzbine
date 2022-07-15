using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class PrijavaZaposlenogSO:SystemOperationBase
    {
        private Apotekar apotekar;

        public PrijavaZaposlenogSO(Apotekar apotekar)
        {
            this.apotekar = apotekar;
        }
        public Apotekar Result { get; private set; }
        protected override void Execute()
        {
          // Result = (Apotekar)repository.login(apotekar);

           
            foreach (Apotekar t in repository.GetAll(new Apotekar()).OfType<Apotekar>().ToList())
            {
                if (t.KorisnickoIme == apotekar.KorisnickoIme &&
                    t.Lozinka == apotekar.Lozinka)
                {
                    apotekar.IdApotekar = t.IdApotekar;
                    apotekar.ImeApotekara = t.ImeApotekara;
                    apotekar.PrezimeApotekara = t.PrezimeApotekara;
                    Result = apotekar;
                }
            }
        }
    }
}
