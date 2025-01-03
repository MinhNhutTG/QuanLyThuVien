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
    public partial class QuanLyDocGiaForm : Form
    {
        XuLyFormDocGia s = new XuLyFormDocGia();
        public QuanLyDocGiaForm()
        {
            XuLyFormDocGia s = new XuLyFormDocGia();
            DataTable dt = s.LayDSDocGia();
            InitializeComponent();
            LoadDanhSach(dt);

        }

        public void LoadDuLieu()
        {

            DataTable dt = s.LayDSDocGia();
            LoadDanhSach(dt);
        }
        public void LoadDanhSach(DataTable dt)
        {
            lsvDocGia.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvDocGia.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());

            }

        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            DataTable dt = s.LayDSDocGia();
            LoadDanhSach(dt);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            frmQuanLyDocGia_Them Them = new frmQuanLyDocGia_Them ();
            Them.sendData += LoadDuLieu;
            Them.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = s.TimKiemDocGia(txtTimKiem.Text);
            LoadDanhSach(dt);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (lsvDocGia.SelectedItems.Count == 1)
            {
                frmQuanLyDocGia_Them SuaDocGia = new frmQuanLyDocGia_Them(false, lsvDocGia.SelectedItems[0].SubItems[0].Text);
                SuaDocGia.sendData += LoadDuLieu;
                SuaDocGia.Show();
            }
            else
            {
                MessageBox.Show("Chọn thông tin độc giả cần sửa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (lsvDocGia.SelectedItems.Count == 1)
            {
                DialogResult dg = MessageBox.Show("Bạn muốn xóa thông tin độc giả  : " + lsvDocGia.SelectedItems[0].Text + " không?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dg == DialogResult.Yes)
                {
                    XuLyFormDocGia xuLyFormDocGia = new XuLyFormDocGia();
                    xuLyFormDocGia.XoaDocGia(lsvDocGia.SelectedItems[0].Text);

                    DataTable dt = xuLyFormDocGia.LayDSDocGia();
                    LoadDanhSach(dt);
                }

            }
            else
            {
                MessageBox.Show("Chọn thông tin độc giả cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }
    }
}