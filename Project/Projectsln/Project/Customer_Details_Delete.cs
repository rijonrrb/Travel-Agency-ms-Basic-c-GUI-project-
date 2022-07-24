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
    public partial class Customer_Details_Delete : Form
    {
        public Customer_Details_Delete()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            string cid = tbDltCId.Text;
            

            
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int id = Int32.Parse(tbDltCId.Text);
            string query = string.Format("delete from Customer where Customer_id= " + id);

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                MessageBox.Show("Package Deleted");

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
            tbDltCId.Text = "";
            

            tbDltCId.Focus();
        }
    }
}
