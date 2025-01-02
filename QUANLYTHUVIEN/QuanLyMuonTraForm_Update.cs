using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QUANLYTHUVIEN
{
    public partial class QuanLyMuonTraForm_Update : Form
    {
        XuLyFormMuonTra s = new XuLyFormMuonTra();
        public delegate void LoadHandler();
        public event LoadHandler sendData;
        public QuanLyMuonTraForm_Update(string UserName, bool b)
        {
            XuLyLogin xl = new XuLyLogin();
            InitializeComponent();
            txtMathuthu.Text = xl.LayMaThuThu(UserName); 
            SetButton(b);
            DataTable dt = s.LayDSSearchOfSach(txtSearchSach.Text); s.LayDSSearchOfDocGia(txtMadocgia.Text) ;
            LoadDSSach(dt);

            //DataTable(dtdg) = s.LayDSSearchOfDocGia(txtSearchDocGia.Text);
            //LoadDSDocGia(dtdg);
            LoadDSDocGia(s.LayDSSearchOfDocGia(txtMadocgia.Text));

        }

        public QuanLyMuonTraForm_Update(bool b,string MaPhieuMuon) //Hien thi thong tin phieu muon trong form
        {
            InitializeComponent();
            SetButton(b);
            DataTable dt = s.LayThongTinPhieu(MaPhieuMuon);
            DataTable ctpm = s.LayChiTietPhieuMuon(MaPhieuMuon);
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
        //private bool CheckFormNull()
        //{
        //    if (string.IsNullOrEmpty(txtMaphieumuon.Text) ||
        //        string.IsNullOrEmpty(txtMadocgia.Text) ||
        //        string.IsNullOrEmpty(txtMathuthu.Text) ||
        //        string.IsNullOrEmpty(txtPhiphat.Text) ||
        //        string.IsNullOrEmpty(dtpNgaymuon.Text) ||
        //        string.IsNullOrEmpty(dtpNgaytra.Text) ||
        //        string.IsNullOrEmpty(dtpHantra.Text) ||
        //        string.IsNullOrEmpty(cboTinhtrang.Text) ||
        //        string.IsNullOrEmpty(nudSoluong.Text) ||
        //        lsvListSach.Items.Count == 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        private bool CheckData() //Kiem tra du lieu nhap vao form
        {
            if (string.IsNullOrEmpty(txtMaphieumuon.Text))
            {
                MessageBox.Show("Mã phiếu mượn không được để trống");
                return false;
            }
            if (string.IsNullOrEmpty(txtMadocgia.Text))
            {
                MessageBox.Show("Mã độc giả không được để trống");
                return false;
            }
            if (string.IsNullOrEmpty(txtMathuthu.Text))
            {
                MessageBox.Show("Mã thủ thư không được để trống");
                return false;
            }
            if (string.IsNullOrEmpty(txtPhiphat.Text))
            {
                MessageBox.Show("Phí phạt không được để trống");
                return false;
            }
            if (string.IsNullOrEmpty(dtpNgaymuon.Text))
            {
                MessageBox.Show("Ngày mượn không được để trống");
                return false;
            }
            if (string.IsNullOrEmpty(dtpNgaytra.Text))
            {
                MessageBox.Show("Ngày trả không được để trống");
                return false;
            }
            if (string.IsNullOrEmpty(dtpHantra.Text))
            {
                MessageBox.Show("Hạn trả không được để trống");
                return false;
            }
            if (string.IsNullOrEmpty(cboTinhtrang.Text))
            {
                MessageBox.Show("Tình trạng không được để trống");
                return false;
            }
            if (string.IsNullOrEmpty(nudSoluong.Text))
            {
                MessageBox.Show("Số lượng không được để trống");
                return false;
            }
            if (lsvListSach.Items.Count == 0)
            {
                MessageBox.Show("Danh sách sách không được để trống");
                return false;
            }
            if (dtpNgaytra.Value < dtpNgaymuon.Value)
            {
                MessageBox.Show("Ngày trả không được nhỏ hơn ngày mượn");
                return false;
            }
            if (dtpHantra.Value < dtpNgaymuon.Value)
            {
                MessageBox.Show("Hạn trả không được nhỏ hơn ngày mượn");
                return false;
            }

            return true;
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
            PhieuMuon m = new PhieuMuon();
            m.MaPhieuMuon = txtMaphieumuon.Text;
            m.NgayMuon = DateTime.Parse(dtpNgaymuon.Value.ToShortDateString());
            m.NgayTra = DateTime.Parse(dtpNgaytra.Value.ToShortDateString());
            m.HanTra = DateTime.Parse(dtpHantra.Value.ToShortDateString());
            m.SoLuong = int.Parse(nudSoluong.Value.ToString());
            m.TinhTrang = cboTinhtrang.SelectedItem.ToString();
            m.PhiPhat = int.Parse(txtPhiphat.Text);
            m.MaDocGia = txtMadocgia.Text;
            m.MaThuThu = txtMathuthu.Text;
            return m;
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
            try
            {
                if(!CheckData()) //Kiem tra du lieu nhap vao form
                {
                    return;
                }

                PhieuMuon pm = LayPhieuMuon(); // Gán thông tin phiếu mượn từ form vào biến pm
                s.Add(pm); //Thêm phiếu mượn vào database
                for (int i = 0; i < lsvListSach.Items.Count; i++) //Duyệt qua danh sách sách trong listview
                {
                    try
                    {
                        s.AddChiTietPhieu(pm.MaPhieuMuon, lsvListSach.Items[i].SubItems[0].Text); //Thêm chi tiết phiếu mượn vào database
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể thêm chi tiết phiếu cho sách: " + lsvListSach.Items[i].SubItems[0].Text);
                        Console.WriteLine(ex.Message);
                     }

                }
                MessageBox.Show("Thêm phiếu mượn thành công");
                Refesh();
                if (sendData != null)
                {
                    sendData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm phiếu mượn");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) //Kiem tra du lieu nhap vao form
                {
                    return;
                }
                XuLyFormMuonTra xl = new XuLyFormMuonTra();

                PhieuMuon pm = LayPhieuMuon();

                string[] tempMaCuonSach = new string[lsvListSach.Items.Count]; //Mảng lưu trữ mã cuốn sách
                for (int i = 0; i < lsvListSach.Items.Count; i++)   //Duyệt qua danh sách sách trong listview
                {
                    tempMaCuonSach[i] = lsvListSach.Items[i].SubItems[0].Text;  //Lưu mã cuốn sách vào mảng
                }

                if (cboTinhtrang.SelectedItem.ToString() == "Đang mượn") //Nếu tình trạng là Đang mượn
                {

                    xl.UpdatePhieu(pm); //Cập nhật phiếu mượn vào database
                    MessageBox.Show("Cập nhật phiếu mượn thành công");

                    xl.UpdateXoaChiTietPhieu(pm.MaPhieuMuon); 

                    for (int i = 0; i < tempMaCuonSach.Length; i++) //Duyệt qua mảng mã cuốn sách 
                    {
                        xl.AddChiTietPhieu(pm.MaPhieuMuon, tempMaCuonSach[i].ToString()); //Thêm chi tiết phiếu mượn vào database
                    }
                    lsvListSach.Items.Clear(); //Xóa danh sách sách trong listview
                    DataTable ctpm = s.LayChiTietPhieuMuon(pm.MaPhieuMuon); //Lấy danh sách sách trong phiếu mượn từ database
                    HienThiChiTietPhieu(ctpm); //Hiển thị danh sách sách trong listview
                }
                else if (cboTinhtrang.SelectedItem.ToString() == "Đã trả") //Nếu tình trạng là Đã trả
                {
                    MessageBox.Show("Cập nhật phiếu mượn thành công");
                    for (int i = 0; i < lsvListSach.Items.Count; i++) //Duyệt qua danh sách sách trong listview
                    {
                        xl.CapNhatTinhTrangSach(tempMaCuonSach[i]); //Cập nhật tình trạng sách trong database
                    }
                    xl.CapNhatTrangThaiPhieu(pm.MaPhieuMuon); //Cập nhật tình trạng phiếu mượn trong database


                }
                //Gửi dữ liệu cập nhật về form chính
                if (sendData != null)
                {
                    sendData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể cập nhật phiếu mượn.");
                Console.WriteLine(ex.Message);

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
            XuLyFormMuonTra s = new XuLyFormMuonTra();
            DataTable dts =s.LayDSSearchOfSach(txtSearchSach.Text); //Lấy danh sách sách từ database theo từ khóa tìm kiếm
            //LoadDSSach(dts); //Hiển thị danh sách sách lên listview
            foreach (DataRow row in dts.Rows)
            {
                // Kiểm tra tình trạng sách
                if (row["TinhTrang"].ToString() == "Còn sẵn") // Giả sử "TinhTrang" là tên cột trong DataTable
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

        private void lsvSearchSach_SelectedIndexChanged(object sender, EventArgs e) // Hien thi sach khi search
        {
            if (lsvSearchSach.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvSearchSach.SelectedItems[0];

                // Tạo một bản sao của item được chọn và thêm vào lsvListSach
                ListViewItem clonedItem = (ListViewItem)selectedItem.Clone();
                lsvListSach.Items.Add(clonedItem);

                lsvSearchSach.Items.Remove(selectedItem);
                nudSoluong.Value = lsvListSach.Items.Count; // vì bắt đầu từ 1 nên dùng đếm số lượng sách trong listview để gán vào số lượng
                //nudSoluong.Value += 1;
            }
            
        }


        private void btnDelete_ListSach_Click(object sender, EventArgs e) 
        {
            lsvListSach.SelectedItems[0].Remove(); //Xoa sach dang chon trong list Sach
            nudSoluong.Value = lsvListSach.Items.Count;
        }

        private void QuanLyMuonTraForm_Update_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchDocGia_Click(object sender, EventArgs e)
        {
            lsvSearchDocGia.Items.Clear();
            XuLyFormMuonTra s = new XuLyFormMuonTra();
            DataTable dtdg = s.LayDSSearchOfDocGia(txtSearchDocGia.Text);
            LoadDSDocGia(dtdg);
        }

        private void lsvSearchDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtdg = s.LayDSSearchOfDocGia(txtSearchDocGia.Text);
            if (lsvSearchDocGia.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvSearchDocGia.SelectedItems[0];

                txtMadocgia.Text = selectedItem.SubItems[0].Text;
            }
        }

        private void lsvListSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nudSoluong.Value = lsvListSach.SelectedItems.Count;
        }
    }
}
