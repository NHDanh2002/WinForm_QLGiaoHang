using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGH
{
    public class clsDTOTinhTrangDH
    {
        private string madh;
        private string tinhtrang;
        private string mota;

        public clsDTOTinhTrangDH(string madh, string tinhtrang, string mota)
        {
            this.Madh = madh;
            this.Tinhtrang = tinhtrang;
            this.Mota = mota;
        }

        public string Madh { get => madh; set => madh = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Mota { get => mota; set => mota = value; }
    }
}
