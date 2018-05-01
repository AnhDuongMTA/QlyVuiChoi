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
        public static string Ma_Phieu;

        private bool _clickBtn = true;
        int dongDGV = 0;

        public void KhoaBtn(bool e)
        {
            txtMaPhieu.Enabled = !e;
            cbMaKH.Enabled = e;
            txtSolg.Enabled = e;
            txtDonGia.Enabled = e;
            cbTenDichVu.Enabled = e;

            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnInPhieu.Enabled = !e;
            

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
            dgvDanhSachCTPM.DataSource = busCTPM.GetData();

            cbTenDichVu.DataSource = busDichVu.XemDichVu();
            cbTenDichVu.ValueMember = "Ma_DV";
            cbTenDichVu.DisplayMember = "Ten_DV";
        }


        private void frmPhieuMuaDichVu_Load(object sender, EventArgs e)
        {
            KhoaBtn(false);
            HienThi();
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            _clickBtn = false;
            KhoaBtn(true);
            SetNull();
            txtMaPhieu.Text = busPhieuMua.TangMa();
            txtMaPhieu.Enabled = false;
            cbTenDichVu.Enabled = false;
            txtDonGia.Enabled = false;
            txtSolg.Enabled = false;
            dgvDichVuMua.Rows.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhoaBtn(true);
            _clickBtn = true;
            txtMaPhieu.Enabled = false;
            cbTenDichVu.Enabled = false;
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
                    _clickBtn = true;
                }
                catch
                {
                    MessageBox.Show("Lỗi không xóa được!");
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

            if (_clickBtn == false)
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
                    MessageBox.Show("lỗi1!", "Thông Báo");
                    return;
                }
                try
                {
                    
                    // MessageBox.Show("Đã Tạo Hoá Đơn Thành Công!","Thông Báo");
                    DialogResult thongbao;
                    thongbao = (MessageBox.Show("Bạn có muốn lưu thông tin này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (thongbao == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvDichVuMua.Rows.Count - 1; i++)
                        {
                            E_CTPM.MaPhieu = txtMaPhieu.Text;
                            E_CTPM.MaDV = dgvDichVuMua.Rows[i].Cells[1].Value.ToString();
                            E_CTPM.SoLuong = dgvDichVuMua.Rows[i].Cells[2].Value.ToString();
                            E_CTPM.DonGia = dgvDichVuMua.Rows[i].Cells[3].Value.ToString();
                            E_CTPM.ThanhTien = dgvDichVuMua.Rows[i].Cells[4].Value.ToString();

                            busCTPM.ThemCTPM(E_CTPM);
                        }
                        MessageBox.Show("Thành công !", "Chú Ý");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi!" + ex);

                    return;
                }
            }
            else
            {

                try
                {
                    E_PhieuMua.MaPhieu = txtMaPhieu.Text;
                    E_PhieuMua.MaKH = cbMaKH.SelectedValue.ToString();
                    E_PhieuMua.NgayMua = dtpNgayMua.Text;
                    E_CTPM.SoLuong = txtSolg.Text;
                    E_CTPM.DonGia = txtDonGia.Text;
                    E_CTPM.MaPhieu = txtMaPhieu.Text;
                    E_CTPM.MaDV = cbTenDichVu.SelectedValue.ToString();
                    E_CTPM.ThanhTien = "1";

                    busPhieuMua.SuaPM(E_PhieuMua);
                    busCTPM.SuaCTPM(E_CTPM);

                    MessageBox.Show("Thành công1", "Chú Ý");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("lỗi!" +ex, "Thông Báo");
                    return;
                }
            }

            // Để hiện thị ra Hoá Đơn!
            SetNull();
            KhoaBtn(false);
            HienThi();
            _clickBtn = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                KhoaBtn(false);
                _clickBtn = true;

            }
            else
                return;
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            Ma_Phieu = txtMaPhieu.Text;
            frmInChiTietPhieuMuaDichVu InPhieuDV = new frmInChiTietPhieuMuaDichVu();
            InPhieuDV.Show();
            KhoaBtn(false);
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
           
                if (dgvDichVuMua.Rows[dongDGV].Cells[2].Value != "" && dgvDichVuMua.Rows[dongDGV].Cells[3].Value != "")
                {
                    try
                    {
                        string a = (int.Parse(dgvDichVuMua.Rows[dongDGV].Cells[2].Value.ToString()) * int.Parse(dgvDichVuMua.Rows[dongDGV].Cells[3].Value.ToString())).ToString();
                        // msds.Rows[dong].Cells[3].Value = (double.Parse(msds.Rows[dong].Cells[1].Value.ToString()) * double.Parse(msds.Rows[dong].Cells[2].Value.ToString())).ToString();
                        dgvDichVuMua.Rows[dongDGV].Cells[4].Value = a;
                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show("Lỗi/n" + ex);
                    }
                }
                try
                {
                    DataTable dt = new DataTable();
                    dt = busDichVu.TimKiemDichVu(" Select *from DichVu where Ma_DV = '" + dgvDichVuMua.Rows[dongDGV].Cells[1].Value.ToString() + "'");
                    dgvDichVuMua.Rows[dongDGV].Cells[3].Value = double.Parse(dt.Rows[0]["Gia_DV"].ToString()).ToString();

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Lỗi/n" + ex);
                }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachCTPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_clickBtn == false)
            {

                cbTenDichVu.Text = Convert.ToString(dgvDanhSachCTPM.CurrentRow.Cells["TenDichVu"].Value);
                txtDonGia.Text = Convert.ToString(dgvDanhSachCTPM.CurrentRow.Cells["DonGia1"].Value);
                txtSolg.Text = Convert.ToString(dgvDanhSachCTPM.CurrentRow.Cells["SoLuong1"].Value);
                cbMaKH.Text = Convert.ToString(dgvDanhSachCTPM.CurrentRow.Cells["TenKH"].Value);

            }
            else
            {
                txtMaPhieu.Text = Convert.ToString(dgvDanhSachCTPM.CurrentRow.Cells["MaPhieu"].Value);
                cbTenDichVu.Text = Convert.ToString(dgvDanhSachCTPM.CurrentRow.Cells["TenDichVu"].Value);
                txtDonGia.Text = Convert.ToString(dgvDanhSachCTPM.CurrentRow.Cells["DonGia1"].Value);
                txtSolg.Text = Convert.ToString(dgvDanhSachCTPM.CurrentRow.Cells["SoLuong1"].Value);
                cbMaKH.Text = Convert.ToString(dgvDanhSachCTPM.CurrentRow.Cells["TenKH"].Value);
            }
            
        }

        private void dgvDanhSachCTPM_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDanhSachCTPM.Rows[e.RowIndex].Cells["STT2"].Value = e.RowIndex + 1;
        }

        private void dgvDichVuMua_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDichVuMua.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
