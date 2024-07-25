using QuanLiShopQuanAo.BUS.Entities;

namespace QuanLiShopQuanAo.DAL.Interfaces
{
    public interface IProcNhanVien : IQueryData
    {
        bool Insert(NhanVien nhanVien);
        bool Update(NhanVien nhanVien);
        bool Delete(NhanVien nhanVien);
    }
}
