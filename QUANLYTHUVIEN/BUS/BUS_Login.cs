﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYTHUVIEN.DAL;
using QUANLYTHUVIEN.DTO;

namespace QUANLYTHUVIEN.BUS
{
    internal class BUS_Login
    {
        DAL_Login dalLogin = new DAL_Login();
        public TaiKhoan Login(string us, string  pw)
        {
            return  dalLogin.checkLogin(us, pw) ;
        }
    }
}
