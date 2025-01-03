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
    public partial class QuanLyThuThuForm : Form
    {
        
        XuLyFormThuThu t = new XuLyFormThuThu();
        public QuanLyThuThuForm()
        {
            XuLyFormThuThu t = new XuLyFormThuThu();
           
            InitializeComponent();
            LoadDsThuTHU();
        }

        private void QuanLyThuThuForm_Load(object sender, EventArgs e)
        {
            LoadDsThuTHU();
        }
        public void LoadDsThuTHU()
        {
            XuLyFormThuThu th = new XuLyFormThuThu();
            DataTable dt = th.LayDSThuThu(); //lay ds thuthu va hthi dl
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
        //private void LoadDanhSachThuThu()
        //{
        //    XuLyFormThuThu th = new XuLyFormThuThu();
        //    DataTable dt = th.LayDSThuThu(); //lay ds thuthu va hthi dl

        //    HienThiDanhSach(dt); // hthi dl tren listview

        //}



        // hien thi danh sach va hien thi so colums dc tao trong listview 
        public void HienThiDanhSach(DataTable dt)
        {
            listView1.Items.Clear(); //lam moi listview
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = t.Timkiem(txtTimKiem.Text);
            HienThiDanhSach(dt);
        }

        //them thu thu
        private void btnThem_Click(object sender, EventArgs e)
        {
                FormThemThuThu formthemtt = new FormThemThuThu(/*MaThuThu*/ null, true);
                formthemtt.sendData += LoadDsThuTHU;
                formthemtt.Show();
           
        }

        //sua thu thu
        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count == 1)
            {
                    FormThemThuThu formsuatt = new FormThemThuThu(false, listView1.SelectedItems[0].SubItems[0].Text); // tao form con sua dl
                    formsuatt.sendData += LoadDsThuTHU; // lay dl tu danh sach vao form con
                    formsuatt.Show();  
            }
            else
            {
                MessageBox.Show("Chon thu thu can sua", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // xoa thu thu 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                DialogResult dg = MessageBox.Show("Bạn chắc chắn muốn xóa thủ thư không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    XuLyFormThuThu formxoa = new XuLyFormThuThu();
                    formxoa.XoaThuThu(listView1.SelectedItems[0].SubItems[0].Text, listView1.SelectedItems[0].SubItems[6].Text); // xoa dl trong database va goi ham XoaThuThu trong class XuLyFormThuThu
                    DataTable dt = formxoa.LayDSThuThu(); // lay lai dl tu database sau khi xoa
                    HienThiDanhSach(dt); // hthi dl trong listview
                }
            }
            else
            {
                MessageBox.Show("Chọn thủ thư cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //thoat khoi form quanlythuthu
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Ban chac chan muon thoat ? ", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
