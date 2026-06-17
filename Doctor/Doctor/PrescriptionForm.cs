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
    public partial class PrescriptionForm : Form
    {
        public int AppointmentID;
        public PrescriptionForm()
        {
            InitializeComponent();
        }

        private void PrescriptionForm_Load(object sender, EventArgs e)
        {
            MySqlConnection con = DB.GetConnection();

            string query =
            "SELECT medicine_name FROM medicines";

            MySqlCommand cmd =
            new MySqlCommand(query, con);

            con.Open();

            MySqlDataReader dr =
            cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbMedicine.Items.Add(
                dr["medicine_name"].ToString());
            }

            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbMedicine.Text != "")
            {
                lstDrugs.Items.Add(
                cmbMedicine.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection con =
   DB.GetConnection();

            con.Open();

            string sql =
            @"INSERT INTO prescriptions
    (appointment_id,
    diagnosis,
    instructions)
    VALUES
    (@id,
    '',
    @ins)";

            MySqlCommand cmd =
            new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue(
            "@id",
            AppointmentID);

            cmd.Parameters.AddWithValue(
            "@ins",
            txtDescription.Text);

            cmd.ExecuteNonQuery();

            string update =
            @"UPDATE appointments
      SET status='Completed'
      WHERE appointment_id=@id";

            MySqlCommand cmd2 =
            new MySqlCommand(update, con);

            cmd2.Parameters.AddWithValue(
            "@id",
            AppointmentID);

            cmd2.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(
            "Prescription Saved");

            this.Close();
        }
    }
}
