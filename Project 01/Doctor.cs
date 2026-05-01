using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Project_01
{
    internal class Doctor : User
    {
        public Doctor(string username, string password) :base(username, password)
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
                                    doctorPage doctorDashboard = new doctorPage();
                                    doctorDashboard.Show();
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
