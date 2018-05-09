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
    public partial class frmKhachHang : Form
    {
        KhachHang obj = new KhachHang();
        KhachHangBUS khbus = new KhachHangBUS();
        private int fluu = 1;
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaKH.Enabled = e;
            txtTenKH.Enabled = e;
            cmbGioiTinh.Enabled = e;
            txtNamSinh.Enabled = e;
            txtSDT.Enabled = e;
        }
        private void clearData()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cmbGioiTinh.Text = "";
            txtNamSinh.Text = "";
            txtSDT.Text = "";
        }
        private void HienThi()
        {
            dgvKhachHang.DataSource = khbus.GetData();
        }

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                m.Close();
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
            txtMaKH.Text = khbus.TangMa();
            DisEnl(true);
            txtMaKH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaKH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    khbus.XoaKhachHang(txtMaKH.Text);
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
            obj.MaKhachHang = txtMaKH.Text;
            obj.TenKhachHang = txtTenKH.Text;
            obj.GioiTinh = cmbGioiTinh.Text;
            obj.NamSinh = int.Parse(txtNamSinh.Text.ToString());
            obj.SDT = int.Parse(txtSDT.Text.ToString());
            if (fluu == 0)
            {
                int dt;
                dt = khbus.ThemKhachHang(obj);
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
                khbus.SuaKhacHang(obj);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text== "Theo Mã Khách Hàng")
            {
                dgvKhachHang.DataSource = khbus.TimKiem("select * from KhachHang where Ma_KH like '%"+txtTimKiem.Text+"%'");
            }
            if (cbTimKiem.Text == "Theo Tên Khách Hàng")
            {
                dgvKhachHang.DataSource = khbus.TimKiem("select * from KhachHang where Ten_KH like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Giới Tính")
            {
                dgvKhachHang.DataSource = khbus.TimKiem("select * from KhachHang where Gioi_Tinh like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Năm Sinh")
            {
                dgvKhachHang.DataSource = khbus.TimKiem("select * from KhachHang where Nam_Sinh like '%" + txtTimKiem.Text + "%'");
            }
        }


        private void dgvKhachHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvKhachHang.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenKH.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["Ten_KH"].Value);
                txtNamSinh.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["Nam_Sinh"].Value);
                cmbGioiTinh.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["Gioi_Tinh"].Value);
                txtSDT.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["SDT"].Value);
            }
            else
            {
                txtMaKH.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["Ma_KH"].Value);
                txtTenKH.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["Ten_KH"].Value);
                txtNamSinh.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["Nam_Sinh"].Value);
                cmbGioiTinh.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["Gioi_Tinh"].Value);
                txtSDT.Text = Convert.ToString(dgvKhachHang.CurrentRow.Cells["SDT"].Value);
            }
        }

        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            frmVeChoi frmVe = new frmVeChoi();
            frmVe.Show();
            this.Hide();     
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
