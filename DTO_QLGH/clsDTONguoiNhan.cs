using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGH
{
    class clsDTONguoiNhan
    {
        private string mann;
        private string makh;
        private string tennn;
        private string sdt;
        private string cmnd;
        private string diachi;
        private string thongtinkhac;

        public clsDTONguoiNhan(string mann, string makh, string tennn, string sdt, string cmnd, string diachi, string thongtinkhac)
        {
            this.mann = mann;
            this.makh = makh;
            this.tennn = tennn;
            this.sdt = sdt;
            this.cmnd = cmnd;
            this.diachi = diachi;
            this.thongtinkhac = thongtinkhac;
        }

        public string Mann { get => mann; set => mann = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Tennn { get => tennn; set => tennn = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Thongtinkhac { get => thongtinkhac; set => thongtinkhac = value; }
    }
}
