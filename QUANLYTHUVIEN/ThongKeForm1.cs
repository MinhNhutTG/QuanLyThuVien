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

namespace QUANLYTHUVIEN
{
    public partial class ThongKeForm1 : Form
    {
        public ThongKeForm1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            lsvdanhsach.Items.Clear();
            XulyThongKe s = new XulyThongKe();
           
            DataTable dt = s.ThongKeSoLuong();
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
            XulyThongKe s = new XulyThongKe();
            DataTable dt = s.ThongKeSoLuong1();
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
            string PATH = AppDomain.CurrentDomain.BaseDirectory ;


            if (rdbSachdangchomuon.Checked)   
            {
                PATH += "\\FileLog\\Sachdangduocmuon.txt";
            }
            else if (rdbSachcontrongkho.Checked)
            {
               
                PATH += "\\FileLog\\ThongKeSachConTrongKho.txt";
            }
            
           
            string content = "";
            for (int i = 0; i< lsvdanhsach.Items.Count; i++ )
            {
                content += lsvdanhsach.Items[i].SubItems[0].Text + " -- ";
                content += lsvdanhsach.Items[i].SubItems[1].Text + " -- ";
                content += lsvdanhsach.Items[i].SubItems[2].Text + "\n ";
               
            }
            File.WriteAllText(PATH , content);
            MessageBox.Show("File Log đã được lưu!!", "Thông báo", MessageBoxButtons.OK);
        }
    }
           
}
