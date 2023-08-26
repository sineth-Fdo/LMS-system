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
    public partial class adLoading : Form
    {
        public adLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaGradient2Panel1.Width += 3;

            if (gunaGradient2Panel1.Width >= 800)
            {
                timer1.Stop();
                AdminDashbord ADB = new AdminDashbord();
                ADB.Show();
                this.Hide();

            }
        }
    }
}
