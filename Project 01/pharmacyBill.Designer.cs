namespace Project_01
{
    partial class pharmacyBill
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
            txtPatientID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAppointmentID = new TextBox();
            label3 = new Label();
            txtAppointmentBill = new TextBox();
            label4 = new Label();
            txtMedicineBill = new TextBox();
            label5 = new Label();
            txtRoomBill = new TextBox();
            cmbPaymentStatus = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            lblTotalAmount = new Label();
            btnSaveBill = new Button();
            button1 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtPatientID
            // 
            txtPatientID.BorderStyle = BorderStyle.FixedSingle;
            txtPatientID.ForeColor = Color.FromArgb(30, 41, 59);
            txtPatientID.Location = new Point(164, 106);
            txtPatientID.Margin = new Padding(3, 4, 3, 4);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(175, 27);
            txtPatientID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(43, 106);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(42, 175);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Appointment ID";
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.BorderStyle = BorderStyle.FixedSingle;
            txtAppointmentID.ForeColor = Color.FromArgb(30, 41, 59);
            txtAppointmentID.Location = new Point(164, 173);
            txtAppointmentID.Margin = new Padding(3, 4, 3, 4);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new Size(175, 27);
            txtAppointmentID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(42, 242);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 5;
            label3.Text = "Appointment Bill";
            label3.Click += label3_Click;
            // 
            // txtAppointmentBill
            // 
            txtAppointmentBill.BorderStyle = BorderStyle.FixedSingle;
            txtAppointmentBill.ForeColor = Color.FromArgb(30, 41, 59);
            txtAppointmentBill.Location = new Point(170, 235);
            txtAppointmentBill.Margin = new Padding(3, 4, 3, 4);
            txtAppointmentBill.Name = "txtAppointmentBill";
            txtAppointmentBill.Size = new Size(169, 27);
            txtAppointmentBill.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(30, 41, 59);
            label4.Location = new Point(42, 306);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 7;
            label4.Text = "Medicine Bill";
            // 
            // txtMedicineBill
            // 
            txtMedicineBill.BorderStyle = BorderStyle.FixedSingle;
            txtMedicineBill.ForeColor = Color.FromArgb(30, 41, 59);
            txtMedicineBill.Location = new Point(170, 299);
            txtMedicineBill.Margin = new Padding(3, 4, 3, 4);
            txtMedicineBill.Name = "txtMedicineBill";
            txtMedicineBill.Size = new Size(169, 27);
            txtMedicineBill.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(30, 41, 59);
            label5.Location = new Point(42, 357);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 9;
            label5.Text = "Room Bill";
            // 
            // txtRoomBill
            // 
            txtRoomBill.BorderStyle = BorderStyle.FixedSingle;
            txtRoomBill.ForeColor = Color.FromArgb(30, 41, 59);
            txtRoomBill.Location = new Point(170, 355);
            txtRoomBill.Margin = new Padding(3, 4, 3, 4);
            txtRoomBill.Name = "txtRoomBill";
            txtRoomBill.Size = new Size(169, 27);
            txtRoomBill.TabIndex = 8;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.BackColor = Color.White;
            cmbPaymentStatus.FlatStyle = FlatStyle.Flat;
            cmbPaymentStatus.ForeColor = Color.FromArgb(30, 41, 59);
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Items.AddRange(new object[] { "Paid", "Unpaid", "Pending" });
            cmbPaymentStatus.Location = new Point(175, 407);
            cmbPaymentStatus.Margin = new Padding(3, 4, 3, 4);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(164, 28);
            cmbPaymentStatus.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(30, 41, 59);
            label6.Location = new Point(43, 407);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 11;
            label6.Text = "Payment Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(30, 41, 59);
            label7.Location = new Point(456, 182);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 12;
            label7.Text = "Total Amount";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.ForeColor = Color.FromArgb(30, 41, 59);
            lblTotalAmount.Location = new Point(560, 182);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 20);
            lblTotalAmount.TabIndex = 13;
            // 
            // btnSaveBill
            // 
            btnSaveBill.BackColor = Color.FromArgb(0, 107, 84);
            btnSaveBill.FlatAppearance.BorderSize = 0;
            btnSaveBill.FlatStyle = FlatStyle.Flat;
            btnSaveBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveBill.ForeColor = Color.White;
            btnSaveBill.Location = new Point(480, 267);
            btnSaveBill.Margin = new Padding(3, 4, 3, 4);
            btnSaveBill.Name = "btnSaveBill";
            btnSaveBill.Size = new Size(160, 59);
            btnSaveBill.TabIndex = 14;
            btnSaveBill.Text = "Save Bill";
            btnSaveBill.UseVisualStyleBackColor = false;
            btnSaveBill.Click += btnSaveBill_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 107, 84);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(32, 11);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 107, 84);
            label8.Location = new Point(247, 52);
            label8.Name = "label8";
            label8.Size = new Size(201, 41);
            label8.TabIndex = 16;
            label8.Text = "Calculate Bill";
            // 
            // pharmacyBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(766, 465);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(btnSaveBill);
            Controls.Add(lblTotalAmount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(label5);
            Controls.Add(txtRoomBill);
            Controls.Add(label4);
            Controls.Add(txtMedicineBill);
            Controls.Add(label3);
            Controls.Add(txtAppointmentBill);
            Controls.Add(label2);
            Controls.Add(txtAppointmentID);
            Controls.Add(label1);
            Controls.Add(txtPatientID);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "pharmacyBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pharmacyBill";
            Load += pharmacyBill_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPatientID;
        private Label label1;
        private Label label2;
        private TextBox txtAppointmentID;
        private Label label3;
        private TextBox txtAppointmentBill;
        private Label label4;
        private TextBox txtMedicineBill;
        private Label label5;
        private TextBox txtRoomBill;
        private ComboBox cmbPaymentStatus;
        private Label label6;
        private Label label7;
        private Label lblTotalAmount;
        private Button btnSaveBill;
        private Button button1;
        private Label label8;
    }
}