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
    public partial class Customer_Details_Update : Form
    {
        public Customer_Details_Update()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void Customer_Details_Update_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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

            int id = Int32.Parse(tbSrchCId.Text);
            string query = "select * from Customer where Customer_id = "+ id;

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Customer1 c = new Customer1();
            while (reader.Read())
            {
                c.Customer_Id = reader.GetInt32(reader.GetOrdinal("Customer_Id"));
                c.Customer_name = reader.GetString(reader.GetOrdinal("Customer_name"));
                c.Pack_name = reader.GetString(reader.GetOrdinal("Pack_name"));
                c.Pack_id = reader.GetString(reader.GetOrdinal("Pack_id"));
                c.Customer_phone = reader.GetString(reader.GetOrdinal("Customer_phone"));
                c.Customer_email = reader.GetString(reader.GetOrdinal("Customer_email"));
                c.Purchase_time = reader.GetString(reader.GetOrdinal("Purchase_time"));
            }

            conn.Close();

            tbCNameUpdate.Text = c.Customer_name;
            tbPNameUpdate.Text = c.Pack_name;
            tbPIdUpdate.Text = c.Pack_id;
            tbCPhoneUpdate.Text = c.Customer_phone;
            tbCEmailUpdate.Text = c.Customer_email;
            dtUpdate.Text = c.Purchase_time;

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(tbSrchCId.Text);
            string cname = tbCNameUpdate.Text.Trim();
            string pid = tbPIdUpdate.Text.Trim();
            string pname = tbPNameUpdate.Text.Trim();
            string cphone = tbCPhoneUpdate.Text.Trim();
            string cemail = tbCEmailUpdate.Text.Trim();
            string ptime = dtUpdate.Text;

            string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = string.Format("update Customer set Customer_name='{0}',Pack_id='{1}',Pack_name='{2}',Customer_phone='{3}',Customer_email='{4}',Purchase_time='{5}' where Customer_id={6}", cname, pid, pname, cphone, cemail, ptime, id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show("Information Updated");
            conn.Close();
            RefreshControls();

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Manager_page().Show();
        }
        void RefreshControls()
        {
            tbSrchCId.Text = "";
            tbCNameUpdate.Text = "";
            tbPIdUpdate.Text = "";
            tbPNameUpdate.Text = "";
            tbCPhoneUpdate.Text = "";
            tbCEmailUpdate.Text = "";
            dtUpdate.Text = "";

            tbSrchCId.Focus();
        }
    }
}

