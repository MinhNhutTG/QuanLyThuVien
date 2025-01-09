namespace QUANLYTHUVIEN.GUI_QLThongKe
{
    partial class GUI_ThongKeMuonTra
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
            this.txtTongSoSach = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMuonTrongNgay = new System.Windows.Forms.RadioButton();
            this.rdbMuontrongtuan = new System.Windows.Forms.RadioButton();
            this.rdbDangmuon = new System.Windows.Forms.RadioButton();
            this.lsvDanhsach = new System.Windows.Forms.ListView();
            this.colMaPhieuMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaDocGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rdbMuontrongthang = new System.Windows.Forms.RadioButton();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTongSoSach
            // 
            this.txtTongSoSach.Location = new System.Drawing.Point(146, 299);
            this.txtTongSoSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongSoSach.Name = "txtTongSoSach";
            this.txtTongSoSach.ReadOnly = true;
            this.txtTongSoSach.Size = new System.Drawing.Size(87, 20);
            this.txtTongSoSach.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 55);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(130, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ MƯỢN TRẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng số sách đã mượn:";
            // 
            // rdbMuonTrongNgay
            // 
            this.rdbMuonTrongNgay.AutoSize = true;
            this.rdbMuonTrongNgay.Location = new System.Drawing.Point(29, 86);
            this.rdbMuonTrongNgay.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMuonTrongNgay.Name = "rdbMuonTrongNgay";
            this.rdbMuonTrongNgay.Size = new System.Drawing.Size(105, 17);
            this.rdbMuonTrongNgay.TabIndex = 13;
            this.rdbMuonTrongNgay.TabStop = true;
            this.rdbMuonTrongNgay.Text = "Mượn trong ngày";
            this.rdbMuonTrongNgay.UseVisualStyleBackColor = true;
            this.rdbMuonTrongNgay.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbMuontrongtuan
            // 
            this.rdbMuontrongtuan.AutoSize = true;
            this.rdbMuontrongtuan.Location = new System.Drawing.Point(156, 86);
            this.rdbMuontrongtuan.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMuontrongtuan.Name = "rdbMuontrongtuan";
            this.rdbMuontrongtuan.Size = new System.Drawing.Size(103, 17);
            this.rdbMuontrongtuan.TabIndex = 14;
            this.rdbMuontrongtuan.TabStop = true;
            this.rdbMuontrongtuan.Text = "Mượn trong tuần";
            this.rdbMuontrongtuan.UseVisualStyleBackColor = true;
            this.rdbMuontrongtuan.CheckedChanged += new System.EventHandler(this.rdbMuontrongtuan_CheckedChanged);
            // 
            // rdbDangmuon
            // 
            this.rdbDangmuon.AutoSize = true;
            this.rdbDangmuon.Location = new System.Drawing.Point(430, 86);
            this.rdbDangmuon.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDangmuon.Name = "rdbDangmuon";
            this.rdbDangmuon.Size = new System.Drawing.Size(80, 17);
            this.rdbDangmuon.TabIndex = 15;
            this.rdbDangmuon.TabStop = true;
            this.rdbDangmuon.Text = "Đang mượn";
            this.rdbDangmuon.UseVisualStyleBackColor = true;
            this.rdbDangmuon.CheckedChanged += new System.EventHandler(this.rdbDangmuon_CheckedChanged);
            // 
            // lsvDanhsach
            // 
            this.lsvDanhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhieuMuon,
            this.colNgayMuon,
            this.colNgayTra,
            this.colMaDocGia});
            this.lsvDanhsach.GridLines = true;
            this.lsvDanhsach.HideSelection = false;
            this.lsvDanhsach.Location = new System.Drawing.Point(8, 113);
            this.lsvDanhsach.Margin = new System.Windows.Forms.Padding(2);
            this.lsvDanhsach.Name = "lsvDanhsach";
            this.lsvDanhsach.Size = new System.Drawing.Size(519, 173);
            this.lsvDanhsach.TabIndex = 16;
            this.lsvDanhsach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhsach.View = System.Windows.Forms.View.Details;
            this.lsvDanhsach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhsach_SelectedIndexChanged);
            // 
            // colMaPhieuMuon
            // 
            this.colMaPhieuMuon.Text = "Mã Phiếu Mượn";
            this.colMaPhieuMuon.Width = 150;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.Text = "Ngày Mượn";
            this.colNgayMuon.Width = 191;
            // 
            // colNgayTra
            // 
            this.colNgayTra.Text = "Ngày Trả";
            this.colNgayTra.Width = 221;
            // 
            // colMaDocGia
            // 
            this.colMaDocGia.Text = "Mã Độc Giả";
            this.colMaDocGia.Width = 246;
            // 
            // rdbMuontrongthang
            // 
            this.rdbMuontrongthang.AutoSize = true;
            this.rdbMuontrongthang.Location = new System.Drawing.Point(295, 86);
            this.rdbMuontrongthang.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMuontrongthang.Name = "rdbMuontrongthang";
            this.rdbMuontrongthang.Size = new System.Drawing.Size(109, 17);
            this.rdbMuontrongthang.TabIndex = 17;
            this.rdbMuontrongthang.TabStop = true;
            this.rdbMuontrongthang.Text = "Mượn trong tháng";
            this.rdbMuontrongthang.UseVisualStyleBackColor = true;
            this.rdbMuontrongthang.CheckedChanged += new System.EventHandler(this.rdbMuontrongthang_CheckedChanged);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXuatFile.Location = new System.Drawing.Point(395, 299);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(82, 25);
            this.btnXuatFile.TabIndex = 18;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // GUI_ThongKeMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 341);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.rdbMuontrongthang);
            this.Controls.Add(this.lsvDanhsach);
            this.Controls.Add(this.rdbDangmuon);
            this.Controls.Add(this.rdbMuontrongtuan);
            this.Controls.Add(this.rdbMuonTrongNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongSoSach);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_ThongKeMuonTra";
            this.Text = "ThongKe2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTongSoSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMuonTrongNgay;
        private System.Windows.Forms.RadioButton rdbMuontrongtuan;
        private System.Windows.Forms.RadioButton rdbDangmuon;
        private System.Windows.Forms.ListView lsvDanhsach;
        private System.Windows.Forms.ColumnHeader colMaPhieuMuon;
        private System.Windows.Forms.ColumnHeader colNgayMuon;
        private System.Windows.Forms.ColumnHeader colNgayTra;
        private System.Windows.Forms.ColumnHeader colMaDocGia;
        private System.Windows.Forms.RadioButton rdbMuontrongthang;
        private System.Windows.Forms.Button btnXuatFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}