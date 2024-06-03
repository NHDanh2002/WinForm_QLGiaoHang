using BLL_QLGH;
using DTO_QLGH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUI_QLGH
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        clsBLLLogin bll = new clsBLLLogin();
        public frmLogin()
        {
            InitializeComponent();
        }
        public string quyen;
        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đóng ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.Login();
            List<clsDTOLogin> taikhoan = new List<clsDTOLogin>();
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                taikhoan.Add(new clsDTOLogin(dt.Rows[i]["username"].ToString(),dt.Rows[i]["password"].ToString()));
            }    
            frmTrangChu frm = new frmTrangChu();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (txtTaiKhoan.Text == dt.Rows[i][0].ToString() && txtMatKhau.Text == dt.Rows[i][1].ToString())
            //    {
            //        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //        Program.th.SetApartmentState(ApartmentState.STA);
            //        Program.th.Start();
            //        break;
            //    }
            //    else
            //    {
            //        if (txtTaiKhoan.Text != dt.Rows[i][0].ToString() || txtMatKhau.Text != dt.Rows[i][1].ToString())
            //        {
            //            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            txtMatKhau.Text = "";
            //            txtTaiKhoan.Text = "";
            //            txtTaiKhoan.Focus();
            //            return;
            //        }
            //    }
            //}
            bool flag = false;
            for(int i = 0; i < taikhoan.Count;i++)
            {
                if(txtMatKhau.Text == taikhoan[i].Password && txtTaiKhoan.Text == taikhoan[i].Username)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = true;
                    this.Close();
                    Program.th.SetApartmentState(ApartmentState.STA);
                    Program.th.Start();
                    break;
                }
            }
            if(flag == false)
            {
                for (int i = 0; i < taikhoan.Count; i++)
                {
                    if (txtMatKhau.Text != taikhoan[i].Password && txtTaiKhoan.Text != taikhoan[i].Username)
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMatKhau.Text = "";
                        txtTaiKhoan.Text = "";
                        txtTaiKhoan.Focus();
                        return;
                    }
                }
            }    
        }

        private void frmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
