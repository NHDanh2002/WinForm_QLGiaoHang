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
    public partial class UCThongKeSL : DevExpress.XtraEditors.XtraUserControl
    {
        clsBLLKhachHang bllkhachhang = new clsBLLKhachHang();
        void bindings()
        {
            DataTable dt = new DataTable();
            dt = bllkhachhang.ThongKeSLDH();
            grdControlTKSLDH.DataSource = dt;
            txtMaKH.DataBindings.Add("Text", dt, "makh");
            txtTenKH.DataBindings.Add("Text", dt, "tenkh");
            txtSDT.DataBindings.Add("Text", dt, "sdt");
            txtEmail.DataBindings.Add("Text", dt, "email");
            txtThongTinKhac.DataBindings.Add("Text", dt, "thongtinkhac");
            txtTongDH.DataBindings.Add("Text", dt, "tongsodh");
            DataTable dt1 = dt.Clone();
            DataRow[] orderRows = dt.Select("tongsodh > 1");
            foreach(DataRow dr in orderRows)
            {
                dt1.ImportRow(dr);
            }
            grdControlKHTN.DataSource = dt1;
            txtMaKH1.DataBindings.Add("Text", dt1, "makh");
            txtTenKH1.DataBindings.Add("Text", dt1, "tenkh");
            txtSDT1.DataBindings.Add("Text", dt1, "sdt");
            txtEmail1.DataBindings.Add("Text", dt1, "email");
            txtThongTinKhac1.DataBindings.Add("Text", dt1, "thongtinkhac");
            txtTongDH1.DataBindings.Add("Text", dt1, "tongsodh");
        }
        public UCThongKeSL()
        {
            InitializeComponent();
            bindings();
        }

        private void btnExport1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (.xlsx)|.xlsx|Excel 2003 (.xls)|.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    grdControlTKSLDH.ExportToXlsx(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            grdTKSLDH.BestFitColumns();
            Report.rpDSSLDH_KH report = new Report.rpDSSLDH_KH();
            report.GridControl = grdControlTKSLDH;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnBieuDo1_Click(object sender, EventArgs e)
        {
            frmBieuDo1 bd1 = new frmBieuDo1();
            bd1.ShowDialog();
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            grdKHTN.BestFitColumns();
            Report.rpKHTN report = new Report.rpKHTN();
            report.GridControl = grdControlKHTN;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnExport2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (.xlsx)|.xlsx|Excel 2003 (.xls)|.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    grdControlKHTN.ExportToXlsx(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }
    }
}
