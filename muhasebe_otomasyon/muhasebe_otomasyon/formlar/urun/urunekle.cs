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
    public partial class urunekle : Form
    {
        public urunekle()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();

        void urunlistele()
        {
            var deger = (from x in db.DBurun select new { x.ID, x.urunad, x.urunyuzde, x.urunprim }).ToList();
            uruneklegrid.DataSource = deger;
        }
        private void urunekle_Load(object sender, EventArgs e)
        {
            urunlistele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int ilk = 0;
            DBurun k = new DBurun();
            k.urunad = ad.Text;
            k.urunyuzde =Convert.ToInt32( yuzde.Text);
            k.urunprim = ilk;
            db.DBurun.Add(k);
            db.SaveChanges();

            XtraMessageBox.Show("Ürün Başarılı Bir Şekilde Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunlistele();
            ad.Text = "";
            yuzde.Text = "";
        }
    }
}
