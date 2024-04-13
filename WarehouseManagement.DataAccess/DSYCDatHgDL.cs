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
        public DataTable SearchData(string loaiTimKiem, string keyword)
        {

            string query = $"SELECT * FROM YeuCauDatHang WHERE {loaiTimKiem} LIKE @Keyword ";
            object[] parameter = { "%" + keyword + "%" };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
        public bool UpdateTrangThai(string maYC, string trangThaiMoi)
        {
            string query = "UPDATE YeuCauDatHang SET TrangThai = @TrangThai WHERE MaYC = @MaYeuCau";
            object[] parameters = { trangThaiMoi, maYC };
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
                return true;
            return false; 
        }
    }
}
