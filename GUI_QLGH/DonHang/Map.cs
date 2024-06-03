using DevExpress.XtraEditors;
using DevExpress.XtraMap;
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
using GUI_QLGH.Properties;

namespace GUI_QLGH.DonHang
{
    public partial class frmViTriDH : DevExpress.XtraEditors.XtraForm
    {
        clsBLLDonHang blldonhang = new clsBLLDonHang();
        private string madh;
        private string diachi;
        public frmViTriDH()
        {
            InitializeComponent();
        }
        public frmViTriDH(string madh, string diachi)
        {
            InitializeComponent();
            this.madh = madh;
            this.diachi = diachi;
        }
        private void frmViTriDH_Load(object sender, EventArgs e)
        {
            txtDiaChi.Text = diachi;
            txtMaDH.Text = madh;
            BingRouteDataProvider routeDataProvider = new BingRouteDataProvider
            {
                BingKey = "AuKJKDL5eEjK5udzBUDBNdPjRYqjjYchifKs2XPtJNA6I9BYrTMJW2gDSzYyVAwY"
            };
            mapVitriDH.Layers.Add(new InformationLayer
            {
                DataProvider = routeDataProvider
            });
            List<RouteWaypoint> waypoints = new List<RouteWaypoint> {
                new RouteWaypoint("Kho","Trần Văn Ơn, Phú Hòa, Thủ Dầu Một, Bình Dương"),
                new RouteWaypoint("Đơn Hàng", txtDiaChi.Text)
            };
            Task<double> calcResults = CalculateDistanceToAsync(waypoints[0].Keyword, waypoints[1].Keyword, waypoints[0].Description, waypoints[1].Description);
            DSDonHang ds = new DSDonHang();
            //double distance = GeoUtils.CalculateDistance(new GeoPoint(36.112, -115.1), new GeoPoint(36.111, -115.2));
            //txtKhoangCach.Text = distance.ToString();
            routeDataProvider.CalculateRoute(waypoints);
            routeDataProvider.LayerItemsGenerating += RouteDataProvider_LayerItemsGenerating;
        }
        async Task<double> CalculateDistanceToAsync(string from, string to, string waypointDescriptionFrom, string waypointDescriptionTo)
        {
            var tcs = new TaskCompletionSource<double>();

            BingRouteDataProvider routeDataProvider = new BingRouteDataProvider { BingKey = "AuKJKDL5eEjK5udzBUDBNdPjRYqjjYchifKs2XPtJNA6I9BYrTMJW2gDSzYyVAwY" };

            routeDataProvider.RouteCalculated += (o, e) =>
            {
                RouteCalculationResult result = e.CalculationResult;
                if (result.RouteResults == null || result.ResultCode == RequestResultCode.BadRequest)
                    return;

                tcs.SetResult(result.RouteResults[0].Distance);
                txtKhoangCach.Text = result.RouteResults[0].Distance.ToString();
            };

            List<RouteWaypoint> waypoints = new List<RouteWaypoint>();

            waypoints.Add(new RouteWaypoint(waypointDescriptionFrom, from));
            waypoints.Add(new RouteWaypoint(waypointDescriptionTo, to));
            routeDataProvider.CalculateRoute(waypoints);

            await tcs.Task;
            return tcs.Task.Result;
        }
        private void RouteDataProvider_LayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e)
        {
            //string letter = "Kho";   
            foreach (MapItem item in e.Items)
            {
                //MapPushpin pushpin = item as MapPushpin;
                //if (pushpin != null)
                //    pushpin.Text = letter;
                MapPolyline line = item as MapPolyline;
                if (line != null)
                {
                    line.Fill = Color.Red;
                    line.Stroke = Color.Red;
                    line.StrokeWidth = 5;
                }
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn cập nhật cước phí?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                blldonhang.CapNhatCuocPhi(txtMaDH.Text, txtCuocPhi.Text);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
        double cuocphi = 0;
        double khoangcach = 0;
        private void txtKhoangCach_TextChanged(object sender, EventArgs e)
        {
            if (txtKhoangCach.Text != string.Empty)
            {
                khoangcach = double.Parse(txtKhoangCach.Text);
                cuocphi = 14000 + (khoangcach * 1000);
                txtCuocPhi.Text = cuocphi.ToString();
            }
            else txtCuocPhi.Text = "?";
        }
    }
}