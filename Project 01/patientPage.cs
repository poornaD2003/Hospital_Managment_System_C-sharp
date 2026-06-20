using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace Project_01
{
    public partial class patientPage : Form
    {
        private string patientID;

        public patientPage(string patientID)
        {
            InitializeComponent();
            this.patientID = patientID;
        }

        private void patientPage_Load(object sender, EventArgs e)
        {
            LoadPatientSummary();
        }

        private void LoadPatientSummary()
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT userName, email, phoneNumber, address, age, sex, bloodGroup FROM patient WHERE patientID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", patientID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["userName"].ToString();
                                string email = reader["email"].ToString();
                                string phone = reader["phoneNumber"].ToString();
                                string address = reader["address"].ToString();
                                string age = reader["age"].ToString();
                                string sex = reader["sex"].ToString();
                                string blood = reader["bloodGroup"].ToString();

                                lblWelcome.Text = "Welcome, " + name + "!";
                                lblProfileDetails.Text = "PATIENT INFORMATION SUMMARY\n\n" +
                                                         "Patient ID:    " + patientID + "\n" +
                                                         "Name:          " + name + "\n" +
                                                         "Email:         " + email + "\n" +
                                                         "Phone:         " + phone + "\n" +
                                                         "Age / Sex:     " + age + " / " + sex + "\n" +
                                                         "Blood Group:   " + blood + "\n" +
                                                         "Address:       " + address;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBookAppt_Click(object sender, EventArgs e)
        {
            patientBookAppointment frm = new patientBookAppointment(patientID);
            frm.ShowDialog();
            LoadPatientSummary(); // Refresh summary if updated
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            patientDataEdit frm = new patientDataEdit(patientID);
            frm.ShowDialog();
            LoadPatientSummary(); // Refresh summary in case name/details updated
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportPatientToPDF(patientID);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login loginPage = new login(null);
            loginPage.Show();
            this.Hide();
        }

        private void patientPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void ExportPatientToPDF(string patientId)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                string query = "SELECT email, phoneNumber, address, age, sex, bloodGroup, userName, patientImage FROM patient WHERE patientID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", patientId);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["userName"].ToString();
                            string address = reader["address"].ToString();
                            string age = reader["age"].ToString();
                            string email = reader["email"].ToString();
                            string phoneNumber = reader["phoneNumber"].ToString();
                            string sex = reader["sex"].ToString();
                            string bloodGroup = reader["bloodGroup"].ToString();

                            byte[] imageBytes = reader["patientImage"] as byte[];

                            Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                            string fullPath = Path.Combine(downloadsPath, "Patient_Report.pdf");

                            PdfWriter.GetInstance(doc, new FileStream(fullPath, FileMode.Create));
                            doc.Open();

                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                try
                                {
                                    iTextSharp.text.Image pdfImg = iTextSharp.text.Image.GetInstance(imageBytes);
                                    pdfImg.ScaleToFit(100f, 100f);
                                    pdfImg.Alignment = iTextSharp.text.Element.ALIGN_RIGHT;
                                    doc.Add(pdfImg);
                                }
                                catch (Exception imgEx)
                                {
                                    doc.Add(new Paragraph("[Error loading image: " + imgEx.Message + "]"));
                                }
                            }

                            doc.Add(new Paragraph("PATIENT REPORT"));
                            doc.Add(new Paragraph("---------------------------------"));
                            doc.Add(new Paragraph("Name: " + name));
                            doc.Add(new Paragraph("Address: " + address));
                            doc.Add(new Paragraph("Age: " + age));
                            doc.Add(new Paragraph("Email: " + email));
                            doc.Add(new Paragraph("Phone Number: " + phoneNumber));
                            doc.Add(new Paragraph("Sex: " + sex));
                            doc.Add(new Paragraph("Blood Group: " + bloodGroup));
                            doc.Add(new Paragraph("Date: " + DateTime.Now.ToString()));

                            doc.Close();

                            MessageBox.Show("Successfully Created PDF");

                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = fullPath,
                                UseShellExecute = true
                            };
                            Process.Start(psi);
                        }
                        else
                        {
                            MessageBox.Show("Patient record not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
