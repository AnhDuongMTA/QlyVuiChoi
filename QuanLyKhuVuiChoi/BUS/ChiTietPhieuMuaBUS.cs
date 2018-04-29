using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BUS
{
    public class ChiTietPhieuMuaBUS
    {
        ChiTietPhieuMuaDAL dal = new ChiTietPhieuMuaDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }

        public int ThemCTPM(ChiTietPhieuMuaEntity c)
        {

            return dal.ThemCTPM(c);
        }
        public int SuaCTPM(ChiTietPhieuMuaEntity c)
        {

            return dal.SuaCTPM(c);
        }

        public int XoaCTPM(string MaPhieu)
        {

            return dal.XoaCTPM(MaPhieu);
        }
    }
}
