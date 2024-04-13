using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class DonDatHangDL
    {
        DataTable DH;
        public DonDatHangDL()
        {
            var query = "SELECT * FROM [NhanVien]";
            DH = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllDonDatHang()
        {
            return DH;
        }
    }
}