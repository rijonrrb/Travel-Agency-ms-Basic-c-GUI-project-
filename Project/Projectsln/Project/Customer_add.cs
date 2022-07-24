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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
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

            string cname = tbCName.Text.Trim();
            string pid = tbPId.Text.Trim();
            string pname = tbPName.Text.Trim();
            string cphone = tbCPhone.Text.Trim();
            string cemail = tbCEmail.Text.Trim();
            string ptime = dt1.Text;

            //string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {

                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string query = string.Format("insert into Customer values ('{0}','{1}','{2}','{3}','{4}','{5}')", cname, pname, pid, cphone, cemail, ptime);

            try
            {

                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Customer Information inserted");
                }
                else
                {
                    MessageBox.Show("Failed to insert customer information");
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            RefreshControls();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manager_page().Show();
        }

        void RefreshControls()
        {
            tbCName.Text = "";
            tbPId.Text = "";
            tbPName.Text = "";
            tbCPhone.Text = "";
            tbCEmail.Text = "";
            dt1.Text = "";
           tbCName.Focus();
        }

   }

}

