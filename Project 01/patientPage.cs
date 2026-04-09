using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Project_01
{
    public partial class patientPage : Form
    {
        string patientID;
        public patientPage(string patientID)
        {
            InitializeComponent();
            this.patientID = patientID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

                            MessageBox.Show("PDF එක සාර්ථකව සාදා නිම කරන ලදී!");

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

        private void button1_Click(object sender, EventArgs e)
        {
            patientPage patientPage = new patientPage(patientID);
            patientPage.ExportPatientToPDF(patientID);
        }
    }
}
