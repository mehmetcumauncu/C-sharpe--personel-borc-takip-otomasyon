
namespace muhasebe_otomasyon.formlar.police
{
    partial class policeler
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
            this.policegrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.policegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // policegrid
            // 
            this.policegrid.Location = new System.Drawing.Point(1, -1);
            this.policegrid.MainView = this.gridView1;
            this.policegrid.Name = "policegrid";
            this.policegrid.Size = new System.Drawing.Size(968, 326);
            this.policegrid.TabIndex = 0;
            this.policegrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.policegrid;
            this.gridView1.Name = "gridView1";
            // 
            // policeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 326);
            this.Controls.Add(this.policegrid);
            this.Name = "policeler";
            this.Text = "POLİÇELER";
            this.Load += new System.EventHandler(this.policeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl policegrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}