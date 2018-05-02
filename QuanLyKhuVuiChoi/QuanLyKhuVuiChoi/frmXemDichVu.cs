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
using ENTITY;
using Entity;

namespace QuanLyKhuVuiChoi
{
    public partial class frmXemDichVu : Form
    {
        DichVuBUS bus = new DichVuBUS();
        DichVu dv = new DichVu();
        public frmXemDichVu()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgvXemDV.DataSource = bus.XemDichVu();
        }
        private void frmXemDichVu_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvXemDV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvXemDV.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
