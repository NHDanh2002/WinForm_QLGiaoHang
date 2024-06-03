
namespace GUI_QLGH.NhanVien
{
    partial class UCLoaiNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLoaiNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdControlDSLoaiNV = new DevExpress.XtraGrid.GridControl();
            this.grdDSLoaiNV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maloainv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenloainv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenLNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMota = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLNV = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlDSLoaiNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSLoaiNV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdControlDSLoaiNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 478);
            this.panel1.TabIndex = 0;
            // 
            // grdControlDSLoaiNV
            // 
            this.grdControlDSLoaiNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControlDSLoaiNV.Location = new System.Drawing.Point(0, 0);
            this.grdControlDSLoaiNV.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.grdControlDSLoaiNV.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdControlDSLoaiNV.MainView = this.grdDSLoaiNV;
            this.grdControlDSLoaiNV.Name = "grdControlDSLoaiNV";
            this.grdControlDSLoaiNV.Size = new System.Drawing.Size(429, 478);
            this.grdControlDSLoaiNV.TabIndex = 2;
            this.grdControlDSLoaiNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdDSLoaiNV});
            // 
            // grdDSLoaiNV
            // 
            this.grdDSLoaiNV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSLoaiNV.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSLoaiNV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSLoaiNV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSLoaiNV.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grdDSLoaiNV.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDSLoaiNV.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.grdDSLoaiNV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDSLoaiNV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSLoaiNV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grdDSLoaiNV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.grdDSLoaiNV.Appearance.Empty.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.grdDSLoaiNV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.EvenRow.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSLoaiNV.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSLoaiNV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSLoaiNV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSLoaiNV.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grdDSLoaiNV.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDSLoaiNV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.grdDSLoaiNV.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.grdDSLoaiNV.Appearance.FixedLine.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grdDSLoaiNV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.grdDSLoaiNV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdDSLoaiNV.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSLoaiNV.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSLoaiNV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSLoaiNV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSLoaiNV.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdDSLoaiNV.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSLoaiNV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSLoaiNV.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.GroupButton.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grdDSLoaiNV.Appearance.GroupButton.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSLoaiNV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSLoaiNV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grdDSLoaiNV.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDSLoaiNV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSLoaiNV.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSLoaiNV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSLoaiNV.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grdDSLoaiNV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grdDSLoaiNV.Appearance.GroupRow.Options.UseFont = true;
            this.grdDSLoaiNV.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSLoaiNV.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSLoaiNV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSLoaiNV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSLoaiNV.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdDSLoaiNV.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.grdDSLoaiNV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.grdDSLoaiNV.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDSLoaiNV.Appearance.HorzLine.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grdDSLoaiNV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.OddRow.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.OddRow.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grdDSLoaiNV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.grdDSLoaiNV.Appearance.Preview.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.Preview.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdDSLoaiNV.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grdDSLoaiNV.Appearance.Row.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.Row.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grdDSLoaiNV.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.grdDSLoaiNV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdDSLoaiNV.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdDSLoaiNV.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdDSLoaiNV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDSLoaiNV.Appearance.VertLine.Options.UseBackColor = true;
            this.grdDSLoaiNV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maloainv,
            this.tenloainv,
            this.mota});
            this.grdDSLoaiNV.GridControl = this.grdControlDSLoaiNV;
            this.grdDSLoaiNV.Name = "grdDSLoaiNV";
            this.grdDSLoaiNV.OptionsView.EnableAppearanceEvenRow = true;
            this.grdDSLoaiNV.OptionsView.EnableAppearanceOddRow = true;
            this.grdDSLoaiNV.PaintStyleName = "Flat";
            // 
            // maloainv
            // 
            this.maloainv.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.maloainv.AppearanceCell.Options.UseFont = true;
            this.maloainv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.maloainv.AppearanceHeader.Options.UseFont = true;
            this.maloainv.AppearanceHeader.Options.UseTextOptions = true;
            this.maloainv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maloainv.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.maloainv.Caption = "Mã loại nhân viên";
            this.maloainv.FieldName = "maloainv";
            this.maloainv.MinWidth = 25;
            this.maloainv.Name = "maloainv";
            this.maloainv.Visible = true;
            this.maloainv.VisibleIndex = 0;
            this.maloainv.Width = 94;
            // 
            // tenloainv
            // 
            this.tenloainv.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tenloainv.AppearanceCell.Options.UseFont = true;
            this.tenloainv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tenloainv.AppearanceHeader.Options.UseFont = true;
            this.tenloainv.AppearanceHeader.Options.UseTextOptions = true;
            this.tenloainv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tenloainv.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tenloainv.Caption = "Loại nhân viên";
            this.tenloainv.FieldName = "tenloainv";
            this.tenloainv.MinWidth = 25;
            this.tenloainv.Name = "tenloainv";
            this.tenloainv.Visible = true;
            this.tenloainv.VisibleIndex = 1;
            this.tenloainv.Width = 94;
            // 
            // mota
            // 
            this.mota.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.mota.AppearanceCell.Options.UseFont = true;
            this.mota.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.mota.AppearanceHeader.Options.UseFont = true;
            this.mota.AppearanceHeader.Options.UseTextOptions = true;
            this.mota.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mota.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mota.Caption = "Mô tả";
            this.mota.FieldName = "mota";
            this.mota.MinWidth = 25;
            this.mota.Name = "mota";
            this.mota.Visible = true;
            this.mota.VisibleIndex = 2;
            this.mota.Width = 94;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(439, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 48);
            this.btnThem.TabIndex = 10;
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
            this.btnSua.Location = new System.Drawing.Point(558, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 48);
            this.btnSua.TabIndex = 9;
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
            this.btnXoa.Location = new System.Drawing.Point(677, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 48);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTenLNV);
            this.panel3.Controls.Add(this.txtMota);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtMaLNV);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(429, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 478);
            this.panel3.TabIndex = 1;
            // 
            // txtTenLNV
            // 
            this.txtTenLNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenLNV.Location = new System.Drawing.Point(177, 87);
            this.txtTenLNV.Name = "txtTenLNV";
            this.txtTenLNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenLNV.Properties.Appearance.Options.UseFont = true;
            this.txtTenLNV.Size = new System.Drawing.Size(172, 28);
            this.txtTenLNV.TabIndex = 31;
            // 
            // txtMota
            // 
            this.txtMota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMota.Location = new System.Drawing.Point(177, 155);
            this.txtMota.Name = "txtMota";
            this.txtMota.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMota.Properties.Appearance.Options.UseFont = true;
            this.txtMota.Size = new System.Drawing.Size(172, 219);
            this.txtMota.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Loại nhân viên:";
            // 
            // txtMaLNV
            // 
            this.txtMaLNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaLNV.Location = new System.Drawing.Point(177, 21);
            this.txtMaLNV.Name = "txtMaLNV";
            this.txtMaLNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaLNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaLNV.Properties.ReadOnly = true;
            this.txtMaLNV.Size = new System.Drawing.Size(172, 28);
            this.txtMaLNV.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mô tả:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã loại nhân viên:";
            // 
            // UCLoaiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UCLoaiNhanVien";
            this.Size = new System.Drawing.Size(799, 578);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdControlDSLoaiNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSLoaiNV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl grdControlDSLoaiNV;
        private DevExpress.XtraGrid.Views.Grid.GridView grdDSLoaiNV;
        private DevExpress.XtraGrid.Columns.GridColumn maloainv;
        private DevExpress.XtraGrid.Columns.GridColumn tenloainv;
        private DevExpress.XtraGrid.Columns.GridColumn mota;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtMaLNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.TextEdit txtTenLNV;
        private DevExpress.XtraEditors.MemoEdit txtMota;
    }
}
