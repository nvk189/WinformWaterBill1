using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace UnitTestNhanVien
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            public SqlConnection _connection;
        }
        [TestMethod]
        public void Setup()
        {
        // Thiết lập kết nối với cơ sở dữ liệu test
        _connection = new SqlConnection(@"Data Source=DESKTOP-A45UN95\SQLEXPRESS;Initial Catalog=WDCS;Integrated Security=True");
            _connection.Open();
        }

        [TestMethod]
        public void Cleanup()
        {
            // Đóng kết nối sau khi hoàn thành unit test
            _connection.Close();
        }

        [TestMethod]
        public void TestSaveButton_Click_WithValidData_ShouldInsertAgent()
        {
            // Arrange
            SqlCommand cmd = new SqlCommand("insert into AgentTb(AgName, AgPhone, AgAddress, AgPass) values('John Doe', '123456789', '123 Main St', 'password')", _connection);

            // Act
            int rowsAffected = cmd.ExecuteNonQuery();

            // Assert
            Assert.AreEqual(1, rowsAffected, "Expected to insert 1 row into AgentTb");
        }

        [TestMethod]
        public void TestSaveButton_Click_WithMissingData_ShouldShowErrorMessage()
        {
            // Arrange
            string expectedErrorMessage = "Điền đầy thông tin !!!";
            SqlCommand cmd = new SqlCommand("insert into AgentTb(AgName, AgPhone, AgAddress, AgPass) values('', '', '', '')", _connection);

            // Act
            string actualErrorMessage = string.Empty;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                actualErrorMessage = ex.Message;
            }

            // Assert
            Assert.AreEqual(expectedErrorMessage, actualErrorMessage, "Expected error message to be shown");
        }
    }
   
}


