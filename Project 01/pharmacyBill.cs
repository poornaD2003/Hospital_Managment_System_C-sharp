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
    public partial class pharmacyBill : Form
    {
        public pharmacyBill()
        {
            InitializeComponent();
            txtAppointmentBill.TextChanged += CalculateTotalLive;
            txtMedicineBill.TextChanged += CalculateTotalLive;
            txtRoomBill.TextChanged += CalculateTotalLive;
        }

        private void pharmacyBill_Load(object sender, EventArgs e)
        {
            cmbPaymentStatus.Items.Clear();
            cmbPaymentStatus.Items.Add("Paid");
            cmbPaymentStatus.Items.Add("Unpaid");
            cmbPaymentStatus.Items.Add("Pending");
            cmbPaymentStatus.SelectedIndex = 2; 

            txtAppointmentBill.Text = "0.00";
            txtMedicineBill.Text = "0.00";
            txtRoomBill.Text = "0.00";
        }
        private void CalculateTotalLive(object sender, EventArgs e)
        {
            decimal appointment = 0, medicine = 0, room = 0;

            decimal.TryParse(txtAppointmentBill.Text, out appointment);
            decimal.TryParse(txtMedicineBill.Text, out medicine);
            decimal.TryParse(txtRoomBill.Text, out room);

            decimal runningTotal = appointment + medicine + room;

            lblTotalAmount.Text = $"LKR {runningTotal:N2}";
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtAppointmentID.Text))
            {
                MessageBox.Show("Please enter valid Patient and Appointment IDs before proceeding.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string patientId = (txtPatientID.Text);
                int appointmentId = int.Parse(txtAppointmentID.Text);

                decimal.TryParse(txtAppointmentBill.Text, out decimal appointmentCost);
                decimal.TryParse(txtMedicineBill.Text, out decimal medicineCost);
                decimal.TryParse(txtRoomBill.Text, out decimal roomCost);

                decimal grandTotal = appointmentCost + medicineCost + roomCost;
                string status = cmbPaymentStatus.SelectedItem.ToString();
                DateTime paymentDate = DateTime.Now;

                string query = @"INSERT INTO [dbo].[bill] 
                                ([patientID], [appoinmnetID], [totalAmount], [paymentDate], [paymentStatus]) 
                                VALUES 
                                (@PatientID, @AppointmentID, @TotalAmount, @PaymentDate, @PaymentStatus);";

                using (SqlConnection connection = dbConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", patientId);
                        command.Parameters.AddWithValue("@AppointmentID", appointmentId);
                        command.Parameters.AddWithValue("@TotalAmount", grandTotal);
                        command.Parameters.AddWithValue("@PaymentDate", paymentDate);
                        command.Parameters.AddWithValue("@PaymentStatus", status);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Invoice processed successfully!\nGrand Total: LKR {grandTotal:N2}",
                                            "Billing System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields();
                        }
                        else
                        {
                            MessageBox.Show("The record could not be written to the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database connection or structural error: {sqlEx.Message}",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected transmission fault occurred: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFormFields()
        {
            txtPatientID.Clear();
            txtAppointmentID.Clear();
            txtAppointmentBill.Text = "0.00";
            txtMedicineBill.Text = "0.00";
            txtRoomBill.Text = "0.00";
            cmbPaymentStatus.SelectedIndex = 2;
            lblTotalAmount.Text = "LKR 0.00";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminPage admin = new adminPage();
            admin.Show();
            this.Hide();
        }
    }
}
