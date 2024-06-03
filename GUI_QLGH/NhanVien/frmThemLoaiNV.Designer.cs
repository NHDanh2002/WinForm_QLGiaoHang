
namespace GUI_QLGH.NhanVien
{
    partial class frmThemLoaiNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLoaiNV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpThongTin = new DevExpress.XtraEditors.GroupControl();
            this.txtMota = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLNV = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLNV = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).BeginInit();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTrang);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnTrang
            // 
            this.btnTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTrang.Appearance.Options.UseFont = true;
            this.btnTrang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrang.ImageOptions.Image")));
            this.btnTrang.Location = new System.Drawing.Point(112, 30);
            this.btnTrang.Name = "btnTrang";
            this.btnTrang.Size = new System.Drawing.Size(100, 47);
            this.btnTrang.TabIndex = 11;
            this.btnTrang.Text = "Trắng";
            this.btnTrang.Click += new System.EventHandler(this.btnTrang_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(340, 30);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 47);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(226, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 47);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpThongTin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 418);
            this.panel2.TabIndex = 1;
            // 
            // grpThongTin
            // 
            this.grpThongTin.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.grpThongTin.AppearanceCaption.Options.UseFont = true;
            this.grpThongTin.AppearanceCaption.Options.UseForeColor = true;
            this.grpThongTin.Controls.Add(this.txtMota);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.txtTenLNV);
            this.grpThongTin.Controls.Add(this.label5);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Controls.Add(this.txtMaLNV);
            this.grpThongTin.Controls.Add(this.panel3);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Location = new System.Drawing.Point(0, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(450, 418);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.Text = "Thông tin:";
            // 
            // txtMota
            // 
            this.txtMota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMota.Location = new System.Drawing.Point(196, 200);
            this.txtMota.Name = "txtMota";
            this.txtMota.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMota.Properties.Appearance.Options.UseFont = true;
            this.txtMota.Size = new System.Drawing.Size(207, 165);
            this.txtMota.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(25, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "Loại nhân viên:";
            // 
            // txtTenLNV
            // 
            this.txtTenLNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenLNV.Location = new System.Drawing.Point(196, 125);
            this.txtTenLNV.Name = "txtTenLNV";
            this.txtTenLNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenLNV.Properties.Appearance.Options.UseFont = true;
            this.txtTenLNV.Size = new System.Drawing.Size(207, 28);
            this.txtTenLNV.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(25, 128);
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
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mã loại nhân viên:";
            // 
            // txtMaLNV
            // 
            this.txtMaLNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaLNV.Location = new System.Drawing.Point(196, 52);
            this.txtMaLNV.Name = "txtMaLNV";
            this.txtMaLNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaLNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaLNV.Properties.ReadOnly = true;
            this.txtMaLNV.Size = new System.Drawing.Size(207, 28);
            this.txtMaLNV.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(658, 1155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 67;
            // 
            // frmThemLoaiNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmThemLoaiNV.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemLoaiNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại nhân viên";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl grpThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaLNV;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.MemoEdit txtMota;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTenLNV;
        private DevExpress.XtraEditors.SimpleButton btnTrang;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}