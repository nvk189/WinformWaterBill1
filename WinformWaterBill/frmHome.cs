using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformWaterBill
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void lbConsumer_Click(object sender, EventArgs e)
        {
            frmConsumer cs = new frmConsumer();
            cs.Show();
            this.Hide();
        }

        private void lbBill_Click(object sender, EventArgs e)
        {
            frmBill c = new frmBill();
            c.Show();
            this.Hide();
        }

        private void lbDashBoard_Click(object sender, EventArgs e)
        {
            frmAdminlogin d = new frmAdminlogin();
            d.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmAdminlogin ags = new frmAdminlogin();
            ags.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmMainWDC he = new frmMainWDC();
            he.Show();
            this.Hide();
        }

        private void lbExith_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
