﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiShopQuanAo.DAL.Interfaces
{
    public interface IProcAccount
    {
        public bool Login(string email, string matKhau);
        public bool ChangePassword(string email, string oldPass, string newPass, string newPassAgain);
        public bool SendMail(string email);
    }
}
