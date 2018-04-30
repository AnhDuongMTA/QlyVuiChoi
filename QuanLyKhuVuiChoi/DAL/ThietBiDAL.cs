using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class ThietBiDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("ThietBi_SelectAll", null);
        }
        public DataTable GetListThietBi()
        {
            return conn.GetData("ThietBi_Select", null);
        }
        public int InsertData(ThietBiEntity Tb)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaTB",Tb.MaTB),
                new SqlParameter("TenTB",Tb.TenTB),
                new SqlParameter("MaTC",Tb.MaTC),
                new SqlParameter("NgayBD",Tb.NgayBD)
            };
            return conn.ExcuteSQL("Them_ThietBi", para);
        }
        public int UpdateData(ThietBiEntity Tb)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaTB",Tb.MaTB),
                new SqlParameter("TenTB",Tb.TenTB),
                new SqlParameter("MaTC",Tb.MaTC),
                new SqlParameter("NgayBD",Tb.NgayBD)
        };
            return conn.ExcuteSQL("Sua_ThietBi ", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Ma",ID)
        };
            return conn.ExcuteSQL("Xoa_ThietBi ", para);
        }

        public string TangMa()
        {
            return conn.TangMa("Select * From ThietBi ", "TB");
        }
    }
}
