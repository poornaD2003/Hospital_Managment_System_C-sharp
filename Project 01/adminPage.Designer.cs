namespace Project_01
{
    partial class adminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnMedical = new Button();
            btnRooms = new Button();
            btnPatients = new Button();
            btnBilling = new Button();
            btnDoctors = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnMedical);
            panel1.Controls.Add(btnRooms);
            panel1.Controls.Add(btnPatients);
            panel1.Controls.Add(btnBilling);
            panel1.Controls.Add(btnDoctors);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 600);
            panel1.TabIndex = 0;
            // 
            // btnMedical
            // 
            btnMedical.BackColor = Color.FromArgb(0, 107, 84);
            btnMedical.FlatAppearance.BorderSize = 0;
            btnMedical.FlatStyle = FlatStyle.Flat;
            btnMedical.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedical.ForeColor = Color.White;
            btnMedical.Location = new Point(14, 436);
            btnMedical.Margin = new Padding(3, 4, 3, 4);
            btnMedical.Name = "btnMedical";
            btnMedical.Size = new Size(233, 59);
            btnMedical.TabIndex = 0;
            btnMedical.Text = "Add medical report";
            btnMedical.UseVisualStyleBackColor = false;
            btnMedical.Click += btnMedical_Click;
            // 
            // btnRooms
            // 
            btnRooms.BackColor = Color.FromArgb(0, 107, 84);
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRooms.ForeColor = Color.White;
            btnRooms.Location = new Point(14, 350);
            btnRooms.Margin = new Padding(3, 4, 3, 4);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(233, 56);
            btnRooms.TabIndex = 3;
            btnRooms.Text = "Rooms & Beds";
            btnRooms.UseVisualStyleBackColor = false;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnPatients
            // 
            btnPatients.BackColor = Color.FromArgb(0, 107, 84);
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatients.ForeColor = Color.White;
            btnPatients.Location = new Point(14, 176);
            btnPatients.Margin = new Padding(3, 4, 3, 4);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(233, 60);
            btnPatients.TabIndex = 2;
            btnPatients.Text = "Manage Patients";
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.FromArgb(0, 107, 84);
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBilling.ForeColor = Color.White;
            btnBilling.Location = new Point(14, 258);
            btnBilling.Margin = new Padding(3, 4, 3, 4);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(233, 58);
            btnBilling.TabIndex = 1;
            btnBilling.Text = "Billing & Invoices";
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.FromArgb(0, 107, 84);
            btnDoctors.FlatAppearance.BorderSize = 0;
            btnDoctors.FlatStyle = FlatStyle.Flat;
            btnDoctors.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoctors.ForeColor = Color.White;
            btnDoctors.Location = new Point(14, 95);
            btnDoctors.Margin = new Padding(3, 4, 3, 4);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(233, 62);
            btnDoctors.TabIndex = 0;
            btnDoctors.Text = "Manage Doctors";
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoScrollMinSize = new Size(401, 356);
            panel2.AutoSize = true;
            panel2.BackgroundImage = Properties.Resources.Background;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(316, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 600);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.jc_gellidon_9Eb_bpTXglM_unsplash;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(-3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(608, 600);
            panel3.TabIndex = 0;
            // 
            // adminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(919, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "adminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminPage";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDoctors;
        private Button btnRooms;
        private Button btnPatients;
        private Button btnBilling;
        private Button btnMedical;
        private Panel panel3;
    }
}