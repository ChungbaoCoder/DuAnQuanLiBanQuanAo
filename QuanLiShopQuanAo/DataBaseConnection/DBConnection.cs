using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopQuanAo.DataBaseConnection
{
    public static class DBConnection
    {
        //public static string ConnectionString = "Data Source=ADMIN-PC;Initial Catalog=QuanLiCuaHang;Integrated Security=True;Trust Server Certificate=True";
        public static string ConnectionString = @"Data Source=LOGINUS\SQLEXPRESS;Initial Catalog=QuanLiCuaHang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
    }
}
