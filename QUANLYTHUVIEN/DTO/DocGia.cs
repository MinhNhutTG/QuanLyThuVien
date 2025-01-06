using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIEN.DTO
{
    public class DocGia
    {
        private string MaDocGia;
        private string TenDocGia;
        private string Lop;
        private string DiaChi;
        private string SODT;

        public string getMaDocGia()
        {
            return MaDocGia;
        }
        public void setMaDocGia(string value)
        {
            this.MaDocGia = value;
        }

        public string getTenDocGia()
        {
            return TenDocGia;
        }
        public void setTenDocGia(string value)
        {
            this.TenDocGia = value;
        }

        public string getLop()
        {
            return Lop;
        }
        public void setLop(string value)
        {
            this.Lop = value;
        }

        public string getDiaChi()
        {
            return DiaChi;
        }
        public void setDiaChi(string value)
        {
            this.DiaChi = value;
        }

        public string getSODT()
        {
            return SODT;
        }
        public void setSODT(string value)
        {
            this.SODT = value;
        }

        public DocGia()
        {
            MaDocGia = "";
            TenDocGia = "";
            Lop = "";
            DiaChi = "";
            SODT = "";
        }

        public DocGia(string maDocGia, string tenDocGia, string lop, string diaChi, string soDT)
        {
            MaDocGia = maDocGia;
            TenDocGia = tenDocGia;
            Lop = lop;
            DiaChi = diaChi;
            SODT = soDT;
        }
    }
}
