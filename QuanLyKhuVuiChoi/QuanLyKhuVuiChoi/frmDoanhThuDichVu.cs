using BUS;
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
    public partial class frmDoanhThuDichVu : Form
    {
        ThongKeBUS tkbus = new ThongKeBUS();
        public frmDoanhThuDichVu()
        {
            InitializeComponent();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            frmPhieuDoanhThuDichVu phieudv = new frmPhieuDoanhThuDichVu();
            phieudv.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvDoanhThuDichVu.DataSource = tkbus.DoanhThuDichVu(dateNgayMua1.Value.Date.ToString(), dateNgayMua2.Value.Date.ToString());

            int index = dgvDoanhThuDichVu.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < index - 1; i++)
            {
                thanhtien += int.Parse(dgvDoanhThuDichVu.Rows[i].Cells["ThanhTien"].Value.ToString());

            }
            lblTongTien.Text = thanhtien.ToString();
        }
    }
}
