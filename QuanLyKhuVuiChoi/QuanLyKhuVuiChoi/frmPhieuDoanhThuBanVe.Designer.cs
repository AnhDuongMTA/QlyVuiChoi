namespace QuanLyKhuVuiChoi
{
    partial class frmPhieuDoanhThuBanVe
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpPhieuDoanhThuBanVe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetDoanhThuCongTy = new QuanLyKhuVuiChoi.DataSetDoanhThuCongTy();
            this.TongTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TongTienTableAdapter = new QuanLyKhuVuiChoi.DataSetDoanhThuCongTyTableAdapters.TongTienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDoanhThuCongTy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TongTienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpPhieuDoanhThuBanVe
            // 
            this.rpPhieuDoanhThuBanVe.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DoanhThuBanVe";
            reportDataSource1.Value = this.TongTienBindingSource;
            this.rpPhieuDoanhThuBanVe.LocalReport.DataSources.Add(reportDataSource1);
            this.rpPhieuDoanhThuBanVe.LocalReport.ReportEmbeddedResource = "QuanLyKhuVuiChoi.rpDoanhThuBanVe.rdlc";
            this.rpPhieuDoanhThuBanVe.Location = new System.Drawing.Point(0, 0);
            this.rpPhieuDoanhThuBanVe.Name = "rpPhieuDoanhThuBanVe";
            this.rpPhieuDoanhThuBanVe.Size = new System.Drawing.Size(768, 427);
            this.rpPhieuDoanhThuBanVe.TabIndex = 0;
            // 
            // DataSetDoanhThuCongTy
            // 
            this.DataSetDoanhThuCongTy.DataSetName = "DataSetDoanhThuCongTy";
            this.DataSetDoanhThuCongTy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TongTienBindingSource
            // 
            this.TongTienBindingSource.DataMember = "TongTien";
            this.TongTienBindingSource.DataSource = this.DataSetDoanhThuCongTy;
            // 
            // TongTienTableAdapter
            // 
            this.TongTienTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuDoanhThuBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 427);
            this.Controls.Add(this.rpPhieuDoanhThuBanVe);
            this.Name = "frmPhieuDoanhThuBanVe";
            this.Text = "frmPhieuDoanhThuBanVe";
            this.Load += new System.EventHandler(this.frmPhieuDoanhThuBanVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDoanhThuCongTy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TongTienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpPhieuDoanhThuBanVe;
        private System.Windows.Forms.BindingSource TongTienBindingSource;
        private DataSetDoanhThuCongTy DataSetDoanhThuCongTy;
        private DataSetDoanhThuCongTyTableAdapters.TongTienTableAdapter TongTienTableAdapter;
    }
}