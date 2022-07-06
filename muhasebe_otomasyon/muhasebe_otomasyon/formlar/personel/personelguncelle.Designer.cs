
namespace muhasebe_otomasyon.formlar
{
    partial class personelguncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelguncelle));
            this.personeleklegrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.idtext = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.mail = new DevExpress.XtraEditors.TextEdit();
            this.prim = new DevExpress.XtraEditors.TextEdit();
            this.adtext = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.iban = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.personeleklegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idtext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adtext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iban.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // personeleklegrid
            // 
            this.personeleklegrid.Location = new System.Drawing.Point(266, 2);
            this.personeleklegrid.MainView = this.gridView1;
            this.personeleklegrid.Name = "personeleklegrid";
            this.personeleklegrid.Size = new System.Drawing.Size(700, 322);
            this.personeleklegrid.TabIndex = 1;
            this.personeleklegrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.personeleklegrid;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.iban);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.idtext);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.prim);
            this.groupBox1.Controls.Add(this.adtext);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(-5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 320);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(100, 76);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 18);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "ID:";
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(129, 77);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(130, 20);
            this.idtext.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(79, 179);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 18);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "IBAN:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(86, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Mail:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(49, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 18);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Ad Soyad:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(129, 206);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(130, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "GÜNCELLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(129, 155);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(130, 20);
            this.mail.TabIndex = 3;
            // 
            // prim
            // 
            this.prim.Location = new System.Drawing.Point(129, 129);
            this.prim.Name = "prim";
            this.prim.Size = new System.Drawing.Size(130, 20);
            this.prim.TabIndex = 2;
            // 
            // adtext
            // 
            this.adtext.Location = new System.Drawing.Point(129, 103);
            this.adtext.Name = "adtext";
            this.adtext.Size = new System.Drawing.Size(130, 20);
            this.adtext.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(230, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "PERSONEL GÜNCELLE";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(83, 129);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Prim:";
            // 
            // iban
            // 
            this.iban.Location = new System.Drawing.Point(129, 181);
            this.iban.Name = "iban";
            this.iban.Size = new System.Drawing.Size(130, 20);
            this.iban.TabIndex = 11;
            // 
            // personelguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.personeleklegrid);
            this.Name = "personelguncelle";
            this.Text = "Personel Güncelle";
            this.Load += new System.EventHandler(this.personelguncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personeleklegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idtext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adtext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iban.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl personeleklegrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit idtext;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit mail;
        private DevExpress.XtraEditors.TextEdit prim;
        private DevExpress.XtraEditors.TextEdit adtext;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit iban;
    }
}