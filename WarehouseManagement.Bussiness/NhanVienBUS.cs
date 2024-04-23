using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Business
{
    public class NhanVienBUS
    {
        NhanVienDL nv = new NhanVienDL();
        public DataTable LayDSNhanVien()
        {
            return nv.GetAllNhanVien();
        }
        public DataTable GetDSLoaiNV()
        {
            return nv.LayDSLoaiNV();
        }
        public bool AddEmployee(string ho, string ten, string sdt, string diachi, string pass, string user, string manv, int gt, string loainv)
        {
            
            if (!nv.MaNVTonTai(manv))
            {
                if (nv.AddNhanVien(ho, ten, sdt, diachi, pass, user, manv, gt, loainv) > 0)
                    return true;
            }
            MessageBox.Show("Mã nhân viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public bool UpdateNV(string thuocTinhDuocSua,string gtMuonSua,string giaTriSua, string manv)
        {
            if (giaTriSua.Equals(manv)||giaTriSua==gtMuonSua||gtMuonSua==manv)
            {
                MessageBox.Show("Mã nhân viên đã được sửa hoặc giá trị muốn sửa và giá trị sửa giống nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
