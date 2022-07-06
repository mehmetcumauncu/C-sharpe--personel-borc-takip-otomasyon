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
    public partial class kullanicilar : Form
    {
        public kullanicilar()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        void kullanicilistele()
        {
            var kullanici=(from x in db.DBkullanici select new
            {
                x.ID,
                x.kullaniciad,
                x.mail,
                x.sifre
            }
                ).ToList();
            gridControl1.DataSource = kullanici;
        }
        private void kullanicilar_Load(object sender, EventArgs e)
        {
            kullanicilistele();
        }
    }
}
