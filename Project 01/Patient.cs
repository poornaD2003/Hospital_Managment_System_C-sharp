using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BCrypt.Net;
using System.Web;

namespace Project_01
{
    internal class Patient : User
    {
        public Patient(string username, string password) : base(username, password)
        {
        }
        public override void openPage()
        {
            try
            {
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT password, patientID FROM [patient] WHERE userName = @username";
                 

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", this.getUsername());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                string storedHash = reader["password"].ToString();
                                string pID = reader["patientID"].ToString();
                                

                                bool isValid = BCrypt.Net.BCrypt.Verify(getPassword(), storedHash);

                                if (isValid)
                                {
                                    patientPage patientDashboard = new patientPage(pID);
                                    patientDashboard.Show();
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