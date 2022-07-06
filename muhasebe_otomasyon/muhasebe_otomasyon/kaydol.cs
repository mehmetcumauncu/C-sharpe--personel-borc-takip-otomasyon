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

namespace muhasebe_otomasyon
{
    public partial class kaydol : Form
    {
        public kaydol()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                
                con = new SqlConnection("server=DESKTOP-K3MG0D2\\MCU; Initial Catalog=muhasebem;Integrated Security=SSPI");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into DBkullanici(kullaniciad,sifre,mail) values" +
                    " ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                XtraMessageBox.Show("Kullanıcı Başarılı Bir Şekilde Kaydoldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch
            {
                XtraMessageBox.Show("GİRMİŞ OLDUĞUNUZ BİLGİLERİ KONTROL EDİNİZ.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            this.Hide();
        }

        private void kaydol_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
