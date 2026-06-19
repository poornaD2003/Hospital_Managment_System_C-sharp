using Microsoft.Data.SqlClient;
namespace Project_01
{
    public partial class Form1 : Form
    {

        private string _doctorUsername;

       

        private int currentUserId;
        public Form1(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppointmentForm frm = new AppointmentForm(_doctorUsername);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDoctorInfo();
            LoadTotalPatients();
            LoadPendingAppointments();
            LoadAppointments();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "  Search patients, appointments...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "  Search patients, appointments...";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void LoadAppointments()
        {
            flowAppointments.Controls.Clear();

            try
            {
                using (SqlConnection con = dbConnection.GetConnection())
                {
                    string query =
                    @"SELECT
          a.appointmentID,
          p.patientID,
          p.userName AS full_name,
          a.appointmentTime,
          a.note
          FROM appoinment a
          INNER JOIN patient p
          ON a.patientID=p.patientID
          INNER JOIN doctor d
          ON a.doctorID=d.doctorID
          WHERE CAST(a.appoinmentDate AS DATE) = CAST(GETDATE() AS DATE)
          AND (a.note IS NULL OR a.note <> 'Completed')
          AND d.doctorName LIKE @doctorName
          ORDER BY a.appointmentTime";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@doctorName", "%" + (_doctorUsername ?? "") + "%");
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Panel p = new Panel();
                        p.Width = 780;
                        p.Height = 75;
                        p.BackColor = Color.White;
                        p.BorderStyle = BorderStyle.FixedSingle;
                        p.Cursor = Cursors.Hand;
                        p.Margin = new Padding(0, 0, 0, 5);

                        string appointmentId = dr["appointmentID"].ToString();
                        p.Tag = appointmentId;

                        Panel accentBar = new Panel();
                        accentBar.BackColor = Color.DarkGreen;
                        accentBar.Width = 6;
                        accentBar.Height = 75;
                        accentBar.Location = new Point(0, 0);

                        Label lbl1 = new Label();
                        TimeSpan time = (TimeSpan)dr["appointmentTime"];
                        lbl1.Text = DateTime.Today.Add(time).ToString("hh:mm tt");
                        lbl1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        lbl1.ForeColor = Color.DarkGreen;
                        lbl1.Location = new Point(25, 22);
                        lbl1.AutoSize = true;

                        Label lbl2 = new Label();
                        string nameText = dr["full_name"].ToString();
                        lbl2.Text = nameText;
                        lbl2.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        lbl2.AutoSize = true;
                        // calculate left position based on measured width of time label
                        Size timeSize = TextRenderer.MeasureText(lbl1.Text, lbl1.Font);
                        int leftPos = 25 + timeSize.Width + 20;
                        lbl2.Location = new Point(leftPos, 12);

                        Label lbl3 = new Label();
                        lbl3.Text = dr["note"].ToString();
                        lbl3.ForeColor = Color.Gray;
                        lbl3.AutoSize = true;
                        // align notes under the patient name
                        lbl3.Location = new Point(leftPos, 42);

                        // show patientID next to name for clarity
                        Label lblId = new Label();
                        string pid = dr["patientID"].ToString();
                        lblId.Text = pid;
                        lblId.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                        lblId.ForeColor = Color.DarkSlateGray;
                        lblId.AutoSize = true;
                        Size nameSize = TextRenderer.MeasureText(nameText, lbl2.Font);
                        lblId.Location = new Point(leftPos + nameSize.Width + 10, 12);

                        Label arrow = new Label();
                        arrow.Text = "\u276F";
                        arrow.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        arrow.ForeColor = Color.FromArgb(200, 200, 200);
                        arrow.Location = new Point(740, 25);
                        arrow.AutoSize = true;

                        p.Controls.Add(accentBar);
                        p.Controls.Add(lbl1);
                        p.Controls.Add(lbl2);
                        p.Controls.Add(lbl3);
                        p.Controls.Add(arrow);

                        EventHandler clickHandler = (s, args) => Appointment_Click(p, EventArgs.Empty);
                        p.Click += clickHandler;
                        accentBar.Click += clickHandler;
                        lbl1.Click += clickHandler;
                        lbl2.Click += clickHandler;
                        lbl3.Click += clickHandler;
                        arrow.Click += clickHandler;

                        flowAppointments.Controls.Add(p);
                    }
                }
            }
            catch
            {
                Label err = new Label();
                err.Text = "Could not load appointments.";
                err.ForeColor = Color.Red;
                flowAppointments.Controls.Add(err);
            }
        }

        private void Appointment_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;

            string appointmentId = p.Tag.ToString();

            PrescriptionForm frm = new PrescriptionForm();
            frm.AppointmentID = appointmentId;
            frm.ShowDialog();
            LoadAppointments();
        }

        private void flowAppointments_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadDoctorInfo();
            LoadTotalPatients();
            LoadPendingAppointments();
            LoadAppointments();
        }

        private void LoadDoctorInfo()
        {
            try
            {

                string searchName = _doctorUsername ?? "";
             

                using (SqlConnection con = dbConnection.GetConnection())

                {
                    string query = "SELECT doctorName, specialization FROM doctor WHERE doctorName LIKE @name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", "%" + searchName + "%");
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["doctorName"].ToString();
                            lblWelcome.Text = "Welcome back,\n" + name;
                            label3.Text = "Dr. " + name;
                            label4.Text = reader["specialization"] != null && !string.IsNullOrWhiteSpace(reader["specialization"].ToString())
                                ? reader["specialization"].ToString() : "General Practitioner";
                        }
                        else
                        {
                            lblWelcome.Text = "Welcome back,\n" + searchName;
                            label3.Text = "Dr. " + (string.IsNullOrEmpty(searchName) ? "Doctor" : searchName);
                            label4.Text = "General Practitioner";
                        }
                    }
                }


                using (SqlConnection con = dbConnection.GetConnection())
                {
                    string query = "SELECT specialization FROM doctor WHERE doctorID = '1'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    object spec = cmd.ExecuteScalar();
                    label4.Text = spec != null && !string.IsNullOrWhiteSpace(spec.ToString())
                        ? spec.ToString() : "General Practitioner";
                }

            }
            catch
            {
                lblWelcome.Text = "Welcome back,\n" + (string.IsNullOrEmpty(_doctorUsername) ? "Doctor" : _doctorUsername);
                label3.Text = "Dr. " + (string.IsNullOrEmpty(_doctorUsername) ? "Doctor" : _doctorUsername);
                label4.Text = "General Practitioner";
            }
        }

        private void LoadTotalPatients()
        {
            try
            {
                using (SqlConnection con = dbConnection.GetConnection())
                {
                    string query =
                    @"SELECT COUNT(DISTINCT p.patientID)
                    FROM patient p
                    INNER JOIN appoinment a ON p.patientID = a.patientID
                    INNER JOIN doctor d ON a.doctorID = d.doctorID
                    WHERE d.doctorName LIKE @doctorName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@doctorName", "%" + (_doctorUsername ?? "") + "%");
                    con.Open();
                    lblTotalPatients.Text = cmd.ExecuteScalar().ToString();
                }
            }
            catch
            {
                lblTotalPatients.Text = "0";
            }
        }

        private void LoadPendingAppointments()
        {
            try
            {
                using (SqlConnection con = dbConnection.GetConnection())
                {
                    string query =
                    @"SELECT COUNT(*)
          FROM appoinment a
          INNER JOIN doctor d ON a.doctorID = d.doctorID
          WHERE CAST(a.appoinmentDate AS DATE) = CAST(GETDATE() AS DATE)
          AND (a.note IS NULL OR a.note <> 'Completed')
          AND d.doctorName LIKE @doctorName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@doctorName", "%" + (_doctorUsername ?? "") + "%");
                    con.Open();
                    lblPendingAppointments.Text = cmd.ExecuteScalar().ToString();
                }
            }
            catch
            {
                lblPendingAppointments.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientForm frm = new PatientForm(_doctorUsername);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppointmentForm frm = new AppointmentForm(_doctorUsername);
            frm.Show();
        }


        private void lblWelcome_Click(object sender, EventArgs e)
        { }

        private void button4_Click_1(object sender, EventArgs e)
        {
            doctorDataEdit editData = new doctorDataEdit(currentUserId);
            editData.Show();

        }
    }
}

