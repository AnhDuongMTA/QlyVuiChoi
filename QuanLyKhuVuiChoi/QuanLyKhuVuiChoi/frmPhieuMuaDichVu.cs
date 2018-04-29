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
    public partial class frmPhieuMuaDichVu : Form
    {
        public frmPhieuMuaDichVu()
        {
            InitializeComponent();
        }
        ChiTietPhieuMuaBUS busCTPM = new ChiTietPhieuMuaBUS();
        ChiTietPhieuMuaEntity E_CTPM = new ChiTietPhieuMuaEntity();
        DichVuBUS busDichVu = new DichVuBUS();
        PhieuMuaBUS busPhieuMua = new PhieuMuaBUS();
        PhieuMuaEntity E_PhieuMua = new PhieuMuaEntity();
        KhachHangBUS busKhachHang = new KhachHangBUS();

        private bool _clickBtn = true;
        int dongDGV = 0;

        public void KhoaBtn(bool e)
        {
            txtMaPhieu.Enabled = e;
            cbMaKH.Enabled = e;

            btnThem.Enabled = !e;
            btnSua.Enabled = e;
            btnXoa.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnInPhieu.Enabled = e;
            

        }
        private void SetNull()
        {
            txtMaPhieu.Text = "";
            cbMaKH.Text = "";
        }

        private void HienThi()
        {
            cbMaKH.DataSource = busKhachHang.GetData();
            cbMaKH.ValueMember = "Ma_KH";
            cbMaKH.DisplayMember = "Ten_KH";

            MaDichVu.DataSource = busDichVu.XemDichVu();
            MaDichVu.ValueMember = "Ma_DV";
            MaDichVu.DisplayMember = "Ten_DV";
        }


        private void frmPhieuMuaDichVu_Load(object sender, EventArgs e)
        {
            KhoaBtn(false);
            HienThi();
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            _clickBtn = true;
            KhoaBtn(true);
            SetNull();
            txtMaPhieu.Text = busPhieuMua.TangMa();
            dgvChiTietPhieuMua.Rows.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhoaBtn(true);
            _clickBtn = false;
            txtMaPhieu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    busCTPM.XoaCTPM(txtMaPhieu.Text);
                    MessageBox.Show("Xóa thành công!");
                    SetNull();
                    KhoaBtn(false);
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
            if (txtMaPhieu.Text == "" || cbMaKH.Text == "")
            {
                MessageBox.Show("Xin Mời Nhập Đầy Đủ Thông Tin!", "Thông Báo");
                return;
            }

            if (_clickBtn == true)
            {
                try
                {

                    E_PhieuMua.MaPhieu = txtMaPhieu.Text;
                    E_PhieuMua.MaKH = cbMaKH.SelectedValue.ToString();
                    E_PhieuMua.NgayMua = dtpNgayMua.Text;

                    busPhieuMua.ThemPM(E_PhieuMua);
                }
                catch
                {
                    MessageBox.Show("lỗi!", "Thông Báo");
                    return;
                }
            }
            else
            {

                try
                {
                    E_PhieuMua.MaPhieu = txtMaPhieu.Text;
                    E_PhieuMua.MaKH = cbMaKH.SelectedIndex.ToString();
                    E_PhieuMua.NgayMua = dtpNgayMua.Text;

                    busPhieuMua.SuaPM(E_PhieuMua);

                }
                catch
                {
                    MessageBox.Show("lỗi!", "Thông Báo");
                    return;
                }
            }

            try
            {
                for (int i = 0; i < dgvChiTietPhieuMua.Rows.Count - 1; i++)
                {
                    E_CTPM.MaPhieu = txtMaPhieu.Text;
                    E_CTPM.MaDV = dgvChiTietPhieuMua.Rows[i].Cells[1].Value.ToString();
                    E_CTPM.SoLuong = dgvChiTietPhieuMua.Rows[i].Cells[2].Value.ToString();
                    E_CTPM.DonGia = dgvChiTietPhieuMua.Rows[i].Cells[3].Value.ToString();
                   E_CTPM.ThanhTien = dgvChiTietPhieuMua.Rows[i].Cells[4].Value.ToString();

                    busCTPM.ThemCTPM(E_CTPM);
                }
                // MessageBox.Show("Đã Tạo Hoá Đơn Thành Công!","Thông Báo");
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn lưu thông tin này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    MessageBox.Show("Bạn có muốn lưu thông tin này?", "Chú Ý");
                }
            }
            catch(Exception ex) {
                MessageBox.Show("lỗi!" + ex);

                return;
            }


            // Để hiện thị ra Hoá Đơn!
            SetNull();
            KhoaBtn(false);
            HienThi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                KhoaBtn(true);
                _clickBtn = true;

            }
            else
                return;
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {

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

        private void dgvChiTietPhieuMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dongDGV = e.RowIndex;
        }
        private void dgvChiTietPhieuMua_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietPhieuMua.Rows[dongDGV].Cells[2].Value != "" && dgvChiTietPhieuMua.Rows[dongDGV].Cells[3].Value != "")
            {
                try
                {
                    string a = (int.Parse(dgvChiTietPhieuMua.Rows[dongDGV].Cells[2].Value.ToString()) * int.Parse(dgvChiTietPhieuMua.Rows[dongDGV].Cells[3].Value.ToString())).ToString();
                    // msds.Rows[dong].Cells[3].Value = (double.Parse(msds.Rows[dong].Cells[1].Value.ToString()) * double.Parse(msds.Rows[dong].Cells[2].Value.ToString())).ToString();
                    dgvChiTietPhieuMua.Rows[dongDGV].Cells[4].Value = a;
                }
                catch
                {

                }

            }
            try
            {
                DataTable dt = new DataTable();
                dt = busDichVu.TimKiemDichVu(" Select *from DichVu where Ma_DV = '" + dgvChiTietPhieuMua.Rows[dongDGV].Cells[1].Value.ToString() + "'");
                dgvChiTietPhieuMua.Rows[dongDGV].Cells[3].Value = double.Parse(dt.Rows[0]["Gia_DV"].ToString()).ToString();

            }
            catch
            {

            }
        }
    }
}
