namespace Project_01
{
    partial class signUp
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            userNameField = new TextBox();
            passswordField = new TextBox();
            phoneNumberField = new TextBox();
            emailField = new TextBox();
            signupBtn = new Button();
            label5 = new Label();
            addressField = new TextBox();
            label6 = new Label();
            ageField = new NumericUpDown();
            Sex = new Label();
            label7 = new Label();
            bloodField = new ComboBox();
            sexField = new ComboBox();
            imageBtn = new Button();
            imageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ageField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(62, 67);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(62, 124);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 1;
            label2.Text = "Passsword";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(62, 182);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(62, 235);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 3;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // userNameField
            // 
            userNameField.Location = new Point(312, 67);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(253, 27);
            userNameField.TabIndex = 4;
            // 
            // passswordField
            // 
            passswordField.Location = new Point(314, 129);
            passswordField.Name = "passswordField";
            passswordField.Size = new Size(251, 27);
            passswordField.TabIndex = 5;
            passswordField.UseSystemPasswordChar = true;
            // 
            // phoneNumberField
            // 
            phoneNumberField.Location = new Point(314, 183);
            phoneNumberField.Name = "phoneNumberField";
            phoneNumberField.Size = new Size(251, 27);
            phoneNumberField.TabIndex = 6;
            // 
            // emailField
            // 
            emailField.Location = new Point(314, 244);
            emailField.Name = "emailField";
            emailField.Size = new Size(251, 27);
            emailField.TabIndex = 7;
            // 
            // signupBtn
            // 
            signupBtn.Location = new Point(341, 524);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(222, 29);
            signupBtn.TabIndex = 8;
            signupBtn.Text = "Signup";
            signupBtn.UseVisualStyleBackColor = true;
            signupBtn.Click += signupBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(62, 285);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 9;
            label5.Text = "Address";
            // 
            // addressField
            // 
            addressField.Location = new Point(315, 291);
            addressField.Name = "addressField";
            addressField.Size = new Size(248, 27);
            addressField.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(74, 344);
            label6.Name = "label6";
            label6.Size = new Size(47, 28);
            label6.TabIndex = 11;
            label6.Text = "Age";
            // 
            // ageField
            // 
            ageField.Location = new Point(315, 344);
            ageField.Name = "ageField";
            ageField.Size = new Size(150, 27);
            ageField.TabIndex = 12;
            // 
            // Sex
            // 
            Sex.AutoSize = true;
            Sex.BackColor = Color.Transparent;
            Sex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sex.ForeColor = SystemColors.ButtonFace;
            Sex.Location = new Point(87, 402);
            Sex.Name = "Sex";
            Sex.Size = new Size(42, 28);
            Sex.TabIndex = 13;
            Sex.Text = "Sex";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(90, 466);
            label7.Name = "label7";
            label7.Size = new Size(120, 28);
            label7.TabIndex = 16;
            label7.Text = "BloodGruop";
            // 
            // bloodField
            // 
            bloodField.FormattingEnabled = true;
            bloodField.Items.AddRange(new object[] { "A-", "o+", "o-", "AB-" });
            bloodField.Location = new Point(333, 470);
            bloodField.Name = "bloodField";
            bloodField.Size = new Size(151, 28);
            bloodField.TabIndex = 17;
            // 
            // sexField
            // 
            sexField.FormattingEnabled = true;
            sexField.Items.AddRange(new object[] { "Male", "Female" });
            sexField.Location = new Point(326, 411);
            sexField.Name = "sexField";
            sexField.Size = new Size(160, 28);
            sexField.TabIndex = 18;
            // 
            // imageBtn
            // 
            imageBtn.Location = new Point(732, 305);
            imageBtn.Name = "imageBtn";
            imageBtn.Size = new Size(94, 29);
            imageBtn.TabIndex = 19;
            imageBtn.Text = "Upload Image";
            imageBtn.UseVisualStyleBackColor = true;
            imageBtn.Click += imageBtn_Click;
            // 
            // imageBox
            // 
            imageBox.Location = new Point(700, 49);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(183, 214);
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.TabIndex = 20;
            imageBox.TabStop = false;
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.elegant_hand_painted_alcohol_ink_background_3001;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1002, 579);
            Controls.Add(imageBox);
            Controls.Add(imageBtn);
            Controls.Add(sexField);
            Controls.Add(bloodField);
            Controls.Add(label7);
            Controls.Add(Sex);
            Controls.Add(ageField);
            Controls.Add(label6);
            Controls.Add(addressField);
            Controls.Add(label5);
            Controls.Add(signupBtn);
            Controls.Add(emailField);
            Controls.Add(phoneNumberField);
            Controls.Add(passswordField);
            Controls.Add(userNameField);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signUp";
            Text = "signUp";
            ((System.ComponentModel.ISupportInitialize)ageField).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox userNameField;
        private TextBox passswordField;
        private TextBox phoneNumberField;
        private TextBox emailField;
        private Button signupBtn;
        private Label label5;
        private TextBox addressField;
        private Label label6;
        private NumericUpDown ageField;
        private Label Sex;
        private Label label7;
        private ComboBox bloodField;
        private ComboBox sexField;
        private Button imageBtn;
        private PictureBox imageBox;
    }
}