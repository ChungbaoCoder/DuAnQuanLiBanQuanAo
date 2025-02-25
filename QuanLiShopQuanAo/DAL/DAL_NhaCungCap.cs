using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL.Interfaces;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace QuanLiShopQuanAo.DAL
{
    public class DAL_NhaCungCap : IProcNhaCungCap
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
                    cmd.CommandText = "dbo.sp_DanhSachNhaCungCap";
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
                    cmd.CommandText = "dbo.sp_TimNhaCungCap";
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
        public bool Insert(NhaCungCap nhaCungCap)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_ThemNhaCungCap";
                    cmd.Parameters.AddWithValue("@TenNhaCungCap", nhaCungCap.TenNhaCungCap);
                    cmd.Parameters.AddWithValue("@SDT", nhaCungCap.SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", nhaCungCap.DiaChi);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Update(NhaCungCap nhaCungCap)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_CapNhatNhaCungCap";
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", nhaCungCap.MaNhaCungCap);
                    cmd.Parameters.AddWithValue("@TenNhaCungCap", nhaCungCap.TenNhaCungCap);
                    cmd.Parameters.AddWithValue("@SDT", nhaCungCap.SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", nhaCungCap.DiaChi);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Delete(NhaCungCap nhaCungCap)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_XoaNhaCungCap";
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", nhaCungCap.MaNhaCungCap);
                    cmd.Parameters.AddWithValue("@SDT", nhaCungCap.SDT);
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
