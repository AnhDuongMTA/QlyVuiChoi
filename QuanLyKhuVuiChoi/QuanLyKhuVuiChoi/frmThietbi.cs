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
using Entity;

namespace QuanLyKhuVuiChoi
{
    public partial class frmThietbi : Form
    {
        ThietBiBus Bus = new ThietBiBus();
        ThietBiEntity Tb = new ThietBiEntity();
        private int fluu = 1;
        public frmThietbi()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaTB.Enabled = e;
            txtTenTB.Enabled = e;
            dpNgayBD.Enabled = e;
            cmbMaTC.Enabled = e;
        }
        private void clearData()
        {
            txtMaTB.Text = "";
            txtTenTB.Text = "";
            dpNgayBD.Text = "";
            cmbMaTC.Text = "";
        }
        public void ShowTroChoi()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListTroChoi();
            cmbMaTC.DataSource = dt;
            cmbMaTC.DisplayMember = "Ten_TroChoi";
            cmbMaTC.ValueMember = "Ma_TroChoi";
        }
        private void HienThi()
        {
            dgvThietBi.DataSource = Bus.GetData();
        }
        private void frmThietbi_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            ShowTroChoi();
        }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (fluu == 0)
                {
                    //  txtMaTB.Text = Convert.ToString(dgvThietBi.CurrentRow.Cells["MaTB"].Value);
                    txtTenTB.Text = Convert.ToString(dgvThietBi.CurrentRow.Cells["TenTB"].Value);
                    dpNgayBD.Text = Convert.ToString(dgvThietBi.CurrentRow.Cells["NgayBD"].Value);
                    cmbMaTC.Text = Convert.ToString(dgvThietBi.CurrentRow.Cells["TenTC"].Value);
                }
                else
                {
                    txtMaTB.Text = Convert.ToString(dgvThietBi.CurrentRow.Cells["MaTB"].Value);
                    txtTenTB.Text = Convert.ToString(dgvThietBi.CurrentRow.Cells["TenTB"].Value);
                    dpNgayBD.Text = Convert.ToString(dgvThietBi.CurrentRow.Cells["NgayBD"].Value);
                    cmbMaTC.Text = Convert.ToString(dgvThietBi.CurrentRow.Cells["TenTC"].Value);
                }
            }
        }

        private void dgvThietBi_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThietBi.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaTB.Text = Bus.TangMa();
            DisEnl(true);
            txtMaTB.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaTB.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                      Bus.DeleteData(txtMaTB.Text);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có Lỗi Không thể xóa !");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Tb.MaTB = txtMaTB.Text;
            Tb.TenTB = txtTenTB.Text;
            Tb.NgayBD = dpNgayBD.Text;
            Tb.MaTC = cmbMaTC.Text;
            if (fluu == 0)
            {
                try
                {
                    Bus.InsertData(Tb);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                    //fluu = 1;
                }
                catch
                {

                }
            }
            else
            {
                try
                {
                    Bus.UpdateData(Tb);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                }
                catch
                {

                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;
            }
            else
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //frmMain m = new frmMain();
                //m.Show();
                //this.Close();
                Application.Exit();
            }
            else
                HienThi();
        }
    }
}
