using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project_01
{
    public partial class patientBookAppointment : Form
    {
        private string patientID;
        private int selectedDoctorId = -1;

        public patientBookAppointment(string patientID)
        {
            InitializeComponent();
            this.patientID = patientID;
        }

        private void patientBookAppointment_Load(object sender, EventArgs e)
        {
            dtpDate.MinDate = DateTime.Today;
            LoadDoctorsList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDoctorsList(txtSearch.Text.Trim());
        }

        private void LoadDoctorsList(string search = "")
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    string sql = "SELECT doctorID AS [ID], doctorName AS [Doctor Name], specialization AS [Specialization], workDate AS [Available Days], workTime AS [Available Hours] FROM doctor";
                    
                    if (!string.IsNullOrEmpty(search))
                    {
                        sql += " WHERE doctorName LIKE @search OR specialization LIKE @search";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (!string.IsNullOrEmpty(search))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvDoctors.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDoctors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDoctors.SelectedRows[0];
                selectedDoctorId = Convert.ToInt32(row.Cells["ID"].Value);
                txtSelectedDoc.Text = row.Cells["Doctor Name"].Value.ToString() + " (" + row.Cells["Specialization"].Value.ToString() + ")";
            }
            else
            {
                selectedDoctorId = -1;
                txtSelectedDoc.Clear();
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (selectedDoctorId == -1)
            {
                MessageBox.Show("Please select a doctor from the list above.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTime.SelectedItem == null)
            {
                MessageBox.Show("Please select a time slot.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime date = dtpDate.Value.Date;
            string timeStr = cmbTime.SelectedItem.ToString();
            TimeSpan time = DateTime.Parse(timeStr).TimeOfDay;

            string reason = txtReason.Text.Trim();
            if (string.IsNullOrEmpty(reason))
            {
                reason = "Routine Checkup";
            }

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string checkSql = "SELECT COUNT(*) FROM appoinment WHERE doctorID = @docId AND appoinmentDate = @date AND appointmentTime = @time";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@docId", selectedDoctorId);
                        checkCmd.Parameters.AddWithValue("@date", date);
                        checkCmd.Parameters.AddWithValue("@time", time);

                        int bookedCount = (int)checkCmd.ExecuteScalar();
                        if (bookedCount > 0)
                        {
                            MessageBox.Show("This time slot is already booked for this doctor. Please select another slot.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertSql = "INSERT INTO appoinment (patientID, doctorID, appoinmentDate, appointmentTime, note) VALUES (@patId, @docId, @date, @time, @note)";
                    using (SqlCommand insertCmd = new SqlCommand(insertSql, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@patId", patientID);
                        insertCmd.Parameters.AddWithValue("@docId", selectedDoctorId);
                        insertCmd.Parameters.AddWithValue("@date", date);
                        insertCmd.Parameters.AddWithValue("@time", time);
                        insertCmd.Parameters.AddWithValue("@note", reason);

                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Appointment scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error scheduling appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
