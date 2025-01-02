using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN
{
    public class Sach
    {
        public string MaCuonSach { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string NamXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public decimal Gia { get; set; }
        public string Mota { get; set; }
        public string TinhTrang { get; set; }
        public int SoLuong { get; set; }
        public string HinhAnh { get; set; }
        public string MaTheLoai { get; set; }
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
