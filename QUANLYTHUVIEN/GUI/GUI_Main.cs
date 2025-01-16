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
using QUANLYTHUVIEN.BLL;
using QUANLYTHUVIEN.GUI_QLThongKe;

namespace QUANLYTHUVIEN.GUI
{
    public partial class GUI_Main : Form
    {
        public string MaNhanVienDangSuDungHeThong { get; set; }
      

        public GUI_Main()
        {
            InitializeComponent();
            MainStart();
            setButton(true, true);
        }

        public GUI_Main(string quyen, string maNhanVien)
        {
            InitializeComponent();
            MainStart();

            if (quyen == "admin")
            {
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
            Form frm = new GUI_BackgroundMain();        // nếy mà chưa có form dc tạo ra sẳn thì sẽ tạo form mới nè

            frm.MdiParent = this;  //set cho form là form con

            frm.Dock = DockStyle.Fill;  // form con lấp đầy không gia của form cha 
            frm.Show();
        }

        private void setButton(bool Admin, bool NhanVien)
        {
            btnMoFormQLSACH.Enabled = NhanVien;
            btnMoFormQLPhieu.Enabled = NhanVien;
            btnMoFormQLNhanVien.Enabled = Admin;
            btnMoFormQLDocGia.Enabled = NhanVien;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát khỏi chương trình", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form formlogin = new GUI_Login();
            formlogin.ShowDialog();
            this.Hide();
        }

      

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng chương trình?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.Cancel)
            {
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
            GUI_QuanLyMuonTra frmPhieu = new GUI_QuanLyMuonTra(MaNhanVienDangSuDungHeThong);

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
            GUI_QuanLyThuThu frmThuThu = new GUI_QuanLyThuThu();

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
            GUI_QuanLyDocGia frmThuThu = new GUI_QuanLyDocGia();

            frmThuThu.MdiParent = this;

            frmThuThu.Dock = DockStyle.Fill;
            frmThuThu.Show();
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
            GUI_QuanLyThongKe frmThuThu = new GUI_QuanLyThongKe();

            frmThuThu.MdiParent = this;

            frmThuThu.Dock = DockStyle.Fill;
            frmThuThu.Show();
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
            GUI_QuanLySachForm frmSach = new GUI_QuanLySachForm();        // nếy mà chưa có form dc tạo ra sẳn thì sẽ tạo form mới nè

            frmSach.MdiParent = this;  //set cho form là form con

            frmSach.Dock = DockStyle.Fill;  // form con lấp đầy không gia của form cha 
            frmSach.Show();
        }
        
      
        
    }
}
