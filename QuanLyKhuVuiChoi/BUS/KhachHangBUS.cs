using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;

namespace BUS
{
    
    public class KhachHangBUS
    {
        KhachHangDAL khdal = new KhachHangDAL();
        public DataTable GetData()
        {
            return khdal.GetData();
        }
        public DataTable TimKiem(string str)
        {
            return khdal.TimKiem(str);
        }
        public int ThemKhachHang(KhachHang kh)
        {
            return khdal.ThemKhachHang(kh);
        }
        public int SuaKhacHang(KhachHang kh)
        {
            return khdal.SuaKhachHang(kh);
        }
        public int XoaKhachHang(string ID)
        {
            return khdal.XoaKhachHang(ID);
        }
        public string TangMa()
        {
            return khdal.TangMa();
        }
    }
}
