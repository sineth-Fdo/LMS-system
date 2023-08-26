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
    public partial class studentlogin : Form
    {

       
        public studentlogin()
        {
            InitializeComponent();
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            studentregister SR = new studentregister();
            SR.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminlogin AL = new adminlogin();
            AL.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
        
        public void stulogin_Click(object sender, EventArgs e)
        {
            string username, pass;

            username = stname.Text;
            pass = stpassword.Text;

            try
            {
                string quary = "SELECT * FROM student WHERE StudentName = '"+ stname.Text + "' AND Password = '"+ stpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(quary,con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
              

                if(dt.Rows.Count > 0)
                {
                    username = stname.Text;
                    pass = stpassword.Text;

                    stLoading sl = new stLoading();
                    sl.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    stname.Text = "";
                    stpassword.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {

            }

           

        }

        private void studentlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
