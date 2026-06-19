namespace Project_01
{
    partial class PatientForm
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
            panelHeader = new Panel();
            lblHeader = new Label();
            panelSearch = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearchHint = new Label();
            dgvPatients = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtHistory = new RichTextBox();
            panelHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkGreen;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 55);
            panelHeader.TabIndex = 5;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(15, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(200, 37);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Patient Records";
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(lblSearchHint);
            panelSearch.Location = new Point(12, 72);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(776, 55);
            panelSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkGreen;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(670, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(120, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(540, 30);
            txtSearch.TabIndex = 1;
            // 
            // lblSearchHint
            // 
            lblSearchHint.AutoSize = true;
            lblSearchHint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearchHint.ForeColor = Color.DarkGreen;
            lblSearchHint.Location = new Point(8, 15);
            lblSearchHint.Name = "lblSearchHint";
            lblSearchHint.Size = new Size(106, 23);
            lblSearchHint.TabIndex = 0;
            lblSearchHint.Text = "Search by:";
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 240);
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.BackgroundColor = Color.White;
            dgvPatients.BorderStyle = BorderStyle.None;
            dgvPatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPatients.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dgvPatients.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvPatients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPatients.ColumnHeadersHeight = 40;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPatients.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.GridColor = Color.FromArgb(220, 220, 220);
            dgvPatients.Location = new Point(12, 135);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvPatients.RowTemplate.Height = 32;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(776, 240);
            dgvPatients.TabIndex = 3;
            dgvPatients.CellClick += dgvPatients_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Patient ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 80;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Gender";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 90;
            // 
            // Column4
            // 
            Column4.HeaderText = "Age";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 70;
            // 
            // Column5
            // 
            Column5.HeaderText = "Phone";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHistory);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkGreen;
            groupBox1.Location = new Point(12, 385);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 160);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "  Patient History  ";
            // 
            // txtHistory
            // 
            txtHistory.BackColor = Color.White;
            txtHistory.Font = new Font("Segoe UI", 9F);
            txtHistory.Location = new Point(10, 25);
            txtHistory.Name = "txtHistory";
            txtHistory.ReadOnly = true;
            txtHistory.Size = new Size(756, 125);
            txtHistory.TabIndex = 0;
            txtHistory.Text = "";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 560);
            Controls.Add(panelSearch);
            Controls.Add(panelHeader);
            Controls.Add(groupBox1);
            Controls.Add(dgvPatients);
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Records";
            Load += PatientForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelSearch;
        private Label lblSearchHint;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvPatients;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox1;
        private RichTextBox txtHistory;
    }
}