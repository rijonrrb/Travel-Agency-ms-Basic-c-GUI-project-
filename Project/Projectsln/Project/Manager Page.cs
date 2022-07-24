using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Project
{
    public partial class Manager_page : Form
    {
        public Manager_page()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void Manager_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerInfo().Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer_Details_Update().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Mpage().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer_Details_Delete().Show();
        }
    }
}
