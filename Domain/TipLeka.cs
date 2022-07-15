using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
   public class TipLeka:IDomainObject
    {

        public int IdTipa { get; set; }
        public String Naziv { get; set; }

        public string TableName => "TipLeka";

        public string InsertValues => $"{IdTipa},'{Naziv}'";

        public string IdName => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public string GetUpdateValues => throw new NotImplementedException();

        public string Condition => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            TipLeka t = new TipLeka
            {
                IdTipa=(int)reader["TipID"],
                Naziv=(String)reader["NazivTipa"]
            };
            return t;
        }

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
