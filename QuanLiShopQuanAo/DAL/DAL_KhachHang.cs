using Microsoft.Data.SqlClient;
using QuanLiShopQuanAo.BUS.Entities;
using QuanLiShopQuanAo.DAL.Interfaces;
using QuanLiShopQuanAo.DataBaseConnection;
using System.Data;

namespace QuanLiShopQuanAo.DAL
{
    public class DAL_KhachHang : IProcKhachHang
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
                    cmd.CommandText = "dbo.sp_DanhSachKhachHang";
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
                    using (SqlCommand cmd = new SqlCommand("dbo.sp_TimKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Varible", tim);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader); // Nạp dữ liệu vào DataTable
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            return dt;
        }


        public bool Insert(KhachHang khachHang)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_ThemKhachHang";
                    cmd.Parameters.AddWithValue("@TenKhachHang", khachHang.TenKhachHang);
                    cmd.Parameters.AddWithValue("@SDT", khachHang.SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR]: {ex.Message}");
            }
            return false;
        }
        public bool Update(KhachHang khachHang)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_CapNhatKhachHang";
                    cmd.Parameters.AddWithValue("@MaKhachHang", khachHang.MaKhachHang);
                    cmd.Parameters.AddWithValue("@TenKhachHang", khachHang.TenKhachHang);
                    cmd.Parameters.AddWithValue("@SDT", khachHang.SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
                    cmd.Connection = conn;
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool Delete(KhachHang khachHang)
        {
            try
            {
                // Create the SQL connection using the connection string
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    // Define the SQL command to call the stored procedure
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_XoaKhachHang"; // Name of the stored procedure

                    // Add parameters for MaKhachHang and SDT
                    cmd.Parameters.AddWithValue("@MaKhachHang", khachHang.MaKhachHang);
                    cmd.Parameters.AddWithValue("@SDT", khachHang.SDT);

                    // Set the connection for the command
                    cmd.Connection = conn;

                    // Open the connection
                    conn.Open();

                    // Execute the stored procedure and check if any rows were affected
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // If rows were affected, the deletion was successful
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the execution
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }


    }
}

