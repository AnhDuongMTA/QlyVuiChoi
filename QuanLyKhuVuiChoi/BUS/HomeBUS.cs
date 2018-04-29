using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;

namespace BUS
{
    public class HomeBUS
    {
        HomeDAL homedal = new HomeDAL();
        public int ThanhToan(string MaVe,string MaKhu)
        {
            return homedal.ThanhToan(MaVe,MaKhu);
        }
        public DataTable Xem(string str)
        {
            return homedal.Xem(str);
        }
        public DataTable XemTroChoiThuocKhuVuc()
        {
            return homedal.TroChoiThuocKhuVuc();
        }
    }
}
