using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable DoanhThuBanVe(string str, string str2)
        {
            SqlParameter[] para =
            {
                new SqlParameter("NgayBan1",str),
                new SqlParameter("NgayBan2",str2)
            };
            return conn.GetData("SP_DoanhThuBanVe", para);
        }
        public DataTable DoanhThuDichVu(string str, string str2)
        {
            SqlParameter[] para =
            {
                new SqlParameter("NgayMua1",str),
                new SqlParameter("NgayMua2",str2)
            };
            return conn.GetData("SP_DoanhThuDichVu", para);
        }
    }
}
