using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.BUS;

namespace QUANLYTHUVIEN.GUI_QLThongKe
{
    public partial class QuanLyThongkeForm : Form
    {
        
        public QuanLyThongkeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKeForm1 ThongkeForm1 = new ThongKeForm1();
            ThongkeForm1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ThongKeForm2 ThongKeForm2 = new ThongKeForm2();
            ThongKeForm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThongKeForm3 ThongkeForm3 = new ThongKeForm3();
            ThongkeForm3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
