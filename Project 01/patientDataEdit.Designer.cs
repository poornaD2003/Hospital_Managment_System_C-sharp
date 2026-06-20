namespace Project_01
{
    partial class patientDataEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patientDataEdit));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            nameBox = new TextBox();
            emailBox = new TextBox();
            numberBox = new TextBox();
            addressBox = new TextBox();
            ageBox = new TextBox();
            sexBox = new ComboBox();
            bloodBox = new ComboBox();
            panel1 = new Panel();
            editBox = new Button();
            label8 = new Label();
            passBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 77);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 0;
            label1.Text = "Patient Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 133);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 200);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 2;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 267);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 3;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 336);
            label5.Name = "label5";
            label5.Size = new Size(47, 23);
            label5.TabIndex = 4;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 402);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 5;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(35, 472);
            label7.Name = "label7";
            label7.Size = new Size(112, 23);
            label7.TabIndex = 6;
            label7.Text = "Blood Group";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(35, 20);
            label9.Name = "label9";
            label9.Size = new Size(300, 41);
            label9.TabIndex = 8;
            label9.Text = "Change Your Details";
            label9.Click += label9_Click;
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.Location = new Point(88, 103);
            nameBox.Multiline = true;
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(279, 27);
            nameBox.TabIndex = 9;
            // 
            // emailBox
            // 
            emailBox.BorderStyle = BorderStyle.None;
            emailBox.Location = new Point(88, 159);
            emailBox.Multiline = true;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(279, 27);
            emailBox.TabIndex = 10;
            // 
            // numberBox
            // 
            numberBox.BorderStyle = BorderStyle.None;
            numberBox.Location = new Point(88, 226);
            numberBox.Multiline = true;
            numberBox.Name = "numberBox";
            numberBox.Size = new Size(279, 27);
            numberBox.TabIndex = 11;
            // 
            // addressBox
            // 
            addressBox.BorderStyle = BorderStyle.None;
            addressBox.Location = new Point(88, 293);
            addressBox.Multiline = true;
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(279, 27);
            addressBox.TabIndex = 12;
            // 
            // ageBox
            // 
            ageBox.BorderStyle = BorderStyle.None;
            ageBox.Location = new Point(88, 362);
            ageBox.Multiline = true;
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(279, 27);
            ageBox.TabIndex = 13;
            // 
            // sexBox
            // 
            sexBox.FormattingEnabled = true;
            sexBox.Items.AddRange(new object[] { "Male", "Female", "" });
            sexBox.Location = new Point(88, 428);
            sexBox.Name = "sexBox";
            sexBox.Size = new Size(195, 28);
            sexBox.TabIndex = 14;
            // 
            // bloodBox
            // 
            bloodBox.FormattingEnabled = true;
            bloodBox.Items.AddRange(new object[] { "A-", "A+", "0+", "0-" });
            bloodBox.Location = new Point(88, 498);
            bloodBox.Name = "bloodBox";
            bloodBox.Size = new Size(195, 28);
            bloodBox.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(427, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 710);
            panel1.TabIndex = 16;
            // 
            // editBox
            // 
            editBox.BackColor = Color.DarkGreen;
            editBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBox.ForeColor = SystemColors.Control;
            editBox.Location = new Point(35, 657);
            editBox.Name = "editBox";
            editBox.Size = new Size(339, 47);
            editBox.TabIndex = 17;
            editBox.Text = "Submit";
            editBox.UseVisualStyleBackColor = false;
            editBox.Click += editBox_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 549);
            label8.Name = "label8";
            label8.Size = new Size(150, 23);
            label8.TabIndex = 18;
            label8.Text = "Change Password";
            // 
            // passBox
            // 
            passBox.BorderStyle = BorderStyle.FixedSingle;
            passBox.Location = new Point(88, 591);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(279, 27);
            passBox.TabIndex = 19;
            passBox.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.email;
            pictureBox2.Location = new Point(46, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.phone_call;
            pictureBox3.Location = new Point(46, 226);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.location;
            pictureBox4.Location = new Point(46, 293);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.padlock;
            pictureBox5.Location = new Point(46, 591);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // patientDataEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 716);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(passBox);
            Controls.Add(label8);
            Controls.Add(editBox);
            Controls.Add(bloodBox);
            Controls.Add(sexBox);
            Controls.Add(ageBox);
            Controls.Add(addressBox);
            Controls.Add(numberBox);
            Controls.Add(emailBox);
            Controls.Add(nameBox);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "patientDataEdit";
            Text = "patientDataEdit";
            Load += patientDataEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox nameBox;
        private TextBox emailBox;
        private TextBox numberBox;
        private TextBox addressBox;
        private TextBox ageBox;
        private ComboBox sexBox;
        private ComboBox bloodBox;
        private Panel panel1;
        private Button editBox;
        private Label label8;
        private TextBox passBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}