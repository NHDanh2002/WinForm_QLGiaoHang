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
using System.IO;
using DevExpress.XtraReports.UI;

namespace GUI_QLGH.NhanVien
{
    public partial class UCThongKeDHGiao : DevExpress.XtraEditors.XtraUserControl
    {
        clsBLLNhanVien bllnhanvien = new clsBLLNhanVien();
        public void bindings()
        {
            DataTable dt = bllnhanvien.TKSLDonHangGiao();
            grdControlSLDHGiao.DataSource = dt;
            txtMaNV.DataBindings.Add("Text", dt, "manv");
            txtMaLNV.DataBindings.Add("Text", dt, "maloainv");
            txtTenNV.DataBindings.Add("Text", dt, "tennv");
            txtLoaiNV.DataBindings.Add("Text", dt, "tenloainv");
            txtSDT.DataBindings.Add("Text", dt, "sdt");
            txtEmail.DataBindings.Add("Text", dt, "email");
            txtSLDLap.DataBindings.Add("Text", dt, "sldh");
        }
        public UCThongKeDHGiao()
        {
            InitializeComponent();
            bindings();
        }
        public void ChuyenAnh(List<byte[]> chuoi, List<Image> img)
        {
            DataTable dt = new DataTable();
            dt = bllnhanvien.TKSLDonHangGiao();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chuoi.Add((byte[])dt.Rows[i]["anh"]);
            }
            for (int i = 0; i < chuoi.Count; i++)
            {
                MemoryStream ms = new MemoryStream(chuoi[i]);
                Image anh = Image.FromStream(ms);
                img.Add(anh);
            }
        }

        private void txtMaNV_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<byte[]> chuoi = new List<byte[]>();
            List<Image> img = new List<Image>();
            ChuyenAnh(chuoi, img);
            dt = bllnhanvien.TKSLDonHangGiao();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (txtMaNV.Text == dt.Rows[i]["manv"].ToString())
                {
                    picAva.Image = img[i];
                }
            }
        }

        private void btnBieuDo1_Click(object sender, EventArgs e)
        {
            frmBieuDoDHGiao frmbieudo = new frmBieuDoDHGiao();
            frmbieudo.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            grdSLDHGiao.BestFitColumns();
            Report.rpTKSLDonHangLap report = new Report.rpTKSLDonHangLap();
            report.GridControl = grdControlSLDHGiao;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
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
                    grdControlSLDHGiao.ExportToXlsx(saveFileDialog.FileName);
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
