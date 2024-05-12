using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    
    public class YCnhaphangDL
    {
        DataTable yc;
        public YCnhaphangDL()
        {
            string query = "SELECT * FROM [YeuCauNhapHang] ";
            yc = DataProvider.Instance.ExecuteQuery(query);

        }
        public bool ycdh( string MaNV, string MaHH,DateTime NgayYC)
        {
            int count = 0;
            var query = "INSERT INTO YeuCauNhapHang( MaNV,MaHH,NgayYC ,TrangThai) VALUES ( @manv , @mahh , @ngayyc , N'Đã gửi yêu cầu' )";
            object[] parameters = { MaNV, MaHH, NgayYC};
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count != 0)
            { return true; }
            return false;
        }
        public DataTable laydsyc()
        {
            return yc;
        }


        public bool ycnhaphang( string MaNV, string MaHH,DateTime NgayYC)
        {

            string query = "SELECT  COUNT(*) FROM YeuCauDatHang WHERE MaNV = @manv AND MaHH = @mahh AND NgayYc = @ngayyc ";
            object[] parameters = {  MaNV, MaHH,NgayYC };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;

        }
        public bool Deleteyeucaunhaphang(string mahh, DateTime ngayyc, string manv)
        {
            var query = $"DELETE [YeuCauNhapHang] WHERE MaHH = '{mahh}' and NgayYC = CONVERT(date, @ngayyc ) and MaNV= '{manv}'";
            object[] parameters = { ngayyc };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool KiemTraCoYCMoi()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM YeuCauNhapHang WHERE TrangThai = N'Đã gửi yêu cầu'");
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public void CapNhatTrangThaiKhiDaXem()
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE YeuCauNhapHang SET TrangThai = N'Đã xem' WHERE TrangThai = N'Đã gửi yêu cầu'");
        }
    }
}





