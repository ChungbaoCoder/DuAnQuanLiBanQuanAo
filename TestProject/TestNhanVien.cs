using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace TestProject;

[TestFixture]
public class DAL_NhanVienTests
{
    private DAL_NhanVien _dal;
    private string _testConnectionString;

    [SetUp]
    public void Setup()
    {
        _dal = new DAL_NhanVien();
        _testConnectionString = DBConnection.ConnectionString;
    }

    [Test]
    public void KiemTraDuLieuTraVe()
    {
        DataTable result = _dal.GetData();

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Rows.Count > 0);
        Assert.That(result.Columns.Contains("MaNhanVien"));
    }

    [Test]
    public void KiemTraTimDuLieu()
    {
        string searchTerm = "Test Employee";

        DataTable result = _dal.Search(searchTerm);

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Rows.Count > 0);
        Assert.That(result.Rows[0]["TenNhanVien"].ToString().Contains(searchTerm));
    }

    [Test]
    public void KiemTraThemNhanVienMoi()
    {
        NhanVien newNhanVien = new NhanVien
        {
            TenNhanVien = "Test Employee",
            ChucVu = "Tester",
            Luong = 50000,
            Email = "test@example.com",
            HinhAnh = "anh.jpg",
            TrangThai = "Đang đi làm",
            MatKhau = "3782"

        };

        bool result = _dal.Insert(newNhanVien);

        Assert.That(result);
    }

    [Test]
    public void KiemTraCapNhatNhanVien()
    {
        NhanVien updatedEmployee = new NhanVien
        {
            MaNhanVien = "NV4",
            TenNhanVien = "Updated Employee",
            ChucVu = "Senior Developer",
            Luong = 90000,
            Email = "updated@example.com",
            HinhAnh = "updated.jpg",
            TrangThai = "Chưa đi làm"
        };

        bool result = _dal.Update(updatedEmployee);

        Assert.IsTrue(result);
    }

    [Test]
    public void KiemTraXoaNhanVien()
    {
        NhanVien employeeToDelete = new NhanVien { MaNhanVien = "NV4" };

        bool result = _dal.Delete(employeeToDelete);

        Assert.That(result);
    }
}