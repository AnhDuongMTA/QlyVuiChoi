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
    public partial class frmDichVu : Form
    {
        DichVu dv = new DichVu();
        DichVuBUS dvbus = new DichVuBUS();
        private int fluu = 1;
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaDV.Enabled = e;
            txtTenDV.Enabled = e;
            txtGiaDV.Enabled = e;
        }
        private void clearData()
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtGiaDV.Text = "";
        }
        private void HienThi()
        {
            dgvDichVu.DataSource = dvbus.XemDichVu();
        }
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();
            }
            else
                HienThi();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaDV.Text = dvbus.TangMa();
            DisEnl(true);
            txtMaDV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaDV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dvbus.XoaDichVu(txtMaDV.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch
                {
                    MessageBox.Show("Lỗi không xóa được");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dv.MaDV = txtMaDV.Text;
            dv.TenDV = txtTenDV.Text;
            dv.GiaDV = Convert.ToInt32(txtGiaDV.Text);

            if (fluu == 0)
            {
                int dt;
                dt = dvbus.ThemDichVu(dv);
                if (dt != 0)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                HienThi();
                clearData();
                DisEnl(false);
                fluu = 1;
            }
            else
            {
                dvbus.SuaDichVu(dv);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvDichVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDichVu.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenDV.Text = Convert.ToString(dgvDichVu.CurrentRow.Cells["Ten_DV"].Value);
                txtGiaDV.Text = Convert.ToString(dgvDichVu.CurrentRow.Cells["Gia_DV"].Value);
            }
            else
            {
                txtMaDV.Text = Convert.ToString(dgvDichVu.CurrentRow.Cells["Ma_DV"].Value);
                txtTenDV.Text = Convert.ToString(dgvDichVu.CurrentRow.Cells["Ten_DV"].Value);
                txtGiaDV.Text = Convert.ToString(dgvDichVu.CurrentRow.Cells["Gia_DV"].Value);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Theo Mã Dich Vụ")
            {
                dgvDichVu.DataSource = dvbus.TimKiemDichVu(" SELECT * FROM DichVu where Ma_DV like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Tên Dịch Vụ")
            {
                dgvDichVu.DataSource = dvbus.TimKiemDichVu(" SELECT * FROM DichVu where Ten_DV like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Giá Dịch Vụ")
            {
                dgvDichVu.DataSource = dvbus.TimKiemDichVu(" SELECT * FROM DichVu where Gia_DV like '%" + txtTimKiem.Text + "%'");
            }
        }
    }
}
