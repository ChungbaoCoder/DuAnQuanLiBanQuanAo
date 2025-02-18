using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace TestProject;

[TestFixture]
public class DAL_SanPhamTests
{
    private DAL_SanPham _dal;
    private string _testConnectionString;

    [SetUp]
    public void Setup()
    {
        _testConnectionString = DBConnection.ConnectionString;
        _dal = new DAL_SanPham();
    }

    [Test]
    public void KiemTraDuLieuTraVe()
    {
        DataTable result = _dal.GetData();

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Rows.Count > 0, Is.True);
        Assert.That(result.Columns.Contains("MaSanPham"), Is.True);
    }

    [Test]
    public void KiemTraTimDuLieu()
    {
        string searchTerm = "New Test Product";

        DataTable result = _dal.Search(searchTerm);

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Rows.Count > 0, Is.True);

        foreach (DataRow row in result.Rows)
        {
            Assert.That(row["TenSanPham"].ToString().Contains(searchTerm), Is.True);
        }
    }

    [Test]
    public void KiemTraThemSanPhamMoi()
    {
        SanPham newProduct = new SanPham
        {
            TenSanPham = "New Test Product",
            LoaiSanPham = "Test Category",
            HinhAnh = "test.jpg",
            SoLuong = 10,
            Gia = 25.00f,
            MaNhaCungCap = "NCC2",
            TrangThai = "Chưa bán"
        };

        bool result = _dal.Insert(newProduct);

        Assert.That(result, Is.True);

        DataTable insertedProduct = GetProductByName("New Test Product");
        Assert.That(insertedProduct, Is.Not.Null);
        Assert.That(insertedProduct.Rows.Count > 0, Is.True);
    }

    [Test]
    public void KiemTraCapNhatSanPham()
    {
        SanPham existingProduct = new SanPham
        {
            MaSanPham = "SP4",
            TenSanPham = "Updated Test Product",
            LoaiSanPham = "Updated Category",
            HinhAnh = "updated.jpg",
            SoLuong = 20,
            Gia = 35.00f,
            MaNhaCungCap = "NCC2",
            TrangThai = "Đang bán"
        };

        bool result = _dal.Update(existingProduct);

        Assert.That(result, Is.True);

        DataTable updatedProduct = GetProductById(existingProduct.MaSanPham.ToUpper());
        Assert.That(updatedProduct, Is.Not.Null);
        Assert.That(updatedProduct.Rows.Count > 0, Is.True);
        Assert.That(updatedProduct.Rows[0]["TenSanPham"].ToString(), Is.EqualTo("Updated Test Product"));
    }


    [Test]
    public void KiemTraXoaSanPham()
    {
        SanPham productToDelete = new SanPham { MaSanPham = "SP4" };

        bool result = _dal.Delete(productToDelete);

        Assert.That(result, Is.True);

        DataTable deletedProduct = GetProductById(productToDelete.MaSanPham.ToUpper());
        Assert.That(deletedProduct, Is.Not.Null);
        Assert.That(deletedProduct.Rows.Count, Is.EqualTo(0));
    }

    private DataTable GetProductByName(string productName)
    {
        DataTable dt = new DataTable();
        using (SqlConnection conn = new SqlConnection(_testConnectionString))
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham WHERE TenSanPham = @TenSanPham", conn);
            cmd.Parameters.AddWithValue("@TenSanPham", productName);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }
        return dt;
    }

    private DataTable GetProductById(string productId)
    {
        DataTable dt = new DataTable();
        using (SqlConnection conn = new SqlConnection(_testConnectionString))
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham WHERE MaSanPham = @MaSanPham", conn);
            cmd.Parameters.AddWithValue("@MaSanPham", productId);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }
        return dt;
    }
}
