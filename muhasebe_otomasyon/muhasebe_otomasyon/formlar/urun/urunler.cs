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
    public partial class urunler : Form
    {
        public urunler()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();

        void urunlistele()
        {
            var deger = (from x in db.DBurun select new { x.ID, x.urunad, x.urunyuzde , x.urunprim }).ToList();
            urungrid.DataSource = deger;
        }
        private void urunler_Load(object sender, EventArgs e)
        {
            urunlistele();
        }
    }
}
