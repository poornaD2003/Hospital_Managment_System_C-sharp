using BCrypt.Net;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Project_01
{
    public partial class signUp : Form
    {
        private login _parentForm;


        public signUp(login form1Instance)
        {
            InitializeComponent();
            _parentForm = form1Instance;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void signUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private string GetNextPatientID(SqlConnection conn)
        {
            string nextID = "P001";      
            string query = "SELECT TOP 1 patientID FROM [patient] ORDER BY patientID DESC";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string lastID = result.ToString();
                        if (lastID.Length > 1)
                        {
                            int lastNumber = int.Parse(lastID.Substring(1));
                            int nextNumber = lastNumber + 1;
                            nextID = "P" + nextNumber.ToString("D3");
                        }
                    }
                }
            }
            catch { /* If query fails, it will fall back to P001 */ }

            return nextID;
        }
        private void signupBtn_Click(object sender, EventArgs e)
        {
            string username = userNameField.Text;
            string password = passswordField.Text;

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            string phoneNumber = phoneNumberField.Text;
            string email = emailField.Text;
            string address = addressField.Text;
            int age = (int)ageField.Value;
            string sex = sexField.SelectedItem?.ToString() ?? "";
            string bloodGroup = bloodField.SelectedItem?.ToString() ?? "";


            byte[] patientImg = GetImageBytes(imageBox);

            


            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string newPatientID = GetNextPatientID(conn);
                    string query = "INSERT INTO [patient] (patientID, password, email, phoneNumber, address, age, sex, bloodGroup, userName, patientImage) " +
                                   "VALUES (@id, @pass, @email, @phone, @address, @age, @sex, @blood, @user, @img)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", newPatientID);
                    cmd.Parameters.AddWithValue("@pass", passwordHash);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@blood", bloodGroup);
                    cmd.Parameters.AddWithValue("@user", username);

                    if (patientImg != null)
                    {
                        cmd.Parameters.AddWithValue("@img", patientImg);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@img", DBNull.Value);
                    }
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show($"User registered successfully! Your ID is: {newPatientID}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private byte[] GetImageBytes(PictureBox pb)
        {
            if (pb.Image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                pb.Image.Save(ms, pb.Image.RawFormat);
                return ms.ToArray();
            }
        }

        private void imageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog()) {
                openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                openFile.Title = "Select Patient Image";
                if (openFile.ShowDialog() == DialogResult.OK) { 
                    
                    imageBox.Image= Image.FromFile(openFile.FileName);
                }
            }
        }
    }
}
