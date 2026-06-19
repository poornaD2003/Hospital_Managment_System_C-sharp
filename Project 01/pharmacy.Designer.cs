namespace Project_01
{
    partial class pharmacy
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            label6 = new Label();
            idLabel = new Label();
            updateBtn = new Button();
            addBtn = new Button();
            dateBox = new TextBox();
            label5 = new Label();
            categoryBox = new ComboBox();
            label4 = new Label();
            priceBox = new TextBox();
            label3 = new Label();
            stockBox = new NumericUpDown();
            label2 = new Label();
            nameBox = new TextBox();
            label1 = new Label();
            searchBox = new TextBox();
            panel2 = new Panel();
            loadMedicine = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadMedicine).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Background;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(dateBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(categoryBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(priceBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(stockBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(searchBox);
            panel1.Location = new Point(-4, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 481);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 107, 84);
            button1.BackgroundImage = Properties.Resources.Vector;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(35, 16);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(39, 22);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(35, 60);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 15;
            label6.Text = "Search";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(378, 133);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 15);
            idLabel.TabIndex = 14;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = SystemColors.ActiveCaptionText;
            updateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = SystemColors.ButtonHighlight;
            updateBtn.Location = new Point(26, 410);
            updateBtn.Margin = new Padding(3, 2, 3, 2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(334, 26);
            updateBtn.TabIndex = 13;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(0, 107, 84);
            addBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = SystemColors.ButtonHighlight;
            addBtn.Location = new Point(26, 375);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(334, 30);
            addBtn.TabIndex = 12;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dateBox
            // 
            dateBox.Location = new Point(35, 230);
            dateBox.Margin = new Padding(3, 2, 3, 2);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(326, 23);
            dateBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(35, 212);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 10;
            label5.Text = "Expier Date";
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Tablets", "", "Capsules", "", "Syrups", "", "Injections", "", "Drops (Eye drops / Ear drops / Nasal drops)", "", "Ointments", "", "Creams", "", "Gels", "", "Lotions", "", "Inhalers", "", "Powders", "", "Suspensions", "", "Solutions", "", "Vaccines", "", "Herbal Medicines", "", "Antibiotics", "", "Painkillers (Analgesics)", "", "Antiseptics", "", "Vitamins & Supplements", "", "Hormonal Medicines" });
            categoryBox.Location = new Point(35, 178);
            categoryBox.Margin = new Padding(3, 2, 3, 2);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(326, 23);
            categoryBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(35, 161);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Category";
            label4.Click += label4_Click;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(35, 329);
            priceBox.Margin = new Padding(3, 2, 3, 2);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(326, 23);
            priceBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(35, 312);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // stockBox
            // 
            stockBox.Location = new Point(35, 279);
            stockBox.Margin = new Padding(3, 2, 3, 2);
            stockBox.Name = "stockBox";
            stockBox.Size = new Size(326, 23);
            stockBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(35, 262);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Stock";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(35, 130);
            nameBox.Margin = new Padding(3, 2, 3, 2);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(326, 23);
            nameBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 113);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "Medicine Name";
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.Gainsboro;
            searchBox.Location = new Point(35, 77);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(326, 23);
            searchBox.TabIndex = 0;
            searchBox.TextChanged += searchBox_TextChanged;
            searchBox.Enter += searchBox_Enter;
            searchBox.Leave += searchBox_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(loadMedicine);
            panel2.Location = new Point(411, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(676, 478);
            panel2.TabIndex = 1;
            // 
            // loadMedicine
            // 
            loadMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            loadMedicine.DefaultCellStyle = dataGridViewCellStyle1;
            loadMedicine.Location = new Point(0, 16);
            loadMedicine.Margin = new Padding(3, 2, 3, 2);
            loadMedicine.Name = "loadMedicine";
            loadMedicine.RowHeadersWidth = 51;
            loadMedicine.Size = new Size(658, 452);
            loadMedicine.TabIndex = 0;
            loadMedicine.CellClick += loadMedicine_CellClick;
            loadMedicine.CellContentClick += loadMedicine_CellContentClick;
            // 
            // pharmacy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 477);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "pharmacy";
            Text = "pharmacy";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockBox).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loadMedicine).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox searchBox;
        private Panel panel2;
        private Label label2;
        private TextBox nameBox;
        private Label label1;
        private TextBox priceBox;
        private Label label3;
        private NumericUpDown stockBox;
        private ComboBox categoryBox;
        private Label label4;
        private Button updateBtn;
        private Button addBtn;
        private TextBox dateBox;
        private Label label5;
        private DataGridView loadMedicine;
        private Label idLabel;
        private Label label6;
        private Button button1;
    }
}