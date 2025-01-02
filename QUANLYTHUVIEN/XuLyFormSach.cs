using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;


namespace QUANLYTHUVIEN
{
    internal class XuLyFormSach
    {
        Database db;

        public XuLyFormSach()
        {
            db = new Database();    
        }


        public void CapNhatSoLuongSach()                        // Cập nhật số lượng những cuốn sách cùng mã Sách
        {
            string sql = "UPDATE SACH SET SoLuong = (    SELECT COUNT(*)  FROM SACH AS S  WHERE S.MaSach = SACH.MaSach );";
            db.ExecuteNonQuery(sql);
        }

        public DataTable LayDSSach()                     //Lấy toàn bộ sách 
        {
            string strSQL = "select MaCuonSach , MaSach, TenSach, TenTheLoai, TacGia, NamXuatBan, Gia , TinhTrang from SACH , THE_LOAI where Sach.MaTheLoai = THE_LOAI.MaTheLoai"; 
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable TimKiem(string key)             // Tìm kiếm sách theo các tiêu chí 
        {
            string SqlTimKiem = string.Format(@"select  MaCuonSach , MaSach, TenSach, TenTheLoai, TacGia, NamXuatBan, Gia , TinhTrang
                                FROM SACH JOIN THE_LOAI ON SACH.MaTheLoai = THE_LOAI.MaTheLoai WHERE MaCuonSach LIKE '{0}' OR MaSach LIKE '{0}' OR
                                TenSach LIKE N'%{0}%'  OR TacGia LIKE N'%{0}%' OR NhaXuatBan LIKE N'%{0}%' OR TenTheLoai LIKE N'%{0}%' OR  THE_LOAI.MaTheLoai = '{0}'", key);
            DataTable dt = db.Execute(SqlTimKiem);
            return dt;
        }

        public DataTable TimSachTheoMaCuonSach(string key)          //Hàm tìm kiếm sách theo Mã : input Key  , output DataTable
        {
            string strSql = string.Format(" Select MaCuonSach , MaSach , TenSach , TacGia, NamXuatBan , NhaXuatBan , Gia , MoTa, TinhTrang,SoLuong,HinhAnh ,TenTheLoai \r\n     " +
                "                      from SACH  join THE_LOAI ON SACH.MaTheLoai = THE_LOAI.MaTheLoai\r\n        " +
                "                           where MaCuonSach = '{0}'", key);
            DataTable dt = db.Execute(strSql);
            return dt;
        }

        public DataTable LayTheLoai()       //  Dùng hàm này trả về DataTable Thể loại  để load combobox the loai
        {
            string strTheLoai = "Select * from THE_LOAI";
            DataTable dt = db.Execute(strTheLoai);
            return dt;
        }
       

        public bool KiemTraMaSach(string key)        // Kiểm tra sách đã tồn tại chưa
        {
            string SqlKiemTra = string.Format("Select * from SACH where MaCuonSach = '{0} '", key);
            DataTable dt = db.Execute(SqlKiemTra);
            return dt.Rows.Count > 0;               // Nếu > 0 ->> return true , ngược lại là false
        }


        public void ThemSach(Sach s)                // Hàm THÊM Sách đầu vào là 1 Sách 
        {
            string sqlThemSach = string.Format(
                  "Insert into SACH ( MaCuonSach, TenSach, TacGia, NamXuatBan, NhaXuatBan, Gia, MoTa, TinhTrang, SoLuong, HinhAnh, MaTheLoai, MaSach ) " +
                  "Values ('{0}', N'{1}', N'{2}', {3}, N'{4}', {5}, N'{6}', N'{7}', {8}, '{9}', '{10}', '{11}');",
                  s.MaCuonSach, s.TenSach, s.TacGia, s.NamXuatBan, s.NhaXuatBan, s.Gia, s.Mota, s.TinhTrang, s.SoLuong, s.HinhAnh, s.MaTheLoai, s.MaSach
              );

            db.ExecuteNonQuery(sqlThemSach);
        }

        public void XoaSach(string Key)               // Hàm Xóa Sách , khi xoá sách sẽ xóa luôn phiếu mượn và chi tiết phiếu mượn  
        {
            string SqlXoaSach = string.Format("BEGIN TRANSACTION;" +
                "\r\n\n\r\nDELETE FROM CHI_TIET_PHIEU_MUON\r" +
                "\nWHERE MaCuonSach IN (\r\n    SELECT MaCuonSach FROM SACH WHERE MaCuonSach = '{0}'\r\n);" +
                "\r\n\r\n\r\nDELETE FROM PHIEUMUON\r\nWHERE MaPhieuMuon IN (\r\n    SELECT DISTINCT MaPhieuMuon\r\n    FROM CHI_TIET_PHIEU_MUON\r\n    WHERE MaCuonSach = '{0}'\r\n);" +
                "\r\n\r\n\r\nDELETE FROM SACH\r\nWHERE MaCuonSach = '{0}';\r\n\r\nCOMMIT;", Key);
            db.ExecuteNonQuery(SqlXoaSach);
        }
     
        public void CapNhatSach(Sach s)             //Hàm cập nhật Sách 
        {
            string sqlCapNhatSach = string.Format(
             "UPDATE SACH SET " +
             "TenSach = N'{0}', TacGia = N'{1}', NamXuatBan = {2}, NhaXuatBan = N'{3}', Gia = {4}, MoTa = N'{5}', TinhTrang = N'{6}', SoLuong = {7}, HinhAnh = '{8}', MaTheLoai = '{9}' " +
             "WHERE MaCuonSach = '{10}';",
                 s.TenSach, s.TacGia, s.NamXuatBan, s.NhaXuatBan, s.Gia, s.Mota, s.TinhTrang, s.SoLuong, s.HinhAnh, s.MaTheLoai, s.MaCuonSach
            );
            db.ExecuteNonQuery(sqlCapNhatSach);

        }
    }
}
