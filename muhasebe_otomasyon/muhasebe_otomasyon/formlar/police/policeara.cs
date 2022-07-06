using DevExpress.XtraEditors;
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

namespace muhasebe_otomasyon.formlar.police
{
    public partial class policeara : Form
    {
        public policeara()
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
            gridControl1.DataSource = police;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox2.BackColor = Color.Gray;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox1.BackColor = Color.Gray;
                textBox2.BackColor = Color.White;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox1.BackColor = Color.Gray;
                textBox2.BackColor = Color.White;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox2.BackColor = Color.Gray;
                textBox1.BackColor = Color.White;
            }
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-K3MG0D2\MCU;Initial Catalog=muhasebem;Integrated Security=True");

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT*FROM DBmusteri WHERE tc='" + textBox1.Text + "'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else if (radioButton2.Checked)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT*FROM DBmusteri WHERE plaka='" + textBox2.Text + "'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];

                baglanti.Close();
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    XtraMessageBox.Show("DEĞER GİRMEDİNİZ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
