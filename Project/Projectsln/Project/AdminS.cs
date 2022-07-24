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
    public partial class AdminS : Form
    {
        public AdminS()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            //string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";

            SqlConnection conn = new SqlConnection(connString);
            List<Ashowcs> Admin = new List<Ashowcs>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from Admin";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ashowcs a = new Ashowcs();
                    a.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    a.Fname = reader.GetString(reader.GetOrdinal("Fname"));
                    a.Lname = reader.GetString(reader.GetOrdinal("Lname"));
                    a.Full_name = reader.GetString(reader.GetOrdinal("Full_name"));
                    a.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    a.DOB = reader.GetString(reader.GetOrdinal("DOB"));
                    a.Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                    a.Address = reader.GetString(reader.GetOrdinal("Address"));
                    a.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                    a.Email = reader.GetString(reader.GetOrdinal("Email"));
                    Admin.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            dtA.DataSource = Admin;
        }
    }
}
