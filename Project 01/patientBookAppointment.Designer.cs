namespace Project_01
{
    partial class patientBookAppointment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblHeader = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvDoctors = new DataGridView();
            lblDoc = new Label();
            txtSelectedDoc = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblTime = new Label();
            cmbTime = new ComboBox();
            lblReason = new Label();
            txtReason = new TextBox();
            btnBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(0, 107, 84);
            lblHeader.Location = new Point(25, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(275, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Schedule Appointment";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(30, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 32);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 107, 84);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(390, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvDoctors
            // 
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.AllowUserToDeleteRows = false;
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctors.BackgroundColor = Color.White;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(30, 115);
            dgvDoctors.MultiSelect = false;
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.Size = new Size(640, 180);
            dgvDoctors.TabIndex = 3;
            dgvDoctors.SelectionChanged += dgvDoctors_SelectionChanged;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDoc.Location = new Point(30, 315);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(144, 23);
            lblDoc.TabIndex = 4;
            lblDoc.Text = "Selected Doctor:";
            // 
            // txtSelectedDoc
            // 
            txtSelectedDoc.Font = new Font("Segoe UI", 11F);
            txtSelectedDoc.Location = new Point(30, 340);
            txtSelectedDoc.Name = "txtSelectedDoc";
            txtSelectedDoc.ReadOnly = true;
            txtSelectedDoc.Size = new Size(300, 32);
            txtSelectedDoc.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDate.Location = new Point(30, 385);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(106, 23);
            lblDate.TabIndex = 6;
            lblDate.Text = "Select Date:";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 11F);
            dtpDate.Location = new Point(30, 410);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(300, 32);
            dtpDate.TabIndex = 7;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTime.Location = new Point(370, 315);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(145, 23);
            lblTime.TabIndex = 8;
            lblTime.Text = "Select Time Slot:";
            // 
            // cmbTime
            // 
            cmbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTime.Font = new Font("Segoe UI", 11F);
            cmbTime.FormattingEnabled = true;
            cmbTime.Items.AddRange(new object[] { "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM" });
            cmbTime.Location = new Point(370, 340);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(300, 33);
            cmbTime.TabIndex = 9;
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReason.Location = new Point(370, 385);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(128, 23);
            lblReason.TabIndex = 10;
            lblReason.Text = "Reason / Note:";
            // 
            // txtReason
            // 
            txtReason.Font = new Font("Segoe UI", 11F);
            txtReason.Location = new Point(370, 410);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(300, 32);
            txtReason.TabIndex = 11;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(0, 107, 84);
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(30, 470);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(640, 45);
            btnBook.TabIndex = 12;
            btnBook.Text = "Book Appointment";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // patientBookAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 540);
            Controls.Add(btnBook);
            Controls.Add(txtReason);
            Controls.Add(lblReason);
            Controls.Add(cmbTime);
            Controls.Add(lblTime);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(txtSelectedDoc);
            Controls.Add(lblDoc);
            Controls.Add(dgvDoctors);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblHeader);
            Name = "patientBookAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Appointment";
            Load += patientBookAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtSelectedDoc;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnBook;
    }
}
