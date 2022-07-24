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
    public partial class Tour_guide : Form
    {
        public Tour_guide()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Gshow().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GuideAdd().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InformationUpdate().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Guide_Delete().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Mpage().Show();
        }
    }
}
