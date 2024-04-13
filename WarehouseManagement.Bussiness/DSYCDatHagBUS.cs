using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Business
{
    public class DSYCDatHagBUS
    {
        DSYCDatHgDL dsYCDat = new DSYCDatHgDL();
        public DataTable LayDSYCDat()
        {
            return dsYCDat.GetAllDSYeuCau();
        }
        public DataTable Search(string loaiTimKiem, string data)
        {
            return dsYCDat.SearchData(loaiTimKiem, data);
        }
        public bool CapNhatTrangThaiYeuCau(string maYC, string trangThai)
        {
            if(dsYCDat.UpdateTrangThai(maYC,trangThai))
                return true;
            return false;
        }
    }
}
