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

namespace GUI_QLGH.KhachHang
{
    public partial class frmBieuDo1 : DevExpress.XtraEditors.XtraForm
    {
        clsBLLKhachHang bllkhachhang = new clsBLLKhachHang();
        public frmBieuDo1()
        {
            InitializeComponent();
        }

        private void frmBieuDo1_Load(object sender, EventArgs e)
        {
            DataTable dt = bllkhachhang.ThongKeSLDH();
            //DataTable dt1 = new DataTable();
            //for(int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if((int)dt.Rows[i]["tongsodh"] > 2)
            //    {
            //        dt1.Rows.Add(dt.Rows[i]);
            //    }    
            //}
            ChartControl barchart = new ChartControl();
            Series series = new Series("Số lượng đơn hàng", ViewType.Bar);
            //chartCTThongKe.Series.Add("Đơn hàng", ViewType.Pie);
            foreach (DataRow dr in dt.Rows)
                series.Points.Add(new SeriesPoint(dr["makh"], dr["tongsodh"]));
            barchart.Series.Add(series);
            series.Label.TextPattern = "{A}: {VP:p2}";
            BarSeriesLabel barSeries = series.Label as BarSeriesLabel;
            barSeries.Position = BarSeriesLabelPosition.Top;
            barSeries.ResolveOverlappingMode = ResolveOverlappingMode.Default;
            BarSeriesView pv = series.View as BarSeriesView;
            BarSeriesView myView = pv;
            //myView.Titles.Add(new SeriesTitle());
            //myView.ExplodeMode = PieExplodeMode.UseFilters;
            //myView.ExplodedDistancePercentage = 30;
            //myView.RuntimeExploding = true;
            //myView.HeightToWidthRatio = 0.75;
            barchart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            barchart.Legend.AlignmentVertical = LegendAlignmentVertical.Center;
            barchart.Dock = DockStyle.Fill;
            grbBieudo.Controls.Add(barchart);
        }
    }
}