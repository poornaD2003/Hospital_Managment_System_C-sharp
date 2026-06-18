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
    public partial class AppointmentForm : Form
    {
        private bool showAll = false;

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;
            showAll = false;
            LoadAppointments();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            showAll = false;
            LoadAppointments();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showAll = true;
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            SqlConnection con = dbConnection.GetConnection();

            string query =
            @"SELECT
      a.appointmentID,
    p.userName AS Patient,
    d.doctorName AS Doctor,
      a.appoinmentDate AS Date,
      a.appointmentTime AS Time,
      a.note AS Reason,
      CASE WHEN a.note = 'Completed' THEN 'Completed' ELSE 'Pending' END AS Status
    FROM appoinment a
    INNER JOIN patient p
    ON a.patientID = p.patientID
    INNER JOIN doctor d
    ON a.doctorID = d.doctorID";

            if (!showAll)
            {
                query += " WHERE CAST(a.appoinmentDate AS DATE) = @date";
            }

            query += " ORDER BY a.appoinmentDate DESC, a.appointmentTime DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            if (!showAll)
            {
                da.SelectCommand.Parameters.AddWithValue("@date", dtpDate.Value.Date);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAppointments.DataSource = dt;

            if (!showAll)
            {
                lblHeader.Text = "Appointments - " + dtpDate.Value.ToString("MMM dd, yyyy");
            }
            else
            {
                lblHeader.Text = "Appointments - All Dates";
            }

            foreach (DataGridViewRow row in dgvAppointments.Rows)
            {
                if (row.Cells["Status"].Value == null)
                    continue;

                string status = row.Cells["Status"].Value.ToString();

                if (status == "Pending")
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (status == "Completed")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (status == "Cancelled")
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
    }
}
