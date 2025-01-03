using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN
{
    public class ThuThu
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string PhanQuyen { get; set; }
        public string MaThuThu { get; set; }
        public string TenThuThu { get; set; }
        public string  NgaySinh {  get; set; }
        public string  GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT {  get; set; }
       
        public ThuThu()
        {
            UserName = string.Empty;
            PassWord = string.Empty;
            PhanQuyen = string.Empty;
            MaThuThu = string.Empty;
            TenThuThu = string.Empty;
            NgaySinh = string .Empty;
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
