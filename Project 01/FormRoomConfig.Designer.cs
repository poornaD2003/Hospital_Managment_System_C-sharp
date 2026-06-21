namespace Project_01
{
    partial class FormRoomConfig
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvConfigRooms = new DataGridView();
            label1 = new Label();
            txtNewRoomNo = new TextBox();
            txtNewSection = new TextBox();
            label2 = new Label();
            txtNewPrice = new TextBox();
            label3 = new Label();
            cmbNewStatus = new ComboBox();
            label4 = new Label();
            btnAddRoom = new Button();
            btnUpdateRoomDetails = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConfigRooms).BeginInit();
            SuspendLayout();
            // 
            // dgvConfigRooms
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(245, 250, 247);
            dgvConfigRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvConfigRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConfigRooms.BackgroundColor = Color.White;
            dgvConfigRooms.BorderStyle = BorderStyle.None;
            dgvConfigRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConfigRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 107, 84);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 107, 84);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvConfigRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvConfigRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(235, 245, 240);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 107, 84);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvConfigRooms.DefaultCellStyle = dataGridViewCellStyle6;
            dgvConfigRooms.EnableHeadersVisualStyles = false;
            dgvConfigRooms.GridColor = Color.FromArgb(230, 235, 240);
            dgvConfigRooms.Location = new Point(68, 83);
            dgvConfigRooms.Margin = new Padding(3, 4, 3, 4);
            dgvConfigRooms.Name = "dgvConfigRooms";
            dgvConfigRooms.RowHeadersVisible = false;
            dgvConfigRooms.RowHeadersWidth = 51;
            dgvConfigRooms.RowTemplate.Height = 35;
            dgvConfigRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConfigRooms.Size = new Size(513, 200);
            dgvConfigRooms.TabIndex = 0;
            dgvConfigRooms.CellClick += dgvConfigRooms_CellClick;
            dgvConfigRooms.CellContentClick += dgvConfigRooms_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(68, 320);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Room No";
            // 
            // txtNewRoomNo
            // 
            txtNewRoomNo.BorderStyle = BorderStyle.FixedSingle;
            txtNewRoomNo.ForeColor = Color.FromArgb(30, 41, 59);
            txtNewRoomNo.Location = new Point(160, 316);
            txtNewRoomNo.Margin = new Padding(3, 4, 3, 4);
            txtNewRoomNo.Name = "txtNewRoomNo";
            txtNewRoomNo.Size = new Size(114, 27);
            txtNewRoomNo.TabIndex = 2;
            // 
            // txtNewSection
            // 
            txtNewSection.BorderStyle = BorderStyle.FixedSingle;
            txtNewSection.ForeColor = Color.FromArgb(30, 41, 59);
            txtNewSection.Location = new Point(160, 375);
            txtNewSection.Margin = new Padding(3, 4, 3, 4);
            txtNewSection.Name = "txtNewSection";
            txtNewSection.Size = new Size(114, 27);
            txtNewSection.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(68, 379);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Section";
            // 
            // txtNewPrice
            // 
            txtNewPrice.BorderStyle = BorderStyle.FixedSingle;
            txtNewPrice.ForeColor = Color.FromArgb(30, 41, 59);
            txtNewPrice.Location = new Point(427, 318);
            txtNewPrice.Margin = new Padding(3, 4, 3, 4);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(138, 27);
            txtNewPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(334, 324);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // cmbNewStatus
            // 
            cmbNewStatus.BackColor = Color.White;
            cmbNewStatus.FlatStyle = FlatStyle.Flat;
            cmbNewStatus.ForeColor = Color.FromArgb(30, 41, 59);
            cmbNewStatus.FormattingEnabled = true;
            cmbNewStatus.Items.AddRange(new object[] { "Available", "Maintenance" });
            cmbNewStatus.Location = new Point(427, 375);
            cmbNewStatus.Margin = new Padding(3, 4, 3, 4);
            cmbNewStatus.Name = "cmbNewStatus";
            cmbNewStatus.Size = new Size(138, 28);
            cmbNewStatus.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(30, 41, 59);
            label4.Location = new Point(334, 379);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Status";
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(0, 107, 84);
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(176, 429);
            btnAddRoom.Margin = new Padding(3, 4, 3, 4);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(125, 41);
            btnAddRoom.TabIndex = 9;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += button1_Click;
            // 
            // btnUpdateRoomDetails
            // 
            btnUpdateRoomDetails.BackColor = Color.FromArgb(0, 107, 84);
            btnUpdateRoomDetails.FlatAppearance.BorderSize = 0;
            btnUpdateRoomDetails.FlatStyle = FlatStyle.Flat;
            btnUpdateRoomDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateRoomDetails.ForeColor = Color.White;
            btnUpdateRoomDetails.Location = new Point(334, 429);
            btnUpdateRoomDetails.Margin = new Padding(3, 4, 3, 4);
            btnUpdateRoomDetails.Name = "btnUpdateRoomDetails";
            btnUpdateRoomDetails.Size = new Size(154, 41);
            btnUpdateRoomDetails.TabIndex = 10;
            btnUpdateRoomDetails.Text = "Update Room Details";
            btnUpdateRoomDetails.UseVisualStyleBackColor = false;
            btnUpdateRoomDetails.Click += btnUpdateRoomDetails_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 107, 84);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(53, 14);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormRoomConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(657, 514);
            Controls.Add(button1);
            Controls.Add(btnUpdateRoomDetails);
            Controls.Add(btnAddRoom);
            Controls.Add(label4);
            Controls.Add(cmbNewStatus);
            Controls.Add(txtNewPrice);
            Controls.Add(label3);
            Controls.Add(txtNewSection);
            Controls.Add(label2);
            Controls.Add(txtNewRoomNo);
            Controls.Add(label1);
            Controls.Add(dgvConfigRooms);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRoomConfig";
            Text = "FormRoomConfig";
            Load += FormRoomConfig_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConfigRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConfigRooms;
        private Label label1;
        private TextBox txtNewRoomNo;
        private TextBox txtNewSection;
        private Label label2;
        private TextBox txtNewPrice;
        private Label label3;
        private ComboBox cmbNewStatus;
        private Label label4;
        private Button btnAddRoom;
        private Button btnUpdateRoomDetails;
        private Button button1;
    }
}