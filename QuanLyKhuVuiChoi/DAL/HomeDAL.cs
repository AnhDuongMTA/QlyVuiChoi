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
    public class HomeDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable Xem(string str)
        {
            return conn.GetData(str);
        }
        public int ThanhToan(string MaVe, string MaKhu)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaVe",MaVe),
                new SqlParameter("MaKhu",MaKhu)
            };
            return conn.ExcuteSQL("ThanhToan",para);
        }
        public DataTable TroChoiThuocKhuVuc()
        {
            return conn.GetData("XemTroChoiThuocKhuVuc");
        }
    }
}
