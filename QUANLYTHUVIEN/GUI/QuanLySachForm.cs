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
using QUANLYTHUVIEN.BUS;



namespace QUANLYTHUVIEN.GUI
{
    public partial class QuanLySachForm : Form
    {
        BUS_Sach busSach = new BUS_Sach();
        public QuanLySachForm()
        {
            DataTable dt = busSach.GetDanhSachSach();
            InitializeComponent();
            HienComboBoxTheLoai();
            LoadDanhSach(dt);
        }
        public void LoadDuLieu()
        {
            DataTable dt = busSach.GetDanhSachSach();
            LoadDanhSach(dt);
        }
        public void HienComboBoxTheLoai()
        {

            CbbTheLoai.DataSource = busSach.GetTheLoai();
            CbbTheLoai.DisplayMember = "TenTheLoai";
            CbbTheLoai.ValueMember = "MaTheLoai";
        }

   
        public void  LoadDanhSach(DataTable dt)
        {

            lsvSach.Items.Clear();
           
            //l.CapNhatSoLuongSach();
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
       

        private void QuanLySachForm_Load(object sender, EventArgs e)
        {   
           
            
            //DataTable dt = s.LayDSSach();
            //LoadDanhSach(dt);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

           DataTable  dt =  busSach.TimKiemSach(txtTimKiem.Text);
            LoadDanhSach(dt);

        }

        private void CbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = busSach.TimSachTheoTheLoai(CbbTheLoai.SelectedValue.ToString());
            LoadDanhSach(dt);
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            frmQuanLySach_ThemSach frm = new frmQuanLySach_ThemSach(true);
            frm.ShowDialog();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (lsvSach.Items.Count > 0) {
                DialogResult dg = MessageBox.Show("Bạn có muốn xóa sách?","Thông báo",MessageBoxButtons .YesNo);
                if (dg == DialogResult.Yes) {
                    if (busSach.XoaSach(lsvSach.SelectedItems[0].Text))
                    {
                        LoadDuLieu();
                        MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.YesNo);
                    }
                }
            }
        }

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{

        //    DataTable dt = s.TimKiem(txtTimKiem.Text);

        //    LoadDanhSach(dt);
        //}

        //private void CbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DataTable dt = s.TimKiem(CbbTheLoai.Text);

        //    LoadDanhSach(dt);
        //}

        //private void btnLamMoi_Click_1(object sender, EventArgs e)
        //{
        //    DataTable dt = s.LayDSSach();
        //    LoadDanhSach(dt);
        //}

        //private void btnThemSach_Click(object sender, EventArgs e)
        //{
        //   frmQuanLySach_ThemSach ThemSach = new frmQuanLySach_ThemSach(true);
        //   ThemSach.Owner = this;
        //   ThemSach.sendData += LoadDuLieu;
        //   ThemSach.ShowDialog();
        //}

        //private void btnXoaSach_Click(object sender, EventArgs e)
        //{
        //    if (lsvSach.SelectedItems.Count == 1)
        //    {
        //        DialogResult dg = MessageBox.Show("Bạn có muốn xóa sách : "+ lsvSach.SelectedItems[0].Text + " không? \n Việc xóa sách sẽ dẫn đến xóa các phiếu mượnn có liên quan đến sách", "Lỗi xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        XuLyFormSach xuLyFormSach = new XuLyFormSach();
        //        xuLyFormSach.XoaSach(lsvSach.SelectedItems[0].Text);

        //        DataTable dt = xuLyFormSach.LayDSSach();
        //        LoadDanhSach(dt);
        //    }
        //    else
        //    { 
        //        MessageBox.Show("Chọn sách cần xóa !!!","Lỗi xóa Sách",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //    }
        //}

        //private void btnSuaSach_Click(object sender, EventArgs e)
        //{

        //    if (lsvSach.SelectedItems.Count == 1)
        //    {
        //        frmQuanLySach_ThemSach SuaSach = new frmQuanLySach_ThemSach(false , lsvSach.SelectedItems[0].SubItems[0].Text);
        //        SuaSach.sendData += LoadDuLieu;
        //        SuaSach.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Chọn sách cần chỉnh sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //private void btnXemChiTiet_Click(object sender, EventArgs e)
        //{
        //    if (lsvSach.SelectedItems.Count > 0) {
        //        frmQuanLySachXemChiTiet frmChiTiet = new frmQuanLySachXemChiTiet(lsvSach.SelectedItems[0].SubItems[0].Text);
        //        frmChiTiet.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Chọn  sách cần xem chi tiết!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}



        //private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        btnTimKiem.PerformClick();
        //    }
        //}

        //private void QuanLySachForm_CtrlF_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Control && e.KeyCode == Keys.F) { 
        //        txtTimKiem.Focus();
        //    }
        //}

        //private void txtTimKiem_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    DialogResult dg = MessageBox.Show("Bạn có muốn trở lại Trang chủ?", "Thông báo",MessageBoxButtons .YesNo, MessageBoxIcon.Question);
        //    if (dg == DialogResult.Yes) { 
        //        this.Close();
        //    }
        //}

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
