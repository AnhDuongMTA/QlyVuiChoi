namespace QuanLyKhuVuiChoi
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMuaVe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.cmbGioiTinh);
            this.groupBox1.Controls.Add(this.txtNamSinh);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 115);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(727, 28);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(174, 25);
            this.txtSDT.TabIndex = 32;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(423, 25);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(206, 25);
            this.cmbGioiTinh.TabIndex = 31;
            this.cmbGioiTinh.Text = "Nam";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(423, 67);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(206, 26);
            this.txtNamSinh.TabIndex = 15;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(94, 66);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(206, 26);
            this.txtTenKH.TabIndex = 11;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(94, 23);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(206, 26);
            this.txtMaKH.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Năm Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "SDT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMuaVe);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(917, 95);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(466, 24);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 58);
            this.btnHuy.TabIndex = 11;
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
            this.btnLuu.Location = new System.Drawing.Point(382, 24);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(61, 58);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(568, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(61, 58);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(283, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 58);
            this.btnXoa.TabIndex = 6;
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
            this.btnSua.Location = new System.Drawing.Point(197, 24);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 58);
            this.btnSua.TabIndex = 5;
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
            this.btnThem.Location = new System.Drawing.Point(103, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 58);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(641, 257);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 28);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(181, 256);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(259, 26);
            this.txtTimKiem.TabIndex = 35;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(760, 256);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(104, 29);
            this.btnLamMoi.TabIndex = 37;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Theo Mã Khách Hàng",
            "Theo Tên Khách Hàng",
            "Theo Giới Tính",
            "Theo Năm Sinh"});
            this.cbTimKiem.Location = new System.Drawing.Point(446, 255);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(171, 27);
            this.cbTimKiem.TabIndex = 36;
            this.cbTimKiem.Text = "Theo Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvKhachHang);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(919, 252);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Viên";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ma_KH,
            this.Ten_KH,
            this.Nam_Sinh,
            this.Gioi_Tinh,
            this.SDT});
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 22);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(913, 227);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvKhachHang_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 70;
            // 
            // Ma_KH
            // 
            this.Ma_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_KH.DataPropertyName = "Ma_KH";
            this.Ma_KH.HeaderText = "Mã NV";
            this.Ma_KH.Name = "Ma_KH";
            // 
            // Ten_KH
            // 
            this.Ten_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten_KH.DataPropertyName = "Ten_KH";
            this.Ten_KH.HeaderText = "Họ Tên";
            this.Ten_KH.Name = "Ten_KH";
            // 
            // Nam_Sinh
            // 
            this.Nam_Sinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nam_Sinh.DataPropertyName = "Nam_Sinh";
            this.Nam_Sinh.HeaderText = "Năm Sinh";
            this.Nam_Sinh.Name = "Nam_Sinh";
            // 
            // Gioi_Tinh
            // 
            this.Gioi_Tinh.DataPropertyName = "Gioi_Tinh";
            this.Gioi_Tinh.HeaderText = "Giới Tính";
            this.Gioi_Tinh.Name = "Gioi_Tinh";
            this.Gioi_Tinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Gioi_Tinh.Width = 200;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            // 
            // btnMuaVe
            // 
            this.btnMuaVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaVe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMuaVe.Image = ((System.Drawing.Image)(resources.GetObject("btnMuaVe.Image")));
            this.btnMuaVe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMuaVe.Location = new System.Drawing.Point(794, 27);
            this.btnMuaVe.Margin = new System.Windows.Forms.Padding(5);
            this.btnMuaVe.Name = "btnMuaVe";
            this.btnMuaVe.Size = new System.Drawing.Size(83, 55);
            this.btnMuaVe.TabIndex = 15;
            this.btnMuaVe.Text = "Mua Vé";
            this.btnMuaVe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMuaVe.UseVisualStyleBackColor = true;
            this.btnMuaVe.Click += new System.EventHandler(this.btnMuaVe_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(940, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Button btnMuaVe;
    }
}