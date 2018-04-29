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
    public class ThietBiBus
    {
        ThietBiDAL da = new ThietBiDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public DataTable GetListTroChoi()
        {
            return da.GetListTroChoi();
        }
        public int InsertData(ThietBiEntity Tb)
        {
            return da.InsertData(Tb);
        }
        public int UpdateData(ThietBiEntity Tb)
        {
            return da.UpdateData(Tb);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
    }
}
