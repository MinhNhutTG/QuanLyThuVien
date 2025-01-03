using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN
{
    public partial class FormThemThuThu : Form
    {
        XuLyFormThuThu x = new XuLyFormThuThu();
        public delegate void LoadHandler();
        public event LoadHandler sendData;
        public FormThemThuThu(string MaThuThu, bool b )
        {
            InitializeComponent();
            HienThiNamNu();
            SetButton(b);
           
            
        }
        
        // danh cho phan sua lay thong tin
        public FormThemThuThu(bool  b, string MaThuThu)
        {
            InitializeComponent();
            SetButton(b);
            HienThiNamNu();
            HienThiThuThu(MaThuThu);
            
            LayThongTinThuThu();
                      
        }
  
        
        // set cac button them hien thi cap nhat an va nguoc lai
        public void SetButton(bool b)
        {
            btnThem.Enabled = b ;
            btnCapNhat.Enabled = !b;
            btnLamMoi.Enabled = b;
            btnThoat.Enabled = true;
            
        }

        public void HienThiThuThu(string key)
        {
            XuLyFormThuThu XuLyFormtt = new XuLyFormThuThu();
            DataTable dt = XuLyFormtt.TimThuThuTheoMa(key);

            txtUserName.Text = dt.Rows[0][6].ToString();
            txtPassword.Text = dt.Rows[0][7].ToString();
            comboBoxPhanquyen.Text = dt.Rows[0][8].ToString();
            txtMaThuThu.Text = dt.Rows[0][0].ToString();
            txtTenThuThu.Text = dt.Rows[0][1].ToString();
            dateTimePickerNgaySinh.Value = DateTime.Parse(dt.Rows[0][2].ToString());
            comboBoxGioiTinh.Text = dt.Rows[0][3].ToString();
            txtDiaChi.Text = dt.Rows[0][4].ToString();
            txtSodt.Text = dt.Rows[0][5].ToString();


        }

        // hien thi cobobox nam/nu
        public void HienThiNamNu()
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
        // hien thi cho combobox phan quyen
       
        private ThuThu LayThongTinThuThu() // lay thong tin thu thu tu form
        {
            ThuThu th = new ThuThu();
            th.MaThuThu = txtMaThuThu.Text;
            th.TenThuThu = txtTenThuThu.Text;
            th.NgaySinh = dateTimePickerNgaySinh.Value.ToShortDateString(); // chuyen doi gtri cua datetime hien tai thanh bieu dien chuoi ngay ngan tuong duong voi no
            th.GioiTinh = comboBoxGioiTinh.SelectedValue != null ? comboBoxGioiTinh.SelectedValue.ToString() : string.Empty;
            // th.GioiTinh = comboBoxGioiTinh.SelectedValue.ToString(); // selectvalue: lay hoac dat gtri cua thuoc tinh thanh vien duoc chi dinh boi listcontrol.thuoc tinh valuemember // reutrn ve 1 doi tuong chua gia tri cua thanh vien cua nguon dl duoc chi dinh boi listcontrol.valuemember 
            th.DiaChi = txtDiaChi.Text;
            th.SoDT = txtSodt.Text;
            th.UserName = txtUserName.Text;
            th.PassWord = txtPassword.Text;
            th.PhanQuyen = comboBoxPhanquyen.Text;
            return th;
        }


        private bool checkFormRong()
        {
            if (string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(comboBoxPhanquyen.Text) ||
                string.IsNullOrEmpty(txtMaThuThu.Text) ||
                string.IsNullOrEmpty(txtTenThuThu.Text) ||
                string.IsNullOrEmpty(dateTimePickerNgaySinh.Text) ||
                string.IsNullOrEmpty(comboBoxGioiTinh.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtSodt.Text))
            {
                return false;
            }
            return true;
        }



        // Them trong button FormThemThuThu
        private void btnThem_Click(object sender, EventArgs e)
        {
          try
            {
                if (checkFormRong())
                {
                    ThuThu thuthu = LayThongTinThuThu();  //lấy thông tin từ các TextBox, ComboBox, DateTimePicker trên giao diện và tạo một đối tượng ThuThu.
                    XuLyFormThuThu th = new XuLyFormThuThu(); // Tạo đối tượng ThuThu từ thông tin nhập vào
                    string ngaysinh = dateTimePickerNgaySinh.Value.ToShortTimeString();
                    if (!th.KiemtraThuThu(txtUserName.Text, txtPassword.Text, comboBoxPhanquyen.SelectedItem.ToString(), txtMaThuThu.Text, txtTenThuThu.Text, ngaysinh, comboBoxGioiTinh.SelectedValue.ToString(), txtDiaChi.Text, txtSodt.Text)) // cái dòng trong đây mày phải truyền vào hết các textbox 
                    { //Kiểm tra xem thủ thư có tồn tại trong cơ sở dữ liệu hay chưa //Nếu KiemtraThuThu trả về false: Thủ thư chưa tồn tại → Tiến hành thêm mới, Nếu true: Thủ thư đã tồn tại → Thông báo lỗi

                        th.ThemThuThu(thuthu); //Gọi phương thức thêm thủ thư mới từ lớp xử lý XuLyFormThuThu. Đối tượng thuthu được truyền vào để thêm thông tin vào cơ sở dữ liệu

                        MessageBox.Show("Da Them Thu Thu");

                    }
                    else
                    {
                        MessageBox.Show("Ma Thu Thu ton tai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (sendData != null)
                    {
                        sendData(); //Một delegate (hoặc event) được sử dụng để thông báo cập nhật dữ liệu lên giao diện hoặc cập nhật danh sách sau khi thêm thành công
                    }
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

        // cap nhat nut button trong FormThemThuThu
        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                if (checkFormRong())
                {
                    ThuThu th = LayThongTinThuThu(); //lay thong tin thu thu tu form 
                    XuLyFormThuThu Capnhat = new XuLyFormThuThu(); //tao doi tuong xu ly
                    string ngaysinh = dateTimePickerNgaySinh.Value.ToShortTimeString();
                    if (Capnhat.KiemtraThuThu(txtUserName.Text, txtPassword.Text, comboBoxPhanquyen.Text, txtMaThuThu.Text, txtTenThuThu.Text, ngaysinh, comboBoxGioiTinh.SelectedValue.ToString(), txtDiaChi.Text, txtSodt.Text))
                    {
                        Capnhat.CapNhatThuThu(th);
                        MessageBox.Show("Đã cập nhật thủ thư");
                    }           
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.YesNo);
                }
                if (sendData != null)
                {
                    sendData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi, vui lòng kiểm tra lại thông tin. Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        /*
         ThuThu th = LayThongTinThuThu(); //lay thong tin thu thu tu form 
                    XuLyFormThuThu Capnhat = new XuLyFormThuThu(); //tao doi tuong xu ly
                    string ngaysinh = dateTimePickerNgaySinh.Value.ToShortTimeString();
                    if (Capnhat.KiemtraThuThu(txtUserName.Text, txtPassword.Text, comboBoxPhanquyen.Text, txtMaThuThu.Text, txtTenThuThu.Text, ngaysinh, comboBoxGioiTinh.SelectedValue.ToString(), txtDiaChi.Text, txtSodt.Text))
                    {
                        Capnhat.CapNhatThuThu(th);
                        MessageBox.Show("Đã cập nhật thủ thư");
                    }
                   if (sendData != null)
                   {
                       sendData();
                   }
                   */

        // lam moi cac texbox trong formthemthuthu
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaThuThu.Text = string.Empty;
            txtTenThuThu.Text = string.Empty;
            dateTimePickerNgaySinh.Value = DateTime.Now; //lam moi datetimepiker ve ngay hien tai //(datetimepickerNgaySinh.ShowCheckBox = true; datetimepickerNgaysinh.Checked = false; (sau khi thiet lap showcheckbox true thi nguoi dung co the bo chon checkbox va khong can chon ngay))
            comboBoxGioiTinh.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSodt.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            comboBoxPhanquyen.Text = string.Empty;
        }

        // thoat khoi form them thuthu
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon roi khoi form nay ?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result  == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
