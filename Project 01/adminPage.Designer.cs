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
            btnRooms = new Button();
            btnPatients = new Button();
            btnBilling = new Button();
            btnDoctors = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRooms);
            panel1.Controls.Add(btnPatients);
            panel1.Controls.Add(btnBilling);
            panel1.Controls.Add(btnDoctors);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 356);
            panel1.TabIndex = 0;
            // 
            // btnRooms
            // 
            btnRooms.Location = new Point(12, 158);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(130, 23);
            btnRooms.TabIndex = 3;
            btnRooms.Text = "Rooms & Beds";
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnPatients
            // 
            btnPatients.Location = new Point(12, 100);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(130, 23);
            btnPatients.TabIndex = 2;
            btnPatients.Text = "Manage Patients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnBilling
            // 
            btnBilling.Location = new Point(12, 129);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(130, 23);
            btnBilling.TabIndex = 1;
            btnBilling.Text = "Billing & Invoices";
            btnBilling.UseVisualStyleBackColor = true;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.Location = new Point(12, 71);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(130, 23);
            btnDoctors.TabIndex = 0;
            btnDoctors.Text = "Manage Doctors";
            btnDoctors.UseVisualStyleBackColor = true;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(156, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 356);
            panel2.TabIndex = 1;
            // 
            // adminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 356);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "adminPage";
            Text = "adminPage";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDoctors;
        private Button btnRooms;
        private Button btnPatients;
        private Button btnBilling;
    }
}