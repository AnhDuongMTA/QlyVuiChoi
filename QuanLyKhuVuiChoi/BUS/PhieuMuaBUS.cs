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
    public class PhieuMuaBUS
    {
        PhieuMuaDAL dal = new PhieuMuaDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public DataTable TimKiemPM(string str)
        {
            return dal.TimKiemPM(str);
        }

        public int ThemPM(PhieuMuaEntity pm)
        {
            return dal.ThemPM(pm);
        }
        public int SuaPM(PhieuMuaEntity pm)
        {
            return dal.SuaPM(pm);
        }
        public int XoaPM(string ID)
        {
            return dal.XoaPM(ID);
        }
         public string TangMa()
        {
            return dal.TangMa();
        }
    }
}
