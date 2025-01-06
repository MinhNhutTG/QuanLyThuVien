namespace QUANLYTHUVIEN
{
    partial class QuanLyMuonTraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lsvPhieuMuon = new System.Windows.Forms.ListView();
            this.colMaPhieuMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHanTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhiPhat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaDocGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaThuThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(518, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Mượn Trả";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(412, 102);
            this.txtSearch.MaxLength = 6;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 28);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(758, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 42);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnOut);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(923, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 660);
            this.panel2.TabIndex = 6;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(39, 269);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(164, 67);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(39, 497);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(164, 67);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(39, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 67);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(39, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 67);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(39, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 67);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lsvPhieuMuon
            // 
            this.lsvPhieuMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhieuMuon,
            this.colNgayMuon,
            this.colNgayTra,
            this.colHanTra,
            this.colSoLuong,
            this.colTinhTrang,
            this.colPhiPhat,
            this.colMaDocGia,
            this.colMaThuThu});
            this.lsvPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPhieuMuon.FullRowSelect = true;
            this.lsvPhieuMuon.GridLines = true;
            this.lsvPhieuMuon.HideSelection = false;
            this.lsvPhieuMuon.Location = new System.Drawing.Point(27, 183);
            this.lsvPhieuMuon.Name = "lsvPhieuMuon";
            this.lsvPhieuMuon.Size = new System.Drawing.Size(872, 571);
            this.lsvPhieuMuon.TabIndex = 7;
            this.lsvPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lsvPhieuMuon.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhieuMuon
            // 
            this.colMaPhieuMuon.Text = "Mã phiếu mượn";
            this.colMaPhieuMuon.Width = 116;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.Text = "Ngày mượn";
            this.colNgayMuon.Width = 150;
            // 
            // colNgayTra
            // 
            this.colNgayTra.Text = "Ngày trả";
            this.colNgayTra.Width = 150;
            // 
            // colHanTra
            // 
            this.colHanTra.Text = "Hạn trả";
            this.colHanTra.Width = 150;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 104;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Text = "Tình trạng";
            this.colTinhTrang.Width = 111;
            // 
            // colPhiPhat
            // 
            this.colPhiPhat.Text = "Phí phạt";
            this.colPhiPhat.Width = 111;
            // 
            // colMaDocGia
            // 
            this.colMaDocGia.Text = "Mã đọc giả";
            this.colMaDocGia.Width = 121;
            // 
            // colMaThuThu
            // 
            this.colMaThuThu.Text = "Mã thủ thư";
            this.colMaThuThu.Width = 117;
            // 
            // QuanLyMuonTraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 817);
            this.Controls.Add(this.lsvPhieuMuon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyMuonTraForm";
            this.Text = "QuanLyMuonTraForm";
            this.Load += new System.EventHandler(this.QuanLyMuonTraForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
      //  private QuanLyThuVienDataSetTableAdapters.PHIEUMUONTableAdapter pHIEUMUONTableAdapter;
       // private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lsvPhieuMuon;
        private System.Windows.Forms.ColumnHeader colMaPhieuMuon;
        private System.Windows.Forms.ColumnHeader colNgayMuon;
        private System.Windows.Forms.ColumnHeader colNgayTra;
        private System.Windows.Forms.ColumnHeader colHanTra;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colTinhTrang;
        private System.Windows.Forms.ColumnHeader colPhiPhat;
        private System.Windows.Forms.ColumnHeader colMaDocGia;
        private System.Windows.Forms.ColumnHeader colMaThuThu;
        private System.Windows.Forms.Button btnView;
    }
}