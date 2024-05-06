﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class YeuCauDatHangBUS
    {
        YeuCauDatHangDL dh = new YeuCauDatHangDL();
        public DataTable LayDSYeuCauDatHang()
        {
            return dh.GetAllYeuCauDatHang();
        }
        public bool JKYCDH(DateTime ngayyeucau, string manv, string mahh, string trangthai)
        {
            if (!dh.KiemTraTonTai(mahh, manv, ngayyeucau))
            {
                if (dh.THYCDH(ngayyeucau, manv, mahh, trangthai))
                    return true;
            }
            return false;
        }
        public bool DeleteYeuCauDatHang(String mahh)
        {
            return dh.DeleteYeuCauDatHang(mahh);
        }
        public bool UpdateYeuCauDatHang(string mahh, string maNV, string mahhcu, DateTime ngayyc)
        {
            if (!dh.KiemTraTonTai( mahh,  maNV, ngayyc))
            {
                if (dh.UpdateYeuCauDatHang(mahh,  maNV, mahhcu, ngayyc))

                    return true;
            }
            return false;

        }

        
    }


}