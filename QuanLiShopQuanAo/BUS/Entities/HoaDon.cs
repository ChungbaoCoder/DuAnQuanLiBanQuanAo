using System.Net.Http.Headers;

namespace QuanLiShopQuanAo.BUS.Entities
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public string MaKhachHang { get; set; }
        public string NgayTao { get; set; }
        public float TongTien { get; set; }
        public string TrangThai { get; set; }
        public string MaNhanVienGhi { get; set; }
    }
}
