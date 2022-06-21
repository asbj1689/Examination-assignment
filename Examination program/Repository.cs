using System;
using System.Data.SqlClient;

namespace Examination_program
{
    class Repository
    {
            private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Camping database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    
        public Repository()
            //Test//
        {
            SqlConnection connection = new(connectionString);
            connection.Open();
            connection.Close();
        }
    }
}
