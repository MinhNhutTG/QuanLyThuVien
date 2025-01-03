using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QUANLYTHUVIEN
{
    public partial class ThongKeForm2 : Form
    {
        public ThongKeForm2()
        {
            InitializeComponent(); 
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lsvDanhsach.Items.Clear();
            XulyThongKe conn = new XulyThongKe();
            DateTime datetime = DateTime.Now;
           
            string ngayHienTai = datetime.ToString("dd/MM/yyyy");
          
            DataTable dt = conn.ThongKeMuonTra(ngayHienTai);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                ListViewItem item = lsvDanhsach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());

                // Cập nhật tổng số sách đã mượn

            }
            txtTongSoSach.Text = dt.Rows.Count.ToString();
        }

        private void rdbMuontrongtuan_CheckedChanged(object sender, EventArgs e)
        {
            lsvDanhsach.Items.Clear();
            XulyThongKe conn = new XulyThongKe();
            DataTable dt = conn.ThongKeTrongTuan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvDanhsach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
            }
            txtTongSoSach.Text = dt.Rows.Count.ToString();
        }

        private void rdbDangmuon_CheckedChanged(object sender, EventArgs e)
        {
            lsvDanhsach.Items.Clear();
            XulyThongKe conn = new XulyThongKe();
            DataTable dt = conn.ThongKeDangMuon();
            for (int i = 0;i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvDanhsach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());

                // Cập nhật tổng số sách đã mượn
                txtTongSoSach.Text = dt.Rows.Count.ToString();
            }
        }

        private void rdbMuontrongthang_CheckedChanged(object sender, EventArgs e)
        {
            lsvDanhsach.Items.Clear();
            XulyThongKe conn = new XulyThongKe ();
            DataTable dt = conn.ThongKeTrongThang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvDanhsach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());

                // Cập nhật tổng số sách đã mượn
                txtTongSoSach.Text = dt.Rows.Count.ToString();
            }
        }

        

        private void lsvDanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            string PATH = AppDomain.CurrentDomain.BaseDirectory;


            if (rdbMuonTrongNgay.Checked)
            {
                PATH += "\\FileLog\\ThongKeMuonTrongNgay.txt";
            }
            else if (rdbMuontrongtuan.Checked)
            {

                PATH += "\\FileLog\\ThongKeMuonTrongTuan.txt";
            }
            else if (rdbMuontrongthang.Checked)
            {
                PATH += "\\FileLog\\ThongKeMuonTrongThang.txt";
            }
            else if (rdbDangmuon.Checked) 
            {
                PATH += "\\FileLog\\ThongKeDangMuon.txt";
            }


            string content = "";
            for (int i = 0; i < lsvDanhsach.Items.Count; i++)
            {
                content += " ";
                content += lsvDanhsach.Items[i].SubItems[0].Text + " -- ";
                content += lsvDanhsach.Items[i].SubItems[1].Text + " -- ";
                content += lsvDanhsach.Items[i].SubItems[2].Text + "\n ";

            }
            File.WriteAllText(PATH, content);
            MessageBox.Show("File Log đã được lưu!!", "Thông báo", MessageBoxButtons.OK);
        }
       

          
        
    }
}
