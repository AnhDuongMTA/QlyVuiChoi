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
    public partial class frmThanhToan : Form
    {
        HomeBUS hombus = new HomeBUS();
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            //cmbMaKhu.DataSource = hombus.Xem("select * from KhuVuc");
            //cmbMaKhu.ValueMember = "Ma_Khu";
            cmbMaVe.DataSource = hombus.Xem("SELECT * FROM dbo.KhuVuc JOIN dbo.VeChoi ON VeChoi.Ma_Khu = KhuVuc.Ma_Khu");
            cmbMaVe.ValueMember = "Ma_Ve";
        }

        private void cmbMaVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dt = (DataRowView)cmbMaVe.SelectedItem;
            cmbMaKhu.Text = dt.Row["Ma_Khu"].ToString();
            txtSoVeNL.Text = dt.Row["So_VeNL"].ToString();
            txtSoVeTE.Text = dt.Row["So_VeTE"].ToString();
            txtGiaVeNL.Text = dt.Row["Gia_NL"].ToString();
            txtGiaVeTE.Text = dt.Row["Gia_TE"].ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // string MaVe = cmbMaVe.Text;
            // string MaKhu = cmbMaKhu.Text;
            //int dt=hombus.ThanhToan(MaVe,MaKhu);
            // txtTongTien.Text = dt.ToString();
            int tongtien = Convert.ToInt32(txtSoVeNL.Text) * Convert.ToInt32(txtGiaVeNL.Text)+ Convert.ToInt32(txtSoVeTE.Text)* Convert.ToInt32(txtGiaVeTE.Text);
            txtTongTien.Text = tongtien.ToString();

        }
    }
}
