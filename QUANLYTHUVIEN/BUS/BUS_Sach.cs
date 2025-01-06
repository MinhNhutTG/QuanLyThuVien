using QUANLYTHUVIEN.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYTHUVIEN.DTO;



namespace QUANLYTHUVIEN.BUS
{

    internal  class BUS_Sach
    {
        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }
        DAL_QuanLySach DalQLSach = new DAL_QuanLySach();
       
        public DataTable GetDanhSachSach()
        {
            return DalQLSach.getListSach();
        }
        public DataTable GetTheLoai() { 
            return DalQLSach.getListTheLoaiSach();
        }
  
        public bool ThemTheLoai(string ma,string ten)
        {
            return DalQLSach.ThemTheLoaiSach(ma, ten);
        }
        public bool XoaTheLoai(string ma)
        {
            return DalQLSach.XoaTheLoaiSach(ma);
        }
        public bool CapNhatTheLoai(string ma ,string ten)
        {
            return DalQLSach.CapNhatTheLoaiSach(ma, ten);
        }
        public DataTable TimKiemSach(string key)
        {
            return DalQLSach.TimKiem(key);
        }
        public DataTable TiemKiemSachTheoMaCuonSach(string key)
        {
           return  DalQLSach.TimKiemTheoMaCuonSach(key);
        }
        public DataTable TimSachTheoTheLoai(string maTheLoai)
        {
            return DalQLSach.TimKiemTheLoai(maTheLoai);
        }
        public bool ThemSach(Sach s)
        {
            if (CheckSach(s.getMaCuonSach()))
            {
                throw new BusinessLogicException("Mã cuốn sách này đã tồn tại");
            }
            if (string.IsNullOrWhiteSpace(s.getMaCuonSach())) {
                throw new BusinessLogicException("Mã cuốn sách không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getTenSach()))
            {
                throw new BusinessLogicException("Tên cuốn sách không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getTinhTrang()))
            {
                throw new BusinessLogicException("Tình trạng cuốn sách không được để trống");
            }
            if (s.getGia() < 0 || s.getGia() > 999999999) 
            {
                throw new BusinessLogicException("Gía cuốn sách không hợp lệ");
            }
            return  DalQLSach.ThemSach(s);

        }
        public bool CheckSach(string key)
        {
            return DalQLSach.TimKiemTheoMaCuonSach(key).Rows.Count > 0;
        }

        public bool XoaSach(string key) { 
           return  DalQLSach.XoaSach(key);
        }
        public bool CapNhatSach(Sach s)
        {
           
            if (string.IsNullOrWhiteSpace(s.getMaCuonSach()))
            {
                throw new BusinessLogicException("Mã cuốn sách không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getTenSach()))
            {
                throw new BusinessLogicException("Tên cuốn sách không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getTinhTrang()))
            {
                throw new BusinessLogicException("Tình trạng cuốn sách không được để trống");
            }
            if (s.getGia() < 0 || s.getGia() > 999999999)
            {
                throw new BusinessLogicException("Gía cuốn sách không hợp lệ");
            }
            return DalQLSach.CapNhatSach(s);
        }
       
    }
}
