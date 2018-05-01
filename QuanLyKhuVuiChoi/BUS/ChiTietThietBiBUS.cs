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
    public class ChiTietThietBiBUS
    {
        ChiTietThietBiDAL da = new ChiTietThietBiDAL();
        public DataTable GetDataByID(string ID)
        {
            return da.GetDataByID(ID);
        }
        public int InsertData(ChiTietThietBiEntity CT)
        {
            return da.InsertData(CT);
        }
        public int DeleteData(string MaTC, string MaTB)
        {
            return da.DeleteData(MaTC, MaTB);
        }
    }
}
