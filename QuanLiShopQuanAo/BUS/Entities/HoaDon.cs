using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace QuanLiShopQuanAo.BUS.Entities
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; }
        public string TenKhachHang { get; set; }
        public string SDTKhach { get; set; }
        public string NgayTao { get; set; }
        public float TongTien { get; set; }
        public string TrangThai { get; set; }
        public string MaNhanVienGhi { get; set; }
    }
}
