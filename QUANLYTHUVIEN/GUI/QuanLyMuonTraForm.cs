﻿using QUANLYTHUVIEN.BUS;
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
    public partial class QuanLyMuonTraForm : Form
    {
        BUS_PhieuMuon BusPM = new BUS_PhieuMuon();
        string MaThuThu = string.Empty;

        public QuanLyMuonTraForm()
        {
           
            InitializeComponent();
            HienThiDanhSach();
        }
        public QuanLyMuonTraForm(string manhanvien)
        {
            MaThuThu = manhanvien;
            InitializeComponent();
            HienThiDanhSach();
        }
        public void LoadDuLieu()
        {
            DataTable dt = BusPM.LayDSPhieuMuon();
            HienThiDanhSach();
        }

        public void HienThiDanhSach()
        {
            DataTable dt = BusPM.LayDSPhieuMuon();
            lsvPhieuMuon.Items.Clear();     // Xóa dữ liệu cũ trên ListView
            for (int i = 0; i < dt.Rows.Count; i++)     // Duyệt qua tất cả các dòng của DataTable
            {
                ListViewItem item = lsvPhieuMuon.Items.Add(dt.Rows[i][0].ToString()); // Lấy dữ liệu từ cột đầu tiên của DataTable
                for (int j = 1; j < dt.Columns.Count; j++) // Duyệt theo số lượng cột có trong DataTable
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());    // Lấy dữ liệu từ các cột còn lại của DataTable
                }
            }
        }

        private void QuanLyMuonTraForm_Load(object sender, EventArgs e)
        {
      
            HienThiDanhSach();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trình quản lý mượn trả?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvPhieuMuon.SelectedItems.Count == 1)
            {
                if (lsvPhieuMuon.SelectedItems[0].SubItems[5].Text == "Đang mượn")
                {
                    MessageBox.Show("Không thể xóa phiếu đang mượn !!!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dg = MessageBox.Show("Bạn có muốn xóa phiếu mượn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                   
                    BusPM.Delete(lsvPhieuMuon.SelectedItems[0].SubItems[0].Text); // Xóa dữ liệu trong Database/ gọi hàm Delete trong class XuLyFormMuonTra

                    HienThiDanhSach(); // Hiển thị dữ liệu lên ListView
                }
            }

            else
            {
                MessageBox.Show("Chọn phiếu mượn cần xóa để xóa!!!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            QuanLyMuonTraForm_Update Add = new QuanLyMuonTraForm_Update(MaThuThu, true);
            Add.sendData += LoadDuLieu;
            Add.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Form Update = new QuanLyMuonTraForm_Update();
            if (lsvPhieuMuon.SelectedItems.Count == 1)
            {
                QuanLyMuonTraForm_Update Update = new QuanLyMuonTraForm_Update(false,lsvPhieuMuon.SelectedItems[0].SubItems[0].Text);
                Update.sendData += LoadDuLieu;
                Update.Show();
            }
            else
            {
                MessageBox.Show("Chọn phiếu mượn cần cập nhật!!!", "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = BusPM.Search(txtSearch.Text);
            HienThiDanhSach();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lsvPhieuMuon.SelectedItems.Count == 1)
            {
                QuanLyPhieuMuonForm_ChiTiet frm = new QuanLyPhieuMuonForm_ChiTiet(lsvPhieuMuon.SelectedItems[0].SubItems[0].Text);
                
                frm.Show();
            }
            else
            {
                MessageBox.Show("Chọn phiếu mượn cần xem chi tiết!!!", "Lỗi xem chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


    }
}
