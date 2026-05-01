using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project_01
{
    public partial class doctorRegestor : Form
    {
        public doctorRegestor()
        {
            InitializeComponent();
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            string doctorName = dNameField.Text;
            string password = passwordField.Text;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            string role = "Doctor";

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO [user] ( userName, password,roleType) VALUES ( @name, @password,@role)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", doctorName);
                    cmd.Parameters.AddWithValue("@password", passwordHash);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Doctor registered successfully with ID: ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
