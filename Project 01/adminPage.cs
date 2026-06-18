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
            this.SuspendLayout();
            // 
            // adminPage
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "adminPage";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
        }
    }
}
