namespace QuanLyKhuVuiChoi
{
    partial class frmTTDV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTTDV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTTDV);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 278);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Dịch Vụ Của Khu Vực";
            // 
            // dgvTTDV
            // 
            this.dgvTTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDV,
            this.TenTC,
            this.TenKhu,
            this.GiaDV});
            this.dgvTTDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTDV.Location = new System.Drawing.Point(3, 21);
            this.dgvTTDV.Name = "dgvTTDV";
            this.dgvTTDV.Size = new System.Drawing.Size(787, 254);
            this.dgvTTDV.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaDV
            // 
            this.MaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDV.DataPropertyName = "Ma_DV";
            this.MaDV.HeaderText = "Mã Dịch Vụ";
            this.MaDV.Name = "MaDV";
            // 
            // TenTC
            // 
            this.TenTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTC.DataPropertyName = "Ten_DV";
            this.TenTC.HeaderText = "Tên Dịch Vụ";
            this.TenTC.Name = "TenTC";
            // 
            // TenKhu
            // 
            this.TenKhu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhu.DataPropertyName = "Ten_Khu";
            this.TenKhu.HeaderText = "Tên Khu Vực";
            this.TenKhu.Name = "TenKhu";
            // 
            // GiaDV
            // 
            this.GiaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaDV.DataPropertyName = "Gia_DV";
            this.GiaDV.HeaderText = "Giá Dịch Vụ";
            this.GiaDV.Name = "GiaDV";
            // 
            // frmTTDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 278);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTTDV";
            this.Text = "frmTTDV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTTDV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
    }
}