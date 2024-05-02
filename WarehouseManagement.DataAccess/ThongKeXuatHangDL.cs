using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;
using System.Data.SqlClient;

namespace WarehouseManagement.DataAccess
{
    public class ThongKeXuatHangDL
    {
        public DataTable ThongKeHangXuatTheoNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "SELECT * FROM HangXuatKho WHERE NgayXuat BETWEEN @NgayBatDau AND @NgayKetThuc";
            object[] parameters = { ngayBatDau, ngayKetThuc };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
