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
    public partial class UCDSNguoiNhan : DevExpress.XtraEditors.XtraUserControl
    {
        clsBLLKhachHang bllkhachhang = new clsBLLKhachHang();
        void LoadData()
        {
            DataTable dt = new DataTable();
            dt = bllkhachhang.LayDSNguoiNhan();
            grdControlDSNN.DataSource = dt;
        }
        void bindings()
        {
            DataTable dt = new DataTable();
            dt = bllkhachhang.LayDSNguoiNhan();
            grdControlDSNN.DataSource = dt;
            txtMaNN.DataBindings.Add("Text", dt, "mann");
            txtMaKH.DataBindings.Add("Text", dt, "makh");
            txtTenNN.DataBindings.Add("Text", dt, "tennn");
            txtSDT.DataBindings.Add("Text", dt, "sdt");
            txtEmail.DataBindings.Add("Text", dt, "email");
            txtCMND.DataBindings.Add("Text", dt, "cmnd");
            txtDiaChi.DataBindings.Add("Text", dt, "diachi");
            txtTTK.DataBindings.Add("Text", dt, "thongtinkhac");
        }
        void ClearBindings()
        {
            txtMaNN.DataBindings.Clear();
            txtMaKH.DataBindings.Clear();
            txtTenNN.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtTTK.DataBindings.Clear();
        }
        public UCDSNguoiNhan()
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
                    grdControlDSNN.ExportToXlsx(saveFileDialog.FileName);
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
            grdDSNN.BestFitColumns();
            Report.rpDSKH report = new Report.rpDSKH();
            report.GridControl = grdControlDSNN;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang.frmThemNguoiNhan themKhachHang = new frmThemNguoiNhan();
            themKhachHang.ShowDialog();
            LoadData();
            ClearBindings();
            bindings();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa người nhận này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllkhachhang.SuaNguoiNhan(txtMaNN.Text, txtMaKH.Text, txtTenNN.Text, txtSDT.Text, txtEmail.Text,txtCMND.Text, txtDiaChi.Text, txtTTK.Text);
                MessageBox.Show("Sửa người nhận thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearBindings();
                bindings();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa người nhận này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bllkhachhang.XoaNguoiNhan(txtMaNN.Text);
                MessageBox.Show("Đã xóa người nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearBindings();
                bindings();
            }
        }
    }
}
