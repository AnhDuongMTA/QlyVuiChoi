﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login=new frmLogin();
            this.Close();
            login.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmnv = new frmNhanVien();
            frmnv.MdiParent = this;
            frmnv.Show();
        }

        private void tltXemKhuVucTroChoi_Click(object sender, EventArgs e)
        {
            //frmXemTroChoiThuocKhuVuc xem = new frmXemTroChoiThuocKhuVuc();
            //xem.Show();
        }

        private void tltThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tltThanhToan_Click(object sender, EventArgs e)
        {
            //frmThanhToan thanhtoan = new frmThanhToan();
            //thanhtoan.Show();
        }

        private void tltMuaVe_Click(object sender, EventArgs e)
        {
            frmVeChoi vechoi = new frmVeChoi();
            vechoi.Show();
        }

        private void xemTròChơiTheoKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTTTC xem = new frmTTTC();
            xem.MdiParent = this;
            xem.Show();
        }

        private void trợGiúoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeChoi vechoi = new frmVeChoi();
            vechoi.MdiParent = this;
            vechoi.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmThanhToan thanhtoan = new frmThanhToan();
            //thanhtoan.MdiParent = this;
            //thanhtoan.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang khachhang = new frmKhachHang();
            khachhang.MdiParent = this;
            khachhang.Show();
        }

        private void quảnLýDichVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVu dichvu = new frmDichVu();
            dichvu.MdiParent = this;
            dichvu.Show();
        }

        private void quảnLýKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhuVuc khuvuc = new frmKhuVuc();
            khuvuc.MdiParent = this;
            khuvuc.Show();
        }

        private void quảnLýThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThietbi thietbi = new frmThietbi();
            thietbi.MdiParent = this;
            thietbi.Show();
        }

        private void quảnLýTròChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTroChoi trochoi = new frmTroChoi();
            trochoi.MdiParent = this;
            trochoi.Show();

        }

        private void quảnLýVéChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeChoi vechoi = new frmVeChoi();
            vechoi.MdiParent = this;
            vechoi.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(frmLogin.Temp == "Admin")
            {
                đăngKýToolStripMenuItem.Enabled = true;
                quảnLýDichVụToolStripMenuItem.Enabled = true;
                quảnLýKhuVựcToolStripMenuItem.Enabled = true;
                quảnLýVéChơiToolStripMenuItem.Enabled = true;
                quảnLýNhânViênToolStripMenuItem.Enabled = true;
                quảnLýKháchHàngToolStripMenuItem.Enabled = true;
                quảnLýThiếtBịToolStripMenuItem.Enabled = true;
                quảnLýTròChơiToolStripMenuItem.Enabled = true;
                thốngKêToolStripMenuItem.Enabled = true;
                muaGóiDịchVụToolStripMenuItem.Enabled = true;
                xemTròChơiTheoKhuVựcToolStripMenuItem.Enabled = true;
                trợGiúoToolStripMenuItem.Enabled = true;
                thanhToánToolStripMenuItem.Enabled = true;
                báoCáoDoanhThuToolStripMenuItem.Enabled = true;
                tlsMuaVe.Enabled = true;
                doanhThuBánVéToolStripMenuItem1.Enabled = true;
                doanhThuDịchVụToolStripMenuItem1.Enabled = true;
                báoCáoToolStripMenuItem.Enabled = true;
                thốngKêToolStripMenuItem.Enabled = true;
                tlsThongKe.Enabled = true;
            }
            else
            {
                if(frmLogin.Temp == "Nhân Viên Bán Vé")
                {
                    quảnLýVéChơiToolStripMenuItem.Enabled = true;
                    quảnLýKháchHàngToolStripMenuItem.Enabled = true;
                    tlsMuaVe.Enabled = true;
                }
                else
                {
                    if (frmLogin.Temp == "Nhân Viên Dịch Vụ")
                    {
                        muaGóiDịchVụToolStripMenuItem.Enabled = true;
                        quảnLýKháchHàngToolStripMenuItem.Enabled = true;
                    }
                }
            }
        }

        private void bảoDưỡngThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThietbi bdtb = new frmThietbi();
            bdtb.MdiParent = this;
            bdtb.Show();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThuBanVe frmDTve = new frmDoanhThuBanVe();
            frmDTve.MdiParent = this;
            frmDTve.Show();

        }

        private void tlsThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tlsDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void tlsXemTroChoi_Click(object sender, EventArgs e)
        {
            frmXemTroChoi tc = new frmXemTroChoi();
            tc.MdiParent = this;
            tc.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmXemDichVu dv = new frmXemDichVu();
            dv.MdiParent = this;
            dv.Show();
        }

        private void tlsMuaVe_Click(object sender, EventArgs e)
        {
            frmKhachHang KH = new frmKhachHang();
            KH.MdiParent = this;
            KH.Show();
        }

        private void tlsThongKe_Click(object sender, EventArgs e)
        {
            //frmDoanhThuBanVe dtbv = new frmDoanhThuBanVe();
            //dtbv.MdiParent = this;
            //dtbv.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void muaGóiDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuMuaDichVu pmdv = new frmPhieuMuaDichVu();
            pmdv.MdiParent = this;
            pmdv.Show();
        }

        private void véChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeChoi vc = new frmVeChoi();
            vc.MdiParent = this;
            vc.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuMuaDichVu pmdv = new frmPhieuMuaDichVu();
            pmdv.MdiParent = this;
            pmdv.Show();
        }

        private void doanhThuBánVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThuBanVe dtbv = new frmDoanhThuBanVe();
            dtbv.MdiParent = this;
            dtbv.Show();
        }

        private void doanhThuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThuDichVu dtdv = new frmDoanhThuDichVu();
            dtdv.MdiParent = this;
            dtdv.Show();
        }

        private void doanhThuBánVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoanhThuBanVe dtbv = new frmDoanhThuBanVe();
            dtbv.MdiParent = this;
            dtbv.Show();
        }
        private void doanhThuDịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoanhThuDichVu dtdv = new frmDoanhThuDichVu();
            dtdv.MdiParent = this;
            dtdv.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan frmTK = new frmThongTinTaiKhoan();
            frmTK.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDTK = new frmDoiMatKhau();
            frmDTK.Show();
        }

        private void báoCáoDoanhThuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThuDichVu frmDTDV = new frmDoanhThuDichVu();
            frmDTDV.Show();
        }
    }
}
