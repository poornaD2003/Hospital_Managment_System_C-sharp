using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_01
{
    internal class Admin: User
    {
        public Admin(string username, string password):base(username, password)
        {

        }
        public override void openPage()
        {
            try
            {
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT password FROM [user] WHERE userName = @username";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", this.getUsername());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["password"].ToString();
                               


                                bool isValid = BCrypt.Net.BCrypt.Verify(getPassword(), storedHash);

                                if (isValid)
                                {
                                    adminPage adminDashboard = new adminPage();
                                    adminDashboard.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid password. Please try again.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Patient record not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
    }
}
