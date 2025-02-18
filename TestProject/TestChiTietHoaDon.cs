using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace TestProject;

[TestFixture]
public class DAL_ChiTietHoaDonTests
{
    private DAL_ChiTietHoaDon _dal;
    private string _testConnectionString;

    [SetUp]
    public void Setup()
    {
        _testConnectionString = DBConnection.ConnectionString;
        _dal = new DAL_ChiTietHoaDon();
    }

    [Test]
    public void KiemTraDuLieuTraVe()
    {
        string maHoaDon = "HD1";

        DataTable result = _dal.LoadChiTietHoaDon(maHoaDon);

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Rows.Count >= 0, Is.True);
        Assert.That(result.Columns.Contains("MaHoaDon"), Is.True);
    }

    [Test]
    public void KiemTraThemChiTietHoaDonMoi()
    {
        ChiTietHoaDon newChiTietHoaDon = new ChiTietHoaDon
        {
            MaHoaDon = "HD2",
            MaKhachHang = "KH2",
            MaSanPham = "SP1",
            SoLuong = 2
        };

        bool result = _dal.Insert(newChiTietHoaDon);

        Assert.That(result, Is.True);
    }

    [Test]
    public void KiemTraNgungLapHoaDon()
    {
        ChiTietHoaDon stopItem = new ChiTietHoaDon
        {
            MaHoaDon = "HD2",
            MaSanPham = "SP3",
            SoLuong = 1
        };

        bool result = _dal.NgungLapHoaDon(stopItem);

        Assert.That(result, Is.True);
    }

    [Test]
    public void KiemTraCapNhatChiTietHoaDon()
    {
        ChiTietHoaDon updatedChiTietHoaDon = new ChiTietHoaDon
        {
            MaHoaDon = "HD4",
            MaKhachHang = "KH6",
            TongThanhTien = 1000.0f
        };

        bool result = _dal.Update(updatedChiTietHoaDon);

        Assert.That(result, Is.True);
    }

    [Test]
    public void KiemTraXoaChiTietHoaDon()
    {
        ChiTietHoaDon itemToDelete = new ChiTietHoaDon
        {
            MaHoaDon = "HD2",
            MaSanPham = "SP2",
            SoLuong = 1
        };

        bool result = _dal.Delete(itemToDelete);

        Assert.That(result, Is.True);
    }
}
