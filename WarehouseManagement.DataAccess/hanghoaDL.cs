using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class HangHoaDL
    {
        DataTable w;
        public HangHoaDL()
        {
            string query = "SELECT * FROM [HangHoa] ";
            w = DataProvider.Instance.ExecuteQuery(query);

        }
        public bool themhang(string MaHH ,string TenHH ,string MoTa,string SoLuong,DateTime NgayCapNhat, string MaLoai)
        {
            int count = 0;
            var query = "INSERT INTO HangHoa( MaHH,TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai) VALUES ( @mahh , @tenhh , @mota , @soluong , @ngaycapnhat , @maloai )";
            object[] parameters = { MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai };
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count != 0)
            { return true; }
            return false;
        }
        public bool ktrtontai(string MaHH)
        {
            
            string query = "SELECT  count(*) FROM HangHoa WHERE  MaHH = @mahh ";
            object[] parameters = {MaHH };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;

        }
        public bool xoahanghoa(string mahh)
        {
            var query = $"DELETE [HangHoa] WHERE MaHH = '{mahh}' ";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool deletehang(string mahh)
        {
            var query = $"DELETE [HangHoa] WHERE MaHH = '{mahh}' ";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable dshh()
        {
            return w;
        }

    }
}
