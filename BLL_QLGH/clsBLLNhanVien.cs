using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLGH;

namespace BLL_QLGH
{
    public class clsBLLNhanVien
    {
        clsDALNhanVien dalnhanvien = new clsDALNhanVien();
        public DataTable LayDSNhanVien()
        {
            return dalnhanvien.LayDSNhanVien();
        }
        public DataTable LayMaLoaiNv()
        {
            return dalnhanvien.LayMaLoaiNV();
        }
        public void XoaNhanVien(string manv)
        {
            dalnhanvien.XoaNhanVien(manv);
        }
        public void SuaNhanVien(string manv, string maloainv, string tennv, string sdt, string email, byte[] anh, string thongtinkhac)
        {
            dalnhanvien.SuaNhanVien(manv, maloainv, tennv, sdt, email, anh, thongtinkhac);
        }
        public void ThemNhanVien(string manv, string maloainv, string tennv, string sdt, string email, byte[] anh, string thongtinkhac)
        {
            dalnhanvien.ThemNhanVien(manv, maloainv, tennv, sdt, email, anh, thongtinkhac);
        }
        public DataTable LayLoaiNV()
        {
            return dalnhanvien.LayLoaiNV();
        }
        public void XoaLoaiNV(string maloainv)
        {
            dalnhanvien.XoaLoaiNV(maloainv);
        }
        public void SuaLoaiNV(string maloainv, string tenloainv, string mota)
        {
            dalnhanvien.SuaLoaiNV(maloainv, tenloainv, mota);
        }
        public void ThemLoaiNV(string maloainv, string tenloainv, string mota)
        {
            dalnhanvien.ThemLoaiNV(maloainv, tenloainv, mota);
        }
        public DataTable TKSLDonHangLap()
        {
            return dalnhanvien.TKSLDonHangLap();
        }
        public DataTable TKSLDonHangGiao()
        {
            return dalnhanvien.TKSLDonHangGiao();
        }
    }
}
