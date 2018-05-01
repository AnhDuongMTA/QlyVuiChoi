using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhuVuiChoi
{
    public partial class frmPhieuDoanhThuDichVu : Form
    {
        public frmPhieuDoanhThuDichVu()
        {
            InitializeComponent();
        }

        private void frmPhieuDoanhThuDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetDoanhThuCongTy.DoanhThuDichVu' table. You can move, or remove it, as needed.
            this.DoanhThuDichVuTableAdapter.Fill(this.DataSetDoanhThuCongTy.DoanhThuDichVu);

            this.rpPhieuDoanhThuDichVu.RefreshReport();
        }
    }
}
