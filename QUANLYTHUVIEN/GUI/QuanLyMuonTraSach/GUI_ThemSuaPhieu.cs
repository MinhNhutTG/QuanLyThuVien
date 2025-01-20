using QUANLYTHUVIEN.DAL;
using System;
using System.Data;
using System.Windows.Forms;
using QUANLYTHUVIEN.DTO;
using QUANLYTHUVIEN.BLL;
using System.Collections.Generic;

namespace QUANLYTHUVIEN
{
    public partial class GUI_ThemSuaPhieu : Form
    {
        BLL_PhieuMuon BusPM = new BLL_PhieuMuon();
        public delegate void LoadHandler();
        public event LoadHandler sendData;

        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }

        public GUI_ThemSuaPhieu(string MaThuThu, bool b)
        {

            InitializeComponent();
            txtMathuthu.Text = MaThuThu;
            SetButton(b);

            LoadDSSach(BusPM.LayDSSachConSan());
            LoadDSDocGia(BusPM.LayDSSearchOfDocGia(txtMadocgia.Text));

        }

        public GUI_ThemSuaPhieu(bool b,string MaPhieuMuon) //Hien thi thong tin phieu muon trong form
        {
            InitializeComponent();
            SetButton(b);
            DataTable dt = BusPM.LayThongTinPhieu(MaPhieuMuon);
            DataTable ctpm = BusPM.LayChiTietPhieuMuon(MaPhieuMuon);
            HienThiThongTinPhieu(dt);
            HienThiChiTietPhieu(ctpm);
        }

        public void SetButton(bool b)
        {
            btnAdd.Enabled = b;
            btnUpdate.Enabled = !b;
            btnRefresh.Enabled = b;
            btnOut.Enabled = true;
        }

       
        public void HienThiChiTietPhieu(DataTable dt) //Hien thi danh sach cac cuon sach trong phieu muon
        {
           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvListSach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
            }

        }
        
        public void HienThiThongTinPhieu(DataTable dt) //Hien thi thong tin phieu muon trong form
        {
            txtMaphieumuon.Text = dt.Rows[0][0].ToString();
            dtpNgaymuon.Text = dt.Rows[0][1].ToString();
            dtpNgaytra.Text = dt.Rows[0][2].ToString();
            dtpHantra.Text = dt.Rows[0][3].ToString();
            nudSoluong.Text = dt.Rows[0][4].ToString();
            cboTinhtrang.Text = dt.Rows[0][5].ToString();
            txtPhiphat.Text = dt.Rows[0][6].ToString();
            txtMadocgia.Text = dt.Rows[0][7].ToString();
            txtMathuthu.Text = dt.Rows[0][8].ToString();
        }

        public void LoadDSSach(DataTable dt)  //Hien thi danh sach cac cuon sach trong form
        {
            lsvSearchSach.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvSearchSach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }

        public void LoadDSDocGia(DataTable dtdg)
        {
            lsvSearchDocGia.Items.Clear();
            for (int i = 0; i < dtdg.Rows.Count; i++)
            {
                ListViewItem item = lsvSearchDocGia.Items.Add(dtdg.Rows[i][0].ToString());
                item.SubItems.Add(dtdg.Rows[i][1].ToString());
                item.SubItems.Add(dtdg.Rows[i][2].ToString());
                item.SubItems.Add(dtdg.Rows[i][3].ToString());
                item.SubItems.Add(dtdg.Rows[i][4].ToString());
            }
        }

        private PhieuMuon LayPhieuMuon() //Lay thong tin phieu muon tu form 
        {
            PhieuMuon pm = new PhieuMuon();
            pm.MaPhieuMuon = txtMaphieumuon.Text;
            pm.NgayMuon = DateTime.Parse(dtpNgaymuon.Value.ToShortDateString());
            pm.NgayTra = DateTime.Parse(dtpNgaytra.Value.ToShortDateString());
            pm.HanTra = DateTime.Parse(dtpHantra.Value.ToShortDateString());
            pm.SoLuong = int.Parse(nudSoluong.Value.ToString());
            pm.TinhTrang = cboTinhtrang.Text;
            pm.PhiPhat = int.Parse(txtPhiphat.Text);
            pm.MaDocGia = txtMadocgia.Text;
            pm.MaThuThu = txtMathuthu.Text;
            return pm;
        }

        public List<Sach> LayDSSach()
        {
            List<Sach> list = new List<Sach>();
            for (int i = 0; i < lsvListSach.Items.Count; i++)
            {
                Sach s = new Sach();
                s.setMaCuonSach(lsvListSach.Items[i].SubItems[0].Text);
                list.Add(s);
            }
            return list;
        }
        private void btnOut_Click(object sender, EventArgs e) 
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trình quản lý mượn trả?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            PhieuMuon pm = LayPhieuMuon(); // Gán thông tin phiếu mượn từ form vào biến pm
            List<Sach> list = LayDSSach(); // Lấy danh sách sách từ listview
            try
            {
                if (BusPM.Add(pm ,list))
                {

                    MessageBox.Show("Thêm phiếu mượn thành công");
                    Refesh();
                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Không thể thêm phiếu mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (BLL_PhieuMuon.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PhieuMuon pm = LayPhieuMuon();
            List<Sach> listSach = LayDSSach(); // Lấy danh sách sách từ listview

            try
            {
                
                if (pm.TinhTrang == "Đang mượn" || pm.TinhTrang == "Quá hạn")
                {
                    BusPM.UpdatePhieu(pm); // Cập nhật thông tin phiếu mượn

                    // Xóa chi tiết phiếu mượn cũ
                    BusPM.UpdateXoaChiTietPhieu(pm.MaPhieuMuon);

                    // Thêm chi tiết phiếu mượn mới
                    foreach (Sach s in listSach)
                    {
                        BusPM.AddChiTietPhieu(pm.MaPhieuMuon, s.getMaCuonSach());
                    }

                    MessageBox.Show("Cập nhật phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (pm.TinhTrang == "Đã trả") // Nếu tình trạng là "Đã trả"
                {
                    // Cập nhật tình trạng phiếu mượn
                    BusPM.UpdateTrangThaiPhieu(pm.MaPhieuMuon);

                    // Cập nhật tình trạng sách
                    foreach (Sach s in listSach)
                    {
                        BusPM.UpdateTinhTrangSach(s.getMaCuonSach());
                    }

                    MessageBox.Show("Cập nhật phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                sendData?.Invoke();
            }
            catch (BLL_PhieuMuon.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void Refesh() //Hàm làm mới form
        {
            txtMaphieumuon.Text = string.Empty;
            dtpNgaymuon.Text = DateTime.Now.ToString();
            dtpNgaytra.Text = DateTime.Now.ToString();
            dtpHantra.Text = DateTime.Now.ToString();
            nudSoluong.Value = 1;
            cboTinhtrang.SelectedIndex = 0;
            txtPhiphat.Text = "0";
            txtMadocgia.Text = string.Empty;
            //txtMathuthu.Text = string.Empty;
            lsvListSach.Items.Clear();
        } 

        private void btnRefresh_Click(object sender, EventArgs e) //Lam moi form
        {
            Refesh();
        }

        private void btnSearchSach_Click(object sender, EventArgs e)
        {
            lsvSearchSach.Items.Clear();
            DAL_QuanLyPhieuMuon s = new DAL_QuanLyPhieuMuon();
            DataTable dts =s.LayDSSearchOfSach(txtSearchSach.Text); //Lấy danh sách sách từ database theo từ khóa tìm kiếm
            //LoadDSSach(dts); //Hiển thị danh sách sách lên listview
            foreach (DataRow row in dts.Rows)
            {
                // Kiểm tra tình trạng sách
                if (row["TinhTrang"].ToString() == "Còn sẵn") // Dieu kien de hien thi sach
                {
                    ListViewItem item = new ListViewItem(row["MaCuonSach"].ToString());
                    item.SubItems.Add(row["MaSach"].ToString());
                    item.SubItems.Add(row["TenSach"].ToString());
                    item.SubItems.Add(row["TinhTrang"].ToString());
                    item.SubItems.Add(row["SoLuong"].ToString());

                    // Thêm sách vào ListView
                    lsvSearchSach.Items.Add(item);
                }
            }
            
        }

        private void lsvSearchSach_SelectedIndexChanged(object sender, EventArgs e)         // Hien thi sach khi search
        {
            if (lsvSearchSach.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvSearchSach.SelectedItems[0];

                // Tạo một bản sao của item được chọn và thêm vào lsvListSach
                ListViewItem clonedItem = (ListViewItem)selectedItem.Clone();
                lsvListSach.Items.Add(clonedItem);

                lsvSearchSach.Items.Remove(selectedItem);
                nudSoluong.Value = lsvListSach.Items.Count;         // vì bắt đầu từ 1 nên dùng đếm số lượng sách trong listview để gán vào số lượng
                //nudSoluong.Value += 1;
            }
            
        }


        private void btnDelete_ListSach_Click(object sender, EventArgs e) 
        {

            try
            {
                // Kiểm tra xem có sách được chọn hay không
                if (lsvListSach.SelectedItems.Count > 0)
                {
                    // Xóa sách đang chọn trong danh sách sách
                    lsvListSach.SelectedItems[0].Remove();

                    //Cập nhật số lượng sách
                    nudSoluong.Value = lsvListSach.Items.Count;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một cuốn sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hiển thị thông báo lỗi
            }
        }

        private void btnSearchDocGia_Click(object sender, EventArgs e)
        {
            lsvSearchDocGia.Items.Clear();
            DataTable dtdg = BusPM.LayDSSearchOfDocGia(txtSearchDocGia.Text);
            LoadDSDocGia(dtdg);
        }

        private void lsvSearchDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtdg = BusPM.LayDSSearchOfDocGia(txtSearchDocGia.Text);
            if (lsvSearchDocGia.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvSearchDocGia.SelectedItems[0];

                txtMadocgia.Text = selectedItem.SubItems[0].Text;
            }
        }

     

        private void dtpNgaytra_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgaytra.Value > dtpHantra.Value)
            {
                float giaphat = 2000;
                TimeSpan ngaytre = dtpNgaytra.Value - dtpHantra.Value;
                int songaytre = Convert.ToInt32(ngaytre.Days);
                int soluong = Convert.ToInt32(nudSoluong.Value);
                cboTinhtrang.SelectedIndex = 2;

               
                txtPhiphat.Text = (songaytre * giaphat * soluong).ToString();
            }
            else
            {
                cboTinhtrang.SelectedIndex = 1;
                txtPhiphat.Text = null;
            }
        }

        private void txtPhiphat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            } 
        }
    }
}
