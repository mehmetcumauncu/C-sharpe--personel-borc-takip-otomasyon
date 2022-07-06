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

namespace muhasebe_otomasyon.formlar.isyerigiderleri
{
    public partial class gidersil : Form
    {
        public gidersil()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        void giderlistele()
        {
            var degerler = (from x in db.DBgider select new { x.ID, x.giderad, x.gidertutar, x.gidertarih, x.personel, x.gideracıklama }).ToList();
            gidersilgrid.DataSource = degerler;
        }
        private void gidersil_Load(object sender, EventArgs e)
        {
            giderlistele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(idtext.Text);
            var deger = db.DBgider.Find(x);
            db.DBgider.Remove(deger);
            db.SaveChanges();
            giderlistele();
            XtraMessageBox.Show("Gider Başarılı Bir Şekilde Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            idtext.Text = "";
        }
    }
}
