using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class XemDSHangtonBUS
    {
        XemDSHangton dsht = new XemDSHangton();
        public DataTable Laydsht()
        {
            return dsht.GetAlldshangton();
        }
        public DataTable timhang(string data)
        {
            return dsht.timhanghoa(data);
        }
    }
}
