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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            label8 = new Label();
            label10 = new Label();
            picPatientImage = new PictureBox();
            txtUserName = new TextBox();
            cmbBloodGroup = new ComboBox();
            cmbSex = new ComboBox();
            btnUpdate = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPatientImage).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 250, 247);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 107, 84);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 107, 84);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 245, 240);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 107, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(230, 235, 240);
            dataGridView1.Location = new Point(105, 58);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(832, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(36, 380);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Patient ID";
            // 
            // txtPatientID
            // 
            txtPatientID.BorderStyle = BorderStyle.FixedSingle;
            txtPatientID.ForeColor = Color.FromArgb(30, 41, 59);
            txtPatientID.Location = new Point(159, 378);
            txtPatientID.Margin = new Padding(3, 4, 3, 4);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(200, 27);
            txtPatientID.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.FromArgb(30, 41, 59);
            txtEmail.Location = new Point(159, 457);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 27);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(36, 464);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Patient email";
            label2.Click += label2_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.ForeColor = Color.FromArgb(30, 41, 59);
            txtPhoneNumber.Location = new Point(161, 494);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(198, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(41, 501);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 5;
            label3.Text = "Phone Number";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.ForeColor = Color.FromArgb(30, 41, 59);
            txtAddress.Location = new Point(161, 535);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(198, 27);
            txtAddress.TabIndex = 8;
           // txtAddress.TextChanged += this.txtAddress_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(30, 41, 59);
            label4.Location = new Point(41, 535);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Address";
            //label4.Click += this.label4_Click;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.ForeColor = Color.FromArgb(30, 41, 59);
            txtAge.Location = new Point(163, 575);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(196, 27);
            txtAge.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(30, 41, 59);
            label5.Location = new Point(36, 577);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 9;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(30, 41, 59);
            label6.Location = new Point(41, 661);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 11;
            label6.Text = "BloodGroup";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(30, 41, 59);
            label8.Location = new Point(41, 621);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 15;
            label8.Text = "Gender";
            label8.Click += label8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(30, 41, 59);
            label10.Location = new Point(35, 418);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 17;
            label10.Text = "Patinet Name";
            // 
            // picPatientImage
            // 
            picPatientImage.BackColor = SystemColors.ActiveBorder;
            picPatientImage.Location = new Point(416, 395);
            picPatientImage.Margin = new Padding(3, 4, 3, 4);
            picPatientImage.Name = "picPatientImage";
            picPatientImage.Size = new Size(287, 246);
            picPatientImage.TabIndex = 18;
            picPatientImage.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.ForeColor = Color.FromArgb(30, 41, 59);
            txtUserName.Location = new Point(159, 416);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 19;
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.BackColor = Color.White;
            cmbBloodGroup.FlatStyle = FlatStyle.Flat;
            cmbBloodGroup.ForeColor = Color.FromArgb(30, 41, 59);
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Items.AddRange(new object[] { "A", "A+", "O", "O+" });
            cmbBloodGroup.Location = new Point(163, 658);
            cmbBloodGroup.Margin = new Padding(3, 4, 3, 4);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(194, 28);
            cmbBloodGroup.TabIndex = 20;
            // 
            // cmbSex
            // 
            cmbSex.BackColor = Color.White;
            cmbSex.FlatStyle = FlatStyle.Flat;
            cmbSex.ForeColor = Color.FromArgb(30, 41, 59);
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbSex.Location = new Point(163, 613);
            cmbSex.Margin = new Padding(3, 4, 3, 4);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(194, 28);
            cmbSex.TabIndex = 21;
            cmbSex.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 107, 84);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(747, 511);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(207, 64);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 107, 84);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(747, 415);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(207, 69);
            button1.TabIndex = 23;
            button1.Text = "ADD NEW Patient";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 107, 84);
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(36, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 24;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // PatientPageEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(1041, 725);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(cmbSex);
            Controls.Add(cmbBloodGroup);
            Controls.Add(txtUserName);
            Controls.Add(picPatientImage);
            Controls.Add(label10);
            Controls.Add(label8);
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
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label8;
        private Label label10;
        private PictureBox picPatientImage;
        private TextBox txtUserName;
        private ComboBox cmbBloodGroup;
        private ComboBox cmbSex;
        private Button btnUpdate;
        private Button button1;
        private Button button2;
    }
}