using System;
using System.Windows.Forms;

namespace Project_01
{
    public partial class emplyeeRegister : Form
    {
        public emplyeeRegister()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // emplyeeRegister
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "emplyeeRegister";
            this.Text = "Employee Register";
            this.ResumeLayout(false);
        }
    }
}
