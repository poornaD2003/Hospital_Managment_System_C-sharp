namespace Project_01
{
    partial class medicalReport
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
            rtbDiagnosis = new RichTextBox();
            rtbTestResults = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtPatientID
            // 
            txtPatientID.BorderStyle = BorderStyle.FixedSingle;
            txtPatientID.ForeColor = Color.FromArgb(30, 41, 59);
            txtPatientID.Location = new Point(68, 117);
            txtPatientID.Margin = new Padding(3, 4, 3, 4);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(231, 27);
            txtPatientID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(44, 93);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(44, 165);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Appoinment ID";
            label2.Click += label2_Click;
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.BorderStyle = BorderStyle.FixedSingle;
            txtAppointmentID.ForeColor = Color.FromArgb(30, 41, 59);
            txtAppointmentID.Location = new Point(68, 199);
            txtAppointmentID.Margin = new Padding(3, 4, 3, 4);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new Size(231, 27);
            txtAppointmentID.TabIndex = 2;
            txtAppointmentID.TextChanged += textBox2_TextChanged;
            // 
            // rtbDiagnosis
            // 
            rtbDiagnosis.Location = new Point(69, 268);
            rtbDiagnosis.Margin = new Padding(3, 4, 3, 4);
            rtbDiagnosis.Name = "rtbDiagnosis";
            rtbDiagnosis.Size = new Size(242, 108);
            rtbDiagnosis.TabIndex = 4;
            rtbDiagnosis.Text = "";
            // 
            // rtbTestResults
            // 
            rtbTestResults.Location = new Point(424, 268);
            rtbTestResults.Margin = new Padding(3, 4, 3, 4);
            rtbTestResults.Name = "rtbTestResults";
            rtbTestResults.Size = new Size(242, 108);
            rtbTestResults.TabIndex = 5;
            rtbTestResults.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(380, 244);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 6;
            label3.Text = "TestResults";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(30, 41, 59);
            label4.Location = new Point(46, 244);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Diagnosis";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 107, 84);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(237, 478);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 107, 84);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(387, 478);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 107, 84);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(23, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 10;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // medicalReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(766, 533);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rtbTestResults);
            Controls.Add(rtbDiagnosis);
            Controls.Add(label2);
            Controls.Add(txtAppointmentID);
            Controls.Add(label1);
            Controls.Add(txtPatientID);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "medicalReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "medicalReport";
            Load += medicalReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPatientID;
        private Label label1;
        private Label label2;
        private TextBox txtAppointmentID;
        private RichTextBox rtbDiagnosis;
        private RichTextBox rtbTestResults;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private Button btnClear;
        private Button button1;
    }
}