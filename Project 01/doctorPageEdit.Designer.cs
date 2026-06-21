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
            picDoctor = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            txtID = new TextBox();
            txtPassword = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDoctor).BeginInit();
            SuspendLayout();
            // 
            // dgvDoctors
            // 
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(49, 76);
            dgvDoctors.Margin = new Padding(3, 4, 3, 4);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.Size = new Size(1302, 207);
            dgvDoctors.TabIndex = 0;
            dgvDoctors.CellClick += dgvDoctors_CellClick;
            dgvDoctors.CellContentClick += dataGridView1_CellContentClick;
            dgvDoctors.CellValueChanged += dgvDoctors_CellValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 350);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Doctor Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 388);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 3;
            label3.Text = "Specialization";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 437);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 4;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 353);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 5;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 308);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 6;
            label6.Text = "Phone Number";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 393);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 7;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(291, 440);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 8;
            label8.Text = "Gender";
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(392, 385);
            txtSpecialization.Margin = new Padding(3, 4, 3, 4);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(138, 27);
            txtSpecialization.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(133, 437);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(114, 27);
            txtAge.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(392, 350);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(138, 27);
            txtAddress.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(392, 306);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(138, 27);
            txtPhone.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(133, 393);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 350);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 16;
            // 
            // cmbSex
            // 
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbSex.Location = new Point(392, 429);
            cmbSex.Margin = new Padding(3, 4, 3, 4);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(138, 28);
            cmbSex.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 107, 84);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(956, 305);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(341, 63);
            button1.TabIndex = 18;
            button1.Text = "ADD New Doctor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // picDoctor
            // 
            picDoctor.BackColor = SystemColors.ActiveBorder;
            picDoctor.BackgroundImageLayout = ImageLayout.Stretch;
            picDoctor.Location = new Point(642, 291);
            picDoctor.Margin = new Padding(3, 4, 3, 4);
            picDoctor.Name = "picDoctor";
            picDoctor.Size = new Size(146, 133);
            picDoctor.TabIndex = 21;
            picDoctor.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(656, 435);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(117, 31);
            button2.TabIndex = 22;
            button2.Text = "Upload image";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 107, 84);
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(956, 385);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(341, 52);
            button3.TabIndex = 23;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 309);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 24;
            label1.Text = "Doctor ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(133, 305);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(114, 27);
            txtID.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Location = new Point(656, 348);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(108, 20);
            txtPassword.TabIndex = 26;
            txtPassword.Text = "Phone Number";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 107, 84);
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(58, 13);
            button4.Name = "button4";
            button4.Size = new Size(83, 37);
            button4.TabIndex = 27;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // doctorPageEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 518);
            Controls.Add(button4);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(picDoctor);
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
            Controls.Add(txtPassword);
            Margin = new Padding(3, 4, 3, 4);
            Name = "doctorPageEdit";
            StartPosition = FormStartPosition.CenterScreen;
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
        private PictureBox picDoctor;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox txtID;
        private Label txtPassword;
        private Button button4;
    }
}