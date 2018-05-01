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
    public partial class frmTroChoi : Form
    {
        TrochoiBus Bus = new TrochoiBus();
        TroChoiEntity Tc = new TroChoiEntity();
        ThietBiBus TB_Bus = new ThietBiBus();
        public static string Ma;
        private int fluu = 1;
        private int fluu1 = 1;
        public frmTroChoi()
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
            txtMa.Enabled = e;
            txtTen.Enabled = e;
            cmbMaKhu.Enabled = e;
        }
        private void clearData()
        {
            txtTen.Text = "";
            txtMa.Text = "";
            cmbMaKhu.Text = "";
        }
        public void ShowKhuVuc()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListKhuVuc();
            cmbMaKhu.DataSource = dt;
            cmbMaKhu.DisplayMember = "Ten_Khu";
            cmbMaKhu.ValueMember = "Ma_Khu";
        }
        public void ShowThietBi()
        {
            DataTable dt = new DataTable();
            dt = TB_Bus.GetListThietBi();
            cmbTB.DataSource = dt;
            cmbTB.DisplayMember = "Ten_TB";
            cmbTB.ValueMember = "Ma_TB";
        }
        private void HienThi()
        {
            dgvTroChoi.DataSource = Bus.GetData();
        }
        private void frmTroChoi_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            ShowKhuVuc();
            ShowThietBi();
        }
        private void dgvTroChoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (fluu == 0)
                {               
                    //txtMa.Text = Convert.ToString(dgvTroChoi.CurrentRow.Cells["MaTC"].Value);
                    txtTen.Text = Convert.ToString(dgvTroChoi.CurrentRow.Cells["TenTC"].Value);
                    cmbMaKhu.Text = Convert.ToString(dgvTroChoi.CurrentRow.Cells["TenKhu"].Value);
                }
                else
                {
                    txtMa.Text = Convert.ToString(dgvTroChoi.CurrentRow.Cells["MaTC"].Value);
                    txtTen.Text = Convert.ToString(dgvTroChoi.CurrentRow.Cells["TenTC"].Value);
                    cmbMaKhu.Text = Convert.ToString(dgvTroChoi.CurrentRow.Cells["TenKhu"].Value);
                }
            }
        }

        private void dgvTroChoi_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTroChoi.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMa.Text = Bus.TangMa();
            DisEnl(true);
            txtMa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMa.Text);
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
            Tc.MaKhu = cmbMaKhu.SelectedValue.ToString();
            Tc.MaTC = txtMa.Text;
            Tc.TenTC = txtTen.Text;
            if (fluu == 0)
            {
                try
                {
                    Bus.InsertData(Tc);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else
            {
                try
                {
                    Bus.UpdateData(Tc);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                }
                catch
                {

                }
            }
            frmTroChoi_Load(sender, e);
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

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable dt = new System.Data.DataTable();
            //    dt = CTHDbus.GetDataByID(txtMaHD.Text);
            //    dgvCTHD.DataSource = dt;
            //}
            //catch
            //{
            //    dgvCTHD.DataSource = null;
            //}
        }
        //Chi tiết Thiết BỊ

    }
}
