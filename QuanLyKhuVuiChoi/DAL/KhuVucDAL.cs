using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTITY;
namespace DAL
{
    public class KhuVucDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("KhuVuc_SelectAll", null);
        }
        public DataTable GetDataTTNV(String ID)
        {
            SqlParameter[] para = { new SqlParameter("MaKhu", ID) };
            return conn.GetData("KhuVuc_SelectNV", para);
        }
        public DataTable GetDataTTTC(String ID)
        {
            SqlParameter[] para = { new SqlParameter("MaKhu", ID) };
            return conn.GetData("KhuVuc_SelectTC", para);
        }
        public DataTable GetDataTTDV(String ID)
        {
            SqlParameter[] para = { new SqlParameter("MaKhu", ID) };
            return conn.GetData("KhuVuc_SelectDV", para);
        }
        public int InsertData(KhuVucEntity Kh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKhu",Kh.MaKhu),
                new SqlParameter("TenKhu",Kh.TenKhu),
                new SqlParameter("MaTK",Kh.MaTK),
                new SqlParameter("ChucNang",Kh.ChucNang),
                new SqlParameter("ViTri",Kh.ViTri),
                new SqlParameter("GiaNL",Kh.GiaNL),
                new SqlParameter("GiaTE",Kh.GiaTE)
            };
            return conn.ExcuteSQL("Them_Khu", para);
        }
        public int UpdateData(KhuVucEntity Kh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKhu",Kh.MaKhu),
                new SqlParameter("TenKhu",Kh.TenKhu),
                new SqlParameter("MaTK",Kh.MaTK),
                new SqlParameter("ChucNang",Kh.ChucNang),
                new SqlParameter("ViTri",Kh.ViTri),
                new SqlParameter("GiaNL",Kh.GiaNL),
                new SqlParameter("GiaTE",Kh.GiaTE)
        };
            return conn.ExcuteSQL("Sua_Khu ", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Ma",ID)
        };
            return conn.ExcuteSQL("Xoa_Khu ", para);
        }

        public string TangMa()
        {
            return conn.TangMa("Select * From KhuVuc ", "KV");
        }
    }
}
