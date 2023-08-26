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


namespace lms_system
{
    public partial class StudentManage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");


        public StudentManage()
        {
            InitializeComponent();
            
        }

        private void combo1()
        {
            string quary1 = "select distinct Gender from student";

            SqlDataAdapter da = new SqlDataAdapter(quary1, con);
            con.Open();
            DataSet dt = new DataSet();
            da.Fill(dt, "Gender");
            SM.DisplayMember = "Gender";
            SM.ValueMember = "Gender";
            SM.DataSource = dt.Tables["Gender"];
            con.Close();

            if (SM.Items.Count > 1)
            {
                SM.SelectedIndex = -1;
            }


        }

        private void display_datgrid()
        {
            SqlCommand quary2 = new SqlCommand("select id,StudentName,Gender,Grade from student where Gender like '%" + SM.Text + "'", con);
            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = quary2;
            dt2.Clear();
            da2.Fill(dt2);
            SMgrid.DataSource = dt2;



        }

        private void StudentManage_Load(object sender, EventArgs e)
        {
            combo1();
            display_datgrid();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            EditStudents ES = new EditStudents();
            ES.Show();
            this.Hide();
           



        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            AdminDashbord ADB = new AdminDashbord();
            ADB.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            SqlCommand cmd = new SqlCommand("Select * from student ", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SMgrid.DataSource = dt; 

        }

        private void gunaDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SMgrid.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            SqlCommand cmd = new SqlCommand("Select id,StudentName,Gender,Grade from student ", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SMgrid.DataSource = dt;
        }

        private void SM_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_datgrid();
        }

        private void SMgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
