using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Project_01
{
    public static class dbConnection
    {
        private static string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=vpDB;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
