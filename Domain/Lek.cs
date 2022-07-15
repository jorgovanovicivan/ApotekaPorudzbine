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
public class Lek:IDomainObject
    {
        public int SifraLeka { get; set; }
        public int JKL { get; set; }
        public String ImeLeka { get; set; }
        public String INN { get; set; }
        public String FOLeka { get; set; }
        public String Proizvodjac { get; set; }
        public Double Cena { get; set; }
        public Apotekar Apotekar { get; set; }
        public TipLeka TipLeka { get; set; }
        [Browsable(false)]
        public string TableName => "Lek";
        [Browsable(false)]
        public string InsertValues => $"{SifraLeka}, {JKL}, '{ImeLeka}','{INN}','{FOLeka}','{Proizvodjac}',{Cena},{Apotekar.IdApotekar},{TipLeka.IdTipa}";
        [Browsable(false)]
        public String IdName => "SifraLeka";
        [Browsable(false)]
        public string WhereCondition => $"SifraLeka={SifraLeka}";
        [Browsable(false)]
        public string GetUpdateValues => $"JKL={JKL}, ImeLeka= '{ImeLeka}', INN='{INN}',FOLeka='{FOLeka}',Proizvodjac='{Proizvodjac}',Cena={Cena},ApotekarID={Apotekar.IdApotekar},TipID={TipLeka.IdTipa}";
        [Browsable(false)]
        public string Condition { get; set; }
        [Browsable(false)]
        public string JoinCondition => " on (a.ApotekarID=l.ApotekarID) join TipLeka t on (t.TipID=l.TipID) ";
        [Browsable(false)]
        public string JoinTable => " join Apotekar a ";
        [Browsable(false)]
        public string TableAlias => "l";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Lek lek = new Lek
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
                    ImeApotekara = (String)reader["ImeApotekara"],
                    PrezimeApotekara = (String)reader["PrezimeApotekara"],
                    KorisnickoIme = (String)reader["KorisnickoIme"],
                    Lozinka = (String)reader["Sifra"],
                },
                TipLeka=new TipLeka
                {
                    IdTipa=(int)reader["TipID"],
                    Naziv = (String)reader["NazivTipa"]
                }
                
            };
            return lek;
        }
        public override string ToString()
        {
            return $"{ImeLeka}";
        }
    }
}
