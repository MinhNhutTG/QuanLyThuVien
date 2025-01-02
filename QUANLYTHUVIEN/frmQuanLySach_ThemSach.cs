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

namespace QUANLYTHUVIEN
{
    public partial class frmQuanLySach_ThemSach : Form
    {
        private string PATH = AppDomain.CurrentDomain.BaseDirectory;
        private string duongDanAnh = string.Empty;
        public delegate void LoadHandler();
        public event LoadHandler sendData;
       
        public frmQuanLySach_ThemSach(bool enable)  // Constructer tao form them sach voi 1 tham so enable de an nut cap nhat
        {
            InitializeComponent();
            setButton(enable);    
            HienThiTheLoai();
        }
        public frmQuanLySach_ThemSach(bool enable , string MaCuonSach)  // Constructer tao form su sach voi 2 tham so enable de an nut them va MaCuonSach de hien chi tiet
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
        public void HienThiChiTietSach(string key)      //==>> Hien thong tin chi tiet cua sach - Function nhan vao 1 key 
        {
            XuLyFormSach XuLyFormSach = new XuLyFormSach();
            DataTable dt = XuLyFormSach.TimSachTheoMaCuonSach(key);      // Goi den class xu ly va goi ham TimSachTheoMaCuonSach -> tra ve mot DataTable

            txtMaCuonSach.Text = dt.Rows[0][0].ToString();          //Gan ca thong tin chi tiet vao txt 
            txtMaSach.Text = dt.Rows[0][1].ToString();
            txtTenSach.Text = dt.Rows[0][2].ToString();
            txtTacGia.Text = dt.Rows[0][3].ToString();
            txtNamXuatBan.Text = dt.Rows[0][4].ToString();
            txtNhaXuatBan.Text = dt.Rows[0][5].ToString();
            txtGiaSach.Text = dt.Rows[0][6].ToString();
            richTextMoTa.Text = dt.Rows[0][7].ToString();
            cbBTrangThai.Text= dt.Rows[0][8].ToString();
            numericSoLuong.Value = int.Parse(dt.Rows[0][9].ToString());
            if (!string.IsNullOrEmpty(dt.Rows[0][10].ToString())) { 
                pictureSach.Image = Image.FromFile(PATH + dt.Rows[0][10].ToString());
            }
            cbBTheLoai.Text = dt.Rows[0][11].ToString();
        }
        public void HienThiTheLoai()            // Ham Nay Hien Thi Cac the loai cua sach
        {
            XuLyFormSach Sach = new XuLyFormSach();
            DataTable dt = Sach.LayTheLoai();           // Goi den Ham Lay The Loai Sach de tra ve 1 DataTable The loai
            cbBTheLoai.DataSource = dt;
            cbBTheLoai.DisplayMember = "TenTheLoai";        
            cbBTheLoai.ValueMember = "MaTheLoai";
        }
        private void ResetTextBox()         // Ham nay de Reset lai cac textbox 
        {
            txtMaSach.Clear();
            txtMaCuonSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtGiaSach.Clear();
            cbBTheLoai.SelectedIndex = 0;
            txtNamXuatBan.Clear();
            txtNhaXuatBan.Clear();
            numericSoLuong.Value = numericSoLuong.Minimum;
            cbBTrangThai.SelectedIndex = -1;
            pictureSach.Image = null;
            richTextMoTa.Text = null;
        }
        private bool checkFormRong()   //Ham Nay Kiem Tra Form co rong hay khong
        {
            if (string.IsNullOrEmpty(txtMaSach.Text) ||
                string.IsNullOrEmpty(txtMaCuonSach.Text) ||
                string.IsNullOrEmpty(txtTenSach.Text) ||
                string.IsNullOrEmpty(txtTacGia.Text)||
                string.IsNullOrEmpty(txtNamXuatBan.Text)||
                string.IsNullOrEmpty(txtNhaXuatBan.Text)||
                string.IsNullOrEmpty(cbBTheLoai.Text) ||
                string.IsNullOrEmpty(txtGiaSach.Text) ||
                string.IsNullOrEmpty(cbBTrangThai.Text))
            {
                return false;
            }
            return true;
        }
       

        private void btnThemAnh_Click(object sender, EventArgs e)               // Ham nay xu ly khi nhan vao nut them anh se hien ra Dialog 
        {
            
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = PATH + "Asset\\Image Books" ;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pictureSach.Image = Image.FromFile(openfile.FileName);
                duongDanAnh= "Asset\\Image Books\\"+Path.GetFileName(openfile.FileName);         // gan duong dan vao bien duongDanAnh duoc khai bao global 
            }

        }

        private Sach LaySach()                                   // Function nay tao ra 1 Sach dua vao class Sach va gan cac txt vao tung thuoc tinh de tra ve 1 cuon sach
        {                                                        //Se lam gon di cac tham so truyen vao
            Sach sach = new Sach();
            sach.MaCuonSach = txtMaCuonSach.Text;
            sach.MaSach = txtMaSach.Text;
            sach.TenSach = txtTenSach.Text;
            sach.TacGia = txtTacGia.Text;
            sach.NamXuatBan = txtNamXuatBan.Text;
            sach.NhaXuatBan = txtNhaXuatBan.Text;
            sach.Gia = decimal.Parse(txtGiaSach.Text);
            sach.Mota = richTextMoTa.Text;
            sach.TinhTrang = cbBTrangThai.SelectedItem.ToString();
            sach.SoLuong = Convert.ToInt32(numericSoLuong.Value);
            sach.HinhAnh = duongDanAnh;                                                             // gan bien duongDanAnh duoc khai bao global
            sach.MaTheLoai = cbBTheLoai.SelectedValue.ToString();

            return sach;
        }
        private void btnThem_Click(object sender, EventArgs e)              //Ham Them Sach
        {
            try                                                             //Su dung try catch de an cac loi ngoai le
            {
                if (checkFormRong())                                         //Kiem tra form co rong khong
                {
                        Sach s = LaySach();
                        XuLyFormSach XuLySach = new XuLyFormSach();
                        if (!XuLySach.KiemTraMaSach(txtMaCuonSach.Text))        //Kiem tra sach co ton tai chua
                        {

                            XuLySach.ThemSach(s);                               //Truyen vao cuon sach
                            DialogResult dg = MessageBox.Show("Đã thêm thành công cuốn sách " + txtTenSach.Text + "!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            sendData?.Invoke();                                 //Kiem tra event co nut ko , 

                            if (dg == DialogResult.OK)
                            {
                                ResetTextBox();
                            }
                        }
                        else
                        {
                            DialogResult dg = MessageBox.Show("Cuốn sách này đã tồn tại không thể thêm!!!", "Thông báo", MessageBoxButtons.YesNo);
                            if (dg == DialogResult.Yes)
                            {
                                txtMaCuonSach.Clear();
                                txtMaCuonSach.Focus();
                            }
                        }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.YesNo);
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Đã có lỗi, vui lòng kiểm tra lại thông tin. Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }



        private void btnCapNhat_Click(object sender, EventArgs e)  // Function Cap Nhat Sach 
        {
            try                                        //Su dung try catch de an cac loi ngoai le
            {
                if (checkFormRong())                        //Kiem tra form rong hay k
                {
                    XuLyFormSach XulyCapNhat = new XuLyFormSach();
                    Sach s = LaySach();                                 
                    XulyCapNhat.CapNhatSach(s);                             
                    DialogResult dg = MessageBox.Show("Cập nhật thành công " + txtTenSach.Text + " !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    sendData?.Invoke();
                  
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.YesNo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi, vui lòng kiểm tra lại thông tin. Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void frmQuanLySach_ThemSach_Load(object sender, EventArgs e)  //Khi form Load  se focus vao txtMaCuonSach
        {
            txtMaCuonSach.Focus();
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }


        private void btnThoat_Click(object sender, EventArgs e)                                          // Nút thoát chương trình
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát form ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes) {
                this.Close();
               
            }
        }

      

       
    }
}
