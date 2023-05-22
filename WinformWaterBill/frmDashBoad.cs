using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformWaterBill
{
    public partial class frmDashBoad : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A45UN95\SQLEXPRESS;Initial Catalog=WDCS;Integrated Security=True");
        public frmDashBoad()
        {
            InitializeComponent();
            SumAgent();
            SumConsumer();
            Sumbill();
            ShowBill();
            Sumcomsuption();




        }
        private void ShowBill()
        {
            // show danh sách thanh toán lên bảng datagriview
            Con.Open();
            string Query = " select *from BillTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvDashBoad.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SumAgent()
        {
            // thống kê số lượng nhân viên
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from AgentTb", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbNAgent.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void SumConsumer()
        {
            // tổng số khách hàng 
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ConsumerTb", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbNCons.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Sumbill()
        {
            // tổng tiền thanh toán 
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Total) from BillTb", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbMToatal.Text = dt.Rows[0][0].ToString() + "\t" + "đ";
            Con.Close();
        }
        private void Sumcomsuption()
        {
            // tính tổng số khối nước đã tiêu thụ 
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Comsuption) from BillTb", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbsokhoinuoc.Text = dt.Rows[0][0].ToString() ;
            Con.Close();
        }
        private void Sumbillmonth()
        {
            // tính tổng số tiền theo ngày tìm kiếm
            Con.Open();
          
            string Query = "select Sum(Total) from BillTb where  BPeriod='" + dtSearchDate.Value.Date + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbMoneymonth.Text = dt.Rows[0][0].ToString() + "\t" + "đ";
            Con.Close();
        }
       
        private void Sumwatedate()
        {
            // tính tổng số khối nước hoặc số khối nước theo ngày tìm kiếm
            
            Con.Open();
            string Query = "select Sum(Comsuption) from BillTb where  BPeriod='" + dtSearchDate.Value.Date + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbsokhoinuoc.Text = dt.Rows[0][0].ToString() ;
            Con.Close();
        }
        private void CountConsDate()
        {
            // tính số  khách hàng hoặc hiện thị lượng khách hàng theo ngày tìm kiếm
            Con.Open();
           
            string Query = "select Count(CId) from BillTb where BPeriod='" + dtSearchDate.Value.Date + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbNCons.Text = dt.Rows[0][0].ToString();
            Con.Close();



        }
        
        private void lbSearchDB_Click(object sender, EventArgs e)
        {
            
        }

        private void lbSearchDate_Click(object sender, EventArgs e)
        {
           
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            // tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
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
            oSheet.Name = sheetName;
            //tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times new Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã  hóa đơn";
            cl1.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã khách hàng";
            cl2.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Tên khách hàng";
            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = " Tên nhân viên";
            cl4.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = " Ngày thanh toán";
            cl5.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Số khối sử dụng(dm^3)";
            cl6.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Giá tiền";
            cl7.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Thuế";
            cl8.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Tổng tiền";
            cl9.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "I3");
            rowHead.Font.Bold = true;
            // kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            //Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // tạo mảng theo datâtble

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            // chuyển dữ liệu từ dataTable vào mảng đối tượng
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
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
        private void btExcel_Click(object sender, EventArgs e)
        {
           

            DataTable dataTable = new DataTable();
            DataColumn col1 = new DataColumn("BNum");
            DataColumn col2 = new DataColumn("CId");
            DataColumn col3 = new DataColumn("CName");
            DataColumn col4 = new DataColumn("AgName");
            DataColumn col5 = new DataColumn("BPeriod");
            DataColumn col6 = new DataColumn("Comsuption");
            DataColumn col7 = new DataColumn("Rate");
            DataColumn col8 = new DataColumn("Tax");
            DataColumn col9 = new DataColumn("Total");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);

            foreach (DataGridViewRow dtgvRow in dgvDashBoad.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = dtgvRow.Cells[0].Value;
                dataRow[1] = dtgvRow.Cells[1].Value;
                dataRow[2] = dtgvRow.Cells[2].Value;
                dataRow[3] = dtgvRow.Cells[3].Value;
                dataRow[4] = dtgvRow.Cells[4].Value;
                dataRow[5] = dtgvRow.Cells[5].Value;
                dataRow[6] = dtgvRow.Cells[6].Value;
                dataRow[7] = dtgvRow.Cells[7].Value;
                dataRow[8] = dtgvRow.Cells[8].Value;

                dataTable.Rows.Add(dataRow);
            }
            ExportFile(dataTable, "Danh sach", "Danh sách thanh toán tiền nước");


        }

        private void lbBill_Click(object sender, EventArgs e)
        {
            frmBill g = new frmBill();
            g.Show();
            this.Hide();
        }

        private void lbConsumer_Click(object sender, EventArgs e)
        {
            frmConsumer ca = new frmConsumer();
            ca.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
           frmAgent g = new frmAgent();
            g.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmHome t = new frmHome();
            t.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbExitdb_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void ptSearchdate_Click(object sender, EventArgs e)
        {
            CountConsDate();
            Sumbillmonth();
            Sumwatedate();

            try
            {
                Con.Open();
                string Query = "select* from BillTb where  BPeriod='" + dtSearchDate.Value.Date + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvDashBoad.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Accer Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ptSearchidbill_Click(object sender, EventArgs e)
        {
            
        }

        private void ptExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            // xóa dựa trên ngày tìm kiếm
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Delete from BillTb where  BPeriod='" + dtSearchDate.Value.Date + "'  ", Con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            // làm mới
            ShowBill();
            SumAgent();
            SumConsumer();
            Sumbill();
            ShowBill();
            Sumcomsuption();
          


        }

        private void DashBoad_Load(object sender, EventArgs e)
        {

        }

        private void lbNCons_Click(object sender, EventArgs e)
        {

        }
    }
}
