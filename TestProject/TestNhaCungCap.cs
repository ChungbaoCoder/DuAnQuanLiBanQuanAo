using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL;
using System.Data;
using QuanLiShopQuanAo.DataBaseConnection;

namespace TestProject;

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
        Assert.That(result.Columns.Contains("MaNCC"), Is.True);
    }

    [Test]
    public void KiemTraTimDuLieu()
    {
        string searchTerm = "New Supplier";

        DataTable result = _dal.Search(searchTerm);

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Rows.Count > 0, Is.True);
        Assert.That(result.Rows[0]["TenNCC"].ToString().Contains(searchTerm), Is.True);
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
    }

    [Test]
    public void KiemTraXoaNhaCungCap()
    {
        // Assuming there's a supplier with MaNhaCungCap = 1 in your test data
        NhaCungCap supplierToDelete = new NhaCungCap { MaNhaCungCap = "NCC6", SDT = "555-123-4567" };

        bool result = _dal.Delete(supplierToDelete);

        Assert.That(result, Is.True);
    }
}
