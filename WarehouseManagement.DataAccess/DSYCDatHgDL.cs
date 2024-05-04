using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class DSYCDatHgDL
    {
        DataTable dsYC;
        public DSYCDatHgDL()
        {
            var query = "SELECT * FROM [YeuCauDatHang]";
            dsYC = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllDSYeuCau()
        {
            return dsYC;
        }
        public DataTable SearchData(string loaiTimKiem, object keyword)
        {
            string query;
            object[] parameters;

            if (keyword is DateTime)
            {
                DateTime date = (DateTime)keyword;
                string ngayyc = date.ToString("yyyy/MM/dd");
                query = $"SELECT * FROM YeuCauDatHang WHERE {loaiTimKiem} = CONVERT(date, @Keyword )";
                parameters = new object[] { ngayyc };
            }
            else
            {
                query = $"SELECT * FROM YeuCauDatHang WHERE {loaiTimKiem} LIKE @Keyword ";
                parameters = new object[] { "%" + keyword.ToString() + "%" };
            }

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public bool UpdateTrangThai(DateTime ngayYC, string manv, string mahh, string trangThaiMoi)
        {
            string query = "UPDATE YeuCauDatHang SET TrangThai = @TrangThai WHERE NgayYC = CONVERT(date, @ngayyc ) AND MaNV = @manv AND MaHH= @mahh ";
            object[] parameters = {"Đã "+ trangThaiMoi, ngayYC, manv, mahh };
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return true;
            return false; 
        }
    }
}
