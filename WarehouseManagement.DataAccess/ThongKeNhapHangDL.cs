using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class ThongKeNhapHangDL
    {
        public DataTable ThongKeHangNhapTheoNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "SELECT * FROM HangNhapKho WHERE NgayNhap BETWEEN @NgayBatDau AND @NgayKetThuc";
            object[] parameters = { ngayBatDau, ngayKetThuc };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
