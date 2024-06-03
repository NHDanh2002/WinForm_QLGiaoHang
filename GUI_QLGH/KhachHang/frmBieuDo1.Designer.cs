
namespace GUI_QLGH.KhachHang
{
    partial class frmBieuDo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBieuDo1));
            this.grbBieudo = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grbBieudo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBieudo
            // 
            this.grbBieudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbBieudo.Location = new System.Drawing.Point(0, 0);
            this.grbBieudo.Name = "grbBieudo";
            this.grbBieudo.Size = new System.Drawing.Size(1061, 558);
            this.grbBieudo.TabIndex = 0;
            // 
            // frmBieuDo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 558);
            this.Controls.Add(this.grbBieudo);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmBieuDo1.IconOptions.LargeImage")));
            this.Name = "frmBieuDo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu đồ";
            this.Load += new System.EventHandler(this.frmBieuDo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbBieudo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbBieudo;
    }
}