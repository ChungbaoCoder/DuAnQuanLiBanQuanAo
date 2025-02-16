using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL.Interfaces;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace QuanLiShopQuanAo.DAL
{
    public class DAL_SanPham : IProcSanPham
    {
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_DanhSachSanPham";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            catch { }
            return dt;
        }
        public DataTable Search(string tim)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_TimSanPham";
                    cmd.Parameters.AddWithValue("@Varible", tim);
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            catch { }
            return dt;
        }
        public bool Insert(SanPham sanPham)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_ThemSanPham";
                    cmd.Parameters.AddWithValue("@TenSanPham", sanPham.TenSanPham);
                    cmd.Parameters.AddWithValue("@LoaiSanPham", sanPham.LoaiSanPham);
                    cmd.Parameters.AddWithValue("@HinhAnh", sanPham.HinhAnh);
                    cmd.Parameters.AddWithValue("@SoLuong", sanPham.SoLuong);
                    cmd.Parameters.AddWithValue("@Gia", sanPham.Gia);
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", sanPham.MaNhaCungCap);
                    cmd.Parameters.AddWithValue("@TrangThai", sanPham.TrangThai);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Update(SanPham sanPham)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_CapNhatSanPham";
                    cmd.Parameters.AddWithValue("@MaSanPham", sanPham.MaSanPham);
                    cmd.Parameters.AddWithValue("@TenSanPham", sanPham.TenSanPham);
                    cmd.Parameters.AddWithValue("@LoaiSanPham", sanPham.LoaiSanPham);
                    cmd.Parameters.AddWithValue("@HinhAnh", sanPham.HinhAnh);
                    cmd.Parameters.AddWithValue("@SoLuong", sanPham.SoLuong);
                    cmd.Parameters.AddWithValue("@Gia", sanPham.Gia);
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", sanPham.MaNhaCungCap);
                    cmd.Parameters.AddWithValue("@TrangThai", sanPham.TrangThai);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Delete(SanPham sanPham)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_XoaSanPham";
                    cmd.Parameters.AddWithValue("@MaSanPham", sanPham.MaSanPham);
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
