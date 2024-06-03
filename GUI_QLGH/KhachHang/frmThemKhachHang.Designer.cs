
namespace GUI_QLGH.KhachHang
{
    partial class frmThemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gctlNhapTT = new DevExpress.XtraEditors.GroupControl();
            this.txtTTKhac = new DevExpress.XtraEditors.MemoEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctlNhapTT)).BeginInit();
            this.gctlNhapTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTTKhac.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gctlNhapTT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 338);
            this.panel1.TabIndex = 0;
            // 
            // gctlNhapTT
            // 
            this.gctlNhapTT.AppearanceCaption.BackColor = System.Drawing.Color.White;
            this.gctlNhapTT.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gctlNhapTT.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.gctlNhapTT.AppearanceCaption.Options.UseBackColor = true;
            this.gctlNhapTT.AppearanceCaption.Options.UseFont = true;
            this.gctlNhapTT.AppearanceCaption.Options.UseForeColor = true;
            this.gctlNhapTT.Controls.Add(this.txtTTKhac);
            this.gctlNhapTT.Controls.Add(this.txtEmail);
            this.gctlNhapTT.Controls.Add(this.txtSDT);
            this.gctlNhapTT.Controls.Add(this.txtTenKH);
            this.gctlNhapTT.Controls.Add(this.txtMaKH);
            this.gctlNhapTT.Controls.Add(this.label4);
            this.gctlNhapTT.Controls.Add(this.label8);
            this.gctlNhapTT.Controls.Add(this.label3);
            this.gctlNhapTT.Controls.Add(this.label2);
            this.gctlNhapTT.Controls.Add(this.label1);
            this.gctlNhapTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctlNhapTT.Location = new System.Drawing.Point(0, 0);
            this.gctlNhapTT.Name = "gctlNhapTT";
            this.gctlNhapTT.Size = new System.Drawing.Size(736, 338);
            this.gctlNhapTT.TabIndex = 9;
            this.gctlNhapTT.Text = "Nhập thông tin khách hàng";
            // 
            // txtTTKhac
            // 
            this.txtTTKhac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTTKhac.Location = new System.Drawing.Point(548, 66);
            this.txtTTKhac.Name = "txtTTKhac";
            this.txtTTKhac.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTTKhac.Properties.Appearance.Options.UseFont = true;
            this.txtTTKhac.Size = new System.Drawing.Size(146, 201);
            this.txtTTKhac.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(372, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thông tin khác:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTrang);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 95);
            this.panel2.TabIndex = 1;
            // 
            // btnTrang
            // 
            this.btnTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTrang.Appearance.Options.UseFont = true;
            this.btnTrang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrang.ImageOptions.Image")));
            this.btnTrang.Location = new System.Drawing.Point(368, 25);
            this.btnTrang.Name = "btnTrang";
            this.btnTrang.Size = new System.Drawing.Size(100, 47);
            this.btnTrang.TabIndex = 5;
            this.btnTrang.Text = "Trắng";
            this.btnTrang.Click += new System.EventHandler(this.btnTrang_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(596, 25);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 47);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(482, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 47);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(27, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(27, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaKH.EditValue = "";
            this.txtMaKH.Location = new System.Drawing.Point(193, 67);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Properties.Appearance.Options.UseFont = true;
            this.txtMaKH.Properties.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(146, 32);
            this.txtMaKH.TabIndex = 8;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKH.Location = new System.Drawing.Point(193, 124);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Properties.Appearance.Options.UseFont = true;
            this.txtTenKH.Size = new System.Drawing.Size(146, 32);
            this.txtTenKH.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Location = new System.Drawing.Point(193, 180);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(146, 32);
            this.txtSDT.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(193, 236);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(146, 32);
            this.txtEmail.TabIndex = 11;
            // 
            // frmThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmThemKhachHang.IconOptions.LargeImage")));
            this.Name = "frmThemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khách hàng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctlNhapTT)).EndInit();
            this.gctlNhapTT.ResumeLayout(false);
            this.gctlNhapTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTTKhac.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl gctlNhapTT;
        private DevExpress.XtraEditors.MemoEdit txtTTKhac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnTrang;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}