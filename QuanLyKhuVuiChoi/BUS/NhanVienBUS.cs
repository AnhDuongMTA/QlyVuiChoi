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
    public class NhanVienBUS
    {
        NhanVienDAL nvdal = new NhanVienDAL();
        public DataTable GetDataNhanVien()
        {
            return nvdal.GetData();
        }
        public DataTable TimKiem(string str)
        {
            return nvdal.TimKiem(str);
        }
        public int ThemNhanVien(NhanVien nv)
        {
            return nvdal.ThemNhanVien(nv);
        }
        public int SuaNhanVien(NhanVien nv)
        {
            return nvdal.SuaNhanVien(nv);
        }
        public int XoaNhanVien(string ID)
        {
            return nvdal.XoaNhanVien(ID);
        }
        public string TangMa()
        {
            return nvdal.TangMa();
        }
        public DataTable GetListDataNV()
        {
            return nvdal.GetListDataNV();
        }
    }
}
