
namespace muhasebe_otomasyon.formlar.urun
{
    partial class urunler
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
            this.urungrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.urungrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // urungrid
            // 
            this.urungrid.Location = new System.Drawing.Point(1, 3);
            this.urungrid.MainView = this.gridView1;
            this.urungrid.Name = "urungrid";
            this.urungrid.Size = new System.Drawing.Size(967, 321);
            this.urungrid.TabIndex = 1;
            this.urungrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.urungrid;
            this.gridView1.Name = "gridView1";
            // 
            // urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 326);
            this.Controls.Add(this.urungrid);
            this.Name = "urunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urungrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl urungrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}