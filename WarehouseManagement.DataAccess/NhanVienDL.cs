using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.DataAccess
{
    public class NhanVienDL
    {
        DataTable NV;
        public NhanVienDL()
        {
            var query = "SELECT * FROM [NhanVien]";
            NV = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllNhanVien()
        {
            return NV;
        }
        public int AddNhanVien(string ho, string ten, string sdt, string diachi, string pass, string user, string manv, int gt, string maloainv)
        {
            int count = 0;

            string query = "INSERT INTO NhanVien (MaNV, HoNV, TenNV, DiaChi, SDT, GioiTinh, UserName, Password, MaLoai) VALUES ( @manv , @ho , @ten , @diachi , @sdt , @gt , @user , @pass , @maloainv )";

            object[] parameters = { manv, ho, ten, diachi, sdt, gt, user, pass, maloainv };

            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return count;
        }
        public DataTable LayDSLoaiNV()
        {
            string query = "SELECT * FROM LoaiNV ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool MaNVTonTai(string maNV)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV ";
            object[] parameters = { maNV };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;
        }
        public bool UpdateNhanVien(string thuocTinhDuocSua, string giaTriSua, string manv)
        {
            var query = $"UPDATE [NhanVien] SET {thuocTinhDuocSua} = @giaTriSua WHERE MaNV = @manv ";
            object[] parameters = {giaTriSua, manv };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool DeleteNhanVien(string manv)
        {
            var query = $"DELETE [NhanVien] WHERE MaNV = '{manv}' ";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
