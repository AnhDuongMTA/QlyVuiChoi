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
    public partial class frmTTTC : Form
    {
        KhuVucBus bus = new KhuVucBus();
        public frmTTTC()
        {
            InitializeComponent();
        }
        private void frmTTTC_Load(object sender, EventArgs e)
        {
            dgvTTTC.DataSource = bus.GetDataTTTC(frmKhuVuc.Ma);
        }
    }
}
