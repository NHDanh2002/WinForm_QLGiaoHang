using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGH
{
    public class clsDTOKhachHang
    {
        private string makh;
        private string tenkh;
        private string sdt;
        private string email;
        private int diemtichluy;
        private string thongtinkhac;

        public clsDTOKhachHang(string makh, string tenkh, string sdt, string email, int diemtichluy, string thongtinkhac)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.sdt = sdt;
            this.email = email;
            this.diemtichluy = diemtichluy;
            this.thongtinkhac = thongtinkhac;
        }

        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public int Diemtichluy { get => diemtichluy; set => diemtichluy = value; }
        public string Thongtinkhac { get => thongtinkhac; set => thongtinkhac = value; }
    }
}
