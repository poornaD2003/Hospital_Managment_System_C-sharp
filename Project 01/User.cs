using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Project_01
{

    public  abstract class User
    {
        private string username;
        private string password;
        


        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                   
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public string getUsername()
        {
            return username;
        }
        public void setUsername(string username) { 
            this.username = username;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public abstract void openPage();
    }
}
