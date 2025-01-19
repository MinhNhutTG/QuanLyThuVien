using QUANLYTHUVIEN.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN
{
    public partial class GUI_XemChiTietPhieu : Form
    {
        BLL_PhieuMuon pm = new BLL_PhieuMuon();
        public GUI_XemChiTietPhieu(string key)
        {

            InitializeComponent();
            DataTable dtPM = pm.LayThongTinPhieu(key);
            DataTable dtS = pm.LayDSSachTheoMaPhieu(key);
            HienThiPhieuMuon(dtPM);
            HienThiSach(dtS);

        }
        public void HienThiPhieuMuon(DataTable dtPM)
        {
            txtMaphieumuon.Text = dtPM.Rows[0]["MaPhieuMuon"].ToString();
            dtpNgaymuon.Text = dtPM.Rows[0]["NgayMuon"].ToString();
            dtpNgaytra.Text = dtPM.Rows[0]["NgayTra"].ToString();
            dtpHantra.Text = dtPM.Rows[0]["HanTra"].ToString();
            nudSoluong.Text = dtPM.Rows[0]["SoLuong"].ToString();
            cboTinhtrang.Text = dtPM.Rows[0]["TinhTrang"].ToString();
            txtPhiphat.Text = dtPM.Rows[0]["PhiPhat"].ToString();
            txtMadocgia.Text = dtPM.Rows[0]["MaDocGia"].ToString();
            txtMathuthu.Text = dtPM.Rows[0]["MaThuThu"].ToString();
        }

        public void HienThiSach(DataTable dtS)
        {
            lsvCTPhieuMuon.Items.Clear();
            for (int i = 0; i < dtS.Rows.Count; i++)
            {
                ListViewItem item = lsvCTPhieuMuon.Items.Add(dtS.Rows[i][0].ToString());
                for (int j = 1; j < dtS.Columns.Count; j++) // Duyệt theo số lượng cột có trong DataTable
                {
                    item.SubItems.Add(dtS.Rows[i][j].ToString());
                }
            }
        }


    }
}
