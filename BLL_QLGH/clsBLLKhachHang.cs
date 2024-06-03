using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLGH;

namespace BLL_QLGH
{
  
    public class clsBLLKhachHang
    {
        clsDALKhachHang dalkhachhang = new clsDALKhachHang();
        public DataTable LayDSKhachHang()
        {
            return dalkhachhang.LayDSKhachHang();
        }
        public void ThemKhachHang(string makh, string tenkh, string sdt, string email, string thongtinkhac)
        {
            dalkhachhang.ThemKhachHang(makh, tenkh, sdt, email, thongtinkhac);
        }
        public void XoaKhachHang(string makh)
        {
            dalkhachhang.XoaKhachHang(makh);
        }
        public void SuaKhachHang(string makh, string tenkh, string sdt, string email, string thongtinkhac)
        {
            dalkhachhang.SuaKhachHang(makh, tenkh, sdt, email, thongtinkhac);
        }
        public DataTable LayDSNguoiNhan()
        {
            return dalkhachhang.LayDSNguoiNhan();
        }
        public void XoaNguoiNhan(string mann)
        {
            dalkhachhang.XoaNguoiNhan(mann);
        }
        public void SuaNguoiNhan(string mann, string makh, string tennn, string sdt, string email, string cmnd, string diachi, string thongtinkhac)
        {
            dalkhachhang.SuaNguoiNhan(mann, makh, tennn, sdt, email, cmnd, diachi, thongtinkhac);
        }
        public void ThemNguoiNhan(string mann, string makh, string tennn, string sdt, string email, string cmnd, string diachi, string thongtinkhac)
        {
            dalkhachhang.ThemNguoiNhan(mann, makh, tennn, sdt, email, cmnd, diachi, thongtinkhac);
        }
        public DataTable ThongKeSLDH()
        {
            return dalkhachhang.ThongKeSLDH();
        }
    }
}
