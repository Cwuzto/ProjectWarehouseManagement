using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class CTDonHangBUS
    {
        CTDonHangDL ctHD=new CTDonHangDL();
        public DataTable DSCTDHTheoMaDH(string madh)
        {
            return ctHD.DSCTDHTheoMaDonHang(madh);
        }
        public DataTable TimHang(string data)
        {
            return ctHD.TimHangHoa(data);
        }
    }
}
