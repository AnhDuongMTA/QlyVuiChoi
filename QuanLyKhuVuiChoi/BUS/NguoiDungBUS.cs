using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguoiDungBUS
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungDAL nddal = new NguoiDungDAL();
        public DataTable DangNhap(NguoiDung nd)
        {
            return nddal.GetUser(nd);
        }
        public int ThemNguoiDung(NguoiDung nd)
        {
            return nddal.ThemNguoiDung(nd);
        }
    }
}
