using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN
{
    internal class XuLyFormThuThu
    {
        Database db;
        public XuLyFormThuThu()
        {
            db = new Database();
        }

        
        public DataTable LayDSThuThu() //thực hiện chức năng lấy danh sách thủ thư từ cơ sở dữ liệu
        {
            string strSQL = "SELECT MaThuTHu, TenThuThu, NgaySinh, GioiTinh, DiaChi, SoDT, TAI_KHOAN.UserName, TAI_KHOAN.PassWord, TAI_KHOAN.PhanQuyen FROM THU_THU, TAI_KHOAN WHERE THU_THU.UserName = TAI_KHOAN.UserName";
            DataTable dt = db.Execute(strSQL);
            return dt; //trả về dt, một DataTable chứa danh sách thủ thư, bao gồm cả thông tin cá nhân và thông tin tài khoản


        }
        public DataTable TimThuThuTheoMa(string key)
        {
            string sqlTimThuThu = string.Format("SELECT TT.*,  TK.PassWord, TK.PhanQuyen  FROM THU_THU TT" +
                " JOIN TAI_KHOAN TK ON TT.Username = TK.Username where TT.MaThuThu = '{0}'", key);
            DataTable dt = db.Execute(sqlTimThuThu);
            return dt;
        }

      

        public DataTable Timkiem(string key)
        {
            
             string SqlTimkiem = string.Format(@"select MaThuThu , TenThuThu , NgaySinh , GioiTinh , DiaChi , SoDT, TAI_KHOAN.UserName ,TAI_KHOAN.PassWord, TAI_KHOAN.PhanQuyen
                                                 FROM THU_THU JOIN TAI_KHOAN ON THU_THU.UserName = TAI_KHOAN.UserName 
                                                 WHERE MaThuThu LIKE N'%{0}%' OR TenThuThu LIKE N'%{0}%' OR DiaChi LIKE N'%{0}%' OR SoDT LIKE N'%{0}%' OR TAI_KHOAN.UserName LIKE N'%{0}%' ", key);
             DataTable dt = db.Execute(SqlTimkiem);
             return dt; 
            
        }

         

        
        public bool KiemtraThuThu(string userName, string passWord, string phanQuyen, string maThuThu, string tenThuThu, string ngaySinh, string gioiTinh, string diaChi, string soDt )
        { //thực hiện kiểm tra trong cơ sở dữ liệu xem có tồn tại thủ thư với thông tin thỏa mãn điều kiện hay không
            string SqlKiemtra = string.Format("SELECT * FROM THU_THU JOIN TAI_KHOAN ON THU_THU.UserName = TAI_KHOAN.UserName " +
                "WHERE MaThuThu LIKE N'%{0}%' OR TenThuThu LIKE N'%{0}%' OR DiaChi LIKE N'{0}' OR SoDT LIKE N'{0}' OR TAI_KHOAN.UserName LIKE N'{0}' ", maThuThu, tenThuThu, diaChi, soDt , userName, passWord, phanQuyen ); //Truy vấn này tham chiếu tới bảng THU_THU và bảng TAI_KHOAN với điều kiện
            DataTable dt = db.Execute(SqlKiemtra); // thu thi lenh sqlkiemtra
            return dt.Rows.Count > 0; //Nếu bảng DataTable trả về có dòng dữ liệu (Rows.Count > 0), nghĩa là có ít nhất một kết quả thỏa mãn truy vấn.
        }


        
        public void ThemThuThu(ThuThu th) { 
                string SqlThemTaiKhoan = string.Format("INSERT INTO TAI_KHOAN( UserName, PassWord, PhanQuyen) " +
                                            " VALUES(N'{0}', '{1}', N'{2}') ", th.UserName, th.PassWord, th.PhanQuyen);
            
            string SqlThemThuThu  = string.Format(" INSERT INTO THU_THU( MaThuThu, TenThuThu, NgaySinh, GioiTinh, DiaChi, SoDT ,UserName) " +
                " VALUES(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}' , '{6}')", th.MaThuThu, th.TenThuThu, th.NgaySinh, th.GioiTinh, th.DiaChi,th.SoDT,th.UserName);

            db.ExecuteNonQuery(SqlThemTaiKhoan); //thuc thi lenh sql
            db.ExecuteNonQuery(SqlThemThuThu); //thuc thi lenh sql

        }

        
        // cap nhat thu thu
        public void CapNhatThuThu(ThuThu th)
        {
            string SqlSuaTaiKhoan = string.Format("UPDATE TAI_KHOAN SET  PassWord = N'{0}', PhanQuyen = N'{1}' where UserName = '{2}'",  th.PassWord, th.PhanQuyen,th.UserName);

            string SqlSuaThuThu = string.Format("UPDATE THU_THU SET TenThuThu = N'{0}', NgaySinh = N'{1}', GioiTinh = N'{2}', DiaChi = N'{3}', SoDT = N'{4}' where MaThuThu = '{5}'", th.TenThuThu, th.NgaySinh, th.GioiTinh, th.DiaChi, th.SoDT,th.MaThuThu);

            db.ExecuteNonQuery(SqlSuaTaiKhoan);
            db.ExecuteNonQuery(SqlSuaThuThu);
        }
        

      
        public void XoaThuThu(string maThuThu, string userName)
        {   
            string SqlXoaThuThu = string.Format("DELETE FROM CHI_TIET_PHIEU_MUON " +
                "WHERE MaPhieuMuon IN(SELECT MaPhieuMuon FROM PHIEUMUON WHERE MaThuThu = '{0}');" +
                "DELETE FROM PHIEUMUON " +
                "WHERE PHIEUMUON.MaThuThu = '{0}';" +
                "DELETE FROM THU_THU " +
                "WHERE MaThuThu = '{0}';" +
                "DELETE FROM TAI_KHOAN WHERE TAI_KHOAN.UserName = '{1}'; ", maThuThu, userName);
            db.ExecuteNonQuery(SqlXoaThuThu);
            
        }
        
    }
}
