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
    public partial class Gshow : Form
    {
        public Gshow()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";

            SqlConnection conn = new SqlConnection(connString);
            List<GuideS> Guide = new List<GuideS>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from Guide";
            try
            {
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                GuideS GS= new GuideS();
                GS.Tour_guide_id = reader.GetInt32(reader.GetOrdinal("Tour_guide_id"));
                GS.Tour_guide_name = reader.GetString(reader.GetOrdinal("Tour_guide_name"));
                GS.Tour_guide_email = reader.GetString(reader.GetOrdinal("Tour_guide_email"));
                GS.Tour_guide_address = reader.GetString(reader.GetOrdinal("Tour_guide_address"));
                GS.Tour_guide_phn = reader.GetString(reader.GetOrdinal("Tour_guide_phn"));
                GS.Customer_id = reader.GetString(reader.GetOrdinal("Customer_id"));
               
                Guide.Add(GS);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            Dtg.DataSource = Guide;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Tour_guide().Show();
        }

        private void Dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        }
    }

