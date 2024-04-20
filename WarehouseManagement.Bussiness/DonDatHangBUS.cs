using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Business
{
    public class DonDatHangBUS
    {
        DonDatHangDL dh = new DonDatHangDL();
        public DataTable LayDSDonDatHang()
        {
            return dh.GetAllDonDatHang();
        }
        public bool JKDDH(string madh, DateTime ngaydat, string trangthai, string manv)
        {

            if (!dh.MaDonHangTonTai(madh))
            {
                if (dh.THDDH(madh, ngaydat, trangthai, manv))
                    return true;
            }
            return false;
        }
        public bool DeleteDonDatHang(string madh)
        {
            return dh.DeleteDonDatHang(madh);
        }
        public bool UpdateDonDatHang(string madh, string tinhtrang, string madoncu, string tinhtrangcu)
        {
            if(madh==madoncu && tinhtrang!="" && tinhtrangcu != "Đã hoàn thành")
            {
                if(dh.UpdateDonDatHang(madh,tinhtrang))

                    return true;
            }
            return false;

        }
    }
    
}
