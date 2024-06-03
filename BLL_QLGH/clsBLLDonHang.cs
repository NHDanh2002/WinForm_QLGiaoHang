using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLGH;

namespace BLL_QLGH
{
    public class clsBLLDonHang
    {
        clsDALDonHang daldonhang = new clsDALDonHang();
        public DataTable LayDSDonHang()
        {
            return daldonhang.LayDSDonHang();
        }
        public void ThemDonHang(string madh, string makh, string mann, string manv, string cuocphi, string khoiluong, string thoihangiao, string ghichu)
        {
            daldonhang.ThemDonHang(madh, makh, mann, manv, cuocphi, khoiluong, thoihangiao, ghichu);
        }
        public void XoaDonHang(string madh)
        {
            daldonhang.XoaDonHang(madh);
        }
        public void SuaDonHang(string madh, string makh, string mann, string manv, string cuocphi, string khoiluong, string thoihangiao, string ghichu)
        {
            daldonhang.SuaDonHang(madh, makh, mann, manv, cuocphi, khoiluong, thoihangiao, ghichu);
        }
        public DataTable LayDSTinhTrangDH()
        {
            return daldonhang.LayDSTinhTrangDH();
        }
        public void SuaTinhTrangDH(string madh, string tinhtrang, string mota)
        {
            daldonhang.SuaTinhTrangDH(madh, tinhtrang, mota);
        }
        public DataTable LayDSDHChuaGiao()
        {
            return daldonhang.LayDSDHChuaGiao();
        }
        public DataTable LayNVGiaoHang()
        {
            return daldonhang.LayNVgiaoHang();
        }
        public void ThemNguoiGiao(string madh, string manv, string tinhtrang, string ghichu)
        {
            daldonhang.ThemNguoiGiao(madh, manv, tinhtrang, ghichu);
        }
        public DataTable LayDiaChi(string makh)
        {
            return daldonhang.LayDiaChi(makh);
        }
        public void CapNhatCuocPhi(string madh, string cuocphi)
        {
            daldonhang.CapNhatCuocPhi(madh, cuocphi);
        }
        public DataTable LaySoLuongDH()
        {
            return daldonhang.LaySoLuongDH();
        }
        public DataSet LayDSCacDH()
        {
            return daldonhang.LayDSCacDH();
        }

        public DataTable LayDSDHDG()
        {
            return daldonhang.LayDSDHDG();
        }
    }
}
