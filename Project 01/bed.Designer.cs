namespace Project_01
{
    partial class bed
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
            dgvRooms = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            txtPatientID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDays = new TextBox();
            label2 = new Label();
            btnAssignPatient = new Button();
            txtRoomNo = new Label();
            txtSection = new TextBox();
            txtStatus = new TextBox();
            txtPrice = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 250, 247);
            dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 107, 84);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 107, 84);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 245, 240);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 107, 84);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.FromArgb(230, 235, 240);
            dgvRooms.Location = new Point(36, 68);
            dgvRooms.Margin = new Padding(3, 4, 3, 4);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.RowTemplate.Height = 35;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(744, 224);
            dgvRooms.TabIndex = 0;
            dgvRooms.CellClick += dgvRooms_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(152, 395);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "Room Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(437, 356);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Status";
            // 
            // txtPatientID
            // 
            txtPatientID.BorderStyle = BorderStyle.FixedSingle;
            txtPatientID.ForeColor = Color.FromArgb(30, 41, 59);
            txtPatientID.Location = new Point(255, 354);
            txtPatientID.Margin = new Padding(3, 4, 3, 4);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(114, 27);
            txtPatientID.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(30, 41, 59);
            label4.Location = new Point(152, 358);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 7;
            label4.Text = "Patient ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(30, 41, 59);
            label5.Location = new Point(445, 451);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 9;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(30, 41, 59);
            label6.Location = new Point(160, 449);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 11;
            label6.Text = "Section";
            // 
            // txtDays
            // 
            txtDays.BorderStyle = BorderStyle.FixedSingle;
            txtDays.ForeColor = Color.FromArgb(30, 41, 59);
            txtDays.Location = new Point(541, 395);
            txtDays.Margin = new Padding(3, 4, 3, 4);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(114, 27);
            txtDays.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(438, 399);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 14;
            label2.Text = "Days";
            // 
            // btnAssignPatient
            // 
            btnAssignPatient.BackColor = Color.FromArgb(0, 107, 84);
            btnAssignPatient.FlatAppearance.BorderSize = 0;
            btnAssignPatient.FlatStyle = FlatStyle.Flat;
            btnAssignPatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssignPatient.ForeColor = Color.White;
            btnAssignPatient.Location = new Point(351, 529);
            btnAssignPatient.Margin = new Padding(3, 4, 3, 4);
            btnAssignPatient.Name = "btnAssignPatient";
            btnAssignPatient.Size = new Size(228, 41);
            btnAssignPatient.TabIndex = 16;
            btnAssignPatient.Text = "Add Patient";
            btnAssignPatient.UseVisualStyleBackColor = false;
            btnAssignPatient.Click += btnAssignPatient_Click;
            // 
            // txtRoomNo
            // 
            txtRoomNo.AutoSize = true;
            txtRoomNo.ForeColor = Color.FromArgb(30, 41, 59);
            txtRoomNo.Location = new Point(287, 395);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(0, 20);
            txtRoomNo.TabIndex = 18;
            // 
            // txtSection
            // 
            txtSection.BorderStyle = BorderStyle.FixedSingle;
            txtSection.ForeColor = Color.FromArgb(30, 41, 59);
            txtSection.Location = new Point(255, 442);
            txtSection.Margin = new Padding(3, 4, 3, 4);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(114, 27);
            txtSection.TabIndex = 19;
            // 
            // txtStatus
            // 
            txtStatus.BorderStyle = BorderStyle.FixedSingle;
            txtStatus.ForeColor = Color.FromArgb(30, 41, 59);
            txtStatus.Location = new Point(540, 351);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(114, 27);
            txtStatus.TabIndex = 20;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.ForeColor = Color.FromArgb(30, 41, 59);
            txtPrice.Location = new Point(540, 447);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(114, 27);
            txtPrice.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 107, 84);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(46, 13);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 22;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // bed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(txtPrice);
            Controls.Add(txtStatus);
            Controls.Add(txtSection);
            Controls.Add(txtRoomNo);
            Controls.Add(btnAssignPatient);
            Controls.Add(txtDays);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPatientID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvRooms);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "bed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "bed";
            Load += bed_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRooms;
        private Label label1;
        private Label label3;
        private TextBox txtPatientID;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDays;
        private Label label2;
        private Button btnAssignPatient;
        private Label txtRoomNo;
        private TextBox txtSection;
        private TextBox txtStatus;
        private TextBox txtPrice;
        private Button button1;
    }
}