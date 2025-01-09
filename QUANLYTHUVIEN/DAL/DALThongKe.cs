using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYTHUVIEN.BUS;

namespace QUANLYTHUVIEN.DAL
{


    internal class DALThongKe:DBConnect
    {
            DBConnect db= new DBConnect();
         
            public DataTable ThongKeSachDangMuon()
            {
                string strSQL = "select MaSach, TenSach, TinhTrang from SACH where TinhTrang = N'Đang mượn'";
                DataTable dt = db.Execute(strSQL);
                return dt;

            }
            public DataTable ThongKeSachConTrongKho()
            {
                string strSQL = "select MaSach, TenSach, TinhTrang from SACH where TinhTrang = N'Còn sẵn'";
                DataTable dt = db.Execute(strSQL);
                return dt;
            }
            public DataTable ThongKeMuonTrongNgay(string key)
            {
                string sql = string.Format("SELECT MaPhieuMuon, NgayMuon, NgayTra, MaDocGia, TinhTrang" +
                    "\r\nFROM PHIEUMUON" +
                    "\r\nWHERE CONVERT(DATE, NgayMuon) = CONVERT(DATE, '{0}');", key);

                DataTable dt = db.Execute(sql);
                return dt;
            }
            public DataTable ThongKeTrongTuan()
            {
                string sql = string.Format("SELECT MaPhieuMuon, NgayMuon, NgayTra, MaDocGia FROM PHIEUMUON WHERE NgayMuon BETWEEN DATEADD(DAY, -7, CAST(GETDATE() AS DATE)) AND CAST(GETDATE() AS DATE); ");
                DataTable dt = db.Execute(sql);
                return dt;
            }

            public DataTable ThongKeTrongThang()
            {
                string sql = string.Format("SELECT MaPhieuMuon, NgayMuon, NgayTra, MaDocGia FROM PHIEUMUON WHERE NgayMuon BETWEEN DATEADD(DAY, -30, CAST(GETDATE() AS DATE)) AND CAST(GETDATE() AS DATE);");
                DataTable dt = db.Execute(sql);
                return dt;
            }
            public DataTable ThongKeDangMuon()
            {
                string sql = string.Format("select MaPhieuMuon, NgayMuon, NgayTra, MaDocGia from PHIEUMUON where TinhTrang = N'Đang mượn'");
                DataTable dt = db.Execute(sql);
                return dt;
            }
            public DataTable ThongKeViPham()
            {
                string sql = string.Format("SELECT MaPhieuMuon, NgayMuon, NgayTra, MaDocGia, HanTra" +
                    ", PhiPhat FROM PHIEUMUON where PhiPhat > 0.0");
                DataTable dt = db.Execute(sql);
                return dt;
            }

        }
    }


