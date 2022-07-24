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
    public partial class Admin_page : Form
    {
        public Admin_page()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Tour_package_add().Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TP_Delete().Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TP_Update().Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Tour_package_show().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Apage().Show();
        }
    }
}
