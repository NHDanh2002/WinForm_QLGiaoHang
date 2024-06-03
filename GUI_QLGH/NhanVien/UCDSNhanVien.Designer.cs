
namespace GUI_QLGH.NhanVien
{
    partial class UCDSNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDSNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdControlDSNV = new DevExpress.XtraGrid.GridControl();
            this.grdDSNV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maloainv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tennv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thongtinkhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picAva = new DevExpress.XtraEditors.PictureEdit();
            this.cboLoaiNV = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThongTinKhac = new DevExpress.XtraEditors.MemoEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSNV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThongTinKhac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdControlDSNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 513);
            this.panel1.TabIndex = 0;
            // 
            // grdControlDSNV
            // 
            this.grdControlDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControlDSNV.Location = new System.Drawing.Point(0, 0);
            this.grdControlDSNV.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.grdControlDSNV.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdControlDSNV.MainView = this.grdDSNV;
            this.grdControlDSNV.Name = "grdControlDSNV";
            this.grdControlDSNV.Size = new System.Drawing.Size(452, 513);
            this.grdControlDSNV.TabIndex = 1;
            this.grdControlDSNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdDSNV});
            // 
            // grdDSNV
            // 
            this.grdDSNV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSNV.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSNV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSNV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSNV.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grdDSNV.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grdDSNV.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grdDSNV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDSNV.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.grdDSNV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDSNV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSNV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grdDSNV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grdDSNV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grdDSNV.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.grdDSNV.Appearance.Empty.Options.UseBackColor = true;
            this.grdDSNV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.grdDSNV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdDSNV.Appearance.EvenRow.Options.UseForeColor = true;
            this.grdDSNV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSNV.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSNV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSNV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSNV.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grdDSNV.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grdDSNV.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grdDSNV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDSNV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.grdDSNV.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grdDSNV.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grdDSNV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.grdDSNV.Appearance.FixedLine.Options.UseBackColor = true;
            this.grdDSNV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grdDSNV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdDSNV.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grdDSNV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.grdDSNV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdDSNV.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdDSNV.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdDSNV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSNV.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSNV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSNV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSNV.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdDSNV.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdDSNV.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdDSNV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSNV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSNV.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.GroupButton.Options.UseBackColor = true;
            this.grdDSNV.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grdDSNV.Appearance.GroupButton.Options.UseForeColor = true;
            this.grdDSNV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSNV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSNV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdDSNV.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grdDSNV.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grdDSNV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grdDSNV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSNV.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdDSNV.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdDSNV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSNV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grdDSNV.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grdDSNV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdDSNV.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grdDSNV.Appearance.GroupRow.Options.UseFont = true;
            this.grdDSNV.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdDSNV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSNV.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grdDSNV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grdDSNV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grdDSNV.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdDSNV.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdDSNV.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdDSNV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.grdDSNV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.grdDSNV.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdDSNV.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grdDSNV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDSNV.Appearance.HorzLine.Options.UseBackColor = true;
            this.grdDSNV.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grdDSNV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.OddRow.Options.UseBackColor = true;
            this.grdDSNV.Appearance.OddRow.Options.UseForeColor = true;
            this.grdDSNV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grdDSNV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.grdDSNV.Appearance.Preview.Options.UseBackColor = true;
            this.grdDSNV.Appearance.Preview.Options.UseForeColor = true;
            this.grdDSNV.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdDSNV.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grdDSNV.Appearance.Row.Options.UseBackColor = true;
            this.grdDSNV.Appearance.Row.Options.UseForeColor = true;
            this.grdDSNV.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grdDSNV.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grdDSNV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.grdDSNV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdDSNV.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdDSNV.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdDSNV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grdDSNV.Appearance.VertLine.Options.UseBackColor = true;
            this.grdDSNV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.manv,
            this.maloainv,
            this.tennv,
            this.sdt,
            this.email,
            this.thongtinkhac});
            this.grdDSNV.GridControl = this.grdControlDSNV;
            this.grdDSNV.Name = "grdDSNV";
            this.grdDSNV.OptionsView.EnableAppearanceEvenRow = true;
            this.grdDSNV.OptionsView.EnableAppearanceOddRow = true;
            this.grdDSNV.PaintStyleName = "Flat";
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
            this.manv.Visible = true;
            this.manv.VisibleIndex = 0;
            this.manv.Width = 94;
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
            this.maloainv.Caption = "Loại nhân viên";
            this.maloainv.FieldName = "maloainv";
            this.maloainv.MinWidth = 25;
            this.maloainv.Name = "maloainv";
            this.maloainv.Visible = true;
            this.maloainv.VisibleIndex = 1;
            this.maloainv.Width = 94;
            // 
            // tennv
            // 
            this.tennv.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tennv.AppearanceCell.Options.UseFont = true;
            this.tennv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tennv.AppearanceHeader.Options.UseFont = true;
            this.tennv.AppearanceHeader.Options.UseTextOptions = true;
            this.tennv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tennv.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tennv.Caption = "Tên nhân viên";
            this.tennv.FieldName = "tennv";
            this.tennv.MinWidth = 25;
            this.tennv.Name = "tennv";
            this.tennv.Visible = true;
            this.tennv.VisibleIndex = 2;
            this.tennv.Width = 94;
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
            this.sdt.VisibleIndex = 3;
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
            this.email.VisibleIndex = 4;
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
            this.thongtinkhac.VisibleIndex = 5;
            this.thongtinkhac.Width = 94;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChonAnh);
            this.panel2.Controls.Add(this.picAva);
            this.panel2.Controls.Add(this.cboLoaiNV);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtThongTinKhac);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.txtTenNV);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(452, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 513);
            this.panel2.TabIndex = 1;
            // 
            // picAva
            // 
            this.picAva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAva.Location = new System.Drawing.Point(303, 45);
            this.picAva.Name = "picAva";
            this.picAva.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAva.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picAva.Size = new System.Drawing.Size(172, 171);
            this.picAva.TabIndex = 24;
            // 
            // cboLoaiNV
            // 
            this.cboLoaiNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLoaiNV.Location = new System.Drawing.Point(177, 95);
            this.cboLoaiNV.Name = "cboLoaiNV";
            this.cboLoaiNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboLoaiNV.Properties.Appearance.Options.UseFont = true;
            this.cboLoaiNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiNV.Size = new System.Drawing.Size(120, 28);
            this.cboLoaiNV.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Loại nhân viên:";
            // 
            // txtThongTinKhac
            // 
            this.txtThongTinKhac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThongTinKhac.Location = new System.Drawing.Point(177, 377);
            this.txtThongTinKhac.Name = "txtThongTinKhac";
            this.txtThongTinKhac.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtThongTinKhac.Properties.Appearance.Options.UseFont = true;
            this.txtThongTinKhac.Size = new System.Drawing.Size(298, 117);
            this.txtThongTinKhac.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(177, 331);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(298, 28);
            this.txtEmail.TabIndex = 20;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSDT.Location = new System.Drawing.Point(177, 287);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(147, 28);
            this.txtSDT.TabIndex = 19;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNV.Location = new System.Drawing.Point(177, 243);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenNV.Properties.Appearance.Options.UseFont = true;
            this.txtTenNV.Size = new System.Drawing.Size(298, 28);
            this.txtTenNV.TabIndex = 18;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNV.Location = new System.Drawing.Point(177, 45);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(120, 28);
            this.txtMaNV.TabIndex = 17;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(16, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Thông tin khác:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã nhân viên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReport);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 100);
            this.panel3.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnReport.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReport.Appearance.Options.UseBackColor = true;
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.Location = new System.Drawing.Point(349, 28);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(101, 48);
            this.btnReport.TabIndex = 9;
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
            this.btnExport.Location = new System.Drawing.Point(468, 28);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 48);
            this.btnExport.TabIndex = 8;
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
            this.btnThem.Location = new System.Drawing.Point(587, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 48);
            this.btnThem.TabIndex = 7;
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
            this.btnSua.Location = new System.Drawing.Point(706, 28);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 48);
            this.btnSua.TabIndex = 6;
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
            this.btnXoa.Location = new System.Drawing.Point(825, 28);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 48);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonAnh.Location = new System.Drawing.Point(267, 193);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(30, 23);
            this.btnChonAnh.TabIndex = 25;
            this.btnChonAnh.Text = "...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // UCDSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "UCDSNhanVien";
            this.Size = new System.Drawing.Size(944, 613);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdControlDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSNV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThongTinKhac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl grdControlDSNV;
        private DevExpress.XtraGrid.Views.Grid.GridView grdDSNV;
        private DevExpress.XtraGrid.Columns.GridColumn manv;
        private DevExpress.XtraGrid.Columns.GridColumn maloainv;
        private DevExpress.XtraGrid.Columns.GridColumn tennv;
        private DevExpress.XtraGrid.Columns.GridColumn sdt;
        private DevExpress.XtraGrid.Columns.GridColumn email;
        private DevExpress.XtraGrid.Columns.GridColumn thongtinkhac;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.ComboBoxEdit cboLoaiNV;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.MemoEdit txtThongTinKhac;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit picAva;
        private System.Windows.Forms.Button btnChonAnh;
    }
}
