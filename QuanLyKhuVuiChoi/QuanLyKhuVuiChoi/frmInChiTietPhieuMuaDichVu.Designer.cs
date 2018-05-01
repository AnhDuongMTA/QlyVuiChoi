namespace QuanLyKhuVuiChoi
{
    partial class frmInChiTietPhieuMuaDichVu
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetChiTietPhieuMuaDichVu = new QuanLyKhuVuiChoi.DataSetChiTietPhieuMuaDichVu();
            this.ChitietphieumuadichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChitietphieumuadichvuTableAdapter = new QuanLyKhuVuiChoi.DataSetChiTietPhieuMuaDichVuTableAdapters.ChitietphieumuadichvuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetChiTietPhieuMuaDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChitietphieumuadichvuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChitietphieumuadichvuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhuVuiChoi.rp_ChiTietPhieuMuaDichVu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(911, 552);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetChiTietPhieuMuaDichVu
            // 
            this.DataSetChiTietPhieuMuaDichVu.DataSetName = "DataSetChiTietPhieuMuaDichVu";
            this.DataSetChiTietPhieuMuaDichVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChitietphieumuadichvuBindingSource
            // 
            this.ChitietphieumuadichvuBindingSource.DataMember = "Chitietphieumuadichvu";
            this.ChitietphieumuadichvuBindingSource.DataSource = this.DataSetChiTietPhieuMuaDichVu;
            // 
            // ChitietphieumuadichvuTableAdapter
            // 
            this.ChitietphieumuadichvuTableAdapter.ClearBeforeFill = true;
            // 
            // frmInChiTietPhieuMuaDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 552);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInChiTietPhieuMuaDichVu";
            this.Text = "frmInChiTietPhieuMuaDichVu";
            this.Load += new System.EventHandler(this.frmInChiTietPhieuMuaDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetChiTietPhieuMuaDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChitietphieumuadichvuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChitietphieumuadichvuBindingSource;
        private DataSetChiTietPhieuMuaDichVu DataSetChiTietPhieuMuaDichVu;
        private DataSetChiTietPhieuMuaDichVuTableAdapters.ChitietphieumuadichvuTableAdapter ChitietphieumuadichvuTableAdapter;
    }
}