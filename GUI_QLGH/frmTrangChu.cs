using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLGH
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmTrangChu()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Start();

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            btnTime.Caption = DateTime.Now.ToString();
        }

        //private void btnExit_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        //{
        //    if (MessageBox.Show("Đóng ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        //        return;
        //    this.Close();
        //}
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            DSDonHang t = new DSDonHang();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnTinhTrangDH_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            DonHang.UCTinhTrangDH t = new DonHang.UCTinhTrangDH(); 
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            KhachHang.UCDSKhachHang t = new KhachHang.UCDSKhachHang();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnXepDH_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            DonHang.UCChonNVGiaoHang t = new DonHang.UCChonNVGiaoHang();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnDHDaGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            DonHang.UCThongKeDH t = new DonHang.UCThongKeDH();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnNguoiNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            KhachHang.UCDSNguoiNhan t = new KhachHang.UCDSNguoiNhan();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnDSNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            NhanVien.UCDSNhanVien t = new NhanVien.UCDSNhanVien();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnTKKHTiemNang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            KhachHang.UCThongKeSL t = new KhachHang.UCThongKeSL();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnLoaiNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            NhanVien.UCLoaiNhanVien t = new NhanVien.UCLoaiNhanVien();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnTKDHLap_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            NhanVien.UCThongKeDHLap t = new NhanVien.UCThongKeDHLap();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnTKDHGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            NhanVien.UCThongKeDHGiao t = new NhanVien.UCThongKeDHGiao();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }

        private void btnVoucher_ItemClick(object sender, ItemClickEventArgs e)
        {
            pncNoiDung.Controls.Clear();
            pncNoiDung.Dock = DockStyle.Fill;

            Khac.frmVoucher t = new Khac.frmVoucher();
            t.Dock = DockStyle.Fill;
            pncNoiDung.Controls.Add(t);
        }
    }
}