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

namespace muhasebe_otomasyon
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection con;
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
        muhasebemEntities db = new muhasebemEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("server=DESKTOP-K3MG0D2\\MCU; Initial Catalog=muhasebem;Integrated Security=SSPI");
            
            try
            {
                con.Open();
                string sql = "Select*From DBkullanici where kullaniciad=@adi AND sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("adi", textEdit2.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", textEdit1.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, con);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                    XtraMessageBox.Show("HOŞGELDİNİZ.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    XtraMessageBox.Show("GİRMİŞ OLDUĞUNUZ BİLGİLERİ KONTROL EDİNİZ.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("GİRMİŞ OLDUĞUNUZ BİLGİLERİ KONTROL EDİNİZ.","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kaydol kyt = new kaydol();
            kyt.Show();
        }
    }
}
