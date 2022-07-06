using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using muhasebe_otomasyon.Entity;


namespace muhasebe_otomasyon.formlar
{
    public partial class personel : Form
    {
        muhasebemEntities db = new muhasebemEntities();
        public personel()
        {
            InitializeComponent();
        }
       void personellistele()
        {
            var degerler = (from x in db.DBpersonel select new {x.ID, x.personelad, x.personelprim, x.personelmail, x.personeliban }).ToList();
            personelgridcontrol.DataSource = degerler;
        }
       
        private void personel_Load(object sender, EventArgs e)

        {
            personellistele();

        }
    }
}
