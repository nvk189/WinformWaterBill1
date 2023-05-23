using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using WinformWaterBill;
//using NUnit.Framework;


namespace Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void tinhtien_1()
        {
            frmBill bill = new frmBill();
            int kqmd, kqtt;
            kqmd = 105000;
            kqtt=bill.TinhTongTien(0, 0, 0); // nhập tất cả bằng 0
            Assert.AreEqual(kqmd, kqtt);
        }


        [TestMethod]
        public void tinhtien_2()
        {
            frmBill bill = new frmBill();
            int kqmd, kqtt;
            kqmd = 105000;
            kqtt = bill.TinhTongTien(0, 100000, 100000); // nhập số  1 số =0
            Assert.AreEqual(kqmd, kqtt);
        }


        [TestMethod]
        public void tinhtien_3()
        {
            frmBill bill = new frmBill();
            int kqmd, kqtt;
            kqmd = 105000;
            kqtt = bill.TinhTongTien(-5, 100000, 100000); // nhập số âm
            Assert.AreEqual(kqmd, kqtt);
        }


        [TestMethod]
        public void tinhtien_4()
        {
            frmBill bill = new frmBill();
            int kqmd, kqtt;
            kqmd = 105000;
            kqtt = bill.TinhTongTien(5, 100000, 100000); // nhập đúng
            Assert.AreEqual(kqmd, kqtt);
        }



        [TestMethod]
        public void Password_0()
        {
            frmAdminlogin  admin=new frmAdminlogin();
            
            Assert.IsTrue(admin.ValidatePassword("")); // để trống trường mật khẩu
           

        }
        [TestMethod]
        public void Password_1()
        {
            frmAdminlogin admin = new frmAdminlogin();

           
            Assert.IsTrue(admin.ValidatePassword("ádfg")); // nhập sai mật khẩu
           

        }
        [TestMethod]
        public void Password_2()
        {
            frmAdminlogin admin = new frmAdminlogin();
            Assert.IsTrue(admin.ValidatePassword("Admin")); // nhập đúng mật khẩu

        }


        //
        [TestMethod]
        public void Search_NhanVien1()
        {
           frmAgent agent = new frmAgent();
            Assert.IsTrue(agent.Search_NV("")); //  để trống ô tìm kiếm

        }

        //
        [TestMethod]
        public void Search_NhanVien2()
        {
            frmAgent agent = new frmAgent();
            Assert.IsTrue(agent.Search_NV("123455556")); // nhập tìm kiếm 

        }


        [TestMethod]
        public void Search_KhachHang1()
        {
            frmConsumer frms=new frmConsumer();
            Assert.IsTrue(frms.Search_KH("")); //  để trống ô tìm kiếm

        }

        //
        [TestMethod]
        public void Search_KhachHang2()
        {
            frmConsumer frms = new frmConsumer();
            Assert.IsTrue(frms.Search_KH("17")); // nhập tìm kiếm 

        }

        [TestMethod]
        public void login1()
        {
            frmLogin login = new frmLogin();
            Assert.IsTrue(login.dangnnhap_test("","")); // nhập trống tất cả 

        }


        [TestMethod]
        public void login2()
        {
            frmLogin login = new frmLogin();
            Assert.IsTrue(login.dangnnhap_test("", "12345")); // nhập tìm kiếm 

        }


        [TestMethod]
        public void login3()
        {
            frmLogin login = new frmLogin();
            Assert.IsTrue(login.dangnnhap_test("long", "123456")); //  sai tài khoản hoặc mật khẩu

        }

        [TestMethod]
        public void login4()
        {
            frmLogin login = new frmLogin();
            Assert.IsTrue(login.dangnnhap_test("NguyenVanKhoa", "1234")); //  sai tài khoản hoặc mật khẩu

        }

    }
}
