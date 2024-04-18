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
        public DataTable Laydshanghoa()
        {
            return hh;
        }
    }
}
