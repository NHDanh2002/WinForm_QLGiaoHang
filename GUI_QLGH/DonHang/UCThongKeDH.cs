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
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;

namespace GUI_QLGH.DonHang
{
    public partial class UCThongKeDH : DevExpress.XtraEditors.XtraUserControl
    {
        clsBLLDonHang bLLdonghang = new clsBLLDonHang();
        private void LoadData()
        {
            DataSet ds = blldonhang.LayDSCacDH();
            DataTable dt1 = ds.Tables[0];
            DataTable dt2 = ds.Tables[1];
            DataTable dt3 = ds.Tables[2];
            gridControlDSDHDaGiao.DataSource = dt1;
            gridControlDSDHDangGiao.DataSource = dt2;
            gridControlDSDHChuaGiao.DataSource = dt3;
            txtCuocPhiCG.DataBindings.Add("Text", dt3, "cuocphi");
            txtMoTaCG.DataBindings.Add("Text", dt3, "mota");
            txtTenKHCG.DataBindings.Add("Text", dt3, "tenkh");
            txtTenNNCG.DataBindings.Add("Text", dt3, "tennn");
            txtTHGCG.DataBindings.Add("Text", dt3, "thoihangiao");
            txtTinhTrangCG.DataBindings.Add("Text", dt3, "tinhtrang");
            txtMaDHCG.DataBindings.Add("Text", dt3, "madh");
            txtCuocPhiDaG.DataBindings.Add("Text", dt1, "cuocphi");
            txtMoTaDaG.DataBindings.Add("Text", dt1, "mota");
            txtTenKHDaG.DataBindings.Add("Text", dt1, "tenkh");
            txtTenNNDaG.DataBindings.Add("Text", dt1, "tennn");
            txtTHGDaG.DataBindings.Add("Text", dt1, "thoihangiao");
            txtTinhTrangDaG.DataBindings.Add("Text", dt1, "tinhtrang");
            txtMaDHDaG.DataBindings.Add("Text", dt1, "madh");
            txtCuocPhiDgG.DataBindings.Add("Text", dt2, "cuocphi");
            txtMoTaDgG.DataBindings.Add("Text", dt2, "mota");
            txtTenKHDgG.DataBindings.Add("Text", dt2, "tenkh");
            txtTenNNDgG.DataBindings.Add("Text", dt2, "tennn");
            txtTHGDgG.DataBindings.Add("Text", dt2, "thoihangiao");
            txtTinhTrangDgG.DataBindings.Add("Text", dt2, "tinhtrang");
            txtMaDHDgG.DataBindings.Add("Text", dt2, "madh");
        }
        clsBLLDonHang blldonhang = new clsBLLDonHang();
        public UCThongKeDH()
        {
            InitializeComponent();
            LoadData();
        }

        private void tabThongKe_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = blldonhang.LaySoLuongDH();
            gridCTThongKeSL.DataSource = dt;
            ChartControl piechart = new ChartControl();
            Series series = new Series("Đơn hàng", ViewType.Pie);
            //chartCTThongKe.Series.Add("Đơn hàng", ViewType.Pie);
            foreach (DataRow dr in dt.Rows)
                series.Points.Add(new SeriesPoint(dr["tinhtrang"], dr["SoLuong"]));
            piechart.Series.Add(series);
            series.Label.TextPattern = "{A}: {VP:p2}";
            PieSeriesLabel pieSeries = series.Label as PieSeriesLabel;
            pieSeries.Position = PieSeriesLabelPosition.TwoColumns;
            pieSeries.ResolveOverlappingMode = ResolveOverlappingMode.Default;
            PieSeriesView pv = series.View as PieSeriesView;
            PieSeriesView myView = pv;
            myView.Titles.Add(new SeriesTitle());
            myView.ExplodeMode = PieExplodeMode.UseFilters;
            myView.ExplodedDistancePercentage = 30;
            myView.RuntimeExploding = true;
            myView.HeightToWidthRatio = 0.75;
            piechart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            piechart.Legend.AlignmentVertical = LegendAlignmentVertical.Center;
            piechart.Dock = DockStyle.Fill;
            grBieuDo.Controls.Add(piechart);
        }
        private void btnExportDaG_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (.xlsx)|.xlsx|Excel 2003 (.xls)|.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gridControlDSDHDaGiao.ExportToXlsx(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnExportDgG_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (.xlsx)|.xlsx|Excel 2003 (.xls)|.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gridControlDSDHDangGiao.ExportToXlsx(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnExportCG_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (.xlsx)|.xlsx|Excel 2003 (.xls)|.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gridControlDSDHChuaGiao.ExportToXlsx(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnReportDaG_Click(object sender, EventArgs e)
        {
            grdDSDHDaGiao.BestFitColumns();
            Report.rpDSDHDaG report = new Report.rpDSDHDaG();
            report.GridControl = gridControlDSDHDaGiao;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnReportDgG_Click(object sender, EventArgs e)
        {
            grdDSDHDangGiao.BestFitColumns();
            Report.rpDSDHDgG report = new Report.rpDSDHDgG();
            report.GridControl = gridControlDSDHDangGiao;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnReportCG_Click(object sender, EventArgs e)
        {
            grdDHChuaGiao.BestFitColumns();
            Report.rpDSDHCG report = new Report.rpDSDHCG();
            report.GridControl = gridControlDSDHChuaGiao;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
