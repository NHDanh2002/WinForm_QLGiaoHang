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
{
    public partial class frmThemNguoiNhan : DevExpress.XtraEditors.XtraForm
    {
        clsBLLKhachHang bllkhachhang = new clsBLLKhachHang();
        DataTable dt = new DataTable();
        public frmThemNguoiNhan()
        {
            InitializeComponent();
        }
        public string tangma()
        {
            dt = bllkhachhang.LayDSNguoiNhan();
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NN001";
            }
            else
            {
                int k;
                ma = "NN";
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
            DataTable dt1 = new DataTable();
            int count = 0;
            dt1 = bllkhachhang.LayDSKhachHang();
            txtMaNN.Text = tangma();
            List<string> listmakh = new List<string>();
            for(int i = 0; i< dt1.Rows.Count; i++)
            {
                listmakh.Add(dt1.Rows[i]["makh"].ToString());
            }
            foreach (string makh in listmakh)
            if (txtMaKH.Text != makh)
            {
                    count++;
            }
            if (txtSDT.Text.Length > 10 || txtSDT.Text.Length < 10)
            {
                MessageBox.Show("SĐT không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtMaKH.Text == string.Empty || txtTenNN.Text == string.Empty || txtSDT.Text == string.Empty || txtEmail.Text == string.Empty || txtDiaChi.Text == string.Empty || txtCMND.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(count == listmakh.Count)
                        MessageBox.Show("Khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (MessageBox.Show("bạn chắc chắn muốn thêm chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            bllkhachhang.ThemNguoiNhan(txtMaNN.Text, txtMaKH.Text, txtTenNN.Text, txtSDT.Text, txtEmail.Text, txtCMND.Text, txtDiaChi.Text, txtTTKhac.Text);
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return;
                    }
                }
            }
        }
        private void btnTrang_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = string.Empty;
            txtMaNN.Text = string.Empty;
            txtTenNN.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtTTKhac.Text = string.Empty;
            txtMaKH.Focus();
        }

        private void frmThemNguoiNhan_Load(object sender, EventArgs e)
        {
            txtMaKH.Focus();
        }
    }
}