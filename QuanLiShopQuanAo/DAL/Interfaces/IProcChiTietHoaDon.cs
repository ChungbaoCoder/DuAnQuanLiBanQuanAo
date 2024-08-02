using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo.DAL.Interfaces
{
    public interface IProcChiTietHoaDon
    {
        public DataTable LoadChiTietHoaDon(string maHoaDon);
        public bool NgungLapHoaDon(ChiTietHoaDon chiTietHoaDon);
        public bool Insert(ChiTietHoaDon chiTietHoaDon);
        public bool Update(ChiTietHoaDon chiTietHoaDon);
        public bool Delete(ChiTietHoaDon chiTietHoaDon);
    }
}
