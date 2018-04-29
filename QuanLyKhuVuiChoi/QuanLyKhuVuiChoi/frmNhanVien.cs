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
    public partial class frmNhanVien : Form
    {
        NhanVien obj = new NhanVien();
        NhanVienBUS nvbus = new NhanVienBUS();
        private int fluu = 1;
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaNV.Enabled = e;
            txtHoTen.Enabled = e;
            cmbGioiTinh.Enabled = e;
            cmbMaKhu.Enabled = e;
            txtLuong.Enabled = e;
            dateNgaySinh.Enabled = e;
            txtDiaChi.Enabled = e;

        }
        private void clearData()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            cmbGioiTinh.Text = "";
            txtLuong.Text = "";
            txtDiaChi.Text = "";
        }
        private void HienThi()
        {
            dgvNhanVien.DataSource = nvbus.GetDataNhanVien();
        }

        public frmNhanVien()
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
            txtMaNV.Text = nvbus.TangMa();
            DisEnl(true);
            txtMaNV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    nvbus.XoaNhanVien(txtMaNV.Text);
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
            obj.MaNV = txtMaNV.Text;
            obj.TenNV = txtHoTen.Text;
            obj.Luong = Convert.ToInt32(txtLuong.Text);
            obj.MaKhu = cmbMaKhu.Text;
            obj.NgaySinh = dateNgaySinh.Text;
            obj.GioiTinh = cmbGioiTinh.Text;
            obj.DiaChi = txtDiaChi.Text;

            if (fluu == 0)
            {
                int dt;
                dt = nvbus.ThemNhanVien(obj);
                if (dt != 0)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                nvbus.SuaNhanVien(obj);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cbTimKiem.DisplayMember = "";
            cmbMaKhu.DataSource = nvbus.GetDataNhanVien();
            cmbMaKhu.DisplayMember = "Ma_Khu";
            HienThi();
            DisEnl(false);
        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }


        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtHoTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Ten_NV"].Value);
                txtLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Luong"].Value);
                cmbMaKhu.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Ma_Khu"].Value);
                dateNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Ngay_Sinh"].Value);
                cmbGioiTinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Gioi_Tinh"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DiaChi"].Value);

            }
            else
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Ma_NV"].Value);
                txtHoTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Ten_NV"].Value);
                txtLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Luong"].Value);
                cmbMaKhu.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Ma_Khu"].Value);
                dateNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Ngay_Sinh"].Value);
                cmbGioiTinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Gioi_Tinh"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DiaChi"].Value);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Theo Mã Nhân Viên")
            {
                dgvNhanVien.DataSource = nvbus.TimKiem(" SELECT * FROM dbo.NhanVien where Ma_NV like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Tên Nhân Viên")
            {
                dgvNhanVien.DataSource = nvbus.TimKiem(" SELECT * FROM dbo.NhanVien where Ten_NV like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Giới Tính")
            {
                dgvNhanVien.DataSource = nvbus.TimKiem(" SELECT * FROM dbo.NhanVien where Gioi_Tinh like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Lương")
            {
                dgvNhanVien.DataSource = nvbus.TimKiem(" SELECT * FROM dbo.NhanVien where Luong like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Mã Khu")
            {
                dgvNhanVien.DataSource = nvbus.TimKiem(" SELECT * FROM dbo.NhanVien where Ma_Khu like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Ngày Sinh")
            {
                dgvNhanVien.DataSource = nvbus.TimKiem(" SELECT * FROM dbo.NhanVien where Ngay_Sinh like '%" + txtTimKiem.Text + "%'");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
