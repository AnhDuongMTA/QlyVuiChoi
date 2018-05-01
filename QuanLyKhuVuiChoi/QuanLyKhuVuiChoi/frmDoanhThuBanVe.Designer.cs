namespace QuanLyKhuVuiChoi
{
    partial class frmDoanhThuBanVe
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
            this.dateNgayBan1 = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBan2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvDoanhThuBanVe = new System.Windows.Forms.DataGridView();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.SoVeNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVeNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoVeTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVeTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuBanVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNgayBan1
            // 
            this.dateNgayBan1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBan1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayBan1.Location = new System.Drawing.Point(79, 13);
            this.dateNgayBan1.Name = "dateNgayBan1";
            this.dateNgayBan1.Size = new System.Drawing.Size(130, 22);
            this.dateNgayBan1.TabIndex = 0;
            // 
            // dateNgayBan2
            // 
            this.dateNgayBan2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBan2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayBan2.Location = new System.Drawing.Point(277, 12);
            this.dateNgayBan2.Name = "dateNgayBan2";
            this.dateNgayBan2.Size = new System.Drawing.Size(131, 22);
            this.dateNgayBan2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "đến:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(457, 11);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDoanhThuBanVe);
            this.groupBox1.Location = new System.Drawing.Point(0, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 282);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu bán vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "VNĐ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(473, 347);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 22);
            this.lblTongTien.TabIndex = 4;
            // 
            // dgvDoanhThuBanVe
            // 
            this.dgvDoanhThuBanVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuBanVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoVeNL,
            this.GiaVeNL,
            this.SoVeTE,
            this.GiaVeTE,
            this.TongTien});
            this.dgvDoanhThuBanVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThuBanVe.Location = new System.Drawing.Point(3, 16);
            this.dgvDoanhThuBanVe.Name = "dgvDoanhThuBanVe";
            this.dgvDoanhThuBanVe.Size = new System.Drawing.Size(708, 263);
            this.dgvDoanhThuBanVe.TabIndex = 0;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.Location = new System.Drawing.Point(552, 11);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(75, 23);
            this.btnInPhieu.TabIndex = 5;
            this.btnInPhieu.Text = "In Phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // SoVeNL
            // 
            this.SoVeNL.DataPropertyName = "SoVeNL";
            this.SoVeNL.HeaderText = "Số vé người lớn";
            this.SoVeNL.Name = "SoVeNL";
            this.SoVeNL.Width = 80;
            // 
            // GiaVeNL
            // 
            this.GiaVeNL.DataPropertyName = "GiaVeNL";
            this.GiaVeNL.HeaderText = "Giá vé người lớn";
            this.GiaVeNL.Name = "GiaVeNL";
            this.GiaVeNL.Width = 170;
            // 
            // SoVeTE
            // 
            this.SoVeTE.DataPropertyName = "SoVeTE";
            this.SoVeTE.HeaderText = "Số vé trẻ em";
            this.SoVeTE.Name = "SoVeTE";
            this.SoVeTE.Width = 80;
            // 
            // GiaVeTE
            // 
            this.GiaVeTE.DataPropertyName = "GiaVeTE";
            this.GiaVeTE.HeaderText = "Giá vé trẻ em";
            this.GiaVeTE.Name = "GiaVeTE";
            this.GiaVeTE.Width = 170;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Thành tiền";
            this.TongTien.Name = "TongTien";
            // 
            // frmDoanhThuBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 388);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateNgayBan2);
            this.Controls.Add(this.dateNgayBan1);
            this.Name = "frmDoanhThuBanVe";
            this.Text = "frmDoanhThuBanVe";
            this.Load += new System.EventHandler(this.frmDoanhThuBanVe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuBanVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateNgayBan1;
        private System.Windows.Forms.DateTimePicker dateNgayBan2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvDoanhThuBanVe;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoVeNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVeNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoVeTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVeTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}