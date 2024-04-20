using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
   
        public class yeucaunhaphangBUS
        {
            yeucaunhaphangDL ycnhDL = new yeucaunhaphangDL();

            public DataTable laydsyc()
            {
                return ycnhDL.laydsyc();
            }


            public bool ycdhhoa(DateTime ngayyc, string manv, string mahh, string trangthai)
            {
                if (!ycnhDL.ycnhaphang(ngayyc,manv, mahh))
                {
                    if (ycnhDL.ycdh(ngayyc, manv, mahh, trangthai))
                        return true;
                }
                return false;
            }
        }
    }



