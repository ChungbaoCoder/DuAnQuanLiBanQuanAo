using System.Data;

namespace QuanLiShopQuanAo.DAL.Interfaces
{
    public interface IQueryData
    {
        public DataTable GetData();
        public DataTable Search(string query);
    }
}
