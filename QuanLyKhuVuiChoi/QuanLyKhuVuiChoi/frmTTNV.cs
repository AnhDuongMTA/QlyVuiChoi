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
    public partial class frmTTNV : Form
    {
        KhuVucBus bus = new KhuVucBus();
        public frmTTNV()
        {
            InitializeComponent();
        }

        private void frmTTNV_Load(object sender, EventArgs e)
        {
            dgvTTNV.DataSource = bus.GetDataTTNV(frmKhuVuc.Ma);
        }
    }
}
