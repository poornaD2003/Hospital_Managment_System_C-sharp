using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BCrypt.Net;

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

                    // Password saha ID dekama select karaganna
                    string sql = "SELECT password, patientID FROM [patient] WHERE userName = @username";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", this.getUsername());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Record ekak thiyenam
                            {
                                string storedHash = reader["password"].ToString();
                                string pID = reader["patientID"].ToString();
                                

                                // Password eka verify kirima
                                bool isValid = BCrypt.Net.BCrypt.Verify(getPassword(), storedHash);

                                if (isValid)
                                {
                                    // PatientID eka parameter ekak lesa pass karanna
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
        /*public override void openPage()
        {
            try
            {
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                   
                    string sql = "SELECT password, patientID FROM [patient] WHERE userName = @username ";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", this.getUsername());
                      

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string storedHash = result.ToString();
                            bool isValid = BCrypt.Net.BCrypt.Verify(getPassword(), storedHash);

                            if (isValid)
                            {
                                patientPage patientDashboard = new patientPage();
                                patientDashboard.Show();
                            }
                            else { 
                                MessageBox.Show("Invalid password. Please try again.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Patient record not found in the database.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }*/
    }
}