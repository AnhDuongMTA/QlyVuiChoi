namespace QuanLyKhuVuiChoi
{
    partial class frmInVeChoi
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
            this.QLKVC = new QuanLyKhuVuiChoi.QLKVC();
            this.InVeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InVeTableAdapter = new QuanLyKhuVuiChoi.QLKVCTableAdapters.InVeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLKVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InVeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.InVeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhuVuiChoi.InVe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(785, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLKVC
            // 
            this.QLKVC.DataSetName = "QLKVC";
            this.QLKVC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InVeBindingSource
            // 
            this.InVeBindingSource.DataMember = "InVe";
            this.InVeBindingSource.DataSource = this.QLKVC;
            // 
            // InVeTableAdapter
            // 
            this.InVeTableAdapter.ClearBeforeFill = true;
            // 
            // frmInVeChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 406);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInVeChoi";
            this.Text = "frmInVeChoi";
            this.Load += new System.EventHandler(this.frmInVeChoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLKVC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InVeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InVeBindingSource;
        private QLKVC QLKVC;
        private QLKVCTableAdapters.InVeTableAdapter InVeTableAdapter;
    }
}