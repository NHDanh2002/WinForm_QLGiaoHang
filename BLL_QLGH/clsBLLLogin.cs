using DAL_QLGH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QLGH
{
    public class clsBLLLogin
    {
        clsDALLogin dal = new clsDALLogin();
        public DataTable Login()
        {
            return dal.Login();
        }
    }
}
