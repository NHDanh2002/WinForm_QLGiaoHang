
namespace GUI_QLGH.KhachHang
{
    partial class UCDSKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDSKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtThongTinKhac = new DevExpress.XtraEditors.MemoEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdControlDSKH = new DevExpress.XtraGrid.GridControl();
            this.grdDSKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.makh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thongtinkhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThongTinKhac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlDSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnReport.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReport.Appearance.Options.UseBackColor = true;
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.Location = new System.Drawing.Point(418, 22);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(101, 48);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnExport.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnExport.Appearance.Options.UseBackColor = true;
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(537, 22);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 48);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(656, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 48);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(775, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 48);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(894, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 48);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtThongTinKhac);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(622, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 516);
            this.panel2.TabIndex = 1;
            // 
            // txtThongTinKhac
            // 
            this.txtThongTinKhac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThongTinKhac.Location = new System.Drawing.Point(195, 314);
            this.txtThongTinKhac.Name = "txtThongTinKhac";
            this.txtThongTinKhac.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtThongTinKhac.Properties.Appearance.Options.UseFont = true;
            this.txtThongTinKhac.Size = new System.Drawing.Size(193, 117);
            this.txtThongTinKhac.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(195, 248);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(193, 28);
            this.txtEmail.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Location = new System.Drawing.Point(195, 176);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(193, 28);
            this.txtSDT.TabIndex = 8;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKH.Location = new System.Drawing.Point(195, 104);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenKH.Properties.Appearance.Options.UseFont = true;
            this.txtTenKH.Size = new System.Drawing.Size(193, 28);
            this.txtTenKH.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaKH.Location = new System.Drawing.Point(195, 32);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaKH.Properties.Appearance.Options.UseFont = true;
            this.txtMaKH.Properties.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(193, 28);
            this.txtMaKH.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(31, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thông tin khác:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(31, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(31, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(31, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdControlDSKH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 516);
            this.panel3.TabIndex = 2;
            // 
            // grdControlDSKH
            // 
            this.grdControlDSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControlDSKH.Location = new System.Drawing.Point(0, 0);
            this.grdControlDSKH.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.grdControlDSKH.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdControlDSKH.MainView = this.grdDSKH;
            this.grdControlDSKH.Name = "grdControlDSKH";
            this.grdControlDSKH.Size = new System.Drawing.Size(622, 516);
            this.grdControlDSKH.TabIndex = 0;
            this.grdControlDSKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdDSKH});
            // 
            // grdDSKH
            // 
            this.grdDSKH.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSKH.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSKH.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSKH.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSKH.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grdDSKH.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grdDSKH.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grdDSKH.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDSKH.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.grdDSKH.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDSKH.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSKH.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grdDSKH.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grdDSKH.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grdDSKH.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.grdDSKH.Appearance.Empty.Options.UseBackColor = true;
            this.grdDSKH.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.grdDSKH.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdDSKH.Appearance.EvenRow.Options.UseForeColor = true;
            this.grdDSKH.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSKH.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSKH.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSKH.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSKH.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grdDSKH.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grdDSKH.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grdDSKH.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDSKH.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.grdDSKH.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grdDSKH.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grdDSKH.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.grdDSKH.Appearance.FixedLine.Options.UseBackColor = true;
            this.grdDSKH.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grdDSKH.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdDSKH.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grdDSKH.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.grdDSKH.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdDSKH.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdDSKH.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdDSKH.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSKH.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSKH.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSKH.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSKH.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdDSKH.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdDSKH.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdDSKH.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSKH.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSKH.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.GroupButton.Options.UseBackColor = true;
            this.grdDSKH.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grdDSKH.Appearance.GroupButton.Options.UseForeColor = true;
            this.grdDSKH.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSKH.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSKH.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdDSKH.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grdDSKH.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grdDSKH.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDSKH.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSKH.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdDSKH.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdDSKH.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSKH.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSKH.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grdDSKH.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdDSKH.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grdDSKH.Appearance.GroupRow.Options.UseFont = true;
            this.grdDSKH.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdDSKH.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSKH.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSKH.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSKH.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSKH.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdDSKH.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdDSKH.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdDSKH.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.grdDSKH.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.grdDSKH.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdDSKH.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grdDSKH.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDSKH.Appearance.HorzLine.Options.UseBackColor = true;
            this.grdDSKH.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grdDSKH.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.OddRow.Options.UseBackColor = true;
            this.grdDSKH.Appearance.OddRow.Options.UseForeColor = true;
            this.grdDSKH.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grdDSKH.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.grdDSKH.Appearance.Preview.Options.UseBackColor = true;
            this.grdDSKH.Appearance.Preview.Options.UseForeColor = true;
            this.grdDSKH.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdDSKH.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grdDSKH.Appearance.Row.Options.UseBackColor = true;
            this.grdDSKH.Appearance.Row.Options.UseForeColor = true;
            this.grdDSKH.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grdDSKH.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grdDSKH.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.grdDSKH.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdDSKH.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdDSKH.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdDSKH.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDSKH.Appearance.VertLine.Options.UseBackColor = true;
            this.grdDSKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.makh,
            this.tenkh,
            this.sdt,
            this.email,
            this.thongtinkhac});
            this.grdDSKH.GridControl = this.grdControlDSKH;
            this.grdDSKH.Name = "grdDSKH";
            this.grdDSKH.OptionsView.EnableAppearanceEvenRow = true;
            this.grdDSKH.OptionsView.EnableAppearanceOddRow = true;
            this.grdDSKH.PaintStyleName = "Web";
            // 
            // makh
            // 
            this.makh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.makh.AppearanceCell.Options.UseFont = true;
            this.makh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.makh.AppearanceHeader.Options.UseFont = true;
            this.makh.AppearanceHeader.Options.UseTextOptions = true;
            this.makh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.makh.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.makh.Caption = "Mã khách hàng";
            this.makh.FieldName = "makh";
            this.makh.MinWidth = 25;
            this.makh.Name = "makh";
            this.makh.Visible = true;
            this.makh.VisibleIndex = 0;
            this.makh.Width = 94;
            // 
            // tenkh
            // 
            this.tenkh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tenkh.AppearanceCell.Options.UseFont = true;
            this.tenkh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tenkh.AppearanceHeader.Options.UseFont = true;
            this.tenkh.AppearanceHeader.Options.UseTextOptions = true;
            this.tenkh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tenkh.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tenkh.Caption = "Tên khách hàng";
            this.tenkh.FieldName = "tenkh";
            this.tenkh.MinWidth = 25;
            this.tenkh.Name = "tenkh";
            this.tenkh.Visible = true;
            this.tenkh.VisibleIndex = 1;
            this.tenkh.Width = 94;
            // 
            // sdt
            // 
            this.sdt.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sdt.AppearanceCell.Options.UseFont = true;
            this.sdt.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sdt.AppearanceHeader.Options.UseFont = true;
            this.sdt.AppearanceHeader.Options.UseTextOptions = true;
            this.sdt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sdt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.sdt.Caption = "Số điện thoại";
            this.sdt.FieldName = "sdt";
            this.sdt.MinWidth = 25;
            this.sdt.Name = "sdt";
            this.sdt.Visible = true;
            this.sdt.VisibleIndex = 2;
            this.sdt.Width = 94;
            // 
            // email
            // 
            this.email.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.email.AppearanceCell.Options.UseFont = true;
            this.email.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.email.AppearanceHeader.Options.UseFont = true;
            this.email.AppearanceHeader.Options.UseTextOptions = true;
            this.email.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.email.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.email.Caption = "Email";
            this.email.FieldName = "email";
            this.email.MinWidth = 25;
            this.email.Name = "email";
            this.email.Visible = true;
            this.email.VisibleIndex = 3;
            this.email.Width = 94;
            // 
            // thongtinkhac
            // 
            this.thongtinkhac.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.thongtinkhac.AppearanceCell.Options.UseFont = true;
            this.thongtinkhac.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.thongtinkhac.AppearanceHeader.Options.UseFont = true;
            this.thongtinkhac.AppearanceHeader.Options.UseTextOptions = true;
            this.thongtinkhac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thongtinkhac.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thongtinkhac.Caption = "Thông tin khác";
            this.thongtinkhac.FieldName = "thongtinkhac";
            this.thongtinkhac.MinWidth = 25;
            this.thongtinkhac.Name = "thongtinkhac";
            this.thongtinkhac.Visible = true;
            this.thongtinkhac.VisibleIndex = 4;
            this.thongtinkhac.Width = 94;
            // 
            // UCDSKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCDSKhachHang";
            this.Size = new System.Drawing.Size(1022, 616);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThongTinKhac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdControlDSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl grdControlDSKH;
        private DevExpress.XtraGrid.Views.Grid.GridView grdDSKH;
        private DevExpress.XtraGrid.Columns.GridColumn makh;
        private DevExpress.XtraGrid.Columns.GridColumn tenkh;
        private DevExpress.XtraGrid.Columns.GridColumn sdt;
        private DevExpress.XtraGrid.Columns.GridColumn email;
        private DevExpress.XtraGrid.Columns.GridColumn thongtinkhac;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.MemoEdit txtThongTinKhac;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.SimpleButton btnReport;
    }
}
