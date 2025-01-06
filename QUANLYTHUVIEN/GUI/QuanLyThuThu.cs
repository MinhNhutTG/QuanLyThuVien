
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
    public partial class QuanLyThuThu : Form
    {
        BUS_ThuThu busThuThu = new BUS_ThuThu();
        public QuanLyThuThu()
        {
            DataTable dt = busThuThu.getDanhSachThuThu();
            InitializeComponent();
            LoadDSThuThu(dt); // load ds tt len form 
        }

        public void LoadDuLieu() // load dl dstt len form qltt
        {
            DataTable dt = busThuThu.getDanhSachThuThu();
            LoadDSThuThu(dt);
        }

        public void LoadDSThuThu(DataTable dt) //load ds thuthu len listview qltt 
        {
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView1.Items.Add(dt.Rows[i][0].ToString());
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    if (j == 3)
                    {
                        string gender = dt.Rows[i][j].ToString();
                        if (gender == "True")
                        {
                            lvi.SubItems.Add("Nam"); // Nếu giới tính là "true", hiển thị "Nam"
                        }
                        else if (gender == "False")
                        {
                            lvi.SubItems.Add("Nữ"); // Nếu giới tính là "false", hiển thị "Nữ"
                        }
                    }
                    else
                    {
                        lvi.SubItems.Add(dt.Rows[i][j].ToString());
                    }
                }
            }
        }

        //su kien button click tim kiem thu thu
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = busThuThu.TimThuThu(txtTimKiem.Text);
            LoadDSThuThu(dt);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemThuThu frmThem = new FormThemThuThu(null, true);
            frmThem.sendData += LoadDuLieu;
            frmThem.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                FormThemThuThu frmSua = new FormThemThuThu(false, listView1.SelectedItems[0].SubItems[0].Text);
                frmSua.sendData += LoadDuLieu;
                frmSua.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn thủ thư cần sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                DialogResult dg = MessageBox.Show("Bạn có muốn xóa thủ thư ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    if (busThuThu.XoaThuThu(listView1.SelectedItems[0].SubItems[0].Text, listView1.SelectedItems[0].SubItems[6].Text))
                    {
                        LoadDuLieu();
                        MessageBox.Show("Đã xóa thủ thư !", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thủ thư cần xóa", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát khỏi QuanLyThuThu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
