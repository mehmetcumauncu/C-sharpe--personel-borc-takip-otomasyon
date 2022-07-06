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
    public partial class personelekle : Form
    {
        public personelekle()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();

        void personellistele()
        {
            var degerler = (from x in db.DBpersonel select new { x.ID, x.personelad, x.personelprim, x.personelmail, x.personeliban }).ToList();
           personeleklegrid.DataSource = degerler;
        }
        private void personelekle_Load(object sender, EventArgs e)
        {
            personellistele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DBpersonel p = new DBpersonel();
            p.personelad = ad.Text;
            p.personelmail = mail.Text;
            p.personeliban = iban.Text;
            db.DBpersonel.Add(p);
            db.SaveChanges();
            
            XtraMessageBox.Show("Personel Başarılı Bir Şekilde Kaydedildi.", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            personellistele();
            ad.Text = "";
            mail.Text = "";
            iban.Text = "";

        }
    }
}
