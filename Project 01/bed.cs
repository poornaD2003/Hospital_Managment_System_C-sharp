using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Project_01
{
    public partial class bed : Form
    {

        public bed()
        {
            InitializeComponent();
        }
        private void FormRoomManagement_Load(object sender, EventArgs e)
        {
            LoadOccupancyGrid();
        }
        public void LoadOccupancyGrid()
        {
            string query = @"SELECT roomNumber AS [Room No], section AS [Section], status AS [Status], 
                            pricePerDay AS [Price/Day], patientID AS [Patient ID], numberOfDays AS [Days Stayed] 
                            FROM room";

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRooms.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading room data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bed_Load(object sender, EventArgs e)
        {
            dgvRooms.ReadOnly = true;
            LoadOccupancyGrid();
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];

                txtRoomNo.Text = row.Cells["Room No"].Value?.ToString() ?? "";
                txtPatientID.Text = row.Cells["Patient ID"].Value?.ToString() ?? "";
                txtDays.Text = row.Cells["Days Stayed"].Value?.ToString() ?? "";

                txtSection.Text = row.Cells["Section"].Value?.ToString() ?? "";
                txtPrice.Text = row.Cells["Price/Day"].Value?.ToString() ?? "";
                txtStatus.Text = row.Cells["Status"].Value?.ToString() ?? "";
            }
        }

        private void btnAssignPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNo.Text) || txtRoomNo.Text == "None")
            {
                MessageBox.Show("Please select a room from the grid layout first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isDischarging = string.IsNullOrWhiteSpace(txtPatientID.Text.Trim());
            string query = @"UPDATE room 
                            SET status = @status, patientID = @patientID, numberOfDays = @days 
                            WHERE roomNumber = @roomNo";

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomNo", txtRoomNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@patientID", isDischarging ? DBNull.Value : (object)txtPatientID.Text.Trim());
                        cmd.Parameters.AddWithValue("@days", isDischarging ? 0 : Convert.ToInt32(txtDays.Text.Trim()));
                        cmd.Parameters.AddWithValue("@status", isDischarging ? "Available" : "Occupied");

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(isDischarging ? "Patient discharged and room cleared!" : "Patient assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOccupancyGrid();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Processing Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void ClearInputs()
        {

            txtRoomNo.Text = "";
            txtPatientID.Clear();
            txtDays.Clear();

            txtSection.Clear();
            txtPrice.Clear();
            txtStatus.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            adminPage admin = new adminPage();
            admin.Show();
            this.Hide();
        }
    }
}
