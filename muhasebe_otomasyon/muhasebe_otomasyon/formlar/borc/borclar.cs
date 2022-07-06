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

namespace muhasebe_otomasyon.formlar.borc
{
    public partial class borclar : Form
    {
        public borclar()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        void borclistele()
        {
            var deger = (from x in db.DBborc select new { x.ID, x.ad_soyad, x.tel, x.adres, x.miktar }).ToList();
            borcgrid.DataSource = deger;
        }
        private void borclar_Load(object sender, EventArgs e)
        {
            borclistele();
        }
    }
}
