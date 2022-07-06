using muhasebe_otomasyon.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe_otomasyon.formlar
{
    public partial class personelistatistik : Form
    {
        public personelistatistik()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        private void chart1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-K3MG0D2\MCU;Initial Catalog=muhasebem;Integrated Security=True");
        private void personelistatistik_Load(object sender, EventArgs e)
        {
            this.chart2.Titles.Add("Personellerin Satış Primleri");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select personelad,personelprim From DBpersonel",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                chart1.Series["Personel Prim"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
                chart2.Series["Personel Prim"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
            }

           
            
            baglanti.Close();

            
        }
    }
}
