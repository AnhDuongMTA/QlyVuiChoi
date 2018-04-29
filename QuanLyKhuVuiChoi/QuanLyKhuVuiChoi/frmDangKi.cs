﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Entity;

namespace QuanLyKhuVuiChoi
{
    public partial class frmDangKi : Form
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungBUS ndbus = new NguoiDungBUS();
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.Show();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            nd.TaiKhoan = txtDKTaiKhoan.Text;
            nd.MatKhau = txtDKMatKhau.Text;
            nd.PhanQuyen = cmbPhanQuyen.Text;
            if (txtDKTaiKhoan.Text=="")
            {
                lblLoiDKTaiKhoan.Text = "Bạn chưa nhập tài khoản";
            }else if (txtDKMatKhau.Text=="")
            {
                lblLoiDangKiMatKhau.Text = "Bạn chưa nhập mật khẩu";
            }
            else if (txtDKMatKhau.Text!=txtNhapLaiMatKhau.Text)
            {
                lblLoiNhapLaiMatKhau.Text = "Mật khẩu không trùng khớp";
            }
            else
            {
                ndbus.ThemNguoiDung(nd);
                MessageBox.Show("Tạo tài khoản thành công!");
            }
            
        }

        private void txtDKTaiKhoan_Click(object sender, EventArgs e)
        {
            lblLoiDKTaiKhoan.Text = "";
        }

        private void txtDKMatKhau_Click(object sender, EventArgs e)
        {
            lblLoiDangKiMatKhau.Text = "";
        }

        private void txtNhapLaiMatKhau_Click(object sender, EventArgs e)
        {
            lblLoiNhapLaiMatKhau.Text = "";
        }

        private void checkShow1_CheckedChanged(object sender, EventArgs e)
        {
            bool checkpass = checkShow1.Checked;
            if (checkpass)
            {
                txtDKMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtDKMatKhau.UseSystemPasswordChar = true;
        }
    }
}
