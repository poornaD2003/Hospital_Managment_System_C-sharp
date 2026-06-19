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
    public partial class PatientForm : Form
    {
        private string _doctorUsername;

        public PatientForm()
        {
            InitializeComponent();
        }

        public PatientForm(string doctorUsername) : this()
        {
            _doctorUsername = doctorUsername;
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // patientID is a string (varchar) in the database
            string patientId = dgvPatients.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (!string.IsNullOrEmpty(patientId))
                LoadHistory(patientId);
        }

        private void LoadHistory(string patientId)
        {
            txtHistory.Clear();

            SqlConnection con =
            dbConnection.GetConnection();

            string query =
            @"SELECT
      p.date AS created_at,
      ISNULL(mr.diagnosis, 'N/A') AS diagnosis,
      ISNULL(mr.testResults, 'N/A') AS instructions,
      p.prescriptionID,
      ISNULL(d.doctorName, 'N/A') AS doctorName,
      ISNULL(m.medicine_name, 'N/A') AS medicine,
      ISNULL(pd.dosage, 'N/A') AS dosage
      FROM prescriptions p
      INNER JOIN appoinment a
      ON p.appoinmentID=a.appointmentID
      LEFT JOIN medicalReport mr
      ON a.appointmentID=mr.appoinmentID
      LEFT JOIN doctor d
      ON p.doctorID=d.doctorID
      LEFT JOIN prescriptionDetails pd
      ON p.prescriptionID=pd.prescriptionID
      LEFT JOIN medicine m
      ON pd.medicineID=CAST(m.medicine_id AS VARCHAR)
      WHERE a.patientID=@id
      ORDER BY p.date DESC";

            SqlCommand cmd =
            new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
            "@id",
            patientId);

            con.Open();

            SqlDataReader dr =
            cmd.ExecuteReader();

            while (dr.Read())
            {
                txtHistory.AppendText(
                "Date : " +
                dr["created_at"].ToString() +
                Environment.NewLine);

                txtHistory.AppendText(
                "Doctor : " +
                dr["doctorName"] +
                Environment.NewLine);

                txtHistory.AppendText(
                "Diagnosis : " +
                dr["diagnosis"] +
                Environment.NewLine);

                txtHistory.AppendText(
                "Test Results : " +
                dr["instructions"] +
                Environment.NewLine);

                txtHistory.AppendText(
                "Medicine : " +
                dr["medicine"] +
                Environment.NewLine);

                txtHistory.AppendText(
                "Dosage : " +
                dr["dosage"] +
                Environment.NewLine);

                txtHistory.AppendText(
                "Prescription ID : " +
                dr["prescriptionID"] +
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadPatients(txtSearch.Text.Trim());
        }

        private void LoadPatients(string searchTerm = "")
        {
            dgvPatients.Rows.Clear();

            SqlConnection con = dbConnection.GetConnection();

            string query =
            @"SELECT DISTINCT p.patientID, p.userName, p.sex, p.age, p.phoneNumber
        FROM patient p
        INNER JOIN appoinment a ON p.patientID = a.patientID
        INNER JOIN doctor d ON a.doctorID = d.doctorID
        WHERE d.doctorName LIKE @doctorName";

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query += " AND (p.userName LIKE @search OR p.phoneNumber LIKE @search)";
            }

            SqlCommand cmd =
            new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@doctorName", "%" + (_doctorUsername ?? "") + "%");

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
            }

            con.Open();

            SqlDataReader dr =
            cmd.ExecuteReader();

            while (dr.Read())
            {
                dgvPatients.Rows.Add(
                    dr["patientID"],
                    dr["userName"],
                    dr["sex"],
                    dr["age"],
                    dr["phoneNumber"]
                );
            }

            con.Close();
        }


    }
}
