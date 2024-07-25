using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using QuanLiShopQuanAo.DAL.Interfaces;

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
                    cmd.CommandText = "dbo.sp_QuenMK";
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@newgenpass", genpass);
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
        private string CreatePassword(int length)
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
    }
}
