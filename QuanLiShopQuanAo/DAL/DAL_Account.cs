using Microsoft.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Text;
using QuanLiShopQuanAo.DAL.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLiShopQuanAo.DAL
{
    public class DAL_Account : IProcAccount
    {
        public bool Login(string email, string matKhau)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_DangNhap";
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Connection = conn;
                    conn.Open();

                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public bool SendMail(string email)
        {
            try
            {
                string genpass = CreatePassword(5);
                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_QuenMatKhau";
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@NewGenPassword", genpass);
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                string username = "baocnqps40165@gmail.com";
                string password = "eyiu fuiw jjus wiac";
                ICredentialsByHost credentials = new NetworkCredential(username, password);

                SmtpClient smtpClient = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = credentials
                };

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(username);
                mail.To.Add(username);
                mail.Subject = "Bạn Đã Sử Dụng Quên Mật Khẩu";
                mail.Body = "Chào anh/chị mật khẩu mới để truy cập phần mềm là " + genpass;

                smtpClient.Send(mail);
                return true;
            }
            catch { }
            return false;
        }
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public bool ChangePassword(string email, string oldPass, string newPass, string newPassAgain)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_DoiMatKhau";
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@OldPass", oldPass);
                    cmd.Parameters.AddWithValue("@NewPass", newPass);
                    cmd.Parameters.AddWithValue("@NewPassAgain", newPassAgain);
                    cmd.Connection = conn;
                    conn.Open();

                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public string MaNguoiDangNhap(string email)
        {
            string maNhanVien = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_MaNguoiDN";
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        maNhanVien = (string)reader["MaNhanVien"];
                    }
                }
            }
            catch { }
            return maNhanVien;
        }
        public string ChucVuNguoiDangNhap(string email)
        {
            string chucVu = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(DataBaseConnection.DBConnection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_ChucVuNguoiDN";
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        chucVu = (string)reader["ChucVu"];
                    }
                }
            }
            catch { }
            return chucVu;
        }
    }
}
