using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class YCnhaphangBUS
    {
        YCnhaphangDL ycnhDL = new YCnhaphangDL();

        public DataTable laydsyc()
        {
            return ycnhDL.laydsyc();
        }


        public bool ycdhhoa(string manv,string mahh,DateTime ngayyc , string trangthai)
        {
            if (!ycnhDL.ycnhaphang( manv,mahh,ngayyc ))
            {
                if (ycnhDL.ycdh( manv,mahh ,ngayyc, trangthai))
                    return true;
            }
            return false;
        }
        public bool Deleteycnhh(string mahh)
        {
            return ycnhDL.Deleteyeucaunhaphang(mahh);
        }
    }

}
