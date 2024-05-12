using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class YeuCauDatHangDL
    {
        DataTable YCDH;
        public YeuCauDatHangDL()
        {
            var query = "SELECT * FROM [YeuCauDatHang]";
            YCDH = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllYeuCauDatHang()
        {
            return YCDH;
        }
        public bool THYCDH(DateTime NgayYeuCau, String MaNV, String MaHH)
        {
            int count = 0;
            var query = "INSERT INTO YeuCauDatHang (NgayYC, MaNV, MaHH, TrangThai) VALUES ( @ngayyeucau , @manv , @mahh , N'Chờ xử lý')";
            object[] parameters = { NgayYeuCau, MaNV, MaHH};
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count != 0) { return true; }
            return false;

        }
        
        public bool DeleteYeuCauDatHang(string mahh, DateTime ngayyc, String manv)
        {
            var query = "DELETE [YeuCauDatHang] where NgayYC = CONVERT(date, @ngayyc ) and MaNV = @manv and MaHH = @mahh ";
            object[] parameters = { ngayyc, manv, mahh };
            var result = DataProvider.Instance.ExecuteNonQuery(query,parameters);
            return result > 0;
        }
        public bool UpdateYeuCauDatHang(string mahh, string maNV, string maHHcu, DateTime ngayyc)
        {
            var query = $"UPDATE [YeuCauDatHang] SET MaHH= @mahh WHERE MaHH= '{maHHcu}' and NgayYC = CONVERT(date, @ngayyc ) and MaNV = @manv ";
            object[] parameters = { mahh, ngayyc, maNV};
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool KiemTraTonTai ( string maHH, string maNV,  DateTime ngayyc)
        {
            var query = $"SELECT count(*) FROM YeuCauDatHang where NgayYC = CONVERT(date, @ngayyc ) and MaNV = @manv and MaHH = @mahh ";
            object[] parametera = { ngayyc, maNV, maHH };
            int count =( int ) DataProvider.Instance.ExecuteScalar(query, parametera);
            if (count>0)
            { return true; }
            return false;
        }
        public bool KiemTraCoYCMoi()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM YeuCauDatHang WHERE TrangThai = N'Chờ xử lý'");
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }

}
