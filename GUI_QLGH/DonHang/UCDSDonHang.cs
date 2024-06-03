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
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraReports.UI;

namespace GUI_QLGH
{
    public partial class DSDonHang : DevExpress.XtraEditors.XtraUserControl
    {
        clsBLLDonHang blldonhang = new clsBLLDonHang();

        public void LoadGrid()
        {
            DataTable dt = blldonhang.LayDSDonHang();
            gridControlDSDH.DataSource = dt;
        }
        public void bindings()
        {
            DataTable dt = blldonhang.LayDSDonHang();
            gridControlDSDH.DataSource = dt;
            txtMaDH.DataBindings.Add("Text", dt, "madh");
            txtMaKH.DataBindings.Add("Text", dt, "makh");
            txtMaNN.DataBindings.Add("Text", dt, "manguoinhan");
            txtMaNV.DataBindings.Add("Text", dt, "manv");
            txtCuocPhi.DataBindings.Add("Text", dt, "cuocphi");
            txtKhoiLuong.DataBindings.Add("Text", dt, "khoiluong");
            txtThoiHangGiao.DataBindings.Add("Text", dt, "thoihangiao");
            txtGhiChu.DataBindings.Add("Text", dt, "ghichu");
        }
        public void ClearBindings()
        {
            txtMaDH.DataBindings.Clear();
            txtMaKH.DataBindings.Clear();
            txtMaNN.DataBindings.Clear();
            txtMaNV.DataBindings.Clear();
            txtCuocPhi.DataBindings.Clear();
            txtKhoiLuong.DataBindings.Clear();
            txtThoiHangGiao.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
        }
        public DSDonHang()
        {
            InitializeComponent();
            bindings();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DonHang.frmThemDH frmthemdh = new DonHang.frmThemDH();
            frmthemdh.ShowDialog();
            LoadGrid();
            ClearBindings();
            bindings();
        }
        private void ExportExcel(String path)
        {
            gridControlDSDH.ExportToXlsx(path);
        }
        private void btnExport_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (.xlsx)|.xlsx|Excel 2003 (.xls)|.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                blldonhang.XoaDonHang(txtMaDH.Text);
                MessageBox.Show("Đã xóa đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                ClearBindings();
                bindings();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa đơn hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                blldonhang.SuaDonHang(txtMaDH.Text, txtMaKH.Text, txtMaNN.Text, txtMaNV.Text, txtCuocPhi.Text, txtKhoiLuong.Text, txtThoiHangGiao.Text, txtGhiChu.Text);
                MessageBox.Show("Sửa đơn hàng thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                ClearBindings();
                bindings();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            grdDSDH.BestFitColumns();
            Report.rpDSDH report = new Report.rpDSDH();
            report.GridControl = gridControlDSDH;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
