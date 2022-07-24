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
    public partial class InformationUpdate : Form
    {
        public InformationUpdate()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbSearch.Text) ;
            string gname = tbName.Text;
            string gmail = tbEmail.Text;
            string gaddress = tbAddress.Text;
            string gphone = tbPhn.Text;
            string cid = tbCID.Text;


            //string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = string.Format("update Guide set Tour_guide_name='{0}',Tour_guide_email='{1}',Tour_guide_address='{2}',Tour_guide_phn='{3}',Customer_id='{4}' where Tour_guide_id={5}", gname, gmail, gaddress, gphone, cid, id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show("Information Updated");
            conn.Close();

        
        }

        private void btnsearch_Click(object sender, EventArgs e)
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

            int id = Convert.ToInt32(tbSearch.Text);
            string query = "select * from Guide where Tour_guide_id = " + id;

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            GuideS c = new GuideS();
            while (reader.Read())
            {
                c.Tour_guide_id = reader.GetInt32(reader.GetOrdinal("Tour_guide_id"));
                c.Tour_guide_name = reader.GetString(reader.GetOrdinal("Tour_guide_name"));
                c.Tour_guide_email = reader.GetString(reader.GetOrdinal("Tour_guide_email"));
                c.Tour_guide_address = reader.GetString(reader.GetOrdinal("Tour_guide_address"));
                c.Tour_guide_phn = reader.GetString(reader.GetOrdinal("Tour_guide_phn"));
                c.Customer_id = reader.GetString(reader.GetOrdinal("Customer_id"));
                
            }

            conn.Close();

            tbName.Text = c.Tour_guide_name;
            tbEmail.Text = c.Tour_guide_email;
            tbAddress.Text = c.Tour_guide_address;
            tbPhn.Text = c.Tour_guide_phn;
            tbCID.Text = c.Customer_id;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Tour_guide().Show();
        }
    }
}
