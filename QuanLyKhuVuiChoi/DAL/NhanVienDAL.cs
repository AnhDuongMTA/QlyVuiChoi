using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NhanVienDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("SP_XemThongTinNhanVien", null);
        }
        public DataTable TimKiem(string str)
        {
            return conn.GetData(str);
        }
        public int ThemNhanVien(NhanVien nv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",nv.MaNV),
                new SqlParameter("TenNV",nv.TenNV),
                new SqlParameter("GioiTinh",nv.GioiTinh),
                new SqlParameter("Luong",nv.Luong),
                new SqlParameter("MaKhu",nv.MaKhu),
                new SqlParameter("NgaySinh",nv.NgaySinh),
                new SqlParameter("DiaChi",nv.DiaChi)
            };
            return conn.ExcuteSQL("SP_ThemNhanVien", para);
        }
        public int SuaNhanVien(NhanVien nv)
        {
            SqlParameter[] para =
            {
               new SqlParameter("MaNV",nv.MaNV),
                new SqlParameter("TenNV",nv.TenNV),
                new SqlParameter("GioiTinh",nv.GioiTinh),
                new SqlParameter("Luong",nv.Luong),
                new SqlParameter("MaKhu",nv.MaKhu),
                new SqlParameter("NgaySinh",nv.NgaySinh),
                new SqlParameter("DiaChi",nv.DiaChi)
            };
            return conn.ExcuteSQL("SP_SuaNhanVien", para);
        }
        public int XoaNhanVien(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",ID)
            };
            return conn.ExcuteSQL("SP_XoaNhanVien", para);
        }
        public string TangMa()
        {
            return conn.TangMa(" SELECT * FROM dbo.NhanVien", "NV");
        }
        public DataTable GetListDataNV()
        {
            return conn.GetData("SP_SelectNV", null);
        }
    }
}
