namespace Project_01
{
    partial class AppointmentForm
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
            panelHeader = new Panel();
            lblHeader = new Label();
            panelFilter = new Panel();
            dtpDate = new DateTimePicker();
            lblFilter = new Label();
            btnShowAll = new Button();
            dgvAppointments = new DataGridView();
            panelHeader.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkGreen;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 55);
            panelHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(20, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(374, 41);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Appointments - Select Date";
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.White;
            panelFilter.BorderStyle = BorderStyle.FixedSingle;
            panelFilter.Controls.Add(dtpDate);
            panelFilter.Controls.Add(lblFilter);
            panelFilter.Controls.Add(btnShowAll);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 55);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1000, 55);
            panelFilter.TabIndex = 2;
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Segoe UI", 10F);
            dtpDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpDate.Font = new Font("Segoe UI", 11F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(115, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(150, 32);
            dtpDate.TabIndex = 3;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFilter.ForeColor = Color.DarkGreen;
            lblFilter.Location = new Point(15, 15);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(94, 25);
            lblFilter.TabIndex = 2;
            lblFilter.Text = "Filter by:";
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.DarkGreen;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnShowAll.ForeColor = Color.White;
            btnShowAll.Location = new Point(285, 11);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(100, 32);
            btnShowAll.TabIndex = 1;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 240);
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = Color.White;
            dgvAppointments.BorderStyle = BorderStyle.None;
            dgvAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAppointments.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dgvAppointments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvAppointments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAppointments.ColumnHeadersHeight = 45;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.EnableHeadersVisualStyles = false;
            dgvAppointments.GridColor = Color.FromArgb(220, 220, 220);
            dgvAppointments.Location = new Point(0, 110);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvAppointments.RowTemplate.Height = 35;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(1000, 490);
            dgvAppointments.TabIndex = 0;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvAppointments);
            Controls.Add(panelFilter);
            Controls.Add(panelHeader);
            Name = "AppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointments";
            Load += AppointmentForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelFilter;
        private DateTimePicker dtpDate;
        private Label lblFilter;
        private Button btnShowAll;
        private DataGridView dgvAppointments;
    }
}