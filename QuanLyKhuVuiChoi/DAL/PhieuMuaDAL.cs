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
    public class PhieuMuaDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("XemPM", null);
        }
        public DataTable TimKiemPM(string str)
        {
            return conn.GetData(str);
        }

        public int ThemPM(PhieuMuaEntity pm)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieu",pm.MaPhieu),
                new SqlParameter("NgayMua",pm.NgayMua),
                new SqlParameter("MaKH",pm.MaKH)
            };
            return conn.ExcuteSQL("ThemPM", para);
        }
        public int SuaPM(PhieuMuaEntity pm)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieu",pm.MaPhieu),
                new SqlParameter("NgayMua",pm.NgayMua),
                new SqlParameter("MaKH",pm.MaKH)
            };
            return conn.ExcuteSQL("SuaPM", para);
        }

        public int XoaPM(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieu",ID)
            };
            return conn.ExcuteSQL("XoaPM", para);
        }

        public string TangMa()
        {
            return conn.TangMa("select * from PhieuMua", "PM");
        }
    }
}
