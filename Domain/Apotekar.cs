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
    public class Apotekar:IDomainObject
    {
        [Browsable(false)]
        public int IdApotekar { get; set; }
        public String ImeApotekara { get; set; }
        public String PrezimeApotekara { get; set; }
        [Browsable(false)]
        public String KorisnickoIme { get; set; }
        [Browsable(false)]
        public String Lozinka { get; set; }
        [Browsable(false)]
        public string TableName => "Apotekar";
        [Browsable(false)]
        public string InsertValues => $"{IdApotekar},'{ImeApotekara}','{PrezimeApotekara}','{KorisnickoIme}', '{Lozinka}'";
        [Browsable(false)]
        public string IdName => throw new NotImplementedException();
        [Browsable(false)]
        public string WhereCondition => throw new NotImplementedException();

        [Browsable(false)]
        public string GetUpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string Condition => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinTable => throw new NotImplementedException();
        [Browsable(false)]
        public string TableAlias => throw new NotImplementedException();

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Apotekar a = new Apotekar
            {
                IdApotekar = (int)reader["ApotekarID"],
                ImeApotekara = (String)reader["ImeApotekara"],
                PrezimeApotekara = (String)reader["PrezimeApotekara"],
                KorisnickoIme = (String)reader["KorisnickoIme"],
                Lozinka = (String)reader["Sifra"]
            };
            return a;
        }

        public override string ToString()
        {
            return $"{ImeApotekara} {PrezimeApotekara}";
        }
    }
}
