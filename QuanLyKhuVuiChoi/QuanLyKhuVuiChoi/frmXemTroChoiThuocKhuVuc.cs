using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BUS;
namespace QuanLyKhuVuiChoi
{
    public partial class frmXemTroChoiThuocKhuVuc : Form
    {
        HomeBUS hombus = new HomeBUS();
        public frmXemTroChoiThuocKhuVuc()
        {
            InitializeComponent();
        }

        private void frmXemTroChoiThuocKhuVuc_Load(object sender, EventArgs e)
        {
            dgvTroChoiThuocKhuVuc.DataSource = hombus.XemTroChoiThuocKhuVuc();
        }
    }
}
