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

namespace GUI_QLGH.KhachHang
{    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        clsBLLKhachHang bllkhachhang = new clsBLLKhachHang();
        DataTable dt = new DataTable();
        public frmThemKhachHang()
        {
            InitializeComponent();
        }
        public string tangma()
        {
            dt = bllkhachhang.LayDSKhachHang();
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "KH001";
            }
            else
            {
                int k;
                ma = "KH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k < 100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }
        private void btnTrang_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtTTKhac.Text = string.Empty;
            txtTenKH.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = tangma();
            if (txtMaKH.Text == string.Empty || txtTenKH.Text == string.Empty || txtSDT.Text == string.Empty || txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("bạn chắc chắn muốn thêm chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    bllkhachhang.ThemKhachHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtEmail.Text, txtTTKhac.Text);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
        }
    }
}