using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class REGISTRATIONam : Form
    {
        public REGISTRATIONam()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void Admin2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new REGISTRATION_A().Show();
        }

        private void Manager2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration_M().Show();
        }
    }
}
