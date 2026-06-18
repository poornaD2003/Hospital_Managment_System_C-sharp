using BCrypt.Net;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Project_01
{
    public partial class doctorDataEdit : Form
    {
        int currentUserId;
        public doctorDataEdit(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }

        private void imageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                openFile.Title = "Select Patient Image";
                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    pictureBox1.Image = Image.FromFile(openFile.FileName);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string doctorName = nameBox.Text;
            string oldPassword = oldpasBox.Text;
            string newPassword = newpassBox.Text;
            string email = emailBox.Text;
            string phoneNumber = numberBox.Text;
            string specialization = speBox.Text;
            string address = adressBox.Text;
            string age = ageBox.Text;
            string sex = genderBox.SelectedItem?.ToString() ?? "";
            string date = dateBox.Text;
            string time = timeBox.Text;

            byte[] patientImg = GetImageBytes(pictureBox1);

            if (string.IsNullOrWhiteSpace(doctorName) || string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please fill in the Name, Old Password, and New Password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string queryUser = "SELECT  password FROM [User] WHERE userId = @userId AND roleType = 'Doctor'";
                    string storedHash = string.Empty;

                    using (SqlCommand cmdUser = new SqlCommand(queryUser, conn))
                    {
                        cmdUser.Parameters.AddWithValue("@userId", currentUserId);
                        using (SqlDataReader reader = cmdUser.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //userId = Convert.ToInt32(reader["UserId"]);
                                storedHash = reader["password"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Doctor username not found in system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    bool isPasswordCorrect = false;
                    try
                    {
                        isPasswordCorrect = BCrypt.Net.BCrypt.Verify(oldPassword, storedHash);
                    }
                    catch
                    {
                        isPasswordCorrect = (oldPassword == storedHash);
                    }

                    if (!isPasswordCorrect)
                    {
                        MessageBox.Show("The temporary password you entered is incorrect.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string updatePasswordQuery = "UPDATE [User] SET password = @newPassword WHERE UserId = @userId";
                            using (SqlCommand cmdUpdatePass = new SqlCommand(updatePasswordQuery, conn, transaction))
                            {
                                cmdUpdatePass.Parameters.AddWithValue("@newPassword", hashedNewPassword);
                                cmdUpdatePass.Parameters.AddWithValue("@userId", currentUserId);
                                cmdUpdatePass.ExecuteNonQuery();
                            }

                            string saveDoctorQuery = @"
                        IF EXISTS (SELECT 1 FROM [Doctor] WHERE doctorID = @doctorID)
                        BEGIN
                            UPDATE [Doctor] 
                            SET doctorName = @doctorName, password = @newPassword, email = @email, 
                                phoneNumber = @phoneNumber, address = @address, age = @age, sex = @sex, specialization = @specialization,
                                workDate = @workDate, workTime = @workTime, doctorImage = @doctorImage
                            WHERE doctorID = @doctorID
                        END
                        ELSE
                        BEGIN
                            INSERT INTO [Doctor] (doctorID, doctorName, password, email, phoneNumber, address, age, sex,specialization, workDate, workTime, doctorImage)
                            VALUES (@doctorID, @doctorName, @newPassword, @email, @phoneNumber, @address, @age, @sex,@specialization, @workDate, @workTime, @doctorImage)
                        END";

                            using (SqlCommand cmdDoctor = new SqlCommand(saveDoctorQuery, conn, transaction))
                            {
                                cmdDoctor.Parameters.AddWithValue("@doctorID", currentUserId); // Linking via matching User ID
                                cmdDoctor.Parameters.AddWithValue("@doctorName", doctorName);
                                cmdDoctor.Parameters.AddWithValue("@newPassword", hashedNewPassword); // Storing the new hash here too
                                cmdDoctor.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? DBNull.Value : (object)email);
                                cmdDoctor.Parameters.AddWithValue("@phoneNumber", string.IsNullOrEmpty(phoneNumber) ? DBNull.Value : (object)phoneNumber);
                                cmdDoctor.Parameters.AddWithValue("@address", string.IsNullOrEmpty(address) ? DBNull.Value : (object)address);
                                cmdDoctor.Parameters.AddWithValue("@age", string.IsNullOrEmpty(age) ? DBNull.Value : (object)Convert.ToInt32(age));
                                cmdDoctor.Parameters.AddWithValue("@sex", string.IsNullOrEmpty(sex) ? DBNull.Value : (object)sex);
                                cmdDoctor.Parameters.AddWithValue("@specialization", string.IsNullOrEmpty(specialization) ? DBNull.Value : (object)specialization); cmdDoctor.Parameters.AddWithValue("@workDate", string.IsNullOrEmpty(date) ? DBNull.Value : (object)date);
                                cmdDoctor.Parameters.AddWithValue("@workTime", string.IsNullOrEmpty(time) ? DBNull.Value : (object)time);
                                cmdDoctor.Parameters.AddWithValue("@doctorImage", patientImg == null ? DBNull.Value : (object)patientImg);

                                cmdDoctor.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Profile updated and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("An error occurred during database save: " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
