
namespace GUI_QLGH.NhanVien
{
    partial class frmBieuDoDHLap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBieuDoDHLap));
            this.grbBieudo = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grbBieudo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBieudo
            // 
            this.grbBieudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbBieudo.Location = new System.Drawing.Point(0, 0);
            this.grbBieudo.Name = "grbBieudo";
            this.grbBieudo.Size = new System.Drawing.Size(928, 560);
            this.grbBieudo.TabIndex = 1;
            // 
            // frmBieuDoDHLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 560);
            this.Controls.Add(this.grbBieudo);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmBieuDoDHLap.IconOptions.LargeImage")));
            this.Name = "frmBieuDoDHLap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu đồ đơn hàng đã lập của từng nhân viên";
            this.Load += new System.EventHandler(this.frmBieuDoDHLap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbBieudo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbBieudo;
    }
}