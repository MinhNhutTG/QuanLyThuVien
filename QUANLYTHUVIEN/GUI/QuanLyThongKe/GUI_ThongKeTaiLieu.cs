using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QUANLYTHUVIEN.BLL;

namespace QUANLYTHUVIEN.GUI_QLThongKe
{
    public partial class GUI_ThongKeTaiLieu : Form
    {
        BLL_ThongKe bus= new BLL_ThongKe();
        public GUI_ThongKeTaiLieu()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            lsvdanhsach.Items.Clear();
            DataTable dt = bus.ThongKeSachDangMuon();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvdanhsach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());



            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lsvdanhsach.Items.Clear(); 
            DataTable dt = bus.ThongKeSachConTrongKho();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvdanhsach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }

        private void lsvdanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvdanhsach.SelectedItems.Count > 0)
            {
                colMaSach.Text = lsvdanhsach.SelectedItems[0].SubItems[0].Text;

                colTenSach.Text = lsvdanhsach.SelectedItems[0].SubItems[3].Text;

                colTinhTrang.Text = lsvdanhsach.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string filename = string.Empty;
            if (rdbSachdangchomuon.Checked) {
                 filename = "TK_SachDangMuon";
            }
            if (rdbSachcontrongkho.Checked)
            {
                filename = "TK_SachConTrongKho";
            }

            string content = "\t \t \t DANH SÁCH THỐNG KÊ -------- " + date + "\n \n";

            for (int i = 0; i < lsvdanhsach.Items.Count; i++)
            {
                content += lsvdanhsach.Items[i].SubItems[0].Text + " - - - ";
                content += lsvdanhsach.Items[i].SubItems[1].Text + " - - - ";
                content += lsvdanhsach.Items[i].SubItems[2].Text + "\n";
            }
            CreateFileDoc  doc = new CreateFileDoc();
            doc.CreateFileWord(filename, content);
        }

        private void GUI_ThongKeTaiLieu_Load(object sender, EventArgs e)
        {

        }
    }
           
}
