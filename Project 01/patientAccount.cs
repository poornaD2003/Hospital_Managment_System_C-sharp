using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BCrypt.Net;

namespace Project_01
{
    public partial class patientAccount : Form
    {
        private string patientID;

        public patientAccount(string patientID)
        {
            InitializeComponent();
            this.patientID = patientID;
        }

        private void patientAccount_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT userName, email, phoneNumber, address, age, sex, bloodGroup FROM patient WHERE patientID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", patientID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["userName"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtPhone.Text = reader["phoneNumber"].ToString();
                                txtAddress.Text = reader["address"].ToString();
                                numAge.Value = Convert.ToDecimal(reader["age"] == DBNull.Value ? 0 : reader["age"]);
                                cmbSex.SelectedItem = reader["sex"].ToString();
                                cmbBlood.SelectedItem = reader["bloodGroup"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading account data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            int age = (int)numAge.Value;
            string sex = cmbSex.SelectedItem?.ToString() ?? "";
            string blood = cmbBlood.SelectedItem?.ToString() ?? "";
            string newPassword = txtPassword.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE patient 
                                     SET userName = @name, 
                                         email = @email, 
                                         phoneNumber = @phone, 
                                         address = @address, 
                                         age = @age, 
                                         sex = @sex, 
                                         bloodGroup = @blood";

                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        query += ", password = @pass";
                    }

                    query += " WHERE patientID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@sex", sex);
                        cmd.Parameters.AddWithValue("@blood", blood);
                        cmd.Parameters.AddWithValue("@id", patientID);

                        if (!string.IsNullOrEmpty(newPassword))
                        {
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                            cmd.Parameters.AddWithValue("@pass", hashedPassword);
                        }

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving account changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
