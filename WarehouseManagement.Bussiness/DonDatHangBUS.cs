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
        DonDatHangDL nv = new DonDatHangDL();
        public DataTable LayDSDonDatHang()
        {
            return nv.GetAllDonDatHang();
        }
    }
}
