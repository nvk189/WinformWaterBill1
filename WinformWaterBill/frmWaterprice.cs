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

namespace WinformWaterBill
{
    public partial class frmWaterprice : Form
    {
        public frmWaterprice()
        {
            InitializeComponent();
            ShowMoneyWate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A45UN95\SQLEXPRESS;Initial Catalog=WDCS;Integrated Security=True");
        private void ShowMoneyWate()
        {
            // hiện dữ liệu lên datagriview
            Con.Open();
            string Query = " select *from WaterpriceTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvMoneywate.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {

            txtCategory.Text = "";
            txtmoneywate.Text = "";
        }
        private void btSaveWate_Click(object sender, EventArgs e)
        {
            if (txtmoneywate.Text == "" || txtCategory.Text == "")
            {
                MessageBox.Show("thông tin còn thiếu!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into WaterpriceTb(Category,Money)values(@CGR,@MN)", Con);

                    cmd.Parameters.AddWithValue("@CGR", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@MN", txtmoneywate.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    Con.Close();
                    ShowMoneyWate();
                    Reset();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtmoneywate.Text == "" || txtCategory.Text == "")
            {
                MessageBox.Show("thông tin còn thiếu!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update WaterpriceTb set Category=@CGR,Money=@MN where WateId=@Wkey", Con);

                    cmd.Parameters.AddWithValue("@CGR", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@MN", txtmoneywate.Text);
                    cmd.Parameters.AddWithValue("@Wkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    Con.Close();
                    ShowMoneyWate();
                    Reset();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        int key = 0;

        private void dgvMoneywate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategory.Text = dgvMoneywate.CurrentRow.Cells[1].Value.ToString();
            txtmoneywate.Text = dgvMoneywate.CurrentRow.Cells[2].Value.ToString();


            //if (txtCategory.Text == "")
            //{
            //    key = 0;
            //}
            //else
            //{
            //    key = Convert.ToInt32(dgvMoneywate.CurrentRow.Cells[0].Value.ToString());
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
            ShowMoneyWate();
        }

        private void lbConsumerw_Click(object sender, EventArgs e)
        {
            frmConsumer cs = new frmConsumer();
            cs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dgvMoneywate.Rows.Count; i++)
            //    if (dgvMoneywate.Rows[i].Cells[0].Value != null)
            //    {
            //        delete(dgvMoneywate.Rows[i].Cells[2].Value.ToString());
            //        //MessageBox.Show(dataGridView1.Rows[i].Cells[2].Value.ToString());

            //    }


            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Delete from WaterpriceTb  ", Con);

                //cmd.Parameters.AddWithValue("@Akey", key);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                Con.Close();
                ShowMoneyWate();
                Reset();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void Waterprice_Load(object sender, EventArgs e)
        {
            //DataGridViewCheckBoxColumn ch = new DataGridViewCheckBoxColumn();
            //ch.Name = "ChonXoa";
            //ch.HeaderText = "Chọn Xóa";
            //dgvMoneywate.Columns.Insert(0, ch);
        }


        private void dgvMoneywate_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Query = "select*from WaterpriceTb where Money='" + txtTimkiem.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvMoneywate.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Accer Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Delete from WaterpriceTb where  Money='" + txtTimkiem.Text + "'  ", Con);

                //cmd.Parameters.AddWithValue("@Akey", key);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                Con.Close();
                ShowMoneyWate();
                Reset();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvMoneywate.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvMoneywate.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvMoneywate.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvMoneywate.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvMoneywate.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 1, j + 1] = dgvMoneywate.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
            //private void btnXoa_Click(object sender, EventArgs e)
            //{
            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //        if (dataGridView1.Rows[i].Cells[0].Value != null)
            //        {
            //            delete(dataGridView1.Rows[i].Cells[2].Value.ToString());
            //            //MessageBox.Show(dataGridView1.Rows[i].Cells[2].Value.ToString());

            //        }
            //}
        }
    }
}
