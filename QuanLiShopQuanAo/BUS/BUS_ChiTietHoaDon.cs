using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL.Interfaces;
using QuanLiShopQuanAo.DAL;
using System.Data;

namespace QuanLiShopQuanAo.BUS
{
    public class BUS_ChiTietHoaDon
    {
        public static DataTable QueryData(string command, string maHoaDon)
        {
            IProcChiTietHoaDon proc = new DAL_ChiTietHoaDon();
            switch (command)
            {
                case "data":
                    return proc.LoadChiTietHoaDon(maHoaDon);
                default:
                    return new DataTable();
            }
        }
        public static bool QueryData(ChiTietHoaDon data, string command)
        {
            IProcChiTietHoaDon proc = new DAL_ChiTietHoaDon();
            switch (command)
            {
                case "stop":
                    return proc.NgungLapHoaDon(data);
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
