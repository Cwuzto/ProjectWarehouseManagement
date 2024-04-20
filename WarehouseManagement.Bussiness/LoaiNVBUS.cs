using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Business
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
            MessageBox.Show("Mã loại nhân viên đã tồn tại hoặc tên loại nhân viên trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public bool Update(string oldMaLoai,string maloai, string tenloai)
        {
            if (tenloai==""||oldMaLoai!=maloai)
            {
                MessageBox.Show("Mã loại nhân viên không thể sửa hoặc tên loại nhân viên trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                
            return loainv.UpdateLoaiNV(maloai, tenloai);
        }
        public bool DeleteLoaiNV(string maloai)
        {
            return loainv.DelLoaiNV(maloai);
        }
    }
}
