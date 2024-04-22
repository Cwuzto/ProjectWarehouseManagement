using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;

namespace WarehouseManagement.Bussiness
{
    public class HangHoaBUS
    {
        HangHoaDL hang = new HangHoaDL();
        public DataTable danhsachhh()
        {
            return hang.dshh();
        }
        public bool adhang(string MaHH, string TenHH, string MoTa, string SoLuong, DateTime NgayCapNhat, string MaLoai)
        {
            {
                if (!hang.ktrtontai(MaHH))
                {
                    if (hang.themhang(MaHH, TenHH, MoTa, SoLuong, NgayCapNhat, MaLoai))
                        return true;
                }
                return false;
            }
        }
        public bool deletehang(string mahh)
        {
            return hang.xoahanghoa(mahh);
        }


    }
}
