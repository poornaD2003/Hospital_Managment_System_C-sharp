namespace Project_01
{
    partial class doctorPageEdit
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
            dgvDoctors = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSpecialization = new TextBox();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            cmbSex = new ComboBox();
            button1 = new Button();
            txtPassword = new TextBox();
            Password = new Label();
            picDoctor = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDoctor).BeginInit();
            SuspendLayout();
            // 
            // dgvDoctors
            // 
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(43, 57);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.Size = new Size(1139, 155);
            dgvDoctors.TabIndex = 0;
            dgvDoctors.CellClick += dgvDoctors_CellClick;
            dgvDoctors.CellContentClick += dataGridView1_CellContentClick;
            dgvDoctors.CellValueChanged += dgvDoctors_CellValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 249);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "doctorName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 244);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "specialization";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 335);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 4;
            label4.Text = "age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 281);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 239);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 6;
            label6.Text = "phoneNumber";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 324);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 7;
            label7.Text = "email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(532, 281);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 8;
            label8.Text = "sex";
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(589, 236);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(100, 23);
            txtSpecialization.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(385, 327);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(385, 281);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(385, 231);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 324);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 249);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 16;
            // 
            // cmbSex
            // 
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbSex.Location = new Point(576, 281);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(121, 23);
            cmbSex.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(988, 249);
            button1.Name = "button1";
            button1.Size = new Size(103, 47);
            button1.TabIndex = 18;
            button1.Text = "ADD New Doctor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(116, 278);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 20;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(32, 284);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 19;
            Password.Text = "Password";
            // 
            // picDoctor
            // 
            picDoctor.BackColor = SystemColors.ActiveBorder;
            picDoctor.Location = new Point(755, 218);
            picDoctor.Name = "picDoctor";
            picDoctor.Size = new Size(128, 100);
            picDoctor.TabIndex = 21;
            picDoctor.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(755, 326);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 22;
            button2.Text = "Upload image";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(589, 324);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 23;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 218);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 24;
            label1.Text = "label1";
            // 
            // txtID
            // 
            txtID.Location = new Point(116, 215);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 25;
            // 
            // doctorPageEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 359);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(picDoctor);
            Controls.Add(txtPassword);
            Controls.Add(Password);
            Controls.Add(button1);
            Controls.Add(cmbSex);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtAge);
            Controls.Add(txtSpecialization);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDoctors);
            Name = "doctorPageEdit";
            Text = "doctorPageEdit";
            Load += doctorPageEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDoctors;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSpecialization;
        private TextBox txtAge;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private ComboBox cmbSex;
        private Button button1;
        private TextBox txtPassword;
        private Label Password;
        private PictureBox picDoctor;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox txtID;
    }
}