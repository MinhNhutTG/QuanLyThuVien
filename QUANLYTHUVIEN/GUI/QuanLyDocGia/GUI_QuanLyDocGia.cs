using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.BLL;
using QUANLYTHUVIEN.DTO;

namespace QUANLYTHUVIEN.GUI
{
    public partial class GUI_ReaderManagement : Form
    {
        BUS_DocGia busDocGia = new BUS_DocGia();
        public GUI_ReaderManagement()
        {
            DataTable dt = busDocGia.GetDSDocGia();
            InitializeComponent();
            LoadDDanhSach(dt);
        }
        public void LoadDuLieu()
        {
            DataTable dt = busDocGia.GetDSDocGia();
            LoadDDanhSach(dt);
        }
        public void LoadDDanhSach(DataTable dt)
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

        private void btnThem_Click(object sender, EventArgs e)
        { 
            GUI_ThemSuaDocGia ThemDocGia = new GUI_ThemSuaDocGia();
            ThemDocGia.Show();
            ThemDocGia.sendData += LoadDuLieu;
        }




        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = busDocGia.TimKiemDocGia(txtTimKiem.Text);
            LoadDDanhSach(dt);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (lsvDocGia.SelectedItems.Count == 1)
            {
                GUI_ThemSuaDocGia SuaDocGia = new GUI_ThemSuaDocGia(false, lsvDocGia.SelectedItems[0].SubItems[0].Text);
                SuaDocGia.sendData += LoadDuLieu;
                SuaDocGia.Show();
            }
            else
            {
                MessageBox.Show("Chọn sách cần chỉnh sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDocGia.SelectedItems.Count == 1)
            {
                DialogResult dg = MessageBox.Show("Bạn có muốn xóa độc giả?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    if (busDocGia.XoaDocGia(lsvDocGia.SelectedItems[0].Text))
                    {
                        LoadDuLieu();
                        MessageBox.Show("Xóa thành công", "Thông báo");

                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn độc giả bạn cần xóa", "Thông báo");
            }
        }
    }
}
