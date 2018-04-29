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
    public partial class frmKhuVuc : Form
    {
        KhuVucBus Bus = new KhuVucBus();
        KhuVucEntity Kh = new KhuVucEntity();
        private int fluu = 1;
        public static string Ma;
        public frmKhuVuc()
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
            txtMaKhu.Enabled = e;
            txtTenKhu.Enabled = e;
            txtChucNang.Enabled = e;
            cmbMaTK.Enabled = e;
            txtGiaNL.Enabled = e;
            txtGiaTE.Enabled = e;
            txtViTri.Enabled = e;
        }
        private void clearData()
        {
            txtMaKhu.Text = "";
            txtTenKhu.Text = "";
            txtChucNang.Text = "";
            txtGiaNL.Text = "";
            txtGiaTE.Text = "";
            cmbMaTK.Text = "";
            txtViTri.Text = "";
        }
        private void HienThi()
        {
            dgvKhuVuc.DataSource = Bus.GetData();
        }
        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvKhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (fluu == 0)
                {
                    //  txtMaTB.Text = Convert.ToString(dgvThietBi.CurrentRow.Cells["MaTB"].Value);
                    txtTenKhu.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["TenKhu"].Value);
                    txtChucNang.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["ChucNang"].Value);
                    txtViTri.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["ViTri"].Value);
                    txtGiaTE.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["GiaTE"].Value);
                    txtGiaNL.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["GiaNL"].Value);
                    cmbMaTK.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["MaTK"].Value);
                }
                else
                {
                    txtMaKhu.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["MaKhu"].Value);
                    txtTenKhu.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["TenKhu"].Value);
                    txtChucNang.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["ChucNang"].Value);
                    txtViTri.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["ViTri"].Value);
                    txtGiaTE.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["GiaTE"].Value);
                    txtGiaNL.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["GiaNL"].Value);
                    cmbMaTK.Text = Convert.ToString(dgvKhuVuc.CurrentRow.Cells["MaTK"].Value);
                }
            }
        }

        private void dgvKhuVuc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvKhuVuc.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaKhu.Text = Bus.TangMa();
            DisEnl(true);
            txtMaKhu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaKhu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaKhu.Text);
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
            Kh.MaKhu = txtMaKhu.Text;
            Kh.TenKhu = txtTenKhu.Text;
            Kh.ChucNang = txtChucNang.Text;
            Kh.ViTri = txtViTri.Text;
            Kh.MaTK = cmbMaTK.Text;
            Kh.GiaNL = Convert.ToInt32(txtGiaNL.Text);
            Kh.GiaTE = Convert.ToInt32(txtGiaTE.Text);
            if (fluu == 0)
            {
                try
                {
                    Bus.InsertData(Kh);
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
                    Bus.UpdateData(Kh);
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

        private void btnTTNV_Click(object sender, EventArgs e)
        {
            if (txtMaKhu != null)
            {
                Ma = txtMaKhu.Text;
                frmTTNV frmNv = new frmTTNV();
                frmNv.Show();
            }

        }

        private void btnTTDV_Click(object sender, EventArgs e)
        {
            if (txtMaKhu != null)
            {
                Ma = txtMaKhu.Text;
                frmTTDV frmDv = new frmTTDV();
                frmDv.Show();
            }

        }

        private void btnTTTC_Click(object sender, EventArgs e)
        {
            if (txtMaKhu != null)
            {
                Ma = txtMaKhu.Text;
                frmTTTC frmTc = new frmTTTC();
                frmTc.Show();
            }
        }
    }
}
