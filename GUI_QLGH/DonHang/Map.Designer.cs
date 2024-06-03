
namespace GUI_QLGH.DonHang
{
    partial class frmViTriDH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViTriDH));
            this.mapVitriDH = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtKhoangCach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.MemoEdit();
            this.txtMaDH = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txtCuocPhi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapVitriDH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoangCach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuocPhi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mapVitriDH
            // 
            this.mapVitriDH.CenterPoint = new DevExpress.XtraMap.GeoPoint(11D, 106.6D);
            this.mapVitriDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapVitriDH.Layers.Add(this.imageLayer1);
            this.mapVitriDH.Location = new System.Drawing.Point(0, 0);
            this.mapVitriDH.MinZoomLevel = 5D;
            this.mapVitriDH.Name = "mapVitriDH";
            this.mapVitriDH.Size = new System.Drawing.Size(818, 595);
            this.mapVitriDH.TabIndex = 0;
            this.mapVitriDH.ZoomLevel = 10D;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AuKJKDL5eEjK5udzBUDBNdPjRYqjjYchifKs2XPtJNA6I9BYrTMJW2gDSzYyVAwY";
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mapVitriDH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 595);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCuocPhi);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.txtKhoangCach);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.txtMaDH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(818, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 595);
            this.panel2.TabIndex = 2;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKhoangCach.Location = new System.Drawing.Point(45, 350);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtKhoangCach.Properties.Appearance.Options.UseFont = true;
            this.txtKhoangCach.Properties.ReadOnly = true;
            this.txtKhoangCach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKhoangCach.Size = new System.Drawing.Size(125, 28);
            this.txtKhoangCach.TabIndex = 5;
            this.txtKhoangCach.TextChanged += new System.EventHandler(this.txtKhoangCach_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 309);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(156, 23);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Khoảng cách (Km)";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaChi.Location = new System.Drawing.Point(19, 130);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(171, 161);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaDH.Location = new System.Drawing.Point(20, 49);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaDH.Properties.Appearance.Options.UseFont = true;
            this.txtMaDH.Size = new System.Drawing.Size(171, 28);
            this.txtMaDH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(72, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCapNhat.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCapNhat.Appearance.Options.UseBackColor = true;
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(20, 531);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(165, 43);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật cước phí";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtCuocPhi
            // 
            this.txtCuocPhi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCuocPhi.Location = new System.Drawing.Point(45, 437);
            this.txtCuocPhi.Name = "txtCuocPhi";
            this.txtCuocPhi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCuocPhi.Properties.Appearance.Options.UseFont = true;
            this.txtCuocPhi.Properties.ReadOnly = true;
            this.txtCuocPhi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCuocPhi.Size = new System.Drawing.Size(125, 28);
            this.txtCuocPhi.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(42, 396);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(131, 23);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Cước phí (VNĐ)";
            // 
            // frmViTriDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmViTriDH.IconOptions.LargeImage")));
            this.Name = "frmViTriDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vị trí đơn hàng";
            this.Load += new System.EventHandler(this.frmViTriDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapVitriDH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoangCach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuocPhi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapVitriDH;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.MemoEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtMaDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtKhoangCach;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.TextEdit txtCuocPhi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}