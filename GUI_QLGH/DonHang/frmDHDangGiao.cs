using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QLGH;

namespace GUI_QLGH.DonHang
{
    public partial class frmDHDangGiao : DevExpress.XtraEditors.XtraForm
    {
        clsBLLDonHang blldonhang = new clsBLLDonHang();
        public frmDHDangGiao()
        {
            InitializeComponent();
            DataTable dt = blldonhang.LayDSDHDG();
            grdCTDSDH.DataSource = dt;
        }
    }
}