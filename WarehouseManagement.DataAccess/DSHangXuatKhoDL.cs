using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class DSHangXuatKhoDL
    {
        DataTable dsHg;
        public DSHangXuatKhoDL()
        {
            var query = "SELECT * FROM [HangXuatKho]";
            dsHg = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllDSHgXuatKho()
        {
            return dsHg;
        }
        public DataTable SearchData(string loaiTimKiem, object keyword)
        {
            string query;
            object[] parameters;

            if (keyword is DateTime)
            {
                DateTime date = (DateTime)keyword;
                string ngayxuat = date.ToString("yyyy/MM/dd");
                query = $"SELECT * FROM HangXuatKho WHERE CONVERT(date, {loaiTimKiem}) = CONVERT(date, @Keyword )";
                parameters = new object[] { ngayxuat };
            }
            else
            {
                query = $"SELECT * FROM HangXuatKho WHERE {loaiTimKiem} LIKE @Keyword ";
                parameters = new object[] { "%" + keyword.ToString() + "%" };
            }

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
