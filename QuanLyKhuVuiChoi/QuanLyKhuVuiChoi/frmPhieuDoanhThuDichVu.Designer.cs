namespace QuanLyKhuVuiChoi
{
    partial class frmPhieuDoanhThuDichVu
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
            this.rpPhieuDoanhThuDichVu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetDoanhThuCongTy = new QuanLyKhuVuiChoi.DataSetDoanhThuCongTy();
            this.DoanhThuDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoanhThuDichVuTableAdapter = new QuanLyKhuVuiChoi.DataSetDoanhThuCongTyTableAdapters.DoanhThuDichVuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDoanhThuCongTy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuDichVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpPhieuDoanhThuDichVu
            // 
            this.rpPhieuDoanhThuDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DoanhThuDichVu";
            reportDataSource1.Value = this.DoanhThuDichVuBindingSource;
            this.rpPhieuDoanhThuDichVu.LocalReport.DataSources.Add(reportDataSource1);
            this.rpPhieuDoanhThuDichVu.LocalReport.ReportEmbeddedResource = "QuanLyKhuVuiChoi.rpDoanhThuDichVu.rdlc";
            this.rpPhieuDoanhThuDichVu.Location = new System.Drawing.Point(0, 0);
            this.rpPhieuDoanhThuDichVu.Name = "rpPhieuDoanhThuDichVu";
            this.rpPhieuDoanhThuDichVu.Size = new System.Drawing.Size(708, 417);
            this.rpPhieuDoanhThuDichVu.TabIndex = 0;
            // 
            // DataSetDoanhThuCongTy
            // 
            this.DataSetDoanhThuCongTy.DataSetName = "DataSetDoanhThuCongTy";
            this.DataSetDoanhThuCongTy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DoanhThuDichVuBindingSource
            // 
            this.DoanhThuDichVuBindingSource.DataMember = "DoanhThuDichVu";
            this.DoanhThuDichVuBindingSource.DataSource = this.DataSetDoanhThuCongTy;
            // 
            // DoanhThuDichVuTableAdapter
            // 
            this.DoanhThuDichVuTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuDoanhThuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 417);
            this.Controls.Add(this.rpPhieuDoanhThuDichVu);
            this.Name = "frmPhieuDoanhThuDichVu";
            this.Text = "frmPhieuDoanhThuDichVu";
            this.Load += new System.EventHandler(this.frmPhieuDoanhThuDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDoanhThuCongTy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuDichVuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpPhieuDoanhThuDichVu;
        private System.Windows.Forms.BindingSource DoanhThuDichVuBindingSource;
        private DataSetDoanhThuCongTy DataSetDoanhThuCongTy;
        private DataSetDoanhThuCongTyTableAdapters.DoanhThuDichVuTableAdapter DoanhThuDichVuTableAdapter;
    }
}