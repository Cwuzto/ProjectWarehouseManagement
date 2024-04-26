using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class QLHangDL
    {
        DataTable qlh;
        public QLHangDL()
        {
            string query = "SELECT * FROM [HangHoa] ";
            qlh = DataProvider.Instance.ExecuteQuery(query);

        }
        public bool qlhh(string MaHH, string TenHH, string MoTa, string SoLuong, DateTime NgayCapNhat,string MaLoai )
        {


            int count = 0;
            var query = "INSERT INTO HangHoa( MaHH,TenHH,MoTa ,SoLuong,NgayCapNhat, MaLoai ) VALUES ( @mahh , @tenhh , @mota , @soluong , @ngaycapnhat , @maloai" + " )";
            object[] parameters = { MaHH, TenHH, MoTa, SoLuong,NgayCapNhat,MaLoai };
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count != 0)
            { return true; }
            return false;
        }
        public DataTable laydshh()
        {
            return qlh;
        }


        public bool quanlyhanghoa(string MaHH)
        {

            string query = "SELECT  COUNT(*) FROM YeuCauDatHang WHERE  MaHH = @mahh ";
            
            object[] parameters = {MaHH };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;

        }
        public bool Deletehang(string mahh)
        {
            var query = $"DELETE [HangHoa] WHERE MaHH = '{mahh}' ";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
       
        public bool CapNhatTenHangHoa(string maHH, string tenHH)
        {
            var query = "UPDATE [HangHoa] SET TenHH = @tenmoi WHERE MaHH = @MaHH";
            object[] parameters = { tenHH, maHH };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool CapNhatMoTa(string  maHH, string mota)
        {
            var query = "UPDATE [HangHoa] SET MoTa = @motamoi WHERE MaHH = @MaHH";
            object[] parameters = { mota, maHH };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool CapNhatSoLuong(string maHH, string soluongmoi)
        {
            var query = "UPDATE [HangHoa] SET SoLuong = @soluongmoi WHERE MaHH = @MaHH";
            object[] parameters = { maHH, soluongmoi };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


    }
}
