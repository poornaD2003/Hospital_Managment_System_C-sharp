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
    public partial class adminRegister : Form
    {
        public adminRegister()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string adminName = nameBox.Text;
            string password = passBox.Text;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            string role = "Admin";
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO [user] ( userName, password,roleType) VALUES ( @name, @password,@role)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", adminName);
                    cmd.Parameters.AddWithValue("@password", passwordHash);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Admin registered successfully with ID: ");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
