using System;
using System.Windows.Forms;

namespace Project_01
{
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(88, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // adminPage
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "adminPage";
            Text = "Admin Dashboard";
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminRegister adminregister = new adminRegister();
            adminregister.Show();
        }

        private Button button1;
    }
}
