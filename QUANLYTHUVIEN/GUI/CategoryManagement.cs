using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.BUS;


namespace QUANLYTHUVIEN.GUI
{
    
    public partial class CategoryManagement : Form
    {
        BUS_Sach busSach = new BUS_Sach();
        public CategoryManagement()
        {
            InitializeComponent();
            HienThiTheLoai();
        }
        public void HienThiTheLoai()
        {
            lsvTheLoai.Items.Clear();
            DataTable dt = busSach.GetTheLoai();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvTheLoai.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());    
                
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTheLoai.SelectedItems.Count == 1)
            {
                txtIDcate.Text = lsvTheLoai.SelectedItems[0].Text; 
                txtNamecate.Text = lsvTheLoai.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDcate.Text) && !string.IsNullOrEmpty(txtNamecate.Text))
            {
                if (busSach.ThemTheLoai(txtIDcate.Text, txtNamecate.Text))
                {
                    HienThiTheLoai();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    txtIDcate.Clear();
                    txtNamecate.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDcate.Text) && !string.IsNullOrEmpty(txtNamecate.Text))
            {
                if (busSach.CapNhatTheLoai(txtIDcate.Text, txtNamecate.Text))
                {
                    HienThiTheLoai();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvTheLoai.SelectedItems.Count > 0 )
            {
                if (busSach.XoaTheLoai(lsvTheLoai.SelectedItems[0].Text))
                {
                    HienThiTheLoai();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    txtIDcate.Clear();
                    txtNamecate.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
               
            
            }
            else
            {
                MessageBox.Show("Chọn thể loại cần xóa", "Thông báo");
            }
        }
    }
}
