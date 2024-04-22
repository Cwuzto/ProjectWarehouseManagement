using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class DSHangXuatKhoBUS
    {
        DSHangXuatKhoDL dsHang = new DSHangXuatKhoDL();
        public DataTable LayDSHgXuatKho()
        {
            return dsHang.GetAllDSHgXuatKho();
        }
        public DataTable Search<T>(string loaiTimKiem, T data)
        {
            if (loaiTimKiem == "Ngày xuất")
                loaiTimKiem = "NgayXuat";
            else if (loaiTimKiem == "Mã nhân viên")
                loaiTimKiem = "MaNV";
            else if (loaiTimKiem == "Mã hàng hóa")
                loaiTimKiem = "MaHH";
            object searchData = data;

            return dsHang.SearchData(loaiTimKiem, searchData);
        }
    }
}
