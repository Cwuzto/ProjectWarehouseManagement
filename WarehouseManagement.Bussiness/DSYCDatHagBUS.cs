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
        QLHangDL qlh = new QLHangDL();
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
        public bool CapNhatTrangThaiYeuCau(DateTime ngayYC, string manv, string mahh, string trangThai)
        {
            if (qlh.quanlyhanghoa(mahh))
            {
                if (dsYCDat.UpdateTrangThai(ngayYC, manv, mahh, trangThai))
                    return true;
            }
            return false;
        }
    }
}
