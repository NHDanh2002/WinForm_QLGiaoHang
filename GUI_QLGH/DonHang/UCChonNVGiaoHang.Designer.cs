
namespace GUI_QLGH.DonHang
{
    partial class UCChonNVGiaoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChonNVGiaoHang));
            this.grDSDH = new DevExpress.XtraEditors.GroupControl();
            this.grdCTDSDHChuaGiao = new DevExpress.XtraGrid.GridControl();
            this.grdDHChuaGiao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.madh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tinhtrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tennn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cuocphi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thoihangiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnChonNguoiGiao = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTinhTrang = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.txtTHG = new DevExpress.XtraEditors.TextEdit();
            this.cboNhanVienGiao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtCuocPhi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNN = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDH = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grDSDH)).BeginInit();
            this.grDSDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCTDSDHChuaGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDHChuaGiao)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTHG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhanVienGiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDH.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDSDH
            // 
            this.grDSDH.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.grDSDH.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.grDSDH.AppearanceCaption.Options.UseFont = true;
            this.grDSDH.AppearanceCaption.Options.UseForeColor = true;
            this.grDSDH.Controls.Add(this.grdCTDSDHChuaGiao);
            this.grDSDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSDH.Location = new System.Drawing.Point(0, 0);
            this.grDSDH.Name = "grDSDH";
            this.grDSDH.Size = new System.Drawing.Size(678, 630);
            this.grDSDH.TabIndex = 0;
            this.grDSDH.Text = "Đơn hàng chưa có người giao";
            // 
            // grdCTDSDHChuaGiao
            // 
            this.grdCTDSDHChuaGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCTDSDHChuaGiao.Location = new System.Drawing.Point(2, 28);
            this.grdCTDSDHChuaGiao.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.grdCTDSDHChuaGiao.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdCTDSDHChuaGiao.MainView = this.grdDHChuaGiao;
            this.grdCTDSDHChuaGiao.Name = "grdCTDSDHChuaGiao";
            this.grdCTDSDHChuaGiao.Size = new System.Drawing.Size(674, 600);
            this.grdCTDSDHChuaGiao.TabIndex = 1;
            this.grdCTDSDHChuaGiao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdDHChuaGiao});
            // 
            // grdDHChuaGiao
            // 
            this.grdDHChuaGiao.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDHChuaGiao.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDHChuaGiao.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDHChuaGiao.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDHChuaGiao.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grdDHChuaGiao.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDHChuaGiao.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.grdDHChuaGiao.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDHChuaGiao.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDHChuaGiao.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grdDHChuaGiao.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.grdDHChuaGiao.Appearance.Empty.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.grdDHChuaGiao.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.EvenRow.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDHChuaGiao.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDHChuaGiao.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDHChuaGiao.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDHChuaGiao.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grdDHChuaGiao.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDHChuaGiao.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.grdDHChuaGiao.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.grdDHChuaGiao.Appearance.FixedLine.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grdDHChuaGiao.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.grdDHChuaGiao.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdDHChuaGiao.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDHChuaGiao.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDHChuaGiao.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDHChuaGiao.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDHChuaGiao.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdDHChuaGiao.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDHChuaGiao.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDHChuaGiao.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.GroupButton.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grdDHChuaGiao.Appearance.GroupButton.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDHChuaGiao.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDHChuaGiao.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grdDHChuaGiao.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDHChuaGiao.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDHChuaGiao.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDHChuaGiao.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDHChuaGiao.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grdDHChuaGiao.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grdDHChuaGiao.Appearance.GroupRow.Options.UseFont = true;
            this.grdDHChuaGiao.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDHChuaGiao.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDHChuaGiao.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDHChuaGiao.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDHChuaGiao.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdDHChuaGiao.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.grdDHChuaGiao.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.grdDHChuaGiao.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDHChuaGiao.Appearance.HorzLine.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grdDHChuaGiao.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.OddRow.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.OddRow.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grdDHChuaGiao.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.grdDHChuaGiao.Appearance.Preview.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.Preview.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdDHChuaGiao.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grdDHChuaGiao.Appearance.Row.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.Row.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grdDHChuaGiao.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.grdDHChuaGiao.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdDHChuaGiao.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdDHChuaGiao.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdDHChuaGiao.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDHChuaGiao.Appearance.VertLine.Options.UseBackColor = true;
            this.grdDHChuaGiao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.madh,
            this.tinhtrang,
            this.tenkh,
            this.tennn,
            this.cuocphi,
            this.thoihangiao,
            this.mota});
            this.grdDHChuaGiao.GridControl = this.grdCTDSDHChuaGiao;
            this.grdDHChuaGiao.Name = "grdDHChuaGiao";
            this.grdDHChuaGiao.OptionsView.EnableAppearanceEvenRow = true;
            this.grdDHChuaGiao.OptionsView.EnableAppearanceOddRow = true;
            this.grdDHChuaGiao.PaintStyleName = "Web";
            // 
            // madh
            // 
            this.madh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.madh.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.madh.AppearanceCell.Options.UseFont = true;
            this.madh.AppearanceCell.Options.UseForeColor = true;
            this.madh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.madh.AppearanceHeader.Options.UseFont = true;
            this.madh.AppearanceHeader.Options.UseTextOptions = true;
            this.madh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.madh.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.madh.Caption = "Mã đơn hàng";
            this.madh.FieldName = "madh";
            this.madh.MinWidth = 25;
            this.madh.Name = "madh";
            this.madh.Visible = true;
            this.madh.VisibleIndex = 0;
            this.madh.Width = 94;
            // 
            // tinhtrang
            // 
            this.tinhtrang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tinhtrang.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.tinhtrang.AppearanceCell.Options.UseFont = true;
            this.tinhtrang.AppearanceCell.Options.UseForeColor = true;
            this.tinhtrang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tinhtrang.AppearanceHeader.Options.UseFont = true;
            this.tinhtrang.AppearanceHeader.Options.UseTextOptions = true;
            this.tinhtrang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tinhtrang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tinhtrang.Caption = "Tình trạng";
            this.tinhtrang.FieldName = "tinhtrang";
            this.tinhtrang.MinWidth = 25;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Visible = true;
            this.tinhtrang.VisibleIndex = 1;
            this.tinhtrang.Width = 94;
            // 
            // tenkh
            // 
            this.tenkh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tenkh.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.tenkh.AppearanceCell.Options.UseFont = true;
            this.tenkh.AppearanceCell.Options.UseForeColor = true;
            this.tenkh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tenkh.AppearanceHeader.Options.UseFont = true;
            this.tenkh.AppearanceHeader.Options.UseTextOptions = true;
            this.tenkh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tenkh.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tenkh.Caption = "Tên người gửi";
            this.tenkh.FieldName = "tenkh";
            this.tenkh.MinWidth = 25;
            this.tenkh.Name = "tenkh";
            this.tenkh.Visible = true;
            this.tenkh.VisibleIndex = 2;
            this.tenkh.Width = 94;
            // 
            // tennn
            // 
            this.tennn.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tennn.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.tennn.AppearanceCell.Options.UseFont = true;
            this.tennn.AppearanceCell.Options.UseForeColor = true;
            this.tennn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tennn.AppearanceHeader.Options.UseFont = true;
            this.tennn.AppearanceHeader.Options.UseTextOptions = true;
            this.tennn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tennn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tennn.Caption = "Tên người nhận";
            this.tennn.FieldName = "tennn";
            this.tennn.MinWidth = 25;
            this.tennn.Name = "tennn";
            this.tennn.Visible = true;
            this.tennn.VisibleIndex = 3;
            this.tennn.Width = 94;
            // 
            // cuocphi
            // 
            this.cuocphi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cuocphi.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.cuocphi.AppearanceCell.Options.UseFont = true;
            this.cuocphi.AppearanceCell.Options.UseForeColor = true;
            this.cuocphi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cuocphi.AppearanceHeader.Options.UseFont = true;
            this.cuocphi.AppearanceHeader.Options.UseTextOptions = true;
            this.cuocphi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cuocphi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cuocphi.Caption = "Cước phí (VNĐ)";
            this.cuocphi.FieldName = "cuocphi";
            this.cuocphi.MinWidth = 25;
            this.cuocphi.Name = "cuocphi";
            this.cuocphi.Visible = true;
            this.cuocphi.VisibleIndex = 4;
            this.cuocphi.Width = 94;
            // 
            // thoihangiao
            // 
            this.thoihangiao.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.thoihangiao.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.thoihangiao.AppearanceCell.Options.UseFont = true;
            this.thoihangiao.AppearanceCell.Options.UseForeColor = true;
            this.thoihangiao.AppearanceCell.Options.UseTextOptions = true;
            this.thoihangiao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thoihangiao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thoihangiao.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.thoihangiao.AppearanceHeader.Options.UseFont = true;
            this.thoihangiao.AppearanceHeader.Options.UseTextOptions = true;
            this.thoihangiao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thoihangiao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thoihangiao.Caption = "Thời hạng giao";
            this.thoihangiao.FieldName = "thoihangiao";
            this.thoihangiao.MinWidth = 25;
            this.thoihangiao.Name = "thoihangiao";
            this.thoihangiao.Visible = true;
            this.thoihangiao.VisibleIndex = 5;
            this.thoihangiao.Width = 94;
            // 
            // mota
            // 
            this.mota.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.mota.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.mota.AppearanceCell.Options.UseFont = true;
            this.mota.AppearanceCell.Options.UseForeColor = true;
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
            this.mota.VisibleIndex = 6;
            this.mota.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnChonNguoiGiao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 90);
            this.panel1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(638, 17);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(188, 60);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Xem ĐH - NG";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnChonNguoiGiao
            // 
            this.btnChonNguoiGiao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonNguoiGiao.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnChonNguoiGiao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChonNguoiGiao.Appearance.Options.UseBackColor = true;
            this.btnChonNguoiGiao.Appearance.Options.UseFont = true;
            this.btnChonNguoiGiao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChonNguoiGiao.ImageOptions.Image")));
            this.btnChonNguoiGiao.Location = new System.Drawing.Point(843, 17);
            this.btnChonNguoiGiao.Name = "btnChonNguoiGiao";
            this.btnChonNguoiGiao.Size = new System.Drawing.Size(188, 60);
            this.btnChonNguoiGiao.TabIndex = 0;
            this.btnChonNguoiGiao.Text = "Chọn người giao";
            this.btnChonNguoiGiao.Click += new System.EventHandler(this.btnChonNguoiGiao_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTinhTrang);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMoTa);
            this.panel2.Controls.Add(this.txtTHG);
            this.panel2.Controls.Add(this.cboNhanVienGiao);
            this.panel2.Controls.Add(this.txtCuocPhi);
            this.panel2.Controls.Add(this.txtTenNN);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.txtMaDH);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(678, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 630);
            this.panel2.TabIndex = 2;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTinhTrang.Location = new System.Drawing.Point(189, 100);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTinhTrang.Properties.Appearance.Options.UseFont = true;
            this.txtTinhTrang.Properties.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(164, 28);
            this.txtTinhTrang.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(23, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tình trạng:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMoTa.Location = new System.Drawing.Point(189, 502);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMoTa.Properties.Appearance.Options.UseFont = true;
            this.txtMoTa.Properties.ReadOnly = true;
            this.txtMoTa.Size = new System.Drawing.Size(164, 90);
            this.txtMoTa.TabIndex = 27;
            // 
            // txtTHG
            // 
            this.txtTHG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTHG.Location = new System.Drawing.Point(189, 435);
            this.txtTHG.Name = "txtTHG";
            this.txtTHG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTHG.Properties.Appearance.Options.UseFont = true;
            this.txtTHG.Properties.ReadOnly = true;
            this.txtTHG.Size = new System.Drawing.Size(164, 28);
            this.txtTHG.TabIndex = 26;
            // 
            // cboNhanVienGiao
            // 
            this.cboNhanVienGiao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboNhanVienGiao.Location = new System.Drawing.Point(189, 167);
            this.cboNhanVienGiao.Name = "cboNhanVienGiao";
            this.cboNhanVienGiao.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboNhanVienGiao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboNhanVienGiao.Properties.Appearance.Options.UseBackColor = true;
            this.cboNhanVienGiao.Properties.Appearance.Options.UseFont = true;
            this.cboNhanVienGiao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNhanVienGiao.Properties.DropDownRows = 3;
            this.cboNhanVienGiao.Size = new System.Drawing.Size(164, 28);
            this.cboNhanVienGiao.TabIndex = 22;
            // 
            // txtCuocPhi
            // 
            this.txtCuocPhi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCuocPhi.Location = new System.Drawing.Point(189, 368);
            this.txtCuocPhi.Name = "txtCuocPhi";
            this.txtCuocPhi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCuocPhi.Properties.Appearance.Options.UseFont = true;
            this.txtCuocPhi.Properties.ReadOnly = true;
            this.txtCuocPhi.Size = new System.Drawing.Size(164, 28);
            this.txtCuocPhi.TabIndex = 25;
            // 
            // txtTenNN
            // 
            this.txtTenNN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNN.Location = new System.Drawing.Point(189, 301);
            this.txtTenNN.Name = "txtTenNN";
            this.txtTenNN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenNN.Properties.Appearance.Options.UseFont = true;
            this.txtTenNN.Properties.ReadOnly = true;
            this.txtTenNN.Size = new System.Drawing.Size(164, 28);
            this.txtTenNN.TabIndex = 24;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKH.Location = new System.Drawing.Point(189, 234);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenKH.Properties.Appearance.Options.UseFont = true;
            this.txtTenKH.Properties.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(164, 28);
            this.txtTenKH.TabIndex = 23;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaDH.Location = new System.Drawing.Point(189, 33);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaDH.Properties.Appearance.Options.UseFont = true;
            this.txtMaDH.Properties.ReadOnly = true;
            this.txtMaDH.Size = new System.Drawing.Size(164, 28);
            this.txtMaDH.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(23, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(23, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Thời hạng giao:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(23, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cước phí:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(23, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên người nhận:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(23, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên người gửi:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(23, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chọn nhân viên giao:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã đơn hàng: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grDSDH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 630);
            this.panel3.TabIndex = 3;
            // 
            // UCChonNVGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCChonNVGiaoHang";
            this.Size = new System.Drawing.Size(1060, 720);
            ((System.ComponentModel.ISupportInitialize)(this.grDSDH)).EndInit();
            this.grDSDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCTDSDHChuaGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDHChuaGiao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTHG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhanVienGiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDH.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grDSDH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnChonNguoiGiao;
        private DevExpress.XtraGrid.GridControl grdCTDSDHChuaGiao;
        private DevExpress.XtraGrid.Views.Grid.GridView grdDHChuaGiao;
        private DevExpress.XtraGrid.Columns.GridColumn madh;
        private DevExpress.XtraGrid.Columns.GridColumn tinhtrang;
        private DevExpress.XtraGrid.Columns.GridColumn tenkh;
        private DevExpress.XtraGrid.Columns.GridColumn tennn;
        private DevExpress.XtraGrid.Columns.GridColumn cuocphi;
        private DevExpress.XtraGrid.Columns.GridColumn thoihangiao;
        private DevExpress.XtraGrid.Columns.GridColumn mota;
        private DevExpress.XtraEditors.MemoEdit txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtTHG;
        private DevExpress.XtraEditors.ComboBoxEdit cboNhanVienGiao;
        private DevExpress.XtraEditors.TextEdit txtCuocPhi;
        private DevExpress.XtraEditors.TextEdit txtTenNN;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.TextEdit txtMaDH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTinhTrang;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
