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
    public partial class UCChonNVGiaoHang : DevExpress.XtraEditors.XtraUserControl
    {
        clsBLLDonHang blldonhang = new clsBLLDonHang();
        public void LoadGrid()
        {
            DataTable dt = blldonhang.LayDSDHChuaGiao();
            grdCTDSDHChuaGiao.DataSource = dt;
        }
        public void bindings()
        {
            DataTable dt = blldonhang.LayDSDHChuaGiao();
            grdCTDSDHChuaGiao.DataSource = dt;
            txtMaDH.DataBindings.Add("Text", dt, "madh");
            txtTenKH.DataBindings.Add("Text", dt, "tenkh");
            txtTenNN.DataBindings.Add("Text", dt, "tennn");
            txtCuocPhi.DataBindings.Add("Text", dt, "cuocphi");
            txtTHG.DataBindings.Add("Text", dt, "thoihangiao");
            txtMoTa.DataBindings.Add("Text", dt, "mota");
            txtTinhTrang.DataBindings.Add("Text", dt, "tinhtrang");
        }
        public void ClearBindings()
        {
            txtMaDH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtTenNN.DataBindings.Clear();
            txtCuocPhi.DataBindings.Clear();
            txtTHG.DataBindings.Clear();
            txtMoTa.DataBindings.Clear();
            txtTinhTrang.DataBindings.Clear();
        }
        public UCChonNVGiaoHang()
        {
            InitializeComponent();
            bindings();
            DataTable d1 = new DataTable();
            d1 = blldonhang.LayNVGiaoHang();
            for (int i = 0; i < d1.Rows.Count; i++)
            {
                cboNhanVienGiao.Properties.Items.Add(d1.Rows[i]["manv"]);
            }
        }

        private void btnChonNguoiGiao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắn chắn chọn nhân viên này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                blldonhang.ThemNguoiGiao(txtMaDH.Text, cboNhanVienGiao.Text, "Đang giao", txtMoTa.Text);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            return;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmDHDangGiao frmdhdg = new frmDHDangGiao();
            frmdhdg.ShowDialog();
        }
    }
}
