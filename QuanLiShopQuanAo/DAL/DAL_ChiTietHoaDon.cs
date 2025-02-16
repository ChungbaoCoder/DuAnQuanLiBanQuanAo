using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL.Interfaces;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace QuanLiShopQuanAo.DAL
{
    public class DAL_ChiTietHoaDon : IProcChiTietHoaDon
    {
        public DataTable LoadChiTietHoaDon(string maHoaDon)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_DanhSachChiTietHoaDon";
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            catch { }
            return dt;
        }
        public bool NgungLapHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_NgungLapHoaDon";
                    cmd.Parameters.AddWithValue("@MaHoaDon", chiTietHoaDon.MaHoaDon);
                    cmd.Parameters.AddWithValue("@MaSanPham", chiTietHoaDon.MaSanPham);
                    cmd.Parameters.AddWithValue("@SoLuong", chiTietHoaDon.SoLuong);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Insert(ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_ThemChiTietHoaDon";
                    cmd.Parameters.AddWithValue("@MaHoaDon", chiTietHoaDon.MaHoaDon);
                    cmd.Parameters.AddWithValue("@MaKhachHang", chiTietHoaDon.MaKhachHang);
                    cmd.Parameters.AddWithValue("@MaSanPham", chiTietHoaDon.MaSanPham);
                    cmd.Parameters.AddWithValue("@SoLuong", chiTietHoaDon.SoLuong);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Update(ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_CapNhatChiTietHoaDon";
                    cmd.Parameters.AddWithValue("@MaHoaDon", chiTietHoaDon.MaHoaDon);
                    cmd.Parameters.AddWithValue("@MaKhachHang", chiTietHoaDon.MaKhachHang);
                    cmd.Parameters.AddWithValue("@TongThanhTien", chiTietHoaDon.TongThanhTien);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Delete(ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_XoaChiTietHoaDon";
                    cmd.Parameters.AddWithValue("@MaHoaDon", chiTietHoaDon.MaHoaDon);
                    cmd.Parameters.AddWithValue("@MaSanPham", chiTietHoaDon.MaSanPham);
                    cmd.Parameters.AddWithValue("@SoLuong", chiTietHoaDon.SoLuong);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
    }
}
