using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.DataAccess;
using WarehouseManagement.DataAccess.Data;

namespace WarehouseManagement.Bussiness
{
    public class LoginBUS
    {
        private LoginDL loginDL;
        public LoginBUS()
        {
            loginDL = LoginDL.Instance;
        }
        public bool Login(string userName, string passWord)
        {
            return LoginDL.Instance.Login(userName, passWord);
        }
        public string GetMaLoai(string userName)
        {
            return loginDL.GetMaLoai(userName);
        }
        public string GetMaNV(string userName, string pass)
        {
            return loginDL.GetMaNV(userName, pass);
        }
    }
}
