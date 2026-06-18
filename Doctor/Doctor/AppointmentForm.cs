using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Doctor
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            MySqlConnection con = DB.GetConnection();

            string query =
            @"SELECT
      a.appointment_id,
      p.full_name,
      d.doctor_name,
      a.appointment_date,
      a.appointment_time,
      a.reason,
      a.status
      FROM appointments a
      INNER JOIN patients p
      ON a.patient_id = p.patient_id
      INNER JOIN doctors d
      ON a.doctor_id = d.doctor_id
      ORDER BY a.appointment_date DESC,
      a.appointment_time DESC";

            MySqlDataAdapter da =
            new MySqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvAppointments.DataSource = dt;

            foreach (DataGridViewRow row in dgvAppointments.Rows)
            {
                if (row.Cells["status"].Value == null)
                    continue;

                string status =
                row.Cells["status"].Value.ToString();

                if (status == "Pending")
                {
                    row.DefaultCellStyle.BackColor =
                    Color.LightYellow;
                }

                if (status == "Completed")
                {
                    row.DefaultCellStyle.BackColor =
                    Color.LightGreen;
                }

                if (status == "Cancelled")
                {
                    row.DefaultCellStyle.BackColor =
                    Color.LightPink;
                }
            }
        }
    }
}
