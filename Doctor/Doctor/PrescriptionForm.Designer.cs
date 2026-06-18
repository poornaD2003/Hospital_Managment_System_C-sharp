namespace Doctor
{
    partial class PrescriptionForm
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtPatient = new TextBox();
            cmbMedicine = new ComboBox();
            btnAdd = new Button();
            lstDrugs = new ListBox();
            txtDescription = new RichTextBox();
            btnSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 89);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(23, 55);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 2;
            label2.Text = "PRECISION CARE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(197, 41);
            label1.TabIndex = 1;
            label1.Text = "The Hospital";
            // 
            // txtPatient
            // 
            txtPatient.Location = new Point(276, 12);
            txtPatient.Name = "txtPatient";
            txtPatient.ReadOnly = true;
            txtPatient.Size = new Size(125, 27);
            txtPatient.TabIndex = 2;
            // 
            // cmbMedicine
            // 
            cmbMedicine.FormattingEnabled = true;
            cmbMedicine.Location = new Point(89, 134);
            cmbMedicine.Name = "cmbMedicine";
            cmbMedicine.Size = new Size(151, 28);
            cmbMedicine.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(146, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Drug";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstDrugs
            // 
            lstDrugs.FormattingEnabled = true;
            lstDrugs.Location = new Point(265, 134);
            lstDrugs.Name = "lstDrugs";
            lstDrugs.Size = new Size(150, 104);
            lstDrugs.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(473, 134);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 104);
            txtDescription.TabIndex = 6;
            txtDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(504, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Prescription";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // PrescriptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 356);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(lstDrugs);
            Controls.Add(btnAdd);
            Controls.Add(cmbMedicine);
            Controls.Add(txtPatient);
            Controls.Add(panel1);
            Name = "PrescriptionForm";
            Text = "PrescriptionForm";
            Load += PrescriptionForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtPatient;
        private ComboBox cmbMedicine;
        private Button btnAdd;
        private ListBox lstDrugs;
        private RichTextBox txtDescription;
        private Button btnSave;
    }
}