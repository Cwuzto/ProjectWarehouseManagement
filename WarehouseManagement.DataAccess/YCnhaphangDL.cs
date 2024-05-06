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
        public bool ycdh( string MaNV, string MaHH,DateTime NgayYC ,string TrangThai)
        {


            int count = 0;
            var query = "INSERT INTO YeuCauNhapHang( MaNV,MaHH,NgayYC ,TrangThai) VALUES ( @manv , @ngayyc , @mahh , @trangthai" +
                " )";
            object[] parameters = { MaNV, MaHH, NgayYC,TrangThai };
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
            ;
            object[] parameters = {  MaNV, MaHH,NgayYC };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;

        }
        public bool Deleteyeucaunhaphang(string mahh)
        {
            var query = $"DELETE [YeuCauNhapHang] WHERE MaHH = '{mahh}' ";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}





