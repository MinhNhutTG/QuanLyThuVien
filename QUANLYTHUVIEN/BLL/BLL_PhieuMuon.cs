using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.DAL;
using QUANLYTHUVIEN.DTO;

namespace QUANLYTHUVIEN.BLL
{
    internal class BLL_PhieuMuon
    {


        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }
        DAL_QuanLyPhieuMuon DalQLPM = new DAL_QuanLyPhieuMuon();

        public DataTable LayDSPhieuMuon()
        {
            return DalQLPM.LayDSPhieuMuon();
        }

        public DataTable LayDSSachTheoMaPhieu(string key)
        {
            return DalQLPM.LayDSSachTheoMaPhieu(key);
        }
        public DataTable LayDSSachConSan()
        {
            return DalQLPM.LayDSSachConSan();
        }
        public DataTable LayThongTinPhieu(string maPhieuMuon)
        {
            return DalQLPM.LayThongTinPhieu(maPhieuMuon);
        }

        public DataTable LayDSSearchOfSach(string key)
        {
            return DalQLPM.LayDSSearchOfSach(key);
        }

        public DataTable LayDSSearchOfDocGia(string key)
        {
            return DalQLPM.LayDSSearchOfDocGia(key);
        }

        public DataTable LayChiTietPhieuMuon(string maPhieuMuon)
        {
            return DalQLPM.LayChiTietPhieuMuon(maPhieuMuon);
        }

        public DataTable Search(string key)
        {
            return DalQLPM.Search(key);
        }

        public bool Add(PhieuMuon m , List<Sach> S)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(m.MaPhieuMuon))
            {
                throw new BusinessLogicException("Mã phiếu mượn không được để trống");
            }
            if (!DalQLPM.KiemTraDocGia(m.MaDocGia))
            {
                throw new BusinessLogicException("Độc giả không tồn tại ");
            }
            if (string.IsNullOrWhiteSpace(m.MaThuThu))
            {
                throw new BusinessLogicException("Mã thủ thư không được để trống");
            }
            if (m.NgayMuon == default)
            {
                throw new BusinessLogicException("Ngày mượn không được để trống");
            }
            if (m.NgayTra == default)
            {
                throw new BusinessLogicException("Ngày trả không được để trống");
            }
            if (m.HanTra == default)
            {
                throw new BusinessLogicException("Hạn trả không được để trống");
            }
            if (m.TinhTrang != "Đang mượn" && m.TinhTrang != "Đã trả" && m.TinhTrang != "Quá hạn")
            {
                throw new BusinessLogicException("Tình trạng không hợp lệ");
            }
            if (m.SoLuong <= 0)
            {
                throw new BusinessLogicException("Số lượng phải lớn hơn 0");
            }
            if (m.NgayTra < m.NgayMuon)
            {
                throw new BusinessLogicException("Ngày trả không được nhỏ hơn ngày mượn");
            }
            if (m.HanTra < m.NgayMuon)
            {
                throw new BusinessLogicException("Hạn trả không được nhỏ hơn ngày mượn");
            }
            if (S.Count == 0)
            {
                throw new BusinessLogicException("Danh sách sách mượn không được để trống");
            }   

            // Nếu kiểm tra thành công, thêm vào cơ sở dữ liệu
            return DalQLPM.Add(m,S);
        }

        public void AddChiTietPhieu(string maphieu, string macuonsach)
        {
            DalQLPM.AddChiTietPhieu(maphieu, macuonsach);
        }

        public void UpdatePhieu(PhieuMuon m)
        {
            if (string.IsNullOrWhiteSpace(m.MaPhieuMuon))
            {
                throw new BusinessLogicException("Mã phiếu mượn không được để trống");
            }
            if (string.IsNullOrWhiteSpace(m.MaDocGia))
            {
                throw new BusinessLogicException("Mã độc giả không được để trống");
            }
            if (string.IsNullOrWhiteSpace(m.MaThuThu))
            {
                throw new BusinessLogicException("Mã thủ thư không được để trống");
            }
            if (m.NgayMuon == default)
            {
                throw new BusinessLogicException("Ngày mượn không được để trống");
            }
            if (m.NgayTra == default)
            {
                throw new BusinessLogicException("Ngày trả không được để trống");
            }
            if (m.HanTra == default)
            {
                throw new BusinessLogicException("Hạn trả không được để trống");
            }
            if (string.IsNullOrWhiteSpace(m.TinhTrang))
            {
                throw new BusinessLogicException("Tình trạng không được để trống");
            }
            if (m.NgayTra < m.NgayMuon)
            {
                throw new BusinessLogicException("Ngày trả không được nhỏ hơn ngày mượn");
            }
            if (m.HanTra < m.NgayMuon)
            {
                throw new BusinessLogicException("Hạn trả không được nhỏ hơn ngày mượn");
            }
           
            DalQLPM.UpdatePhieu(m);
        }

        public void UpdateTrangThaiPhieu(string maPhieuMuon)
        {
            DalQLPM.UpdateTrangThaiPhieu(maPhieuMuon);
        }

        public void UpdateTinhTrangSach(string maCuonSach)
        {
            DalQLPM.UpdateTinhTrangSach(maCuonSach);
        }


        public void Delete(string key)
        {
            DalQLPM.Delete(key);
        }

        public void UpdateXoaChiTietPhieu(string maPhieuMuon)
        {
            DalQLPM.UpdateXoaChiTietPhieu(maPhieuMuon);
        }
    }
}
