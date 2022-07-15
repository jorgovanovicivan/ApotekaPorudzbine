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
  public  class Dobavljac:IDomainObject
    {
        [Browsable(false)]
        public int IdDobavljac { get; set; }
        public String NazivDobavljaca { get; set; }
        public String Grad { get; set; }
        [Browsable(false)]
        public string TableName => "Dobavljac";
        [Browsable(false)]
        public string InsertValues => $"{IdDobavljac},'{NazivDobavljaca}','{Grad}'";
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
            Dobavljac d = new Dobavljac
            {
                IdDobavljac = (int)reader["DobavljacID"],
                NazivDobavljaca = (String)reader["NazivDobavljaca"],
                Grad = (String)reader["Grad"]
            };
            return d;
        }

        public override string ToString()
        {
            return $"{NazivDobavljaca} - {Grad}";
        }
    }
}
