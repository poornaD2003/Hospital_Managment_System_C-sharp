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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBookAppt = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblProfileDetails = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(84)))));
            this.lblWelcome.Location = new System.Drawing.Point(40, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(325, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Patient Portal";
            // 
            // btnBookAppt
            // 
            this.btnBookAppt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(84)))));
            this.btnBookAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAppt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBookAppt.ForeColor = System.Drawing.Color.White;
            this.btnBookAppt.Location = new System.Drawing.Point(40, 110);
            this.btnBookAppt.Name = "btnBookAppt";
            this.btnBookAppt.Size = new System.Drawing.Size(220, 50);
            this.btnBookAppt.TabIndex = 1;
            this.btnBookAppt.Text = "Book Appointment";
            this.btnBookAppt.UseVisualStyleBackColor = false;
            this.btnBookAppt.Click += new System.EventHandler(this.btnBookAppt_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(84)))));
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnManageAccount.ForeColor = System.Drawing.Color.White;
            this.btnManageAccount.Location = new System.Drawing.Point(40, 180);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(220, 50);
            this.btnManageAccount.TabIndex = 2;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.UseVisualStyleBackColor = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(84)))));
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Location = new System.Drawing.Point(40, 250);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(220, 50);
            this.btnExportPDF.TabIndex = 3;
            this.btnExportPDF.Text = "Download PDF Report";
            this.btnExportPDF.UseVisualStyleBackColor = false;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(40, 320);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 45);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblProfileDetails);
            this.pnlInfo.Location = new System.Drawing.Point(290, 110);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(350, 255);
            this.pnlInfo.TabIndex = 5;
            // 
            // lblProfileDetails
            // 
            this.lblProfileDetails.AutoSize = true;
            this.lblProfileDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfileDetails.Location = new System.Drawing.Point(20, 20);
            this.lblProfileDetails.Name = "lblProfileDetails";
            this.lblProfileDetails.Size = new System.Drawing.Size(117, 23);
            this.lblProfileDetails.TabIndex = 0;
            this.lblProfileDetails.Text = "Patient Info...";
            // 
            // patientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnBookAppt);
            this.Controls.Add(this.lblWelcome);
            this.Name = "patientPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Portal Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.patientPage_FormClosed);
            this.Load += new System.EventHandler(this.patientPage_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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