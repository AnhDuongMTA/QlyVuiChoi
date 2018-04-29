using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using DAL;

namespace BUS
{
    public class VeChoiBus
    {
        VeChoiDAL da = new VeChoiDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public int InsertData(VeChoiEntity Ve)
        {
            return da.InsertData(Ve);
        }
        public int UpdateData(VeChoiEntity Ve)
        {
            return da.UpdateData(Ve);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public DataTable GetListKhuVuc()
        {
            return da.GetListKhuVuc();
        }
        public DataTable GetListKhachHang()
        {
            return da.GetListKhachHang();
        }
    }
}
