using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Project_01
{
    public partial class pharmacy : Form
    {
        public pharmacy()
        {
            InitializeComponent();
            medicine_load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO [medicine]  VALUES (@medicineName, @category,@date,@stock,@price)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@medicineName", nameBox.Text);
                        cmd.Parameters.AddWithValue("@price", priceBox.Text);
                        cmd.Parameters.AddWithValue("@stock", stockBox.Text);
                        cmd.Parameters.AddWithValue("@category", categoryBox.Text);
                        cmd.Parameters.AddWithValue("@date", dateBox.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            medicine_load();
                            MessageBox.Show("Medicine added successfully.");

                            nameBox.Clear();
                            priceBox.Clear();
                            categoryBox.SelectedIndex = -1;
                            stockBox.Value = 0;
                            dateBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add medicine. Please try again.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }


        private void medicine_load()
        {
            try
            {
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT medicine_id,medicine_name,category,expiry_date,stock , price FROM [medicine]";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            loadMedicine.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void searchMedicine()
        {
            try
            {
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    if (string.IsNullOrWhiteSpace(searchBox.Text) || searchBox.Text == "Search Medicine Name or Category")
                    {
                        medicine_load();
                        return;
                    }
                    string sql = "SELECT * FROM [medicine] WHERE medicine_name LIKE @search OR category LIKE @search ";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchBox.Text + "%");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            loadMedicine.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
        private void update_details(string id)
        {
            try
            {
                using (SqlConnection conn = dbConnection.GetConnection())
                {

                    string sql = "UPDATE [medicine] SET  medicine_name = @name , category = @category,expiry_date = @date, stock = @stock, price = @price WHERE medicine_id = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", nameBox.Text);
                        cmd.Parameters.AddWithValue("@price", priceBox.Text);
                        cmd.Parameters.AddWithValue("@stock", stockBox.Text);
                        cmd.Parameters.AddWithValue("@category", categoryBox.Text);
                        cmd.Parameters.AddWithValue("@date", dateBox.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        medicine_load();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void loadMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void loadMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = loadMedicine.Rows[e.RowIndex];
                idLabel.Text = row.Cells["medicine_id"].Value.ToString();
                nameBox.Text = row.Cells["medicine_name"].Value.ToString();
                categoryBox.Text = row.Cells["category"].Value.ToString();
                priceBox.Text = row.Cells["price"].Value.ToString();
                stockBox.Text = row.Cells["stock"].Value.ToString();
                dateBox.Text = row.Cells["expiry_date"].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string id = idLabel.Text;
            update_details(id);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchMedicine();
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Medicine Name or Category")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search Medicine Name or Category";
                searchBox.ForeColor = Color.Gray;
            }
        }
    }
}
