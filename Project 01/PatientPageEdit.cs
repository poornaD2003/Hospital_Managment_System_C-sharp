using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_01
{
    public partial class PatientPageEdit : Form
    {
        public PatientPageEdit()
        {
            InitializeComponent();
        }

        // --- TASK 1: LOAD ALL DATA TO DATAGRIDVIEW ---
        private void LoadPatientData()
        {
            try
            {
                // Using your centralized connection class here
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    string query = "SELECT patientID, email, phoneNumber, address, age, sex, bloodGroup, userName, patientImage FROM patient";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientPageEdit_Load(object sender, EventArgs e)
        {
            LoadPatientData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientID.Text))
            {
                MessageBox.Show("Please select a patient row from the grid first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Using your centralized connection class here as well
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    string query = @"UPDATE patient 
                                     SET  
                                         email = @email, 
                                         phoneNumber = @phoneNumber, 
                                         address = @address, 
                                         age = @age, 
                                         sex = @sex, 
                                         bloodGroup = @bloodGroup, 
                                         userName = @userName,
                                         patientImage = @patientImage
                                     WHERE patientID = @patientID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Map values from UI inputs to SQL Parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@patientID", txtPatientID.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());

                        // Parse numerical inputs safely
                        int.TryParse(txtAge.Text, out int age);
                        cmd.Parameters.AddWithValue("@age", age);

                        cmd.Parameters.AddWithValue("@sex", cmbSex.Text.Trim());
                        cmd.Parameters.AddWithValue("@bloodGroup", cmbBloodGroup.Text.Trim());
                        cmd.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());

                        // Convert PictureBox image back to a binary byte array for your database
                        if (picPatientImage.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                picPatientImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                cmd.Parameters.AddWithValue("@patientImage", ms.ToArray());
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@patientImage", SqlDbType.VarBinary).Value = DBNull.Value;
                        }

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPatientData(); // Refresh grid instantly to show updates
                        }
                        else
                        {
                            MessageBox.Show("Update execution failed. Target record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Pull data directly using your column names from the SQL query
                txtPatientID.Text = row.Cells["patientID"].Value?.ToString();
                txtEmail.Text = row.Cells["email"].Value?.ToString();
                txtPhoneNumber.Text = row.Cells["phoneNumber"].Value?.ToString();
                txtAddress.Text = row.Cells["address"].Value?.ToString();
                txtAge.Text = row.Cells["age"].Value?.ToString();
                cmbSex.Text = row.Cells["sex"].Value?.ToString();
                cmbBloodGroup.Text = row.Cells["bloodGroup"].Value?.ToString();
                txtUserName.Text = row.Cells["userName"].Value?.ToString();

                // Handle image extraction safely
                if (row.Cells["patientImage"].Value != DBNull.Value && row.Cells["patientImage"].Value != null)
                {
                    byte[] imageBytes = (byte[])row.Cells["patientImage"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picPatientImage.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picPatientImage.Image = null; // Clear old image if entry is empty
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

