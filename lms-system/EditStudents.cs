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
    public partial class EditStudents : Form
    {
       
        public EditStudents()
        {
            InitializeComponent();
        }

        private void EditStudents_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentManage SM = new StudentManage();
            SM.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from student where id = @id", con);

            cmd.Parameters.AddWithValue("@id", int.Parse(stText1.Text));
            cmd.ExecuteNonQuery();
           MessageBox.Show(stText1.Text+" Sucsessfuly Delete !");

            StudentManage SM = new StudentManage();
            SM.Show();
            this.Hide();


            con.Close();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update student set id=@id, StudentName=@StudentName, Gender=@Gender  where ID=@id  ", con);

            cmd.Parameters.AddWithValue("@id", int.Parse(stText1.Text));
            cmd.Parameters.AddWithValue("@StudentName", stText2.Text);
            cmd.Parameters.AddWithValue("@Gender", Gselect.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("successfully Saved ");

            StudentManage SM = new StudentManage();
            SM.Show();
            this.Hide();


            con.Close();
        }
    }
}
