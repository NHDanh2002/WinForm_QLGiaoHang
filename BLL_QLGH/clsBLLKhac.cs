using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLGH;

namespace BLL_QLGH
{
    public class clsBLLKhac
    {
        clsDALKhac dalkhac = new clsDALKhac();
        public DataTable LayDSVoucher()
        {
            return dalkhac.LayDSVoucher();
        }    
        public void XoaVoucher(string mavoucher)
        {
            dalkhac.XoaVoucher(mavoucher);
        }
        public void SuaVoucher(string mavc, string tenvc, string manl, DateTime ngaytao, string thoihang)
        {
            dalkhac.SuaVoucher(mavc, tenvc, manl, ngaytao, thoihang);
        }
        public void ThemVoucher(string mavc, string tenvc, string manl, DateTime ngaytao, string thoihang)
        {
            dalkhac.ThemVoucher(mavc, tenvc, manl, ngaytao, thoihang);
        }
    }
}
