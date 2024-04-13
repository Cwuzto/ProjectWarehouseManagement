using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{  
    public class LoaiNVDL
    {
        DataTable loaiNV;
        public LoaiNVDL()
        {

            var query = "SELECT * FROM [LoaiNV]";
            loaiNV = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllLoaiNV()
        {
            return loaiNV;
        }
        public int AddLoaiNV(string maloai, string tenloai)
        {
            int count = 0;

            string query = "INSERT INTO LoaiNV (MaLoaiNV, TenLoaiNV) VALUES ( @maloainv , @tenloainv )";

            object[] parameters = { maloai , tenloai };

            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return count;
        }
        public bool MaLoaiTonTai(string maloai)
        {
            string query = "SELECT COUNT(*) FROM LoaiNV WHERE MaLoaiNV = @MaLoai ";
            object[] parameters = { maloai };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;
        }
        public bool UpdateLoaiNV(string maloai, string tenloai)
        {
            var query = $"UPDATE [LoaiNV] SET TenLoaiNV = @tenloai WHERE MaLoaiNV = @maloai ";
            object[] parameters = { tenloai , maloai };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool DelLoaiNV(string maloai)
        {
            var query = $"DELETE [LoaiNV] WHERE MaLoaiNV = '{maloai}' ";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
