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
    public partial class giderguncelle : Form
    {
        public giderguncelle()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        void giderlistele()
        {
            var degerler = (from x in db.DBgider select new { x.ID, x.giderad, x.gidertutar, x.gidertarih, x.personel, x.gideracıklama }).ToList();
            giderguncellegrid.DataSource = degerler;
        }
        private void giderguncelle_Load(object sender, EventArgs e)
        {
            giderlistele();

            var personel = (from x in db.DBpersonel
                            select new
                            {
                                x.ID,
                                x.personelad
                            }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "personelad";
            lookUpEdit1.Properties.DataSource = personel;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(idtext.Text);
            var deger = db.DBgider.Find(x);
            deger.giderad = giderad.Text;
            deger.gidertutar = Convert.ToInt32( gidertutar.Text);
            deger.gidertarih= date.DateTime;
            deger.personel= int.Parse(lookUpEdit1.EditValue.ToString());
            deger.gideracıklama = gideraciklama.Text;
            db.SaveChanges();
            giderlistele();
            XtraMessageBox.Show("Gider Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderad.Text = "";
            gidertutar.Text = "";
            gideraciklama.Text = "";
            date.Text = "";
            lookUpEdit1.EditValue = "";
            idtext.Text = "";
            
        }
    }
}
