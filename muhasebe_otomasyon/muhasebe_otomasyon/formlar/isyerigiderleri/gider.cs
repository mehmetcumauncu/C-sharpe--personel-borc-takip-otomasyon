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
    public partial class gider : Form
    {
        muhasebemEntities db = new muhasebemEntities();
        public gider()
        {
            InitializeComponent();
        }
        void giderlistele()
        {
            var degerler = (from x in db.DBgider select new { x.ID, x.giderad, x.gidertutar, x.gidertarih, x.personel, x.gideracıklama }).ToList() ;
            gidergirdkontrol.DataSource = degerler;
        }
        private void gider_Load(object sender, EventArgs e)
        {
            giderlistele();
        }
    }
}
