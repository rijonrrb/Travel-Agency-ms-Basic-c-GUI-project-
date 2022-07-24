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
    public partial class Tour_package_add : Form
    {
        public Tour_package_add()
        {
            InitializeComponent();
        }
          protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            string packname = tbPackName.Text;
            string tourd = cbTourDuration.Text;
            string packprice = tbPackPrice.Text;
            string packfeat = cbPackFeat.Text;



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

            string query = string.Format("insert into Package values ('{0}','{1}','{2}','{3}')", packname, tourd, packprice, packfeat);

            try
            {

                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Package Details inserted");
                }
                else
                {
                    MessageBox.Show("Failed to insert Package Details");
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();

        }
        

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_page().Show();
        }


        
    }
}

    
