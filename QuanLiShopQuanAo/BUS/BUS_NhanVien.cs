using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL.Interfaces;
using QuanLiShopQuanAo.DAL;
using System.Data;

namespace QuanLiShopQuanAo.BUS
{
    public class BUS_NhanVien 
    {
        public static DataTable QueryData(string command, string? search = null)
        {
            IProcNhanVien proc = new DAL_NhanVien();
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
        public static bool QueryData(NhanVien data, string command)
        {
            IProcNhanVien proc = new DAL_NhanVien();
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
