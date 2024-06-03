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
    public partial class frmThemVoucher : DevExpress.XtraEditors.XtraForm
    {
        clsBLLKhac bllkhac = new clsBLLKhac();
        clsBLLNhanVien bllnhanvien = new clsBLLNhanVien();
        DataTable dt = new DataTable();
        public frmThemVoucher()
        {
            InitializeComponent();
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
        public string tangma()
        {
            dt = bllkhac.LayDSVoucher();
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "VC001";
            }
            else
            {
                int k;
                ma = "VC";
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
        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaVC.Text = tangma();
            if (txtMaVC.Text == string.Empty || txtTenVC.Text == string.Empty || txtThoiHang.Text == string.Empty || cboMaNV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("bạn chắc chắn muốn thêm chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    bllkhac.ThemVoucher(txtMaVC.Text, txtTenVC.Text, cboMaNV.Text, dtpNgayTao.Value, txtThoiHang.Text);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
        }

        private void btnTrang_Click(object sender, EventArgs e)
        {
            txtMaVC.Text = string.Empty;
            txtTenVC.Text = string.Empty;
            cboMaNV.Text = string.Empty;
            txtThoiHang.Text = string.Empty;
        }

        private void frmThemVoucher_Load(object sender, EventArgs e)
        {
            dtpNgayTao.Value = DateTime.Now;
        }
    }
}