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
        public DataTable SearchData(string loaiTimKiem, object keyword)
        {
            string query;
            object[] parameters;

            if (keyword is DateTime)
            {
                DateTime date = (DateTime)keyword;
                string ngayyc = date.ToString("yyyy/MM/dd");
                query = $"SELECT * FROM YeuCauNhapHang WHERE {loaiTimKiem} = CONVERT(date, @Keyword )";
                parameters = new object[] { ngayyc };
            }
            else
            {
                query = $"SELECT * FROM YeuCauNhapHang WHERE {loaiTimKiem} LIKE @Keyword ";
                parameters = new object[] { "%" + keyword.ToString() + "%" };
            }

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
