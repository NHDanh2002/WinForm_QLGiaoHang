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
    public partial class frmThemLoaiNV : DevExpress.XtraEditors.XtraForm
    {
        clsBLLNhanVien bllnhanvien = new clsBLLNhanVien();
        DataTable dt = new DataTable();
        public frmThemLoaiNV()
        {
            InitializeComponent();
        }
        public string tangma()
        {
            dt = bllnhanvien.LayLoaiNV();
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "LNV01";
            }
            else
            {
                int k;
                ma = "LNV";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }
        private void btnTrang_Click(object sender, EventArgs e)
        {
            txtMaLNV.Text = string.Empty;
            txtTenLNV.Text = string.Empty;
            txtMota.Text = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLNV.Text = tangma();
            if (txtMaLNV.Text == string.Empty || txtTenLNV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn thêm chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    bllnhanvien.ThemLoaiNV(txtMaLNV.Text, txtTenLNV.Text, txtMota.Text);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.Close();
        }
    }
}