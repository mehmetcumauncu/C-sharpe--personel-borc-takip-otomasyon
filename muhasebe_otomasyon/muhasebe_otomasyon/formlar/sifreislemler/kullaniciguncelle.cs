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

namespace muhasebe_otomasyon.formlar.sifreislemler
{
    public partial class kullaniciguncelle : Form
    {
        public kullaniciguncelle()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        void kullanicilistele()
        {
            var kullanici = (from x in db.DBkullanici
                             select new
                             {
                                 x.ID,
                                 x.kullaniciad,
                                 x.mail,
                                 x.sifre
                             }
                ).ToList();
            giderguncellegrid.DataSource = kullanici;
        }
        private void kullaniciguncelle_Load(object sender, EventArgs e)
        {
            kullanicilistele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(idtext.Text);
            var deger = db.DBkullanici.Find(x);
            deger.kullaniciad = giderad.Text;
            deger.sifre = textEdit1.Text;
            deger.mail = gidertutar.Text;
            
            db.SaveChanges();
            kullanicilistele();
            XtraMessageBox.Show("Kullanıcı Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderad.Text = "";
            gidertutar.Text = "";
            textEdit1.Text = "";
            
            idtext.Text = "";
        }
    }
}
