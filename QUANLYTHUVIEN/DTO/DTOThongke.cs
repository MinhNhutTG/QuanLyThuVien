using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN.DTO_QLThongke
{
   
public class ThongKe
    {    
        private string MaCuonSach;
        private string MaSach;
        private string TenSach;
        private string TinhTrang;
        private int SoLuong;
        private string MaDocGia;
        private string TenDocGia;
        private string NgayMuon;
        private string NgayTra;
        private string HanTra;
        private string PhiPhat;

        public string getMaCuonSach()
        {
            return MaCuonSach;
        }
        public void setMaCuonSach(string value)
        {
            this.MaCuonSach = value;
        }
        public string getMaSach()
        {
            return MaSach;
        }
        public void setMaSach(string value)
        {
            this.MaSach = value;
        }
        public string getTenSach()
        {
            return TenSach;
        }
        public void setTenSach(string value)
        {
            TenSach = value;
        }
        public string getTinhTrang()
        {
            return TinhTrang;
        }
        public void setTinhTrang(string value)
        {
            TinhTrang = value;
        }
        public int getSoLuong()
        {
            return SoLuong;
        }
        public void setSoLuong(int value)
        {
            SoLuong = value;
        }
        public string getMaDocGia()
        {
            return MaDocGia;
        }
        public void setMaDocGia(string value)
        {
            MaDocGia = value;
        }
        public string getTenDocGia()
        {
            return TenDocGia;
        }
        public void setTenDocGia(string value)
        {
            TenDocGia = value;
        }
        public string getNgayMuon()
        {
            return NgayMuon;
        }
        public void setNgayMuon(string value)
        {
            NgayMuon = value;
        }
        public string getNgayTra()
        {
            return NgayTra;
        }
        public void setNgayTra(string value)
        {
            NgayTra = value;
        }
        public string getHanTra()
        {
            return HanTra;
        }
        public void setHanTra(string value)
        {
            HanTra = value;
        }
        public string getPhiPhat()
        {
            return PhiPhat;
        }
        public void setPhiPhat(string value)
        {
            PhiPhat = value;
        }
        public ThongKe()
        {
            MaCuonSach = "";
            MaSach = "";
            TenSach = "";
            TinhTrang = "";
            SoLuong = 0;
            MaDocGia = "";
            TenDocGia = "";
            NgayMuon = "";
            NgayTra = "";
            HanTra = "";
            PhiPhat = "";

        }
        public ThongKe(string MaCuonSach, string MaSach, string TenSach, string TinhTrang, int SoLuong, string MaDocGia, string TenDocGia, string NgayMuon, string NgayTra, string HanTra, string PhiPhat)
        {
            MaCuonSach = MaCuonSach;
            MaSach = MaSach;
            TenSach = TenSach;
            TinhTrang = TinhTrang;
            SoLuong = SoLuong;
            MaDocGia = MaDocGia;
            TenDocGia = TenDocGia;
            NgayMuon= NgayMuon;


        }
    }
}

    

