namespace Project_01
{
    partial class adminRegister
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameBox = new TextBox();
            passBox = new TextBox();
            registerBtn = new Button();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.jc_gellidon_9Eb_bpTXglM_unsplash;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 448);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(446, 20);
            label1.Name = "label1";
            label1.Size = new Size(191, 41);
            label1.TabIndex = 1;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 116);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Full Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 178);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.Location = new Point(407, 139);
            nameBox.Multiline = true;
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(290, 27);
            nameBox.TabIndex = 4;
            // 
            // passBox
            // 
            passBox.BorderStyle = BorderStyle.FixedSingle;
            passBox.Location = new Point(407, 201);
            passBox.Name = "passBox";
            passBox.PasswordChar = '•';
            passBox.Size = new Size(290, 27);
            passBox.TabIndex = 5;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.DarkGreen;
            registerBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = SystemColors.Control;
            registerBtn.Location = new Point(372, 257);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(325, 46);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.user;
            pictureBox4.Location = new Point(372, 139);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.padlock;
            pictureBox1.Location = new Point(372, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // adminRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 450);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(registerBtn);
            Controls.Add(passBox);
            Controls.Add(nameBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "adminRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameBox;
        private TextBox passBox;
        private Button registerBtn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
    }
}