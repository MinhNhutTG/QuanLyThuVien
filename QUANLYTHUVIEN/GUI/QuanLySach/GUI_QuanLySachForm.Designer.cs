namespace QUANLYTHUVIEN.GUI
{
    partial class GUI_QuanLySachForm
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
            this.lsvSach = new System.Windows.Forms.ListView();
            this.MaCuonSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TheLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamXuatBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.CbbTheLoai = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1973, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(552, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // lsvSach
            // 
            this.lsvSach.BackColor = System.Drawing.Color.White;
            this.lsvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaCuonSach,
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.TacGia,
            this.NamXuatBan,
            this.Gia,
            this.TinhTrang});
            this.lsvSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvSach.FullRowSelect = true;
            this.lsvSach.GridLines = true;
            this.lsvSach.HideSelection = false;
            this.lsvSach.Location = new System.Drawing.Point(26, 154);
            this.lsvSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsvSach.Name = "lsvSach";
            this.lsvSach.Size = new System.Drawing.Size(1092, 431);
            this.lsvSach.TabIndex = 1;
            this.lsvSach.UseCompatibleStateImageBehavior = false;
            this.lsvSach.View = System.Windows.Forms.View.Details;
            // 
            // MaCuonSach
            // 
            this.MaCuonSach.Text = "Mã cuốn sách";
            this.MaCuonSach.Width = 63;
            // 
            // MaSach
            // 
            this.MaSach.Text = "Mã Sách";
            this.MaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên sách";
            this.TenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenSach.Width = 270;
            // 
            // TheLoai
            // 
            this.TheLoai.Text = "Thể loại";
            this.TheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TheLoai.Width = 120;
            // 
            // TacGia
            // 
            this.TacGia.Text = "Tác giả";
            this.TacGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TacGia.Width = 200;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.Text = "Năm xuất bản";
            this.NamXuatBan.Width = 100;
            // 
            // Gia
            // 
            this.Gia.Text = "Giá";
            this.Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gia.Width = 150;
            // 
            // TinhTrang
            // 
            this.TinhTrang.Text = "Tình Trạng";
            this.TinhTrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TinhTrang.Width = 95;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(759, 97);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(137, 36);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.MintCream;
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemSach.Location = new System.Drawing.Point(67, 33);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(130, 51);
            this.btnThemSach.TabIndex = 0;
            this.btnThemSach.Text = "Thêm Sách";
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.BackColor = System.Drawing.Color.MintCream;
            this.btnSuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaSach.Location = new System.Drawing.Point(307, 33);
            this.btnSuaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(130, 51);
            this.btnSuaSach.TabIndex = 1;
            this.btnSuaSach.Text = "Sửa Sách";
            this.btnSuaSach.UseVisualStyleBackColor = false;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.MintCream;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemChiTiet.Location = new System.Drawing.Point(545, 33);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(130, 51);
            this.btnXemChiTiet.TabIndex = 2;
            this.btnXemChiTiet.Text = "Xem Chi Tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.BackColor = System.Drawing.Color.MintCream;
            this.btnXoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaSach.Location = new System.Drawing.Point(767, 33);
            this.btnXoaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(130, 51);
            this.btnXoaSach.TabIndex = 3;
            this.btnXoaSach.Text = "Xóa Sách";
            this.btnXoaSach.UseVisualStyleBackColor = false;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoaSach);
            this.panel2.Controls.Add(this.btnXemChiTiet);
            this.panel2.Controls.Add(this.btnSuaSach);
            this.panel2.Controls.Add(this.btnThemSach);
            this.panel2.Location = new System.Drawing.Point(-8, 612);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 149);
            this.panel2.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MintCream;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(996, 33);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 51);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(913, 92);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(205, 45);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Quản lý thể loại Sách";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(470, 102);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.MaximumSize = new System.Drawing.Size(400, 50);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(282, 23);
            this.txtTimKiem.TabIndex = 6;
            // 
            // CbbTheLoai
            // 
            this.CbbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CbbTheLoai.FormattingEnabled = true;
            this.CbbTheLoai.Items.AddRange(new object[] {
            "None"});
            this.CbbTheLoai.Location = new System.Drawing.Point(223, 101);
            this.CbbTheLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbbTheLoai.Name = "CbbTheLoai";
            this.CbbTheLoai.Size = new System.Drawing.Size(175, 25);
            this.CbbTheLoai.TabIndex = 7;
            this.CbbTheLoai.SelectedIndexChanged += new System.EventHandler(this.CbbTheLoai_SelectedIndexChanged);
            // 
            // GUI_QuanLySachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1148, 750);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.CbbTheLoai);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lsvSach);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUI_QuanLySachForm";
            this.Text = "Quản lý sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_QuanLySachForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_QuanLySachForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvSach;
        private System.Windows.Forms.ColumnHeader MaCuonSach;
        private System.Windows.Forms.ColumnHeader TenSach;
        private System.Windows.Forms.ColumnHeader TacGia;
        private System.Windows.Forms.ColumnHeader NamXuatBan;
        private System.Windows.Forms.ColumnHeader Gia;
        private System.Windows.Forms.ColumnHeader TheLoai;
        private System.Windows.Forms.ColumnHeader MaSach;
        private System.Windows.Forms.ColumnHeader TinhTrang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox CbbTheLoai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCategory;
    }
}