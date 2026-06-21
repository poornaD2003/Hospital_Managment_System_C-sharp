using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using BCrypt.Net;


namespace Project_01
{
    public partial class doctorPageEdit : Form
    {
        public doctorPageEdit()
        {
            InitializeComponent();
            LoadDoctors();
            StyleDataGridView();
        }
        private void StyleDataGridView()
        {
            dgvDoctors.AllowUserToAddRows = false; 
            dgvDoctors.ReadOnly = false; 
            dgvDoctors.BackgroundColor = Color.White;
            dgvDoctors.BorderStyle = BorderStyle.None;
            dgvDoctors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDoctors.GridColor = Color.FromArgb(235, 238, 242); 

            dgvDoctors.RowHeadersVisible = false; 
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.MultiSelect = false;

            dgvDoctors.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvDoctors.RowTemplate.Height = 40; 

            dgvDoctors.EnableHeadersVisualStyles = false; 
            dgvDoctors.ColumnHeadersHeight = 45;
            dgvDoctors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvDoctors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 54, 93);
            dgvDoctors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDoctors.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDoctors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvDoctors.RowsDefaultCellStyle.BackColor = Color.White;
            dgvDoctors.RowsDefaultCellStyle.ForeColor = Color.FromArgb(45, 55, 72);
            dgvDoctors.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 242, 247); 
            dgvDoctors.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(26, 54, 93);

            dgvDoctors.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 250, 252); 

            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctors.AllowUserToResizeRows = false;
        }
        private void LoadDoctors()
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                string query = "SELECT doctorID, doctorName, email, phoneNumber, address, age, sex, specialization, workDate, workTime, doctorImage FROM doctor";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoctors.DataSource = dt;

                if (dgvDoctors.Columns.Contains("doctorImage"))
                {
                    dgvDoctors.Columns["doctorImage"].Visible = false;
                }

                if (dgvDoctors.Columns.Contains("doctorID"))
                {
                    dgvDoctors.Columns["doctorID"].ReadOnly = true;
                }

                if (dgvDoctors.Columns.Contains("sex"))
                {
                    int sexIndex = dgvDoctors.Columns["sex"].Index;

                    dgvDoctors.Columns.Remove("sex");

                    DataGridViewComboBoxColumn comboSex = new DataGridViewComboBoxColumn();
                    comboSex.Name = "sex";
                    comboSex.HeaderText = "sex";
                    comboSex.DataPropertyName = "sex"; 

                    comboSex.Items.Add("Male");
                    comboSex.Items.Add("Female");

                    dgvDoctors.Columns.Insert(sexIndex, comboSex);
                }

                dgvDoctors.CellValueChanged -= dgvDoctors_CellValueChanged;

                dgvDoctors.DataSource = dt;

                dgvDoctors.CellValueChanged += dgvDoctors_CellValueChanged;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void doctorPageEdit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (doctorRegestor addForm = new doctorRegestor())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDoctors(); 
                }
            }
        }
        string selectedImagePath = "";
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;

                    picDoctor.Image = Image.FromFile(selectedImagePath);
                    picDoctor.SizeMode = PictureBoxSizeMode.Zoom; 
                }
            }
        }

        private void dgvDoctors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvDoctors.Rows[e.RowIndex].Cells["doctorID"].Value == null)
                return;

            DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];
            string doctorId = row.Cells["doctorID"].Value.ToString();

            string columnName = dgvDoctors.Columns[e.ColumnIndex].Name;
            var updatedValue = row.Cells[e.ColumnIndex].Value ?? DBNull.Value;

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                string query = $"UPDATE doctor SET [{columnName}] = @newValue WHERE doctorID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@newValue", updatedValue);
                    cmd.Parameters.AddWithValue("@id", doctorId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];

                txtID.Text = row.Cells["doctorID"].Value?.ToString();
                txtName.Text = row.Cells["doctorName"].Value?.ToString();
                txtEmail.Text = row.Cells["email"].Value?.ToString();
                txtPhone.Text = row.Cells["phoneNumber"].Value?.ToString();
                txtAddress.Text = row.Cells["address"].Value?.ToString();
                txtAge.Text = row.Cells["age"].Value?.ToString();
                txtSpecialization.Text = row.Cells["specialization"].Value?.ToString();

                cmbSex.SelectedItem = row.Cells["sex"].Value?.ToString();

                if (row.Cells["doctorImage"].Value != DBNull.Value && row.Cells["doctorImage"].Value != null)
                {
                    byte[] imgData = (byte[])row.Cells["doctorImage"].Value;

                    if (imgData.Length > 1)
                    {
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imgData))
                        {
                            picDoctor.Image = Image.FromStream(ms);
                            picDoctor.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    else
                    {
                        picDoctor.Image = null; 
                    }
                }
                else
                {
                    picDoctor.Image = null; 
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please click on a doctor from the list first to update their record.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid numeric age.");
                return;
            }

            if (cmbSex.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            byte[] imgData = null;
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                imgData = System.IO.File.ReadAllBytes(selectedImagePath);
            }

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                string query = "UPDATE doctor SET doctorName = @name, email = @email, " +
                               "phoneNumber = @phone, address = @address, age = @age, sex = @sex, " +
                               "specialization = @spec";

                bool isPasswordChanged = !string.IsNullOrWhiteSpace(txtPassword.Text);
                if (isPasswordChanged)
                {
                    query += ", password = @pass";
                }

                if (imgData != null)
                {
                    query += ", doctorImage = @image";
                }

                query += " WHERE doctorID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text)); 
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@sex", cmbSex.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@spec", txtSpecialization.Text);

                    if (isPasswordChanged)
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text); 
                        cmd.Parameters.AddWithValue("@pass", hashedPassword);
                    }

                    if (imgData != null)
                    {
                        cmd.Parameters.AddWithValue("@image", imgData);
                    }

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor details updated successfully!");
                        txtPassword.Text = "";

                        LoadDoctors(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating record: " + ex.Message);
                    }
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminPage admin = new adminPage();
            admin.Show();
            this.Hide(); 
        }
    }
}
