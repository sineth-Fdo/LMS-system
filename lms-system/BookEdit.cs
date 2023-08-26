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
    public partial class BookEdit : Form
    {
        public BookEdit()
        {
            InitializeComponent();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update BOOK set ID=@ID, Name=@Name, Author=@Author, Category=@Category  where ID=@ID  ", con);

            cmd.Parameters.AddWithValue("@ID", int.Parse(Bid.Text));
            cmd.Parameters.AddWithValue("@Name", Bname.Text);
            cmd.Parameters.AddWithValue("@Author", Bau.Text);
            cmd.Parameters.AddWithValue("@Category", Sc.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("successfully Saved ");

            BookManage BM = new BookManage();
            BM.Show();
            this.Hide();


            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookManage BM = new BookManage();
            BM.Show();
            this.Hide();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into BOOK values (@ID,@Name,@Author,@Category)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(Bid.Text));
            cmd.Parameters.AddWithValue("@Name", Bname.Text);
            cmd.Parameters.AddWithValue("@Author", Bau.Text);
            cmd.Parameters.AddWithValue("@Category", Sc.Text);
            
            cmd.ExecuteNonQuery();

            MessageBox.Show("Sucsessfuly added !");

            BookManage BM = new BookManage();
            BM.Show();
            this.Hide();

            con.Close();


        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from BOOK where ID = @ID", con);

            cmd.Parameters.AddWithValue("@ID", int.Parse(Bid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Sucsessfuly Delete !");

            BookManage BM = new BookManage();
            BM.Show();
            this.Hide();


            con.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int bID = rnd.Next(0, 3000);
            Bid.Text = bID.ToString();
        }

        private void BookEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
