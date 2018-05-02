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
namespace QuanLyKhuVuiChoi
{
    public partial class frmXemTroChoi : Form
    {
        TrochoiBus bus = new TrochoiBus();
        TroChoiEntity tc = new TroChoiEntity();
        KhuVucBus bus1 = new KhuVucBus();
        KhuVucEntity kv = new KhuVucEntity();
        public frmXemTroChoi()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgvXemTC.DataSource = bus.XemTC();
            //dgvXemTC.DataSource = bus1.GetData();
        }

        private void frmXemTroChoi_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvXemTC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvXemTC.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
