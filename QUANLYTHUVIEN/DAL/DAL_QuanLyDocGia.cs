using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYTHUVIEN.DTO;

namespace QUANLYTHUVIEN.DAL
{
    internal class DAL_QuanLyDocGia :DBConnect
    {
        DBConnect db = new DBConnect();
        public DataTable getListDocGia()
        {
            string sqlGetListDocGia = "select MaDocGia, TenDocGia, Lop, DiaChi, SODT from DOC_GIA";
            DataTable dt = db.Execute(sqlGetListDocGia);

            return dt;
        }
        public DataTable TimKiemDocGia(string key)
        {
            string SqlTimKiemDocGia = string.Format(@"SELECT MaDocGia, TenDocGia, Lop, DiaChi, SoDT FROM DOC_GIA " +
                " WHERE MaDocGia LIKE '{0}' OR TenDocGia LIKE N'%{0}%' OR Lop LIKE N'%{0}%' OR DiaChi LIKE N'%{0}%' OR MaDocGia = '%{0}%';", key);
            DataTable dt = db.Execute(SqlTimKiemDocGia);
            return dt;
        }

        public DataTable TimKiemTheoMaDocGia(string key)
        {
            string strSql = string.Format(" Select MaDocGia, TenDocGia, Lop, DiaChi, SODT \r\n" +
                                          " from DOC_GIA \r\n" +
                                          " where MaDocGia = '{0}'", key);
            DataTable dt = db.Execute(strSql);
            return dt;
        }
        public bool ThemDocGia(DocGia s)
        {

            try
            {
                string sqlThemDocGia = string.Format(
                "Insert into DOC_GIA (MaDocGia, TenDocGia, Lop, DiaChi, SoDT) " +
                                     "Values ('{0}', N'{1}', N'{2}', N'{3}', '{4}');",
                s.getMaDocGia(), s.getTenDocGia(), s.getLop(), s.getDiaChi(), s.getSODT());
                db.ExecuteNonQuery(sqlThemDocGia);
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool XoaDocGia(string key)
        {
            try
            {
                string SqlXoaDocGia = string.Format("DELETE FROM CHI_TIET_PHIEU_MUON\nWHERE MaPhieuMuon IN (\n" +
                                                "SELECT MaPhieuMuon FROM Phieu_Muon WHERE MaDocGia = '{0}'\n)\n" +
                                                "DELETE FROM PHIEU_MUON\nWHERE MaDocGia = '{0}'\n" +
                                                "DELETE FROM DOC_GIA\nWHERE MaDocGia = '{0}'", key);
                db.ExecuteNonQuery(SqlXoaDocGia);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public bool CapNhatDocGia(DocGia s)
        {
            try
            {
                string sqlCapNhatDocGia = string.Format(
                "UPDATE DOC_GIA SET " +
                "TenDocGia = N'{0}', Lop = N'{1}', DiaChi = N'{2}', SoDT = N'{3}' " +
                "WHERE MaDocGia = '{4}';",
                s.getTenDocGia(), s.getLop(), s.getDiaChi(), s.getSODT(), s.getMaDocGia());
                db.ExecuteNonQuery(sqlCapNhatDocGia);
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
