using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using muhasebe_otomasyon.Entity;

namespace muhasebe_otomasyon.formlar
{
    public partial class personelsil : Form
    {
        public personelsil()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        void personellistele()
        {
            var degerler = (from x in db.DBpersonel select new { x.ID, x.personelad, x.personelprim, x.personelmail, x.personeliban }).ToList();
            personeleklegrid.DataSource = degerler;
        }
        private void personelsil_Load(object sender, EventArgs e)
        {
            personellistele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(idtext.Text);
            var deger = db.DBpersonel.Find(x);
            db.DBpersonel.Remove(deger);
            db.SaveChanges();
            personellistele();
            XtraMessageBox.Show("Personel Başarılı Bir Şekilde Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            idtext.Text = "";

        }
    }
}
