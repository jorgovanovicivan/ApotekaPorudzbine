using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DatabaseRepository
{

    public class GenericDbRepository : IRepository<IDomainObject>
    {
        Broker broker = new Broker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }
        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }
        public IDomainObject login(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Select * FROM {obj.TableName}";
            using (SqlDataReader reader=command.ExecuteReader())
            {
                if (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    return rowObject;
                }
            }
            return null;
        }
        public void Delete(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"DELETE FROM {obj.TableName} WHERE {obj.Condition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Greska prilikom brisanja!");
            }
        }
        public List<IDomainObject> GetAll(IDomainObject obj)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Select * FROM {obj.TableName}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }
        public void OpenConnection()
        {
            broker.OpenConnection();
        }
        public void Rollback()
        {
            broker.Rollback();
        }
        public void Save(IDomainObject obj)
        {
            
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"Insert into {obj.TableName} values ({obj.InsertValues})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }


        }

        public List<IDomainObject> Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
        public void Update(IDomainObject obj)
        {
           
                SqlCommand command = broker.CreateCommand();
                command.CommandText = $"UPDATE {obj.TableName} SET {obj.GetUpdateValues}  WHERE {obj.WhereCondition}";
                if (command.ExecuteNonQuery() != 1)
                {
                    throw new Exception("Database error!");
                }
            
           
        }

        public int GetNewId(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select max({obj.IdName}) from {obj.TableName}";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                return (int)result+1;
            }
        }

        public List<IDomainObject> GetSpecific(IDomainObject obj)
        {

            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"SELECT * FROM {obj.TableName} {obj.TableAlias} {obj.JoinTable} {obj.JoinCondition} WHERE {obj.Condition}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }
     
        public List<IDomainObject> getAllJoin(IDomainObject obj)
        {

            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"SELECT * FROM {obj.TableName} {obj.TableAlias} {obj.JoinTable} {obj.JoinCondition}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }
    }
}
