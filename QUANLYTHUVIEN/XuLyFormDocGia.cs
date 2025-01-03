using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN;


namespace QUANLYTHUVIEN
{
    internal class XuLyFormDocGia
    {
        Database db;
        public XuLyFormDocGia()
        {
            db = new Database();
        }
        public DataTable LayDSDocGia()
        {
            string strSQL = " select MaDocGia, TenDocGia, Lop, DiaChi, SODT from DOCGIA";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable TimKiemDocGia(string key)
        {
            string SqlTimKiemDocGia = string.Format(@"SELECT MaDocGia, TenDocGia, Lop, DiaChi, SoDT FROM DOCGIA " +
                " WHERE MaDocGia LIKE '{0}' OR TenDocGia LIKE N'%{0}%' OR Lop LIKE N'%{0}%' OR DiaChi LIKE N'%{0}%' OR MaDocGia = '%{0}%';", key);
            DataTable dt = db.Execute(SqlTimKiemDocGia);
            return dt;
        }
        public DataTable SelectDocGia(string key)
        {
            string sql = string.Format("select * from DOCGIA where MaDocGia ='{0}'", key);
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public bool KiemTraMaDocGia(string key)
        {
            string SqlKiemTra = string.Format("Select * from DOCGIA where MaDocGia = '{0} '", key);
            DataTable dt = db.Execute(SqlKiemTra);
            return dt.Rows.Count > 0;
        }
        public void ThemDocGia(DocGia s)
        {
            string sqlThemDocGia = string.Format("Insert into DOCGIA (MaDocGia, TenDocGia, Lop, DiaChi, SoDT) " +
                                     "Values ('{0}', N'{1}', N'{2}', N'{3}', '{4}');",
                                      s.MaDocGia, s.TenDocGia, s.Lop, s.DiaChi, s.SODT);
            db.ExecuteNonQuery(sqlThemDocGia);
        }
        public void XoaDocGia(string Key)
        {
            string SqlXoaDocGia = string.Format("DELETE FROM CHI_TIET_PHIEU_MUON\nWHERE MaPhieuMuon IN (\n" +
                                                "SELECT MaPhieuMuon FROM PhieuMuon WHERE MaDocGia = '{0}'\n)\n" +
                                                "DELETE FROM PHIEUMUON\nWHERE MaDocGia = '{0}'\n" +
                                                "DELETE FROM DOCGIA\nWHERE MaDocGia = '{0}'", Key);
            db.ExecuteNonQuery(SqlXoaDocGia);
        }

        public void CapNhatDocGia(DocGia dg)
        {
            string sqlCapNhatDocGia = string.Format(
                "UPDATE DOCGIA SET " +
                "TenDocGia = N'{0}', Lop = N'{1}', DiaChi = N'{2}', SoDT = N'{3}' " +
                "WHERE MaDocGia = '{4}';",
                dg.TenDocGia, dg.Lop, dg.DiaChi, dg.SODT, dg.MaDocGia
            );
            db.ExecuteNonQuery(sqlCapNhatDocGia);
        }

    }
}
