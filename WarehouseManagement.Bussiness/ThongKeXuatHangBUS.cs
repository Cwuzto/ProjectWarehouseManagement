using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class ThongKeXuatHangBUS
    {
        ThongKeXuatHangDL thongKeXuatHangDL;

        public ThongKeXuatHangBUS()
        {
            this.thongKeXuatHangDL = new ThongKeXuatHangDL();
        }

        public DataTable ThongKeHangXuatTheoNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return thongKeXuatHangDL.ThongKeHangXuatTheoNgay(ngayBatDau, ngayKetThuc);
        }
    }
}
