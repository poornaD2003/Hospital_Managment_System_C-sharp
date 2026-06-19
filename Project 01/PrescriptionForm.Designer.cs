namespace Project_01
{
    partial class PrescriptionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            label2 = new Label();
            label1 = new Label();
            pnlInfo = new Panel();
            lblApptInfo = new Label();
            lblDiagnosis = new Label();
            txtDiagnosis = new TextBox();
            lblMedicine = new Label();
            cmbMedicine = new ComboBox();
            lblDosage = new Label();
            cmbDosage = new ComboBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblDrugs = new Label();
            lstDrugs = new ListBox();
            grpNotes = new GroupBox();
            txtDescription = new RichTextBox();
            btnSave = new Button();
            panelHeader.SuspendLayout();
            pnlInfo.SuspendLayout();
            grpNotes.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(700, 80);
            panelHeader.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(20, 50);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 2;
            label2.Text = "PRECISION CARE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(217, 46);
            label1.TabIndex = 1;
            label1.Text = "The Hospital";
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(235, 245, 235);
            pnlInfo.Controls.Add(lblApptInfo);
            pnlInfo.Location = new Point(12, 92);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(676, 50);
            pnlInfo.TabIndex = 1;
            // 
            // lblApptInfo
            // 
            lblApptInfo.AutoSize = true;
            lblApptInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblApptInfo.ForeColor = Color.DarkGreen;
            lblApptInfo.Location = new Point(10, 13);
            lblApptInfo.Name = "lblApptInfo";
            lblApptInfo.Size = new Size(300, 25);
            lblApptInfo.TabIndex = 0;
            lblApptInfo.Text = "Appointment #0  |  Patient  |  Date";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiagnosis.ForeColor = Color.Black;
            lblDiagnosis.Location = new Point(12, 157);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(76, 20);
            lblDiagnosis.TabIndex = 2;
            lblDiagnosis.Text = "Diagnosis";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Font = new Font("Segoe UI", 10F);
            txtDiagnosis.Location = new Point(12, 180);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(676, 50);
            txtDiagnosis.TabIndex = 3;
            // 
            // lblMedicine
            // 
            lblMedicine.AutoSize = true;
            lblMedicine.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedicine.ForeColor = Color.Black;
            lblMedicine.Location = new Point(12, 245);
            lblMedicine.Name = "lblMedicine";
            lblMedicine.Size = new Size(70, 20);
            lblMedicine.TabIndex = 4;
            lblMedicine.Text = "Medicine";
            // 
            // cmbMedicine
            // 
            cmbMedicine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedicine.Font = new Font("Segoe UI", 10F);
            cmbMedicine.FormattingEnabled = true;
            cmbMedicine.Location = new Point(12, 268);
            cmbMedicine.Name = "cmbMedicine";
            cmbMedicine.Size = new Size(220, 31);
            cmbMedicine.TabIndex = 5;
            // 
            // lblDosage
            // 
            lblDosage.AutoSize = true;
            lblDosage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDosage.ForeColor = Color.Black;
            lblDosage.Location = new Point(248, 245);
            lblDosage.Name = "lblDosage";
            lblDosage.Size = new Size(59, 20);
            lblDosage.TabIndex = 12;
            lblDosage.Text = "Dosage";
            // 
            // cmbDosage
            // 
            cmbDosage.Font = new Font("Segoe UI", 10F);
            cmbDosage.FormattingEnabled = true;
            cmbDosage.Items.AddRange(new object[] {
            "500mg",
            "250mg",
            "100mg",
            "50mg",
            "1 tablet",
            "2 tablets",
            "1 capsule",
            "1 teaspoon",
            "5ml",
            "10ml",
            "As directed"});
            cmbDosage.Location = new Point(248, 268);
            cmbDosage.Name = "cmbDosage";
            cmbDosage.Size = new Size(110, 31);
            cmbDosage.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(375, 268);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+ Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemove.ForeColor = Color.FromArgb(180, 50, 50);
            btnRemove.Location = new Point(471, 268);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(90, 30);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblDrugs
            // 
            lblDrugs.AutoSize = true;
            lblDrugs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDrugs.ForeColor = Color.Black;
            lblDrugs.Location = new Point(12, 312);
            lblDrugs.Name = "lblDrugs";
            lblDrugs.Size = new Size(111, 20);
            lblDrugs.TabIndex = 8;
            lblDrugs.Text = "Prescribed Drugs";
            // 
            // lstDrugs
            // 
            lstDrugs.Font = new Font("Segoe UI", 10F);
            lstDrugs.FormattingEnabled = true;
            lstDrugs.ItemHeight = 23;
            lstDrugs.Location = new Point(12, 335);
            lstDrugs.Name = "lstDrugs";
            lstDrugs.Size = new Size(400, 100);
            lstDrugs.TabIndex = 9;
            // 
            // grpNotes
            // 
            grpNotes.Controls.Add(txtDescription);
            grpNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpNotes.ForeColor = Color.DarkGreen;
            grpNotes.Location = new Point(420, 312);
            grpNotes.Name = "grpNotes";
            grpNotes.Size = new Size(268, 125);
            grpNotes.TabIndex = 10;
            grpNotes.TabStop = false;
            grpNotes.Text = "  Instructions / Notes  ";
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(3, 23);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(402, 99);
            txtDescription.TabIndex = 0;
            txtDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(525, 450);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 45);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Prescription";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // PrescriptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 510);
            Controls.Add(btnSave);
            Controls.Add(grpNotes);
            Controls.Add(lstDrugs);
            Controls.Add(lblDrugs);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(cmbDosage);
            Controls.Add(lblDosage);
            Controls.Add(cmbMedicine);
            Controls.Add(lblMedicine);
            Controls.Add(txtDiagnosis);
            Controls.Add(lblDiagnosis);
            Controls.Add(pnlInfo);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PrescriptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Prescription";
            Load += PrescriptionForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            grpNotes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelHeader;
        private Label label2;
        private Label label1;
        private Panel pnlInfo;
        private Label lblApptInfo;
        private Label lblDiagnosis;
        private TextBox txtDiagnosis;
        private Label lblMedicine;
        private ComboBox cmbMedicine;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblDrugs;
        private ListBox lstDrugs;
        private GroupBox grpNotes;
        private RichTextBox txtDescription;
        private Button btnSave;
        private Label lblDosage;
        private ComboBox cmbDosage;
    }
}
