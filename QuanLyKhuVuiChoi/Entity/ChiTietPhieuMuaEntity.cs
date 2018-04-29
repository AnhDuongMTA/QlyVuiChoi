using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ChiTietPhieuMuaEntity
    {
        private string _MaPhieu;
        private string _MaDV;
        private string _SoLuong;
        private string _DonGia;
        private string _ThanhTien;

        public string MaPhieu
        {
            get
            {
                return _MaPhieu;
            }

            set
            {
                _MaPhieu = value;
            }
        }

        public string MaDV
        {
            get
            {
                return _MaDV;
            }

            set
            {
                _MaDV = value;
            }
        }

        public string SoLuong
        {
            get
            {
                return _SoLuong;
            }

            set
            {
                _SoLuong = value;
            }
        }

        public string DonGia
        {
            get
            {
                return _DonGia;
            }

            set
            {
                _DonGia = value;
            }
        }

        public string ThanhTien
        {
            get
            {
                return _ThanhTien;
            }

            set
            {
                _ThanhTien = value;
            }
        }
    }
}
