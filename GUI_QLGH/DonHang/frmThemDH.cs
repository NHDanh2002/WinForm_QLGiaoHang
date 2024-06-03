using BLL_QLGH;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLGH.DonHang
{
    public partial class frmThemDH : DevExpress.XtraEditors.XtraForm
    {
        clsBLLDonHang blldonhang = new clsBLLDonHang();
        DataTable dt = new DataTable();
        public frmThemDH()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.Close();
        }
        public string tangma()
        {
            dt = blldonhang.LayDSDonHang();
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "DH001";
            }
            else
            {
                int k;
                ma = "DH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if(k<10)
                {
                    ma = ma + "00";
                }
                else if(k<100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaDH.Text = tangma();
            txtCuocPhi.Text = "0";
            if (txtMaNV.Text == string.Empty || txtMaDH.Text == string.Empty || txtMaKH.Text == string.Empty || txtMaNN.Text == string.Empty || txtTHG.Text == string.Empty || txtKhoiLuong.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("bạn chắc chắn muốn thêm chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    blldonhang.ThemDonHang(txtMaDH.Text, txtMaKH.Text, txtMaNN.Text, txtMaNV.Text, txtCuocPhi.Text, txtKhoiLuong.Text, txtTHG.Text, txtGhiChu.Text);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtCuocPhi.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtKhoiLuong.Text = string.Empty;
            txtMaDH.Text = string.Empty;
            txtMaKH.Text = string.Empty;
            txtMaNN.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtTHG.Text = string.Empty;
        }
    }
}