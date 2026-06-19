using MySql.Data.MySqlClient;
namespace Doctor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void LoadAppointments()
        {
            flowAppointments.Controls.Clear();

            MySqlConnection con = DB.GetConnection();

            string query =
            @"SELECT
      a.appointment_id,
      p.full_name,
      a.appointment_time,
      a.reason
      FROM appointments a
      INNER JOIN patients p
      ON a.patient_id=p.patient_id
      WHERE a.appointment_date=CURDATE()
      AND a.status='Pending'
      ORDER BY a.appointment_time";

            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Panel p = new Panel();

                p.Width = 750;
                p.Height = 70;
                p.BackColor = Color.White;
                p.BorderStyle = BorderStyle.FixedSingle;

                int appointmentId =
                Convert.ToInt32(dr["appointment_id"]);

                p.Tag = appointmentId;

                Label lbl1 = new Label();
                TimeSpan time =
                (TimeSpan)dr["appointment_time"];

                lbl1.Text =
                DateTime.Today.Add(time)
                .ToString("hh:mm tt");

                lbl1.Location = new Point(20, 25);

                Label lbl2 = new Label();
                lbl2.Text = dr["full_name"].ToString();
                lbl2.Location = new Point(150, 15);
                lbl2.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

                Label lbl3 = new Label();
                lbl3.Text = dr["reason"].ToString();
                lbl3.Location = new Point(150, 40);

                p.Controls.Add(lbl1);
                p.Controls.Add(lbl2);
                p.Controls.Add(lbl3);

                p.Click += Appointment_Click;

                flowAppointments.Controls.Add(p);
            }

            con.Close();
        }
        private void Appointment_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;

            int appointmentId =
            Convert.ToInt32(p.Tag);

            PrescriptionForm frm =
            new PrescriptionForm();

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
            MySqlConnection con = DB.GetConnection();

            string query =
            "SELECT doctor_name FROM doctors WHERE doctor_id = 1";

            MySqlCommand cmd =
            new MySqlCommand(query, con);

            con.Open();

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                lblWelcome.Text =
                "Welcome back,\n" + result.ToString();
            }

            con.Close();
        }

        private void LoadTotalPatients()
        {
            MySqlConnection con = DB.GetConnection();

            string query =
            "SELECT COUNT(*) FROM patients";

            MySqlCommand cmd =
            new MySqlCommand(query, con);

            con.Open();

            lblTotalPatients.Text =
            cmd.ExecuteScalar().ToString();

            con.Close();
        }

        private void LoadPendingAppointments()
        {
            MySqlConnection con = DB.GetConnection();

            string query =
            @"SELECT COUNT(*)
      FROM appointments
      WHERE appointment_date = CURDATE()
      AND status='Pending'";

            MySqlCommand cmd =
            new MySqlCommand(query, con);

            con.Open();

            lblPendingAppointments.Text =
            cmd.ExecuteScalar().ToString();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientForm frm = new PatientForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppointmentForm frm = new AppointmentForm();
            frm.Show();
        }
    }
}
