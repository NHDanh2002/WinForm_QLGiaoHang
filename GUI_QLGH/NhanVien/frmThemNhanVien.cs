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

namespace GUI_QLGH.NhanVien
{
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        clsBLLNhanVien bllnhanvien = new clsBLLNhanVien();
        DataTable dt = new DataTable();
        public frmThemNhanVien()
        {
            InitializeComponent();
            DataTable dt1 = new DataTable();
            dt1 = bllnhanvien.LayMaLoaiNv();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cboLoaiNV.Properties.Items.Add(dt1.Rows[i]["maloainv"]);
            }
        }

        public string tangma()
        {
            dt = bllnhanvien.LayDSNhanVien();
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NV001";
            }
            else
            {
                int k;
                ma = "NV";
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
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = tangma();
            if (txtSDT.Text.Length > 10 || txtSDT.Text.Length < 10)
            {
                MessageBox.Show("SĐT không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtMaNV.Text == string.Empty || cboLoaiNV.Text == string.Empty || txtSDT.Text == string.Empty || txtEmail.Text == string.Empty || txtTenNV.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("bạn chắc chắn muốn thêm chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        bllnhanvien.ThemNhanVien(txtMaNV.Text, cboLoaiNV.Text, txtTenNV.Text, txtSDT.Text, txtEmail.Text, ImageToByteArray(picAva.Image), txtThongTinKhac.Text);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }
            }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.Close();
        }

        private void btnTrang_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = string.Empty;
            cboLoaiNV.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtThongTinKhac.Text = string.Empty;
            picAva.Image = null;
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            if (picAva.Image != null)
                picAva.Image.Dispose();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                picAva.Image = new Bitmap(openFileDialog.FileName);
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            picAva.Image = Image.FromFile(Application.StartupPath + @"\face\default.jpg");
        }
    }
}