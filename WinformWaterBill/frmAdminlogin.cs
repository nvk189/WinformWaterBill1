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
    public partial class frmAdminlogin : Form
    {
        public frmAdminlogin()
        {
            InitializeComponent();
        }

        private void lblogin_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }

        public void btLoginadmin_Click(object sender, EventArgs e)
        {
            //// đặt mật khẩu cho quyền đăng nhập admin
            //if (txtPassloginadmin.Text == "")
            //{
            //    MessageBox.Show(" Sai mật khẩu");
            //}else if(txtPassloginadmin.Text=="Admin")
            //{
            //    Agent a = new Agent();
            //    a.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Sai mật khẩu ");
            //}
            ValidatePassword(txtPassloginadmin.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btThongke_Click(object sender, EventArgs e)
        {
            if (txtPassloginadmin.Text == "")
            {
                MessageBox.Show(" Sai mật khẩu");
            }
            else if (txtPassloginadmin.Text == "Admin")
            {
                frmDashBoad b = new frmDashBoad();
                b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu ");
            }
        }
        public bool ValidatePassword(string password)
        {
            if (password == "")
            {
                MessageBox.Show(" Không được để trống ");
                return false;
            }
            else if (password == "Admin")
            {
                MessageBox.Show(" Đăng nhập thành công ");
                frmAgent a = new frmAgent();
                a.Show();
                this.Hide();
                return true;
            }
            else
            {
                MessageBox.Show("Sai mật khẩu ");
                return false;
            }
        }
    }
}
