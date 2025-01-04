using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        
        public DataTable getListTheLoaiSach()
        {
            string sqlListTheLoai = "Select MaTheLoai ,  TenTheLoai from THE_LOAI";
            DataTable dt = db.Execute(sqlListTheLoai);
            return dt;
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
                "Values ('{0}', N'{1}', N'{2}', {3}, N'{4}', {5}, N'{6}', N'{7}', {8}, '{9}', '{10}', '{11}');",
                s.getMaCuonSach(), s.getTenSach(), s.getTacGia(), s.getNamXuatBan(), s.getNhaXuatBan(), s.getGia(), s.getMota(), s.getTinhTrang(), s.getSoLuong(), s.getHinhAnh(), s.getMaTheLoai(), s.getMaSach());
                db.ExecuteNonQuery(sqlThemSach);
                return true;
            }
          
            catch (Exception ex) {
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
                "\r\n\r\n\r\nDELETE FROM PHIEUMUON\r\nWHERE MaPhieuMuon IN (\r\n    SELECT DISTINCT MaPhieuMuon\r\n    FROM CHI_TIET_PHIEU_MUON\r\n    WHERE MaCuonSach = '{0}'\r\n);" +
                "\r\n\r\n\r\nDELETE FROM SACH\r\nWHERE MaCuonSach = '{0}';\r\n\r\nCOMMIT;", key);
                db.ExecuteNonQuery(SqlXoaSach);
                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
