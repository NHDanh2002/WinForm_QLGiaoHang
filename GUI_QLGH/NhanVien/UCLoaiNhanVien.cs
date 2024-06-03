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

namespace GUI_QLGH.NhanVien
{
    public partial class UCLoaiNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        clsBLLNhanVien bllnhanvien = new clsBLLNhanVien();
        public void LoadData()
        {
            DataTable dt = bllnhanvien.LayLoaiNV();
            grdControlDSLoaiNV.DataSource = dt;
        }
        public void bindings()
        {
            DataTable dt = bllnhanvien.LayLoaiNV();
            grdControlDSLoaiNV.DataSource = dt;
            txtMaLNV.DataBindings.Add("Text", dt, "maloainv");
            txtTenLNV.DataBindings.Add("Text", dt, "tenloainv");
            txtMota.DataBindings.Add("Text", dt, "mota");
        }
        public void ClearBindings()
        {
            txtMaLNV.DataBindings.Clear();
            txtMota.DataBindings.Clear();
            txtTenLNV.DataBindings.Clear();
        }
        public UCLoaiNhanVien()
        {
            InitializeComponent();
            bindings();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bllnhanvien.XoaLoaiNV(txtMaLNV.Text);
                MessageBox.Show("Đã xóa loại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearBindings();
                bindings();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa loại nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //ImageToByteArray(picAva.Image);
                bllnhanvien.SuaLoaiNV(txtMaLNV.Text, txtTenLNV.Text, txtMota.Text);
                MessageBox.Show("Sửa loại nhân viên thành công?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearBindings();
                bindings();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien.frmThemLoaiNV frmthemloainv = new frmThemLoaiNV();
            frmthemloainv.ShowDialog();
            LoadData();
            ClearBindings();
            bindings();
        }
    }
}
