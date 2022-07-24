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
    public partial class TP_Update : Form
    {
        public TP_Update()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void btnsrchUp_Click(object sender, EventArgs e)
        {
            //string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";

            SqlConnection conn = new SqlConnection(connString);
            //List<PackShow> Package = new List<PackShow>();
            try
            {

                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int Pack_id = Int32.Parse(tbTpIdUp.Text);
            string query = string.Format("select * from Package where Pack_id= " + Pack_id);

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            PackShow p = new PackShow();
            while (reader.Read())
            {
                //PackShow p = new PackShow();
                p.Pack_id = reader.GetInt32(reader.GetOrdinal("Pack_id"));
                p.Pack_name = reader.GetString(reader.GetOrdinal("Pack_name"));
                p.Tour_duration = reader.GetString(reader.GetOrdinal("Tour_duration"));
                p.Pack_price = reader.GetString(reader.GetOrdinal("Pack_price"));
                p.pack_feature = reader.GetString(reader.GetOrdinal("pack_feature"));
                //Package.Add(p);

            }
            conn.Close();
            tbTpNameUp.Text = p.Pack_name;
            tbTDuUp.Text = p.Tour_duration;
            tbTpPrUp.Text = p.Pack_price;
            tbTpFUp.Text = p.pack_feature;

        }
       

        private void btnpackUp_Click(object sender, EventArgs e)
        {
            int pid = Int32.Parse(tbTpIdUp.Text);
            string pname = tbTpNameUp.Text.Trim();
            string tduration = tbTDuUp.Text.Trim();
            string pprice = tbTpPrUp.Text.Trim();
            string pfeature = tbTpFUp.Text.Trim();

            //string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = string.Format("update Package set Pack_name='{0}',Tour_duration='{1}',Pack_price='{2}',pack_feature='{3}' where Pack_id={4}", pname, tduration, pprice, pfeature, pid);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show("Tour Package Details Updated");
            conn.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_page().Show();
        }
    }
}
