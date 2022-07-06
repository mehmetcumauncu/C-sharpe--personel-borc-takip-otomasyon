using DevExpress.XtraEditors;

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
    public partial class borclukisi : Form
    {
        public borclukisi()
        {
            InitializeComponent();
        }
        
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con;
        SqlCommand cmd;
        
        private void gideradd_Click(object sender, EventArgs e)
        {
            try { 
            int miktar = 0;
            con = new SqlConnection("server=DESKTOP-K3MG0D2\\MCU; Initial Catalog=muhasebem;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into DBborc(ID,ad_soyad,tel,adres,miktar) values" +
                " ('" + tc.Text + "','" + ad.Text + "','" + tel.Text + "','" + adres.Text + "','" + miktar + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            XtraMessageBox.Show("Müşteri Başarılı Bir Şekilde Kaydoldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                XtraMessageBox.Show("GİRMİŞ OLDUĞUNUZ BİLGİLERİ KONTROL EDİNİZ.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
      
        private void tc_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ad_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void borclukisi_Load(object sender, EventArgs e)
        {
            ad.Text.ToUpper();
            adres.Text.ToUpper();
        }
    }
}
