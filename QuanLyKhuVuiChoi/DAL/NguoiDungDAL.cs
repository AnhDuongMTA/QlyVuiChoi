using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class NguoiDungDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetUser(NguoiDung nd)
        {
            SqlParameter[] para = { new SqlParameter("TaiKhoan", nd.TaiKhoan),
                                    new SqlParameter("MatKhau", nd.MatKhau),
                                    new SqlParameter("PhanQuyen", nd.PhanQuyen)
                                   
            };
            return conn.GetData("DangNhap", para);
        }
        public int ThemNguoiDung(NguoiDung nd)
        {
            SqlParameter[] para = { new SqlParameter("TaiKhoan", nd.TaiKhoan),
                                    new SqlParameter("MatKhau", nd.MatKhau),
                                    new SqlParameter("PhanQuyen", nd.PhanQuyen),
                                    new SqlParameter("MaNV", nd.MaNV)
            };
            return conn.ExcuteSQL("SP_ThemNguoiDung", para);
        }
    }
}
