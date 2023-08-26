using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms_system
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void backtostulog_Click(object sender, EventArgs e)
        {
            
        }

        private void admlogin_Click(object sender, EventArgs e)
        {
            string Aname = adminname.Text;
            string APass = adminpassword.Text;

           if (Aname == "ADMIN" && APass == "admin123")
            {
                adLoading adLoading = new adLoading();
                adLoading.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show("Invalide Username or Password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            studentlogin objstlog = new studentlogin();
            objstlog.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
