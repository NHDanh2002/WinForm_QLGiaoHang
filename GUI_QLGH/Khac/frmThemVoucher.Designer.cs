
namespace GUI_QLGH.Khac
{
    partial class frmThemVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemVoucher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThoiHang = new DevExpress.XtraEditors.TextEdit();
            this.txtTenVC = new DevExpress.XtraEditors.TextEdit();
            this.txtMaVC = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.cboMaNV = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVC.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboMaNV);
            this.panel1.Controls.Add(this.dtpNgayTao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtThoiHang);
            this.panel1.Controls.Add(this.txtTenVC);
            this.panel1.Controls.Add(this.txtMaVC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 418);
            this.panel1.TabIndex = 0;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayTao.Enabled = false;
            this.dtpNgayTao.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(234, 262);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(196, 32);
            this.dtpNgayTao.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(43, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Thời hạng: ";
            // 
            // txtThoiHang
            // 
            this.txtThoiHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThoiHang.Location = new System.Drawing.Point(234, 340);
            this.txtThoiHang.Name = "txtThoiHang";
            this.txtThoiHang.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiHang.Properties.Appearance.Options.UseFont = true;
            this.txtThoiHang.Size = new System.Drawing.Size(196, 32);
            this.txtThoiHang.TabIndex = 19;
            // 
            // txtTenVC
            // 
            this.txtTenVC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenVC.Location = new System.Drawing.Point(234, 106);
            this.txtTenVC.Name = "txtTenVC";
            this.txtTenVC.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVC.Properties.Appearance.Options.UseFont = true;
            this.txtTenVC.Size = new System.Drawing.Size(196, 32);
            this.txtTenVC.TabIndex = 17;
            // 
            // txtMaVC
            // 
            this.txtMaVC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaVC.EditValue = "";
            this.txtMaVC.Location = new System.Drawing.Point(234, 28);
            this.txtMaVC.Name = "txtMaVC";
            this.txtMaVC.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVC.Properties.Appearance.Options.UseFont = true;
            this.txtMaVC.Properties.ReadOnly = true;
            this.txtMaVC.Size = new System.Drawing.Size(196, 32);
            this.txtMaVC.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(43, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày tạo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(43, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã nhân viên lập:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(43, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên voucher:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã voucher:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTrang);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnTrang
            // 
            this.btnTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTrang.Appearance.Options.UseFont = true;
            this.btnTrang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrang.ImageOptions.Image")));
            this.btnTrang.Location = new System.Drawing.Point(72, 27);
            this.btnTrang.Name = "btnTrang";
            this.btnTrang.Size = new System.Drawing.Size(100, 47);
            this.btnTrang.TabIndex = 8;
            this.btnTrang.Text = "Trắng";
            this.btnTrang.Click += new System.EventHandler(this.btnTrang_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(300, 27);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 47);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(186, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 47);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboMaNV
            // 
            this.cboMaNV.Location = new System.Drawing.Point(234, 184);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboMaNV.Properties.Appearance.Options.UseFont = true;
            this.cboMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaNV.Size = new System.Drawing.Size(196, 30);
            this.cboMaNV.TabIndex = 22;
            // 
            // frmThemVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmThemVoucher.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Voucher";
            this.Load += new System.EventHandler(this.frmThemVoucher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVC.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnTrang;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtThoiHang;
        private DevExpress.XtraEditors.TextEdit txtTenVC;
        private DevExpress.XtraEditors.TextEdit txtMaVC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cboMaNV;
    }
}