using BCrypt.Net;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace Project_01
{
    public partial class patientDataEdit : Form
    {
        string pID;
        public patientDataEdit(string pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void editBox_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string password = passBox.Text;
            string email = emailBox.Text;
            string number =numberBox.Text;
            string address = addressBox.Text;
            string age = ageBox.Text;
            string sex = sexBox.SelectedItem?.ToString() ?? "";
            string blood = bloodBox.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            string sql = @"UPDATE [patient] 
                   SET password = @password, 
                       email = @email, 
                       phoneNumber = @number, 
                       address = @address, 
                       age = @age, 
                       sex = @sex, 
                       bloodGroup = @bloodGroup, 
                       userName = @userName 
                   WHERE patientID = @patientID";

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", hashedPassword); 
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@number", number);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@age", string.IsNullOrEmpty(age) ? (object)DBNull.Value : Convert.ToInt32(age));
                        cmd.Parameters.AddWithValue("@sex", sex);
                        cmd.Parameters.AddWithValue("@bloodGroup", blood);
                        cmd.Parameters.AddWithValue("@userName", name);
                        cmd.Parameters.AddWithValue("@patientID", this.pID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("Patient record not found or no changes were made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch(Exception ex) {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
