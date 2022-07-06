using DevExpress.XtraEditors;
using muhasebe_otomasyon.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe_otomasyon.formlar.urun
{
    public partial class urunguncelle : Form
    {
        public urunguncelle()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();

        void urunlistele()
        {
            var deger = (from x in db.DBurun select new { x.ID, x.urunad, x.urunyuzde, x.urunprim }).ToList();
            urunguncellegrid.DataSource = deger;
        }
        private void urunguncelle_Load(object sender, EventArgs e)
        {
            urunlistele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (prim.Text == "")
            {
                XtraMessageBox.Show("Prim Kısmı Boş Geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int x = int.Parse(idtext.Text);
                var deger = db.DBurun.Find(x);
                deger.urunad = adtext.Text;
                deger.urunprim =Convert.ToInt32( prim.Text);
                deger.urunyuzde =Convert.ToInt32( yuzde.Text);
                
            
                db.SaveChanges();
                urunlistele();
                XtraMessageBox.Show("Ürün Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adtext.Text = "";
                prim.Text = "";
                yuzde.Text = "";
                idtext.Text = "";
                
                urunlistele();
            }
        }
    }
}
