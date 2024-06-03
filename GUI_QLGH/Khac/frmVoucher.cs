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

namespace GUI_QLGH.Khac
{
    public partial class frmVoucher : DevExpress.XtraEditors.XtraUserControl
    {
        clsBLLNhanVien bllnhanvien = new clsBLLNhanVien();
        clsBLLKhac bllkhac = new clsBLLKhac();
        void LoadData()
        {
            DataTable dt = bllkhac.LayDSVoucher();
            gridControlDSVoucher.DataSource = dt;
        }
        void bindings()
        {
            DataTable dt = bllkhac.LayDSVoucher();
            gridControlDSVoucher.DataSource = dt;
            txtMaVC.DataBindings.Add("Text", dt, "mavoucher");
            txtTenVC.DataBindings.Add("Text", dt, "tenvoucher");
            cboMaNV.DataBindings.Add("Text", dt, "manguoilap");
            txtThoiHang.DataBindings.Add("Text", dt, "thoihang");
            dtpNgayTao.DataBindings.Add("Value", dt, "ngaytao");
        }
        void ClearBindings()
        {
            cboMaNV.DataBindings.Clear();
            txtMaVC.DataBindings.Clear();
            txtTenVC.DataBindings.Clear();
            txtThoiHang.DataBindings.Clear();
            dtpNgayTao.DataBindings.Clear();
        }
        public frmVoucher()
        {
            InitializeComponent();
            bindings();
            DataTable dt1 = bllnhanvien.LayDSNhanVien();
            List<string> nvql = new List<string>();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if (dt1.Rows[i]["maloainv"].ToString() == "LNV04     ")
                    nvql.Add(dt1.Rows[i]["manv"].ToString());
            }
            for (int i = 0; i < nvql.Count; i++)
                cboMaNV.Properties.Items.Add(nvql[i]);
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
                    gridControlDSVoucher.ExportToXlsx(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemVoucher themvoucher = new frmThemVoucher();
            themvoucher.ShowDialog();
            LoadData();
            ClearBindings();
            bindings();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa Voucher này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllkhac.SuaVoucher(txtMaVC.Text, txtTenVC.Text, cboMaNV.Text, dtpNgayTao.Value, txtThoiHang.Text);
                MessageBox.Show("Sửa Voucher thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearBindings();
                bindings();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Voucher này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bllkhac.XoaVoucher(txtMaVC.Text);
                MessageBox.Show("Đã xóa Voucher", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearBindings();
                bindings();
            }
        }
    }
}
