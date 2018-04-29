namespace QuanLyKhuVuiChoi
{
    partial class frmPhieuMuaDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuMuaDichVu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.dtpNgayMua = new System.Windows.Forms.DateTimePicker();
            this.lbNgayMua = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPhieuMua = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDichVu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuMua)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaKH);
            this.groupBox1.Controls.Add(this.dtpNgayMua);
            this.groupBox1.Controls.Add(this.lbNgayMua);
            this.groupBox1.Controls.Add(this.lbMaKH);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.lbMaPhieu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(875, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Mua";
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(229, 104);
            this.cbMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(213, 24);
            this.cbMaKH.TabIndex = 9;
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.CustomFormat = "yyyy/MM/dd";
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMua.Location = new System.Drawing.Point(702, 51);
            this.dtpNgayMua.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(133, 24);
            this.dtpNgayMua.TabIndex = 8;
            // 
            // lbNgayMua
            // 
            this.lbNgayMua.AutoSize = true;
            this.lbNgayMua.Location = new System.Drawing.Point(501, 58);
            this.lbNgayMua.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNgayMua.Name = "lbNgayMua";
            this.lbNgayMua.Size = new System.Drawing.Size(71, 17);
            this.lbNgayMua.TabIndex = 3;
            this.lbNgayMua.Text = "Ngày Mua";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(28, 104);
            this.lbMaKH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(107, 17);
            this.lbMaKH.TabIndex = 4;
            this.lbMaKH.Text = "Mã Khách Hàng";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(229, 51);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(213, 24);
            this.txtMaPhieu.TabIndex = 7;
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.AutoSize = true;
            this.lbMaPhieu.Location = new System.Drawing.Point(28, 58);
            this.lbMaPhieu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(65, 17);
            this.lbMaPhieu.TabIndex = 5;
            this.lbMaPhieu.Text = "Mã Phiếu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietPhieuMua);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 218);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(875, 430);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Phiếu Mua ";
            // 
            // dgvChiTietPhieuMua
            // 
            this.dgvChiTietPhieuMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuMua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDichVu,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvChiTietPhieuMua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPhieuMua.Location = new System.Drawing.Point(4, 21);
            this.dgvChiTietPhieuMua.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietPhieuMua.Name = "dgvChiTietPhieuMua";
            this.dgvChiTietPhieuMua.RowTemplate.Height = 24;
            this.dgvChiTietPhieuMua.Size = new System.Drawing.Size(867, 319);
            this.dgvChiTietPhieuMua.TabIndex = 1;
            this.dgvChiTietPhieuMua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuMua_CellClick);
            this.dgvChiTietPhieuMua.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuMua_CellValueChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaDichVu
            // 
            this.MaDichVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDichVu.HeaderText = "Mã Dịch Vụ";
            this.MaDichVu.Name = "MaDichVu";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lương";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInPhieu);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 340);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnInPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieu.Image")));
            this.btnInPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInPhieu.Location = new System.Drawing.Point(613, 27);
            this.btnInPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(100, 50);
            this.btnInPhieu.TabIndex = 20;
            this.btnInPhieu.Text = "In Phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(755, 27);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(76, 50);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(501, 26);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(70, 50);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(373, 26);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 50);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(257, 26);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 50);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(145, 26);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 50);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(39, 23);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 50);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmPhieuMuaDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(891, 686);
            this.MinimumSize = new System.Drawing.Size(891, 686);
            this.Name = "frmPhieuMuaDichVu";
            this.Text = "Mua Dịch Vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuMuaDichVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuMua)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayMua;
        private System.Windows.Forms.Label lbNgayMua;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lbMaPhieu;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}