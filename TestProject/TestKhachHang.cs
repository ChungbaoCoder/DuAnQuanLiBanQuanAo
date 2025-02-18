using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace TestProject;

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
        string searchTerm = "New Customer";

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
            TenKhachHang = "New Customer",
            SDT = "555-123-4567",
            DiaChi = "New Address"
        };

        bool result = _dal.Insert(newCustomer);

        Assert.That(result, Is.True);
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
    }

    [Test]
    public void KiemTraXoaKhachHang()
    {
        KhachHang customerToDelete = new KhachHang { MaKhachHang = "KH7", SDT= "555-123-4567" };

        bool result = _dal.Delete(customerToDelete);

        Assert.That(result, Is.True);
    }
}
