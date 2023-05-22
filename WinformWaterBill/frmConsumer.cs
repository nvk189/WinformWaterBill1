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

namespace WinformWaterBill
{
    public partial class frmConsumer : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A45UN95\SQLEXPRESS;Initial Catalog=WDCS;Integrated Security=True");
        public frmConsumer()
        {
            InitializeComponent();
            ShowConsumer();
            
        }
      
        private void ShowConsumer()
        {
            // hiện dữ liệu lên datagriview
            Con.Open();
            string Query = " select *from ConsumerTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvConsumer.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
             // đặt trạng thái các ô textbox về trạng thái trống.
            txtCName.Text = "";
            txtCAdd.Text = "";
            txtCPhone.Text = "";
            cbCCategory.SelectedIndex = -1;
            txtRate.Text = "";
        }
        private void btCSave_Click(object sender, EventArgs e)
        {
            // thêm thông tin nhân viên
            if (txtCName.Text == "" || txtCAdd.Text == "" || txtCPhone.Text == "" || cbCCategory.SelectedIndex == -1)
            {
                MessageBox.Show("thông tin còn thiếu!!!");
            }
            else
            {
                try
                {
                    //string BPeriod = dtJdate.Value.Day+"/"+ dtJdate.Value.Month + "/" + dtJdate.Value.Year;
                    //dtJdate.Text = BPeriod.ToString();
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ConsumerTb(CName,CAddress,CPhone,CCategory,CJDate,CRate)values(@CN,@CA,@CP,@CC,@CJD,@CR)", Con);
                    cmd.Parameters.AddWithValue("@CN", txtCName.Text);
                    cmd.Parameters.AddWithValue("@CA", txtCAdd.Text);
                    cmd.Parameters.AddWithValue("@CP", txtCPhone.Text);
                    cmd.Parameters.AddWithValue("@CC", cbCCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CJD", dtJdate.Value.Date);
                    cmd.Parameters.AddWithValue("@CR", txtRate.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    Con.Close();
                    ShowConsumer();
                    //Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        // xác định giá tiền cho mục đích sử dụng  Category=" + cbCCategory.SelectedValue.ToString() + "
        //private void GetRate()
        //{
       
            //if (cbCCategory.SelectedIndex == 0)
            //{
            //    txtRate.Text = "70000";
            //}
            //else if (cbCCategory.SelectedIndex == 1)
            //{
            //    txtRate.Text = "85000";
            //}
            //else
            //{
            //    txtRate.Text = "120000";
            //}
        //}

        private void cbCCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //GetRate();
            //GetWaterate();
        }
        int key = 0;
        private void dgvConsumer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // load dữ liệu trên các ô khi kích vào thông tin
            txtCName.Text = dgvConsumer.CurrentRow.Cells[1].Value.ToString();
            txtCAdd.Text = dgvConsumer.CurrentRow.Cells[2].Value.ToString();
            txtCPhone.Text = dgvConsumer.CurrentRow.Cells[3].Value.ToString();
            cbCCategory.SelectedItem = dgvConsumer.CurrentRow.Cells[4].Value.ToString();
            dtJdate.Text = dgvConsumer.CurrentRow.Cells[5].Value.ToString();
            txtRate.Text = dgvConsumer.CurrentRow.Cells[6].Value.ToString();
            if (txtCName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvConsumer.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btCEdit_Click(object sender, EventArgs e)
        {
            //Sửa
            if (txtCName.Text == "" || txtCAdd.Text == "" || txtCPhone.Text == "" || cbCCategory.SelectedIndex == -1)
            {
                MessageBox.Show(" thông tin còn thiếu!!!");
            }
            else
            {
                try
                {
                    string Bperiod=dtJdate.Text;
                    //string BPeriod = dtJdate.Value.Month + "/" + dtJdate.Value.Day + "/" + dtJdate.Value.Year;
                    //dtJdate.Text = BPeriod;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update  ConsumerTb set CName=@CN,CAddress=@CA,CPhone=@CP,CCategory=@CC,CJDate=@CJD,CRate=@CR where CId=@Ckey", Con);
                    cmd.Parameters.AddWithValue("@CN", txtCName.Text);
                    cmd.Parameters.AddWithValue("@CA", txtCAdd.Text);
                    cmd.Parameters.AddWithValue("@CP", txtCPhone.Text);
                    cmd.Parameters.AddWithValue("@CC", cbCCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CJD", dtJdate.Value.Date);
                    cmd.Parameters.AddWithValue("@CR", txtRate.Text);
                    cmd.Parameters.AddWithValue("@Ckey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    Con.Close();
                    ShowConsumer();
                    //Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btCDelete_Click(object sender, EventArgs e)
        {
            // Xóa
            if (key == 0)
            {
                MessageBox.Show("Chọn khách hàng sẽ bị xóa!!! ");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from ConsumerTb where CId = @Akey ", Con);

                    cmd.Parameters.AddWithValue("@Akey", key);
                  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    Con.Close();
                    ShowConsumer();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
          
        }

        private void lbBill_Click(object sender, EventArgs e)
        {
            frmBill s = new frmBill();
            s.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            frmAdminlogin h = new frmAdminlogin();
            h.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmAdminlogin a = new frmAdminlogin();
            a.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmHome u = new frmHome();
            u.Show();
            this.Hide();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        public void ExportFile(DataTable dataTable, string sheetName,string title)
        {
            // tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel=new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // tạo mới 1 Excel workbook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name= sheetName;
            //tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times new Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment= Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã  khách hàng";
            cl1.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ và tên";
            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Địa chỉ";
            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số điện thoại";
            cl4.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Mục đích sử dụng";
            cl5.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Ngày sử dụng";
            cl6.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Giá tiền";
            cl7.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            // kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            //Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // tạo mảng theo datâtble

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count]; 
            // chuyển dữ liệu từ dataTable vào mảng đối tượng
            for(int row=0; row<dataTable.Rows.Count; row++)
            {
                DataRow dataRow= dataTable.Rows[row];
                for(int col=0; col<dataTable.Columns.Count; col++)
                {
                    arr[row,col] = dataRow[col];
                }
            }
            // thiết lập vùng điền dữ liệu
            int rowSart = 4;
            int columnSart = 1;
            int rowEnd = rowSart + dataTable.Rows.Count - 2;
            int columnEnd = dataTable.Columns.Count;
            // ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowSart, columnSart];
            // ô kết thúc điền dữ liệu;
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            // điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // căn giữa cả bảng
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


        }
        private void btExcelkh_Click(object sender, EventArgs e)
        {
          

            DataTable dataTable=new DataTable();
            DataColumn col1 = new DataColumn("CId");
            DataColumn col2 = new DataColumn("CName");
            DataColumn col3 = new DataColumn("CAddress");
            DataColumn col4 = new DataColumn("CPhone");
            DataColumn col5 = new DataColumn("CCategory");
            DataColumn col6 = new DataColumn("CJDate");
            DataColumn col7 = new DataColumn("CRate");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);             
            foreach(DataGridViewRow dtgvRow in dgvConsumer.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = dtgvRow.Cells[0].Value;
                dataRow[1] = dtgvRow.Cells[1].Value;
                dataRow[2] = dtgvRow.Cells[2].Value;
                dataRow[3] = dtgvRow.Cells[3].Value;
                dataRow[4] = dtgvRow.Cells[4].Value;
                dataRow[5] = dtgvRow.Cells[5].Value;
                dataRow[6] = dtgvRow.Cells[6].Value;
                dataTable.Rows.Add(dataRow);
            }
            ExportFile(dataTable, "Danh sach", "Danh sách khách hàng");
         

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            //reset lại các ô và xâu lên dữ liệu
            Reset();
            ShowConsumer();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }
        public bool Search_KH(string a)
        {

            if (a == "")
            {
                MessageBox.Show(" Nhập thông tin tìm kiếm");
                return false;
            }
            else
            {
                Con.Open();
                string Query = "select*from ConsumerTb where CId='" + txtCSearch.Text + "'or CPhone='" + txtCSearch.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvConsumer.DataSource = dt;
                Con.Close();
                return  true;
            }
        }
        private void ptSearchidConsumer_Click(object sender, EventArgs e)
        {
            // tìm tìm kiếm dựa trên mã kh hoặc số dt
            try
            {
                Search_KH(txtCSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Accer Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            // hiển thị thông tin khách hàng lên ô textbox
            txtCName.Text = dgvConsumer.CurrentRow.Cells[1].Value.ToString();
            txtCAdd.Text = dgvConsumer.CurrentRow.Cells[2].Value.ToString();
            txtCPhone.Text = dgvConsumer.CurrentRow.Cells[3].Value.ToString();
            cbCCategory.SelectedItem = dgvConsumer.CurrentRow.Cells[4].Value.ToString();
            dtJdate.Text = dgvConsumer.CurrentRow.Cells[5].Value.ToString();
            txtRate.Text = dgvConsumer.CurrentRow.Cells[6].Value.ToString();
            if (txtCName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvConsumer.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
