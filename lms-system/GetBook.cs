using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms_system
{
    public partial class GetBook : Form
    {
        public GetBook()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Library li = new Library();
            li.Show();
            this.Hide();
        }
       
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ziney\\Documents\\Library.mdf;Integrated Security=True;Connect Timeout=30");
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int code = rnd.Next(0,1000);
            

            
            string getid, getname;

            getid = GETid.Text;
            getname = GETname.Text;


            if(getid == "" )
            {

            }

            try
            {
                string quary = "SELECT * FROM BOOK WHERE ID = '" + GETid.Text + "' ";
               
                SqlDataAdapter sda = new SqlDataAdapter(quary, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    getid = GETid.Text;
                   
                    
                    if (MessageBox.Show("Are you want to Borrow ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Borrowed Successfuly ! ");
                        MessageBox.Show("Book Code = "+code.ToString());
                        label5.Text = code.ToString();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete from BOOK where ID = @ID", con);

                        cmd.Parameters.AddWithValue("@ID", int.Parse(GETid.Text));
                        cmd.ExecuteNonQuery();
                        
                        con.Close();

                    }
                    else
                    {

                    }



                }
                else
                {
                    MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GETid.Text = "";
                    GETname.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {

            }

            label5.Text = code.ToString();
        }

        private void GetBook_Load(object sender, EventArgs e)
        {

        }
    }
}
