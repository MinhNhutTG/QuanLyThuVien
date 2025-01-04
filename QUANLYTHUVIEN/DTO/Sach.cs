using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN.DTO
{
    public class Sach
    {
        private string MaCuonSach;
        private string MaSach;
        private string TenSach;
        private string TacGia;
        private string NamXuatBan;
        private string NhaXuatBan;
        private decimal Gia;
        private string Mota;
        private string TinhTrang;
        private int SoLuong;
        private string HinhAnh;
        private string MaTheLoai;

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

        public string getTacGia()
        {
            return TacGia;
        }
        public void setTacGia(string value)
        {
            TacGia = value;
        }

        public string getNamXuatBan()
        {
            return NamXuatBan;
        }
        public void setNamXuatBan(string value)
        {
            NamXuatBan = value;
        }

        public string getNhaXuatBan()
        {
            return NhaXuatBan;
        }
        public void setNhaXuatBan(string value)
        {
            NhaXuatBan = value;
        }

        public decimal getGia()
        {
            return Gia;
        }
        public void setGia(decimal value)
        {
            Gia = value;
        }

        public string getMota()
        {
            return Mota;
        }
        public void setMota(string value)
        {
            Mota = value;
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

        public string getHinhAnh()
        {
            return HinhAnh;
        }
        public void setHinhAnh(string value)
        {
            HinhAnh = value;
        }

        public string getMaTheLoai()
        {
            return MaTheLoai;
        }
        public void setMaTheLoai(string value)
        {
            MaTheLoai = value;
        }
        public Sach()
        {
            MaCuonSach = "";
            MaSach = "";
            TenSach = "";
            TacGia = "";
            NamXuatBan = "";
            NhaXuatBan = "";
            Gia = 0;
            Mota = "";
            TinhTrang = "";
            SoLuong = 0;
            HinhAnh = "";
            MaTheLoai = "";
        }
        public Sach(string maCuonSach, string maSach, string tenSach, string tacGia, string namXuatBan, string nhaXuatBan, decimal gia, string mota, string tinhTrang, int soLuong, string hinhAnh, string maTheLoai)
        {
            MaCuonSach = maCuonSach;
            MaSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
            NamXuatBan = namXuatBan;
            NhaXuatBan = nhaXuatBan;
           
            Gia = gia;
            Mota = mota;
            TinhTrang = tinhTrang;
            SoLuong = soLuong;
            HinhAnh = hinhAnh;
            MaTheLoai = maTheLoai;
        }
    }
}
