namespace QuanLyKhuVuiChoi
{
    partial class frmTTTB
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
            this.dgvTTTB = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTTTB);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 301);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thiết Bị  Của Trò Chơi";
            // 
            // dgvTTTB
            // 
            this.dgvTTTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaTB,
            this.TenTB,
            this.TenTC,
            this.NgayBD});
            this.dgvTTTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTTB.Location = new System.Drawing.Point(3, 21);
            this.dgvTTTB.Name = "dgvTTTB";
            this.dgvTTTB.Size = new System.Drawing.Size(766, 277);
            this.dgvTTTB.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaTB
            // 
            this.MaTB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTB.DataPropertyName = "Ma_TB";
            this.MaTB.HeaderText = "Mã Thiết Bị";
            this.MaTB.Name = "MaTB";
            // 
            // TenTB
            // 
            this.TenTB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTB.DataPropertyName = "Ten_TB";
            this.TenTB.HeaderText = "Tên Khu Vực";
            this.TenTB.Name = "TenTB";
            // 
            // TenTC
            // 
            this.TenTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTC.DataPropertyName = "Ten_TroChoi";
            this.TenTC.HeaderText = "Tên Trò Chơi";
            this.TenTC.Name = "TenTC";
            // 
            // NgayBD
            // 
            this.NgayBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBD.DataPropertyName = "Ngay_BD";
            this.NgayBD.HeaderText = "Ngày Bảo Dưỡng";
            this.NgayBD.Name = "NgayBD";
            // 
            // frmTTTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 300);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTTTB";
            this.Text = "frmTTTB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTTTB_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTTTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
    }
}