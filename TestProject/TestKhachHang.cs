using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace TestProject
{
    [TestFixture]
    public class DAL_KhachHangTests
    {
        private DAL_KhachHang _dal;
        private string _testConnectionString;

        [SetUp]
        public void Setup()
        {
            _testConnectionString = DBConnection.ConnectionString;
            _dal = new DAL_KhachHang();
        }

        [Test]
        public void KiemTraDuLieuTraVe()
        {
            DataTable result = _dal.GetData();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count > 0, Is.True);
            Assert.That(result.Columns.Contains("MaKhachHang"), Is.True);
        }

        [Test]
        public void KiemTraTimDuLieu()
        {
            // tim kiem theo ten khach hang
            string searchTerm = "Updated Customer";

            DataTable result = _dal.Search(searchTerm);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count > 0, Is.True);
            Assert.That(result.Rows[0]["TenKhachHang"].ToString().Contains(searchTerm), Is.True);
        }

        [Test]
        public void KiemTraThemKhachHangMoi()
        {
            KhachHang newCustomer = new KhachHang
            {
                TenKhachHang = "Customer",
                SDT = "123-123-456789",
                DiaChi = "New Address"
            };

            bool result = _dal.Insert(newCustomer);

            Assert.That(result, Is.True);

            using (SqlConnection conn = new SqlConnection(_testConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE TenKhachHang = @TenKhachHang", conn);
                cmd.Parameters.AddWithValue("@TenKhachHang", newCustomer.TenKhachHang);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Assert.That(reader.HasRows, Is.True);
                }
            }
        }

        [Test]
        public void KiemTraCapNhatKhachHang()
        {
            KhachHang updatedCustomer = new KhachHang
            {
                MaKhachHang = "KH2",
                TenKhachHang = "Updated Customer",
                SDT = "555-987-6543",
                DiaChi = "Updated Address"
            };

            bool result = _dal.Update(updatedCustomer);

            Assert.That(result, Is.True);

            using (SqlConnection conn = new SqlConnection(_testConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM KhachHang WHERE MaKhachHang = @MaKhachHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhachHang", updatedCustomer.MaKhachHang.ToUpper());
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Assert.That(reader.HasRows, Is.True);
                    reader.Read();
                    Assert.That(reader["TenKhachHang"], Is.EqualTo("Updated Customer"));
                }
            }
        }

        [Test]
        public void KiemTraXoaKhachHang()
        {
            KhachHang customerToDelete = new KhachHang
            {
                MaKhachHang = "KH4",
                SDT = "1234567890"
            };

            bool result = _dal.Delete(customerToDelete);

            if (result)
            {
                Console.WriteLine("Customer deleted successfully.");
            }
            else
            {
                Console.WriteLine("Failed to delete the customer.");
            }

            using (SqlConnection conn = new SqlConnection(_testConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE MaKhachHang = @MaKhachHang AND SDT = @SDT", conn);
                cmd.Parameters.AddWithValue("@MaKhachHang", customerToDelete.MaKhachHang.ToUpper());
                cmd.Parameters.AddWithValue("@SDT", customerToDelete.SDT);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    Assert.That(reader.HasRows, Is.False);
                }
            }
        }


    }
}
