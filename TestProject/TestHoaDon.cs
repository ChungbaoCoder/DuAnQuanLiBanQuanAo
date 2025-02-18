using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace TestProject;

[TestFixture]
public class DAL_HoaDonTests
{
    private DAL_HoaDon _dal;
    private string _testConnectionString;

    [SetUp]
    public void Setup()
    {
        _testConnectionString = DBConnection.ConnectionString;
        _dal = new DAL_HoaDon();
    }

    [Test]
    public void KiemTraDuLieuTraVe()
    {
        DataTable result = _dal.GetData();

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Rows.Count >= 0, Is.True);
        Assert.That(result.Columns.Contains("MaHoaDon"), Is.True);
    }

    [Test]
    public void KiemTraTimDuLieu()
    {
        string searchTerm = "Test";

        DataTable result = _dal.Search(searchTerm);

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Rows.Count >= 0, Is.True);
    }

    [Test]
    public void KiemTraThemHoaDonMoi()
    {
        HoaDon newHoaDon = new HoaDon
        {
            TenKhachHang = "Test KhachHang",
            SDTKhach = "123-456-7890",
            NgayTao = DateTime.Now.ToString(),
            MaNhanVienGhi = "NV1"
        };

        bool result = _dal.Insert(newHoaDon);

        Assert.That(result, Is.True);
    }

    [Test]
    public void KiemTraCapNhatHoaDon()
    {
        HoaDon updatedHoaDon = new HoaDon
        {
            MaHoaDon = "HD1",
            MaKhachHang = "KH3",
            TenKhachHang = "Updated Test",
            NgayTao = DateTime.Now.ToString(),
            TrangThai = "Chưa thanh toán"
        };

        bool result = _dal.Update(updatedHoaDon);

        Assert.That(result, Is.True);
    }

    [Test]
    public void KiemTraXoaHoaDon()
    {
        HoaDon hoaDonToDelete = new HoaDon { MaHoaDon = "HD1", MaKhachHang = "KH3" };

        bool result = _dal.Delete(hoaDonToDelete);

        Assert.That(result, Is.True);
    }
}
