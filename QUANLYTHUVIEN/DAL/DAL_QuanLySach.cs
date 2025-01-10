using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.DTO;

namespace QUANLYTHUVIEN.DAL
{
    public  class DAL_QuanLySach :DBConnect
    {
        DBConnect db = new DBConnect();
      
      
        public DataTable getListSach()
        {  
            string sqlGetListSach = "select MaCuonSach , MaSach, TenSach, TenTheLoai, TacGia, NamXuatBan," +
                " Gia , TinhTrang from SACH , THE_LOAI" +
                " where Sach.MaTheLoai = THE_LOAI.MaTheLoai";
            DataTable dt = db.Execute(sqlGetListSach);

            return dt;
        }
        public void CapNhatSoLuongSach()                      
        {
            string sql = "UPDATE SACH SET SoLuong = (    SELECT COUNT(*)  FROM SACH AS S  WHERE S.MaSach = SACH.MaSach );";
            db.ExecuteNonQuery(sql);
        }
        public DataTable TimKiemTheoMaCuonSach(string key)
        {
            string strSql = string.Format(" Select MaCuonSach , MaSach , TenSach , TacGia, NamXuatBan , NhaXuatBan , Gia , MoTa, TinhTrang,SoLuong,HinhAnh ,TenTheLoai \r\n     " +
                "                      from SACH  join THE_LOAI ON SACH.MaTheLoai = THE_LOAI.MaTheLoai\r\n        " +
                "                           where MaCuonSach = '{0}'", key);
            DataTable dt = db.Execute(strSql);
            return dt;
        }
        public DataTable getListTheLoaiSach()
        {
            string sqlListTheLoai = "Select MaTheLoai ,  TenTheLoai from THE_LOAI";
            DataTable dt = db.Execute(sqlListTheLoai);
            return dt;
        }
        public bool ThemTheLoaiSach(string ma , string ten)
        {
            try
            {
                string SqlThemTL = string.Format("Insert into THE_LOAI ( MaTheLoai, TenTheLoai) " +
                    "Values ('{0}',N'{1}')", ma, ten);
                db.ExecuteNonQuery(SqlThemTL);
                return true;
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool XoaTheLoaiSach(string ma)
        {
            try
            {
                string SqlXoaTL = string.Format("Update  SACH Set MaTheLoai = 'None' where MaTheLoai = '{0}'" +
                    "Delete from THE_LOAI where MaTheLoai = '{0}'", ma);
               
                  
                db.ExecuteNonQuery(SqlXoaTL);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool CapNhatTheLoaiSach(string ma, string ten)
        {
            try
            {
                string SqlCapNhat = string.Format("Update THE_LOAI set TenTheLoai = N'{0}' where MaTheLoai =  '{1}'", ten , ma);

                db.ExecuteNonQuery(SqlCapNhat);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public DataTable TimKiem(string key)
        {
            string SqlTimKiem = string.Format(@"select  MaCuonSach , MaSach, TenSach, TenTheLoai, TacGia, NamXuatBan, Gia , TinhTrang
                                FROM SACH JOIN THE_LOAI ON SACH.MaTheLoai = THE_LOAI.MaTheLoai WHERE MaCuonSach LIKE '{0}' OR MaSach LIKE '{0}' OR
                                TenSach LIKE N'%{0}%'  OR TacGia LIKE N'%{0}%' OR NhaXuatBan LIKE N'%{0}%' OR TenTheLoai LIKE N'%{0}%' OR  THE_LOAI.MaTheLoai = '{0}'", key);
            DataTable dt = db.Execute(SqlTimKiem);
            return dt;
        }
        public DataTable TimKiemTheLoai(string maTheLoai)
        {
            string strTheLoai = string.Format("select * from SACH where SACH.MaTheLoai = '{0}'",maTheLoai);
            DataTable dt = db.Execute(strTheLoai);
            return dt;
        }
        public bool ThemSach(Sach s)
        {

            try
            {
                string sqlThemSach = string.Format(
                "Insert into SACH ( MaCuonSach, TenSach, TacGia, NamXuatBan, NhaXuatBan, Gia, MoTa, TinhTrang, SoLuong, HinhAnh, MaTheLoai, MaSach ) " +
                "Values (N'{0}', N'{1}', N'{2}', '{3}', N'{4}', {5}, N'{6}', N'{7}', {8}, '{9}', '{10}', '{11}');",
                s.getMaCuonSach(), s.getTenSach(), s.getTacGia(), s.getNamXuatBan(), s.getNhaXuatBan(), s.getGia(), s.getMota(), s.getTinhTrang(), s.getSoLuong(), s.getHinhAnh(), s.getMaTheLoai(), s.getMaSach());
                db.ExecuteNonQuery(sqlThemSach);
                CapNhatSoLuongSach();
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public bool XoaSach(string key)
        {
            try
            {
                string SqlXoaSach = string.Format("BEGIN TRANSACTION;" +
                "\r\n\n\r\nDELETE FROM CHI_TIET_PHIEU_MUON\r" +
                "\nWHERE MaCuonSach IN (\r\n    SELECT MaCuonSach FROM SACH WHERE MaCuonSach = '{0}'\r\n);" +
                "\r\n\r\n\r\nDELETE FROM PHIEU_MUON\r\nWHERE MaPhieuMuon IN (\r\n    SELECT DISTINCT MaPhieuMuon\r\n    FROM CHI_TIET_PHIEU_MUON\r\n    WHERE MaCuonSach = '{0}'\r\n);" +
                "\r\n\r\n\r\nDELETE FROM SACH\r\nWHERE MaCuonSach = '{0}';\r\n\r\nCOMMIT;", key);
                db.ExecuteNonQuery(SqlXoaSach);
                CapNhatSoLuongSach();
                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public bool CapNhatSach(Sach s)
        {
            try
            {
                string sqlCapNhatSach = string.Format(
                "UPDATE SACH SET " +
                "TenSach = N'{0}', TacGia = N'{1}', NamXuatBan = {2}, NhaXuatBan = N'{3}', Gia = {4}, MoTa = N'{5}', TinhTrang = N'{6}', SoLuong = {7}, HinhAnh = '{8}', MaTheLoai = '{9}' " +
                "WHERE MaCuonSach = '{10}';",
                    s.getTenSach(), s.getTacGia(), s.getNamXuatBan(), s.getNhaXuatBan(), s.getGia(), s.getMota(), s.getTinhTrang(), s.getSoLuong(), s.getHinhAnh(), s.getMaTheLoai(), s.getMaCuonSach()
                );
                db.ExecuteNonQuery(sqlCapNhatSach);
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
            
        }
    }
}
