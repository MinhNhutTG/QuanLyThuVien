using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN.DTO
{
    public  class TaiKhoan
    {
        private string userName;
        private string password;
        private string phanQuyen;

        public string getUserName() {
       
                return userName;
        } 
        public void setUserName(string value)
        {
            userName = value;
        }
        public string getPassword()
        {

            return password;
        }
        public void setPassword(string value)
        {
            password = value;
        }

        public string getPhanQuyen()
        {

            return phanQuyen;
        }
        public void getPhanQuyen(string value)
        {
            phanQuyen = value;
        }
        public TaiKhoan(string us, string pw , string pq) {
            this.userName = us; 
            this.password = pw;
            this.phanQuyen = pq;
        }
    }
}
