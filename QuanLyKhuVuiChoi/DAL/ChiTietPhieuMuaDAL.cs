using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ChiTietPhieuMuaDAL
    {
        KetNoi _Connect = new KetNoi();

        public DataTable GetData()
        {
            return _Connect.GetData("SP_ChiTietPhieuMuaSelectAll");
        }

        public int ThemCTPM(ChiTietPhieuMuaEntity c)
        {
            SqlParameter[] para = {
                new SqlParameter("MaPhieu",c.MaPhieu),
                new SqlParameter("MaDV",c.MaDV),
                new SqlParameter("SoLuong",c.SoLuong),
                new SqlParameter("DonGia",c.DonGia),
                new SqlParameter("ThanhTien",c.ThanhTien)
            };
            return _Connect.ExcuteSQL("SP_ThemCTPM", para);
        }
        public int SuaCTPM(ChiTietPhieuMuaEntity c)
        {
            SqlParameter[] para = {
                new SqlParameter("MaPhieu",c.MaPhieu),
                new SqlParameter("MaDV",c.MaDV),
                new SqlParameter("SoLuong",c.SoLuong),
                new SqlParameter("DonGia",c.DonGia),
                new SqlParameter("ThanhTien",c.ThanhTien)
            };
            return _Connect.ExcuteSQL("SP_SuaCTPM", para);
        }
        public int XoaCTPM(string MaPhieu)
        {
            SqlParameter[] para = {
                new SqlParameter("MaPhieu",MaPhieu)
            };
            return _Connect.ExcuteSQL("SP_XoaCTPM", para);
        }
    }
}
