using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class LoaiNVBUS
    {
        LoaiNVDL loainv = new LoaiNVDL();
        public DataTable LayDSLoaiNV()
        {
            return loainv.GetAllLoaiNV();
        }
        public bool ThemLoaiNV(string maloai, string tenloai)
        {
            if (!loainv.MaLoaiTonTai(maloai)||tenloai=="")
            {
                if (loainv.AddLoaiNV(maloai,tenloai) > 0)
                    return true;
            }
            return false;
        }
        public bool Update(string oldMaLoai,string maloai, string tenloai)
        {
            if (tenloai==""||oldMaLoai!=maloai)
                return false;
            return loainv.UpdateLoaiNV(maloai, tenloai);
        }
        public bool DeleteLoaiNV(string maloai)
        {
            return loainv.DelLoaiNV(maloai);
        }
    }
}
