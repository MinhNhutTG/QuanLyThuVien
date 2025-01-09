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
using QUANLYTHUVIEN.BLL;

namespace QUANLYTHUVIEN.GUI_QLThongKe
{
    public partial class GUI_ThongKeMuonTra : Form
    {
        BUS_ThongKe bus = new BUS_ThongKe();
        public GUI_ThongKeMuonTra()
        {
            InitializeComponent(); 
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
            
        {
            DateTime date = DateTime.Now;
            lsvDanhsach.Items.Clear();
            string key =  date.ToShortDateString(); // Thay "YourKeyHere" bằng giá trị bạn muốn truyền
            MessageBox.Show(key);
            DataTable dt = bus.ThongKeMuonTrongNgay(key); //truyền key vào DAL
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
             DataTable dt = bus.ThongKeTrongTuan();
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
            DataTable dt = bus.ThongKeDangMuon();
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
            DataTable dt = bus.ThongKeTrongThang();
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
