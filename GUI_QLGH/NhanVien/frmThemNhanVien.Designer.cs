
namespace GUI_QLGH.NhanVien
{
    partial class frmThemNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpThongTin = new DevExpress.XtraEditors.GroupControl();
            this.picAva = new DevExpress.XtraEditors.PictureEdit();
            this.cboLoaiNV = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnThemAnh = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtThongTinKhac = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).BeginInit();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThongTinKhac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpThongTin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 568);
            this.panel1.TabIndex = 0;
            // 
            // grpThongTin
            // 
            this.grpThongTin.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.grpThongTin.AppearanceCaption.Options.UseFont = true;
            this.grpThongTin.AppearanceCaption.Options.UseForeColor = true;
            this.grpThongTin.Controls.Add(this.picAva);
            this.grpThongTin.Controls.Add(this.cboLoaiNV);
            this.grpThongTin.Controls.Add(this.btnThemAnh);
            this.grpThongTin.Controls.Add(this.label5);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.txtThongTinKhac);
            this.grpThongTin.Controls.Add(this.label4);
            this.grpThongTin.Controls.Add(this.txtSDT);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.txtTenNV);
            this.grpThongTin.Controls.Add(this.label7);
            this.grpThongTin.Controls.Add(this.txtMaNV);
            this.grpThongTin.Controls.Add(this.panel3);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Location = new System.Drawing.Point(0, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(540, 568);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.Text = "Thông tin nhân viên:";
            // 
            // picAva
            // 
            this.picAva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAva.Location = new System.Drawing.Point(294, 50);
            this.picAva.Name = "picAva";
            this.picAva.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAva.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picAva.Size = new System.Drawing.Size(196, 208);
            this.picAva.TabIndex = 53;
            // 
            // cboLoaiNV
            // 
            this.cboLoaiNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLoaiNV.Location = new System.Drawing.Point(168, 100);
            this.cboLoaiNV.Name = "cboLoaiNV";
            this.cboLoaiNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboLoaiNV.Properties.Appearance.Options.UseFont = true;
            this.cboLoaiNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiNV.Size = new System.Drawing.Size(120, 28);
            this.cboLoaiNV.TabIndex = 66;
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemAnh.Location = new System.Drawing.Point(496, 228);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(30, 30);
            this.btnThemAnh.TabIndex = 54;
            this.btnThemAnh.Text = "...";
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(21, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 65;
            this.label5.Text = "Loại nhân viên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(21, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tên nhân viên:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(168, 370);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(321, 28);
            this.txtEmail.TabIndex = 63;
            // 
            // txtThongTinKhac
            // 
            this.txtThongTinKhac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThongTinKhac.Location = new System.Drawing.Point(168, 415);
            this.txtThongTinKhac.Name = "txtThongTinKhac";
            this.txtThongTinKhac.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtThongTinKhac.Properties.Appearance.Options.UseFont = true;
            this.txtThongTinKhac.Size = new System.Drawing.Size(322, 127);
            this.txtThongTinKhac.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(21, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Location = new System.Drawing.Point(168, 326);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(166, 28);
            this.txtSDT.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(21, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "Email:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.Location = new System.Drawing.Point(168, 282);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenNV.Properties.Appearance.Options.UseFont = true;
            this.txtTenNV.Size = new System.Drawing.Size(321, 28);
            this.txtTenNV.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(21, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 59;
            this.label7.Text = "Thông tin khác:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNV.Location = new System.Drawing.Point(168, 50);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(120, 28);
            this.txtMaNV.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(658, 1155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTrang);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnTrang
            // 
            this.btnTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTrang.Appearance.Options.UseFont = true;
            this.btnTrang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrang.ImageOptions.Image")));
            this.btnTrang.Location = new System.Drawing.Point(188, 27);
            this.btnTrang.Name = "btnTrang";
            this.btnTrang.Size = new System.Drawing.Size(100, 47);
            this.btnTrang.TabIndex = 8;
            this.btnTrang.Text = "Trắng";
            this.btnTrang.Click += new System.EventHandler(this.btnTrang_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(416, 27);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 47);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(302, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 47);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmThemNhanVien.IconOptions.LargeImage")));
            this.Name = "frmThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThongTinKhac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl grpThongTin;
        private DevExpress.XtraEditors.PictureEdit picAva;
        private DevExpress.XtraEditors.ComboBoxEdit cboLoaiNV;
        private DevExpress.XtraEditors.SimpleButton btnThemAnh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.MemoEdit txtThongTinKhac;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnTrang;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}