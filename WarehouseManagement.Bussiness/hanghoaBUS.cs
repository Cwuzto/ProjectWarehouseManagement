using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{

    public class hanghoaBUS
    {
        hanghoaDL HH = new hanghoaDL();
        public DataTable Laydshanghoa()
        {
            return HH.Laydshanghoa();
        }
        public DataTable timhang(string data)
        {
            return HH.timhanghoa(data);
        }
    }
}