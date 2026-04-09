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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            label2 = new Label();
            userNameField = new TextBox();
            passwordField = new TextBox();
            loginBtn = new Button();
            signupBtn = new Button();
            roleField = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 242, 241);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 58);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 242, 241);
            label2.Location = new Point(46, 126);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // userNameField
            // 
            userNameField.Location = new Point(45, 81);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(258, 27);
            userNameField.TabIndex = 2;
            userNameField.TextChanged += userNameField_TextChanged;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(46, 149);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(257, 27);
            passwordField.TabIndex = 3;
            passwordField.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Location = new Point(45, 250);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(258, 29);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.LightSeaGreen;
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupBtn.ForeColor = SystemColors.ButtonFace;
            signupBtn.Location = new Point(45, 338);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(258, 34);
            signupBtn.TabIndex = 5;
            signupBtn.Text = "Sign up";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += signupBtn_Click;
            // 
            // roleField
            // 
            roleField.FormattingEnabled = true;
            roleField.Items.AddRange(new object[] { "Patient", "Doctor", "Admin" });
            roleField.Location = new Point(152, 192);
            roleField.Name = "roleField";
            roleField.Size = new Size(151, 28);
            roleField.TabIndex = 6;
            roleField.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 242, 241);
            label3.Location = new Point(47, 304);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 7;
            label3.Text = "Do Not Have Account ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 242, 241);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 456);
            panel1.TabIndex = 8;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(roleField);
            Controls.Add(signupBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordField);
            Controls.Add(userNameField);
            Controls.Add(panel1);
            Name = "login";
            Text = "login";
            Load += login_Load;
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
    }
}