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

namespace Project
{
    public partial class TP_Delete : Form
    {
        public TP_Delete()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void btnpackDel_Click(object sender, EventArgs e)
        {
            string packid = tbTpId.Text;
            //string packname =tbTpName.Text;

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
            int Pack_id = Int32.Parse(tbTpId.Text);
            string query = string.Format("delete from Package where Pack_id= " + Pack_id);

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
        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            List<PackShow> Package = new List<PackShow>();
            try
            {

                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           int Pack_id = Int32.Parse(tbTpId.Text);
            string query = string.Format("select * from Package where Pack_id= " + Pack_id);

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //PackShow p = new PackShow();
            while (reader.Read())
            {
                PackShow p = new PackShow();
                p.Pack_id = reader.GetInt32(reader.GetOrdinal("Pack_id"));
                p.Pack_name = reader.GetString(reader.GetOrdinal("Pack_name"));
                p.Tour_duration = reader.GetString(reader.GetOrdinal("Tour_duration"));
                p.Pack_price = reader.GetString(reader.GetOrdinal("Pack_price"));
                p.pack_feature = reader.GetString(reader.GetOrdinal("pack_feature"));
                Package.Add(p);
                
            }
            conn.Close();
            gvTpDel.DataSource = Package;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_page().Show();
        }
    }
}
