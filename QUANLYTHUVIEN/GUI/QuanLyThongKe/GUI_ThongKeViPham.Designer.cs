namespace QUANLYTHUVIEN.GUI_QLThongKe
{
    partial class GUI_ThongKeViPham
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
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMaPhieuMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaDocGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhiPhat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongViPham = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ VI PHẠM THƯ VIỆN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhieuMuon,
            this.colNgayMuon,
            this.colNgayTra,
            this.colMaDocGia,
            this.colGiaHan,
            this.colPhiPhat});
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(8, 105);
            this.lsvDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(519, 165);
            this.lsvDanhSach.TabIndex = 1;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colMaPhieuMuon
            // 
            this.colMaPhieuMuon.Text = "Mã Phiếu Mượn";
            this.colMaPhieuMuon.Width = 140;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.Text = "Ngày Mượn";
            this.colNgayMuon.Width = 120;
            // 
            // colNgayTra
            // 
            this.colNgayTra.Text = "Ngày Trả";
            this.colNgayTra.Width = 125;
            // 
            // colMaDocGia
            // 
            this.colMaDocGia.Text = "Mã Độc Giả";
            this.colMaDocGia.Width = 150;
            // 
            // colGiaHan
            // 
            this.colGiaHan.Text = "Gia Hạn";
            this.colGiaHan.Width = 120;
            // 
            // colPhiPhat
            // 
            this.colPhiPhat.Text = "Phí Phạt";
            this.colPhiPhat.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng vi phạm:";
            // 
            // txtTongViPham
            // 
            this.txtTongViPham.Location = new System.Drawing.Point(123, 292);
            this.txtTongViPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongViPham.Name = "txtTongViPham";
            this.txtTongViPham.Size = new System.Drawing.Size(68, 20);
            this.txtTongViPham.TabIndex = 4;
            this.txtTongViPham.TextChanged += new System.EventHandler(this.txtTongViPham_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(405, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xuất File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_ThongKeViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTongViPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GUI_ThongKeViPham";
            this.Text = "ThongKeForm3";
            this.Load += new System.EventHandler(this.ThongKeForm3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongViPham;
        private System.Windows.Forms.ColumnHeader colMaPhieuMuon;
        private System.Windows.Forms.ColumnHeader colNgayMuon;
        private System.Windows.Forms.ColumnHeader colNgayTra;
        private System.Windows.Forms.ColumnHeader colMaDocGia;
        private System.Windows.Forms.ColumnHeader colGiaHan;
        private System.Windows.Forms.ColumnHeader colPhiPhat;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}