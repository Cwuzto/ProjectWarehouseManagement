using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class QLHangBUS
    {
        QLHangDL qlh = new QLHangDL();

        public DataTable laydshh()
        {
            return qlh.laydshh();
        }


        public bool qlhang(string mahh, string tenhh, string mota, string soluong, DateTime ngayyc, string maloai)
        {
            if (!qlh.quanlyhanghoa(mahh))
            {
                if (qlh.qlhh(mahh, tenhh, mota, soluong, ngayyc, maloai))
                    return true;
            }
            return false;
        }
        public bool Deletehh(string mahh)
        {
            return qlh.Deletehang(mahh);
        }
        
      public bool CtTenHangHoa(string maHH, string tenHH)
        {
          return qlh.CapNhatTenHangHoa(maHH, tenHH);
        }
            public bool CtMoTa(string maHH, string mota)
            {
                return qlh.CapNhatMoTa(maHH, mota);
            }

            public bool CtSoLuong(string maHH, string soluongmoi)
            {
                return qlh.CapNhatSoLuong(maHH, soluongmoi);
            }
        }
    }


