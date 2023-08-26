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
    public partial class UserDashbord : Form
    {



        public UserDashbord()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradient2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradient2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradient2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }




        }

        private void gunaShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Library LI = new Library();
            LI.Show();
            this.Hide();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            GetBook GB = new GetBook();
            GB.Show();
            this.Hide();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                studentlogin SL = new studentlogin();
                SL.Show();
                this.Hide();

            }
            else
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
           

        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from student ", con);
            SqlCommand cmd2 = new SqlCommand("select * from BOOK ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            da2.Fill(dt2);
            con.Close();

            stcount.Text = dt.Rows.Count.ToString();
            bkcount.Text = dt2.Rows.Count.ToString();
        }
    }
}
