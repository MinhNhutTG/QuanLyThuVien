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
using Xceed.Words.NET;


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
            
            DateTime date = DateTime.Now;
            string filename = string.Empty;

            if (rdbMuonTrongNgay.Checked)
            {
                filename = "TK_MuonTrongNgay";
            }
            if (rdbMuontrongtuan.Checked) 
            {
                filename = "TK_MuonTrongTuan";
            }
            if (rdbMuontrongthang.Checked)
            {
                filename = "TK_MuonTrongThang";
            }
            if (rdbDangmuon.Checked) {
                filename = "TK_PhieuDangMuon";
            }

            string content = "\t \t \t --------- THỐNG KÊ -------- " + date + "\n \n";

            for (int i = 0; i < lsvDanhsach.Items.Count; i++)
            {
                content += lsvDanhsach.Items[i].SubItems[0].Text + " -- ";
                content += lsvDanhsach.Items[i].SubItems[1].Text + " -- ";
                content += lsvDanhsach.Items[i].SubItems[2].Text + "\n";
            }

            CreateFileDoc  doc = new CreateFileDoc();
            doc.CreateFileWord(filename, content);

        }

        private void GUI_ThongKeMuonTra_Load(object sender, EventArgs e)
        {

        }
    }
}
