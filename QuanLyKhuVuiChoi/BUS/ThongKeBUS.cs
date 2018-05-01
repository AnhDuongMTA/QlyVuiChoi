using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class ThongKeBUS
    {
        ThongKeDAL tkdal = new ThongKeDAL();
        public DataTable DoanhThuBanVe(string str, string str2)
        {
            return tkdal.DoanhThuBanVe(str, str2);
        }
        public DataTable DoanhThuDichVu(string str, string str2)
        {
            return tkdal.DoanhThuDichVu(str, str2);
        }
    }
}
