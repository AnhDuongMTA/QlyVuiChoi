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
    public class DichVuDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable XemDichVu()
        {
            return conn.GetData("SP_XemDichVu", null);
        }
        public DataTable TimKiemDichVu(string str)
        {
            return conn.GetData(str);
        }
        public int ThemDichVu(DichVu dv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDV",dv.MaDV),
                new SqlParameter("TenDV",dv.TenDV),
                new SqlParameter("GiaDV",dv.GiaDV)
            };
            return conn.ExcuteSQL("SP_ThemDichVu", para);
        }
        public int SuaDichVu(DichVu dv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDV",dv.MaDV),
                new SqlParameter("TenDV",dv.TenDV),
                new SqlParameter("GiaDV",dv.GiaDV)
            };
            return conn.ExcuteSQL("SP_SuaDichVu", para);
        }
        public int XoaDichVu(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDV",id)
            };
            return conn.ExcuteSQL("SP_XoaDichVu", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From DichVu", "DV");
        }
    }
}
