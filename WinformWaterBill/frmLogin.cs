using Microsoft.Office.Interop.Excel;
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
using System.Data.SqlClient;

namespace WinformWaterBill
{
    public partial class frmLogin : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A45UN95\SQLEXPRESS;Initial Catalog=WDCS;Integrated Security=True");
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool dangnnhap_test(string a,string b)
        {
            if(a=="" || b == "")
            {
                return false;
            }
            else if(a=="" & b == "")
            {
                return false;
            }
            else
            {
                Con.Open();
             
                string sql = "select*from AgentTb where AgName='" + a + "' and AgPass='" + b + "'";
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show(" Đăng nhập thành công");
                    frmHome h = new frmHome();
                    h.Show();
                    this.Hide();
                    return true;
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập");
                    return false;
                }
                
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                dangnnhap_test(txtNamelogin.Text, txtPasslogin.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi đường truyền");
            }
        }

        private void lbAdmin_Click(object sender, EventArgs e)
        {
            frmAdminlogin ad = new frmAdminlogin();
            ad.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //MainWDC dc = new MainWDC();
            //dc.Show();
            //this.Hide();

        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            frmMainWDC dc = new frmMainWDC();
            dc.Show();
            this.Hide();
        }

        public bool ValidateUsername(string username)
        {
            username= txtNamelogin.Text;
            // Kiểm tra tính hợp lệ của Tên đăng nhập
            if (string.IsNullOrEmpty(username))
            {
                return false; // Tên đăng nhập không được để trống
            }

            // Kiểm tra các quy tắc khác để đảm bảo tính hợp lệ của Tên đăng nhập
            // ...

            return true; // Tên đăng nhập hợp lệ
        }

        //public bool ValidatePassword(string password)
        //{
        //    txtPasslogin.Text = "password";
        //    password = txtPasslogin.Text;
        //    // Kiểm tra tính hợp lệ của Mật khẩu
        //    if (string.IsNullOrEmpty(password))
        //    {
        //        return true; // Mật khẩu không được để trống
        //    }

        //    // Kiểm tra các quy tắc khác để đảm bảo tính hợp lệ của Mật khẩu
        //    // ...

        //    return false; // Mật khẩu hợp lệ
        //}
    }
}
