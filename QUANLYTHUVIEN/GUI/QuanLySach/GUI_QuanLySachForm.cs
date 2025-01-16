using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.DTO;
using QUANLYTHUVIEN.BLL;



namespace QUANLYTHUVIEN.GUI
{
    public partial class GUI_QuanLySachForm : Form
    {

        //Khai bao bien
        BUS_Sach busSach = new BUS_Sach();

        //Ham Tao
        public GUI_QuanLySachForm()
        {
            DataTable dt = busSach.GetDanhSachSach();
            InitializeComponent();
            HienComboBoxTheLoai();
            ShowListSach(dt);
        }

        // Function Show
        public void ShowListSach(DataTable dt)
        {
            lsvSach.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvSach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());
                item.SubItems.Add(dt.Rows[i][6].ToString());
                item.SubItems.Add(dt.Rows[i][7].ToString());
            }
        }
        public void LoadData()
        {
            DataTable dt = busSach.GetDanhSachSach();
            ShowListSach(dt);
        }
        public void HienComboBoxTheLoai()
        {
            CbbTheLoai.DataSource = busSach.GetTheLoai();
            CbbTheLoai.DisplayMember = "TenTheLoai";
            CbbTheLoai.ValueMember = "MaTheLoai";
        }
        private void CbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = busSach.TimSachTheoTheLoai(CbbTheLoai.SelectedValue.ToString());
            ShowListSach(dt);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = busSach.TimKiemSach(txtTimKiem.Text);
            ShowListSach(dt);
        }

        //Functon Add View Remove Update Exit

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            GUI_ThemSuaSach frm = new GUI_ThemSuaSach(true);
            frm.sendData += LoadData;
            frm.ShowDialog();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (lsvSach.SelectedItems.Count == 1)
            {
                DialogResult dg = MessageBox.Show("Bạn có muốn xóa sách?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    if (busSach.XoaSach(lsvSach.SelectedItems[0].Text))
                    {
                        LoadData();
                        MessageBox.Show("Đã xóa thành công", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 cuốn sách để xóa", "Thông báo");
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (lsvSach.SelectedItems.Count == 1)
            {
                GUI_ThemSuaSach SuaSach = new GUI_ThemSuaSach(false, lsvSach.SelectedItems[0].SubItems[0].Text);
                SuaSach.sendData += LoadData;
                SuaSach.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn sách cần chỉnh sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (lsvSach.SelectedItems.Count == 1)
            {
                GUI_XemChiTietSach Xem = new GUI_XemChiTietSach(lsvSach.SelectedItems[0].SubItems[0].Text);
                Xem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn sách cần xem!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            GUI_QuanLyTheLoaiSach frm = new GUI_QuanLyTheLoaiSach();
            frm.ShowDialog();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn trở lại Trang chủ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Function keys



        private void GUI_QuanLySachForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                txtTimKiem.Focus();
            }
        }

        private void GUI_QuanLySachForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}

