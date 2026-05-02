namespace Project_01
{
    partial class login
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
            userNameField = new TextBox();
            passwordField = new TextBox();
            loginBtn = new Button();
            signupBtn = new Button();
            roleField = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(580, 101);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(584, 171);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // userNameField
            // 
            userNameField.Location = new Point(580, 126);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(258, 27);
            userNameField.TabIndex = 2;
            userNameField.TextChanged += userNameField_TextChanged;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(584, 194);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(257, 27);
            passwordField.TabIndex = 3;
            passwordField.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(0, 107, 84);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(580, 295);
            loginBtn.Margin = new Padding(3, 4, 4, 3);
            loginBtn.Name = "loginBtn";
            loginBtn.Padding = new Padding(0, 2, 2, 0);
            loginBtn.Size = new Size(258, 43);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Enter Dashboard";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // signupBtn
            // 
            signupBtn.BackColor = SystemColors.ActiveCaptionText;
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupBtn.ForeColor = SystemColors.ButtonFace;
            signupBtn.Location = new Point(580, 393);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(258, 42);
            signupBtn.TabIndex = 5;
            signupBtn.Text = "Sign up";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += signupBtn_Click;
            // 
            // roleField
            // 
            roleField.FormattingEnabled = true;
            roleField.Items.AddRange(new object[] { "Patient", "Doctor", "Admin" });
            roleField.Location = new Point(687, 241);
            roleField.Name = "roleField";
            roleField.Size = new Size(151, 28);
            roleField.TabIndex = 6;
            roleField.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(584, 360);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 7;
            label3.Text = "Do Not Have Account ";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(224, 242, 241);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 660);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 107, 84);
            panel2.BackgroundImage = Properties.Resources.Background;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 662);
            panel2.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(57, 279);
            label8.Name = "label8";
            label8.Size = new Size(352, 60);
            label8.TabIndex = 4;
            label8.Text = "Welcome to Clinical Sanctuary. Managing your\nhealth journey with organic precision and high-level\nmedical oversight.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(52, 199);
            label7.Name = "label7";
            label7.Size = new Size(91, 41);
            label7.TabIndex = 3;
            label7.Text = "login";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(53, 155);
            label6.Name = "label6";
            label6.Size = new Size(292, 41);
            label6.TabIndex = 2;
            label6.Text = "starts with a single ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(53, 113);
            label5.Name = "label5";
            label5.Size = new Size(219, 41);
            label5.TabIndex = 1;
            label5.Text = "Precision care ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(53, 37);
            label4.Name = "label4";
            label4.Size = new Size(132, 28);
            label4.TabIndex = 0;
            label4.Text = "The Hospital";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(593, 241);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 10;
            label9.Text = "Role";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(944, 660);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(roleField);
            Controls.Add(signupBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordField);
            Controls.Add(userNameField);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userNameField;
        private TextBox passwordField;
        private Button loginBtn;
        private Button signupBtn;
        private ComboBox roleField;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}