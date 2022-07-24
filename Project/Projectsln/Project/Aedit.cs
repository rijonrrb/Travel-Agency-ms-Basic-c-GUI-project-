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
    public partial class Aedit : Form
    {
        public Aedit()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            //string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";


            SqlConnection conn = new SqlConnection(connString);

                conn.Open();

                //tbuser.Text = LAdmin.SetValueForText1;
                string user = tbuser.Text;

                if (user == LAdmin.SetValueForText1)
                {
                    string query = string.Format("select * from Admin where Username='{0}' ", user);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    aReg a = new aReg();

                    while (reader.Read())
                    {
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


                    }
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    btnUpdate.Visible = true;
                    btndlt.Visible = true;

                    tbFname.Visible = true;
                    tbLname.Visible = true;
                    tbgender.Visible = true;
                    tbPhn.Visible = true;
                    tbNation.Visible = true;
                    tbAdress.Visible = true;
                    tbEmail.Visible = true;
                    tbdob.Visible = true;
                    tbID.Visible = true;
                    Invalid.Visible = false;

                    int aid = a.Id;
                    tbID.Text = Convert.ToString(aid);
                    tbFname.Text = a.Fname;
                    tbLname.Text = a.Lname;
                    tbgender.Text = a.Gender;
                    tbPhn.Text = a.Phone;
                    tbNation.Text = a.Nationality;
                    tbAdress.Text = a.Address;
                    tbEmail.Text = a.Email;
                    tbdob.Text = a.DOB;
                }
                else 
                {
                    Invalid.Visible = true;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    btnUpdate.Visible = false;
                    btndlt.Visible = false;

                    tbFname.Visible = false;
                    tbLname.Visible = false;
                    tbgender.Visible = false;
                    tbPhn.Visible = false;
                    tbNation.Visible = false;
                    tbAdress.Visible = false;
                    tbEmail.Visible = false;
                    tbdob.Visible = false;
                    tbID.Visible = false;
                    
                }
                conn.Close();
            }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Apage().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            //string user = LAdmin.SetValueForText1;
            string fname = tbFname.Text;
            string lname = tbLname.Text;
            string gender = tbgender.Text;
            string phn  = tbPhn.Text;
            string nation = tbNation.Text;
            string address = tbAdress.Text;
            string email = tbEmail.Text;
            string dob = tbdob.Text;
            string fullname = string.Concat(fname, " ", lname);

            string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            //string connString = @"Server=NEEHAL\SQLEXPRESS;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS; Database=Project ;Integrated Security=true;";

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = string.Format("update Admin set Fname='{0}',Lname='{1}',Full_name='{2}',Gender='{3}',DOB='{4}',Nationality='{5}',Address='{6}',Phone='{7}',Email='{8}' where Id={9}", fname, lname, fullname, gender, dob, nation, address, phn, email, id);
            try
            { SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show("Information Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void Aedit_Load(object sender, EventArgs e)
        {

        }

        private void Invalid_Click(object sender, EventArgs e)
        {

        }

        private void tbuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);

            string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            //string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
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

            string query = string.Format("delete from Admin where Id= " + id);

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
                this.Hide();
                new Welcome().Show();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

            
        }
    }

