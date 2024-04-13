using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class DSYCNhapHangDL
    {
        DataTable dsYC;
        public DSYCNhapHangDL()
        {
            var query = "SELECT * FROM [YeuCauNhapHang]";
            dsYC = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllDSYeuCau()
        {
            return dsYC;
        }
        public DataTable SearchData(string loaiTimKiem, string keyword)
        {
            
            string query = $"SELECT * FROM YeuCauNhapHang WHERE {loaiTimKiem} LIKE @Keyword ";
            object[] parameter = { "%" + keyword + "%" };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
