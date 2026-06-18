namespace Project_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel4 = new Panel();
            lblWelcome = new Label();
            panel5 = new Panel();
            lblTotalPatients = new Label();
            label6 = new Label();
            panel6 = new Panel();
            lblPendingAppointments = new Label();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            flowAppointments = new FlowLayoutPanel();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 754);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 255, 230);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(180, 50, 50);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(1, 707);
            button5.Name = "button5";
            button5.Padding = new Padding(40, 0, 0, 0);
            button5.Size = new Size(272, 42);
            button5.TabIndex = 7;
            button5.Text = "  \u23fb  Sign Out";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 230, 200);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 245, 220);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 203);
            button3.Name = "button3";
            button3.Padding = new Padding(40, 0, 0, 0);
            button3.Size = new Size(272, 42);
            button3.TabIndex = 5;
            button3.Text = "  📅  Appointments";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 230, 200);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 245, 220);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 161);
            button2.Name = "button2";
            button2.Padding = new Padding(40, 0, 0, 0);
            button2.Size = new Size(272, 42);
            button2.TabIndex = 4;
            button2.Text = "  👤  Patient Records";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 245, 220);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 230, 200);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 250, 230);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkGreen;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 119);
            button1.Name = "button1";
            button1.Padding = new Padding(40, 0, 0, 0);
            button1.Size = new Size(272, 42);
            button1.TabIndex = 3;
            button1.Text = "  📊  Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(302, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 70);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(671, 35);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 3;
            label4.Text = "Senior Cardiologist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(671, 10);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "Dr. Alistair Vance";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(807, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(13, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 30);
            textBox1.TabIndex = 0;
            textBox1.Text = "  Search patients, appointments...";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGreen;
            panel4.Controls.Add(lblWelcome);
            panel4.Location = new Point(22, 21);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15, 10, 0, 0);
            panel4.Size = new Size(300, 120);
            panel4.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(4, 4);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(260, 92);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome back,\r\nDoctor";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblTotalPatients);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(352, 21);
            panel5.Name = "panel5";
            panel5.Size = new Size(186, 120);
            panel5.TabIndex = 1;
            // 
            // lblTotalPatients
            // 
            lblTotalPatients.AutoSize = true;
            lblTotalPatients.BackColor = Color.White;
            lblTotalPatients.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalPatients.Location = new Point(3, 10);
            lblTotalPatients.Name = "lblTotalPatients";
            lblTotalPatients.Size = new Size(43, 50);
            lblTotalPatients.TabIndex = 8;
            lblTotalPatients.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(3, 60);
            label6.Name = "label6";
            label6.Size = new Size(143, 23);
            label6.TabIndex = 0;
            label6.Text = "TOTAL PATIENTS";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblPendingAppointments);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(544, 21);
            panel6.Name = "panel6";
            panel6.Size = new Size(308, 120);
            panel6.TabIndex = 2;
            // 
            // lblPendingAppointments
            // 
            lblPendingAppointments.AutoSize = true;
            lblPendingAppointments.BackColor = Color.White;
            lblPendingAppointments.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPendingAppointments.Location = new Point(9, 10);
            lblPendingAppointments.Name = "lblPendingAppointments";
            lblPendingAppointments.Size = new Size(43, 50);
            lblPendingAppointments.TabIndex = 9;
            lblPendingAppointments.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(9, 60);
            label7.Name = "label7";
            label7.Size = new Size(221, 23);
            label7.TabIndex = 0;
            label7.Text = "PENDING APPOINTMENTS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 173);
            label8.Name = "label8";
            label8.Size = new Size(425, 38);
            label8.TabIndex = 3;
            label8.Text = "Today's Pending Appointments";
            // 
            // panel3
            // 
            panel3.Controls.Add(flowAppointments);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(302, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(860, 665);
            panel3.TabIndex = 2;
            // 
            // flowAppointments
            // 
            flowAppointments.AutoScroll = true;
            flowAppointments.FlowDirection = FlowDirection.TopDown;
            flowAppointments.Location = new Point(22, 230);
            flowAppointments.Name = "flowAppointments";
            flowAppointments.Size = new Size(830, 400);
            flowAppointments.TabIndex = 7;
            flowAppointments.WrapContents = false;
            flowAppointments.Paint += flowAppointments_Paint;
            // 
            // button4
            // 
            button4.Location = new Point(578, 22);
            button4.Name = "button4";
            button4.Size = new Size(76, 29);
            button4.TabIndex = 4;
            button4.Text = "Profile";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1174, 778);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private Label lblWelcome;
        private Panel panel5;
        private Label label6;
        private Panel panel6;
        private Label label7;
        private Label label8;
        private Panel panel3;
        private FlowLayoutPanel flowAppointments;
        private Label lblTotalPatients;
        private Label lblPendingAppointments;
        private Button button4;
    }
}
