using QuanLiShopQuanAo.BUS.Entities;
using System.Data;

namespace QuanLiShopQuanAo.DAL.Interfaces
{
    public interface IProcHoaDon : IQueryData
    {
        public bool Insert(HoaDon hoaDon);
        public bool Update(HoaDon hoaDon);
        public bool Delete(HoaDon hoaDon);
    }
}
