using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class yeucaunhaphangDL
    {
        DataTable yc;
         public yeucaunhaphangDL()
        {
            string query = "SELECT * FROM [YeuCauNhapHang] ";
            yc = DataProvider.Instance.ExecuteQuery(query);

        }
        public bool ycdh(DateTime NgayYC, string MaNV, string MaHH, string TrangThai)
        {
            

            int count = 0;
            var query = "INSERT INTO YeuCauNhapHang( NgayYC,MaNV, MaHH, TrangThai) VALUES ( @ngayyc , @manv , @mahh , @trangthai )";
            object[] parameters = { NgayYC, MaNV, MaHH , TrangThai };
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count != 0)
            { return true; }
            return false;
        }
        public DataTable laydsyc()
        {
            return yc;
        }
       

        public bool ycnhaphang(DateTime NgayYC,string MaNV, string MaHH)
        {
//[MaNV], [MaHH], [NgayYC]
            string query = "SELECT  count(*) FROM YeuCauDatHang WHERE MaNV = @manv AND NgayYc = @ngayyc AND MaHH = @mahh ";
;
            object[] parameters = {  MaNV, NgayYC , MaHH };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
           if (count > 0)
            return true; 
           return false;
                
            }
        
        }
    }


