using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Doctor
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int patientId = Convert.ToInt32(dgvPatients.CurrentRow.Cells[0].Value);
            LoadHistory(patientId);
        }

        private void LoadHistory(int patientId)
        {
            txtHistory.Clear();

            MySqlConnection con =
            DB.GetConnection();

            string query =
            @"SELECT
      p.created_at,
      p.diagnosis,
      p.instructions
      FROM prescriptions p
      INNER JOIN appointments a
      ON p.appointment_id=a.appointment_id
      WHERE a.patient_id=@id
      ORDER BY p.created_at DESC";

            MySqlCommand cmd =
            new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue(
            "@id",
            patientId);

            con.Open();

            MySqlDataReader dr =
            cmd.ExecuteReader();

            while (dr.Read())
            {
                txtHistory.AppendText(
                "Date : " +
                dr["created_at"] +
                Environment.NewLine);

                txtHistory.AppendText(
                "Diagnosis : " +
                dr["diagnosis"] +
                Environment.NewLine);

                txtHistory.AppendText(
                "Notes : " +
                dr["instructions"] +
                Environment.NewLine);

                txtHistory.AppendText(
                "------------------------"
                + Environment.NewLine);
            }

            con.Close();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
        {
            dgvPatients.Rows.Clear();

            MySqlConnection con = DB.GetConnection();

            string query =
            @"SELECT *
      FROM patients
      ORDER BY created_at DESC";

            MySqlCommand cmd =
            new MySqlCommand(query, con);

            con.Open();

            MySqlDataReader dr =
            cmd.ExecuteReader();

            while (dr.Read())
            {
                dgvPatients.Rows.Add(
                    dr["patient_id"],
                    dr["full_name"],
                    dr["gender"],
                    dr["age"],
                    dr["phone"]
                );
            }

            con.Close();
        }


    }
}
