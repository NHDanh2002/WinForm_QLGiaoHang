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
    public partial class UCDSNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        clsBLLNhanVien bllnhanvien = new clsBLLNhanVien();
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = bllnhanvien.LayDSNhanVien();
            grdControlDSNV.DataSource = dt;
        }
        public void bindings()
        {
            DataTable dt = bllnhanvien.LayDSNhanVien();
            grdControlDSNV.DataSource = dt;
            txtMaNV.DataBindings.Add("Text", dt, "manv");
            cboLoaiNV.DataBindings.Add("Text", dt, "maloainv");
            txtTenNV.DataBindings.Add("Text", dt, "tennv");
            txtSDT.DataBindings.Add("Text", dt, "sdt");
            txtEmail.DataBindings.Add("Text", dt, "email");
            txtThongTinKhac.DataBindings.Add("Text", dt, "thongtinkhac");
        }
        public void ClearBindings()
        {
            txtEmail.DataBindings.Clear();
            txtMaNV.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtTenNV.DataBindings.Clear();
            txtThongTinKhac.DataBindings.Clear();
            cboLoaiNV.DataBindings.Clear();
        }
        public void ChuyenAnh(List<byte[]> chuoi, List<Image> img)
        {
            DataTable dt = new DataTable();
            dt = bllnhanvien.LayDSNhanVien();
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
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public UCDSNhanVien()
        {
            InitializeComponent();
            bindings();
            DataTable dt1 = new DataTable();
            dt1 = bllnhanvien.LayMaLoaiNv();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cboLoaiNV.Properties.Items.Add(dt1.Rows[i]["maloainv"]);
            }
        }
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<byte[]> chuoi = new List<byte[]>();
            List<Image> img = new List<Image>();
            ChuyenAnh(chuoi, img);
            dt = bllnhanvien.LayDSNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(txtMaNV.Text == dt.Rows[i]["manv"].ToString())
                {
                    picAva.Image = img[i];
                }
            }
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
                    grdControlDSNV.ExportToXlsx(saveFileDialog.FileName);
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
            grdDSNV.BestFitColumns();
            Report.rpDSNV report = new Report.rpDSNV();
            report.GridControl = grdControlDSNV;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien.frmThemNhanVien frmthemnv = new frmThemNhanVien();
            frmthemnv.ShowDialog();
            LoadData();
            ClearBindings();
            bindings();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //ImageToByteArray(picAva.Image);
                bllnhanvien.SuaNhanVien(txtMaNV.Text, cboLoaiNV.Text, txtTenNV.Text, txtSDT.Text, txtEmail.Text, ImageToByteArray(picAva.Image),txtThongTinKhac.Text);
                MessageBox.Show("Sửa nhân viên thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearBindings();
                bindings();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bllnhanvien.XoaNhanVien(txtMaNV.Text);
                MessageBox.Show("Đã xóa nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearBindings();
                bindings();
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            if (picAva.Image != null)
                picAva.Image.Dispose();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
                picAva.Image = new Bitmap(openFileDialog.FileName);
        }
    }
}
