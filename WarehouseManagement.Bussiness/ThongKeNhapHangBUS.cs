using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class ThongKeNhapHangBUS
    {
        ThongKeNhapHangDL thongKeNhapHangDL;

        public ThongKeNhapHangBUS()
        {
            this.thongKeNhapHangDL = new ThongKeNhapHangDL();
        }

        public DataTable ThongKeHangNhapTheoNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return thongKeNhapHangDL.ThongKeHangNhapTheoNgay(ngayBatDau, ngayKetThuc);
        }
    }
}
