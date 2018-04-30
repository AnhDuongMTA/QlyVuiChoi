using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ENTITY;
namespace DAL
{
    public class ChiTietDichVuDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetDataByID(String ID)
        {
            SqlParameter[] para = { new SqlParameter("Ma", ID) };
            return conn.GetData("CTDV_SelectID", para);
        }
        public int InsertData( ChiTietDichVuEntity DV)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDV",DV.MaDV),
                new SqlParameter("MaKhu",DV.MaKhu),
                new SqlParameter("GioMo",DV.GioMo),
                new SqlParameter("GioDong",DV.GioDong)
            };
            return conn.ExcuteSQL("Them_CTDV", para);
        }
        public int DeleteData(string MaDV, string MaKhu)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDV",MaDV),
                new SqlParameter("MaKhu",MaKhu)
        };
            return conn.ExcuteSQL("Xoa_CTDV", para);
        }
    }
}
