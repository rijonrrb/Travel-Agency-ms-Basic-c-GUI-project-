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
    public partial class ManagerS : Form
    {
        public ManagerS()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }


        private void ManagerS_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

           // string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";


            SqlConnection conn = new SqlConnection(connString);
            List<Mshow> Manager = new List<Mshow>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from Manager";
            try
            {
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Mshow m = new Mshow();
                m.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                m.Fname = reader.GetString(reader.GetOrdinal("Fname"));
                m.Lname = reader.GetString(reader.GetOrdinal("Lname"));
                m.Full_name = reader.GetString(reader.GetOrdinal("Full_name"));
                m.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                m.DOB = reader.GetString(reader.GetOrdinal("DOB"));
                m.Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
                m.Address = reader.GetString(reader.GetOrdinal("Address"));
                m.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                m.Email = reader.GetString(reader.GetOrdinal("Email"));
                Manager.Add(m);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            dtM.DataSource = Manager;
        }
    }
}
