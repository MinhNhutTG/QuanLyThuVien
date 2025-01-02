using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN
{
    internal class XuLyLogin
    {
        Database db;
        public XuLyLogin()
        {
            db = new Database();
        }
        public DataTable TimTaiKhoan(string key)
        {
            string sql = string.Format("select * from TAI_KHOAN where UserName = '{0}'",key);
            DataTable dt = db.Execute(sql);
            return dt;
        }
    }
}
