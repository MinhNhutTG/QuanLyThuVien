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
    public partial class GUI_ThongKeViPham : Form
    {
        BUS_ThongKe bus = new BUS_ThongKe();
        public GUI_ThongKeViPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ThongKeForm3_Load(object sender, EventArgs e)
        {
            lsvDanhSach.Items.Clear();
           
            DataTable dt = bus.ThongKeViPham();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvDanhSach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());

            }
            txtTongViPham.Text = dt.Rows.Count.ToString();
        }

        private void txtTongViPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;
            string path = @"\\FileLog\ThongKeMuonTrongThang.docx";

            string content = "\t \t \t --------- THỐNG KÊ -------- " + date + "\n \n";

            for (int i = 0; i < lsvDanhSach.Items.Count; i++)
            {
                content += lsvDanhSach.Items[i].SubItems[0].Text + " -- ";
                content += lsvDanhSach.Items[i].SubItems[1].Text + " -- ";
                content += lsvDanhSach.Items[i].SubItems[2].Text + "\n ";
            }

            CreateFileDoc doc = new CreateFileDoc();
            doc.CreateFileWord(path, content);
        }
    }
}
