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
    
    public partial class frmBill : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A45UN95\SQLEXPRESS;Initial Catalog=WDCS;Integrated Security=True");
        public frmBill()
        {
            InitializeComponent();
            ShowBill();
            GetCons();
            GetAgentName();




        }

        private void lbBSearch_Click(object sender, EventArgs e)
        {
      
        }
        private void ShowBill()
        {
            // hiển thị  danh sách thanh toán hóa đơn từ csdl lên datagriview
            Con.Open();
            string Query = " select *from BillTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvBill.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetCons()
        {
            // hàm truy vấn lấy ID khách hàng từ bảng ConsumerTb
            Con.Open();
            SqlCommand cmd = new SqlCommand(" select CId from ConsumerTb", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CId", typeof(int));
            dt.Load(Rdr);
            cbBCID.ValueMember = "CId";
            cbBCID.DataSource = dt;
            Con.Close();
        }
       
        private void GetAgentName()
        {
            // hàm truy vấn lấy tên nhân viên từ bảng AgentTb
            Con.Open();
            SqlCommand cmd = new SqlCommand(" select AgName from AgentTb", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AgName", typeof(String));
            dt.Load(Rdr);
            cbBAgName.ValueMember = "AgName";
            cbBAgName.DataSource = dt;
            Con.Close();
           
        }
        private void GetConsRate()
        {
            // truy vấn lấy giá tiền cửa khách hàng
            Con.Open();
            string Query = "select * from ConsumerTb where CId=" + cbBCID.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtBRate.Text = dr["CRate"].ToString();

            }
            Con.Close();
        }
        private void GetConsName()
        {
            // truy vấn lấy tên của khách hàng thông qua id
            Con.Open();
            string Query = "select * from ConsumerTb where CId=" + cbBCID.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtBCName.Text = dr["CName"].ToString();

            }
            Con.Close();
        }
        private void Reset()
        {
            cbBCID.SelectedIndex = -1;
            txtBCName.Text = "";          
            cbBAgName.Text = "";
            dtBPeriod.Text = "";
            txtBConsupion.Text = "";
            txtBRate.Text = "";
            txtBTax.Text = "";
            txtBTotal.Text = "";
        }

       public int TinhTongTien(double a, double b, double c)
        {
            double total;
            total = b + c * (a / 100);
            return (int)total;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            // thêm thông tin thanh toán
            if (txtBConsupion.Text == "" || txtBRate.Text == "" || txtBTax.Text == "")
            {
                MessageBox.Show("Điền thông tin còn thiếu!!!");
            }
            else

            {
                if (Convert.ToInt32(txtBConsupion.Text) >= 0 & Convert.ToInt32(txtBRate.Text) > 0)
                {

                    try
                    {
                        double a = Convert.ToDouble(txtBTax.Text) ;
                        double b= Convert.ToInt32(txtBConsupion.Text) * Convert.ToInt32(txtBRate.Text);
                        double c = (Convert.ToInt32(txtBConsupion.Text) * Convert.ToInt32(txtBRate.Text));
                        txtBTotal.Text = TinhTongTien(a,b,c).ToString();


                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into BillTb(CId,CName,AgName,BPeriod,Comsuption,Rate,Tax,Total)values(@CID,@CN,@AN,@BP,@CST,@RT,@TAX,@TT)", Con);
                        cmd.Parameters.AddWithValue("@CID", cbBCID.Text);
                        cmd.Parameters.AddWithValue("@CN", txtBCName.Text);
                        cmd.Parameters.AddWithValue("@AN", cbBAgName.Text);
                        cmd.Parameters.AddWithValue("@BP", dtBPeriod.Value.Date);
                        cmd.Parameters.AddWithValue("@CST", txtBConsupion.Text);
                        cmd.Parameters.AddWithValue("@RT", txtBRate.Text);
                        cmd.Parameters.AddWithValue("@TAX", txtBTax.Text);
                        cmd.Parameters.AddWithValue("@TT", txtBTotal.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        Con.Close();    
                        ShowBill();


                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show(" Số khối nước và thuế không âm");
                }
              
            }
        }

        private void cbBCID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetConsRate();
            GetConsName();
        }

        private void cbAgentB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetAgentName();
            
        }
        int key = 0;
        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // cách truy suất  đến ô trong datagriview
            cbBCID.Text = dgvBill.CurrentRow.Cells[1].Value.ToString();
            txtBCName.Text = dgvBill.CurrentRow.Cells[2].Value.ToString();
            cbBAgName.Text = dgvBill.CurrentRow.Cells[3].Value.ToString();
            dtBPeriod.Text = dgvBill.CurrentRow.Cells[4].Value.ToString();
            txtBConsupion.Text = dgvBill.CurrentRow.Cells[5].Value.ToString();
            txtBRate.Text = dgvBill.CurrentRow.Cells[6].Value.ToString();
            txtBTax.Text = dgvBill.CurrentRow.Cells[7].Value.ToString();
            txtBTotal.Text = dgvBill.CurrentRow.Cells[8].Value.ToString();
            if (txtBCName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvBill.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtBConsupion.Text == "" || txtBRate.Text == "" || txtBTax.Text == "")
            {
                MessageBox.Show("Điền thông tin còn thiếu!!!");
            }
            else
            {
                if (Convert.ToInt32(txtBConsupion.Text) >= 0 & Convert.ToInt32(txtBRate.Text) > 0)
                {
                    try
                {


                        double a = Convert.ToDouble(txtBTax.Text);
                        double b = Convert.ToInt32(txtBConsupion.Text) * Convert.ToInt32(txtBRate.Text);
                        double c = (Convert.ToInt32(txtBConsupion.Text) * Convert.ToInt32(txtBRate.Text));
                        txtBTotal.Text = TinhTongTien(a, b, c).ToString();
                        Con.Open();
                    SqlCommand cmd = new SqlCommand("Update  BillTb set CId=@CID,CName=@CN,AgName=@AN,BPeriod=@BP,Comsuption=@CST,Rate=@RT,Tax=@TAX,Total=@TT where BNum=@Bkey", Con);

                    cmd.Parameters.AddWithValue("@CID", cbBCID.Text);
                    cmd.Parameters.AddWithValue("@CN", txtBCName.Text);
                    cmd.Parameters.AddWithValue("@AN", cbBAgName.Text);
                    cmd.Parameters.AddWithValue("@BP", dtBPeriod.Value.Date);
                    cmd.Parameters.AddWithValue("@CST", txtBConsupion.Text);
                    cmd.Parameters.AddWithValue("@RT", txtBRate.Text);
                    cmd.Parameters.AddWithValue("@TAX", txtBTax.Text);
                    cmd.Parameters.AddWithValue("@TT", txtBTotal.Text);
                    cmd.Parameters.AddWithValue("@Bkey", key);
                    cmd.ExecuteNonQuery();
                     MessageBox.Show("Sửa thành công");             
                    Con.Close();
                    ShowBill();
                   


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                }
                else
                {
                    MessageBox.Show(" Số khối nước và thuế không âm");
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            
            if (key == 0)
            {
                MessageBox.Show("Chọn Hóa đơn sẽ bị xóa!!! ");
            }
            else
            {
                try
                {
                   
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from BillTb where BNum =@Bkey", Con);

                    cmd.Parameters.AddWithValue("@Bkey", key);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Xóa thành công");
                    Con.Close();
                    ShowBill();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            // in hóa đơn
            try
            {

                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hệ thống quản lý thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btReceipt_Click(object sender, EventArgs e)
        {
            // xuất hóa đơn
           
            rtpReceipt.Clear();
            
            rtpReceipt.AppendText("\t\t  HÓA ĐƠN TIỀN NƯỚC \t\t\t\n\n\n\n\n");
            rtpReceipt.AppendText(lbCID.Text + ":" + "\t" + "\t" + cbBCID.Text + "\n\n");
            rtpReceipt.AppendText(lbCName.Text + ":" + "\t" + "\t" + txtBCName.Text + "\n\n");
           
            rtpReceipt.AppendText(lbAgentName.Text + ":" + "\t" + "\t" + cbBAgName.Text + "\n\n");
            rtpReceipt.AppendText(lbBPeriod.Text + ":" + "\t" + "\t" + dtBPeriod.Value.Date + "\n\n");
            rtpReceipt.AppendText(lbConsuption.Text + ":" + "\t" + txtBConsupion.Text + "\n\n");
            rtpReceipt.AppendText(lbRate.Text + ":" + "\t" + "\t" + "\t" + txtBRate.Text+"đ" + "\n\n");
            rtpReceipt.AppendText(lbTax.Text + ":" + "\t" + "\t" + "\t" + txtBTax.Text+"%" + "\n\n");

            rtpReceipt.AppendText("___________________________________________" + "\n" + "\n");
            rtpReceipt.AppendText(lbTotal.Text + ":" + "\t" + "\t" + txtBTotal.Text + "đ" + "\n" + "\n" + "\n");
           


          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // định dạng cho việc xuất hóa đơn
            try
            {

                System.Drawing.Font fntString = new System.Drawing.Font("Arial", 18, FontStyle.Regular);
                e.Graphics.DrawString(rtpReceipt.Text, fntString, Brushes.Black, 120, 120);

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hệ thống quản lý thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbConsumer_Click(object sender, EventArgs e)
        {
            frmConsumer q = new frmConsumer();
            q.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            frmAdminlogin b = new frmAdminlogin();
            b.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmAdminlogin ag = new frmAdminlogin();
            ag.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmHome homes = new frmHome();
            homes.Show();
            this.Hide();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
           
        }

        private void lbExitb_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void btReset_Click_1(object sender, EventArgs e)
        {
            Reset();
            ShowBill();
        }

        private void ptSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void ptSearchidbill_Click(object sender, EventArgs e)
        { 
            // tìm kiếm hóa đơn theo mã hóa đơn
            try
            {
                Con.Open();
                string Query = "select * from BillTb where    BNum='" + txtBSearch.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvBill.DataSource = dt;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Accer Connect", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            }
            cbBCID.Text = dgvBill.CurrentRow.Cells[1].Value.ToString();
            txtBCName.Text = dgvBill.CurrentRow.Cells[2].Value.ToString();

            cbBAgName.Text = dgvBill.CurrentRow.Cells[3].Value.ToString();
            dtBPeriod.Text = dgvBill.CurrentRow.Cells[4].Value.ToString();
            txtBConsupion.Text = dgvBill.CurrentRow.Cells[5].Value.ToString();
            txtBRate.Text = dgvBill.CurrentRow.Cells[6].Value.ToString();
            txtBTax.Text = dgvBill.CurrentRow.Cells[7].Value.ToString();
            txtBTotal.Text = dgvBill.CurrentRow.Cells[8].Value.ToString();
            if (txtBCName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvBill.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
