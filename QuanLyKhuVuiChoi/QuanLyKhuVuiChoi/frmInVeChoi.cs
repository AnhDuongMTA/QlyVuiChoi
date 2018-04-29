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
    public partial class frmInVeChoi : Form
    {
        public frmInVeChoi()
        {
            InitializeComponent();
        }

        private void frmInVeChoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKVC.InVe' table. You can move, or remove it, as needed.
            this.InVeTableAdapter.Fill(this.QLKVC.InVe,frmVeChoi.Ma);

            this.reportViewer1.RefreshReport();
        }
    }
}
