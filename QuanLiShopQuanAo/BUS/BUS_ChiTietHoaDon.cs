using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL.Interfaces;
using QuanLiShopQuanAo.DAL;
using System.Data;

namespace QuanLiShopQuanAo.BUS
{
    public class BUS_ChiTietHoaDon
    {
        public static DataTable QueryData(string command, string maKhachHang)
        {
            IProcChiTietHoaDon proc = new DAL_ChiTietHoaDon();
            switch (command)
            {
                case "data":
                    return proc.LoadChiTietHoaDon(maKhachHang);
                default:
                    return new DataTable();
            }
        }
        public static bool QueryData(ChiTietHoaDon data, string command)
        {
            IProcChiTietHoaDon proc = new DAL_ChiTietHoaDon();
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
