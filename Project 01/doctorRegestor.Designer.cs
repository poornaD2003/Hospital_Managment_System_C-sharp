namespace Project_01
{
    partial class doctorRegestor
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
            label1 = new Label();
            dNameField = new TextBox();
            Password = new Label();
            passwordField = new TextBox();
            submitBtn = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 105);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Doctor Name";
            // 
            // dNameField
            // 
            dNameField.Location = new Point(492, 138);
            dNameField.Name = "dNameField";
            dNameField.Size = new Size(265, 27);
            dNameField.TabIndex = 1;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(492, 189);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // passwordField
            // 
            passwordField.Location = new Point(492, 226);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(261, 27);
            passwordField.TabIndex = 3;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.FromArgb(0, 107, 84);
            submitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.ForeColor = SystemColors.ButtonHighlight;
            submitBtn.Location = new Point(492, 302);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(265, 37);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Background;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 576);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(492, 48);
            label2.Name = "label2";
            label2.Size = new Size(233, 38);
            label2.TabIndex = 6;
            label2.Text = "Register Doctors";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.medium_shot_female_nurse_hospital_removebg_preview;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 487);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 107, 84);
            button1.BackgroundImage = Properties.Resources.Vector;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(786, 12);
            button1.Name = "button1";
            button1.Size = new Size(42, 29);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            // 
            // doctorRegestor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 569);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(submitBtn);
            Controls.Add(passwordField);
            Controls.Add(Password);
            Controls.Add(dNameField);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "doctorRegestor";
            Text = "doctorRegestor";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox dNameField;
        private Label Password;
        private TextBox passwordField;
        private Button submitBtn;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button button1;
    }
}