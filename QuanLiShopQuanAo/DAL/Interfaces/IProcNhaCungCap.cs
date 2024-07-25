using QuanLiShopQuanAo.BUS.Entities;

namespace QuanLiShopQuanAo.DAL.Interfaces
{
    public interface IProcNhaCungCap : IQueryData
    {
        bool Insert(NhaCungCap nhaCungCap);
        bool Update(NhaCungCap nhaCungCap);
        bool Delete(NhaCungCap nhaCungCap);
    }
}
