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
    public class CTDonHangDL
    {
        public CTDonHangDL() { }
        public DataTable DSCTDHTheoMaDonHang(string madh)
        {
            var query = "SELECT MaHH, SoLuong, GiaNhap FROM [ChiTietDH] where MaDH= @madh ";
            object[] parameters = { madh };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public bool HHDaCoTrongDH(string madh, string mahh)
        {
            string query = "SELECT COUNT(*) FROM ChiTietDH WHERE MaDH = @madh And MaHH= @Mahh ";
            object[] parameters = { madh, mahh };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;
        }
        public void ThemChiTietHD(List<Tuple<string, int, double>> data, string madh)
        {

            string query = "INSERT INTO ChiTietDH (MaDH, MaHH, SoLuong, GiaNhap) VALUES ( @MaDH , @MaHH , @SoLuong , @GiaNhap )";
            foreach (var item in data)
            {
                if(!HHDaCoTrongDH(madh, item.Item1))
                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { madh, item.Item1, item.Item2, item.Item3 });
            }
        }
    }
}
