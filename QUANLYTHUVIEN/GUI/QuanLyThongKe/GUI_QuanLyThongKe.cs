using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.BLL;

namespace QUANLYTHUVIEN.GUI_QLThongKe
{
    public partial class GUI_QuanLyThongKe : Form
    {
        
        public GUI_QuanLyThongKe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_ThongKeTaiLieu ThongkeForm1 = new GUI_ThongKeTaiLieu();
            ThongkeForm1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GUI_ThongKeMuonTra ThongKeForm2 = new GUI_ThongKeMuonTra();
            ThongKeForm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI_ThongKeViPham ThongkeForm3 = new GUI_ThongKeViPham();
            ThongkeForm3.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
