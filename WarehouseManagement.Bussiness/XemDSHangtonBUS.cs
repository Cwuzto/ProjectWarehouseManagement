using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class XemDSHangtonBUS
    {
        XemDSHangton dsht = new XemDSHangton();
        public DataTable Laydsht()
        {
            return dsht.GetAlldshangton();
        }
        public DataTable timhang(string data)
        {
            return dsht.timhanghoa(data);
        }
        public bool CapNhapSLHH(List<Tuple<string, int>> data, DateTime ngaycapnhat)
        {
            try
            {
                dsht.CapNhapSL(data, ngaycapnhat);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi " + e, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
