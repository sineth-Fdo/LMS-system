using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms_system
{
    public partial class studentregister : Form
    {
        public studentregister()
        {
            InitializeComponent();
            
        }

       



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            studentlogin objstlog = new studentlogin();
            objstlog.Show();
            this.Hide();
        }

        private void confirmreg_Click(object sender, EventArgs e)
        {

            if(stid.Text == "" || stname.Text == "" || stgender.Text == "" || stgrade.Text == "" || pword.Text == ""  )
            {
                MessageBox.Show("Fii the boxes first ");
            }
            else
            {
                if(pword.Text == conpword.Text)
                {

                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into student values (@id,@StudentName,@Gender,@Grade,@Password)", con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(stid.Text));
                    cmd.Parameters.AddWithValue("@StudentName", stname.Text);
                    cmd.Parameters.AddWithValue("@Gender", stgender.Text);
                    cmd.Parameters.AddWithValue("@Grade", stgrade.Text);
                    cmd.Parameters.AddWithValue("@Password", pword.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sucsessfuly added !");
                    stid.Text = "";
                    stname.Text = "";
                    stgender.Text = "";
                    stgrade.Text = "";
                    pword.Text = "";
                    conpword.Text = "";

                    con.Close();
                }else
                {
                    MessageBox.Show("Ckeck the Comfirm Password");
                }


            }


            

            


          

        }

        private void studentregister_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            studentlogin SL = new studentlogin();
            SL.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ID = rnd.Next(0, 10000);
            stid.Text = ID.ToString();


        }


        /*private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            studentlogin objstlog = new studentlogin();
            objstlog.Show();
            this.Hide();
        }
        */
    }
}
