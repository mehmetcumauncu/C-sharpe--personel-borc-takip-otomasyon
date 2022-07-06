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
    public partial class policeler : Form
    {
        public policeler()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        void policelistele()
        {
            var police = (from x in db.DBmusteri
                          select new
                          {
                              x.ID,
                              x.adsoyad,
                              x.tc,
                              x.plaka,
                              x.belgerino,
                              x.iletisim,
                              x.personel,
                              x.urun,     
                              x.baslangictarih,
                              x.bitistarih,
                              x.urunyuzde,
                              x.netprim,
                              x.brütprim,
                              x.kar
                          }).ToList();
            policegrid.DataSource = police;
        }
        private void policeler_Load(object sender, EventArgs e)
        {
            policelistele();
        }
    }
}
