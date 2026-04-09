using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BCrypt.Net;
namespace Project_01
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            signUp form2 = new signUp(this);

            form2.Show();

            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = userNameField.Text;
            string password = passwordField.Text;
            string role = roleField.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            User user;
            switch (role)
            {
                case "Patient":
                    user = new Patient(username, password);
                    break;
                case "Doctor":
                    user = new Doctor(username, password);
                    break;
                case "Admin":
                    user = new Admin(username, password);
                    break;
                default:
                    MessageBox.Show("Please select a valid role.");
                    return;
            }
            user.openPage();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This ensures the entire process kills itself when the form is closed
            Application.Exit();
        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
