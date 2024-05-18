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
    public class CTDonHangBUS
    {
        CTDonHangDL ctHD=new CTDonHangDL();
        public DataTable DSCTDHTheoMaDH(string madh)
        {
            return ctHD.DSCTDHTheoMaDonHang(madh);
        }
        public bool ThemCTHoaDon(List<Tuple<string, int, double>> data, string madh)
        {
            try
            {
                ctHD.ThemChiTietHD(data, madh);
                return true;
            }
            catch(Exception e) 
            {
                MessageBox.Show("Lỗi " + e, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
        }
    }
}
