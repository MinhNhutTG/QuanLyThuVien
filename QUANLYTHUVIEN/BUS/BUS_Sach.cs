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
        DAL_QuanLySach DalQLSach = new DAL_QuanLySach();
        public DataTable GetDanhSachSach()
        {
            return DalQLSach.getListSach();
        }
        public DataTable GetTheLoai() { 
            return DalQLSach.getListTheLoaiSach();
        }
        public DataTable TimKiemSach(string key)
        {
            return DalQLSach.TimKiem(key);
        }
        public DataTable TimSachTheoTheLoai(string maTheLoai)
        {
            return DalQLSach.TimKiemTheLoai(maTheLoai);
        }
        public bool ThemSach(Sach s)
        {
            if (string.IsNullOrWhiteSpace(s.getMaCuonSach())) {
                throw new Exception("Mã cuốn sách không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getTenSach()))
            {
                throw new Exception("Tên cuốn sách không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getTinhTrang()))
            {
                throw new Exception("Tình trạng cuốn sách không được để trống");
            }
            if (s.getGia() == 0) 
            {
                throw new Exception("Gía cuốn sách không được để trống");
            }
            return DalQLSach.ThemSach(s);

        }

        public bool XoaSach(string key) { 
           return  DalQLSach.XoaSach(key);
        }
    }
}
