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
    public partial class stLoading : Form
    {
        public stLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaGradient2Panel2.Width += 3;

            if (gunaGradient2Panel2.Width >= 800)
            {
                timer1.Stop();
                UserDashbord UDB = new UserDashbord();
                UDB.Show();
                this.Hide();

            }
        }
    }
}
