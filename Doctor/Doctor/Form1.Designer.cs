namespace Doctor
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
            button4 = new Button();
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
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
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
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(48, 240);
            button5.Name = "button5";
            button5.Size = new Size(196, 29);
            button5.TabIndex = 7;
            button5.Text = "sign out";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(48, 205);
            button4.Name = "button4";
            button4.Size = new Size(196, 29);
            button4.TabIndex = 6;
            button4.Text = "Medical Census";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(48, 170);
            button3.Name = "button3";
            button3.Size = new Size(196, 29);
            button3.TabIndex = 5;
            button3.Text = "Appointments";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(48, 135);
            button2.Name = "button2";
            button2.Size = new Size(196, 29);
            button2.TabIndex = 4;
            button2.Text = "Patient Records";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(48, 100);
            button1.Name = "button1";
            button1.Size = new Size(196, 29);
            button1.TabIndex = 3;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
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
            label2.Click += label2_Click;
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
            textBox1.Location = new Point(13, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 30);
            textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGreen;
            panel4.Controls.Add(lblWelcome);
            panel4.Location = new Point(22, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 120);
            panel4.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(19, 14);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(260, 92);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome back,\r\nDoctor";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
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
            lblTotalPatients.FlatStyle = FlatStyle.Popup;
            lblTotalPatients.Location = new Point(3, 27);
            lblTotalPatients.Name = "lblTotalPatients";
            lblTotalPatients.Size = new Size(170, 31);
            lblTotalPatients.TabIndex = 8;
            lblTotalPatients.Text = "lblTotalPatients";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 27);
            label6.Name = "label6";
            label6.Size = new Size(178, 62);
            label6.TabIndex = 0;
            label6.Text = "\r\nTOTAL PATIENTS";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
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
            lblPendingAppointments.FlatStyle = FlatStyle.Popup;
            lblPendingAppointments.Location = new Point(9, 27);
            lblPendingAppointments.Name = "lblPendingAppointments";
            lblPendingAppointments.Size = new Size(76, 31);
            lblPendingAppointments.TabIndex = 9;
            lblPendingAppointments.Text = "label5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 27);
            label7.Name = "label7";
            label7.Size = new Size(284, 62);
            label7.TabIndex = 0;
            label7.Text = "\r\nPENDING APPOINTMENTS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 173);
            label8.Name = "label8";
            label8.Size = new Size(310, 38);
            label8.TabIndex = 3;
            label8.Text = "Today's Appointments";
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
            Text = "hi";
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
        private Button button4;
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
    }
}
