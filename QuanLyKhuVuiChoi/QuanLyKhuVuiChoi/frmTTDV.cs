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
    public partial class frmTTDV : Form
    {
        KhuVucBus bus = new KhuVucBus();
        public frmTTDV()
        {
            InitializeComponent();
        }

        private void frmTTDV_Load(object sender, EventArgs e)
        {
            dgvTTDV.DataSource = bus.GetDataTTDV(frmKhuVuc.Ma);
        }
    }
}
