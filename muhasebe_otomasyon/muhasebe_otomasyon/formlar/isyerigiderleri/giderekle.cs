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
    public partial class giderekle : Form
    {
        public giderekle()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        void giderlistele()
        {
            var degerler = (from x in db.DBgider select new { x.ID, x.giderad, x.gidertutar, x.gidertarih, x.personel, x.gideracıklama }).ToList();
           gidereklegrid.DataSource = degerler;
        }
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void giderekle_Load(object sender, EventArgs e)
        {
            giderlistele();
            var personel = (from x in db.DBpersonel select new
            {
                x.ID,
                x.personelad
            }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "personelad";
            lookUpEdit1.Properties.DataSource = personel;
        }

        private void gideradd_Click(object sender, EventArgs e)
        {
            DBgider d = new DBgider();
            d.giderad = giderad.Text;
            d.gidertutar =Convert.ToInt32( gidertutar.Text);
            d.gidertarih = date.DateTime;
            d.personel = int.Parse( lookUpEdit1.EditValue.ToString());
            d.gideracıklama = gideraciklama.Text;
            db.DBgider.Add(d);
            db.SaveChanges();

            XtraMessageBox.Show("Gider Başarılı Bir Şekilde Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistele();

            giderad.Text="";
            gidertutar.Text = "";
            date.Text = "";
            lookUpEdit1.EditValue  = "";
            gideraciklama.Text="";
            
        }
    }
}
