using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL;
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
        public void Insert_ShouldReturnTrue_WhenInsertionIsSuccessful()
        {
            // Arrange
            var nhaCungCap = new NhaCungCap
            {
                TenNhaCungCap = "XYZ Supplier",
                SDT = "1234567890",
                DiaChi = "123 XYZ Street"
            };

            // Act
            var result = _dal.Insert(nhaCungCap);

            // Assert
            Assert.IsTrue(result); 
        }

        [Test]
        public void Insert_ShouldReturnFalse_WhenRequiredFieldIsMissing()
        {
            // Arrange
            var nhaCungCap = new NhaCungCap
            {
                TenNhaCungCap = null, 
                SDT = "1234567890",
                DiaChi = "123 XYZ Street"
            };

            // Act
            var result = _dal.Insert(nhaCungCap);

            // Assert
            Assert.IsFalse(result); 
        }
        [Test]
        public void Update_ShouldReturnTrue_WhenUpdateIsSuccessful()
        {
            // Arrange
            var updatedSupplier = new NhaCungCap
            {
                MaNhaCungCap = "NCC2", // Existing MaNCC
                TenNhaCungCap = "Updated Supplier",
                SDT = "9876543210",
                DiaChi = "Updated Address"
            };

            // Act
            var result = _dal.Update(updatedSupplier);

            // Assert
            Assert.IsTrue(result); 
        }

        [Test]
        public void Update_ShouldReturnFalse_WhenUpdateFails()
        {
            var updatedSupplier = new NhaCungCap
            {
                MaNhaCungCap = null, 
                TenNhaCungCap = "Updated Supplier",
                SDT = "9876543210",
                DiaChi = "Updated Address"
            };

            var result = _dal.Update(updatedSupplier);

            Assert.IsFalse(result); 
        }
        [Test]
        public void Delete_ShouldReturnTrue_WhenDeletionIsSuccessful()
        {
            var nhaCungCap = new NhaCungCap
            {
                MaNhaCungCap = "NCC5", 
                SDT = "1234567890"
            };

            // Act
            var result = _dal.Delete(nhaCungCap);

            // Assert
            Assert.IsTrue(result); 
        }

        [Test]
        public void Delete_ShouldReturnFalse_WhenSupplierDoesNotExist()
        {
            // Arrange
            var nhaCungCap = new NhaCungCap
            {
                MaNhaCungCap = "NonExistent", 
                SDT = "0000000000"
            };

            // Act
            var result = _dal.Delete(nhaCungCap);

            // Assert
            Assert.IsFalse(result); 
        }

    }
}
