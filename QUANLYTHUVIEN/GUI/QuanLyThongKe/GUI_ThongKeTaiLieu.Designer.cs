namespace QUANLYTHUVIEN.GUI_QLThongKe
{
    partial class GUI_ThongKeTaiLieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvdanhsach = new System.Windows.Forms.ListView();
            this.colMaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbSachdangchomuon = new System.Windows.Forms.RadioButton();
            this.rdbSachcontrongkho = new System.Windows.Forms.RadioButton();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(188, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ TÀI LIỆU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvdanhsach);
            this.groupBox1.Location = new System.Drawing.Point(16, 166);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(689, 244);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // lsvdanhsach
            // 
            this.lsvdanhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSach,
            this.colTenSach,
            this.colTinhTrang});
            this.lsvdanhsach.GridLines = true;
            this.lsvdanhsach.HideSelection = false;
            this.lsvdanhsach.Location = new System.Drawing.Point(5, 20);
            this.lsvdanhsach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvdanhsach.Name = "lsvdanhsach";
            this.lsvdanhsach.Size = new System.Drawing.Size(685, 221);
            this.lsvdanhsach.TabIndex = 0;
            this.lsvdanhsach.UseCompatibleStateImageBehavior = false;
            this.lsvdanhsach.View = System.Windows.Forms.View.Details;
            // 
            // colMaSach
            // 
            this.colMaSach.Text = "Mã Cuốn Sách";
            this.colMaSach.Width = 160;
            // 
            // colTenSach
            // 
            this.colTenSach.Text = "Tên Sách";
            this.colTenSach.Width = 200;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Text = "Tình Trạng";
            this.colTinhTrang.Width = 180;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 68);
            this.panel1.TabIndex = 7;
            // 
            // rdbSachdangchomuon
            // 
            this.rdbSachdangchomuon.AutoSize = true;
            this.rdbSachdangchomuon.Location = new System.Drawing.Point(57, 117);
            this.rdbSachdangchomuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSachdangchomuon.Name = "rdbSachdangchomuon";
            this.rdbSachdangchomuon.Size = new System.Drawing.Size(154, 20);
            this.rdbSachdangchomuon.TabIndex = 9;
            this.rdbSachdangchomuon.TabStop = true;
            this.rdbSachdangchomuon.Text = "Sách đang cho mượn";
            this.rdbSachdangchomuon.UseVisualStyleBackColor = true;
            this.rdbSachdangchomuon.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbSachcontrongkho
            // 
            this.rdbSachcontrongkho.AutoSize = true;
            this.rdbSachcontrongkho.Location = new System.Drawing.Point(391, 117);
            this.rdbSachcontrongkho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSachcontrongkho.Name = "rdbSachcontrongkho";
            this.rdbSachcontrongkho.Size = new System.Drawing.Size(142, 20);
            this.rdbSachcontrongkho.TabIndex = 10;
            this.rdbSachcontrongkho.TabStop = true;
            this.rdbSachcontrongkho.Text = "Sách còn trong kho";
            this.rdbSachcontrongkho.UseVisualStyleBackColor = true;
            this.rdbSachcontrongkho.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXuatFile.Location = new System.Drawing.Point(572, 442);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(129, 38);
            this.btnXuatFile.TabIndex = 11;
            this.btnXuatFile.Text = "Ghi log";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_ThongKeTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 514);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.rdbSachcontrongkho);
            this.Controls.Add(this.rdbSachdangchomuon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI_ThongKeTaiLieu";
            this.Text = "ThongKeForm1";
            this.Load += new System.EventHandler(this.GUI_ThongKeTaiLieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbSachdangchomuon;
        private System.Windows.Forms.RadioButton rdbSachcontrongkho;
        private System.Windows.Forms.ListView lsvdanhsach;
        private System.Windows.Forms.ColumnHeader colMaSach;
        private System.Windows.Forms.ColumnHeader colTenSach;
        private System.Windows.Forms.ColumnHeader colTinhTrang;
        private System.Windows.Forms.Button btnXuatFile;
    }
}