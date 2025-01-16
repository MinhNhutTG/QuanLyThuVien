namespace QUANLYTHUVIEN.GUI
{
    partial class GUI_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMoFormQLSACH = new System.Windows.Forms.ToolStripButton();
            this.btnMoFormQLPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnMoFormQLDocGia = new System.Windows.Forms.ToolStripButton();
            this.btnThongKe = new System.Windows.Forms.ToolStripButton();
            this.btnMoFormQLNhanVien = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoFormQLSACH,
            this.btnMoFormQLPhieu,
            this.btnMoFormQLDocGia,
            this.btnThongKe,
            this.btnMoFormQLNhanVien,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(192, 712);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
           
            this.toolStrip1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.toolStrip1_PreviewKeyDown);
            // 
            // btnMoFormQLSACH
            // 
            this.btnMoFormQLSACH.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMoFormQLSACH.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoFormQLSACH.ForeColor = System.Drawing.Color.White;
            this.btnMoFormQLSACH.Image = ((System.Drawing.Image)(resources.GetObject("btnMoFormQLSACH.Image")));
            this.btnMoFormQLSACH.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btnMoFormQLSACH.Margin = new System.Windows.Forms.Padding(1, 300, 0, 2);
            this.btnMoFormQLSACH.Name = "btnMoFormQLSACH";
            this.btnMoFormQLSACH.Padding = new System.Windows.Forms.Padding(10);
            this.btnMoFormQLSACH.Size = new System.Drawing.Size(190, 46);
            this.btnMoFormQLSACH.Text = "Quản lý sách";
            this.btnMoFormQLSACH.Click += new System.EventHandler(this.btnMoFormQLSACH_Click);
            // 
            // btnMoFormQLPhieu
            // 
            this.btnMoFormQLPhieu.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnMoFormQLPhieu.ForeColor = System.Drawing.Color.White;
            this.btnMoFormQLPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnMoFormQLPhieu.Image")));
            this.btnMoFormQLPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoFormQLPhieu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoFormQLPhieu.Name = "btnMoFormQLPhieu";
            this.btnMoFormQLPhieu.Padding = new System.Windows.Forms.Padding(10);
            this.btnMoFormQLPhieu.Size = new System.Drawing.Size(191, 46);
            this.btnMoFormQLPhieu.Text = "Quản lý mượn trả";
            this.btnMoFormQLPhieu.Click += new System.EventHandler(this.btnMoFormQLPhieu_Click);
            // 
            // btnMoFormQLDocGia
            // 
            this.btnMoFormQLDocGia.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnMoFormQLDocGia.ForeColor = System.Drawing.Color.White;
            this.btnMoFormQLDocGia.Image = ((System.Drawing.Image)(resources.GetObject("btnMoFormQLDocGia.Image")));
            this.btnMoFormQLDocGia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoFormQLDocGia.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoFormQLDocGia.Name = "btnMoFormQLDocGia";
            this.btnMoFormQLDocGia.Padding = new System.Windows.Forms.Padding(10);
            this.btnMoFormQLDocGia.Size = new System.Drawing.Size(191, 46);
            this.btnMoFormQLDocGia.Text = "Quản lý độc giả";
            this.btnMoFormQLDocGia.Click += new System.EventHandler(this.btnMoFormQLDocGia_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10);
            this.btnThongKe.Size = new System.Drawing.Size(191, 46);
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click_1);
            // 
            // btnMoFormQLNhanVien
            // 
            this.btnMoFormQLNhanVien.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnMoFormQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnMoFormQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnMoFormQLNhanVien.Image")));
            this.btnMoFormQLNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoFormQLNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoFormQLNhanVien.Name = "btnMoFormQLNhanVien";
            this.btnMoFormQLNhanVien.Padding = new System.Windows.Forms.Padding(10);
            this.btnMoFormQLNhanVien.Size = new System.Drawing.Size(191, 46);
            this.btnMoFormQLNhanVien.Text = "Nhân viên";
            this.btnMoFormQLNhanVien.Click += new System.EventHandler(this.btnMoFormQLNhanVien_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.toolStripButton5.ForeColor = System.Drawing.Color.White;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(1, 20, 0, 2);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripButton5.Size = new System.Drawing.Size(190, 46);
            this.toolStripButton5.Text = "Đăng xuất";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.toolStripButton6.ForeColor = System.Drawing.Color.White;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripButton6.Size = new System.Drawing.Size(191, 46);
            this.toolStripButton6.Text = "Thoát";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GUI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 712);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_Main";
            this.Text = "Quản lý thư viện";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMoFormQLSACH;
        private System.Windows.Forms.ToolStripButton btnMoFormQLPhieu;
        private System.Windows.Forms.ToolStripButton btnMoFormQLDocGia;
        private System.Windows.Forms.ToolStripButton btnMoFormQLNhanVien;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton btnThongKe;
    }
}

