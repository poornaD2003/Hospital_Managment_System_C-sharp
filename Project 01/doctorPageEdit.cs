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
            dgvDoctors.AllowUserToAddRows = false; // Removes the blank row at the bottom
            dgvDoctors.ReadOnly = false; // Allows the user to type inside cells
            // --- Colors & Aesthetics ---
            dgvDoctors.BackgroundColor = Color.White;
            dgvDoctors.BorderStyle = BorderStyle.None;
            dgvDoctors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDoctors.GridColor = Color.FromArgb(235, 238, 242); // Soft subtle gridlines

            // --- Row Headers Configuration ---
            dgvDoctors.RowHeadersVisible = false; // Removes the empty far-left grey arrow column
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.MultiSelect = false;

            // --- Typography & Row Sizing ---
            dgvDoctors.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvDoctors.RowTemplate.Height = 40; // Gives cells spacious breathing room

            // --- Header Custom Styling ---
            dgvDoctors.EnableHeadersVisualStyles = false; // Overrides system defaults
            dgvDoctors.ColumnHeadersHeight = 45;
            dgvDoctors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Professional Medical Slate/Navy Color for headers
            dgvDoctors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 54, 93);
            dgvDoctors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDoctors.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDoctors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // --- Alternating Row Shades (Very Reader-Friendly) ---
            dgvDoctors.RowsDefaultCellStyle.BackColor = Color.White;
            dgvDoctors.RowsDefaultCellStyle.ForeColor = Color.FromArgb(45, 55, 72);
            dgvDoctors.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 242, 247); // Light grey selection track
            dgvDoctors.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(26, 54, 93);

            dgvDoctors.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 250, 252); // Soft alternate banding

            // --- Auto Scaling Layout ---
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctors.AllowUserToResizeRows = false;
        }
        private void LoadDoctors()
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                // Notice we leave out 'doctorImage' and 'password' so the grid doesn't crash trying to draw them
                string query = "SELECT doctorID, doctorName, email, phoneNumber, address, age, sex, specialization, workDate, workTime, doctorImage FROM doctor";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoctors.DataSource = dt;

                // Tells the grid layout engine to hide the binary column from the user's view
                if (dgvDoctors.Columns.Contains("doctorImage"))
                {
                    dgvDoctors.Columns["doctorImage"].Visible = false;
                }

                // Locks the doctorID column so it cannot be double-clicked or edited
                if (dgvDoctors.Columns.Contains("doctorID"))
                {
                    dgvDoctors.Columns["doctorID"].ReadOnly = true;
                }

                // ---- 2. Convert the 'sex' Column into a Drop-Down ----
                if (dgvDoctors.Columns.Contains("sex"))
                {
                    // Get the position index of the old text column
                    int sexIndex = dgvDoctors.Columns["sex"].Index;

                    // Remove the old plain text box column
                    dgvDoctors.Columns.Remove("sex");

                    // Create a new drop-down column setup
                    DataGridViewComboBoxColumn comboSex = new DataGridViewComboBoxColumn();
                    comboSex.Name = "sex";
                    comboSex.HeaderText = "sex";
                    comboSex.DataPropertyName = "sex"; // Links it directly to your database field

                    // Add the drop-down choices
                    comboSex.Items.Add("Male");
                    comboSex.Items.Add("Female");

                    // Put the new drop-down column exactly where the old one was
                    dgvDoctors.Columns.Insert(sexIndex, comboSex);
                }

                // Temporarily detach the event handler so loading data doesn't trigger a save loop
                dgvDoctors.CellValueChanged -= dgvDoctors_CellValueChanged;

                dgvDoctors.DataSource = dt;

                // Re-attach it once loading is finished
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
            // Open the new standalone registration sub-form as a blocking dialog window
            using (doctorRegestor addForm = new doctorRegestor())
            {
                // If the user saves successfully and the form closes with an OK result
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDoctors(); // Instantly reload our dashboard grid view tracking array
                }
            }
        }
        string selectedImagePath = "";
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Filter out non-image files so the user only picks graphics
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;

                    // Display the chosen photo inside your PictureBox
                    picDoctor.Image = Image.FromFile(selectedImagePath);
                    picDoctor.SizeMode = PictureBoxSizeMode.Zoom; // Fits the image nicely
                }
            }
        }

        private void dgvDoctors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Avoid running this when the form is still initializing data rows
            if (e.RowIndex < 0 || dgvDoctors.Rows[e.RowIndex].Cells["doctorID"].Value == null)
                return;

            // 1. Get the changed row and its corresponding Doctor ID
            DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];
            string doctorId = row.Cells["doctorID"].Value.ToString();

            // 2. Identify which column header was edited
            string columnName = dgvDoctors.Columns[e.ColumnIndex].Name;
            var updatedValue = row.Cells[e.ColumnIndex].Value ?? DBNull.Value;

            // 3. Update the database dynamically based on the edited cell
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                // Dynamically inject the column name safely into the query syntax
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
            // Make sure the user clicked an actual data row, not the header tracking row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];

                txtID.Text = row.Cells["doctorID"].Value?.ToString();
                // 1. Populate the Text Boxes safely
                txtName.Text = row.Cells["doctorName"].Value?.ToString();
                txtEmail.Text = row.Cells["email"].Value?.ToString();
                txtPhone.Text = row.Cells["phoneNumber"].Value?.ToString();
                txtAddress.Text = row.Cells["address"].Value?.ToString();
                txtAge.Text = row.Cells["age"].Value?.ToString();
                txtSpecialization.Text = row.Cells["specialization"].Value?.ToString();

                // Match the drop-down ComboBox selection
                cmbSex.SelectedItem = row.Cells["sex"].Value?.ToString();

                // 2. Fetch and Convert the Binary Image Column from the Database Row
                if (row.Cells["doctorImage"].Value != DBNull.Value && row.Cells["doctorImage"].Value != null)
                {
                    byte[] imgData = (byte[])row.Cells["doctorImage"].Value;

                    // Prevent a crash if it's just our default placeholder 0x01 byte array
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
                        picDoctor.Image = null; // Clear the box if it's only the dummy placeholder
                    }
                }
                else
                {
                    picDoctor.Image = null; // Clear the box if no image data exists
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Safety check: Ensure an existing doctor is actually selected from the grid
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

            // Capture image changes if a new one was uploaded
            byte[] imgData = null;
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                imgData = System.IO.File.ReadAllBytes(selectedImagePath);
            }

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                // Use an UPDATE statement targeted at the specific selected doctorID
                string query = "UPDATE doctor SET doctorName = @name, email = @email, " +
                               "phoneNumber = @phone, address = @address, age = @age, sex = @sex, " +
                               "specialization = @spec";

                bool isPasswordChanged = !string.IsNullOrWhiteSpace(txtPassword.Text);
                if (isPasswordChanged)
                {
                    query += ", password = @pass";
                }

                // Only update the image column if the user actually uploaded a new file
                if (imgData != null)
                {
                    query += ", doctorImage = @image";
                }

                query += " WHERE doctorID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text)); // Matches the hidden or tracking ID text box
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@sex", cmbSex.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@spec", txtSpecialization.Text);

                    if (isPasswordChanged)
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text); // <--- ඔයා පාවිච්චි කරන Hash function එක මෙතනට දාන්න (e.g. BCrypt, SHA256)
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

                        LoadDoctors(); // Refresh the grid to show the changes instantly
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
