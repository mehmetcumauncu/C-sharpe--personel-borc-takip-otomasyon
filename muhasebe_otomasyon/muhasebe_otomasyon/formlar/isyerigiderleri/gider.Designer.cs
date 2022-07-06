
namespace muhasebe_otomasyon.formlar
{
    partial class gider
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
            this.gidergirdkontrol = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gidergirdkontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gidergirdkontrol
            // 
            this.gidergirdkontrol.Location = new System.Drawing.Point(-1, 0);
            this.gidergirdkontrol.MainView = this.gridView1;
            this.gidergirdkontrol.Name = "gidergirdkontrol";
            this.gidergirdkontrol.Size = new System.Drawing.Size(971, 326);
            this.gidergirdkontrol.TabIndex = 0;
            this.gidergirdkontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gidergirdkontrol;
            this.gridView1.Name = "gridView1";
            // 
            // gider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 326);
            this.Controls.Add(this.gidergirdkontrol);
            this.Name = "gider";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.gider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gidergirdkontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gidergirdkontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}