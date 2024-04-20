using System;
using System.Data;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class YeucaunhaphangDL
    {
        DataTable yc;

        public bool ycdh(/*DateTime NgayYC,*/ string MaNV, string MaHH, string TrangThai)
         {
             int count = 0;
             var query = "INSERT INTO YeuCauNhapHang(NgayYC, MaNV, MaHH, TrangThai) VALUES (@ngayyc, @manv, @mahh, @trangthai )";
             object[] parameters = {/* NgayYC,*/ MaNV, MaHH, TrangThai };
             count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return (count != 0);
            { return true; }
            return false;
         }
        public DataTable laydsyc()
        {
            return yc;
        }
        public YeucaunhaphangDL()
        {
            string query = $"SELECT * FROM [YeuCauDatHang] ";
            yc = DataProvider.Instance.ExecuteQuery(query);

        }

       
         public bool ycnhaphang(string MaNV,string MaHH)
          {
              string query = "SELECT * FROM YeuCauDatHang WHERE MaNV = @MaNV AND MaHH = @MaHH ";
              object[] parameters = { MaNV, MaHH };
              int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
              return count > 0;
          }
      }
    }

