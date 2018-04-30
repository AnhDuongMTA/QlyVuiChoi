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
        public int InsertData(ChiTietDichVuEntity CT)
        {
            return da.InsertData(CT);
        }
        public int DeleteData(string MaHD, string MaSP)
        {
            return da.DeleteData(MaHD, MaSP);
        }
    }
}
