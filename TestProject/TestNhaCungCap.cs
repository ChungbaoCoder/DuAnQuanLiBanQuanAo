using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL.Interfaces;
using QuanLiShopQuanAo.DAL;
using System.Data;
using QuanLiShopQuanAo.DataBaseConnection;

namespace TestProject
{
    [TestFixture]
    public class DAL_NhaCungCapTests
    {
        private DAL_NhaCungCap _dal;
        private string _testConnectionString;

        [SetUp]
        public void Setup()
        {
            _testConnectionString = DBConnection.ConnectionString;
            _dal = new DAL_NhaCungCap();
        }

        [Test]
        public void KiemTraDuLieuTraVe()
        {
            DataTable result = _dal.GetData();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count > 0, Is.True);
            Assert.That(result.Columns.Contains("MaNhaCungCap"), Is.True);
        }

        [Test]
        public void KiemTimDuLieu()
        {
            string searchTerm = "Test";

            DataTable result = _dal.Search(searchTerm);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Rows.Count > 0, Is.True);
            Assert.That(result.Rows[0]["TenNhaCungCap"].ToString().Contains(searchTerm), Is.True);
        }

        [Test]
        public void KiemTraThemNhaCungCapMoi()
        {
            NhaCungCap newSupplier = new NhaCungCap
            {
                TenNhaCungCap = "New Supplier",
                SDT = "555-123-4567",
                DiaChi = "New Address"
            };

            bool result = _dal.Insert(newSupplier);

            Assert.That(result, Is.True);

            using (SqlConnection conn = new SqlConnection(_testConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap WHERE TenNhaCungCap = @TenNhaCungCap", conn);
                cmd.Parameters.AddWithValue("@TenNhaCungCap", "New Supplier");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Assert.That(reader.HasRows, Is.True);
                }
            }
        }

        [Test]
        public void KiemTraCapNhatNhaCungCap()
        {
            NhaCungCap updatedSupplier = new NhaCungCap
            {
                MaNhaCungCap = "NCC2",
                TenNhaCungCap = "Updated Supplier",
                SDT = "555-987-6543",
                DiaChi = "Updated Address"
            };

            bool result = _dal.Update(updatedSupplier);

            Assert.That(result, Is.True);

            using (SqlConnection conn = new SqlConnection(_testConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap WHERE MaNhaCungCap = " + updatedSupplier.MaNhaCungCap.ToUpper(), conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Assert.That(reader.HasRows, Is.True);
                    reader.Read();
                    Assert.That(reader["TenNhaCungCap"], Is.EqualTo("Updated Supplier"));
                }
            }
        }

        [Test]
        public void KiemTraXoaNhaCungCap()
        {
            // Assuming there's a supplier with MaNhaCungCap = 1 in your test data
            NhaCungCap supplierToDelete = new NhaCungCap { MaNhaCungCap = "NCC3" };

            bool result = _dal.Delete(supplierToDelete);

            Assert.That(result, Is.True);

            using (SqlConnection conn = new SqlConnection(_testConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap WHERE MaNhaCungCap = " + supplierToDelete.MaNhaCungCap.ToUpper(), conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Assert.That(reader.HasRows, Is.False);
                }
            }
        }
    }
}
