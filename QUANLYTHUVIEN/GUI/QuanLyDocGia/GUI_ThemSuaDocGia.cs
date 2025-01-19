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
using QUANLYTHUVIEN.DTO;


namespace QUANLYTHUVIEN.GUI
{
    public partial class GUI_ThemSuaDocGia : Form
    {
        BLL_DocGia busDocGia = new BLL_DocGia();
        public delegate void LoadHandler();
        public event LoadHandler sendData;
        public GUI_ThemSuaDocGia()
        {
            InitializeComponent();
        }

        public GUI_ThemSuaDocGia(bool enable)  
        {
            InitializeComponent();
            setButton(enable);
        }
        public GUI_ThemSuaDocGia(bool enable, string MaDocGia)
        {
            InitializeComponent();
            setButton(enable);

            HienThiChiTietDocGia(MaDocGia);

        }
        private void setButton(bool enable)   
        {
            btnThem.Enabled = enable;
            btnCapNhat.Enabled = !enable;
            btnLamMoi.Enabled = enable;
            btnThoat.Enabled = true;
        }
        public void HienThiChiTietDocGia(string key)
        {
            DataTable dt = busDocGia.TimKiemTheoMaDocGia(key);
            txtMaDocGia.Text = dt.Rows[0][0].ToString();
            txtTenDocGia.Text = dt.Rows[0][1].ToString();
            txtLop.Text = dt.Rows[0][2].ToString();
            txtDiaChi.Text = dt.Rows[0][3].ToString();
            txtSODT.Text = dt.Rows[0][4].ToString();

        }
        private DocGia LayDocGia()
        {
            DocGia docGia = new DocGia();
            docGia.setMaDocGia(txtMaDocGia.Text);
            docGia.setTenDocGia(txtTenDocGia.Text);
            docGia.setLop(txtLop.Text);
            docGia.setDiaChi(txtDiaChi.Text);
            docGia.setSODT(txtSODT.Text);

            return docGia;
        }

        private void ResetTextBox()
        {
            txtMaDocGia.Clear();
            txtTenDocGia.Clear();
            txtLop.Clear();
            txtDiaChi.Clear();
            txtSODT.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            DocGia s = LayDocGia();
            try
            {

                if (busDocGia.ThemDocGia(s))
                {
                    MessageBox.Show("Thêm độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTextBox();
                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (sendData != null)
                {
                    sendData();
                }

            }
            catch (BLL_DocGia.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DocGia s = LayDocGia();
            try
            {
                if (busDocGia.CapNhatDocGia(s))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (BLL_DocGia.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }

        private void txtSODT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }   
        }
    }
}
