using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class XemDSHangton
    {
        DataTable dshtk;
        public XemDSHangton()
        {
            var query = "SELECT * FROM [HangHoa]";
            dshtk = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAlldshangton()
        {
            return dshtk;
        }
        public DataTable timhanghoa(string MaHH)
        {
            string query = "SELECT * FROM [HangHoa] WHERE MaHH LIKE @Keyword";
            object[] parameter = { MaHH };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
        public void CapNhapSL(List<Tuple<string, int>> data, DateTime ngaycapnhat)
        {

            string query = "Update HangHoa Set SoLuong = @sl , NgayCapNhat = CONVERT(date, @ngaycapnhat ) Where MaHH= @Mahh";
            foreach (var item in data)
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { item.Item2, ngaycapnhat ,item.Item1});
            }
        }
    }
}
