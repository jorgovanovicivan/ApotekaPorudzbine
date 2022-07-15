using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Porudzbina : IDomainObject
    {
        public Porudzbina()
        {
            listaStavki = new BindingList<StavkaPorudzbine>();
        }
        public override string ToString()
        {
            return $"Porudzbina {IdPorudzbina} Kreirana: {Datum}";
        }
        public int IdPorudzbina { get; set; }
        public DateTime Datum { get; set; }
        public Double CenaUkupno { get; set; }
        public bool Status { get; set; }
        public Apotekar Apotekar { get; set; }
        public Dobavljac Dobavljac { get; set; }

        BindingList<StavkaPorudzbine> listaStavki;

        public BindingList<StavkaPorudzbine> ListaStavki { get => listaStavki; set => listaStavki = value; }
        [Browsable(false)]
        public string TableName => "Porudzbina";
        [Browsable(false)]
        public string InsertValues => $"{IdPorudzbina},'{Datum}',{CenaUkupno},'{Status}',{Apotekar.IdApotekar},{Dobavljac.IdDobavljac}";
        [Browsable(false)]
        public string IdName => "PorudzbinaID";
        [Browsable(false)]
        public string WhereCondition => $"PorudzbinaID={IdPorudzbina}";
        [Browsable(false)]
        public string GetUpdateValues => $"Datum='{Datum}',CenaUkupno={CenaUkupno},Status='{Status}',ApotekarID={Apotekar.IdApotekar},DobavljacID={Dobavljac.IdDobavljac}";
        [Browsable(false)]
        public string Condition { get; set; }
        [Browsable(false)]
        public string JoinCondition => " on ( a.ApotekarID=p.ApotekarID ) join Dobavljac d on ( d.DobavljacID=p.DobavljacID ) ";
        [Browsable(false)]
        public string JoinTable => " join Apotekar a ";
        [Browsable(false)]
        public string TableAlias => " p ";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Porudzbina porudzbina = new Porudzbina
            {
                IdPorudzbina = (int)reader["PorudzbinaID"],
                Datum = (DateTime)reader["Datum"],
                CenaUkupno = (Double)reader["CenaUkupno"],
                Status=(bool)reader["Status"],
                Apotekar =new Apotekar
                {
                    IdApotekar= (int)reader["ApotekarID"],

                     ImeApotekara = (String)reader["ImeApotekara"],
                    PrezimeApotekara = (String)reader["PrezimeApotekara"],
                    KorisnickoIme = (String)reader["KorisnickoIme"],
                    Lozinka = (String)reader["Sifra"],
                },
                Dobavljac=new Dobavljac { 
                  IdDobavljac= (int)reader["DobavljacID"],
                  NazivDobavljaca=(String)reader["NazivDobavljaca"],
                  Grad=(String)reader["Grad"]
                }
            };
            return porudzbina;
        }
    }
}
