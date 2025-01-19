using QUANLYTHUVIEN.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYTHUVIEN.DTO;

namespace QUANLYTHUVIEN.BLL
{

    internal class BLL_ThuThu
    {
        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }

        DAL_QuanLyThuThu dalQLThuThu = new DAL_QuanLyThuThu();

        public DataTable getDanhSachThuThu()
        {
            return dalQLThuThu.LayDSThuThu();
        }

        public DataTable TimThuThu(string key)
        {
            return dalQLThuThu.Timkiem(key);
        }

        public DataTable getTimThuThuTheoMa(string MaThuThu) //một phương thức trong một lớp, được sử dụng để lấy dữ liệu của thủ thư dựa trên mã thủ thư
        {
            return dalQLThuThu.TimThuThuTheoMa(MaThuThu);
        }

        public bool ThemThuThu(ThuThu th)
        {
            if (dalQLThuThu.KiemTraTaiKhoan(th.UserName).Rows.Count > 0)
            {
                throw new BusinessLogicException("UserName này đã tồn tại !");
            }

            if (string.IsNullOrWhiteSpace(th.UserName))
            {
                throw new BusinessLogicException("UserName không được để trống !");
            }
            if (string.IsNullOrWhiteSpace(th.PassWord))
            {
                throw new BusinessLogicException("Password không được để trống !");
            }
            if (th.PhanQuyen != "admin" && th.PhanQuyen != "nhanvien")
            {
                throw new BusinessLogicException("Phân quyền không hợp lệ!");
            }
            if (string.IsNullOrWhiteSpace(th.MaThuThu))
            {
                throw new BusinessLogicException("Mã thủ thư không được để trống !");
            }
            if (string.IsNullOrWhiteSpace(th.TenThuThu))
            {
                throw new BusinessLogicException("Tên thủ thư không được để trống !");
            }
            if (string.IsNullOrWhiteSpace(th.NgaySinh))
            {
                throw new BusinessLogicException("Ngày sinh không được để trống !");
            }
            if (th.GioiTinh != "True" && th.GioiTinh != "False" )
            {
                throw new BusinessLogicException("Giới tính không hợp lệ !");
            }
            if (string.IsNullOrWhiteSpace(th.SoDT))
            {
                throw new BusinessLogicException("Số điện thoại không được để trống !");
            }

            return dalQLThuThu.ThemThuThu(th);

        }

        public bool CheckThuThu(string key)
        {
            return dalQLThuThu.TimThuThuTheoMa(key).Rows.Count > 0;
        }


        public bool CapNhatThuThu(ThuThu th)
        {
          
            if (string.IsNullOrWhiteSpace(th.UserName))
            {
                throw new BusinessLogicException("UserName không được để trống !");
            }
            if (string.IsNullOrWhiteSpace(th.PassWord))
            {
                throw new BusinessLogicException("Password không được để trống !");
            }
            if (th.PhanQuyen != "admin" && th.PhanQuyen != "nhanvien")
            {
                throw new BusinessLogicException("Phân quyền không hợp lệ!");
            }
            if (string.IsNullOrWhiteSpace(th.MaThuThu))
            {
                throw new BusinessLogicException("Mã thủ thư không được để trống !");
            }
            if (string.IsNullOrWhiteSpace(th.TenThuThu))
            {
                throw new BusinessLogicException("Tên thủ thư không được để trống !");
            }
            if (string.IsNullOrWhiteSpace(th.NgaySinh))
            {
                throw new BusinessLogicException("Ngày sinh không được để trống !");
            }
            if (string.IsNullOrWhiteSpace(th.GioiTinh))
            {
                throw new BusinessLogicException("Giới tính không được để trống !");
            }
            if (string.IsNullOrWhiteSpace(th.DiaChi))
            {
                throw new BusinessLogicException("Địa chỉ không được để trống !");
            }
            if (string.IsNullOrWhiteSpace(th.SoDT))
            {
                throw new BusinessLogicException("Số điện thoại không được để trống !");
            }

            return dalQLThuThu.CapNhatThuThu(th);
        }

        public bool XoaThuThu(string maThuThu, string userName)
        {
            return dalQLThuThu.XoaThuThu(maThuThu, userName);
        }
        
    }
}
