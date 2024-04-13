using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class NhanVienBUS
    {
        NhanVienDL nv = new NhanVienDL();
        public DataTable LayDSNhanVien()
        {
            return nv.GetAllNhanVien();
        }
        public bool AddEmployee(string ho, string ten, string sdt, string diachi, string pass, string user, string manv, int gt, string loainv)
        {
            var maloai = nv.LayMaLoaiTuTenLoaiNV(loainv);
            if (!nv.MaNVTonTai(manv))
            {
                if (nv.AddNhanVien(ho, ten, sdt, diachi, pass, user, manv, gt, maloai) > 0)
                    return true;
            }
            return false;
        }
        public bool UpdateNV(string thuocTinhDuocSua,string gtMuonSua,string giaTriSua, string manv)
        {
            if (giaTriSua.Equals(manv)||giaTriSua==gtMuonSua||gtMuonSua==""||giaTriSua==""||gtMuonSua==manv)
            {
                return false;
            }
            
            return nv.UpdateNhanVien(thuocTinhDuocSua,giaTriSua,manv);
        }
        public bool DeleteNV(string manv)
        {
            return nv.DeleteNhanVien(manv);
        }
    }
}
