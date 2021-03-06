﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTITY;
using DAL;

namespace BUS
{
    public class TrochoiBus
    {
        TroChoiDAL Dal = new TroChoiDAL();
        public DataTable GetData()
        {
            return Dal.GetData();
        }
        public DataTable XemTC()
        {
            return Dal.XemTC();
        }
        public int InsertData(TroChoiEntity Tc)
        {
            return Dal.InsertData(Tc);
        }
        public int UpdateData(TroChoiEntity Tc)
        {
            return Dal.UpdateData(Tc);
        }
        public int DeleteData(String ID)
        {
            return Dal.DeleteData(ID);
        }
        public string TangMa()
        {
            return Dal.TangMa();
        }
        public DataTable GetDataTC()
        {
            return Dal.GetDataTC();
        }
        public DataTable GetListKhuVuc()
        {
            return Dal.GetListKhuVuc();
        }
    }
}
