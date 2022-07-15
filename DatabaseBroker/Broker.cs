﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        SqlConnection connection;
        SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Apoteka;Integrated Security=True;");
        }

        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            if(connection!=null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", connection, transaction);
        }
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }
        public void Commit()
        {
            transaction.Commit();
        }
        public void Rollback()
        {
            transaction.Rollback();
        }
    }
}
