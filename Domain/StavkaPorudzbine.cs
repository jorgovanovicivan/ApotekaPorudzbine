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
    public class StavkaPorudzbine : IDomainObject
    {

        public Porudzbina Porudzbina { get; set; }
        public int Rb { get; set; }
        public int Kolicina { get; set; }
        public Double Cena { get; set; }
        public Lek Lek { get; set; }

       
        [Browsable(false)]
        public string TableName => "StavkaPorudzbine";

        [Browsable(false)]
        public string InsertValues => $"{Porudzbina.IdPorudzbina},{Rb},{Kolicina},{Cena},{Lek.SifraLeka}";
        [Browsable(false)]
        public string IdName => "PorudzbinaID";
        [Browsable(false)]
        public string WhereCondition => $"PorudzbinaID={Porudzbina.IdPorudzbina}";
        [Browsable(false)]
        public string GetUpdateValues => $"Rb={Rb},Kolicina={Kolicina},Cena={Cena},SifraLeka={Lek.SifraLeka}";
        [Browsable(false)]
        public string Condition { get; set; }
        [Browsable(false)]
        public string JoinCondition => "  on ( l.SifraLeka=s.SifraLeka ) ";
        [Browsable(false)]
        public string JoinTable => " join Lek l ";
        [Browsable(false)]
        public string TableAlias => " s ";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            StavkaPorudzbine s = new StavkaPorudzbine
            {
              Porudzbina = new Porudzbina
              {
                  IdPorudzbina = (int)reader["PorudzbinaID"],
                  

              },
               Rb=(int)reader["Rb"],
              Kolicina=  (int)reader["Kolicina"],
              Cena= (Double)reader["Cena"],
              Lek=new Lek
              {
                  SifraLeka = (int)reader["SifraLeka"],
                  JKL = (int)reader["JKL"],
                  ImeLeka = (String)reader["ImeLeka"],
                  INN = (String)reader["INN"],
                  FOLeka = (String)reader["FOLeka"],
                  Proizvodjac = (String)reader["Proizvodjac"],
                  Cena = (Double)reader["Cena"],
                  Apotekar = new Apotekar
                  {
                      IdApotekar = (int)reader["ApotekarID"],
                     
                  },
                  TipLeka = new TipLeka
                  {
                      IdTipa = (int)reader["TipID"],
                     
                  }
              }
            };
            return s;
        }
    }
}
