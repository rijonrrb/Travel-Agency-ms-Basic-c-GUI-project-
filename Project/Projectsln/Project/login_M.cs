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
    public partial class LManager : Form
    {
        public static string SetValueForText2 = ""; 
        public LManager()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void submit_Click(object sender, EventArgs e)
        {

            string uname = username.Text;
            string pass = password.Text;

            SetValueForText2 = username.Text;

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
            string query = string.Format("select * from Manager where Username='{0}' and Password='{1}' ", uname, pass);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    this.Hide();
                    new Mpage().Show();
                }
                else
                {
                    MessageBox.Show("Invalid user!!!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void ck1_CheckedChanged(object sender, EventArgs e)
        {
            if (ck1.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else if (ck1.Checked == false)
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
