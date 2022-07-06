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
    public partial class urunsil : Form
    {
        public urunsil()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();

        void urunlistele()
        {
            var deger = (from x in db.DBurun select new { x.ID, x.urunad, x.urunyuzde, x.urunprim }).ToList();
            urunsilgrid.DataSource = deger;
        }
        private void urunsil_Load(object sender, EventArgs e)
        {
            urunlistele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(idtext.Text);
            var deger = db.DBurun.Find(x);
            db.DBurun.Remove(deger);
            db.SaveChanges();
            urunlistele();
            XtraMessageBox.Show("Ürün Başarılı Bir Şekilde Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            idtext.Text = "";
        }
    }
}
