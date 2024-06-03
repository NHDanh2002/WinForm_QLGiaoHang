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

namespace GUI_QLGH.NhanVien
{
    public partial class frmBieuDoDHLap : DevExpress.XtraEditors.XtraForm
    {
        clsBLLNhanVien bllnhanvien = new clsBLLNhanVien();
        public frmBieuDoDHLap()
        {
            InitializeComponent();
        }

        private void frmBieuDoDHLap_Load(object sender, EventArgs e)
        {
            DataTable dt = bllnhanvien.TKSLDonHangLap();
            ChartControl barchart = new ChartControl();
            Series series = new Series("Số lượng đơn hàng", ViewType.Bar);
            foreach (DataRow dr in dt.Rows)
                series.Points.Add(new SeriesPoint(dr["tennv"], dr["sldh"]));
            barchart.Series.Add(series);
            series.Label.TextPattern = "{A}: {VP:p2}";
            BarSeriesLabel barSeries = series.Label as BarSeriesLabel;
            barSeries.Position = BarSeriesLabelPosition.Top;
            barSeries.ResolveOverlappingMode = ResolveOverlappingMode.Default;
            BarSeriesView pv = series.View as BarSeriesView;
            BarSeriesView myView = pv;
            barchart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            barchart.Legend.AlignmentVertical = LegendAlignmentVertical.Center;
            barchart.Dock = DockStyle.Fill;
            grbBieudo.Controls.Add(barchart);
        }
    }
}