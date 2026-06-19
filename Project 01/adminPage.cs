using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_01
{
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            doctorPageEdit docPage = new doctorPageEdit();
            docPage.Show();
            this.Hide();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientPageEdit patPage = new PatientPageEdit();
            patPage.Show();
            this.Hide();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            pharmacyBill billPage = new pharmacyBill();
            billPage.Show();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            bed bedPage = new bed();
            bedPage.Show();
            this.Hide();

        }
    }
}
