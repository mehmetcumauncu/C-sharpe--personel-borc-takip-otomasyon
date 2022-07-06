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

namespace muhasebe_otomasyon.formlar.borc
{
    public partial class borcekle : Form
    {
        public borcekle()
        {
            InitializeComponent();
        }
        muhasebemEntities db = new muhasebemEntities();
        void borclistele()
        {
            var deger = (from x in db.DBborc select new { x.ID, x.ad_soyad, x.tel, x.adres, x.miktar }).ToList();
            gridControl1.DataSource = deger;
        }
        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void borcekle_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox2.Text.ToUpper();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
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
                SqlCommand komut = new SqlCommand("SELECT*FROM DBborc WHERE ID='" + textBox1.Text + "'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];
                baglanti.Close();
            }else if (radioButton2.Checked)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT*FROM DBborc WHERE ad_soyad='" + textBox2.Text + "'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
                
                   // XtraMessageBox.Show("MÜŞTERİ BULUNAMADI.YENİ MÜŞTERİ KAYDI YAPINIZ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                
                gridControl1.DataSource = ds.Tables[0];
               
                baglanti.Close();
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                 XtraMessageBox.Show("DEĞER GİRMEDİNİZ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            formlar.borc.islemyap frm = new formlar.borc.islemyap();
            frm.Show();
        }
        int eskimiktar;
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                if (radioButton1.Checked) // tc ile ise 
                {
                    /*int yeniborc;
                    SqlCommand komut = new SqlCommand("SELECT miktar FROM DBborc WHERE ID='" + textBox1.Text + "'", baglanti);
                    SqlDataReader veri = komut.ExecuteReader();
                    yeniborc = Convert.ToInt32(veri["miktar"]) + Convert.ToInt32(textBox3.Text);
                    SqlCommand upp = new SqlCommand("UPDATE DBborc SET miktar ='" + yeniborc + "' WHERE ID='" + textBox1.Text + "'", baglanti);
                    XtraMessageBox.Show("OLdUUUGGGG.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    
                
                }
           }
            catch(Exception HATA)
            {
                MessageBox.Show(HATA.Message);

            }
            finally
           {
                baglanti.Close();
           }
        }

        private void simpleButton3_Click(object sender, EventArgs e)//sil
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            gridControl1.DataSource = "";
        }
    }
}
