using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class DonDatHangDL
    {
        DataTable DH;
        public DonDatHangDL()
        {
            var query = "SELECT * FROM [DonDatHang]";
            DH = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllDonDatHang()
        {
            return DH;
        }
        public bool THDDH(String MaDH,DateTime NgayDat , String TrangThai, String MaNV)
        {
            int count = 0;
            var query = "INSERT INTO DonDatHang (MaDH, NgayDat, TrangThai, MaNV) VALUES ( @madh , @ngaydat , @trangthai , @manv )";
            object[] parameters = { MaDH, NgayDat,TrangThai, MaNV };
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count!= 0) { return true; }
            return false;



        }
        public bool MaDonHangTonTai(string maDH)
        {
            string query = "SELECT COUNT(*) FROM DonDatHang WHERE MaDH = @MaDH ";
            object[] parameters = { maDH };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;
        }
        public bool DeleteDonDatHang(string madh)
        {
            var query = $"DELETE [DonDatHang] WHERE MaDH = '{madh}' ";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateDonDatHang(string madh, string tinhtrang)
        {
            var query = $"UPDATE [DonDatHang] SET TrangThai= @trangthai WHERE MaDH= '{madh}'";
            object[] parameters = { tinhtrang };
            var result =  DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}