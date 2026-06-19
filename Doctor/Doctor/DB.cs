using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

class DB
{
    public static MySqlConnection GetConnection()
    {
        string conn =
        "server=localhost;" +
        "database=hospital_db_vs;" +
        "uid=root;" +
        "pwd=;";

        return new MySqlConnection(conn);
    }
}