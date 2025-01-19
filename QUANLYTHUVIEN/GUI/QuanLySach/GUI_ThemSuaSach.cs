using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QUANLYTHUVIEN.BLL;
using QUANLYTHUVIEN.DTO;




namespace QUANLYTHUVIEN.GUI
{
    

    public partial class GUI_ThemSuaSach : Form
    {

        //... Khai bao bien
        BLL_Sach busSach = new BLL_Sach();
        private string PATH = AppDomain.CurrentDomain.BaseDirectory;
        private string duongDanAnh = string.Empty;
        public delegate void LoadHandler();
        public event LoadHandler sendData;

        public class BusinessLogicException : Exception
        {
             public BusinessLogicException(string message) : base(message) { }
        }

        public GUI_ThemSuaSach()  // Constructer tao form them sach voi 1 tham so enable de an nut cap nhat
        {
            InitializeComponent();
        }
        public GUI_ThemSuaSach(bool enable)  // Constructer tao form them sach voi 1 tham so enable de an nut cap nhat
        {
            InitializeComponent();
            setButton(enable);    
            HienThiTheLoai();
            cbBTrangThai.SelectedIndex = 0;
            
        }
        public GUI_ThemSuaSach(bool enable, string MaCuonSach)  // Constructer tao form su sach voi 2 tham so enable de an nut them va MaCuonSach de hien chi tiet
        {
            InitializeComponent();
            setButton(enable);
            HienThiTheLoai();
            HienThiChiTietSach(MaCuonSach);
        }
      
        private void setButton(bool enable)   // Set cho button them va cap nhat khac nhau ( btnThem hien thi btnCapNhan mo  va nguoc lai)
        {
            btnThem.Enabled = enable;
            btnCapNhat.Enabled = !enable;
            btnLamMoi.Enabled = enable;
            btnThoat.Enabled = true;
        }
        private void HienThiChiTietSach(string key)     
        {
            DataTable dt = busSach.TiemKiemSachTheoMaCuonSach(key);
            txtMaCuonSach.Text = dt.Rows[0][0].ToString();         
            txtMaSach.Text = dt.Rows[0][1].ToString();
            txtTenSach.Text = dt.Rows[0][2].ToString();
            txtTacGia.Text = dt.Rows[0][3].ToString();
            txtNamXuatBan.Text = dt.Rows[0][4].ToString();
            txtNhaXuatBan.Text = dt.Rows[0][5].ToString();
            txtGiaSach.Text = dt.Rows[0][6].ToString();
            richTextMoTa.Text = dt.Rows[0][7].ToString();
            cbBTrangThai.Text = dt.Rows[0][8].ToString();
            numericSoLuong.Value = int.Parse(dt.Rows[0][9].ToString());
            if (!string.IsNullOrEmpty(dt.Rows[0][10].ToString()))
            {
                pictureSach.Image = Image.FromFile(PATH + dt.Rows[0][10].ToString());
                duongDanAnh =  dt.Rows[0][10].ToString();
            }
            cbBTheLoai.Text = dt.Rows[0][11].ToString();
        }
        private void HienThiTheLoai()            // Ham Nay Hien Thi Cac the loai cua sach
        {
            DataTable dt = busSach.GetTheLoai();       // Goi den Ham Lay The Loai Sach de tra ve 1 DataTable The loai
            cbBTheLoai.DataSource = dt;
            cbBTheLoai.DisplayMember = "TenTheLoai";
            cbBTheLoai.ValueMember = "MaTheLoai";
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = PATH + "Asset\\Image Books";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pictureSach.Image = Image.FromFile(openfile.FileName);
                duongDanAnh = "Asset\\Image Books\\" + Path.GetFileName(openfile.FileName); 
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }
        private void ResetTextBox()         // Ham nay de Reset lai cac textbox 
        {
            txtMaSach.Clear();
            txtMaCuonSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtGiaSach.Text = "0";
            cbBTheLoai.SelectedIndex = 0;
            txtNamXuatBan.Clear();
            txtNhaXuatBan.Clear();
            numericSoLuong.Value = numericSoLuong.Minimum;
            cbBTrangThai.SelectedIndex = -1;
            pictureSach.Image = null;
            richTextMoTa.Text = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach s = LaySach();
            try
            {

                if (busSach.ThemSach(s))
                {
                    
                    ResetTextBox();
                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Thêm khong sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (BLL_PhieuMuon.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private Sach LaySach()                                   // Function nay tao ra 1 Sach dua vao class Sach va gan cac txt vao tung thuoc tinh de tra ve 1 cuon sach
        {                                                        //Se lam gon di cac tham so truyen vao
            Sach sach = new Sach();
            sach.setMaCuonSach(txtMaCuonSach.Text);
            sach.setMaSach(txtMaSach.Text);
            sach.setTenSach(txtTenSach.Text);
            sach.setTacGia(txtTacGia.Text);
            sach.setNamXuatBan(txtNamXuatBan.Text);
            sach.setNhaXuatBan(txtNhaXuatBan.Text);
            if (txtGiaSach.Text == "0")
            {
                sach.setGia(0);
            }
            sach.setGia(decimal.Parse(txtGiaSach.Text));
            sach.setMota(richTextMoTa.Text);
            sach.setTinhTrang(cbBTrangThai.SelectedItem.ToString());
            sach.setSoLuong(Convert.ToInt32(numericSoLuong.Value));
            sach.setHinhAnh(duongDanAnh);                                                           // gan bien duongDanAnh duoc khai bao global
            sach.setMaTheLoai(cbBTheLoai.SelectedValue.ToString());

            return sach;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Sach s = LaySach();
            try
            {
                if (busSach.CapNhatSach(s))
                {
                    MessageBox.Show("Cập nhật sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Cập nhật sách không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (BLL_PhieuMuon.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát form ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmQuanLySach_ThemSach_Load(object sender, EventArgs e)
        {
            
        }

        private void txtGiaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
