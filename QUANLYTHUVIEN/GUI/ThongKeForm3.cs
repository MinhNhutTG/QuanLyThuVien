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
using QUANLYTHUVIEN.BUS;

namespace QUANLYTHUVIEN.GUI_QLThongKe
{
    public partial class ThongKeForm3 : Form
    {
        BUSThongKe bus = new BUSThongKe();
        public ThongKeForm3()
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
            string PATH = AppDomain.CurrentDomain.BaseDirectory;


            
           
            {

                PATH += "\\FileLog\\ThongKeViPham.txt";
            }


            string content = "";
            for (int i = 0; i < lsvDanhSach.Items.Count; i++)
            {
                content += " ";
                content += lsvDanhSach.Items[i].SubItems[0].Text + " -- ";
                content += lsvDanhSach.Items[i].SubItems[1].Text + " -- ";
                content += lsvDanhSach.Items[i].SubItems[2].Text + "\n ";

            }
            File.WriteAllText(PATH, content);
            MessageBox.Show("File Log đã được lưu!!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
