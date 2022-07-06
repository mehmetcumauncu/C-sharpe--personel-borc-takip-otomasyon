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

namespace muhasebe_otomasyon.formlar
{
    public partial class personelguncelle : Form
    {
        public personelguncelle()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        void personellistele()
        {
            var degerler = (from x in db.DBpersonel select new { x.ID, x.personelad, x.personelprim, x.personelmail, x.personeliban }).ToList();
            personeleklegrid.DataSource = degerler;
        }
        private void personelguncelle_Load(object sender, EventArgs e)
        {
            personellistele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (prim.Text == "")
            {
                XtraMessageBox.Show("Prim Kısmı Boş Geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            int x = int.Parse(idtext.Text);
            var deger = db.DBpersonel.Find(x);
            deger.personelad = adtext.Text;
            deger.personelmail = mail.Text;
            deger.personeliban = iban.Text; 
            deger.personelprim = Convert.ToInt32(prim.Text ); 
            db.SaveChanges();
            personellistele();
            XtraMessageBox.Show("Personel Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            adtext.Text = "";
            prim.Text = "";
            mail.Text = "";
            idtext.Text = "";
            iban.Text = "";
            personellistele();
            }


        }
    }
}
