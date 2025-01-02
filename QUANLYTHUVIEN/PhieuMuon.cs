using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN
{
    internal class PhieuMuon
    {
        public string MaPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public DateTime HanTra { get; set; }
        public int SoLuong { get; set; }
        public string TinhTrang { get; set; }
        public float PhiPhat { get; set; }
        public string MaDocGia { get; set; }
        public string MaThuThu { get; set; }

        public PhieuMuon(string maPhieuMuon, DateTime ngayMuon, DateTime ngayTra, DateTime hanTra, int soLuong, string tinhTrang, float phiPhat, string maDocGia, string maThuThu)
        {
            MaPhieuMuon = maPhieuMuon;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
            HanTra = hanTra;
            SoLuong = soLuong;
            TinhTrang = tinhTrang;
            PhiPhat = phiPhat;
            MaDocGia = maDocGia;
            MaThuThu = maThuThu;
        }
        public PhieuMuon()
        {
            MaDocGia = string.Empty;
            MaPhieuMuon = string.Empty;
            MaThuThu = string.Empty;
            NgayMuon = DateTime.Now;
            NgayTra = DateTime.Now;
            HanTra = DateTime.Now;
            SoLuong = 0;
            TinhTrang = string.Empty;
            PhiPhat = 0;
            MaDocGia = string.Empty;
            MaThuThu = string.Empty;
        }
    }
}
