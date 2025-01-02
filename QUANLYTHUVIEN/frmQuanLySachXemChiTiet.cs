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
    public partial class frmQuanLySachXemChiTiet : Form
    {
        private string PATH = AppDomain.CurrentDomain.BaseDirectory ;          //Dan duong dan chua thu muc
        public frmQuanLySachXemChiTiet()
        {
            InitializeComponent();
        }
        public frmQuanLySachXemChiTiet(string key)                      //Constructer tao form chi tiet voi string key-( 
        {
            InitializeComponent();
            HienThiChiTiet(key);
        }

        public void HienThiChiTiet(string key)
        {
            XuLyFormSach xuly = new XuLyFormSach();
            DataTable dt = xuly.TimSachTheoMaCuonSach(key);
            txtMaCuonSach.Text = dt.Rows[0][0].ToString();
            txtMaSach.Text = dt.Rows[0][1].ToString();
            txtTenSach.Text = dt.Rows[0][2].ToString();
            txtTacGia.Text = dt.Rows[0][3].ToString();
            txtNamXuatBan.Text = dt.Rows[0][4].ToString();
            txtNhaXuatBan.Text = dt.Rows[0][5].ToString();
            txtGiaSach.Text = dt.Rows[0][6].ToString();
            txtMoTa.Text = dt.Rows[0][7].ToString();
            txtTrangThai.Text = dt.Rows[0][8].ToString();
            txtSoLuong.Text = dt.Rows[0][9].ToString();
            if (!string.IsNullOrEmpty(dt.Rows[0][10].ToString()))
            {
                pictureChiTiet.Image = Image.FromFile(PATH + dt.Rows[0][10].ToString());
            }
            //"C:\Users\tuhin\Desktop\WorkSpace\QUANLYTHUVIEN\QUANLYTHUVIEN\asset\DacNhanTam.jpg"
            txtTheLoai.Text= dt.Rows[0][11].ToString();
        }
        private void frmQuanLySachXemChiTiet_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
