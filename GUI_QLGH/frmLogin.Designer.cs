
namespace GUI_QLGH
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(54, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(220, 61);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đăng nhập ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 15F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(54, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 36);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaiKhoan.Location = new System.Drawing.Point(54, 159);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 15F);
            this.txtTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.txtTaiKhoan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtTaiKhoan.Size = new System.Drawing.Size(355, 44);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 15F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 223);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 36);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatKhau.Location = new System.Drawing.Point(54, 265);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 15F);
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(355, 44);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Tag = "";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 17F);
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(54, 343);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 63);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 450);
            this.panel1.TabIndex = 6;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(500, 450);
            this.pictureEdit1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.txtTaiKhoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(500, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 450);
            this.panel2.TabIndex = 7;
            // 
            // btnDong
            // 
            this.btnDong.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDong.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 17F);
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Location = new System.Drawing.Point(256, 343);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(153, 63);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmLogin.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}

