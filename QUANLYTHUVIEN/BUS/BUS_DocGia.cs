using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYTHUVIEN.DAL;
using QUANLYTHUVIEN.DTO;

namespace QUANLYTHUVIEN.BUS
{
    internal class BUS_DocGia
    {
        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }
        DAL_QuanLyDocGia dAL_QuanLyDocGia = new DAL_QuanLyDocGia();

        public DataTable GetDSDocGia()
        {
            return dAL_QuanLyDocGia.getListDocGia();
        }
        public DataTable TimKiemDocGia(string key)
        {
            return dAL_QuanLyDocGia.TimKiemDocGia(key);
        }
        public DataTable TimKiemTheoMaDocGia(string key)
        {
            return dAL_QuanLyDocGia.TimKiemTheoMaDocGia(key);
        }
        public bool ThemDocGia(DocGia s)
        {
            if (KTDocGia(s.getMaDocGia()))
            {
                throw new BusinessLogicException("Mã độc giả đã tồn tại");
            }
            if (string.IsNullOrWhiteSpace(s.getMaDocGia()))
            {
                throw new BusinessLogicException("Mã độc giả không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getTenDocGia()))
            {
                throw new BusinessLogicException("Tên độc giả không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getLop()))
            {
                throw new BusinessLogicException("Lớp không được để trống");
            }
            //if (string.IsNullOrWhiteSpace(s.getDiaChi()))
            //{
            //    throw new BusinessLogicException("Địa chỉ không được để trống");
            //}
            if (string.IsNullOrWhiteSpace(s.getSODT()))
            {
                throw new BusinessLogicException("Số điện thoại không được để trống");
            }
            return dAL_QuanLyDocGia.ThemDocGia(s);

        }
        public bool KTDocGia(string key)
        {
            return dAL_QuanLyDocGia.TimKiemTheoMaDocGia(key).Rows.Count > 0;
        }
        public bool XoaDocGia(string key)
        {
            return dAL_QuanLyDocGia.XoaDocGia(key);
        }
        
        public bool CapNhatDocGia(DocGia s)
        {
          
            if (string.IsNullOrWhiteSpace(s.getMaDocGia()))
            {
                throw new BusinessLogicException("Mã độc giả không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getTenDocGia()))
            {
                throw new BusinessLogicException("Tên độc giả không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getLop()))
            {
                throw new BusinessLogicException("Lớp không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getDiaChi()))
            {
                throw new BusinessLogicException("Địa chỉ không được để trống");
            }
            if (string.IsNullOrWhiteSpace(s.getSODT()))
            {
                throw new BusinessLogicException("Số điện thoại không được để trống");
            }
            return dAL_QuanLyDocGia.CapNhatDocGia(s);
        }
    }
}
