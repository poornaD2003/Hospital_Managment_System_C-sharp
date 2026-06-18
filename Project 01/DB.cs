using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

class DB
{
    private static string connectionString =
        "Data Source=localhost\\SQLEXPRESS;Initial Catalog=vpDB;Integrated Security=True;TrustServerCertificate=True";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}