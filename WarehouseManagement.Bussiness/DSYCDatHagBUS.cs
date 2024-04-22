using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
        public DataTable Search<T>(string loaiTimKiem, T data)
        {
            if (loaiTimKiem == "Ngày yêu cầu")
                loaiTimKiem = "NgayYC";
            else if (loaiTimKiem == "Mã nhân viên")
                loaiTimKiem = "MaNV";
            else if (loaiTimKiem == "Mã hàng hóa")
                loaiTimKiem = "MaHH";
            else if (loaiTimKiem == "Trạng thái")
                loaiTimKiem = "TrangThai";
            object searchData = data;

            return dsYCDat.SearchData(loaiTimKiem, searchData);
        }
        public bool CapNhatTrangThaiYeuCau(string maYC, string trangThai)
        {
            if(dsYCDat.UpdateTrangThai(maYC,trangThai))
                return true;
            return false;
        }
    }
}
