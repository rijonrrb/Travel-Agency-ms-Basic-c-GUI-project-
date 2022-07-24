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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            //string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            List<Customer1> Customer = new List<Customer1>();


                conn.Open();


            string query = "select * from Customer ";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer1 c = new Customer1();
                    c.Customer_Id = reader.GetInt32(reader.GetOrdinal("Customer_Id"));
                    c.Customer_name = reader.GetString(reader.GetOrdinal("Customer_name"));
                    c.Pack_name = reader.GetString(reader.GetOrdinal("Pack_name"));
                    c.Pack_id = reader.GetString(reader.GetOrdinal("Pack_id"));
                    c.Customer_phone = reader.GetString(reader.GetOrdinal("Customer_phone"));
                    c.Customer_email = reader.GetString(reader.GetOrdinal("Customer_email"));
                    c.Purchase_time = reader.GetString(reader.GetOrdinal("Purchase_time"));
                    Customer.Add(c);
                }

            conn.Close();
            dtCustomer.DataSource = Customer;
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manager_page().Show();
        }
    }
}
