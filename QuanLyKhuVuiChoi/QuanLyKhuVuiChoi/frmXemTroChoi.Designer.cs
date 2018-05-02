namespace QuanLyKhuVuiChoi
{
    partial class frmXemTroChoi
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
            this.dgvXemTC = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemTC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXemTC
            // 
            this.dgvXemTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemTC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaTC,
            this.TenTC,
            this.MaKhu,
            this.GiaNL,
            this.GiaTE});
            this.dgvXemTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXemTC.Location = new System.Drawing.Point(0, 0);
            this.dgvXemTC.Name = "dgvXemTC";
            this.dgvXemTC.Size = new System.Drawing.Size(749, 262);
            this.dgvXemTC.TabIndex = 0;
            this.dgvXemTC.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvXemTC_RowPrePaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaTC
            // 
            this.MaTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTC.DataPropertyName = "Ma_TroChoi";
            this.MaTC.HeaderText = "Mã Trò Chơi";
            this.MaTC.Name = "MaTC";
            // 
            // TenTC
            // 
            this.TenTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTC.DataPropertyName = "Ten_TroChoi";
            this.TenTC.HeaderText = "Tên Trò Chơi";
            this.TenTC.Name = "TenTC";
            // 
            // MaKhu
            // 
            this.MaKhu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKhu.DataPropertyName = "Ma_Khu";
            this.MaKhu.HeaderText = "Mã Khu";
            this.MaKhu.Name = "MaKhu";
            // 
            // GiaNL
            // 
            this.GiaNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaNL.DataPropertyName = "Gia_NL";
            this.GiaNL.HeaderText = "Giá Người Lớn";
            this.GiaNL.Name = "GiaNL";
            // 
            // GiaTE
            // 
            this.GiaTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaTE.DataPropertyName = "Gia_TE";
            this.GiaTE.HeaderText = "Giá Trẻ Em";
            this.GiaTE.Name = "GiaTE";
            // 
            // frmXemTroChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 262);
            this.Controls.Add(this.dgvXemTC);
            this.Name = "frmXemTroChoi";
            this.Text = "frmXemTroChoi";
            this.Load += new System.EventHandler(this.frmXemTroChoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXemTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTE;
    }
}