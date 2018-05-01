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
    public partial class frmPhieuDoanhThuBanVe : Form
    {
        public frmPhieuDoanhThuBanVe()
        {
            InitializeComponent();
        }

        private void frmPhieuDoanhThuBanVe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetDoanhThuCongTy.TongTien' table. You can move, or remove it, as needed.
            this.TongTienTableAdapter.Fill(this.DataSetDoanhThuCongTy.TongTien);

            this.rpPhieuDoanhThuBanVe.RefreshReport();
        }
    }
}
