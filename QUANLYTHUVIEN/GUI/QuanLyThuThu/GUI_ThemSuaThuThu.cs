
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.BLL;
using QUANLYTHUVIEN.DAL;
using QUANLYTHUVIEN.DTO;


namespace QUANLYTHUVIEN.GUI
{
    public partial class GUI_ThemSuaThuThu : Form
    {
        BUS_ThuThu busThuThu = new BUS_ThuThu();
        public delegate void LoadHandler();
        public event LoadHandler sendData;

        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }
        public GUI_ThemSuaThuThu(string MaThuThu, bool enable) //constructer tạo form thêm thủ thư với 1 tham số enable để ẩn nút cập nhật
        {
            InitializeComponent();
            setButton(enable);
            HienThiNamNu();
            HienThiPhanQuyen();
        }

        
         // sua 
        public GUI_ThemSuaThuThu(bool enable, string MaThuThu)
        {
            InitializeComponent();
            setButton(enable);
            HienThiNamNu();
            HienThiPhanQuyen();
            //LayThuThu();
            HienThiThuThu(MaThuThu);
        }
        

        private void setButton(bool enable)
        {
            btnThem.Enabled = enable;
            btnCapNhat.Enabled = !enable;
            btnLamMoi.Enabled = enable;
            btnThoat.Enabled = true;
        }
        
        public void HienThiThuThu(string key) // hien thi thong tin thu thu de sua thu thu
        {

            DataTable dt = busThuThu.getTimThuThuTheoMa(key);

            txtUserName.Text = dt.Rows[0][6].ToString();
            txtPassword.Text = dt.Rows[0][7].ToString();
            comboBoxPhanquyen.Text = dt.Rows[0][8].ToString();
            txtMaThuThu.Text = dt.Rows[0][0].ToString();
            txtTenThuThu.Text = dt.Rows[0][1].ToString();
            dateTimePickerNgaySinh.Value = DateTime.Parse(dt.Rows[0][2].ToString());
            if (dt.Rows[0][3].ToString() == "False")
            {
                comboBoxGioiTinh.Text = "Nữ";
            }
            else if (dt.Rows[0][3].ToString() == "True")
            {
                comboBoxGioiTinh.Text = "Nam";
            }
            txtDiaChi.Text = dt.Rows[0][4].ToString();
            txtSodt.Text = dt.Rows[0][5].ToString();
        }

        
        public void HienThiNamNu() // hien thi nam/nu cho comboboxGioiTinh
        {
            DataTable dt = new DataTable();            
            dt.Columns.Add("Gender", typeof(string)); // Cột tên giới tính (Nam/Nữ)
            dt.Columns.Add("Value", typeof(bool));     // Cột giá trị tương ứng (1/0)

            dt.Rows.Add("Nam", true);
            dt.Rows.Add("Nữ", false);

            comboBoxGioiTinh.DataSource = dt;
            comboBoxGioiTinh.DisplayMember = "Gender";
            comboBoxGioiTinh.ValueMember = "Value";
        }


        public void HienThiPhanQuyen()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Role", typeof(string));
            dt.Columns.Add ("Value", typeof(bool));

            dt.Rows.Add("admin", true);
            dt.Rows.Add("nhanvien", false);

            comboBoxPhanquyen.DataSource = dt;
            comboBoxPhanquyen.DisplayMember = "Role";
            comboBoxPhanquyen.ValueMember = "Value";
        }

        private ThuThu LayThuThu() // lay thong tin thu thu
        {
            ThuThu thuthu = new ThuThu();
            thuthu.MaThuThu = txtMaThuThu.Text;
            thuthu.TenThuThu = txtTenThuThu.Text;
            thuthu.NgaySinh = dateTimePickerNgaySinh.Value.ToShortDateString(); // chuyen doi gtri cua datetime hien tai thanh bieu dien chuoi ngay ngan tuong duong voi no
            thuthu.GioiTinh = comboBoxGioiTinh.SelectedValue != null ? comboBoxGioiTinh.SelectedValue.ToString() : string.Empty;
            // th.GioiTinh = comboBoxGioiTinh.SelectedValue.ToString(); // selectvalue: lay hoac dat gtri cua thuoc tinh thanh vien duoc chi dinh boi listcontrol.thuoc tinh valuemember // reutrn ve 1 doi tuong chua gia tri cua thanh vien cua nguon dl duoc chi dinh boi listcontrol.valuemember 
            thuthu.DiaChi = txtDiaChi.Text;
            thuthu.SoDT = txtSodt.Text;
            thuthu.UserName = txtUserName.Text;
            thuthu.PassWord = txtPassword.Text;
            thuthu.PhanQuyen = comboBoxPhanquyen.Text;
           
            return thuthu;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetTexBox();
        }

        private void ResetTexBox()
        {
            txtMaThuThu.Text = string.Empty;
            txtTenThuThu.Text = string.Empty;
            dateTimePickerNgaySinh.Value = DateTime.Now; //lam moi datetimepiker ve ngay hien tai
            comboBoxGioiTinh.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSodt.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            comboBoxPhanquyen.Text = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {           
            ThuThu th = LayThuThu();
            if (th == null) //ktra thu thu
            {
                return; // Không thực hiện tiếp nếu thông tin không hợp lệ
            }
            try
            {
                if (busThuThu.ThemThuThu(th))
                {
                    MessageBox.Show("Thêm thủ thư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTexBox();
                    sendData?.Invoke();
                }                
                else
                {
                    MessageBox.Show("Thêm thủ thư không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (BusinessLogicException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi, vui lòng kiểm tra lại thông tin. Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ThuThu th = LayThuThu();
            try
            {
                if (busThuThu.CapNhatThuThu(th) )
                {
                    MessageBox.Show("Cập nhật thủ thư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Cập nhật thủ thư không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát khỏi form ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtSodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { 
                e.Handled = true;
            }
        }
    }
}
