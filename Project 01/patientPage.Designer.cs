namespace Project_01
{
    partial class patientPage
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
            lblWelcome = new Label();
            btnBookAppt = new Button();
            btnManageAccount = new Button();
            btnExportPDF = new Button();
            btnLogout = new Button();
            pnlInfo = new Panel();
            lblProfileDetails = new Label();
            pnlInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(0, 107, 84);
            lblWelcome.Location = new Point(40, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(356, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to Patient Portal";
            // 
            // btnBookAppt
            // 
            btnBookAppt.BackColor = Color.FromArgb(0, 107, 84);
            btnBookAppt.FlatStyle = FlatStyle.Flat;
            btnBookAppt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBookAppt.ForeColor = Color.White;
            btnBookAppt.Location = new Point(40, 116);
            btnBookAppt.Name = "btnBookAppt";
            btnBookAppt.Size = new Size(220, 50);
            btnBookAppt.TabIndex = 1;
            btnBookAppt.Text = "Book Appointment";
            btnBookAppt.UseVisualStyleBackColor = false;
            btnBookAppt.Click += btnBookAppt_Click;
            // 
            // btnManageAccount
            // 
            btnManageAccount.BackColor = Color.FromArgb(0, 107, 84);
            btnManageAccount.FlatStyle = FlatStyle.Flat;
            btnManageAccount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnManageAccount.ForeColor = Color.White;
            btnManageAccount.Location = new Point(40, 200);
            btnManageAccount.Name = "btnManageAccount";
            btnManageAccount.Size = new Size(220, 50);
            btnManageAccount.TabIndex = 2;
            btnManageAccount.Text = "Manage Account";
            btnManageAccount.UseVisualStyleBackColor = false;
            btnManageAccount.Click += btnManageAccount_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.FromArgb(0, 107, 84);
            btnExportPDF.FlatStyle = FlatStyle.Flat;
            btnExportPDF.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExportPDF.ForeColor = Color.White;
            btnExportPDF.Location = new Point(40, 282);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(220, 62);
            btnExportPDF.TabIndex = 3;
            btnExportPDF.Text = "Medical Report Downlaod";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 57, 43);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(40, 560);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 45);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.White;
            pnlInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlInfo.Controls.Add(lblProfileDetails);
            pnlInfo.Location = new Point(290, 110);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(573, 357);
            pnlInfo.TabIndex = 5;
            pnlInfo.Paint += pnlInfo_Paint;
            // 
            // lblProfileDetails
            // 
            lblProfileDetails.AutoSize = true;
            lblProfileDetails.Font = new Font("Segoe UI", 10F);
            lblProfileDetails.Location = new Point(20, 20);
            lblProfileDetails.Name = "lblProfileDetails";
            lblProfileDetails.Size = new Size(110, 23);
            lblProfileDetails.TabIndex = 0;
            lblProfileDetails.Text = "Patient Info...";
            // 
            // patientPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.clay_banks_e6pK_snssSY_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1037, 632);
            Controls.Add(pnlInfo);
            Controls.Add(btnLogout);
            Controls.Add(btnExportPDF);
            Controls.Add(btnManageAccount);
            Controls.Add(btnBookAppt);
            Controls.Add(lblWelcome);
            Name = "patientPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Portal Menu";
            FormClosed += patientPage_FormClosed;
            Load += patientPage_Load;
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBookAppt;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblProfileDetails;
    }
}