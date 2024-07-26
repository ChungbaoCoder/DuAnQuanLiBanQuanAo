using QuanLiShopQuanAo.DAL;
using QuanLiShopQuanAo.DAL.Interfaces;

namespace QuanLiShopQuanAo.BUS
{
    public class BUS_Account
    {
        public static bool Login(string email, string matKhau)
        {
            IProcAccount account = new DAL_Account();
            return account.Login(email, matKhau);
        }
        public static bool ChangePassword(string email, string oldPass, string newPass, string newPassAgain)
        {
            IProcAccount account = new DAL_Account();
            return account.ChangePassword(email, oldPass, newPass, newPassAgain);
        }
        public static bool SendMail(string email)
        {
            IProcAccount account = new DAL_Account();
            return account.SendMail(email);
        }
        public static string MaNguoiDangNhap(string email)
        {
            IProcAccount account = new DAL_Account();
            return account.MaNguoiDangNhap(email);
        }
    }
}
