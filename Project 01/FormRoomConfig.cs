using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
/*




unwanted page////////////////////////////////////////////






*/

namespace Project_01
{
    public partial class FormRoomConfig : Form
    {
        private bed mainForm = null;
        public FormRoomConfig(bed callingForm)
        {
            InitializeComponent();

            mainForm = callingForm;
        }
        public FormRoomConfig()
        {
            InitializeComponent();
        }

        private void FormRoomConfig_Load(object sender, EventArgs e)
        {

            cmbNewStatus.Items.AddRange(new string[] { "Available", "Maintenance" });
            cmbNewStatus.SelectedIndex = 0;
            LoadConfigGrid();
        }
        private void LoadConfigGrid()
        {
            string query = "SELECT roomNumber AS [Room No], section AS [Section], pricePerDay AS [Price/Day], status AS [Status] FROM room";

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvConfigRooms.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying inventory setup: " + ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRoomConfig configForm = new FormRoomConfig();
            configForm.ShowDialog();
            if (string.IsNullOrWhiteSpace(txtNewRoomNo.Text) || string.IsNullOrWhiteSpace(txtNewPrice.Text))
            {
                MessageBox.Show("Please fill all structural tracking data fields.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO room (roomNumber, section, status, pricePerDay, numberOfDays) VALUES (@roomNo, @section, @status, @price, 0)";
            ExecuteConfigQuery(query, "New room entity saved to inventory.");
        }

        private void btnUpdateRoomDetails_Click(object sender, EventArgs e)
        {
            if (txtNewRoomNo.Enabled == true)
            {
                MessageBox.Show("Please click on a record inside the grid view layout to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE room SET section = @section, pricePerDay = @price, status = @status WHERE roomNumber = @roomNo";
            ExecuteConfigQuery(query, "Room structural settings successfully altered.");

        }
        private void ExecuteConfigQuery(string query, string successMsg)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomNo", txtNewRoomNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@section", txtNewSection.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbNewStatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtNewPrice.Text.Trim()));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(successMsg, "Database Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadConfigGrid();
                    if (mainForm != null)
                    {
                        mainForm.LoadOccupancyGrid();
                    } // Force refresh parent dashboard window seamlessly
                    ClearConfigInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query processing failure: " + ex.Message, "Error Pipeline", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvConfigRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvConfigRooms.Rows[e.RowIndex];
                txtNewRoomNo.Text = row.Cells["Room No"].Value.ToString();
                txtNewSection.Text = row.Cells["Section"].Value.ToString();
                txtNewPrice.Text = row.Cells["Price/Day"].Value.ToString();

                string statusVal = row.Cells["Status"].Value.ToString();
                cmbNewStatus.SelectedItem = (statusVal == "Occupied") ? "Available" : statusVal;

                txtNewRoomNo.Enabled = false; // Block changes to Primary Key
            }
        }
        private void ClearConfigInputs()
        {
            txtNewRoomNo.Clear();
            txtNewSection.Clear();
            txtNewPrice.Clear();
            cmbNewStatus.SelectedIndex = 0;
            txtNewRoomNo.Enabled = true;
        }

        private void dgvConfigRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked a valid data row, not the header row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvConfigRooms.Rows[e.RowIndex];

                txtNewRoomNo.Text = row.Cells["Room No"].Value?.ToString() ?? "";
                txtNewSection.Text = row.Cells["Section"].Value?.ToString() ?? "";
                txtNewPrice.Text = row.Cells["Price/Day"].Value?.ToString() ?? "";

                string statusVal = row.Cells["Status"].Value?.ToString() ?? "Available";
                cmbNewStatus.SelectedItem = (statusVal == "Occupied") ? "Available" : statusVal;

                txtNewRoomNo.Enabled = false; // Block changes to Primary Key
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            adminPage admin = new adminPage();
            admin.Show();
            this.Hide();
        }
    }


}
