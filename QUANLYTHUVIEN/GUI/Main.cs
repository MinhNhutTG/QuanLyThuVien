using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.DTO;
using QUANLYTHUVIEN.BUS;

namespace QUANLYTHUVIEN.GUI
{
    public partial class Main : Form
    {
        public string MaNhanVienDangSuDungHeThong {  get; set; }
        public Main()
        {
            InitializeComponent();
            MainStart();
            setButton(true, true);
        }

        public Main(string quyen , string maNhanVien)
        {
            InitializeComponent();
            MainStart();
            
            if (quyen == "admin") {
                setButton(true, true);
            }
            else if (quyen == "nhanvien")
            {
                setButton(false, true);
            }
            MaNhanVienDangSuDungHeThong = maNhanVien;
           
        }

        private void MainStart()
        {

            foreach (Form f in this.MdiChildren)  // Chạy for từng form con 
            {
                if (f.Name == "Main_Picture")  //kiểm tra nếu là form QuanLySachForm thì kích hoạt form khi nó đã được mở
                {
                    f.Activate();  // kích hoạt nè
                    return;     // return này là dừng lại để tránh tạo form nữa 
                }
            }
            Form frm = new mainPicture();        // nếy mà chưa có form dc tạo ra sẳn thì sẽ tạo form mới nè

            frm.MdiParent = this;  //set cho form là form con

            frm.Dock = DockStyle.Fill;  // form con lấp đầy không gia của form cha 
            frm.Show();
        }

        private void setButton(bool Admin , bool NhanVien)
        {
            //btnMoFormQLSACH.Enabled = NhanVien;
            //btnMoFormQLPhieu.Enabled = NhanVien;
            //btnMoFormQLNhanVien.Enabled = Admin;
            //btnMoFormQLDocGia.Enabled = NhanVien;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát khỏi chương trình", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) { 
                Application.Exit();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form formlogin = new loginForm();
            formlogin.ShowDialog();
            this.Hide();
        }

        //private void btnMoFormSach_Click(object sender, EventArgs e)  // Hàm này là khi nhấn 1 nút ở bảng bên trái sẽ tạo form con 
        //{

        //    foreach (Form frm in this.MdiChildren)  // Chạy for từng form con 
        //    {
        //        if (frm.Name == "QuanLySachForm")  //kiểm tra nếu là form QuanLySachForm thì kích hoạt form khi nó đã được mở
        //        {
        //            frm.Activate();  // kích hoạt nè
        //            return;     // return này là dừng lại để tránh tạo form nữa 
        //        }
        //    }
        //    QuanLySachForm frmSach = new QuanLySachForm();        // nếy mà chưa có form dc tạo ra sẳn thì sẽ tạo form mới nè

        //    frmSach.MdiParent = this;  //set cho form là form con

        //    frmSach.Dock = DockStyle.Fill;  // form con lấp đầy không gia của form cha 
        //    frmSach.Show();

        //}

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng chương trình?","Thoát",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.Cancel) { 
                e.Cancel = true;
            }
            
        }

       

        private void btnMoFormQLPhieu_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyMuonTraForm")
                {
                    frm.Activate();
                    return;
                }
            }
            QuanLyMuonTraForm frmPhieu = new QuanLyMuonTraForm(MaNhanVienDangSuDungHeThong);

            frmPhieu.MdiParent = this;

            frmPhieu.Dock = DockStyle.Fill;
            frmPhieu.Show();
        }

        private void btnMoFormQLNhanVien_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyThuThuForm")
                {
                    frm.Activate();
                    return;
                }
            }
            QuanLyThuThu  frmThuThu= new QuanLyThuThu();

            frmThuThu.MdiParent = this;

            frmThuThu.Dock = DockStyle.Fill;
            frmThuThu.Show();
        }

        private void btnMoFormQLDocGia_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyDocGiaForm")
                {
                    frm.Activate();
                    return;
                }
            }
            //QuanLyDocGiaForm frmThuThu = new QuanLyDocGiaForm();

            //frmThuThu.MdiParent = this;

            //frmThuThu.Dock = DockStyle.Fill;
            //frmThuThu.Show();
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyThongkeForm")
                {
                    frm.Activate();
                    return;
                }
            }
            //QuanLyThongkeForm frmThuThu = new QuanLyThongkeForm();

            //frmThuThu.MdiParent = this;

            //frmThuThu.Dock = DockStyle.Fill;
            //frmThuThu.Show();
        }

        private void btnMoFormQLSACH_Click(object sender, EventArgs e)
        {

            foreach (Form frm in this.MdiChildren)  // Chạy for từng form con 
            {
                if (frm.Name == "QuanLySachForm")  //kiểm tra nếu là form QuanLySachForm thì kích hoạt form khi nó đã được mở
                {
                    frm.Activate();  // kích hoạt nè
                    return;     // return này là dừng lại để tránh tạo form nữa 
                }
            }
            QuanLySachForm frmSach = new QuanLySachForm();        // nếy mà chưa có form dc tạo ra sẳn thì sẽ tạo form mới nè

            frmSach.MdiParent = this;  //set cho form là form con

            frmSach.Dock = DockStyle.Fill;  // form con lấp đầy không gia của form cha 
            frmSach.Show();
        }
    }
}
