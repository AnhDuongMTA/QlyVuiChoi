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
    public class ChiTietThietBiDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetDataByID(String ID)
        {
            SqlParameter[] para = { new SqlParameter("Ma", ID) };
            return conn.GetData("CTTB_SelectID", para);
        }
        public int InsertData(ChiTietThietBiEntity TB)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaTC",TB.MaTC),
                new SqlParameter("MaTB",TB.MaTB),
                new SqlParameter("SoLuong",TB.SoLuong),
            };
            return conn.ExcuteSQL("Them_CTTB", para);
        }
        public int DeleteData(string MaTC, string MaTB)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaTC",MaTC),
                new SqlParameter("MaTB",MaTB)
        };
            return conn.ExcuteSQL("Xoa_CTTB", para);
        }
    }
}
