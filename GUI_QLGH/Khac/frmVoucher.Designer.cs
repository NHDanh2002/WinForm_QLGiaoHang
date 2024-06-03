
namespace GUI_QLGH.Khac
{
    partial class frmVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoucher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlDSVoucher = new DevExpress.XtraGrid.GridControl();
            this.grdDSVoucher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mavoucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenvoucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manguoilap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngaytao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thoihang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThoiHang = new DevExpress.XtraEditors.TextEdit();
            this.txtTenVC = new DevExpress.XtraEditors.TextEdit();
            this.txtMaVC = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaNV = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlDSVoucher);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 485);
            this.panel1.TabIndex = 0;
            // 
            // gridControlDSVoucher
            // 
            this.gridControlDSVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDSVoucher.Location = new System.Drawing.Point(0, 0);
            this.gridControlDSVoucher.MainView = this.grdDSVoucher;
            this.gridControlDSVoucher.Name = "gridControlDSVoucher";
            this.gridControlDSVoucher.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gridControlDSVoucher.Size = new System.Drawing.Size(628, 485);
            this.gridControlDSVoucher.TabIndex = 1;
            this.gridControlDSVoucher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdDSVoucher});
            // 
            // grdDSVoucher
            // 
            this.grdDSVoucher.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSVoucher.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSVoucher.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSVoucher.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSVoucher.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grdDSVoucher.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDSVoucher.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.grdDSVoucher.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDSVoucher.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSVoucher.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grdDSVoucher.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.grdDSVoucher.Appearance.Empty.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.grdDSVoucher.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.EvenRow.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSVoucher.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSVoucher.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSVoucher.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSVoucher.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grdDSVoucher.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDSVoucher.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.grdDSVoucher.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.grdDSVoucher.Appearance.FixedLine.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grdDSVoucher.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.grdDSVoucher.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdDSVoucher.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSVoucher.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSVoucher.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSVoucher.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSVoucher.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdDSVoucher.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSVoucher.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSVoucher.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.GroupButton.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grdDSVoucher.Appearance.GroupButton.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSVoucher.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSVoucher.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grdDSVoucher.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDSVoucher.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSVoucher.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSVoucher.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSVoucher.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grdDSVoucher.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grdDSVoucher.Appearance.GroupRow.Options.UseFont = true;
            this.grdDSVoucher.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSVoucher.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSVoucher.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSVoucher.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSVoucher.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdDSVoucher.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.grdDSVoucher.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.grdDSVoucher.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDSVoucher.Appearance.HorzLine.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grdDSVoucher.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.OddRow.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.OddRow.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grdDSVoucher.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.grdDSVoucher.Appearance.Preview.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.Preview.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdDSVoucher.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grdDSVoucher.Appearance.Row.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.Row.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grdDSVoucher.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.grdDSVoucher.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdDSVoucher.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdDSVoucher.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdDSVoucher.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDSVoucher.Appearance.VertLine.Options.UseBackColor = true;
            this.grdDSVoucher.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grdDSVoucher.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mavoucher,
            this.tenvoucher,
            this.manguoilap,
            this.ngaytao,
            this.thoihang});
            this.grdDSVoucher.GridControl = this.gridControlDSVoucher;
            this.grdDSVoucher.Name = "grdDSVoucher";
            this.grdDSVoucher.OptionsView.EnableAppearanceEvenRow = true;
            this.grdDSVoucher.OptionsView.EnableAppearanceOddRow = true;
            this.grdDSVoucher.PaintStyleName = "Web";
            // 
            // mavoucher
            // 
            this.mavoucher.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mavoucher.AppearanceCell.Options.UseFont = true;
            this.mavoucher.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.mavoucher.AppearanceHeader.Options.UseFont = true;
            this.mavoucher.AppearanceHeader.Options.UseTextOptions = true;
            this.mavoucher.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mavoucher.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mavoucher.Caption = "Mã Voucher";
            this.mavoucher.FieldName = "mavoucher";
            this.mavoucher.MinWidth = 25;
            this.mavoucher.Name = "mavoucher";
            this.mavoucher.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.mavoucher.Visible = true;
            this.mavoucher.VisibleIndex = 0;
            this.mavoucher.Width = 93;
            // 
            // tenvoucher
            // 
            this.tenvoucher.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tenvoucher.AppearanceCell.Options.UseFont = true;
            this.tenvoucher.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tenvoucher.AppearanceHeader.Options.UseFont = true;
            this.tenvoucher.AppearanceHeader.Options.UseTextOptions = true;
            this.tenvoucher.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tenvoucher.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tenvoucher.Caption = "Tên Voucher";
            this.tenvoucher.FieldName = "tenvoucher";
            this.tenvoucher.MinWidth = 25;
            this.tenvoucher.Name = "tenvoucher";
            this.tenvoucher.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.tenvoucher.Visible = true;
            this.tenvoucher.VisibleIndex = 1;
            this.tenvoucher.Width = 74;
            // 
            // manguoilap
            // 
            this.manguoilap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.manguoilap.AppearanceCell.Options.UseFont = true;
            this.manguoilap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.manguoilap.AppearanceHeader.Options.UseFont = true;
            this.manguoilap.AppearanceHeader.Options.UseTextOptions = true;
            this.manguoilap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.manguoilap.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.manguoilap.Caption = "Mã người lập";
            this.manguoilap.FieldName = "manguoilap";
            this.manguoilap.MinWidth = 25;
            this.manguoilap.Name = "manguoilap";
            this.manguoilap.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.manguoilap.Visible = true;
            this.manguoilap.VisibleIndex = 2;
            this.manguoilap.Width = 74;
            // 
            // ngaytao
            // 
            this.ngaytao.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ngaytao.AppearanceCell.Options.UseFont = true;
            this.ngaytao.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ngaytao.AppearanceHeader.Options.UseFont = true;
            this.ngaytao.AppearanceHeader.Options.UseTextOptions = true;
            this.ngaytao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngaytao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ngaytao.Caption = "Ngày tạo";
            this.ngaytao.FieldName = "ngaytao";
            this.ngaytao.MinWidth = 25;
            this.ngaytao.Name = "ngaytao";
            this.ngaytao.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.ngaytao.Visible = true;
            this.ngaytao.VisibleIndex = 3;
            this.ngaytao.Width = 74;
            // 
            // thoihang
            // 
            this.thoihang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.thoihang.AppearanceCell.Options.UseFont = true;
            this.thoihang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.thoihang.AppearanceHeader.Options.UseFont = true;
            this.thoihang.AppearanceHeader.Options.UseTextOptions = true;
            this.thoihang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thoihang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.thoihang.Caption = "Thời hạng";
            this.thoihang.FieldName = "thoihang";
            this.thoihang.MinWidth = 25;
            this.thoihang.Name = "thoihang";
            this.thoihang.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.thoihang.Visible = true;
            this.thoihang.VisibleIndex = 4;
            this.thoihang.Width = 74;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnExport.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnExport.Appearance.Options.UseBackColor = true;
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(472, 23);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 51);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(880, 23);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 51);
            this.btnXoa.TabIndex = 7;
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
            this.btnSua.Location = new System.Drawing.Point(744, 23);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 51);
            this.btnSua.TabIndex = 6;
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
            this.btnThem.Location = new System.Drawing.Point(608, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 51);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboMaNV);
            this.panel3.Controls.Add(this.dtpNgayTao);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtThoiHang);
            this.panel3.Controls.Add(this.txtTenVC);
            this.panel3.Controls.Add(this.txtMaVC);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(628, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 485);
            this.panel3.TabIndex = 1;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(159, 206);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(176, 28);
            this.dtpNgayTao.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã voucher:";
            // 
            // txtThoiHang
            // 
            this.txtThoiHang.Location = new System.Drawing.Point(159, 262);
            this.txtThoiHang.Name = "txtThoiHang";
            this.txtThoiHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtThoiHang.Properties.Appearance.Options.UseFont = true;
            this.txtThoiHang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtThoiHang.Size = new System.Drawing.Size(176, 30);
            this.txtThoiHang.TabIndex = 29;
            // 
            // txtTenVC
            // 
            this.txtTenVC.Location = new System.Drawing.Point(155, 96);
            this.txtTenVC.Name = "txtTenVC";
            this.txtTenVC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenVC.Properties.Appearance.Options.UseFont = true;
            this.txtTenVC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtTenVC.Size = new System.Drawing.Size(176, 30);
            this.txtTenVC.TabIndex = 26;
            // 
            // txtMaVC
            // 
            this.txtMaVC.Location = new System.Drawing.Point(158, 38);
            this.txtMaVC.Name = "txtMaVC";
            this.txtMaVC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaVC.Properties.Appearance.Options.UseFont = true;
            this.txtMaVC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMaVC.Properties.ReadOnly = true;
            this.txtMaVC.Size = new System.Drawing.Size(176, 30);
            this.txtMaVC.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(30, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thời hạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(30, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày tạo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(30, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã người lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên voucher:";
            // 
            // cboMaNV
            // 
            this.cboMaNV.Location = new System.Drawing.Point(159, 153);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboMaNV.Properties.Appearance.Options.UseFont = true;
            this.cboMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaNV.Size = new System.Drawing.Size(176, 28);
            this.cboMaNV.TabIndex = 34;
            // 
            // frmVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmVoucher";
            this.Size = new System.Drawing.Size(998, 585);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenVC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gridControlDSVoucher;
        private DevExpress.XtraGrid.Views.Grid.GridView grdDSVoucher;
        private DevExpress.XtraGrid.Columns.GridColumn mavoucher;
        private DevExpress.XtraGrid.Columns.GridColumn tenvoucher;
        private DevExpress.XtraGrid.Columns.GridColumn manguoilap;
        private DevExpress.XtraGrid.Columns.GridColumn ngaytao;
        private DevExpress.XtraGrid.Columns.GridColumn thoihang;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtThoiHang;
        private DevExpress.XtraEditors.TextEdit txtTenVC;
        private DevExpress.XtraEditors.TextEdit txtMaVC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private DevExpress.XtraEditors.ComboBoxEdit cboMaNV;
    }
}
