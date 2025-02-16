using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL.Interfaces;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace QuanLiShopQuanAo.DAL
{
    public class DAL_NhanVien : IProcNhanVien
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
                    cmd.CommandText = "dbo.sp_DanhSachNhanVien";
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
                    cmd.CommandText = "dbo.sp_TimNhanVien";
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
        public bool Insert(NhanVien nhanVien)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_ThemNhanVien";
                    cmd.Parameters.AddWithValue("@TenNhanVien", nhanVien.TenNhanVien);
                    cmd.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);
                    cmd.Parameters.AddWithValue("@Luong", nhanVien.Luong);
                    cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
                    cmd.Parameters.AddWithValue("@HinhAnh", nhanVien.HinhAnh);
                    cmd.Parameters.AddWithValue("@TrangThai", nhanVien.TrangThai);
                    cmd.Parameters.AddWithValue("@MatKhau", nhanVien.MatKhau);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Update(NhanVien nhanVien)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_CapNhatNhanVien";
                    cmd.Parameters.AddWithValue("@MaNhanVien", nhanVien.MaNhanVien);
                    cmd.Parameters.AddWithValue("@TenNhanVien", nhanVien.TenNhanVien);
                    cmd.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);
                    cmd.Parameters.AddWithValue("@Luong", nhanVien.Luong);
                    cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
                    cmd.Parameters.AddWithValue("@HinhAnh", nhanVien.HinhAnh);
                    cmd.Parameters.AddWithValue("@TrangThai", nhanVien.TrangThai);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Delete(NhanVien nhanVien)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_XoaNhanVien";
                    cmd.Parameters.AddWithValue("@MaNhanVien", nhanVien.MaNhanVien);
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
