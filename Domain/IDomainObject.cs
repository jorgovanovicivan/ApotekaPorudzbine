using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDomainObject
    {
        String TableName { get; }
        String InsertValues { get; }
      String IdName { get; }
        String WhereCondition { get; }
        String GetUpdateValues { get; }
        String Condition { get; }

        string JoinCondition { get; }
        string JoinTable { get; }
        string TableAlias { get; }
       
        IDomainObject ReadObjectRow(SqlDataReader result);
    }
}
