
namespace GUI_QLGH
{
    partial class DSDonHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSDonHang));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlDSDH = new DevExpress.XtraGrid.GridControl();
            this.grdDSDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.madh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.makh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manguoinhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cuocphi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khoiluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thoihangiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThoiHangGiao = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoiLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtCuocPhi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNN = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDH = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiHangGiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoiLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlDSDH);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(983, 507);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControlDSDH
            // 
            this.gridControlDSDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDSDH.Location = new System.Drawing.Point(2, 2);
            this.gridControlDSDH.MainView = this.grdDSDH;
            this.gridControlDSDH.Name = "gridControlDSDH";
            this.gridControlDSDH.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gridControlDSDH.Size = new System.Drawing.Size(619, 503);
            this.gridControlDSDH.TabIndex = 0;
            this.gridControlDSDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdDSDH});
            // 
            // grdDSDH
            // 
            this.grdDSDH.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSDH.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSDH.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSDH.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSDH.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grdDSDH.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grdDSDH.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grdDSDH.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDSDH.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.grdDSDH.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDSDH.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSDH.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grdDSDH.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grdDSDH.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grdDSDH.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.grdDSDH.Appearance.Empty.Options.UseBackColor = true;
            this.grdDSDH.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.grdDSDH.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdDSDH.Appearance.EvenRow.Options.UseForeColor = true;
            this.grdDSDH.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSDH.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSDH.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSDH.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSDH.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grdDSDH.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grdDSDH.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grdDSDH.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDSDH.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.grdDSDH.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grdDSDH.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grdDSDH.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.grdDSDH.Appearance.FixedLine.Options.UseBackColor = true;
            this.grdDSDH.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grdDSDH.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdDSDH.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grdDSDH.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.grdDSDH.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdDSDH.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdDSDH.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdDSDH.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSDH.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSDH.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSDH.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSDH.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdDSDH.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdDSDH.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdDSDH.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSDH.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSDH.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.GroupButton.Options.UseBackColor = true;
            this.grdDSDH.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grdDSDH.Appearance.GroupButton.Options.UseForeColor = true;
            this.grdDSDH.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSDH.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSDH.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdDSDH.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grdDSDH.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grdDSDH.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDSDH.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSDH.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdDSDH.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdDSDH.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSDH.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSDH.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grdDSDH.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdDSDH.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grdDSDH.Appearance.GroupRow.Options.UseFont = true;
            this.grdDSDH.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdDSDH.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSDH.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSDH.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSDH.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSDH.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdDSDH.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdDSDH.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdDSDH.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.grdDSDH.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.grdDSDH.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdDSDH.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grdDSDH.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDSDH.Appearance.HorzLine.Options.UseBackColor = true;
            this.grdDSDH.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grdDSDH.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.OddRow.Options.UseBackColor = true;
            this.grdDSDH.Appearance.OddRow.Options.UseForeColor = true;
            this.grdDSDH.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grdDSDH.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.grdDSDH.Appearance.Preview.Options.UseBackColor = true;
            this.grdDSDH.Appearance.Preview.Options.UseForeColor = true;
            this.grdDSDH.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdDSDH.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grdDSDH.Appearance.Row.Options.UseBackColor = true;
            this.grdDSDH.Appearance.Row.Options.UseForeColor = true;
            this.grdDSDH.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grdDSDH.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grdDSDH.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.grdDSDH.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdDSDH.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdDSDH.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdDSDH.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDSDH.Appearance.VertLine.Options.UseBackColor = true;
            this.grdDSDH.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grdDSDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.madh,
            this.makh,
            this.manguoinhan,
            this.manv,
            this.cuocphi,
            this.khoiluong,
            this.thoihangiao,
            this.ghichu});
            this.grdDSDH.GridControl = this.gridControlDSDH;
            this.grdDSDH.Name = "grdDSDH";
            this.grdDSDH.OptionsView.EnableAppearanceEvenRow = true;
            this.grdDSDH.OptionsView.EnableAppearanceOddRow = true;
            this.grdDSDH.PaintStyleName = "Web";
            // 
            // madh
            // 
            this.madh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madh.AppearanceCell.Options.UseFont = true;
            this.madh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.madh.AppearanceHeader.Options.UseFont = true;
            this.madh.AppearanceHeader.Options.UseTextOptions = true;
            this.madh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.madh.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.madh.Caption = "Mã đơn hàng";
            this.madh.FieldName = "madh";
            this.madh.MinWidth = 25;
            this.madh.Name = "madh";
            this.madh.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.madh.Visible = true;
            this.madh.VisibleIndex = 0;
            this.madh.Width = 93;
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
            this.makh.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.makh.Visible = true;
            this.makh.VisibleIndex = 1;
            this.makh.Width = 74;
            // 
            // manguoinhan
            // 
            this.manguoinhan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.manguoinhan.AppearanceCell.Options.UseFont = true;
            this.manguoinhan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.manguoinhan.AppearanceHeader.Options.UseFont = true;
            this.manguoinhan.AppearanceHeader.Options.UseTextOptions = true;
            this.manguoinhan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.manguoinhan.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.manguoinhan.Caption = "Mã người nhận";
            this.manguoinhan.FieldName = "manguoinhan";
            this.manguoinhan.MinWidth = 25;
            this.manguoinhan.Name = "manguoinhan";
            this.manguoinhan.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.manguoinhan.Visible = true;
            this.manguoinhan.VisibleIndex = 2;
            this.manguoinhan.Width = 74;
            // 
            // manv
            // 
            this.manv.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.manv.AppearanceCell.Options.UseFont = true;
            this.manv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.manv.AppearanceHeader.Options.UseFont = true;
            this.manv.AppearanceHeader.Options.UseTextOptions = true;
            this.manv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.manv.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.manv.Caption = "Mã nhân viên";
            this.manv.FieldName = "manv";
            this.manv.MinWidth = 25;
            this.manv.Name = "manv";
            this.manv.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.manv.Visible = true;
            this.manv.VisibleIndex = 3;
            this.manv.Width = 74;
            // 
            // cuocphi
            // 
            this.cuocphi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cuocphi.AppearanceCell.Options.UseFont = true;
            this.cuocphi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cuocphi.AppearanceHeader.Options.UseFont = true;
            this.cuocphi.AppearanceHeader.Options.UseTextOptions = true;
            this.cuocphi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cuocphi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cuocphi.Caption = "Cước phí (VNĐ)";
            this.cuocphi.FieldName = "cuocphi";
            this.cuocphi.MinWidth = 25;
            this.cuocphi.Name = "cuocphi";
            this.cuocphi.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.cuocphi.Visible = true;
            this.cuocphi.VisibleIndex = 4;
            this.cuocphi.Width = 74;
            // 
            // khoiluong
            // 
            this.khoiluong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.khoiluong.AppearanceCell.Options.UseFont = true;
            this.khoiluong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.khoiluong.AppearanceHeader.Options.UseFont = true;
            this.khoiluong.AppearanceHeader.Options.UseTextOptions = true;
            this.khoiluong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.khoiluong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.khoiluong.Caption = "Khối lượng (kg)";
            this.khoiluong.FieldName = "khoiluong";
            this.khoiluong.MinWidth = 25;
            this.khoiluong.Name = "khoiluong";
            this.khoiluong.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.khoiluong.Visible = true;
            this.khoiluong.VisibleIndex = 5;
            this.khoiluong.Width = 74;
            // 
            // thoihangiao
            // 
            this.thoihangiao.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.thoihangiao.AppearanceCell.Options.UseFont = true;
            this.thoihangiao.AppearanceCell.Options.UseTextOptions = true;
            this.thoihangiao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thoihangiao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thoihangiao.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.thoihangiao.AppearanceHeader.Options.UseFont = true;
            this.thoihangiao.AppearanceHeader.Options.UseTextOptions = true;
            this.thoihangiao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thoihangiao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thoihangiao.Caption = "Thời gian giao";
            this.thoihangiao.FieldName = "thoihangiao";
            this.thoihangiao.MinWidth = 25;
            this.thoihangiao.Name = "thoihangiao";
            this.thoihangiao.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.thoihangiao.Visible = true;
            this.thoihangiao.VisibleIndex = 6;
            this.thoihangiao.Width = 74;
            // 
            // ghichu
            // 
            this.ghichu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ghichu.AppearanceCell.Options.UseFont = true;
            this.ghichu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ghichu.AppearanceHeader.Options.UseFont = true;
            this.ghichu.AppearanceHeader.Options.UseTextOptions = true;
            this.ghichu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ghichu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ghichu.Caption = "Ghi Chú";
            this.ghichu.FieldName = "ghichu";
            this.ghichu.MinWidth = 25;
            this.ghichu.Name = "ghichu";
            this.ghichu.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ghichu.Visible = true;
            this.ghichu.VisibleIndex = 7;
            this.ghichu.Width = 93;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtThoiHangGiao);
            this.panel1.Controls.Add(this.txtKhoiLuong);
            this.panel1.Controls.Add(this.txtCuocPhi);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtMaNN);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.txtMaDH);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(621, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 503);
            this.panel1.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(144, 411);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtGhiChu.Size = new System.Drawing.Size(176, 88);
            this.txtGhiChu.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã đơn hàng:";
            // 
            // txtThoiHangGiao
            // 
            this.txtThoiHangGiao.Location = new System.Drawing.Point(144, 355);
            this.txtThoiHangGiao.Name = "txtThoiHangGiao";
            this.txtThoiHangGiao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtThoiHangGiao.Properties.Appearance.Options.UseFont = true;
            this.txtThoiHangGiao.Properties.Appearance.Options.UseTextOptions = true;
            this.txtThoiHangGiao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtThoiHangGiao.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtThoiHangGiao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtThoiHangGiao.Size = new System.Drawing.Size(176, 30);
            this.txtThoiHangGiao.TabIndex = 14;
            // 
            // txtKhoiLuong
            // 
            this.txtKhoiLuong.Location = new System.Drawing.Point(144, 299);
            this.txtKhoiLuong.Name = "txtKhoiLuong";
            this.txtKhoiLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtKhoiLuong.Properties.Appearance.Options.UseFont = true;
            this.txtKhoiLuong.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKhoiLuong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKhoiLuong.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtKhoiLuong.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtKhoiLuong.Size = new System.Drawing.Size(176, 30);
            this.txtKhoiLuong.TabIndex = 13;
            // 
            // txtCuocPhi
            // 
            this.txtCuocPhi.Location = new System.Drawing.Point(144, 243);
            this.txtCuocPhi.Name = "txtCuocPhi";
            this.txtCuocPhi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCuocPhi.Properties.Appearance.Options.UseFont = true;
            this.txtCuocPhi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCuocPhi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCuocPhi.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtCuocPhi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtCuocPhi.Size = new System.Drawing.Size(176, 30);
            this.txtCuocPhi.TabIndex = 12;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(144, 187);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaNV.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaNV.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaNV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMaNV.Size = new System.Drawing.Size(176, 30);
            this.txtMaNV.TabIndex = 11;
            // 
            // txtMaNN
            // 
            this.txtMaNN.Location = new System.Drawing.Point(144, 131);
            this.txtMaNN.Name = "txtMaNN";
            this.txtMaNN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaNN.Properties.Appearance.Options.UseFont = true;
            this.txtMaNN.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaNN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaNN.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaNN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMaNN.Size = new System.Drawing.Size(176, 30);
            this.txtMaNN.TabIndex = 10;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(144, 75);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaKH.Properties.Appearance.Options.UseFont = true;
            this.txtMaKH.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaKH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaKH.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaKH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMaKH.Size = new System.Drawing.Size(176, 30);
            this.txtMaKH.TabIndex = 9;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(143, 19);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaDH.Properties.Appearance.Options.UseFont = true;
            this.txtMaDH.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaDH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaDH.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaDH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMaDH.Properties.ReadOnly = true;
            this.txtMaDH.Size = new System.Drawing.Size(176, 30);
            this.txtMaDH.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(15, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ghi chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(15, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời hạng giao:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(15, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "khối lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(15, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cước phí:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(15, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã người lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã người nhận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnReport);
            this.panelControl2.Controls.Add(this.btnExport);
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Controls.Add(this.btnSua);
            this.panelControl2.Controls.Add(this.btnThem);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 507);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(983, 100);
            this.panelControl2.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnExport.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnExport.Appearance.Options.UseBackColor = true;
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(456, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 51);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(864, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 51);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(728, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 51);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnThem.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(592, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 51);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnReport.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnReport.Appearance.Options.UseBackColor = true;
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnReport.Location = new System.Drawing.Point(320, 20);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 51);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // DSDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "DSDonHang";
            this.Size = new System.Drawing.Size(983, 607);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiHangGiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoiLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControlDSDH;
        private DevExpress.XtraGrid.Views.Grid.GridView grdDSDH;
        private DevExpress.XtraGrid.Columns.GridColumn madh;
        private DevExpress.XtraGrid.Columns.GridColumn makh;
        private DevExpress.XtraGrid.Columns.GridColumn manguoinhan;
        private DevExpress.XtraGrid.Columns.GridColumn manv;
        private DevExpress.XtraGrid.Columns.GridColumn cuocphi;
        private DevExpress.XtraGrid.Columns.GridColumn khoiluong;
        private DevExpress.XtraGrid.Columns.GridColumn thoihangiao;
        private DevExpress.XtraGrid.Columns.GridColumn ghichu;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtThoiHangGiao;
        private DevExpress.XtraEditors.TextEdit txtKhoiLuong;
        private DevExpress.XtraEditors.TextEdit txtCuocPhi;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtMaNN;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.TextEdit txtMaDH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnReport;
    }
}
