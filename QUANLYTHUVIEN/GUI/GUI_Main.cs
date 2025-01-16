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
        //Khai bao bien
        public string MaNhanVienDangSuDungHeThong { get; set; }
      

        //ham tao
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
      

        //Open form 
        private void MainStart()
        {
            Form frm = new GUI_BackgroundMain();        

            frm.MdiParent = this; 

            frm.Dock = DockStyle.Fill; 
            frm.Show();
        }

        private void setButton(bool Admin, bool NhanVien)
        {
            btnMoFormQLSACH.Enabled = NhanVien;
            btnMoFormQLPhieu.Enabled = NhanVien;
            btnMoFormQLNhanVien.Enabled = Admin;
            btnMoFormQLDocGia.Enabled = NhanVien;
        }

        //Open form login
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form formlogin = new GUI_Login();
            formlogin.ShowDialog();
            this.Hide();
        }

        //Open form Quan Ly Sach
        private void btnMoFormQLSACH_Click(object sender, EventArgs e)
        {
            btnMoFormQLSACH.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLySachForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }


            GUI_QuanLySachForm frmSach = new GUI_QuanLySachForm();

            frmSach.MdiParent = this;

            frmSach.Dock = DockStyle.Fill;
            frmSach.Show();
            frmSach.FormClosed += (s, args) =>
            {
                btnMoFormQLSACH.BackColor = Color.CornflowerBlue; 
            };
        }

        //Open form Quan Ly Phieu Muon
        private void btnMoFormQLPhieu_Click(object sender, EventArgs e)
        {
            btnMoFormQLPhieu.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyMuonTraForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }
            GUI_QuanLyMuonTra frmPhieu = new GUI_QuanLyMuonTra(MaNhanVienDangSuDungHeThong);

            frmPhieu.MdiParent = this;

            frmPhieu.Dock = DockStyle.Fill;
            frmPhieu.Show();
            frmPhieu.Closed += (s, args) =>
            {
                btnMoFormQLPhieu.BackColor = Color.CornflowerBlue;
            };
        }

        //Open form Quan Ly Nhan Vien
        private void btnMoFormQLNhanVien_Click(object sender, EventArgs e)
        {
            btnMoFormQLNhanVien.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyThuThuForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }
            GUI_QuanLyThuThu frmThuThu = new GUI_QuanLyThuThu();

            frmThuThu.MdiParent = this;

            frmThuThu.Dock = DockStyle.Fill;
            frmThuThu.Show();
            frmThuThu.FormClosed += (s, args) =>
            {
                btnMoFormQLNhanVien.BackColor = Color.CornflowerBlue;
            };
        }

        //Open form Quan Ly Doc Gia
        private void btnMoFormQLDocGia_Click(object sender, EventArgs e)
        {
            btnMoFormQLDocGia.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyDocGiaForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }
            GUI_QuanLyDocGia frmThuThu = new GUI_QuanLyDocGia();

            frmThuThu.MdiParent = this;

            frmThuThu.Dock = DockStyle.Fill;
            frmThuThu.Show();
            frmThuThu.FormClosed += (s, args) =>
            {
                btnMoFormQLDocGia.BackColor = Color.CornflowerBlue;
            };
        }

        //Open form Quan Ly Thong Ke
        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyThongkeForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }
          
            GUI_QuanLyThongKe frmThuThu = new GUI_QuanLyThongKe();

            frmThuThu.MdiParent = this;

            frmThuThu.Dock = DockStyle.Fill;
            frmThuThu.Show();
            frmThuThu.FormClosed += (s, args) =>
            {
                btnThongKe.BackColor = Color.CornflowerBlue;
            };
        }

        //Close Application 
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát khỏi chương trình", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        // Khi nhấn click vào nút thì sẽ chạy vòng lập kiểm tra các form con 
        // Nếu form có tên như form mình muốn mở thì cho nó tiếp tục mở 
        // Nếu các form khác với form background thì đóng ==> nhằm hủy các form đang hoạt động khi mở form mới, tránh chồng form
        //Sau đó , tại form cần mở và set thành form con , form con fill đầy khu vực trống
    }
}
