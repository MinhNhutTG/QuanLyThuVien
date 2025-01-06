using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN.DTO
{
    internal class ThuThu
    {
        /*
        private string UserName;
        private string PassWord;
        private string PhanQuyen;
        private string MaThuThu;
        private string TenThuThu;
        private string NgaySinh;
        private string GioiTinh;
        private string DiaChi;
        private string SoDT;

        public string getUserName()
        {
            return UserName;
        }
        public void setUserName(string value) // Gán giá trị value vào thuộc tính MaThuThu của đối tượng hiện tại
        {
            this.UserName = value;
        }
        public string getPassWord()
        {
            return PassWord;
        }
        public void setPassWord(string value)
        {
            this.PassWord = value;
        }
        public string getPhanQuyen()
        {
            return PhanQuyen;
        }
        public void setPhanQuyen(string value)
        {
            this.PhanQuyen = value;
        }
        public string getMaThuThu()
        {
            return MaThuThu;
        }
        public void setMaThuThu(string value)
        {
            this.MaThuThu = value;
        }
        public string getTenThuThu()
        {
            return TenThuThu;
        }
        public void setTenThuThu( string value)
        {
            this.TenThuThu = value;
        }
        public string getNgaySinh()
        {
            return NgaySinh;
        }
        public void setNgaySinh(string value)
        {
            this.NgaySinh = value;
        }
        public string getGioiTinh()
        {
            return GioiTinh;
        }
        public void setGioiTinh(string value)
        {
            this.GioiTinh = value;
        }
        public string getDiaChi()
        {
            return DiaChi;
        }
        public void setDiaChi(string value)
        {
            this.DiaChi = value;
        }
        public string getSoDT()
        {
            return SoDT;
        }
        public void setSoDT(string value)
        {
            this.SoDT = value;
        }
        */

        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string PhanQuyen { get; set; }
        public string MaThuThu { get; set; }
        public string TenThuThu { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public ThuThu()
        {
            UserName = string.Empty;
            PassWord = string.Empty;
            PhanQuyen = string.Empty;
            MaThuThu = string.Empty;
            TenThuThu = string.Empty;
            NgaySinh = string.Empty;
            GioiTinh = string.Empty;
            DiaChi = string.Empty;
            SoDT = string.Empty;

        }

        public ThuThu(string userName, string passWord, string phanQuyen, string maThuThu, string tenThuThu, string ngaySinh, string gioiTinh, string diaChi, string soDT)
        {
            UserName = userName;
            PassWord = passWord;
            PhanQuyen = phanQuyen;
            MaThuThu = maThuThu;
            TenThuThu = tenThuThu;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDT = soDT;

        }
    }
}
