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
                TenNhaCungCap = "ABC",
                SDT = "1234567890",
                DiaChi = "dgh"
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
                TenNhaCungCap ="hg", 
                SDT = "1234jh",
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
                MaNhaCungCap = "NCC18", 
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
            // Arrange
            var updatedSupplier = new NhaCungCap
            {
                MaNhaCungCap = "NCC2", 
                TenNhaCungCap = "Updated Supplier",
                SDT = "98765kj210",
                DiaChi = "Updated Address"
            };

            // Act
            var result = _dal.Update(updatedSupplier);

            // Assert
            Assert.IsFalse(result); // Ensure that update fails due to invalid MaNCC
        }
        [Test]
        public void Delete_ShouldReturnTrue_WhenDeletionIsSuccessful()
        {
            // Arrange
            var nhaCungCap = new NhaCungCap
            {
                MaNhaCungCap = "NCC4", // Ensure this exists in the DB
                SDT = "1234567890"
            };

            // Act
            var result = _dal.Delete(nhaCungCap);

            // Assert
            Assert.IsTrue(result); // Ensure that deletion returns true
        }

    }
}
