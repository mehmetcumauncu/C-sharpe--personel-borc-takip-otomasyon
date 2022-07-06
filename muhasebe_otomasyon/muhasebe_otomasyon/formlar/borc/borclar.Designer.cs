
namespace muhasebe_otomasyon.formlar.borc
{
    partial class borclar
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
            this.borcgrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.borcgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // borcgrid
            // 
            this.borcgrid.Location = new System.Drawing.Point(-1, 0);
            this.borcgrid.MainView = this.gridView1;
            this.borcgrid.Name = "borcgrid";
            this.borcgrid.Size = new System.Drawing.Size(971, 326);
            this.borcgrid.TabIndex = 1;
            this.borcgrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.borcgrid;
            this.gridView1.Name = "gridView1";
            // 
            // borclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 326);
            this.Controls.Add(this.borcgrid);
            this.Name = "borclar";
            this.Text = "BORÇLAR";
            this.Load += new System.EventHandler(this.borclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borcgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl borcgrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}