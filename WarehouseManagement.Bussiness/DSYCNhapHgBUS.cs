using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class DSYCNhapHgBUS
    {
        DSYCNhapHangDL dsYCNhap = new DSYCNhapHangDL();
        public DataTable LayDSYCNhap()
        {
            return dsYCNhap.GetAllDSYeuCau();
        }
        public DataTable Search(string loaiTimKiem, string data) 
        {
            return dsYCNhap.SearchData(loaiTimKiem, data);
        }
    }
}
