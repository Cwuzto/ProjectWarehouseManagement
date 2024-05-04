
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{

    public class hanghoaDL
    {
        DataTable hh;
        public hanghoaDL()
        {
            var query = "SELECT * FROM [HangHoa]";
            hh = DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable timhanghoa(string MaHH)
        {
            string query = "SELECT * FROM [HangHoa] WHERE MaHH LIKE @Keyword";
            object[] parameter = { MaHH };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

        public DataTable Laydshanghoa()
        {
            return hh;
        }
    }
}