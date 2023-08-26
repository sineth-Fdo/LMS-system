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
    public partial class BookManage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
        public BookManage()
        {
            InitializeComponent();
        }

        private void combo1()
        {
            string quary1 = "select distinct Category from BOOK";

            SqlDataAdapter da = new SqlDataAdapter(quary1, con);
            con.Open();
            DataSet dt = new DataSet();
            da.Fill(dt, "Category");
            Sc.DisplayMember = "Category";
            Sc.ValueMember = "Category";
            Sc.DataSource = dt.Tables["Category"];
            con.Close();

            if (Sc.Items.Count > 1)
            {
                Sc.SelectedIndex = -1;
            }



        }

        private void display_datgrid()
        {
            SqlCommand quary2 = new SqlCommand("select ID,Name,Author,Category from BOOK where Category like '%" + Sc.Text + "'", con);
            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = quary2;
            dt2.Clear();
            da2.Fill(dt2);
            gunaDataGridView2.DataSource = dt2;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            SqlCommand cmd = new SqlCommand("Select * from BOOK ", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gunaDataGridView2.DataSource = dt;
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            BookEdit BookEdit = new BookEdit();
            BookEdit.Show();
            this.Hide();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            AdminDashbord ADB = new AdminDashbord();
            ADB.Show();
            this.Hide();
        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sc_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_datgrid();
        }

        private void BookManage_Load(object sender, EventArgs e)
        {
            combo1();
            display_datgrid();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            SqlCommand cmd = new SqlCommand("Select * from BOOK ", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gunaDataGridView2.DataSource = dt;
        }
    }
}
