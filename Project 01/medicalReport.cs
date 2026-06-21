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
    public partial class medicalReport : Form
    {
        public medicalReport()
        {
            InitializeComponent();
        }

        private void medicalReport_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Basic Input Validation
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtAppointmentID.Text))
            {
                MessageBox.Show("Patient ID and Appointment ID are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Prepare the parameterized SQL query
            // (Excluding reportID assuming it is an auto-incrementing identity column)
            string query = "INSERT INTO [dbo].[medicalReport] ([patientID], [appoinmentID], [diagnosis], [testResults]) " +
                           "VALUES (@PatientID, @AppointmentID, @Diagnosis, @TestResults)";

            // 3. Call your centralized dbConnection helper inside a using block
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Map form inputs securely to the query parameters
                    command.Parameters.AddWithValue("@PatientID", txtPatientID.Text.Trim());
                    command.Parameters.AddWithValue("@AppointmentID", txtAppointmentID.Text.Trim());

                    // Handle potential empty inputs as DBNull.Value safely
                    command.Parameters.AddWithValue("@Diagnosis", string.IsNullOrEmpty(rtbDiagnosis.Text) ? DBNull.Value : (object)rtbDiagnosis.Text.Trim());
                    command.Parameters.AddWithValue("@TestResults", string.IsNullOrEmpty(rtbTestResults.Text) ? DBNull.Value : (object)rtbTestResults.Text.Trim());

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Medical Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save the report. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtPatientID.Clear();
            txtAppointmentID.Clear();
            rtbDiagnosis.Clear();
            rtbTestResults.Clear();
            txtPatientID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminPage admin = new adminPage();
            admin.Show();
            this.Hide();
        }
    }
}
