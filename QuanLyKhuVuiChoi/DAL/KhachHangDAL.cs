using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class KhachHangDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("SP_XemKhachHang", null);
        }
        public DataTable TimKiem(string str)
        {
            return conn.GetData(str);
        }
        public int ThemKhachHang(KhachHang kh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",kh.MaKhachHang),
                new SqlParameter("TenKH",kh.TenKhachHang),
                new SqlParameter("NamSinh",kh.NamSinh),
                new SqlParameter("GioiTinh",kh.GioiTinh),
                new SqlParameter("SDT",kh.SDT)
            };
            return conn.ExcuteSQL("SP_ThemKhachHang", para);
        }
        public int SuaKhachHang(KhachHang kh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",kh.MaKhachHang),
                new SqlParameter("TenKH",kh.TenKhachHang),
                new SqlParameter("NamSinh",kh.NamSinh),
                new SqlParameter("GioiTinh",kh.GioiTinh),
                new SqlParameter("SDT",kh.SDT)
            };
            return conn.ExcuteSQL("SP_SuaKhachHang", para);
        }
        public int XoaKhachHang(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",ID)
            };
            return conn.ExcuteSQL("SP_XoaKhachHang", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From KhachHang", "KH");
        }
    }
}
