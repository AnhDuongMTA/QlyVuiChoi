namespace QuanLyKhuVuiChoi
{
    partial class frmXemTroChoiThuocKhuVuc
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
            this.dgvTroChoiThuocKhuVuc = new System.Windows.Forms.DataGridView();
            this.Ma_Khu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Khu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_TroChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_NL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_TE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTroChoiThuocKhuVuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTroChoiThuocKhuVuc
            // 
            this.dgvTroChoiThuocKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTroChoiThuocKhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Khu,
            this.Ten_Khu,
            this.Ten_TroChoi,
            this.Gia_NL,
            this.Gia_TE});
            this.dgvTroChoiThuocKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTroChoiThuocKhuVuc.Location = new System.Drawing.Point(0, 0);
            this.dgvTroChoiThuocKhuVuc.Name = "dgvTroChoiThuocKhuVuc";
            this.dgvTroChoiThuocKhuVuc.Size = new System.Drawing.Size(804, 363);
            this.dgvTroChoiThuocKhuVuc.TabIndex = 0;
            // 
            // Ma_Khu
            // 
            this.Ma_Khu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_Khu.DataPropertyName = "Ma_Khu";
            this.Ma_Khu.HeaderText = "Mã Khu";
            this.Ma_Khu.Name = "Ma_Khu";
            // 
            // Ten_Khu
            // 
            this.Ten_Khu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten_Khu.DataPropertyName = "Ten_Khu";
            this.Ten_Khu.HeaderText = "Tên Khu";
            this.Ten_Khu.Name = "Ten_Khu";
            // 
            // Ten_TroChoi
            // 
            this.Ten_TroChoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten_TroChoi.DataPropertyName = "Ten_TroChoi";
            this.Ten_TroChoi.HeaderText = "Tên Trò Chơi";
            this.Ten_TroChoi.Name = "Ten_TroChoi";
            // 
            // Gia_NL
            // 
            this.Gia_NL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia_NL.DataPropertyName = "Gia_NL";
            this.Gia_NL.HeaderText = "Giá Người Lớn";
            this.Gia_NL.Name = "Gia_NL";
            // 
            // Gia_TE
            // 
            this.Gia_TE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia_TE.DataPropertyName = "Gia_TE";
            this.Gia_TE.HeaderText = "Giá Trẻ Em";
            this.Gia_TE.Name = "Gia_TE";
            // 
            // frmXemTroChoiThuocKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 363);
            this.Controls.Add(this.dgvTroChoiThuocKhuVuc);
            this.Name = "frmXemTroChoiThuocKhuVuc";
            this.Text = "Khu vực trò chơi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemTroChoiThuocKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTroChoiThuocKhuVuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTroChoiThuocKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Khu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Khu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_TroChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_NL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_TE;
    }
}