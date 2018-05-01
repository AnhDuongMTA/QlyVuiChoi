using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PhieuMuaEntity
    {
        public string MaPhieu { get; set; }
        public string NgayMua { get; set; }
        public string MaKH { get; set; }

        public PhieuMuaEntity()
        {
            MaPhieu = "";
            MaKH = "";
            NgayMua = "";
        }
        public PhieuMuaEntity(string _MaPhieu,string _NgayMua,string _MaKH)
        {
            MaPhieu = _MaPhieu;
            NgayMua = _NgayMua;
            MaKH = _MaKH;
        }
    }
}
