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

namespace muhasebe_otomasyon.formlar.police
{
    public partial class policeekle : Form
    {
        public policeekle()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int netprim=Convert.ToInt32( netprimtext.Text);
            int urunyuzde = Convert.ToInt32(urunyuzdetext.Text);
            int kar = netprim * urunyuzde / 100 ;
            kartext.Text = kar.ToString() ;
        }

        private void policeekle_Load(object sender, EventArgs e)
        {
            var personel = (from x in db.DBpersonel
                            select new
                            {
                                x.ID,
                                x.personelad
                            }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "personelad";
            lookUpEdit1.Properties.DataSource = personel;

            var urun = (from y in db.DBurun
                        select new
                        {
                            y.ID,
                            y.urunad
                        }).ToList();
            lookUpEdit2.Properties.ValueMember = "ID";
            lookUpEdit2.Properties.DisplayMember = "urunad";
            lookUpEdit2.Properties.DataSource = urun;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DBmusteri m = new DBmusteri();
            m.adsoyad = adtext.Text;
            m.tc = tctext.Text;
            m.plaka = plakatext.Text;
            m.belgerino = serinotext.Text;
            m.iletisim = iletisimtext.Text;
            m.personel = int.Parse(lookUpEdit1.EditValue.ToString());
            m.urun = int.Parse(lookUpEdit2.EditValue.ToString());
            m.baslangictarih = baslamadate.DateTime;
            m.bitistarih = bitisdate.DateTime;
            m.urunyuzde =Convert.ToInt32( urunyuzdetext.Text);
            m.netprim = Convert.ToInt32(netprimtext.Text);
            m.brütprim = Convert.ToInt32(brutprimtext.Text);
            m.kar = Convert.ToInt32(kartext.Text);
            db.DBmusteri.Add(m);
            db.SaveChanges();

            XtraMessageBox.Show("Poliçe Başarılı Bir Şekilde Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
