namespace QUANLYTHUVIEN
{
    partial class GUI_XemChiTietPhieu
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
            this.txtMaphieumuon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSoluong = new System.Windows.Forms.NumericUpDown();
            this.cboTinhtrang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhiphat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMathuthu = new System.Windows.Forms.TextBox();
            this.dtpNgaytra = new System.Windows.Forms.DateTimePicker();
            this.dtpHantra = new System.Windows.Forms.DateTimePicker();
            this.txtMadocgia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.lsvCTPhieuMuon = new System.Windows.Forms.ListView();
            this.colMaCuonSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU MƯỢN SÁCH";
            this.label1.UseWaitCursor = true;
            // 
            // txtMaphieumuon
            // 
            this.txtMaphieumuon.Enabled = false;
            this.txtMaphieumuon.Location = new System.Drawing.Point(193, 118);
            this.txtMaphieumuon.MaxLength = 6;
            this.txtMaphieumuon.Name = "txtMaphieumuon";
            this.txtMaphieumuon.Size = new System.Drawing.Size(318, 22);
            this.txtMaphieumuon.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số lượng";
            // 
            // nudSoluong
            // 
            this.nudSoluong.Enabled = false;
            this.nudSoluong.Location = new System.Drawing.Point(193, 392);
            this.nudSoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoluong.Name = "nudSoluong";
            this.nudSoluong.Size = new System.Drawing.Size(318, 22);
            this.nudSoluong.TabIndex = 27;
            this.nudSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboTinhtrang
            // 
            this.cboTinhtrang.Enabled = false;
            this.cboTinhtrang.FormattingEnabled = true;
            this.cboTinhtrang.Items.AddRange(new object[] {
            "Đã trả",
            "Chưa trả",
            "Quá hạn"});
            this.cboTinhtrang.Location = new System.Drawing.Point(193, 431);
            this.cboTinhtrang.Name = "cboTinhtrang";
            this.cboTinhtrang.Size = new System.Drawing.Size(318, 24);
            this.cboTinhtrang.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Phí phạt";
            // 
            // txtPhiphat
            // 
            this.txtPhiphat.Enabled = false;
            this.txtPhiphat.Location = new System.Drawing.Point(192, 477);
            this.txtPhiphat.Name = "txtPhiphat";
            this.txtPhiphat.Size = new System.Drawing.Size(319, 22);
            this.txtPhiphat.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hạn trả";
            // 
            // txtMathuthu
            // 
            this.txtMathuthu.Enabled = false;
            this.txtMathuthu.Location = new System.Drawing.Point(193, 349);
            this.txtMathuthu.MaxLength = 6;
            this.txtMathuthu.Name = "txtMathuthu";
            this.txtMathuthu.Size = new System.Drawing.Size(318, 22);
            this.txtMathuthu.TabIndex = 28;
            // 
            // dtpNgaytra
            // 
            this.dtpNgaytra.Enabled = false;
            this.dtpNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaytra.Location = new System.Drawing.Point(193, 210);
            this.dtpNgaytra.Name = "dtpNgaytra";
            this.dtpNgaytra.Size = new System.Drawing.Size(318, 22);
            this.dtpNgaytra.TabIndex = 25;
            // 
            // dtpHantra
            // 
            this.dtpHantra.Enabled = false;
            this.dtpHantra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHantra.Location = new System.Drawing.Point(193, 260);
            this.dtpHantra.Name = "dtpHantra";
            this.dtpHantra.Size = new System.Drawing.Size(318, 22);
            this.dtpHantra.TabIndex = 26;
            // 
            // txtMadocgia
            // 
            this.txtMadocgia.Enabled = false;
            this.txtMadocgia.Location = new System.Drawing.Point(193, 307);
            this.txtMadocgia.MaxLength = 6;
            this.txtMadocgia.Name = "txtMadocgia";
            this.txtMadocgia.Size = new System.Drawing.Size(318, 22);
            this.txtMadocgia.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mã thủ thư";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mã đọc giả";
            // 
            // dtpNgaymuon
            // 
            this.dtpNgaymuon.Enabled = false;
            this.dtpNgaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaymuon.Location = new System.Drawing.Point(193, 159);
            this.dtpNgaymuon.Name = "dtpNgaymuon";
            this.dtpNgaymuon.Size = new System.Drawing.Size(318, 22);
            this.dtpNgaymuon.TabIndex = 24;
            // 
            // lsvCTPhieuMuon
            // 
            this.lsvCTPhieuMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaCuonSach,
            this.colMaSach,
            this.colTenSach});
            this.lsvCTPhieuMuon.FullRowSelect = true;
            this.lsvCTPhieuMuon.GridLines = true;
            this.lsvCTPhieuMuon.HideSelection = false;
            this.lsvCTPhieuMuon.Location = new System.Drawing.Point(568, 118);
            this.lsvCTPhieuMuon.Name = "lsvCTPhieuMuon";
            this.lsvCTPhieuMuon.Size = new System.Drawing.Size(483, 381);
            this.lsvCTPhieuMuon.TabIndex = 36;
            this.lsvCTPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lsvCTPhieuMuon.View = System.Windows.Forms.View.Details;
            // 
            // colMaCuonSach
            // 
            this.colMaCuonSach.Text = "Mã cuốn sách";
            this.colMaCuonSach.Width = 100;
            // 
            // colMaSach
            // 
            this.colMaSach.Text = "Mã sách";
            this.colMaSach.Width = 100;
            // 
            // colTenSach
            // 
            this.colTenSach.Text = "Tên sách";
            this.colTenSach.Width = 200;
            // 
            // QuanLyPhieuMuonForm_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 525);
            this.Controls.Add(this.lsvCTPhieuMuon);
            this.Controls.Add(this.txtMathuthu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMadocgia);
            this.Controls.Add(this.cboTinhtrang);
            this.Controls.Add(this.txtPhiphat);
            this.Controls.Add(this.nudSoluong);
            this.Controls.Add(this.dtpHantra);
            this.Controls.Add(this.dtpNgaytra);
            this.Controls.Add(this.dtpNgaymuon);
            this.Controls.Add(this.txtMaphieumuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuanLyPhieuMuonForm_ChiTiet";
            this.Text = "QuanLyPhieuMuonForm_ChiTiet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaphieumuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSoluong;
        private System.Windows.Forms.ComboBox cboTinhtrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhiphat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMathuthu;
        private System.Windows.Forms.DateTimePicker dtpNgaytra;
        private System.Windows.Forms.DateTimePicker dtpHantra;
        private System.Windows.Forms.TextBox txtMadocgia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgaymuon;
        private System.Windows.Forms.ListView lsvCTPhieuMuon;
        private System.Windows.Forms.ColumnHeader colMaCuonSach;
        private System.Windows.Forms.ColumnHeader colMaSach;
        private System.Windows.Forms.ColumnHeader colTenSach;
    }
}