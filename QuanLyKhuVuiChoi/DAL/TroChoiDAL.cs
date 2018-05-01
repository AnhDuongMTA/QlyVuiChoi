using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTITY;

namespace DAL
{
    public class TroChoiDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("TroChoi_SelectAll", null);
        }
        public int InsertData(TroChoiEntity Tc)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaTC",Tc.MaTC),
                new SqlParameter("TenTC",Tc.TenTC),
                new SqlParameter("MaKhu",Tc.MaKhu)
            };
            return conn.ExcuteSQL("Them_TroChoi", para);
        }
        public int UpdateData(TroChoiEntity Tc)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaTC",Tc.MaTC),
                new SqlParameter("TenTC",Tc.TenTC),
                new SqlParameter("MaKhu",Tc.MaKhu)
        };
            return conn.ExcuteSQL("Sua_TroChoi", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Ma",ID)
        };
            return conn.ExcuteSQL("Xoa_TroChoi ", para);
        }

        public string TangMa()
        {
            return conn.TangMa("Select * From TroChoi ", "TC");
        }

        public DataTable GetListKhuVuc()
        {
            return conn.GetData("KhuVuc_SelectAll", null);
        }
        public DataTable GetDataTC()
        {
            return conn.GetData("TroChoi_Select", null);
        }
    }
}
