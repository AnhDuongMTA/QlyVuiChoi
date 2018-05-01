using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyKhuVuiChoi
{
    public partial class frmDoanhThuBanVe : Form
    {
        ThongKeBUS tkbus = new ThongKeBUS();
        public frmDoanhThuBanVe()
        {
            InitializeComponent();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            frmPhieuDoanhThuBanVe phieu = new frmPhieuDoanhThuBanVe();
            phieu.Show();
        }

        private void frmDoanhThuBanVe_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvDoanhThuBanVe.DataSource = tkbus.DoanhThuBanVe(dateNgayBan1.Value.Date.ToString(), dateNgayBan2.Value.Date.ToString());
            
            int index = dgvDoanhThuBanVe.Rows.Count;
            int thanhtien = 0;
            for (int i = 0; i < index - 1; i++)
            {
                thanhtien += int.Parse(dgvDoanhThuBanVe.Rows[i].Cells["TongTien"].Value.ToString());
                
            }
            lblTongTien.Text = thanhtien.ToString();
        }
    }
}
