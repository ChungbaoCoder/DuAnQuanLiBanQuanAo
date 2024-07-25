using QuanLiShopQuanAo.BUS.Entities;

namespace QuanLiShopQuanAo.DAL.Interfaces
{
    public interface IProcSanPham : IQueryData
    {
        bool Insert(SanPham sanPham);
        bool Update(SanPham sanPham);
        bool Delete(SanPham sanPham);
    }
}
