using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class CTDonHangDL
    {
        public CTDonHangDL() { }
        public DataTable DSCTDHTheoMaDonHang(string mahd)
        {
            var query = "SELECT * FROM [ChiTietDH] where MaDH= @madh ";
            object[] parameters = { mahd };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable TimHangHoa(string MaHH)
        {
            string query = "SELECT * FROM [ChiTietDH] WHERE MaHH LIKE @Keyword";
            object[] parameter = { MaHH };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
