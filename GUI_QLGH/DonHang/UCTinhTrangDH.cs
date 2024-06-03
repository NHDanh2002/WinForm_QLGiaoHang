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
using DTO_QLGH;
using DevExpress.XtraReports.UI;

namespace GUI_QLGH.DonHang
{
    public partial class UCTinhTrangDH : DevExpress.XtraEditors.XtraUserControl
    {
        clsBLLDonHang blldonhang = new clsBLLDonHang();
        public void LoadGrid()
        {
            DataTable dt = blldonhang.LayDSTinhTrangDH();
            grdControlTinhTrangDH.DataSource = dt;
        }
        public void bindings()
        {
            DataTable dt = blldonhang.LayDSTinhTrangDH();
            grdControlTinhTrangDH.DataSource = dt;
            txtMaDH.DataBindings.Add("Text", dt, "madh");
            txtTenKH.DataBindings.Add("Text", dt, "tenkh");
            txtTenNN.DataBindings.Add("Text", dt, "tennn");
            txtCuocPhi.DataBindings.Add("Text", dt, "cuocphi");
            txtTHG.DataBindings.Add("Text", dt, "thoihangiao");
            txtMoTa.DataBindings.Add("Text", dt, "mota");
            cboTinhTrang.DataBindings.Add("Text", dt, "tinhtrang");
            txtDiaChi.DataBindings.Add("Text", dt, "diachi");
        }
        public void ClearBindings()
        {
            txtMaDH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtTenNN.DataBindings.Clear();
            txtCuocPhi.DataBindings.Clear();
            txtTHG.DataBindings.Clear();
            txtMoTa.DataBindings.Clear();
            cboTinhTrang.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
        }
        public UCTinhTrangDH()
        {
            InitializeComponent();
            bindings();
            cboTinhTrang.Properties.Items.Add("Đã giao");
            cboTinhTrang.Properties.Items.Add("Đang giao");
            cboTinhTrang.Properties.Items.Add("Chưa giao");
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
                    grdControlTinhTrangDH.ExportToXlsx(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnCapNhatTT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật tình trạng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                blldonhang.SuaTinhTrangDH(txtMaDH.Text, cboTinhTrang.Text, txtMoTa.Text);
                MessageBox.Show("Cập nhật thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                ClearBindings();
                bindings();
            }
        }

        private void grdTinhTrangDH_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DataTable dt = new DataTable();
            List<clsDTOTinhTrangDH> listTT = new List<clsDTOTinhTrangDH>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listTT.Add(new clsDTOTinhTrangDH(dt.Rows[i]["madh"].ToString(), dt.Rows[i]["tinhtrang"].ToString(), dt.Rows[i]["mota"].ToString()));
            }
            if(grdTinhTrangDH.GetRowCellValue(e.RowHandle, "tinhtrang").ToString() == "Đã giao")
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
            if (grdTinhTrangDH.GetRowCellValue(e.RowHandle, "tinhtrang").ToString() == "Chưa giao")
            {
                e.Appearance.BackColor = Color.Tomato;
            }
            if (grdTinhTrangDH.GetRowCellValue(e.RowHandle, "tinhtrang").ToString() == "Đang giao")
            {
                e.Appearance.BackColor = Color.Khaki;
            }
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            frmViTriDH vitri = new frmViTriDH(txtMaDH.Text, txtDiaChi.Text);
            vitri.ShowDialog();
            LoadGrid();
            ClearBindings();
            bindings();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            grdTinhTrangDH.BestFitColumns();
            Report.rpDSDH report = new Report.rpDSDH();
            report.GridControl = grdControlTinhTrangDH;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
