namespace Project_01
{
    partial class PatientPageEdit
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtPatientID = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            picPatientImage = new PictureBox();
            txtUserName = new TextBox();
            cmbBloodGroup = new ComboBox();
            cmbSex = new ComboBox();
            btnUpdate = new Button();
            txtPassword = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPatientImage).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(608, 226);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 270);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Patient ID";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(114, 264);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(100, 23);
            txtPatientID.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 328);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 331);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Patient email";
            label2.Click += label2_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(319, 362);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 365);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 5;
            label3.Text = "Phone Number";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(316, 267);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 270);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 7;
            label4.Text = "address";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(316, 300);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 303);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 9;
            label5.Text = "age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 275);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 11;
            label6.Text = "bloodGroup";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(111, 297);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 300);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 13;
            label7.Text = "address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 334);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 15;
            label8.Text = "sex";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(693, 387);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 16;
            label9.Text = "patientImage";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(443, 323);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 17;
            label10.Text = "Username";
            // 
            // picPatientImage
            // 
            picPatientImage.Location = new Point(662, 273);
            picPatientImage.Name = "picPatientImage";
            picPatientImage.Size = new Size(121, 102);
            picPatientImage.TabIndex = 18;
            picPatientImage.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(527, 318);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 19;
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Items.AddRange(new object[] { "A", "A+", "O", "O+" });
            cmbBloodGroup.Location = new Point(527, 275);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(121, 23);
            cmbBloodGroup.TabIndex = 20;
            // 
            // cmbSex
            // 
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbSex.Location = new Point(295, 331);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(121, 23);
            cmbSex.TabIndex = 21;
            cmbSex.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(505, 379);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(106, 357);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 360);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 23;
            label11.Text = "Password";
            // 
            // PatientPageEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 438);
            Controls.Add(txtPassword);
            Controls.Add(label11);
            Controls.Add(btnUpdate);
            Controls.Add(cmbSex);
            Controls.Add(cmbBloodGroup);
            Controls.Add(txtUserName);
            Controls.Add(picPatientImage);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtPatientID);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "PatientPageEdit";
            Text = "PatientPageEdit";
            Load += PatientPageEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPatientImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtPatientID;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPhoneNumber;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox picPatientImage;
        private TextBox txtUserName;
        private ComboBox cmbBloodGroup;
        private ComboBox cmbSex;
        private Button btnUpdate;
        private TextBox txtPassword;
        private Label label11;
    }
}