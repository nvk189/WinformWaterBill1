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
    public partial class frmAgent : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A45UN95\SQLEXPRESS;Initial Catalog=WDCS;Integrated Security=True");
        public frmAgent()
        {
            InitializeComponent();
            ShowAgent();
        }
        private void ShowAgent()
        {
            // đưa dữ liệu lên bảng datagriview
            Con.Open();
            string Query = " select *from AgentTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvAgent.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {// đặt lại trạng thái các ô textbox là trống
            txtAgName.Text = "";
            txtAgPhone.Text = "";
            txtAgAdd.Text = "";
            txtAgPass.Text = "";
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            //  thêm thông tin nhân viên

            if ( txtAgName.Text== "" || txtAgAdd.Text == "" || txtAgPhone.Text == "" || txtAgPass.Text == "")
            {
                MessageBox.Show("Điền đầy thông tin !!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AgentTb(AgName,AgPhone,AgAddress,AgPass)values(@AN,@AP,@AA,@APS)", Con);
                    cmd.Parameters.AddWithValue("@AN", txtAgName.Text);
                    cmd.Parameters.AddWithValue("@AP", txtAgPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", txtAgAdd.Text);
                    cmd.Parameters.AddWithValue("@APS", txtAgPass.Text);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    Con.Close();
                    ShowAgent();
                    //Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void dgvAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // kích  để hiện thông tin từ datagriview lên các ô textbox
            txtAgName.Text = dgvAgent.CurrentRow.Cells[1].Value.ToString();
            txtAgPhone.Text = dgvAgent.CurrentRow.Cells[2].Value.ToString();
            txtAgAdd.Text = dgvAgent.CurrentRow.Cells[3].Value.ToString();
            txtAgPass.Text = dgvAgent.CurrentRow.Cells[4].Value.ToString();

            if (txtAgName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvAgent.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            // sửa thông tin nhân viên
            if (txtAgName.Text == "" || txtAgAdd.Text == "" || txtAgPhone.Text == "" || txtAgPass.Text == "")
            {
                MessageBox.Show("Điền đầy thông tin!!!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("update  AgentTb set AgName=@AN,AgPhone=@AP,AgAddress=@AA,AgPass=@APS where AgNum=@Akey", Con);
                    cmd.Parameters.AddWithValue("@AN", txtAgName.Text);                 
                    cmd.Parameters.AddWithValue("@AP", txtAgPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", txtAgAdd.Text);
                    cmd.Parameters.AddWithValue("@APS", txtAgPass.Text);
                    cmd.Parameters.AddWithValue("@Akey",key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    Con.Close();
                    ShowAgent();
                    //Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // xóa thông tin nhân viên
            if (key == 0)
            {
                MessageBox.Show("Chọn nhân viên sex được xóa!!! ");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from AgentTb where AgNum=@Akey", Con);

                    cmd.Parameters.AddWithValue("@Akey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    Con.Close();
                    ShowAgent();
                    //Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void lbConsumer_Click(object sender, EventArgs e)
        {
            frmConsumer ct = new frmConsumer();
            ct.Show();
            this.Hide();
        }

        private void lbBill_Click(object sender, EventArgs e)
        {
            frmBill c = new frmBill();
            c.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            frmDashBoad  dh =new frmDashBoad();
            dh.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmHome an = new frmHome();
            an.Show();
            this.Hide();
        }

        private void lbExita_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Reset();
            ShowAgent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool Search_NV(string a)
        {
           
            if (a == "")
            {
                MessageBox.Show(" Nhập thông tin tìm kiếm");
                return false;
            }
            else
            {
                Con.Open();
                string Query = "select*from AgentTb where AgNum='" + a + "'or AgPhone='" + a +"' ";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvAgent.DataSource = dt;
                Con.Close();
                return true;
            }
        }
        private void ptSearchAg_Click(object sender, EventArgs e)
        {
            // tìm kiếm nhân viên thông qua mã nhân viên hoặc số điện thoại
             Search_NV(txtAgSearch.Text);
            // hiển thị thông tin nhân viên lên textbox khi tìm kiếm
            txtAgName.Text = dgvAgent.CurrentRow.Cells[1].Value.ToString();
            txtAgPhone.Text = dgvAgent.CurrentRow.Cells[2].Value.ToString();
            txtAgAdd.Text = dgvAgent.CurrentRow.Cells[3].Value.ToString();
            txtAgPass.Text = dgvAgent.CurrentRow.Cells[4].Value.ToString();

            if (txtAgName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvAgent.CurrentRow.Cells[0].Value.ToString());
            }
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
            cl1.Value2 = "Mã  nhân viên";
            cl1.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ và tên";
            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Số điện thoại";
            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Địa chỉ";
            cl4.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Mật khẩu";
            cl5.ColumnWidth = 25.0;

          

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");
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

        private void btExcelnv_Click(object sender, EventArgs e)
        {
            

            DataTable dataTable = new DataTable();
            DataColumn col1 = new DataColumn("AgNum");
            DataColumn col2 = new DataColumn("AgName");
            DataColumn col3 = new DataColumn("AgPhone");
            DataColumn col4 = new DataColumn("AgAddress");
            DataColumn col5 = new DataColumn("AgPass");
          

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            

            foreach (DataGridViewRow dtgvRow in dgvAgent.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = dtgvRow.Cells[0].Value;
                dataRow[1] = dtgvRow.Cells[1].Value;
                dataRow[2] = dtgvRow.Cells[2].Value;
                dataRow[3] = dtgvRow.Cells[3].Value;
                dataRow[4] = dtgvRow.Cells[4].Value;
                dataTable.Rows.Add(dataRow);
            }
            ExportFile(dataTable, "Danh sach", "Danh sách nhân viên");
        }
    }
}
