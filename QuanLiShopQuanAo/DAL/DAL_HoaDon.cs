using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopQuanAo.DAL
{
    public class DAL_HoaDon : IProcHoaDon
    {
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_DanhSachHoaDon";
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
                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_TimHoaDon";
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
        public bool Insert(HoaDon hoaDon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_TaoHoaDonMoi";
                    cmd.Parameters.AddWithValue("@TenKhachHang", hoaDon.TenKhachHang);
                    cmd.Parameters.AddWithValue("@SDT", hoaDon.SDTKhach);
                    cmd.Parameters.AddWithValue("@NgayLap", hoaDon.NgayTao);
                    cmd.Parameters.AddWithValue("@MaNVGhi", hoaDon.MaNhanVienGhi);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Update(HoaDon hoaDon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_CapNhatHoaDon";
                    cmd.Parameters.AddWithValue("@MaHoaDon", hoaDon.MaHoaDon);
                    cmd.Parameters.AddWithValue("@MaKhachHang", hoaDon.MaKhachHang);
                    cmd.Parameters.AddWithValue("@TenKhachHang", hoaDon.TenKhachHang);
                    cmd.Parameters.AddWithValue("@NgayLap", hoaDon.NgayTao);
                    cmd.Parameters.AddWithValue("@TrangThai", hoaDon.TrangThai);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Delete(HoaDon hoaDon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_XoaHoaDon";
                    cmd.Parameters.AddWithValue("@MaHoaDon", hoaDon.MaHoaDon);
                    cmd.Parameters.AddWithValue("@MaKhachHang", hoaDon.MaKhachHang);
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
