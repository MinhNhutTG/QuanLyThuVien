using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN
{
    internal class DocGia
    {
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public string Lop { get; set; }
        public string DiaChi { get; set; }
        public string SODT { get; set; }

        public DocGia()
        {
            MaDocGia = string.Empty;
            TenDocGia = string.Empty;
            Lop = string.Empty;
            DiaChi = string.Empty;
            SODT = string.Empty;
        }

        public DocGia(string maDocGia, string tenDocGia, string lop, string diaChi, string DT)
        {
            MaDocGia = maDocGia;
            TenDocGia = tenDocGia;
            Lop = lop;
            DiaChi = diaChi;
            SODT = DT;
        }
    }
}
