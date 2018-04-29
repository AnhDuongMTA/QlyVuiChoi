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
    public class DichVuBUS
    {
        DichVuDAL dvdal = new DichVuDAL();
        public DataTable XemDichVu()
        {
            return dvdal.XemDichVu();
        }
        public DataTable TimKiemDichVu(string str)
        {
            return dvdal.TimKiemDichVu(str);
        }
        public int ThemDichVu(DichVu dv)
        {
            return dvdal.ThemDichVu(dv);
        }
        public int SuaDichVu(DichVu dv)
        {
            return dvdal.SuaDichVu(dv);
        }
        public int XoaDichVu(string id)
        {
            return dvdal.XoaDichVu(id);
        }
        public string TangMa()
        {
            return dvdal.TangMa();
        }
    }
}
