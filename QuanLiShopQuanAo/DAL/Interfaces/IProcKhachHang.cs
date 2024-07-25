using QuanLiShopQuanAo.BUS.Entities;

namespace QuanLiShopQuanAo.DAL.Interfaces
{
    public interface IProcKhachHang : IQueryData
    {
        public bool Insert(KhachHang khachHang);
        public bool Update(KhachHang khachHang);
        public bool Delete(KhachHang khachHang);
    }
}
