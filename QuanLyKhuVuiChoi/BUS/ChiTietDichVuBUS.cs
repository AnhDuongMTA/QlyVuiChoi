using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ENTITY;
using DAL;

namespace BUS
{
    public class ChiTietDichVuBUS
    {
        ChiTietDichVuDAL da = new ChiTietDichVuDAL();
        public DataTable GetDataByID(string ID)
        {
            return da.GetDataByID(ID);
        }
        public int InsertData(ChiTietDichVuEntity DV)
        {
            return da.InsertData(DV);
        }
        public int DeleteData(string MaDV, string MaKhu)
        {
            return da.DeleteData(MaDV, MaKhu);
        }
    }
}
