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
using DevExpress.XtraReports.UI;

namespace GUI_QLGH.KhachHang
{
    public partial class UCDSKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public void LoadGrid()
        {
            DataTable dt = bllkhachhang.LayDSKhachHang();
            grdControlDSKH.DataSource = dt;
        }
        public void bindings()
        {
            DataTable dt = bllkhachhang.LayDSKhachHang();
            grdControlDSKH.DataSource = dt;
            txtMaKH.DataBindings.Add("Text", dt, "makh");
            txtTenKH.DataBindings.Add("Text", dt, "tenkh");
            txtEmail.DataBindings.Add("Text", dt, "email");
            txtSDT.DataBindings.Add("Text", dt, "sdt");
            txtThongTinKhac.DataBindings.Add("Text", dt, "thongtinkhac");
        }
        public void ClearBindings()
        {
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtThongTinKhac.DataBindings.Clear();
        }
        clsBLLKhachHang bllkhachhang = new clsBLLKhachHang();
        public UCDSKhachHang()
        {
            InitializeComponent();
            bindings();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (.xlsx)|.xlsx|Excel 2003 (.xls)|.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    grdControlDSKH.ExportToXlsx(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            grdDSKH.BestFitColumns();
            Report.rpDSKH report = new Report.rpDSKH();
            report.GridControl = grdControlDSKH;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang.frmThemKhachHang themKhachHang = new frmThemKhachHang();
            themKhachHang.ShowDialog();
            LoadGrid();
            ClearBindings();
            bindings();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllkhachhang.SuaKhachHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtEmail.Text, txtThongTinKhac.Text);
                MessageBox.Show("Sửa khách hàng thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                ClearBindings();
                bindings();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bllkhachhang.XoaKhachHang(txtMaKH.Text);
                MessageBox.Show("Đã xóa khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                ClearBindings();
                bindings();
            }
        }
    }
}
