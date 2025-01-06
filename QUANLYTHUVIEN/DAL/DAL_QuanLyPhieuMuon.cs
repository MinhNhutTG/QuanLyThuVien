

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
    public class DAL_QuanLyPhieuMuon : DBConnect
    {
        DBConnect db = new DBConnect();

        public DataTable LayDSPhieuMuon()
        {
            string strSQL = "select PHIEUMUON.MaPhieuMuon, PHIEUMUON.NgayMuon, PHIEUMUON.NgayTra, \r\n       PHIEUMUON.HanTra, PHIEUMUON.SoLuong, PHIEUMUON.TinhTrang, \r\n       PHIEUMUON.PhiPhat, DOCGIA.MaDocGia, THU_THU.MaThuThu\r\nFROM PHIEUMUON\r\nJOIN DOCGIA ON PHIEUMUON.MaDocGia = DOCGIA.MaDocGia\r\nJOIN THU_THU ON PHIEUMUON.MaThuThu = THU_THU.MaThuThu";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public bool KiemTraDocGia(string maDocGia)
        {
            string SqlView = string.Format("Select * from DOCGIA where MaDocGia = '{0}';", maDocGia);
            DataTable dt = db.Execute(SqlView);
            return dt.Rows.Count > 0;
        }   

        public DataTable LayThongTinPhieu(string maPhieuMuon)
        {
            string SqlView = string.Format("Select * from PHIEUMUON where MaPhieuMuon = '{0}';", maPhieuMuon);
            DataTable dt = db.Execute(SqlView);
            return dt;
        }
        public DataTable LayDSSearchOfSach(string key)
        {
            string SqlTimKiem = string.Format(@"select  MaCuonSach , MaSach, TenSach, TinhTrang ,SoLuong
                     FROM SACH  WHERE TenSach LIKE N'%{0}%' or MaSach LIKE '{0}' or MaCuonSach LIKE '{0}'", key);
            DataTable dt = db.Execute(SqlTimKiem);
            return dt;
        }
        public DataTable LayDSSachConSan()
        {
            string SqlTimKiem = "select  MaCuonSach , MaSach, TenSach, TinhTrang ,SoLuong FROM SACH  WHERE TinhTrang = N'Còn sẵn';";
            DataTable dt = db.Execute(SqlTimKiem);
            return dt;
        }
        public DataTable LayDSSearchOfDocGia(string key)
        {
            string SqlTimKiem = string.Format(@"select  MaDocGia, TenDocGia, Lop, DiaChi, SODT
                     FROM DOCGIA WHERE TenDocGia LIKE N'%{0}%' or MaDocGia LIKE '{0}'", key);
            DataTable dtdg = db.Execute(SqlTimKiem);
            return dtdg;
        }

        public DataTable LayChiTietPhieuMuon(string maPhieuMuon)
        {
            string SqlView = string.Format("SELECT SACH.MaCuonSach,MaSach, TenSach , TinhTrang\r\n " +
                 "FROM CHI_TIET_PHIEU_MUON\r\n            " +
                 "JOIN SACH ON CHI_TIET_PHIEU_MUON.MaCuonSach = SACH.MaCuonSach\r\n" +
                 " WHERE CHI_TIET_PHIEU_MUON.MaPhieuMuon = '{0}'", maPhieuMuon);
            DataTable dt = db.Execute(SqlView);
            return dt;
        }

        public DataTable LayDSSachTheoMaPhieu(string key)
        {
            string SqlView = string.Format("SELECT SACH.MaCuonSach,MaSach, TenSach\r\n " +
                "FROM CHI_TIET_PHIEU_MUON\r\n            " +
                "JOIN SACH ON CHI_TIET_PHIEU_MUON.MaCuonSach = SACH.MaCuonSach\r\n" +
                " WHERE CHI_TIET_PHIEU_MUON.MaPhieuMuon = '{0}'", key);
            DataTable dt = db.Execute(SqlView);
            return dt;
        }


        public DataTable Search(string key)
        {

            string strSearch = string.Format(@"select PHIEUMUON.MaPhieuMuon, PHIEUMUON.NgayMuon, PHIEUMUON.NgayTra, 
                PHIEUMUON.HanTra, PHIEUMUON.SoLuong, PHIEUMUON.TinhTrang, PHIEUMUON.PhiPhat, DOCGIA.MaDocGia, THU_THU.MaThuThu " +
                " FROM PHIEUMUON " +
                " JOIN DOCGIA ON PHIEUMUON.MaDocGia = DOCGIA.MaDocGia " +
                " JOIN THU_THU ON PHIEUMUON.MaThuThu = THU_THU.MaThuThu " +
                " WHERE MaPhieuMuon LIKE N'%{0}%'  OR  DOCGIA.MaDocGia = '{0}' OR THU_THU.MaThuThu = '{0}'", key);
            DataTable dt = db.Execute(strSearch);
            return dt;
        } //tìm kiếm phiếu mượn

        public bool Add(PhieuMuon m , List<Sach> list)
        {
            try
            {
                string SqlAdd = string.Format("INSERT INTO PHIEUMUON " +
                "(MaPhieuMuon, NgayMuon, NgayTra, HanTra, SoLuong, TinhTrang, PhiPhat, MaDocGia, MaThuThu) " +
                 "VALUES ('{0}', '{1:yyyy-MM-dd}', '{2:yyyy-MM-dd}', '{3:yyyy-MM-dd}', '{4}', N'{5}', '{6}', '{7}', '{8}');",
                m.MaPhieuMuon, m.NgayMuon, m.NgayTra, m.HanTra, m.SoLuong, m.TinhTrang, m.PhiPhat, m.MaDocGia, m.MaThuThu);
               
                db.ExecuteNonQuery(SqlAdd);
                foreach (Sach s in list)
                {
                    AddChiTietPhieu(m.MaPhieuMuon, s.getMaCuonSach());
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public void AddChiTietPhieu(string maphieu, string macuonsach)
        {
            try
            {
                string sqlAddChiTietPhieu = string.Format("INSERT INTO CHI_TIET_PHIEU_MUON (MaPhieuMuon, MaCuonSach) VALUES ('{0}', '{1}');", maphieu, macuonsach);
                string sqlUpdateTrangThaiSach = string.Format("UPDATE SACH SET TinhTrang = N'Đang mượn' WHERE MaCuonSach = '{0}';", macuonsach);
                db.ExecuteNonQuery(sqlAddChiTietPhieu);
                db.ExecuteNonQuery(sqlUpdateTrangThaiSach);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdatePhieu(PhieuMuon m)
        {
            string SqlUpdate = string.Format("UPDATE PHIEUMUON SET " +
                "NgayMuon = '{0:yyyy-MM-dd}', NgayTra = '{1:yyyy-MM-dd}', HanTra = '{2:yyyy-MM-dd}', SoLuong = '{3}', TinhTrang = N'{4}', PhiPhat = '{5}', MaDocGia = '{6}', MaThuThu = '{7}' " +
                "WHERE MaPhieuMuon = '{8}';",
                m.NgayMuon, m.NgayTra, m.HanTra, m.SoLuong, m.TinhTrang, m.PhiPhat, m.MaDocGia, m.MaThuThu, m.MaPhieuMuon);

            db.ExecuteNonQuery(SqlUpdate);
        }

        public void CapNhatTrangThaiPhieu(string maPhieuMuon) 
        { 
            try
            {
                string SqlUpdate = string.Format("UPDATE PHIEUMUON SET TinhTrang = N'Đã trả' WHERE MaPhieuMuon = '{0}';", maPhieuMuon);
                db.ExecuteNonQuery(SqlUpdate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void CapNhatTinhTrangSach(string maCuonSach) 
        {
            try
            {
                string SqlUpdate = string.Format("UPDATE SACH SET TinhTrang = N'Còn sẵn' WHERE MaCuonSach = '{0}';", maCuonSach);
                db.ExecuteNonQuery(SqlUpdate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        

        public void UpdateXoaChiTietPhieu(string maPhieuMuon) //xóa chi tiết phiếu
        {
            string SqlDelete = string.Format("DELETE FROM CHI_TIET_PHIEU_MUON WHERE MaPhieuMuon = '{0}';", maPhieuMuon);
            db.ExecuteNonQuery(SqlDelete);
        }


        
        public void Delete(string key)
        {
            try
            {
                string SqlDelete = string.Format("Delete from CHI_TIET_PHIEU_MUON where MaPhieuMuon = '{0}' " +
                " DELETE FROM PHIEUMUON WHERE MaPhieuMuon = '{0}';", key);
                db.ExecuteNonQuery(SqlDelete);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
