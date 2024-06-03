
namespace GUI_QLGH.DonHang
{
    partial class frmDHDangGiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDHDangGiao));
            this.grdCTDSDH = new DevExpress.XtraGrid.GridControl();
            this.grdDSDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.madh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tinhtrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tennv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCTDSDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSDH)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCTDSDH
            // 
            this.grdCTDSDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCTDSDH.Location = new System.Drawing.Point(0, 0);
            this.grdCTDSDH.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.grdCTDSDH.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdCTDSDH.MainView = this.grdDSDH;
            this.grdCTDSDH.Name = "grdCTDSDH";
            this.grdCTDSDH.Size = new System.Drawing.Size(973, 566);
            this.grdCTDSDH.TabIndex = 2;
            this.grdCTDSDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.grdDSDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.madh,
            this.manv,
            this.tennv,
            this.tinhtrang,
            this.sdt,
            this.email});
            this.grdDSDH.GridControl = this.grdCTDSDH;
            this.grdDSDH.Name = "grdDSDH";
            this.grdDSDH.OptionsView.EnableAppearanceEvenRow = true;
            this.grdDSDH.OptionsView.EnableAppearanceOddRow = true;
            this.grdDSDH.PaintStyleName = "Web";
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
            this.tinhtrang.VisibleIndex = 3;
            this.tinhtrang.Width = 94;
            // 
            // tennv
            // 
            this.tennv.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tennv.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.tennv.AppearanceCell.Options.UseFont = true;
            this.tennv.AppearanceCell.Options.UseForeColor = true;
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
            // manv
            // 
            this.manv.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.manv.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.manv.AppearanceCell.Options.UseFont = true;
            this.manv.AppearanceCell.Options.UseForeColor = true;
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
            this.manv.VisibleIndex = 1;
            this.manv.Width = 94;
            // 
            // sdt
            // 
            this.sdt.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sdt.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.sdt.AppearanceCell.Options.UseFont = true;
            this.sdt.AppearanceCell.Options.UseForeColor = true;
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
            this.sdt.VisibleIndex = 4;
            this.sdt.Width = 94;
            // 
            // email
            // 
            this.email.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.email.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.email.AppearanceCell.Options.UseFont = true;
            this.email.AppearanceCell.Options.UseForeColor = true;
            this.email.AppearanceCell.Options.UseTextOptions = true;
            this.email.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.email.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
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
            this.email.VisibleIndex = 5;
            this.email.Width = 94;
            // 
            // frmDHDangGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 566);
            this.Controls.Add(this.grdCTDSDH);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmDHDangGiao.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDHDangGiao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đơn hàng đã có người giao";
            ((System.ComponentModel.ISupportInitialize)(this.grdCTDSDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCTDSDH;
        private DevExpress.XtraGrid.Views.Grid.GridView grdDSDH;
        private DevExpress.XtraGrid.Columns.GridColumn madh;
        private DevExpress.XtraGrid.Columns.GridColumn manv;
        private DevExpress.XtraGrid.Columns.GridColumn tennv;
        private DevExpress.XtraGrid.Columns.GridColumn tinhtrang;
        private DevExpress.XtraGrid.Columns.GridColumn sdt;
        private DevExpress.XtraGrid.Columns.GridColumn email;
    }
}