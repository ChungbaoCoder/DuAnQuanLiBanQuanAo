using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL;
using QuanLiShopQuanAo.DAL.Interfaces;
using System.Data;

namespace QuanLiShopQuanAo.BUS
{
    public class BUS_KhachHang
    {
        public static DataTable QueryData(string command, string? search = null)
        {
            IProcKhachHang proc = new DAL_KhachHang();
            switch (command)
            {
                case "data":
                    return proc.GetData();
                case "search":
                    return proc.Search(search);
                default:
                    return new DataTable();
            }
        }
        public static bool QueryData(KhachHang data, string command)
        {
            IProcKhachHang proc = new DAL_KhachHang();
            switch (command)
            {
                case "insert":
                    return proc.Insert(data);
                case "update":
                    return proc.Update(data);
                case "delete":
                    return proc.Delete(data);
                default:
                    return false;
            }    
        }
    }
}
