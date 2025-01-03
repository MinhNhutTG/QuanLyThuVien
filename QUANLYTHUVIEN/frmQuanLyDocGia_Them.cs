using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN
{
    public partial class frmQuanLyDocGia_Them : Form
    {
        XuLyFormDocGia xl = new XuLyFormDocGia();
        public delegate void LoadHandler();
        public event LoadHandler sendData;
        public frmQuanLyDocGia_Them()
        {
            InitializeComponent();
            setButton(true);
        }

        public frmQuanLyDocGia_Them(bool enable , string MaDocGia)
        {
            InitializeComponent();
            setButton(enable);
            DataTable dt = xl.SelectDocGia(MaDocGia);
            HienThiChiTietDocGia(dt);

        }
        private void HienThiChiTietDocGia(DataTable dt)
        {
            txtMaDocGia.Text = dt.Rows[0][0].ToString();
            txtTenDocGia.Text = dt.Rows[0][1].ToString();
            txtLop.Text = dt.Rows[0][2].ToString();
            txtDiaChi.Text = dt.Rows[0][3].ToString();
            txtSODT.Text = dt.Rows[0][4].ToString();
        }

        private void ResetTextBox()
        {
            txtMaDocGia.Clear();
            txtTenDocGia.Clear();
            txtLop.Clear();
            txtDiaChi.Clear();
            txtSODT.Clear();
        }

        private bool checkFormRong()
        {
            if (string.IsNullOrEmpty(txtMaDocGia.Text) ||
                string.IsNullOrEmpty(txtTenDocGia.Text) ||
                string.IsNullOrEmpty(txtLop.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtSODT.Text))
            {
                return false;
            }
            return true;
        }

        private void setButton(bool enable)
        {
            btnThem.Enabled = enable;
            btnCapNhat.Enabled = !enable;
            btnLamMoi.Enabled = enable;
            btnThoat.Enabled = true;
        }


        private DocGia LayDocGia()
        {
            DocGia docGia = new DocGia();
            docGia.MaDocGia = txtMaDocGia.Text;
            docGia.TenDocGia = txtTenDocGia.Text;
            docGia.Lop = txtLop.Text;
            docGia.DiaChi = txtDiaChi.Text;
            docGia.SODT = txtSODT.Text;

            return docGia;
        }

        private void frmQuanLyDocGia_Them_Load(object sender, EventArgs e)
        {
            txtMaDocGia.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkFormRong())
                {
                    DocGia s = LayDocGia();
                    XuLyFormDocGia XuLyDocGia = new XuLyFormDocGia();
                    if (!XuLyDocGia.KiemTraMaDocGia(txtMaDocGia.Text))
                    {

                        XuLyDocGia.ThemDocGia(s);
                        DialogResult dg = MessageBox.Show("Thêm thành công độc giả " + txtTenDocGia.Text + "!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (sendData != null)
                        {
                            sendData();
                        }

                        if (dg == DialogResult.OK)
                        {
                            ResetTextBox();
                        }
                    }
                    else
                    {
                        DialogResult dg = MessageBox.Show("Mã độc giả đã tồn tại !", "Thông báo", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {
                            txtMaDocGia.Clear();
                            txtMaDocGia.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin độc giả", "Thông báo", MessageBoxButtons.YesNo);
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Đã có lỗi, vui lòng kiểm tra lại thông tin !" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkFormRong())
                {
                    XuLyFormDocGia xuLyCapNhat = new XuLyFormDocGia();
                    DocGia dg = LayDocGia();
                    xuLyCapNhat.CapNhatDocGia(dg);
                    DialogResult result = MessageBox.Show("Cập nhật thành công độc giả " + txtTenDocGia.Text + " !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi " + ex, "Thôngbáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
                
        }
    }
}
